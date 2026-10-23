        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:02 2020
        MODULE REFPROP__genmod
          INTERFACE 
            SUBROUTINE REFPROP(HFLD,HIN,HOUT,IUNITS,IMASS,IFLAG,A,B,Z,  &
     &OUTPUT,HUNITS,IUCODE,X,Y,X3,Q,IERR,HERR)
              CHARACTER(*) :: HFLD
              CHARACTER(*) :: HIN
              CHARACTER(*) :: HOUT
              INTEGER(KIND=4) :: IUNITS
              INTEGER(KIND=4) :: IMASS
              INTEGER(KIND=4) :: IFLAG
              REAL(KIND=8) :: A
              REAL(KIND=8) :: B
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: OUTPUT(200)
              CHARACTER(LEN=255) :: HUNITS
              INTEGER(KIND=4) :: IUCODE
              REAL(KIND=8) :: X(20)
              REAL(KIND=8) :: Y(20)
              REAL(KIND=8) :: X3(20)
              REAL(KIND=8) :: Q
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE REFPROP
          END INTERFACE 
        END MODULE REFPROP__genmod
