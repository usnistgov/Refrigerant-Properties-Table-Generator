        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:12 2020
        MODULE PHIDERV__genmod
          INTERFACE 
            SUBROUTINE PHIDERV(IDERV,T,D,Z,DADN,DNADN,IERR,HERR)
              INTEGER(KIND=4) :: IDERV
              REAL(KIND=8) :: T
              REAL(KIND=8) :: D
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: DADN(20)
              REAL(KIND=8) :: DNADN(20)
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE PHIDERV
          END INTERFACE 
        END MODULE PHIDERV__genmod
