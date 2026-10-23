        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:00 2020
        MODULE GETUNITS__genmod
          INTERFACE 
            SUBROUTINE GETUNITS(IUNITS,IUCODE,IFLAG,IC,Z,HA,XIN,XOUT,   &
     &HUNITS,IERR,HERR)
              INTEGER(KIND=4) :: IUNITS
              INTEGER(KIND=4) :: IUCODE
              INTEGER(KIND=4) :: IFLAG
              INTEGER(KIND=4) :: IC
              REAL(KIND=8) :: Z(20)
              CHARACTER(LEN=255) :: HA
              REAL(KIND=8) :: XIN
              REAL(KIND=8) :: XOUT
              CHARACTER(LEN=255) :: HUNITS
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE GETUNITS
          END INTERFACE 
        END MODULE GETUNITS__genmod
