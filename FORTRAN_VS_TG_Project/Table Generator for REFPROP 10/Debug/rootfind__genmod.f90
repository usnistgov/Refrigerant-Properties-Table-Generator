        !COMPILER-GENERATED INTERFACE MODULE: Thu Jul 09 22:57:54 2020
        MODULE ROOTFIND__genmod
          INTERFACE 
            SUBROUTINE ROOTFIND(HFUNC,IBT,JBT,B,Z,KPH,IDERV,ITD,IIB,ILG1&
     &,ILG2,T,D,OT,IERR,HERR)
              CHARACTER(*) :: HFUNC
              INTEGER(KIND=4) :: IBT
              INTEGER(KIND=4) :: JBT
              REAL(KIND=8) :: B
              REAL(KIND=8) :: Z(20)
              INTEGER(KIND=4) :: KPH
              INTEGER(KIND=4) :: IDERV
              INTEGER(KIND=4) :: ITD
              INTEGER(KIND=4) :: IIB
              INTEGER(KIND=4) :: ILG1
              INTEGER(KIND=4) :: ILG2
              REAL(KIND=8) :: T
              REAL(KIND=8) :: D
              REAL(KIND=8) :: OT
              INTEGER(KIND=4) :: IERR
              CHARACTER(LEN=255) :: HERR
            END SUBROUTINE ROOTFIND
          END INTERFACE 
        END MODULE ROOTFIND__genmod
