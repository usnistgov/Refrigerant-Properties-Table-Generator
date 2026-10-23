        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:57:52 2020
        MODULE QMASS__genmod
          INTERFACE 
            SUBROUTINE QMASS(QMOL,XL,XV,QKG,XLKG,XVKG,WLIQ,WVAP,IERR,   &
     &HERR)
              REAL(KIND=8) :: QMOL
              REAL(KIND=8) :: XL(20)
              REAL(KIND=8) :: XV(20)
              REAL(KIND=8) :: QKG
              REAL(KIND=8) :: XLKG(20)
              REAL(KIND=8) :: XVKG(20)
              REAL(KIND=8) :: WLIQ
              REAL(KIND=8) :: WVAP
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE QMASS
          END INTERFACE 
        END MODULE QMASS__genmod
