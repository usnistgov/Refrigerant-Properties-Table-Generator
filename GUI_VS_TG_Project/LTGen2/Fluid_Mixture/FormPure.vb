Public Class FormPure
    Private ListaFluidiDT As DataTable
    Friend FluidFeature As FluidFeatureSTR
    Friend PushOk As Boolean = False
    Friend TypeRefrigerant As Integer      '0: Pure; 1: Predefined; 2: UserDefinedMixture
    Friend SelectedFluidIndex As Integer
    Friend SelectedFluidName(2) As String  '0:NameFluidoCode; 1:NameFluidoUser; 2:NameFluidoFile
    Private Sub FormPure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ListaFluidiLocalDT As New DataTable
        Dim ListaFluidiDW As New DataView
        Dim RowDummy As DataRow
        Dim Cont As Int32 = 0
        Dim snextfile, fluid As String
        Dim fluid2string, casstring, fullnamestring, fullname As String
        Dim name1, name2, name3 As String
        Dim chrpos, ExtentionLength As Integer

        'YYJ[2020.0504]ltgen2: Remove unused codes - s
        ''Create the DataTable
        'ListaFluidiLocalDT.Columns.Add("IdFluido", System.Type.GetType("System.Int32"))
        'ListaFluidiLocalDT.Columns.Add("NameFluidoCode", System.Type.GetType("System.String"))
        'ListaFluidiLocalDT.Columns.Add("NameFluidoUser", System.Type.GetType("System.String"))
        'ListaFluidiLocalDT.Columns.Add("NameFluidoFile", System.Type.GetType("System.String"))
        'ListaFluidiLocalDT.PrimaryKey = New DataColumn() {ListaFluidiLocalDT.Columns("IdFluido")}
        'For Cont = 0 To 29  '26
        '    RowDummy = ListaFluidiLocalDT.NewRow
        '    RowDummy("IdFluido") = Cont
        '    ListaFluidiLocalDT.Rows.Add(RowDummy)
        'Next Cont
        'ListaFluidiLocalDT.Rows(0).Item("NameFluidoCode") = "neopentane"
        'ListaFluidiLocalDT.Rows(1).Item("NameFluidoCode") = "acetone"
        'ListaFluidiLocalDT.Rows(2).Item("NameFluidoCode") = "ammonia"
        'ListaFluidiLocalDT.Rows(3).Item("NameFluidoCode") = "benzene"
        'ListaFluidiLocalDT.Rows(4).Item("NameFluidoCode") = "butane"
        'ListaFluidiLocalDT.Rows(5).Item("NameFluidoCode") = "butene"
        'ListaFluidiLocalDT.Rows(6).Item("NameFluidoCode") = "carbon dioxide"
        'ListaFluidiLocalDT.Rows(7).Item("NameFluidoCode") = "cis-butene"
        'ListaFluidiLocalDT.Rows(8).Item("NameFluidoCode") = "cyclohexane"
        'ListaFluidiLocalDT.Rows(9).Item("NameFluidoCode") = "cyclopropane"
        'ListaFluidiLocalDT.Rows(10).Item("NameFluidoCode") = "dimethylether"
        'ListaFluidiLocalDT.Rows(11).Item("NameFluidoCode") = "perfluoropentane"
        'ListaFluidiLocalDT.Rows(12).Item("NameFluidoCode") = "dodecane"
        'ListaFluidiLocalDT.Rows(13).Item("NameFluidoCode") = "ethane"
        'ListaFluidiLocalDT.Rows(14).Item("NameFluidoCode") = "ethanol"
        'ListaFluidiLocalDT.Rows(15).Item("NameFluidoCode") = "ethylene"
        'ListaFluidiLocalDT.Rows(16).Item("NameFluidoCode") = "heptane"
        'ListaFluidiLocalDT.Rows(17).Item("NameFluidoCode") = "hexane"
        'ListaFluidiLocalDT.Rows(18).Item("NameFluidoCode") = "isobutane"
        'ListaFluidiLocalDT.Rows(19).Item("NameFluidoCode") = "isobutene"
        'ListaFluidiLocalDT.Rows(20).Item("NameFluidoCode") = "isohexane"
        'ListaFluidiLocalDT.Rows(21).Item("NameFluidoCode") = "isopentane"
        'ListaFluidiLocalDT.Rows(22).Item("NameFluidoCode") = "methane"
        'ListaFluidiLocalDT.Rows(23).Item("NameFluidoCode") = "methanol"
        'ListaFluidiLocalDT.Rows(24).Item("NameFluidoCode") = "pentane"
        'ListaFluidiLocalDT.Rows(25).Item("NameFluidoCode") = "propane"
        'ListaFluidiLocalDT.Rows(26).Item("NameFluidoCode") = "propylene"
        'ListaFluidiLocalDT.Rows(27).Item("NameFluidoCode") = "sulfur hexafluoride"
        'ListaFluidiLocalDT.Rows(28).Item("NameFluidoCode") = "trans-butene"
        'ListaFluidiLocalDT.Rows(29).Item("NameFluidoCode") = "trifluoroiodomethane"

        'ListaFluidiLocalDT.Rows(0).Item("NameFluidoUser") = "2,2-dimethylpropane"
        'ListaFluidiLocalDT.Rows(1).Item("NameFluidoUser") = "acetone"
        'ListaFluidiLocalDT.Rows(2).Item("NameFluidoUser") = "ammonia"
        'ListaFluidiLocalDT.Rows(3).Item("NameFluidoUser") = "benzene"
        'ListaFluidiLocalDT.Rows(4).Item("NameFluidoUser") = "butane"
        'ListaFluidiLocalDT.Rows(5).Item("NameFluidoUser") = "butene (1-butene)"
        'ListaFluidiLocalDT.Rows(6).Item("NameFluidoUser") = "carbon dioxide"
        'ListaFluidiLocalDT.Rows(7).Item("NameFluidoUser") = "cis-2-butene"
        'ListaFluidiLocalDT.Rows(8).Item("NameFluidoUser") = "cyclohexane"
        'ListaFluidiLocalDT.Rows(9).Item("NameFluidoUser") = "cyclopropane"
        'ListaFluidiLocalDT.Rows(10).Item("NameFluidoUser") = "dimethylether (methoxymethane)"
        'ListaFluidiLocalDT.Rows(11).Item("NameFluidoUser") = "perfluoropentane"
        'ListaFluidiLocalDT.Rows(12).Item("NameFluidoUser") = "dodecane"
        'ListaFluidiLocalDT.Rows(13).Item("NameFluidoUser") = "ethane"
        'ListaFluidiLocalDT.Rows(14).Item("NameFluidoUser") = "ethanol (ethyl alcohol)"
        'ListaFluidiLocalDT.Rows(15).Item("NameFluidoUser") = "ethylene(ethene)"
        'ListaFluidiLocalDT.Rows(16).Item("NameFluidoUser") = "heptane"
        'ListaFluidiLocalDT.Rows(17).Item("NameFluidoUser") = "hexane"
        'ListaFluidiLocalDT.Rows(18).Item("NameFluidoUser") = "isobutane (2 - methylpropane)"
        'ListaFluidiLocalDT.Rows(19).Item("NameFluidoUser") = "isobutene (2-methyl-1-propene)"
        'ListaFluidiLocalDT.Rows(20).Item("NameFluidoUser") = "isohexane (2 - methylpentane)"
        'ListaFluidiLocalDT.Rows(21).Item("NameFluidoUser") = "isopentane (2 - methylbutane)"
        'ListaFluidiLocalDT.Rows(22).Item("NameFluidoUser") = "methane"
        'ListaFluidiLocalDT.Rows(23).Item("NameFluidoUser") = "methanol"
        'ListaFluidiLocalDT.Rows(24).Item("NameFluidoUser") = "pentane"
        'ListaFluidiLocalDT.Rows(25).Item("NameFluidoUser") = "propane"
        'ListaFluidiLocalDT.Rows(26).Item("NameFluidoUser") = "propylene (propene)"
        'ListaFluidiLocalDT.Rows(27).Item("NameFluidoUser") = "sulfur hexafluoride"
        'ListaFluidiLocalDT.Rows(28).Item("NameFluidoUser") = "trans-butene"
        'ListaFluidiLocalDT.Rows(29).Item("NameFluidoUser") = "trifluoroiodomethane"

        'ListaFluidiLocalDT.Rows(0).Item("NameFluidoFile") = "neopentn.fld"
        'ListaFluidiLocalDT.Rows(1).Item("NameFluidoFile") = "acetone.fld"
        'ListaFluidiLocalDT.Rows(2).Item("NameFluidoFile") = "ammonia.fld"
        'ListaFluidiLocalDT.Rows(3).Item("NameFluidoFile") = "benzene.fld"
        'ListaFluidiLocalDT.Rows(4).Item("NameFluidoFile") = "butane.fld"
        'ListaFluidiLocalDT.Rows(5).Item("NameFluidoFile") = "1butene.fld"
        'ListaFluidiLocalDT.Rows(6).Item("NameFluidoFile") = "CO2.fld"
        'ListaFluidiLocalDT.Rows(7).Item("NameFluidoFile") = "c2butene.fld"
        'ListaFluidiLocalDT.Rows(8).Item("NameFluidoFile") = "cyclohex.fld"
        'ListaFluidiLocalDT.Rows(9).Item("NameFluidoFile") = "cyclopro.fld"
        'ListaFluidiLocalDT.Rows(10).Item("NameFluidoFile") = "dme.fld"
        'ListaFluidiLocalDT.Rows(11).Item("NameFluidoFile") = "c5f12.fld"
        'ListaFluidiLocalDT.Rows(12).Item("NameFluidoFile") = "c12.fld"
        'ListaFluidiLocalDT.Rows(13).Item("NameFluidoFile") = "ethane.fld"
        'ListaFluidiLocalDT.Rows(14).Item("NameFluidoFile") = "ethanol.fld"
        'ListaFluidiLocalDT.Rows(15).Item("NameFluidoFile") = "ethylene.fld"
        'ListaFluidiLocalDT.Rows(16).Item("NameFluidoFile") = "heptane.fld"
        'ListaFluidiLocalDT.Rows(17).Item("NameFluidoFile") = "hexane.fld"
        'ListaFluidiLocalDT.Rows(18).Item("NameFluidoFile") = "isobutan.fld"
        'ListaFluidiLocalDT.Rows(19).Item("NameFluidoFile") = "ibutene.fld"
        'ListaFluidiLocalDT.Rows(20).Item("NameFluidoFile") = "ihexane.fld"
        'ListaFluidiLocalDT.Rows(21).Item("NameFluidoFile") = "ipentane.fld"
        'ListaFluidiLocalDT.Rows(22).Item("NameFluidoFile") = "methane.fld"
        'ListaFluidiLocalDT.Rows(23).Item("NameFluidoFile") = "methanol.fld"
        'ListaFluidiLocalDT.Rows(24).Item("NameFluidoFile") = "pentane.fld"
        'ListaFluidiLocalDT.Rows(25).Item("NameFluidoFile") = "propane.fld"
        'ListaFluidiLocalDT.Rows(26).Item("NameFluidoFile") = "propylen.fld"
        'ListaFluidiLocalDT.Rows(27).Item("NameFluidoFile") = "sf6.fld"
        'ListaFluidiLocalDT.Rows(28).Item("NameFluidoFile") = "t2butene.fld"
        'ListaFluidiLocalDT.Rows(29).Item("NameFluidoFile") = "cf3i.fld"

        ''Verify the Directory exinstance
        'If Not My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\fluids") Then
        '    MsgBox("Impossible to read the folder Fluids")
        '    Exit Sub
        'End If

        '' Do not modify cont here, else uncomment before the for : ' Cont = ListaFluidiLocalDT.Rows.Count
        'For Each file As System.IO.FileInfo In My.Computer.FileSystem.GetDirectoryInfo(My.Application.Info.DirectoryPath & "\fluids\").GetFiles
        '    fluid = file.Name
        '    ExtentionLength = file.Extension.Length
        '    snextfile = Strings.Left(fluid, fluid.Length - ExtentionLength)

        '    If (Strings.Left(snextfile, 1) = "r" Or Strings.Left(snextfile, 1) = "R") And file.Extension.ToUpper() = ".FLD" Then
        '        FileOpen(1, file.FullName, OpenMode.Input)
        '        fluid2string = LineInput(1)
        '        casstring = LineInput(1)
        '        fullnamestring = LineInput(1)
        '        FileClose(1)
        '        'to divide from the comment
        '        chrpos = Strings.InStr(3, fullnamestring, " ")
        '        fullname = Strings.Left(fullnamestring, chrpos - 1)
        '        name1 = snextfile & " (" & fullname & ")"
        '        name2 = Strings.Left(name1, 2)
        '        name3 = Strings.Mid(name1, 3)
        '        name3 = Strings.LCase(name3)
        '        name1 = name2 & name3
        '        ' Add the refrigerant to the DataTable
        '        RowDummy = ListaFluidiLocalDT.NewRow
        '        RowDummy("IdFluido") = Cont
        '        RowDummy("NameFluidoCode") = name1
        '        RowDummy("NameFluidoUser") = name1
        '        RowDummy("NameFluidoFile") = file.Name
        '        ListaFluidiLocalDT.Rows.Add(RowDummy)
        '        Cont = Cont + 1
        '    End If
        'Next

        'ListaFluidiDW = ListaFluidiLocalDT.DefaultView
        'ListaFluidiDW.Sort() = "NameFluidoUser"
        'Me.lstPure.DataSource = ListaFluidiDW
        'Me.lstPure.ValueMember = "IdFluido"
        'Me.lstPure.DisplayMember = "NameFluidoUser"
        'YYJ[2020.0504]ltgen2: Remove unused codes - e

        Me.ListaFluidiDT = ListaFluidiLocalDT.Copy
        Me.lstPure.SelectedValue = Me.SelectedFluidIndex
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click, lstPure.DoubleClick
        Dim FileName As String
        Dim RowToFind As DataRow
        RowToFind = ListaFluidiDT.Rows.Find(Me.lstPure.SelectedValue)
        FileName = RowToFind("NameFluidoFile").ToString
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\FLUIDS\" & FileName) Then
            Me.FluidFeature = FormPure.SetFluidFeature(FileName)
            Me.SelectedFluidIndex = CInt(RowToFind("IdFluido"))
            Me.SelectedFluidName(0) = CStr(RowToFind("NameFluidoCode"))
            Me.SelectedFluidName(1) = CStr(RowToFind("NameFluidoUser"))
            Me.SelectedFluidName(2) = CStr(RowToFind("NameFluidoFile"))
            PushOk = True
            Me.Close()
        Else
            MsgBox("Fluid file does not exist.  Please select another fluid or add this particular fluid to the fluids subdirectory.")
        End If
    End Sub
    Public Shared Function SetFluidFeature(ByVal FileName As String) As FluidFeatureSTR
        Dim FluidFeatureLocal As FluidFeatureSTR = Nothing
        Dim chrpos As Integer
        Dim Path As String
        Path = My.Application.Info.DirectoryPath & "\FLUIDS\" & FileName
        FileOpen(1, Path, OpenMode.Input)
        With FluidFeatureLocal
            .fluid = LineInput(1)
            .cas = LineInput(1)
            .fullname = LineInput(1)
            .chemname = LineInput(1)
            .FileName = FileName
            .junk = LineInput(1)
            .wmstring = LineInput(1)
            .junk = LineInput(1)
            .tnbptstring = LineInput(1)
            .tcstring = LineInput(1)
            .pcstring = LineInput(1)
            .dcstring = LineInput(1)
            .acfstring = LineInput(1)
            FileClose(1)

            chrpos = Strings.InStr(3, .fluid, "!")
            .fluid = Strings.Left(.fluid, chrpos - 1)
            .fluid = Strings.Trim(.fluid)
            chrpos = Strings.InStr(3, .cas, " ")
            .cas = Strings.Left(.cas, chrpos - 1)
            chrpos = Strings.InStr(3, .fullname, " ")
            .fullname = Strings.Left(.fullname, chrpos - 1)
            chrpos = Strings.InStr(3, .chemname, " ")
            .chemname = Strings.Left(.chemname, chrpos - 1)
            chrpos = Strings.InStr(3, .wmstring, " ")
            .wmstring = Strings.Left(.wmstring, chrpos - 1)
            .wm = Val(.wmstring)
            chrpos = Strings.InStr(3, .tnbptstring, " ")
            .tnbptstring = Strings.Left(.tnbptstring, chrpos - 1)
            .tnbpt = Val(.tnbptstring)
            chrpos = InStr(3, .tcstring, " ")
            .tcstring = Strings.Left(.tcstring, chrpos - 1)
            .tc = Val(.tcstring)
            chrpos = Strings.InStr(3, .pcstring, " ")
            .pcstring = Strings.Left(.pcstring, chrpos - 1)
            .pc = Val(.pcstring)
            chrpos = InStr(3, .dcstring, " ")
            .dcstring = Strings.Left(.dcstring, chrpos - 1)
            .dc = Val(.dcstring)
            chrpos = InStr(3, .acfstring, " ")
            .acfstring = Strings.Left(.acfstring, chrpos - 1)
            .acf = Val(.acfstring)
            'This array is used for calling Refrop
            .nc = 1
            ReDim .X(NMaxRefrigrants) : .X(0) = 1
            ReDim .comp(NMaxRefrigrants) : .comp(0) = FileName
            ReDim .WmElements(NMaxRefrigrants) : .WmElements(0) = 1
        End With
        Return FluidFeatureLocal
    End Function
    Friend Shared Function CrateTBPerSummaryinFormInput(ByVal FluidFeatureLocal As FluidFeatureSTR) As DataTable
        Dim SummaryTB As New DataTable
        Dim Row As DataRow
        SummaryTB.Columns.Add("Component", System.Type.GetType("System.String"))
        SummaryTB.Columns.Add("Composition", System.Type.GetType("System.Double"))
        Row = SummaryTB.NewRow
        Row("Component") = FluidFeatureLocal.fluid
        Row("Composition") = 1.0
        SummaryTB.Rows.Add(Row)
        Return SummaryTB
    End Function
   
End Class