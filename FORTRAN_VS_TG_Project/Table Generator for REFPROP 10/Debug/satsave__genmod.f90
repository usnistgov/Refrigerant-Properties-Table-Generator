        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:39 2020
        MODULE SATSAVE__genmod
          INTERFACE 
            SUBROUTINE SATSAVE(IFLAG,ICOMP,KPH,T,P,D,DL,DV,Q,X,Y,Z,IERR,&
     &IEXIT)
              INTEGER(KIND=4) :: IFLAG
              INTEGER(KIND=4) :: ICOMP
              INTEGER(KIND=4) :: KPH
              REAL(KIND=8) :: T
              REAL(KIND=8) :: P
              REAL(KIND=8) :: D
              REAL(KIND=8) :: DL
              REAL(KIND=8) :: DV
              REAL(KIND=8) :: Q
              REAL(KIND=8) :: X(20)
              REAL(KIND=8) :: Y(20)
              REAL(KIND=8) :: Z(20)
              INTEGER(KIND=4) :: IERR
              INTEGER(KIND=4) :: IEXIT
            END SUBROUTINE SATSAVE
          END INTERFACE 
        END MODULE SATSAVE__genmod
