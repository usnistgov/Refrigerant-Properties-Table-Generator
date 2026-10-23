        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:13 2020
        MODULE RPNEQN__genmod
          INTERFACE 
            FUNCTION RPNEQN(IFLAG,ICOMP,IVAR,T,D,Z,ETA,IERR,HERR)
              INTEGER(KIND=4) :: IFLAG
              INTEGER(KIND=4) :: ICOMP
              INTEGER(KIND=4) :: IVAR
              REAL(KIND=8) :: T
              REAL(KIND=8) :: D
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: ETA
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
              REAL(KIND=8) :: RPNEQN
            END FUNCTION RPNEQN
          END INTERFACE 
        END MODULE RPNEQN__genmod
