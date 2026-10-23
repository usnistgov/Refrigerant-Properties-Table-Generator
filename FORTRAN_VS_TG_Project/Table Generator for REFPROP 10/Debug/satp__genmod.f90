        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:39 2020
        MODULE SATP__genmod
          INTERFACE 
            SUBROUTINE SATP(P,Z,KPH,T,DL,DV,X,Y,IERR,HERR)
              REAL(KIND=8) :: P
              REAL(KIND=8) :: Z(20)
              INTEGER(KIND=4) :: KPH
              REAL(KIND=8) :: T
              REAL(KIND=8) :: DL
              REAL(KIND=8) :: DV
              REAL(KIND=8) :: X(20)
              REAL(KIND=8) :: Y(20)
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE SATP
          END INTERFACE 
        END MODULE SATP__genmod
