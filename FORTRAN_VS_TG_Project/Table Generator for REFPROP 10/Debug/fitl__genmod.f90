        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:57:52 2020
        MODULE FITL__genmod
          INTERFACE 
            SUBROUTINE FITL(N,M,MAXN,XPNTS,YPNTS,XVAL,YVAL,CMATRIX,IERR,&
     &HERR)
              INTEGER(KIND=4) :: MAXN
              INTEGER(KIND=4) :: N
              INTEGER(KIND=4) :: M
              REAL(KIND=8) :: XPNTS(*)
              REAL(KIND=8) :: YPNTS(*)
              REAL(KIND=8) :: XVAL
              REAL(KIND=8) :: YVAL
              REAL(KIND=8) :: CMATRIX(MAXN)
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE FITL
          END INTERFACE 
        END MODULE FITL__genmod
