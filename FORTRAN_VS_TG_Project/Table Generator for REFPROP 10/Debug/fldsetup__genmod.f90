        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:01 2020
        MODULE FLDSETUP__genmod
          INTERFACE 
            SUBROUTINE FLDSETUP(HFLD,IMASS,IFLAG,Z,ZM,IERR,HERR)
              CHARACTER(*) :: HFLD
              INTEGER(KIND=4) :: IMASS
              INTEGER(KIND=4) :: IFLAG
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: ZM(20)
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE FLDSETUP
          END INTERFACE 
        END MODULE FLDSETUP__genmod
