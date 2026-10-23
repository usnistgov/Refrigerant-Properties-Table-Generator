        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:35 2020
        MODULE PHIDERVPR__genmod
          INTERFACE 
            SUBROUTINE PHIDERVPR(IDERV,T,RHO,Z,DADN,DNADN,IERR,HERR)
              INTEGER(KIND=4) :: IDERV
              REAL(KIND=8) :: T
              REAL(KIND=8) :: RHO
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: DADN(20)
              REAL(KIND=8) :: DNADN(20)
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE PHIDERVPR
          END INTERFACE 
        END MODULE PHIDERVPR__genmod
