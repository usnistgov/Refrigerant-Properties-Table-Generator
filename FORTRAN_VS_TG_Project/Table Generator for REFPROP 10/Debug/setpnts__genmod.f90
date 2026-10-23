        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:57:53 2020
        MODULE SETPNTS__genmod
          INTERFACE 
            SUBROUTINE SETPNTS(IFLAG,ICOMP,Z,T,P,DL,DV,IERR,HERR)
              INTEGER(KIND=4) :: IFLAG
              INTEGER(KIND=4) :: ICOMP
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: T
              REAL(KIND=8) :: P
              REAL(KIND=8) :: DL
              REAL(KIND=8) :: DV
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE SETPNTS
          END INTERFACE 
        END MODULE SETPNTS__genmod
