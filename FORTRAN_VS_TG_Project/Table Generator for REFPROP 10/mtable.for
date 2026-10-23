      program main mtable
C----------------------------------------------------------------------
C--user-generated table of mixtures for EVAP-COND
C--Written by Yun-Guang Chen   02/09/2012
C--REFPROP 9.0 subroutines are used
C
c  New:
c_2019-11-27; Expanded to add logarithmic pressure steps (to linear steps)
c    klog=0 for linear pressure step; klog.ne.0 for logarithmic step
c_2020-05-18; Number of pressure points increased from 100 to 150
c_2020-07-22; Number of fluids in a blend increased from 4 to 6
C----------------------------------------------------------------------
      implicit double precision (a-h,o-z)

      parameter (ncmax=20)
      parameter (npl=150, nhl=102, ncb=6)
      character*255 hfiles(ncmax),hfmix
      character hrf*3, herr*255, refname*80
c      character*1 hdelim
      character*3 hdir 
      character*10 hrfn(ncmax)
      character*14 hrfnfld(6)   !pad
c--from REFLEAK
c	character*54 UserApplicationFolder   !was 240
      data hdelim/'\'/ 
      common/ncomp/nc
      common/hrfn/hrfn
      common/fname/refname
      common/rdata/xw(ncmax),xm(ncmax),wmix,pcrit,tcrit,dcrit,
     1             f0(5,5),f1(5,5)
      common /table/ ptab(150),xqtab(nhl,150),htab(nhl,150),
     1                ttab(nhl,150),vltab(nhl,150),xltab(nhl,150,ncb),
     2                vvtab(nhl,150),xvtab(nhl,150,ncb),vtab(nhl,150),
     3                cvtab(nhl,150),cptab(nhl,150),vstab(nhl,150),
     4               amltab(nhl,150),akltab(nhl,150),amvtab(nhl,150),
     5                akvtab(nhl,150)
      common /tablim/ ptop,pbot,pstep,
     1        nppts,nhpts,ttop, tbot, hleft, hright, hstep, klog
   
	open (unit=10, file='tableinfo.txt', status='old')
	rewind 10

	read(10,890) refname    !refrigerant 'short' name
  890 format(1A80)
	read(10,*) nc
	read(10,*) (hrfnfld(i),i=1,nc)   !refrigerant file name with .fld
c 	read(10,*) (hrfn(i),i=1,nc)   !refrigerant file name without .fld     
	read(10,*) (xw(i),i=1,nc)
	read(10,*) pbot,ptop
	read(10,*) nppts,nhpts
      read(10,*) klog !klog=0 for linear; klog.ne.0 for logarithmic pressure step
c      klog=0 

      do 20 i=1,nc  !drop .fld from the file name
      Icount=0
      do 15 k=1,7
      kk=15-k
      if(hrfnfld(i)(kk:kk).eq.'d'.or.hrfnfld(i)(kk:kk).eq.'D')goto 16
   15 icount=icount +1
   16 idrop=icount+4
   20 hrfn(i)=hrfnfld(i)(1:14-idrop)     !refrigerant file name without .fld
      
      DO 24 I=1,NC
   24 hfiles(i)='fluids\'//trim(hrfn(i))//'.fld'
      hfmix='fluids\HMX.bnc'
      hrf='ASH'    
	call SETUP (nc,hfiles,hfmix,hrf,ierr,herr)
      if(ierr.ne.0)call LISTherr(herr)      
	call errmsg(ierr,herr)
      if (ierr.gt.0) then
        write (*,*) herr
        write (*,*) "This run is being terminated."
        GO TO 100
      end if
c      
      call INFO (1,wm,ttp,tnbp,tc,pc,dc,zc,acf,dip,rgas)     
      tcrit=tc
      pcrit=pc
      dcrit=dc
c	
	call xmole (xw,xm,wmix)
	call critp(xm,tcrit,pcrit,dcrit,ierr,herr)
	call errmsg(ierr,herr)
      
      if (ierr.gt.0) then
        write (*,*) herr
        write (*,*) "This run is being terminated."
        GO TO 100
      end if

c     calculate the upper and lower limit of pressure and enthalpy	
	call tblmts
c     generate the table	
      call wtable
      
100   write(*,*)
      write (*,*)"Press 'Enter' key to exit..."
      read (*,*)	
      close (10)
      STOP
      END
c
      subroutine LISTherr(herr)
c
      character*255 herr
      WRITE(*,900)HERR
  900 FORMAT('Diagnostic note: ',1A255)
      write (*,*)
      write (*,*)"Press 'Enter' key to continue..."
      read (*,*)	
      return
      end