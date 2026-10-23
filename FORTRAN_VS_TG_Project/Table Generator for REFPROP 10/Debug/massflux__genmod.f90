        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:14 2020
        MODULE MASSFLUX__genmod
          INTERFACE 
            SUBROUTINE MASSFLUX(TM,P,Z,BETA,RF,FLUXM,CS,T0,P0,XMACH,U,TS&
     &,PS,IERR,HERR)
              REAL(KIND=8) :: TM
              REAL(KIND=8) :: P
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: BETA
              REAL(KIND=8) :: RF
              REAL(KIND=8) :: FLUXM
              REAL(KIND=8) :: CS
              REAL(KIND=8) :: T0
              REAL(KIND=8) :: P0
              REAL(KIND=8) :: XMACH
              REAL(KIND=8) :: U
              REAL(KIND=8) :: TS
              REAL(KIND=8) :: PS
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE MASSFLUX
          END INTERFACE 
        END MODULE MASSFLUX__genmod
