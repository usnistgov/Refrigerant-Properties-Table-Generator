        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:40 2020
        MODULE HVAPZTN__genmod
          INTERFACE 
            SUBROUTINE HVAPZTN(T,P,Z,ITP,HVAP,HVAP0,IERR,HERR)
              REAL(KIND=8) :: T
              REAL(KIND=8) :: P
              REAL(KIND=8) :: Z(20)
              INTEGER(KIND=4) :: ITP
              REAL(KIND=8) :: HVAP
              REAL(KIND=8) :: HVAP0
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE HVAPZTN
          END INTERFACE 
        END MODULE HVAPZTN__genmod
