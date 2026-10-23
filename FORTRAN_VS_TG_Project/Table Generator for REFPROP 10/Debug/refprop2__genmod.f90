        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:02 2020
        MODULE REFPROP2__genmod
          INTERFACE 
            SUBROUTINE REFPROP2(HFLD,HIN,HOUT,IUNITS,IFLAG,A,B,Z,OUTPUT,&
     &Q,IERR,HERR)
              CHARACTER(*) :: HFLD
              CHARACTER(*) :: HIN
              CHARACTER(*) :: HOUT
              INTEGER(KIND=4) :: IUNITS
              INTEGER(KIND=4) :: IFLAG
              REAL(KIND=8) :: A
              REAL(KIND=8) :: B
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: OUTPUT(200)
              REAL(KIND=8) :: Q
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE REFPROP2
          END INTERFACE 
        END MODULE REFPROP2__genmod
