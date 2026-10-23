c_2019-11-27; Table7.for, pad
C_2020-05-12; Table7.for pad
C##############################################################################
      subroutine tblmts
C
C--Purpose: to establishe the limits and increments
C           of the look-up table
c
c   The table selects the lower enthalpy limit to be the saturated
c   liquid enthalpy at the lower limit pressure (if below the critical
c   point).  If the lower limit pressure is above the critical point,
c   it chooses the lower limit enthalpy to have the saturated liquid
c   enthalpy at a saturation temperature which is 15 K below the critical
c   temperatures.  For the upper limit enthalpy value: it chooses
c   the enthalpy to correspond to T=430 K and specific volume estimated
c   from the ideal gas law.  
C##############################################################################
c
c_2019-11-27; Expanded to add logarithmic pressure steps (to linear steps)
c    klog=0 for linear pressure step; klog.ne.0 for logarithmic step 

      implicit double precision (a-h,o-z)

      parameter (ncmax=20)
	character*255 herr
      common/rdata/xw(ncmax),xm(ncmax),wmix,pcrit,tcrit,dcrit,
     1             f0(5,5),f1(5,5)
      common /tablim/ ptop,pbot,pstep,
     1        nppts,nhpts,ttop, tbot, hleft, hright, hstep, klog
              !klog=0 (linear) or klog.ne.0 for logarithmic pressure steps
      dimension xliq(ncmax),xvap(ncmax)

c   pressure increment
c   klog=0 for linear pressure step; klog.ne.0 for logarithmic step
      if (klog.eq.0) then 
          pstep=(ptop-pbot)/real(nppts-1)
        else
          pbotln=log(pbot)
          ptopln=log(ptop)
          pstep=(ptopln-pbotln)/real(nppts-1)
c          pnewln=pbotln+pstep*real(k)
c          ptab(i)=exp(pnewln) 
      endif  
c---------------------------------------------------------------      
      if (ptop .le. pcrit) then  
c       lower limit      
        call satp(pbot,xm,1,tbot,rhol,rhov,xliq,xvap,ierr,herr)
        call errmsg(ierr,herr)
        call enthal(tbot,rhol,xm,hleft)
c       upper limit
        call satt(tbot,xm,2,p,rhol,rhov,xliq,xvap,ierr,herr) 
	  t2=tbot+10.0d0
	  call entro(t2,rhov,xm,s2)
	  s2=1.2d0*s2

	  call psfl1(ptop,s2,xm,2,ttop,dtop,ierr,herr)
	  call errmsg (ierr,herr)
	  call enthal(ttop,dtop,xm,hright)

	  hstep = (hright - hleft)/(nhpts-1)
      endif
c---------------------------------------------------------------
      if (pbot .lt. pcrit .and. ptop .ge. pcrit) then
c       lower limit  
	  call satp(pbot,xm,1,tbot,rhol,rhov,xliq,xvap,ierr,herr)
        call errmsg(ierr,herr)
        call enthal(tbot,rhol,xm,hleft) 
c       upper limit        
        t2=tbot+10.0d0
        rho=rhov
        call tprho(t2,pbot,xm,2,1,rho,ierr,herr)
        call errmsg(ierr,herr)        
	  call entro(t2,rho,xm,s)
        call psfl1(ptop,s,xm,2,ttop,dvap,ierr,herr)
        call errmsg(ierr,herr)
	  call enthal(tbot,rhov,xm,h1)
	  call enthal(ttop,dvap,xm,h2)
	  hright=h1+1.3d0*(h2-h1)

        hstep = (hright - hleft)/(nhpts-1)
      endif
C---------------------------------------------------------------
      if (pbot .ge. pcrit .and. ptop .ge. pcrit) then
        ttop=430.0d0
	  tbot=tc-15.0d0
c       upper limit	 
	  vv2=8314.0d0*ttop/ptop
	  call entro(ttop,1.0d0/vv2,xm,s2)
	  call psfl1(ptop,s2,xm,2,tright,dright,ierr,herr)
	  call errmsg (ierr,herr)
	  call enthal(tright,dright,xm,hright)
c       lower limit	 
	  call satt(tbot,xm,1,p,rhol,rhov,xliq,xvap,ierr,herr)
	  call errmsg(ierr,herr)
	  call enthal(tbot,rhol,xm,hleft) 
	 
	  hstep = (hright - hleft)/(nhpts-1)
	 
      endif

	call satpos
	
