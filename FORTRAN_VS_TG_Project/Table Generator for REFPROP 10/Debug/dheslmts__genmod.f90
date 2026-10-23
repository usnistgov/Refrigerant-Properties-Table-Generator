        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:28 2020
        MODULE DHESLMTS__genmod
          INTERFACE 
            SUBROUTINE DHESLMTS(IFLAG,KR,T,TC,B,Z,IBT,DMIN,DMAX,DMID,   &
     &BMIN,BMAX,BSAT,PSAT,DL,DV,ZSAT,IERR,HERR)
              INTEGER(KIND=4) :: IFLAG
              INTEGER(KIND=4) :: KR
              REAL(KIND=8) :: T
              REAL(KIND=8) :: TC
              REAL(KIND=8) :: B
              REAL(KIND=8) :: Z(20)
              INTEGER(KIND=4) :: IBT
              REAL(KIND=8) :: DMIN
              REAL(KIND=8) :: DMAX
              REAL(KIND=8) :: DMID
              REAL(KIND=8) :: BMIN
              REAL(KIND=8) :: BMAX
              REAL(KIND=8) :: BSAT
              REAL(KIND=8) :: PSAT
              REAL(KIND=8) :: DL
              REAL(KIND=8) :: DV
              REAL(KIND=8) :: ZSAT(20)
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE DHESLMTS
          END INTERFACE 
        END MODULE DHESLMTS__genmod
