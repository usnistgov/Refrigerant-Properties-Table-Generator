        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:57:54 2020
        MODULE LIMITX__genmod
          INTERFACE 
            SUBROUTINE LIMITX(HTYP,T,D,P,Z,TMIN,TMAX,DMAX,PMAX,IERR,HERR&
     &)
              CHARACTER(LEN=3) :: HTYP
              REAL(KIND=8) :: T
              REAL(KIND=8) :: D
              REAL(KIND=8) :: P
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: TMIN
              REAL(KIND=8) :: TMAX
              REAL(KIND=8) :: DMAX
              REAL(KIND=8) :: PMAX
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE LIMITX
          END INTERFACE 
        END MODULE LIMITX__genmod
