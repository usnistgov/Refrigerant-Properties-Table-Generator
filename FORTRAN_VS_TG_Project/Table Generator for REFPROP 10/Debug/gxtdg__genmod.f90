        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:07 2020
        MODULE GXTDG__genmod
          INTERFACE 
            SUBROUTINE GXTDG(M,I,J,DJ,Z,XMJ,FJ,HJ,GJ,ETADG,TCXDG,TCXIN, &
     &GXSUM,TDGMSW)
              INTEGER(KIND=4) :: M
              INTEGER(KIND=4) :: I
              INTEGER(KIND=4) :: J
              REAL(KIND=8) :: DJ
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: XMJ(20)
              REAL(KIND=8) :: FJ(20)
              REAL(KIND=8) :: HJ(20)
              REAL(KIND=8) :: GJ
              REAL(KIND=8) :: ETADG(20)
              REAL(KIND=8) :: TCXDG(20)
              REAL(KIND=8) :: TCXIN(20)
              REAL(KIND=8) :: GXSUM
              REAL(KIND=8) :: TDGMSW
            END SUBROUTINE GXTDG
          END INTERFACE 
        END MODULE GXTDG__genmod
