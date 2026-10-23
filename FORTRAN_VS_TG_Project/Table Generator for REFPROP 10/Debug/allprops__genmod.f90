        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:01 2020
        MODULE ALLPROPS__genmod
          INTERFACE 
            SUBROUTINE ALLPROPS(HOUT,IUNITS,IMASS,IFLAG,T,D,Z,OUTPUT,   &
     &HUNITSARRAY,IUCODEARRAY,IERR,HERR)
              CHARACTER(*) :: HOUT
              INTEGER(KIND=4) :: IUNITS
              INTEGER(KIND=4) :: IMASS
              INTEGER(KIND=4) :: IFLAG
              REAL(KIND=8) :: T
              REAL(KIND=8) :: D
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: OUTPUT(200)
              CHARACTER(LEN=50) :: HUNITSARRAY(200)
              INTEGER(KIND=4) :: IUCODEARRAY(200)
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE ALLPROPS
          END INTERFACE 
        END MODULE ALLPROPS__genmod
