        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:58:18 2020
        MODULE PHIMIX__genmod
          INTERFACE 
            FUNCTION PHIMIX(ICOMP,JCOMP,ITAU,IDEL,TAU,DELTA,Z)
              INTEGER(KIND=4) :: ICOMP
              INTEGER(KIND=4) :: JCOMP
              INTEGER(KIND=4) :: ITAU
              INTEGER(KIND=4) :: IDEL
              REAL(KIND=8) :: TAU
              REAL(KIND=8) :: DELTA
              REAL(KIND=8) :: Z(20)
              REAL(KIND=8) :: PHIMIX
            END FUNCTION PHIMIX
          END INTERFACE 
        END MODULE PHIMIX__genmod
