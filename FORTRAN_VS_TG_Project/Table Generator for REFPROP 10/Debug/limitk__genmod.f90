        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:57:54 2020
        MODULE LIMITK__genmod
          INTERFACE 
            SUBROUTINE LIMITK(HTYP,ICOMP,T,D,P,TMIN,TMAX,DMAX,PMAX,IERR,&
     &HERR)
              CHARACTER(LEN=3) :: HTYP
              INTEGER(KIND=4) :: ICOMP
              REAL(KIND=8) :: T
              REAL(KIND=8) :: D
              REAL(KIND=8) :: P
              REAL(KIND=8) :: TMIN
              REAL(KIND=8) :: TMAX
              REAL(KIND=8) :: DMAX
              REAL(KIND=8) :: PMAX
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE LIMITK
          END INTERFACE 
        END MODULE LIMITK__genmod
