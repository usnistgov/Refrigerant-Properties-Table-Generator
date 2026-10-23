        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:29 2020
        MODULE PSFL2__genmod
          INTERFACE 
            SUBROUTINE PSFL2(P,S,Z,KSAT,TBUB,TDEW,DLBUB,DVDEW,YBUB,XDEW,&
     &T,DL,DV,X,Y,Q,IERR,HERR)
              REAL(KIND=8) :: P
              REAL(KIND=8) :: S
              REAL(KIND=8) :: Z(20)
              INTEGER(KIND=4) :: KSAT
              REAL(KIND=8) :: TBUB
              REAL(KIND=8) :: TDEW
              REAL(KIND=8) :: DLBUB
              REAL(KIND=8) :: DVDEW
              REAL(KIND=8) :: YBUB(20)
              REAL(KIND=8) :: XDEW(20)
              REAL(KIND=8) :: T
              REAL(KIND=8) :: DL
              REAL(KIND=8) :: DV
              REAL(KIND=8) :: X(20)
              REAL(KIND=8) :: Y(20)
              REAL(KIND=8) :: Q
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE PSFL2
          END INTERFACE 
        END MODULE PSFL2__genmod
