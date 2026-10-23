        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:28 2020
        MODULE TPRHO__genmod
          INTERFACE 
            SUBROUTINE TPRHO(T,P,Z,KPH,KGUESS,D,IERR,HERR)
              REAL(KIND=8) :: T
              REAL(KIND=8) :: P
              REAL(KIND=8) :: Z(20)
              INTEGER(KIND=4) :: KPH
              INTEGER(KIND=4) :: KGUESS
              REAL(KIND=8) :: D
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE TPRHO
          END INTERFACE 
        END MODULE TPRHO__genmod
