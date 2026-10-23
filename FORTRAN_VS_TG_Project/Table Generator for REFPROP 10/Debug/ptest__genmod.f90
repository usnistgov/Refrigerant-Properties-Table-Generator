        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:39 2020
        MODULE PTEST__genmod
          INTERFACE 
            SUBROUTINE PTEST(INP,T,P,ALPHA,Z,CALC,ZOUT,IERR,HERR)
              INTEGER(KIND=4) :: INP
              REAL(KIND=8) :: T
              REAL(KIND=8) :: P
              REAL(KIND=8) :: ALPHA
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: CALC
              REAL(KIND=8) :: ZOUT(20)
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE PTEST
          END INTERFACE 
        END MODULE PTEST__genmod
