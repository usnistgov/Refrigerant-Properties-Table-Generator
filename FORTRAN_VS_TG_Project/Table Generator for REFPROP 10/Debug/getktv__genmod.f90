        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:19 2020
        MODULE GETKTV__genmod
          INTERFACE 
            SUBROUTINE GETKTV(ICOMP,JCOMP,HMODIJ,FIJ,HFMIX,HFIJ,HBINP,  &
     &HMXRUL)
              INTEGER(KIND=4) :: ICOMP
              INTEGER(KIND=4) :: JCOMP
              CHARACTER(LEN=3) :: HMODIJ
              REAL(KIND=8) :: FIJ(6)
              CHARACTER(LEN=255) :: HFMIX
              CHARACTER(LEN=8) :: HFIJ(6)
              CHARACTER(LEN=255) :: HBINP
              CHARACTER(LEN=255) :: HMXRUL
            END SUBROUTINE GETKTV
          END INTERFACE 
        END MODULE GETKTV__genmod
