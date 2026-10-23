        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:00 2020
        MODULE CONVUNIT__genmod
          INTERFACE 
            FUNCTION CONVUNIT(XIN,IUNITS,IUNITID,Z,HUNITS,IERR,HERR)
              REAL(KIND=8) :: XIN
              INTEGER(KIND=4) :: IUNITS
              INTEGER(KIND=4) :: IUNITID
              REAL(KIND=8) :: Z(20)
              CHARACTER(LEN=255) :: HUNITS
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
              REAL(KIND=8) :: CONVUNIT
            END FUNCTION CONVUNIT
          END INTERFACE 
        END MODULE CONVUNIT__genmod
