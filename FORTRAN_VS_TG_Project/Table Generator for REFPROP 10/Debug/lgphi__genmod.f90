        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:39 2020
        MODULE LGPHI__genmod
          INTERFACE 
            SUBROUTINE LGPHI(IDERV,IPHASE,T,D,P,Z,PHILN,DPDT,DPDD,DDDT, &
     &IERR,HERR)
              INTEGER(KIND=4) :: IDERV
              INTEGER(KIND=4) :: IPHASE
              REAL(KIND=8) :: T
              REAL(KIND=8) :: D
              REAL(KIND=8) :: P
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: PHILN(20)
              REAL(KIND=8) :: DPDT
              REAL(KIND=8) :: DPDD
              REAL(KIND=8) :: DDDT
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE LGPHI
          END INTERFACE 
        END MODULE LGPHI__genmod
