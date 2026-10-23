        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:07 2020
        MODULE CHECKTRN__genmod
          INTERFACE 
            SUBROUTINE CHECKTRN(IFLAG,ICOMP,T,D,Z,ETA,TCX,IERR,IERRETA, &
     &IERRTCX,IERRECS,HERR,HERRETA,HERRTCX,HERRECS)
              INTEGER(KIND=4) :: IFLAG
              INTEGER(KIND=4) :: ICOMP
              REAL(KIND=8) :: T
              REAL(KIND=8) :: D
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: ETA
              REAL(KIND=8) :: TCX
              INTEGER(KIND=4) :: IERR
              INTEGER(KIND=4) :: IERRETA
              INTEGER(KIND=4) :: IERRTCX
              INTEGER(KIND=4) :: IERRECS
              CHARACTER(LEN=255) :: HERR
              CHARACTER(LEN=255) :: HERRETA
              CHARACTER(LEN=255) :: HERRTCX
              CHARACTER(LEN=255) :: HERRECS
            END SUBROUTINE CHECKTRN
          END INTERFACE 
        END MODULE CHECKTRN__genmod
