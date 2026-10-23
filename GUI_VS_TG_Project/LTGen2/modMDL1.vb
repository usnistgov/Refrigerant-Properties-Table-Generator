Module modMDL1
    Public inumber As Integer, hp As Double, lp As Double, np As Integer, nh As Integer
    Public iscale As Integer, rname As String

    'YYJ[2020.0727]ltgen2: maximum component changed to 6- s
    Public refcomp_STR(NMaxRefrigrants) As String, refname(NMaxRefrigrants) As String, refcomp(NMaxRefrigrants) As Double
    'Public refcomp_STR(5) As String, refname(5) As String, refcomp(5) As Double
    'YYJ[2020.0727]ltgen2: maximum component changed to 6- e

    'YYJ[2020.0727]ltgen2: Saving *.FLD filename to TableInfo.txt
    Public refFLDname(NMaxRefrigrants) As String

End Module
