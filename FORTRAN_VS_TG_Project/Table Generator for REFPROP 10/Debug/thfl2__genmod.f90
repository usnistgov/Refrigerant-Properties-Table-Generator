        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:30 2020
        MODULE THFL2__genmod
          INTERFACE 
            SUBROUTINE THFL2(T,H,Z,KSAT,PBUB,PDEW,DLBUB,DVDEW,YBUB,XDEW,&
     &P,DL,DV,X,Y,Q,IERR,HERR)
              REAL(KIND=8) :: T
              REAL(KIND=8) :: H
              REAL(KIND=8) :: Z(20)
              INTEGER(KIND=4) :: KSAT
              REAL(KIND=8) :: PBUB
              REAL(KIND=8) :: PDEW
              REAL(KIND=8) :: DLBUB
              REAL(KIND=8) :: DVDEW
              REAL(KIND=8) :: YBUB(20)
              REAL(KIND=8) :: XDEW(20)
              REAL(KIND=8) :: P
              REAL(KIND=8) :: DL
              REAL(KIND=8) :: DV
              REAL(KIND=8) :: X(20)
              REAL(KIND=8) :: Y(20)
              REAL(KIND=8) :: Q
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE THFL2
          END INTERFACE 
        END MODULE THFL2__genmod
