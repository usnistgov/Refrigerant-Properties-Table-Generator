        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:57:53 2020
        MODULE PASSCMN__genmod
          INTERFACE 
            SUBROUTINE PASSCMN(HVR,ISET,ICOMP,JCOMP,HSTR,ILNG,DBL,ARR,  &
     &IERR,HERR)
              CHARACTER(*) :: HVR
              INTEGER(KIND=4) :: ISET
              INTEGER(KIND=4) :: ICOMP
              INTEGER(KIND=4) :: JCOMP
              CHARACTER(LEN=255) :: HSTR
              INTEGER(KIND=4) :: ILNG
              REAL(KIND=8) :: DBL
              REAL(KIND=8) :: ARR(100)
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE PASSCMN
          END INTERFACE 
        END MODULE PASSCMN__genmod
