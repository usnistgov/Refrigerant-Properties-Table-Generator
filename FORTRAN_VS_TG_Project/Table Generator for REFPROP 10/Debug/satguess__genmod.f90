        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:39 2020
        MODULE SATGUESS__genmod
          INTERFACE 
            SUBROUTINE SATGUESS(KPH,IPROP,IFLAG,ISPL,X,T,P,D,H,S,DY,Y,  &
     &IERR,HERR)
              INTEGER(KIND=4) :: KPH
              INTEGER(KIND=4) :: IPROP
              INTEGER(KIND=4) :: IFLAG
              INTEGER(KIND=4) :: ISPL
              REAL(KIND=8) :: X(20)
              REAL(KIND=8) :: T
              REAL(KIND=8) :: P
              REAL(KIND=8) :: D
              REAL(KIND=8) :: H
              REAL(KIND=8) :: S
              REAL(KIND=8) :: DY
              REAL(KIND=8) :: Y(20)
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE SATGUESS
          END INTERFACE 
        END MODULE SATGUESS__genmod
