Public Class FormPredefined
    Friend MixtureFeature As FluidFeatureSTR
    Friend MixtureComponents() As FluidFeatureSTR
    Private ListMixtureDT As DataTable
    Friend PushOk As Boolean = False
    Friend SelectedFluiIndex As Integer
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
        For Each file As System.IO.FileInfo In My.Computer.FileSystem.GetDirectoryInfo(My.Application.Info.DirectoryPath & "\mixtures\").GetFiles
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
        Next

        If Not My.Computer.FileSystem.DirectoryExists(UserApplicationFolder & "\UserDefinedMixture") Then
            My.Computer.FileSystem.CreateDirectory(UserApplicationFolder & "\UserDefinedMixture")
        End If

        For Each file As System.IO.FileInfo In My.Computer.FileSystem.GetDirectoryInfo(UserApplicationFolder & "\UserDefinedMixture").GetFiles

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
        Next

        ListMixtureDW = ListMixtureLocalDT.DefaultView
        ListMixtureDW.Sort() = "NameMixture"
        Me.lstPredefined.DataSource = ListMixtureDW
        Me.lstPredefined.ValueMember = "IdMixture"
        Me.lstPredefined.DisplayMember = "NameMixture"
        Me.lstPredefined.SelectedValue = Me.SelectedFluiIndex
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
        If CBool(RowToFind("UserMixture")) = False And My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\mixtures\" & FileName) Then
            FileNamePathComplete = My.Application.Info.DirectoryPath & "\mixtures\" & FileName
            Me.MixtureFeature = FormPredefined.SetMixtureFeature(FileNamePathComplete, FileName, Me.MixtureComponents)
            PushOk = True
            Me.SelectedFluiIndex = CInt(RowToFind("IdMixture"))
            Me.SelectedFluidName(0) = CStr(RowToFind("NameMixture"))
            Me.SelectedFluidName(1) = CStr(RowToFind("UserMixture"))
            Me.SelectedFluidName(2) = "True"
            Me.Close()
        ElseIf CBool(RowToFind("UserMixture")) = True And My.Computer.FileSystem.FileExists(UserApplicationFolder & "\UserDefinedMixture\" & FileName) Then
            FileNamePathComplete = UserApplicationFolder & "\UserDefinedMixture\" & FileName
            Me.MixtureFeature = FormPredefined.SetMixtureFeature(FileNamePathComplete, FileName, Me.MixtureComponents)
            Me.SelectedFluiIndex = CInt(RowToFind("IdMixture"))
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
        SummaryTB.Columns.Add("Mole Fraction", System.Type.GetType("System.Double"))
        SummaryTB.Columns.Add("Mass Fraction", System.Type.GetType("System.Double"))
        For i As Integer = 0 To MixtureFeatureLocal.nc - 1
            Row = SummaryTB.NewRow
            Row("Component") = MixtureComponents(i).fluid
            Row("Mole Fraction") = MixtureFeatureLocal.X(i)
            Row("Mass Fraction") = MixtureFeatureLocal.WmElements(i)
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

        If CBool(RowToFind("UserMixture")) = False And My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\mixtures\" & FileName) Then
            FileNamePathComplete = My.Application.Info.DirectoryPath & "\mixtures\" & FileName
            Me.MixtureFeature = FormPredefined.SetMixtureFeature(FileNamePathComplete, FileName, Me.MixtureComponents)
            FormMixInfo.TBPerSummary = FormPredefined.CreateTBPerSummaryinFormInput(Me.MixtureFeature, Me.MixtureComponents).Copy
            FormMixInfo.MixtureFeature = Me.MixtureFeature
            FormMixInfo.ShowDialog()
        ElseIf CBool(RowToFind("UserMixture")) = True And My.Computer.FileSystem.FileExists(UserApplicationFolder & "\UserDefinedMixture\" & FileName) Then
            FileNamePathComplete = UserApplicationFolder & "\UserDefinedMixture\" & FileName
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
        Dim MixtureFeatureLocal As FluidFeatureSTR = Nothing
        FileOpen(1, FileNameCompletePath, OpenMode.Input)
        With MixtureFeatureLocal
            Input(1, .fluid)
            Input(1, .wm)
            Input(1, .tc)
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
            'If .nc = 1 Then
            '    hfld = CType("fluids\" & .comp(0) & "|fluids\" & .comp(1) & "|", Char())
            'ElseIf .nc = 2 Then
            '    hfld = CType("fluids\" & .comp(0) & "|fluids\" & .comp(1) & "|" & .comp(2) & "|", Char())
            'ElseIf .nc = 3 Then
            '    hfld = CType("fluids\" & .comp(0) & "|fluids\" & .comp(1) & "|" & .comp(2) & "|" & .comp(3) & "|", Char())
            'ElseIf .nc = 4 Then
            '    hfld = CType("fluids\" & .comp(0) & "|fluids\" & .comp(1) & "|" & .comp(2) & "|" & .comp(3) & "|" & .comp(4) & "|", Char())
            'End If
            'hfmix = CType("fluids\hmx.bnc", Char())
            'hrf = CType("DEF", Char())
            'Call SETUPdll(.nc, hfld, hfmix, hrf, ierr, herr, 10000, 255, 3, 255)
            'If (.nc > 1) Then Call SETREFdll("DEF", 2, x0ref, h0ref, s0ref, t0ref, p0ref, ierr, herr, 3, 255)
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