c     calculate the temp. limit ---but need to discuss further!
      if(ptop .lt. pcrit) then
         call satp(pbot,xm,2,tbot,rhol,rhov,xliq,xvap,ierr,herr)
         call satp(ptop,xm,1,ttop,rhol,rhov,xliq,xvap,ierr,herr)
      endif
      
      if((pbot .lt. pcrit) .and. (ptop .ge. pcrit)) then
         call phflsh(pbot,hleft,xm,tbot,rho,rhol,   !temp.
     1               rhov,xliq,xvap,q,e,s,cv, 
     2               cp,vs,ierr,herr)
      endif
         	
 999  return
      end
         
c###############################################################################
c
	subroutine satpos
c
c     Establishes subscript positions (j) for saturated liquid and vapor
c     (jsatlq and jsatvp) in the table.
c     they depend on the vapor quality step (0.05 or 0.1).
c     jose a.r. parise, october 1991.
c
C##############################################################################
	implicit double precision (a-h,o-z)
	common /tablim/ ptop,pbot,pstep,nppts,nhpts,ttop,tbot,hleft,
     1                hright,hstep,klog
	common /jsat/ jsatlq,jsatvp
c
      jsatlq = nhpts+1
      jsatvp = nhpts+2
c
	return
	end

C##############################################################################
      subroutine wtable

C   This subroutine generates the look-up table for refrigerant
C   mixtures of up to five components.The look-table is bounded by the 
C   limits established in subroutine TBLMTS.
C
C   Note also that if the upper limit pressure is above the critical pressure
C   and the lower limit pressure is below the critical pressure, then a 
C   grid of data points using the critical pressure is automatically generated
C   by the program.  The intention of doing this is to improve iteration of
C   property values near the critical pressure.
C_2019-12-05; klog=0 for linear pressure step
C             klog.ne.0 for logarithmic pressure step
C##############################################################################
c
c_2019-11-27; cleaned (pad)
C_2020-05-12; Pressure level increased from 100 to 150 (pad)
c_2020-07-22; Number of fluids in a blend increased from 4 to 6 (ncb=6)
c
      implicit double precision (a-h,o-z) 
      parameter (ncmax=20,nfl=50, ncb=6)  !ncb = # compnents in the blend
      parameter (npl=150, nhl=102)
      character*255 hfiles(ncmax),hfmix
      character hrf*3, herr*255,refname*80
      character*255 tname,tname1
	character*10 href(0:nfl),hrfn(ncmax)
      common/ncomp/nc
      common/hrfn/hrfn
      common/fname/refname
      common/rdata/xw(ncmax),xm(ncmax),wmix,pcrit,tcrit,dcrit,
     1             f0(5,5),f1(5,5)
      common /tablim/ ptop,pbot,pstep,nppts,nhpts,ttop, 
     1        tbot, hleft, hright, hstep, klog
c     !klog=0 (linear) or klog.ne.0 for logarithmic pressure steps
      common /table/ ptab(150),xqtab(nhl,150),htab(nhl,150),
     1                ttab(nhl,150),vltab(nhl,150),xltab(nhl,150,ncb),
     2                vvtab(nhl,150),xvtab(nhl,150,ncb),vtab(nhl,150),
     3                cvtab(nhl,150),cptab(nhl,150),vstab(nhl,150),
     4               amltab(nhl,150),akltab(nhl,150),amvtab(nhl,150),
     5                akvtab(nhl,150)
     	common /jsat/ jsatlq,jsatvp
     	common /href1/ href
      common /href2/ mmax
      dimension xliq(ncmax),xvap(ncmax),ir(5),xl(ncmax),xv(ncmax)
      dimension xldew(ncmax),xvdew(ncmax),xlbub(ncmax),xvbub(ncmax)

