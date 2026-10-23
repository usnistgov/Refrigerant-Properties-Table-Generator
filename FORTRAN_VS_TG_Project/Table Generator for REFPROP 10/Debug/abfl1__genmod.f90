        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:28 2020
        MODULE ABFL1__genmod
          INTERFACE 
            SUBROUTINE ABFL1(AB,A,B,Z,KPH,IGUESS,DMIN,DMAX,T,P,D,IERR,  &
     &HERR)
              CHARACTER(LEN=2) :: AB
              REAL(KIND=8) :: A
              REAL(KIND=8) :: B
              REAL(KIND=8) :: Z(20)
              INTEGER(KIND=4) :: KPH
              INTEGER(KIND=4) :: IGUESS
              REAL(KIND=8) :: DMIN
              REAL(KIND=8) :: DMAX
              REAL(KIND=8) :: T
              REAL(KIND=8) :: P
              REAL(KIND=8) :: D
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE ABFL1
          END INTERFACE 
        END MODULE ABFL1__genmod
