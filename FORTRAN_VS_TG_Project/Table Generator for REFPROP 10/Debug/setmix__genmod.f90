        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:34 2020
        MODULE SETMIX__genmod
          INTERFACE 
            SUBROUTINE SETMIX(HMIXNME,HFMIX,HRF,NCC,HFILES,Z,IERR,HERR)
              CHARACTER(LEN=255) :: HMIXNME
              CHARACTER(LEN=255) :: HFMIX
              CHARACTER(LEN=3) :: HRF
              INTEGER(KIND=4) :: NCC
              CHARACTER(LEN=255) :: HFILES(20)
              REAL(KIND=8) :: Z(20)
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE SETMIX
          END INTERFACE 
        END MODULE SETMIX__genmod