C     create the file name of the mixture
!      mfile=''
!	do 100,i=1,nc
!	   mfile=adjustl(trim(mfile)//'-'//trim(hrfn(i)))
!100    continue
!      mfile(1:1)=''
     
      if(nc.eq.1) then
         do 2 k=2,21
         if(refname(k:k).eq.' ')then
             if(refname(k+1:k+1).eq.' ')then
                 tname=refname
             else
                 tname=hrfn(1)
             end if
             goto 5
          end if
    2    continue
         write(*,*)'Refrigerant name must not exeed 20 characters.'
         write(*,*)'This runs is being terminated.'
         pause
         stop
      else
         do 3 k=2,21  !nc > 1
    3    if(refname(k:k).eq.' ')goto 4
         write(*,*)'Refrigerant name must not exeed 20 characters.'
         write(*,*)'This runs is being terminated.'
         pause
         stop        
    4    tname=refname(1:k-1)
      end if
    5 continue 
      open (unit=12, file=trim(tname)//'.txt', status='unknown')
      close(unit=12, status='delete')
      open (unit=12, file=trim(tname)//'.txt', status='new')

      do 7 i=1,50
         do 7 j=1,150
         amltab(i,j)=1.d5
         akltab(i,j)=1.d5
         amvtab(i,j)=1.d5
         akvtab(i,j)=1.d5
7     continue
c-----write refrigerant mixture information into file
!      do 7 k=1,nc
!         hrfn(k)=trim(hrfn(k))
!7     continue    
!      write(12,900)(hrfn(k),k=1,nc)
      write(12,900)trim(tname)
900   format(1A,1x)
c 900   format(1A50,1x)      !900   format((1A6,1x))
      write (12,901) nc   !from common block /ncomp/   
	write (12,905) (ir(k),k=1,5)  !from common block /rdata/
      write (12,805) (xw(k),k=1,5)  !from common block /rdata1/
      do 450 k1=1,5
450   write (12,805) (f0(k1,k2),k2=1,5) !from common block /rdata1/
      do 451 k1=1,5
451   write (12,805) (f1(k1,k2),k2=1,5) !from common block /tablim/
      if (pcrit .gt. pbot .and. pcrit .lt. ptop) nppts = nppts+1
      write (12,1041) ptop,pbot,pstep,ttop,tbot,nppts
      write (12,1042) hleft,hright,hstep,nhpts
1041  format(5(d23.16,1x),i5)
1042  format(3(d23.16,1x),i5)
	write (12,902) jsatlq,jsatvp  !from common block /JSAT/
C     common block /UNITS/
	WRITE (12,938) 1,'C'
938   FORMAT (I2,1X,A1)
C
805   format (5(d23.16,1x))
901   format (I5,1x)
902   format (2(I5,1x))
905   format (5(I5,1x))

c-----Executing
      write (*,600)
600   format (' Executing...')
C===================================================================================
c------------------LARGE LOOP: stepping pressure from pbot to ptop------------------
      do 10 i = 1,nppts
	   ierr=0
	   herr='  '
c     Establish pressure levels
         k=i-1
         if (i .gt. 1 .and. pbot .lt. pcrit) then
		   if (ptab(i-1) .ge. pcrit) k=i-2
         end if
c
         if(klog.eq.0)then
           ptab(i)=pbot+pstep*real(k) ! 0 for linear pressure step
         else
c           ptab(i)=(pbot**(1.0d0-real(k)/(nppts-1)))  (nppts may be greater by 1)
c     1             *(ptop**(real(k)/(nppts-1)))
           pbotln=log(pbot)
           ptab(i)=exp(pbotln+pstep*real(k))      
         endif

        if(i.gt.1)then
           if( ptab(i-1).lt.pcrit .and. ptab(i).gt.pcrit)
     1        ptab(i) = pcrit
        endif
C        write(22,505)i,k,ptab(i)
C 505    format(' ',2i3,2f10.2)
        write (*,700) ptab(i)
700     format (1x,'  Pressure level: ',e13.5,'  kPa')
C-----------------------------------------------------------------------------------
c When Ptab is less than Pcrit
C-----------------------------------------------------------------------------------
         if (ptab(i) .lt. pcrit) then   !------
    	       !dew point--calculate h_vap & dew-point properties
	       call satp(ptab(i),xm,2,tdew,rholdew,rhovdew,xldew,xvdew,
     1                ierr,herr)
	       call errmsg(ierr,herr)
	       call enthal(tdew,rhovdew,xm,hvap)	       

	       !bubble point--calculate h_liq & bubble-point properties 
	       call satp(ptab(i),xm,1,tbub,rholbub,rhovbub,xlbub,xvbub,
     1                 ierr,herr)	       
	       call errmsg(ierr,herr)
	       call enthal(tbub,rholbub,xm,hliq)           
c---TEST
c         Plin=pbot+pstep*real(k)
c         plog=(pbot**(1.0d0-real(k)/(nppts-1)))
c     1             *(ptop**(real(k)/(nppts-1)))
c         write(22,522)i,plog,ptab(i),tbub
c522      format(' ',1i3,1x,4f8.2)
c
             do 20, j=1,nhpts ! ENTHALPY STEP LOOP for a given pressure------------
                htab(j,i) = hleft + hstep*(j-1)
                
c---------------Subcooled liquid region-----------------------------------
                if (htab(j,i) .lt. hliq) then  
                   call phflsh(ptab(i),htab(j,i),xm,ttab(j,i),rho,rhol,   !temp.
     1                         rhov,xliq,xvap,q,e,s,cvtab(j,i),
     2                         cptab(j,i),vstab(j,i),ierr,herr)   !Specific heats and velocity of sound
                   call errmsg(ierr,herr)                   

                   if(ttab(j,i) .lt. 100 .or. ierr .eq. -1) then
	                 xqtab(j,i) = 999
	                 goto 88
                   endif
                   xqtab(j,i)=(htab(j,i)-hliq)/(hvap-hliq) !quality
                   
! Add the following code to calculate subcooled region
! in order to be consistent with old version
! ---------------------------------------------------- 
      	         call satp(ptab(i),xm,1,t,rhol1,rhov1,xl,xv,ierr,herr)
	             call errmsg(ierr,herr)   
! ----------------------------------------------------                                       
                   do 710 k = 1,ncb  !was 4 2020-10-29
                       xvtab(j,i,k) = xv(k) !xvap(k) !composition for vapor phase
                       xltab(j,i,k) = xm(k) !xm(k)   !composition for liquid phase
710                continue     
                   vltab(j,i)=1.0d0/rhol
                   vvtab(j,i)=1.0d0/rhov1
	             vtab(j,i)=vltab(j,i) ! specific volume
    	          
	             call trnprp(ttab(j,i),1.0d0/vtab(j,i),xm,amltab(j,i), !Transport properties
     1                          akltab(j,i),ierr,herr)
     
                   amltab(j,i)=amltab(j,i)*1.0d-6
                   akltab(j,i)=akltab(j,i)*1.0d-3
                   amvtab(j,i)=0.0d0
                   akvtab(j,i)=0.0d0
                end if
                
c-------------------Two-phase region------------------------------------------
                if (htab(j,i).ge.hliq .and. htab(j,i).le.hvap) then
                  call phflsh(ptab(i),htab(j,i),xm,ttab(j,i),rho,rhol,   !temp.
     1                       rhov,xliq,xvap,xqtab(j,i),e,s,cvtab(j,i),
     2                       cptab(j,i),vstab(j,i),ierr,herr)           !Specific heats and velocity of sound
                  call errmsg(ierr,herr)
     
                  if(ttab(j,i) .lt. 100 .or. ierr .eq. -1) then
                     xqtab(j,i) = 999
                     goto 88
                  end if 
 
                  vltab(j,i)=1.0d0/rhol
                  vvtab(j,i)=1.0d0/rhov
                  vtab(j,i)=vltab(j,i)+xqtab(j,i)*(vvtab(j,i) ! differnet from 1.0/D of phflsh??
     1                        -vltab(j,i))

                  do 720 k = 1,ncb  !was 4 2020-10-29
                     xvtab(j,i,k) = xvap(k)
                     xltab(j,i,k) = xliq(k)
720               continue

	            call trnprp(ttab(j,i),1.0d0/vltab(j,i),xliq,     !Transport properties of liquid phase
     1	                     amltab(j,i),akltab(j,i),ierr,herr)
     	            call trnprp(ttab(j,i),1.0d0/vvtab(j,i),xvap,     !Transport properties of vapor phase
     1	                       amvtab(j,i),akvtab(j,i),ierr,herr)
     
                  amltab(j,i)=amltab(j,i)*1.0d-6
                  akltab(j,i)=akltab(j,i)*1.0d-3
                  amvtab(j,i)=amvtab(j,i)*1.0d-6
                  akvtab(j,i)=akvtab(j,i)*1.0d-3                    
                  cvtab(j,i)=0.d0  ! do not calculate for two-phase region
                  cptab(j,i)=0.d0
                  vstab(j,i)=0.d0                 
                endif
                
c-------------------superheated region------------------------------------------
                if (htab(j,i) .gt. hvap) then 
                   call phflsh(ptab(i),htab(j,i),xm,ttab(j,i),rho,rhol,   !temp.
     1                         rhov,xliq,xvap,q,e,s,cvtab(j,i),
     2                         cptab(j,i),vstab(j,i),ierr,herr)           !Specific heats and velocity of sound
                   call errmsg(ierr,herr)     
                   
                   if(ttab(j,i) .lt. 100 .or. ierr .eq. -1) then
	                 xqtab(j,i) = 999
	                 goto 88
                   endif
                   xqtab(j,i)=(htab(j,i)-hliq)/(hvap-hliq) !quality
                   
! Add the following code to calculate superheated region
! in order to be consistent with old version
! ---------------------------------------------------- 
                   call satp(ptab(i),xm,2,t,rhol1,rhov1,xl,xv,ierr,herr)
	             call errmsg(ierr,herr)
! ----------------------------------------------------                      
                                       
                   do 760 k = 1,ncb  !was 4 2020-10-29
                       xvtab(j,i,k) = xm(k) !xm(k) !composition for vapor phase
                       xltab(j,i,k) = xl(k) !xliq(k)   !composition for liquid phase
760                continue
                    
                   vltab(j,i)=1.0d0/rhol1
                   vvtab(j,i)=1.0d0/rhov
	             vtab(j,i)=vvtab(j,i) ! specific volume
    	          
	             call trnprp(ttab(j,i),1.0d0/vtab(j,i),xm,amvtab(j,i), !Transport properties
     1                          akvtab(j,i),ierr,herr)

                   amvtab(j,i)=amvtab(j,i)*1.0d-6
                   akvtab(j,i)=akvtab(j,i)*1.0d-3
                   amltab(j,i)=0.0
                   akltab(j,i)=0.0
                end if
                                 
88	          write (12,502) ptab(i),xqtab(j,i),htab(j,i),ttab(j,i),
     1                  vltab(j,i),vvtab(j,i),(xltab(j,i,k),k=1,ncb),
     2                  (xvtab(j,i,k),k=1,ncb),
     3                  vtab(j,i),cvtab(j,i),cptab(j,i),vstab(j,i),
     4                  amltab(j,i),akltab(j,i),amvtab(j,i),akvtab(j,i)
20              continue
         end if

C-----------------------------------------------------------------------------------
c In case that ptab < pcrit, add two rows for sat. liq. & vap. properties
C-----------------------------------------------------------------------------------
         if (ptab(i) .lt. pcrit) then  ! 
             htab(j,i) = hliq           ! write data for bubble pt.
             xqtab(j,i) = 0.d0

             call phflsh(ptab(i),htab(j,i),xm,ttab(j,i),rho,rhol,   !temp.
     1                   rhov,xliq,xvap,q,e,s,cvtab(j,i),
     2                   cptab(j,i),vstab(j,i),ierr,herr)     !Specific heats and velocity of sound
             call errmsg(ierr,herr) 
             
 	       call trnprp(ttab(j,i),rholbub,xm,amltab(j,i), !Transport properties
     1                   akltab(j,i),ierr,herr)
             call errmsg(ierr,herr)
             amltab(j,i)=amltab(j,i)*1.0d-6
             akltab(j,i)=akltab(j,i)*1.0d-3              
             
             call trnprp(ttab(j,i),rhovbub,xvbub,amvtab(j,i), !Transport properties
     1                   akvtab(j,i),ierr,herr)
             call errmsg(ierr,herr)  
             amvtab(j,i)=amvtab(j,i)*1.0d-6
             akvtab(j,i)=akvtab(j,i)*1.0d-3             
             ttab(j,i)= tbub
             vvtab(j,i)=1.0d0/rhovbub
             vltab(j,i)=1.0d0/rholbub
             vtab(j,i)=vltab(j,i)             
             
             do 731 k=1,ncb
                xvtab(j,i,k)=xvbub(k)
                xltab(j,i,k)=xm(k)
731          continue
             
             write (12,502) ptab(i),xqtab(j,i),htab(j,i),
     1           ttab(j,i),vtab(j,i),vvtab(j,i),
     2           (xltab(j,i,k),k=1,ncb),(xvtab(j,i,k),k=1,ncb),
     3           vtab(j,i),cvtab(j,i),cptab(j,i),
     4           vstab(j,i),amltab(j,i),akltab(j,i),
     5           amvtab(j,i),akvtab(j,i)

             htab(j+1,i) = hvap            ! write data for dew pt.
             xqtab(j+1,i) = 1.d0
             
             call phflsh(ptab(i),htab(j+1,i),xm,ttab(j+1,i),rho,rhol,   !temp.
     1                   rhov,xliq,xvap,q,e,s,cvtab(j+1,i),
     2                   cptab(j+1,i),vstab(j+1,i),ierr,herr)     !Specific heats and velocity of sound
             call errmsg(ierr,herr) 
             
 	       call trnprp(ttab(j+1,i),rholdew,xldew,amltab(j+1,i),  !Transport properties
     1                   akltab(j+1,i),ierr,herr)
             call errmsg(ierr,herr)
             amltab(j+1,i)=amltab(j+1,i)*1.0d-6
             akltab(j+1,i)=akltab(j+1,i)*1.0d-3              
             
             call trnprp(ttab(j+1,i),rhovdew,xm,amvtab(j+1,i), !Transport properties
     1                   akvtab(j+1,i),ierr,herr)
             call errmsg(ierr,herr) 
             amvtab(j+1,i)=amvtab(j+1,i)*1.0d-6
             akvtab(j+1,i)=akvtab(j+1,i)*1.0d-3             
     
             ttab(j+1,i)= tdew
             vvtab(j+1,i)=1.0d0/rhovdew
             vltab(j+1,i)=1.0d0/rholdew
             vtab(j+1,i)=vvtab(j,i)             
             
             do 732 k=1,ncb
                xvtab(j+1,i,k)=xm(k)
                xltab(j+1,i,k)=xldew(k)
732          continue             

             write (12,502) ptab(i),xqtab(j+1,i),htab(j+1,i),
     1          ttab(j+1,i),vltab(j+1,i),vvtab(j+1,i),
     2          (xltab(j+1,i,k),k=1,ncb),(xvtab(j+1,i,k),k=1,ncb),
     3          vtab(j+1,i),cvtab(j+1,i),cptab(j+1,i),
     4          vstab(j+1,i),amltab(j+1,i),akltab(j+1,i),
     5          amvtab(j+1,i),akvtab(j+1,i)	
         end if

C-----------------------------------------------------------------------------------
c Ptab is .ge. Pcrit
C-----------------------------------------------------------------------------------
	   if (ptab(i) .ge. pcrit-1.d-6) then 
		   do 22 j = 1, nhpts+2   !Enthalpy step loop
             htab(j,i) = hleft + hstep*(j-1) 
			  
c The following lines are used to calculate properties for grid points that have the critical pressure.  
c This is done because if the normal PHFLSH calculation is called, they will blow-up.

             if (dabs(ptab(i) - pcrit) .lt. 1.d-6) then    !ptab = pcrit, critical pressure
                dmid=dcrit
                call enthal(tcrit,dmid,xm,hcrit)
                if(j .eq. jsatlq .or. j .eq. jsatvp) then  !critical point
                   call cvcp(tcrit,0.95*dcrit,xm,cv,cp)
                   tmid=tcrit
	             hmid=hcrit
                   goto 810
                end if

                call PHFLSH (pcrit,htab(j,i),xm,tmid,Dmid,Dl,Dv,
     1                         xliq,xvap,q,e,s,cv,cp,w,ierr,herr)
                call errmsg(ierr,herr)
810	          v = 1.d0/dmid
	          do 820 k=1,ncb
	             xvtab(j,i,k) = xvap(k)
	             xltab(j,i,k) = xliq(k)   
820             continue
   	          call trnprp(tmid,dmid,xm,am,ak,ierr,herr)

C----Viscosity from micropoise to Pa.s (kg/m.s)
	          am=am*1.d-06
C----Thermal conductivity from W/mK to kW/mK
	          ak=ak*1.d-03
	          xq = 1.d0

	          if (ierr .gt. 200 .or. ierr .eq. -1) xq=999.d0
                if (dabs(ptab(i)) .gt. 1.d7) ptab(i)=999.
                if (dabs(xq) .gt. 1.d7) xq=999.
                if (dabs(htab(j,i)) .gt. 1.d7) htab(j,i)=999.
                if (dabs(tmid) .gt. 1.d7) tmid=999.
                if (dabs(v) .gt. 1.d7) v=999.   !  need correction  
                if (dabs(xltab(j,i,1)) .gt. 1.d7) xltab(j,i,1)=999.
                if (dabs(xltab(j,i,2)) .gt. 1.d7) xltab(j,i,2)=999.
                if (dabs(xltab(j,i,3)) .gt. 1.d7) xltab(j,i,3)=999.
                if (dabs(xltab(j,i,4)) .gt. 1.d7) xltab(j,i,4)=999.
                if (dabs(xvtab(j,i,1)) .gt. 1.d7) xvtab(j,i,1)=999.
                if (dabs(xvtab(j,i,2)) .gt. 1.d7) xvtab(j,i,2)=999.
                if (dabs(xvtab(j,i,3)) .gt. 1.d7) xvtab(j,i,3)=999.
                if (dabs(xvtab(j,i,4)) .gt. 1.d7) xvtab(j,i,4)=999.
                if (dabs(cv) .gt. 1.d7) cv=999.
                if (dabs(cp) .gt. 1.d7) cp=999.
                if (dabs(am) .gt. 1.d7) am=999.
                if (dabs(ak) .gt. 1.d7) ak=999.
               
                write (12,502) ptab(i),xq,htab(j,i),tmid,v,v,
     1                (xltab(j,i,k),k=1,ncb),(xvtab(j,i,k),k=1,ncb),
     2                v,cv,cp,vstab(j,i),am,ak,am,ak
                goto 22
             end if	!End of calculations for ptab = pcrit		  

             if (j .le. nhpts) then   ! Start calculations for ptab > pcrit
                call phflsh(ptab(i),htab(j,i),xm,ttab(j,i),rho,rhol,   !temp.
     1                       rhov,xliq,xvap,q,e,s,cvtab(j,i),
     2                       cptab(j,i),vstab(j,i),ierr,herr)    !Specific heats and velocity of sound
                call errmsg(ierr,herr)
                if(ttab(j,i) .lt. 100 .or. ierr .eq. -1) then
	              xqtab(j,i) = 999
	              goto 90
                end if
                vltab(j,i)=1.0d0/rhol
                vvtab(j,i)=1.0d0/rhov
                vtab(j,i)=vvtab(j,i)
                   
	          call trnprp(ttab(j,i),1.0d0/vtab(j,i),xm,amvtab(j,i), !Transport properties
     1                      akvtab(j,i),ierr,herr)
     
                amvtab(j,i)=amvtab(j,i)*1.0d-6
                akvtab(j,i)=akvtab(j,i)*1.0d-3
                amltab(j,i)=amvtab(j,i)
                akltab(j,i)=akvtab(j,i)  
             else    ! for the last two rows, sat. property for p>pcrit do not exist, so 999 is set to the values.
	          ttab(j,i)=999.
	          vtab(j,i)=999.
                vltab(j,i)=999.
                vvtab(j,i)=999.
                cvtab(j,i)=999.
                cptab(j,i)=999.
                vstab(j,i)=999.
                amltab(j,i)=999.
                akltab(j,i)=999.
                amvtab(j,i)=999.
		      akvtab(j,i)=999.
             end if
             xqtab(j,i)=1.0d0
                
             do 860 k=1,ncb
                xvtab(j,i,k) = xm(k)
                xltab(j,i,k) = xm(k)
860          continue

90           write (12,502) ptab(i),xqtab(j,i),htab(j,i),ttab(j,i),
     1          vltab(j,i),vvtab(j,i),(xltab(j,i,k),k=1,ncb),
     2          (xvtab(j,i,k),k=1,ncb),
     3          vtab(j,i),cvtab(j,i),cptab(j,i),vstab(j,i),
     4          amltab(j,i),akltab(j,i),amvtab(j,i),akvtab(j,i)
22           continue
       end if   !End of calculations for Ptab .ge. Pcrit
502    format(22d23.16) 

10    continue   !END OF THE LARGE (PRESSURE) LOOP 
C===================================================================================
      write(12,901)klog   !2020-06-3
      write (12,910) (hrfn(k),k=1,nc)  !from common block /rdata/
910   format(10(10A,1x))
      write (12,912) (xw(k),k=1,nc)  !from common block /rdata1/
912   format (10(d23.16,1x))
      write(12,915)refname
915   format(1A80)
      return
      end