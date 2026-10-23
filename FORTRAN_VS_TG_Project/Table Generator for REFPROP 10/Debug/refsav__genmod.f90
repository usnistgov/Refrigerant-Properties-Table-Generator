        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:00 2020
        MODULE REFSAV__genmod
          INTERFACE 
            SUBROUTINE REFSAV(IO,IUNITS,IMASS,IFLAG,X,Y,X3,Q,DL,DV,IERR,&
     &HERR)
              INTEGER(KIND=4) :: IO
              INTEGER(KIND=4) :: IUNITS
              INTEGER(KIND=4) :: IMASS
              INTEGER(KIND=4) :: IFLAG
              REAL(KIND=8) :: X(20)
              REAL(KIND=8) :: Y(20)
              REAL(KIND=8) :: X3(20)
              REAL(KIND=8) :: Q
              REAL(KIND=8) :: DL
              REAL(KIND=8) :: DV
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE REFSAV
          END INTERFACE 
        END MODULE REFSAV__genmod
