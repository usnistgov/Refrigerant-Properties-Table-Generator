'Imports VBDLL1.Class1

Public Class FormPredefined
    Friend MixtureFeature As FluidFeatureSTR
    Friend MixtureComponents() As FluidFeatureSTR
    Private ListMixtureDT As DataTable
    Friend PushOk As Boolean = False
    Friend SelectedFluidIndex As Integer
    Friend SelectedFluidName(2) As String   '0:NameMixture; 1:NameMixtureUser; 2:MixtureStored
    Private Sub FormPredefined_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ListMixtureLocalDT As New DataTable
        Dim ListMixtureDW As New DataView
        Dim RowDummy As DataRow
        Dim Cont As Int32 = 0
        Dim snextfile, fluid As String
        Dim ExtentionLength As Integer
        'Create the DataTable
        ListMixtureLocalDT.Columns.Add("IdMixture", System.Type.GetType("System.Int32"))
        ListMixtureLocalDT.Columns.Add("NameMixture", System.Type.GetType("System.String"))
        ListMixtureLocalDT.Columns.Add("UserMixture", System.Type.GetType("System.Boolean"))
        ListMixtureLocalDT.PrimaryKey = New DataColumn() {ListMixtureLocalDT.Columns("IdMixture")}

        ' Do not modify cont here, else uncomment before the for : ' Cont = ListaFluidiDT.Rows.Count
        For Each file As System.IO.FileInfo In My.Computer.FileSystem.GetDirectoryInfo(My.Application.Info.DirectoryPath & "\MIXTURES\").GetFiles

            'YYJ[2020.0404] Exclude non *.MIX file from the data table - s
            If file.Extension.ToUpper() = ".MIX" Then 'consider only *.MIX file
                fluid = file.Name
                ExtentionLength = file.Extension.Length
                snextfile = Strings.Left(fluid, fluid.Length - ExtentionLength)
                ' Add the refrigerant to the DataTable
                RowDummy = ListMixtureLocalDT.NewRow
                RowDummy("IdMixture") = Cont
                RowDummy("NameMixture") = snextfile
                RowDummy("UserMixture") = False
                ListMixtureLocalDT.Rows.Add(RowDummy)
                Cont = Cont + 1
            Else
                Continue For
            End If
            'fluid = file.Name
            'ExtentionLength = file.Extension.Length
            'snextfile = Strings.Left(fluid, fluid.Length - ExtentionLength)
            '' Add the refrigerant to the DataTable
            'RowDummy = ListMixtureLocalDT.NewRow
            'RowDummy("IdMixture") = Cont
            'RowDummy("NameMixture") = snextfile
            'RowDummy("UserMixture") = False
            'ListMixtureLocalDT.Rows.Add(RowDummy)
            'Cont = Cont + 1
            'YYJ[2020.0404] Exclude non *.MIX file from the data table - e
        Next

        'YYJ[2020.1119]ltgen2: make a portable version - s
        If Not My.Computer.FileSystem.DirectoryExists(ApplicationFolder & "\UserDefinedMixture") Then
            My.Computer.FileSystem.CreateDirectory(ApplicationFolder & "\UserDefinedMixture")
        End If
        For Each file As System.IO.FileInfo In My.Computer.FileSystem.GetDirectoryInfo(ApplicationFolder & "\UserDefinedMixture").GetFiles
            'If Not My.Computer.FileSystem.DirectoryExists(UserApplicationFolder & "\UserDefinedMixture") Then
            '    My.Computer.FileSystem.CreateDirectory(UserApplicationFolder & "\UserDefinedMixture")
            'End If
            'For Each file As System.IO.FileInfo In My.Computer.FileSystem.GetDirectoryInfo(UserApplicationFolder & "\UserDefinedMixture").GetFiles
            'YYJ[2020.1119]ltgen2: make a portable version - e

            'YYJ[2020.0404] Exclude non *.MIX file from the data table - s
            If file.Extension.ToUpper() = ".MIX" Then 'consider only *.MIX file
                fluid = file.Name
                ExtentionLength = file.Extension.Length
                snextfile = Strings.Left(fluid, fluid.Length - ExtentionLength)
                ' Add the refrigerant to the DataTable
                RowDummy = ListMixtureLocalDT.NewRow
                RowDummy("IdMixture") = Cont
                RowDummy("NameMixture") = snextfile
                RowDummy("UserMixture") = True
                ListMixtureLocalDT.Rows.Add(RowDummy)
                Cont = Cont + 1
            Else
                Continue For
            End If
            'fluid = file.Name
            'ExtentionLength = file.Extension.Length
            'snextfile = Strings.Left(fluid, fluid.Length - ExtentionLength)
            '' Add the refrigerant to the DataTable
            'RowDummy = ListMixtureLocalDT.NewRow
            'RowDummy("IdMixture") = Cont
            'RowDummy("NameMixture") = snextfile
            'RowDummy("UserMixture") = True
            'ListMixtureLocalDT.Rows.Add(RowDummy)
            'Cont = Cont + 1
            'YYJ[2020.0404] Exclude non *.MIX file from the data table - e

        Next

        ListMixtureDW = ListMixtureLocalDT.DefaultView
        ListMixtureDW.Sort() = "NameMixture"
        Me.lstPredefined.DataSource = ListMixtureDW
        Me.lstPredefined.ValueMember = "IdMixture"
        Me.lstPredefined.DisplayMember = "NameMixture"
        Me.lstPredefined.SelectedValue = Me.SelectedFluidIndex
        Me.ListMixtureDT = ListMixtureLocalDT.Copy
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click, lstPredefined.DoubleClick
        Dim FileNamePathComplete, FileName As String
        Dim RowToFind As DataRow
        RowToFind = ListMixtureDT.Rows.Find(Me.lstPredefined.SelectedValue)
        FileName = CStr(RowToFind("NameMixture"))
        FileName = FileName & ".mix"

        If CBool(RowToFind("UserMixture")) = False And My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\MIXTURES\" & FileName) Then
            FileNamePathComplete = My.Application.Info.DirectoryPath & "\MIXTURES\" & FileName
            Me.MixtureFeature = FormPredefined.SetMixtureFeature(FileNamePathComplete, FileName, Me.MixtureComponents)
            PushOk = True
            Me.SelectedFluidIndex = CInt(RowToFind("IdMixture"))
            Me.SelectedFluidName(0) = CStr(RowToFind("NameMixture"))
            Me.SelectedFluidName(1) = CStr(RowToFind("UserMixture"))
            Me.SelectedFluidName(2) = "True"
            Me.Close()

            'YYJ[2020.1119]ltgen2: make a portable version - s
        ElseIf CBool(RowToFind("UserMixture")) = True And My.Computer.FileSystem.FileExists(ApplicationFolder & "\UserDefinedMixture\" & FileName) Then
            FileNamePathComplete = ApplicationFolder & "\UserDefinedMixture\" & FileName
            'ElseIf CBool(RowToFind("UserMixture")) = True And My.Computer.FileSystem.FileExists(UserApplicationFolder & "\UserDefinedMixture\" & FileName) Then
            'FileNamePathComplete = UserApplicationFolder & "\UserDefinedMixture\" & FileName
            'YYJ[2020.1119]ltgen2: make a portable version - e

            FileNamePathComplete = UserApplicationFolder & "\UserDefinedMixture\" & FileName
            Me.MixtureFeature = FormPredefined.SetMixtureFeature(FileNamePathComplete, FileName, Me.MixtureComponents)
            Me.SelectedFluidIndex = CInt(RowToFind("IdMixture"))
            Me.SelectedFluidName(0) = CStr(RowToFind("NameMixture"))
            Me.SelectedFluidName(1) = CStr(RowToFind("UserMixture"))
            Me.SelectedFluidName(2) = "False"
            PushOk = True
            Me.Close()

        Else
            MsgBox("Mixture file does not exist. Please select another fluid or add this particular fluid to the fluids subdirectory.")
        End If

    End Sub
    Friend Shared Function CreateTBPerSummaryinFormInput(ByVal MixtureFeatureLocal As FluidFeatureSTR, ByVal MixtureComponents() As FluidFeatureSTR) As DataTable
        Dim SummaryTB As New DataTable
        Dim Row As DataRow
        SummaryTB.Columns.Add("Component", System.Type.GetType("System.String"))
        SummaryTB.Columns.Add("MoleFraction", System.Type.GetType("System.Double"))
        SummaryTB.Columns.Add("MassFraction", System.Type.GetType("System.Double"))

        'YYJ[2020.0727]ltgen2: Saving *.FLD filename to TableInfo.txt
        SummaryTB.Columns.Add("FLD", System.Type.GetType("System.String"))

        For i As Integer = 0 To MixtureFeatureLocal.nc - 1
            Row = SummaryTB.NewRow
            Row("Component") = MixtureComponents(i).fluid
            Row("MoleFraction") = MixtureFeatureLocal.X(i)
            Row("MassFraction") = MixtureFeatureLocal.WmElements(i)

            'YYJ[2020.0727]ltgen2: Saving *.FLD filename to TableInfo.txt (update DB)
            Row("FLD") = MixtureFeatureLocal.comp(i).ToUpper()
            'Row("FLD") = MixtureComponents(i).FileName

            SummaryTB.Rows.Add(Row)
        Next i
        Return SummaryTB
    End Function
    Private Sub cmdInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInfo.Click
        Me.Enabled = False
        Dim FileNamePathComplete, FileName As String
        Dim RowToFind As DataRow
        RowToFind = ListMixtureDT.Rows.Find(Me.lstPredefined.SelectedValue)
        FileName = CStr(RowToFind("NameMixture"))
        FileName = FileName & ".mix"

        If CBool(RowToFind("UserMixture")) = False And My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\MIXTURES\" & FileName) Then
            FileNamePathComplete = My.Application.Info.DirectoryPath & "\MIXTURES\" & FileName
            Me.MixtureFeature = FormPredefined.SetMixtureFeature(FileNamePathComplete, FileName, Me.MixtureComponents)
            FormMixInfo.TBPerSummary = FormPredefined.CreateTBPerSummaryinFormInput(Me.MixtureFeature, Me.MixtureComponents).Copy
            FormMixInfo.MixtureFeature = Me.MixtureFeature
            FormMixInfo.ShowDialog()

            'YYJ[2020.1119]ltgen2: make a portable version - s
        ElseIf CBool(RowToFind("UserMixture")) = True And My.Computer.FileSystem.FileExists(ApplicationFolder & "\UserDefinedMixture\" & FileName) Then
            FileNamePathComplete = ApplicationFolder & "\UserDefinedMixture\" & FileName
            'ElseIf CBool(RowToFind("UserMixture")) = True And My.Computer.FileSystem.FileExists(UserApplicationFolder & "\UserDefinedMixture\" & FileName) Then
            '    FileNamePathComplete = UserApplicationFolder & "\UserDefinedMixture\" & FileName
            'YYJ[2020.1119]ltgen2: make a portable version - e

            Me.MixtureFeature = FormPredefined.SetMixtureFeature(FileNamePathComplete, FileName, Me.MixtureComponents)
            FormMixInfo.TBPerSummary = FormPredefined.CreateTBPerSummaryinFormInput(Me.MixtureFeature, Me.MixtureComponents).Copy
            FormMixInfo.MixtureFeature = Me.MixtureFeature
            FormMixInfo.ShowDialog()
        Else
            MsgBox("Mixture file does not exist. Please select another fluid or add this particular fluid to the fluids subdirectory.")
        End If
        Me.Enabled = True
    End Sub
    Friend Shared Function SetMixtureFeature(ByVal FileNameCompletePath As String, ByVal FileName As String, ByRef MixtureComponentsDummy() As FluidFeatureSTR) As FluidFeatureSTR
        Dim TempString As String
        Dim hfldSTR As String = ""
        Dim herr(254), hfmix(254) As Char
        Dim hrf(2) As Char
        Dim hfld(9999) As Char
        Dim ierr As Integer
        Dim TcFile As Double
        Dim h0ref, s0ref, t0ref, p0ref As Double
        Dim MixtureFeatureLocal As FluidFeatureSTR = Nothing

        FileOpen(1, FileNameCompletePath, OpenMode.Input)

        With MixtureFeatureLocal
            Input(1, .fluid)

            Input(1, .wm)
            Input(1, .tc)  'overwritten below using Refprop routine
            Input(1, .pc)
            Input(1, .dc)
            Input(1, .nc)
            .wmstring = CStr(.wm)
            .tcstring = CStr(.tc)
            .pcstring = CStr(.pc)
            .dcstring = CStr(.dc)
            .fullname = String.Empty
            .chemname = String.Empty
            .FileName = FileName
            .junk = String.Empty
            .tnbptstring = String.Empty
            .acfstring = String.Empty

            If Internat Then
                .wmstring = Replace(.wmstring, ".", ",")
                .wm = CDbl(.wmstring)
                .tcstring = Replace(.tcstring, ".", ",")
                .tc = CDbl(.tcstring)
                .pcstring = Replace(.pcstring, ".", ",")
                .pc = CDbl(.pcstring)
                .dcstring = Replace(.dcstring, ".", ",")
                .dc = CDbl(.dcstring)
            End If
            ReDim .comp(NMaxRefrigrants - 1), .X(NMaxRefrigrants - 1)

            For i As Integer = 0 To NMaxRefrigrants - 1
                If i <= .nc - 1 Then
                    Input(1, .comp(i))
                Else
                    .comp(i) = "."
                End If
            Next i

            For i As Integer = 0 To NMaxRefrigrants - 1
                If i <= .nc - 1 Then
                    Input(1, .X(i))
                Else
                    .X(i) = 0.0
                End If
                If Internat Then
                    TempString = CStr(.X(i))
                    TempString = Replace(TempString, ".", ",")
                    .X(i) = CDbl(TempString)
                End If
            Next i

            FileClose(1)



            'YYJ[2020.0425]ltgen2: remove RfLkDLL - e
            'Dim FS As String
            'FS = "|fluids\" 'YYJ[2020.0305] specify full path string

            'TcFile = .tc
            ''If .nc = 1 Then
            ''    hfld = CType("fluids\" & .comp(0) & "|fluids\" & .comp(1) & "|", Char())
            ''ElseIf .nc = 2 Then
            ''    hfld = CType("fluids\" & .comp(0) & "|fluids\" & .comp(1) & "|" & .comp(2) & "|", Char())
            ''ElseIf .nc = 3 Then
            ''    hfld = CType("fluids\" & .comp(0) & "|fluids\" & .comp(1) & "|" & .comp(2) & "|" & .comp(3) & "|", Char())
            ''ElseIf .nc = 4 Then
            ''    hfld = CType("fluids\" & .comp(0) & "|fluids\" & .comp(1) & "|" & .comp(2) & "|" & .comp(3) & "|" & .comp(4) & "|", Char())
            ''End If
            'If .nc = 2 Then
            '    hfldSTR = "fluids\" & .comp(0) & FS & .comp(1) & "|"
            'ElseIf .nc = 3 Then
            '    hfldSTR = "fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & "|"
            'ElseIf .nc = 4 Then
            '    hfldSTR = "fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & "|"
            'ElseIf .nc = 5 Then
            '    hfldSTR = "fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & "|"
            'ElseIf .nc = 6 Then
            '    hfldSTR = "fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & FS & .comp(5) & "|"
            'ElseIf .nc = 7 Then
            '    hfldSTR = "fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & FS & .comp(5) & FS & .comp(6) & "|"
            'ElseIf .nc = 8 Then
            '    hfldSTR = "fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & FS & .comp(5) & FS & .comp(6) & FS & .comp(7) & "|"
            'ElseIf .nc = 9 Then
            '    hfldSTR = "fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & FS & .comp(5) & FS & .comp(6) & FS & .comp(7) & FS & .comp(8) & "|"
            'ElseIf .nc = 10 Then
            '    hfldSTR = "fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & FS & .comp(5) & FS & .comp(6) & FS & .comp(7) & FS & .comp(8) & FS & .comp(9) & "|"
            'End If

            'Array.ConstrainedCopy(CType(hfldSTR, Char()), 0, hfld, 0, hfldSTR.Length)
            'Array.ConstrainedCopy(CType("fluids\hmx.bnc", Char()), 0, hfmix, 0, "fluids\hmx.bnc".Length)
            'Array.ConstrainedCopy(CType("DEF", Char()), 0, hrf, 0, "DEF".Length)

            ''YYJ[2020.0305] I/F with Wrapper - s
            'Dim hFldSTR2, hFmixSTR, hRfSTR, hErrSTR As String
            'Dim nFld_len, nFmix_len, nRf_len, nErr_len As Integer

            'hFldSTR2 = CStr(hfld)

            'hFmixSTR = CStr(hfmix)
            'hFmixSTR += Space(255 - hFmixSTR.Length())

            'hRfSTR = CStr(hrf)

            'hErrSTR = Space(255)
            'nFld_len = hFldSTR2.Length()
            'nFmix_len = hFmixSTR.Length()
            'nRf_len = hRfSTR.Length()
            'nErr_len = hErrSTR.Length()
            'Call SETUP0(.nc, hFldSTR2, hFmixSTR, hRfSTR, ierr, hErrSTR, nFld_len, nFmix_len, nRf_len, nErr_len)

            'If (.nc > 1) Then
            '    Call SETREF_dll(hRfSTR, 2, .X(0), h0ref, s0ref, t0ref, p0ref, ierr, hErrSTR, nRf_len, nErr_len)
            'End If

            'Call SATSPLN_dll(.X(0), ierr, hErrSTR, nErr_len)
            'Call CRITP_dll(.X(0), .tc, .pc, .dc, ierr, hErrSTR, nErr_len)
            ''YYJ[2020.0305] I/F with Wrapper - e


            'If .FileName = "R401C.mix" And .tc < 384.5 Then ' if to take of when Refprop will be updated to version 9.1.1
            '    .tc = TcFile
            'End If
            'YYJ[2020.0425]ltgen2: remove RfLkDLL - e




            'Remember: the molar fraxion will exit by this method
            'Set the arry having each mixture component feature
            ReDim MixtureComponentsDummy(.nc - 1)
            For i As Integer = 0 To .nc - 1
                MixtureComponentsDummy(i) = FormPure.SetFluidFeature(.comp(i))
            Next i
            'calculate the mixture mass fraction
            ReDim .WmElements(.nc - 1)
            For i As Integer = 0 To .nc - 1
                .WmElements(i) = .X(i) * MixtureComponentsDummy(i).wm / .wm
            Next i
        End With
        Return MixtureFeatureLocal
    End Function

End Class