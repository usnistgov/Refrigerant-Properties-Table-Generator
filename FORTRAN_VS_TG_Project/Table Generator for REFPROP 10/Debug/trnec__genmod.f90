        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:07 2020
        MODULE TRNEC__genmod
          INTERFACE 
            SUBROUTINE TRNEC(M,ICOMP,T,D,Z,ETA,TCX,IERR,HERR,IREFN,T0,D0&
     &,AMX,ZMIX,FX,HX)
              INTEGER(KIND=4) :: M
              INTEGER(KIND=4) :: ICOMP
              REAL(KIND=8) :: T
              REAL(KIND=8) :: D
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: ETA
              REAL(KIND=8) :: TCX
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
              INTEGER(KIND=4) :: IREFN
              REAL(KIND=8) :: T0
              REAL(KIND=8) :: D0
              REAL(KIND=8) :: AMX
              REAL(KIND=8) :: ZMIX
              REAL(KIND=8) :: FX
              REAL(KIND=8) :: HX
            END SUBROUTINE TRNEC
          END INTERFACE 
        END MODULE TRNEC__genmod
