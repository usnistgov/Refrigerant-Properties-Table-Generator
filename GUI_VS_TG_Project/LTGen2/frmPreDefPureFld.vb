Imports System.Diagnostics
Public Class frmPreDefPureFld 'YYJ[2020.0425]ltgen2: << Public Class FormPredefined
    Friend PureFldFeature As FluidFeatureSTR 'MixtureFeature
    'Friend PureFldComponents() As FluidFeatureSTR 'MixtureComponents()
    Private ListPureFldDT As DataTable 'ListMixtureDT
    Friend PushOk As Boolean = False
    Friend SelectedFluidIndex As Integer
    Friend SelectedFluidName(2) As String   '0:NameMixture; 1:NameMixtureUser; 2:MixtureStored

    Private Function Get_PureFld_ShorName(ByVal FileName As String) As String
        'YYJ[2020.0704]ltgen2: when the pure fluid file name is given as an arguent, this function returns the 'short name' of the pure fluid

        Dim strResult, FileNamePathComplete, File_1stLine As String
        Dim ExtractPos As Integer
        FileNamePathComplete = My.Application.Info.DirectoryPath & "\FLUIDS\" & FileName

        Dim PureFldReader As New System.IO.StreamReader(FileNamePathComplete)
        File_1stLine = PureFldReader.ReadLine()
        PureFldReader.Close()

        'YYJ[2020.0727]ltgen2: bugfix on parsing the short name - s
        ExtractPos = InStr(1, File_1stLine, "!", CompareMethod.Text)
        strResult = Mid(File_1stLine, 1, ExtractPos - 1).Trim()
        'ExtractPos = InStr(1, File_1stLine, " ", CompareMethod.Text)
        'strResult = Mid(File_1stLine, 1, ExtractPos - 1)
        'YYJ[2020.0727]ltgen2: bugfix on parsing the short name - e
        Return strResult

    End Function
    Private Sub frmPreDefPureFld_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'YYJ[2020.0425]ltgen2: << Private Sub FormPredefined_Load
        Dim ListPureFldLocalDT As New DataTable 'ListMixtureLocalDT
        Dim ListPureFldDW As New DataView 'ListMixtureDW
        Dim RowDummy As DataRow
        Dim Cont As Int32 = 0
        Dim snextfile, fluid As String
        Dim ExtentionLength As Integer
        Dim ShortName As String 'YYJ[2020.0704]ltgen2: handling ShortName

        'Create the DataTable
        With ListPureFldLocalDT
            .Columns.Add("IdPureFld", System.Type.GetType("System.Int32")) 'ListMixtureLocalDT.Columns.Add("IdMixture", System.Type.GetType("System.Int32"))
            .Columns.Add("NamePureFld", System.Type.GetType("System.String")) 'ListMixtureLocalDT.Columns.Add("NameMixture", System.Type.GetType("System.String"))
            .Columns.Add("UsrDefined_PureFld", System.Type.GetType("System.Boolean")) 'ListMixtureLocalDT.Columns.Add("UserMixture", System.Type.GetType("System.Boolean"))
            .Columns.Add("ShortName", System.Type.GetType("System.String")) 'YYJ[2020.0704]ltgen2: add DB entry: 'ShortName'
            .PrimaryKey = New DataColumn() {ListPureFldLocalDT.Columns("IdPureFld")} 'ListMixtureLocalDT.PrimaryKey = New DataColumn() {ListMixtureLocalDT.Columns("IdMixture")}
        End With

        ' Do not modify cont here, else uncomment before the for : ' Cont = ListaFluidiDT.Rows.Count
        For Each file As System.IO.FileInfo In My.Computer.FileSystem.GetDirectoryInfo(My.Application.Info.DirectoryPath & "\FLUIDS\").GetFiles 'For Each file As System.IO.FileInfo In My.Computer.FileSystem.GetDirectoryInfo(My.Application.Info.DirectoryPath & "\mixtures\").GetFiles
            If file.Extension.ToUpper() = ".FLD" Then 'consider only *.FLD file
                fluid = file.Name
                ExtentionLength = file.Extension.Length
                snextfile = Strings.Left(fluid, fluid.Length - ExtentionLength)

                ShortName = Get_PureFld_ShorName(fluid) 'YYJ[2020.0704]ltgen2: handling ShortName
                'Console.WriteLine(snextfile + "---" + ShortName) 'YYJ[2020.0704]ltgen2: DBG: handling ShortName

                ' Add the refrigerant to the DataTable
                RowDummy = ListPureFldLocalDT.NewRow 'RowDummy = ListMixtureLocalDT.NewRow
                RowDummy("IdPureFld") = Cont 'RowDummy("IdMixture") = Cont
                RowDummy("NamePureFld") = snextfile 'RowDummy("NameMixture") = snextfile
                RowDummy("UsrDefined_PureFld") = False 'RowDummy("UserMixture") = False
                RowDummy("ShortName") = ShortName 'YYJ[2020.0704]ltgen2: add DB entry: 'ShortName'
                ListPureFldLocalDT.Rows.Add(RowDummy) 'ListMixtureLocalDT.Rows.Add(RowDummy)
                Cont = Cont + 1
            Else
                Continue For
            End If
        Next

        ListPureFldDW = ListPureFldLocalDT.DefaultView 'ListMixtureDW = ListMixtureLocalDT.DefaultView

        ListPureFldDW.Sort() = "ShortName" 'ListMixtureDW.Sort() = "NameMixture"
        'ListPureFldDW.Sort() = "NamePureFld" 'ListMixtureDW.Sort() = "NameMixture"

        With Me.lstPreDefPureFld
            .DataSource = ListPureFldDW 'Me.lstPredefined.DataSource = ListMixtureDW
            .ValueMember = "IdPureFld" 'Me.lstPredefined.ValueMember = "IdMixture"

            'YYJ[2020.0704]ltgen2: Handling ShortName - s
            .DisplayMember = "ShortName" 'Me.lstPredefined.DisplayMember = "NameMixture"
            '.DisplayMember = "NamePureFld" 'Me.lstPredefined.DisplayMember = "NameMixture"
            'YYJ[2020.0704]ltgen2: Handling ShortName - e

            .SelectedValue = 0 'Me.lstPredefined.SelectedValue = Me.SelectedFluidIndex
        End With

        Me.ListPureFldDT = ListPureFldLocalDT.Copy 'Me.ListMixtureDT = ListMixtureLocalDT.Copy
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click 'YYJ[2020.0425]ltgen2: << Private Sub cmdCancel_Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click, lstPreDefPureFld.DoubleClick 'YYJ[2020.0425]ltgen2: << Private Sub cmdOk_Click
        Dim FileNamePathComplete, FileName As String
        Dim RowToFind As DataRow

        RowToFind = ListPureFldDT.Rows.Find(Me.lstPreDefPureFld.SelectedValue) 'RowToFind = ListMixtureDT.Rows.Find(Me.lstPredefined.SelectedValue)

        FileName = CStr(RowToFind("NamePureFld")) 'FileName = CStr(RowToFind("NameMixture"))
        FileName = FileName & ".FLD" 'FileName = FileName & ".mix"

        If CBool(RowToFind("UsrDefined_PureFld")) = False And
           My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\FLUIDS\" & FileName) Then 'If CBool(RowToFind("UserMixture")) = False And My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\mixtures\" & FileName) Then

            FileNamePathComplete = My.Application.Info.DirectoryPath & "\FLUIDS\" & FileName 'FileNamePathComplete = My.Application.Info.DirectoryPath & "\mixtures\" & FileName
            Me.PureFldFeature = frmPreDefPureFld.SetPureFldFeature(FileNamePathComplete, FileName) 'Me.MixtureFeature = FormPredefined.SetMixtureFeature(FileNamePathComplete, FileName, Me.MixtureComponents)

            PushOk = True
            Me.SelectedFluidIndex = CInt(RowToFind("IdPureFld")) 'Me.SelectedFluidIndex = CInt(RowToFind("IdMixture"))
            Me.SelectedFluidName(0) = CStr(RowToFind("NamePureFld")) 'Me.SelectedFluidName(0) = CStr(RowToFind("NameMixture"))
            Me.SelectedFluidName(1) = CStr(RowToFind("UsrDefined_PureFld")) 'Me.SelectedFluidName(1) = CStr(RowToFind("UserMixture"))
            Me.SelectedFluidName(2) = "True"
            Me.Close()

            'YYJ[2020.1119]ltgen2: remove unused codes - s
            'ElseIf CBool(RowToFind("UsrDefined_PureFld")) = True And
            '    My.Computer.FileSystem.FileExists(UserApplicationFolder & "\__UserDefinedPureFluid\" & FileName) Then 'ElseIf CBool(RowToFind("UserMixture")) = True And My.Computer.FileSystem.FileExists(UserApplicationFolder & "\UserDefinedMixture\" & FileName) Then

            '    FileNamePathComplete = UserApplicationFolder & "\__UserDefinedPureFluid\" & FileName 'FileNamePathComplete = UserApplicationFolder & "\UserDefinedMixture\" & FileName
            '    Me.PureFldFeature = frmPreDefPureFld.SetPureFldFeature(FileNamePathComplete, FileName) 'Me.MixtureFeature = FormPredefined.SetMixtureFeature(FileNamePathComplete, FileName, Me.MixtureComponents)

            '    PushOk = True
            '    Me.SelectedFluidIndex = CInt(RowToFind("IdPureFld")) 'Me.SelectedFluidIndex = CInt(RowToFind("IdMixture"))
            '    Me.SelectedFluidName(0) = CStr(RowToFind("NamePureFld")) 'Me.SelectedFluidName(0) = CStr(RowToFind("NameMixture"))
            '    Me.SelectedFluidName(1) = CStr(RowToFind("UsrDefined_PureFld")) 'Me.SelectedFluidName(1) = CStr(RowToFind("UserMixture"))
            '    Me.SelectedFluidName(2) = "False"
            '    Me.Close()
            'YYJ[2020.1119]ltgen2: remove unused codes - e

        Else
            MsgBox("PureFld(org=Mixture) file does not exist. Please select another fluid or add this particular fluid to the fluids subdirectory.")
        End If
    End Sub

    Friend Shared Function CreateTBPerSummary_PureFld_frmInput(ByVal PureFldFeatureLocal As FluidFeatureSTR) As DataTable 'YYJ[2020.0425]ltgen2: << Friend Shared Function CreateTBPerSummaryinFormInput
        Dim SummaryTB As New DataTable
        Dim Row As DataRow

        With SummaryTB.Columns
            .Add("Component", System.Type.GetType("System.String"))
            .Add("MoleFraction", System.Type.GetType("System.Double"))
            .Add("MassFraction", System.Type.GetType("System.Double"))

            'YYJ[2020.0727]ltgen2: Saving *.FLD filename to TableInfo.txt
            .Add("FLD", System.Type.GetType("System.String"))
        End With

        For i As Integer = 0 To PureFldFeatureLocal.nc - 1 'For i As Integer = 0 To MixtureFeatureLocal.nc - 1
            Row = SummaryTB.NewRow
            Row("Component") = PureFldFeatureLocal.fluid  'Row("Component") = MixtureComponents(i).fluid
            Row("MoleFraction") = 1.0 'PureFldFeatureLocal.X(i) 'Row("MoleFraction") = MixtureFeatureLocal.X(i)
            Row("MassFraction") = 1.0 'PureFldFeatureLocal.WmElements(i) 'Row("MassFraction") = MixtureFeatureLocal.WmElements(i)

            'YYJ[2020.0727]ltgen2: Saving *.FLD filename to TableInfo.txt (update DB)
            'Row("FLD") = PureFldFeatureLocal.comp(0)
            Row("FLD") = PureFldFeatureLocal.FileName.ToUpper()

            SummaryTB.Rows.Add(Row)
        Next i
        Return SummaryTB
    End Function

    Private Sub cmdInfo_Click(sender As Object, e As EventArgs) Handles cmdInfo.Click 'YYJ[2020.0425]ltgen2: << Private Sub cmdInfo_Click
        '이거는 포팅 안옮겨도 될 것 같은데...?
        MsgBox("이거는 안옮겨도 될 것 같은데...?")
    End Sub

    Friend Shared Function SetPureFldFeature(ByVal FileNameCompletePath As String, ByVal FileName As String) As FluidFeatureSTR 'YYJ[2020.0425]ltgen2: Friend Shared Function SetMixtureFeature
        Dim TempString As String = ""
        Dim hfldSTR As String = ""
        Dim herr(254), hfmix(254) As Char
        Dim hrf(2) As Char
        Dim hfld(9999) As Char
        Dim PureFldFeatureLocal As FluidFeatureSTR = Nothing 'Dim MixtureFeatureLocal As ...
        Dim a As Integer = 0
        Dim xName As String
        Dim PureFldReader As New System.IO.StreamReader(FileNameCompletePath)
        TempString = PureFldReader.ReadLine()
        PureFldReader.Close()


        'FileOpen(1, FileNameCompletePath, OpenMode.Input)

        With PureFldFeatureLocal 'With MixtureFeatureLocal

            'YYJ[2020.0727]ltgen2: bugfix on parsing the short name - s 'YYJ[2020.0704]ltgen2: Handling ShortName - s
            a = InStr(1, TempString, "!", CompareMethod.Text)
            .ShortName = Mid(TempString, 1, a - 1).Trim()
            'a = InStr(1, TempString, " ", CompareMethod.Text)
            '.ShortName = Mid(TempString, 1, a - 1)
            'YYJ[2020.0727]ltgen2: bugfix on parsing the short name - e 'YYJ[2020.0704]ltgen2: Handling ShortName - e

            'xName = TempString : a = InStr(1, xName, " ", CompareMethod.Text) 'using Short name
            xName = FileName : a = InStr(1, xName, ".", CompareMethod.Text) 'using File name
            .fluid = Mid(xName, 1, a - 1) 'Input(1, .fluid)

            .wm = 1.0 'Input(1, .wm)
            .tc = -999.9 'Input(1, .tc)  'overwritten below using Refprop routine
            .pc = -999.9 'Input(1, .pc)
            .dc = -999.9 'Input(1, .dc)
            .nc = 1 'Input(1, .nc)
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

            'YYJ[2020.0728]ltgen2: .comp contains the filename(*.FLD) of the component
            .comp(0) = FileName   '.comp(0) = .fluid

            'For i As Integer = 0 To NMaxRefrigrants - 1
            '    If i <= .nc - 1 Then
            '        Input(1, .comp(i))
            '    Else
            '        .comp(i) = "."
            '    End If
            'Next i

            .X(0) = 1.0
            'For i As Integer = 0 To NMaxRefrigrants - 1
            '    If i <= .nc - 1 Then
            '        Input(1, .X(i))
            '    Else
            '        .X(i) = 0.0
            '    End If
            '    If Internat Then
            '        TempString = CStr(.X(i))
            '        TempString = Replace(TempString, ".", ",")
            '        .X(i) = CDbl(TempString)
            '    End If
            'Next i

            'FileClose(1)

            ''Remember: the molar fraxion will exit by this method
            'ReDim PureFldComponentsDummy(.nc - 1) 'ReDim MixtureComponentsDummy(.nc - 1)
            'For i As Integer = 0 To .nc - 1
            '    PureFldComponentsDummy(i) = Me.PureFldFeature  'MixtureComponentsDummy(i) = FormPure.SetFluidFeature(.comp(i))
            'Next i

            ''calculate the mixture mass fraction
            ReDim .WmElements(.nc - 1)
            .WmElements(0) = 1.0
            'ReDim .WmElements(.nc - 1)
            'For i As Integer = 0 To .nc - 1
            '    .WmElements(i) = .X(i) * PureFldComponentsDummy(i).wm / .wm '.WmElements(i) = .X(i) * MixtureComponentsDummy(i).wm / .wm
            'Next i
        End With

        'ReDim PureFldComponentsDummy(PureFldFeatureLocal.nc - 1)
        'PureFldComponentsDummy(0) = PureFldFeatureLocal

        Return PureFldFeatureLocal 'Return MixtureFeatureLocal
    End Function
End Class