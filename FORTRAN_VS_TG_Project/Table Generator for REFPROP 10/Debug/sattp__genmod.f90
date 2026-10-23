        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:40 2020
        MODULE SATTP__genmod
          INTERFACE 
            SUBROUTINE SATTP(T,P,Z,IFLSH,IGUESS,D,DL,DV,X,Y,Q,IERR,HERR)
              REAL(KIND=8) :: T
              REAL(KIND=8) :: P
              REAL(KIND=8) :: Z(20)
              INTEGER(KIND=4) :: IFLSH
              INTEGER(KIND=4) :: IGUESS
              REAL(KIND=8) :: D
              REAL(KIND=8) :: DL
              REAL(KIND=8) :: DV
              REAL(KIND=8) :: X(20)
              REAL(KIND=8) :: Y(20)
              REAL(KIND=8) :: Q
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE SATTP
          END INTERFACE 
        END MODULE SATTP__genmod
