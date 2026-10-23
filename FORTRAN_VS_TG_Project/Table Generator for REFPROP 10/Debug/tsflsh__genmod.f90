        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:30 2020
        MODULE TSFLSH__genmod
          INTERFACE 
            SUBROUTINE TSFLSH(T,S,Z,KR,P,D,DL,DV,X,Y,Q,E,H,CV,CP,W,IERR,&
     &HERR)
              REAL(KIND=8) :: T
              REAL(KIND=8) :: S
              REAL(KIND=8) :: Z(20)
              INTEGER(KIND=4) :: KR
              REAL(KIND=8) :: P
              REAL(KIND=8) :: D
              REAL(KIND=8) :: DL
              REAL(KIND=8) :: DV
              REAL(KIND=8) :: X(20)
              REAL(KIND=8) :: Y(20)
              REAL(KIND=8) :: Q
              REAL(KIND=8) :: E
              REAL(KIND=8) :: H
              REAL(KIND=8) :: CV
              REAL(KIND=8) :: CP
              REAL(KIND=8) :: W
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE TSFLSH
          END INTERFACE 
        END MODULE TSFLSH__genmod
