        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:57:51 2020
        MODULE PIVOT__genmod
          INTERFACE 
            SUBROUTINE PIVOT(N,MAXN,J,AMATRIX,SDECOMP)
              INTEGER(KIND=4) :: MAXN
              INTEGER(KIND=4) :: N
              INTEGER(KIND=4) :: J
              REAL(KIND=8) :: AMATRIX(MAXN,MAXN)
              REAL(KIND=8) :: SDECOMP(MAXN)
            END SUBROUTINE PIVOT
          END INTERFACE 
        END MODULE PIVOT__genmod
