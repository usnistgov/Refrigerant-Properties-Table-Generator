        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:57:52 2020
        MODULE MINEIGEN__genmod
          INTERFACE 
            SUBROUTINE MINEIGEN(N,A,U,XLAMDA,IERR,HERR)
              INTEGER(KIND=4) :: N
              REAL(KIND=8) :: A(20,20)
              REAL(KIND=8) :: U(20)
              REAL(KIND=8) :: XLAMDA
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE MINEIGEN
          END INTERFACE 
        END MODULE MINEIGEN__genmod
