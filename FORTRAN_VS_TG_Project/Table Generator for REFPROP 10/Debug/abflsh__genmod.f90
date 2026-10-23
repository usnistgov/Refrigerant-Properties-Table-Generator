        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:00 2020
        MODULE ABFLSH__genmod
          INTERFACE 
            SUBROUTINE ABFLSH(AB,A,B,Z,IFLAG,T,P,D,DL,DV,X,Y,Q,E,H,S,CV,&
     &CP,W,IERR,HERR)
              CHARACTER(LEN=2) :: AB
              REAL(KIND=8) :: A
              REAL(KIND=8) :: B
              REAL(KIND=8) :: Z(20)
              INTEGER(KIND=4) :: IFLAG
              REAL(KIND=8) :: T
              REAL(KIND=8) :: P
              REAL(KIND=8) :: D
              REAL(KIND=8) :: DL
              REAL(KIND=8) :: DV
              REAL(KIND=8) :: X(20)
              REAL(KIND=8) :: Y(20)
              REAL(KIND=8) :: Q
              REAL(KIND=8) :: E
              REAL(KIND=8) :: H
              REAL(KIND=8) :: S
              REAL(KIND=8) :: CV
              REAL(KIND=8) :: CP
              REAL(KIND=8) :: W
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE ABFLSH
          END INTERFACE 
        END MODULE ABFLSH__genmod
