        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:40 2020
        MODULE SATGV__genmod
          INTERFACE 
            SUBROUTINE SATGV(T,P,Z,VF,B,IPV,ITYP,ISP,DX,DY,X,Y,IERR,HERR&
     &)
              REAL(KIND=8) :: T
              REAL(KIND=8) :: P
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: VF
              REAL(KIND=8) :: B
              INTEGER(KIND=4) :: IPV
              INTEGER(KIND=4) :: ITYP
              INTEGER(KIND=4) :: ISP
              REAL(KIND=8) :: DX
              REAL(KIND=8) :: DY
              REAL(KIND=8) :: X(20)
              REAL(KIND=8) :: Y(20)
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE SATGV
          END INTERFACE 
        END MODULE SATGV__genmod
