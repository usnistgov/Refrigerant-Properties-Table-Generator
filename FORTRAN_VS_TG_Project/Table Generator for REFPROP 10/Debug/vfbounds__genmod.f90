        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:27 2020
        MODULE VFBOUNDS__genmod
          INTERFACE 
            SUBROUTINE VFBOUNDS(T,P,X,KPH,V,F,VLOG,TC,DC,LNEG,LPOS)
              REAL(KIND=8) :: T
              REAL(KIND=8) :: P
              REAL(KIND=8) :: X(20)
              INTEGER(KIND=4) :: KPH
              REAL(KIND=8) :: V(20)
              REAL(KIND=8) :: F(20)
              REAL(KIND=8) :: VLOG
              REAL(KIND=8) :: TC
              REAL(KIND=8) :: DC
              LOGICAL(KIND=4) :: LNEG
              LOGICAL(KIND=4) :: LPOS
            END SUBROUTINE VFBOUNDS
          END INTERFACE 
        END MODULE VFBOUNDS__genmod
