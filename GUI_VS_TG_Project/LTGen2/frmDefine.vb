Public Class formDefine
    Friend fluid As String
    Private ListaFluidiDT As DataTable
    Private ListaFluidiForNewMixtureDT As DataTable
    Friend MixtureFeature As FluidFeatureSTR
    Friend MixtureComponents() As FluidFeatureSTR
    Friend PushOk As Boolean = False
    Friend SelectedFluiIndex As Integer
    Friend SelectedFluidName(2) As String   '0:NameMixture; 1:NameMixtureUser; 2:MixtureStored
    Private Sub frmDefine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ListaFluidiLocalDT As New DataTable
        Dim RowDummy As DataRow
        Dim Cont As Int32 = 0
        Dim snextfile As String
        Dim fluid2string, casstring, fullnamestring, fullname As String
        Dim name1, name2, name3 As String
        Dim chrpos, ExtentionLength As Integer

        'Create the DataTable
        ListaFluidiLocalDT.TableName = "TbPureFluid"
        ListaFluidiLocalDT.Columns.Add("IdFluido", System.Type.GetType("System.Int32"))
        ListaFluidiLocalDT.Columns.Add("NameFluidoCode", System.Type.GetType("System.String"))
        ListaFluidiLocalDT.Columns.Add("NameFluidoUser", System.Type.GetType("System.String"))
        ListaFluidiLocalDT.Columns.Add("NameFluidoFile", System.Type.GetType("System.String"))
        ListaFluidiLocalDT.PrimaryKey = New DataColumn() {ListaFluidiLocalDT.Columns("IdFluido")}
        ListaFluidiForNewMixtureDT = ListaFluidiLocalDT.Clone()
        For Cont = 0 To 29  '26
            RowDummy = ListaFluidiLocalDT.NewRow
            RowDummy("IdFluido") = Cont
            ListaFluidiLocalDT.Rows.Add(RowDummy)
        Next Cont
        ListaFluidiLocalDT.Rows(0).Item("NameFluidoCode") = "neopentane"
        ListaFluidiLocalDT.Rows(1).Item("NameFluidoCode") = "acetone"
        ListaFluidiLocalDT.Rows(2).Item("NameFluidoCode") = "ammonia"
        ListaFluidiLocalDT.Rows(3).Item("NameFluidoCode") = "benzene"
        ListaFluidiLocalDT.Rows(4).Item("NameFluidoCode") = "butane"
        ListaFluidiLocalDT.Rows(5).Item("NameFluidoCode") = "butene"
        ListaFluidiLocalDT.Rows(6).Item("NameFluidoCode") = "carbon dioxide"
        ListaFluidiLocalDT.Rows(7).Item("NameFluidoCode") = "cis-butene"
        ListaFluidiLocalDT.Rows(8).Item("NameFluidoCode") = "cyclohexane"
        ListaFluidiLocalDT.Rows(9).Item("NameFluidoCode") = "cyclopropane"
        ListaFluidiLocalDT.Rows(10).Item("NameFluidoCode") = "dimethylether"
        ListaFluidiLocalDT.Rows(11).Item("NameFluidoCode") = "perfluoropentane"
        ListaFluidiLocalDT.Rows(12).Item("NameFluidoCode") = "dodecane"
        ListaFluidiLocalDT.Rows(13).Item("NameFluidoCode") = "ethane"
        ListaFluidiLocalDT.Rows(14).Item("NameFluidoCode") = "ethanol"
        ListaFluidiLocalDT.Rows(15).Item("NameFluidoCode") = "ethylene"
        ListaFluidiLocalDT.Rows(16).Item("NameFluidoCode") = "heptane"
        ListaFluidiLocalDT.Rows(17).Item("NameFluidoCode") = "hexane"
        ListaFluidiLocalDT.Rows(18).Item("NameFluidoCode") = "isobutane"
        ListaFluidiLocalDT.Rows(19).Item("NameFluidoCode") = "isobutene"
        ListaFluidiLocalDT.Rows(20).Item("NameFluidoCode") = "isohexane"
        ListaFluidiLocalDT.Rows(21).Item("NameFluidoCode") = "isopentane"
        ListaFluidiLocalDT.Rows(22).Item("NameFluidoCode") = "methane"
        ListaFluidiLocalDT.Rows(23).Item("NameFluidoCode") = "methanol"
        ListaFluidiLocalDT.Rows(24).Item("NameFluidoCode") = "pentane"
        ListaFluidiLocalDT.Rows(25).Item("NameFluidoCode") = "propane"
        ListaFluidiLocalDT.Rows(26).Item("NameFluidoCode") = "propylene"
        ListaFluidiLocalDT.Rows(27).Item("NameFluidoCode") = "sulfur hexafluoride"
        ListaFluidiLocalDT.Rows(28).Item("NameFluidoCode") = "trans-butene"
        ListaFluidiLocalDT.Rows(29).Item("NameFluidoCode") = "trifluoroiodomethane"

        ListaFluidiLocalDT.Rows(0).Item("NameFluidoUser") = "2,2-dimethylpropane"
        ListaFluidiLocalDT.Rows(1).Item("NameFluidoUser") = "acetone"
        ListaFluidiLocalDT.Rows(2).Item("NameFluidoUser") = "ammonia"
        ListaFluidiLocalDT.Rows(3).Item("NameFluidoUser") = "benzene"
        ListaFluidiLocalDT.Rows(4).Item("NameFluidoUser") = "butane"
        ListaFluidiLocalDT.Rows(5).Item("NameFluidoUser") = "butene (1-butene)"
        ListaFluidiLocalDT.Rows(6).Item("NameFluidoUser") = "carbon dioxide"
        ListaFluidiLocalDT.Rows(7).Item("NameFluidoUser") = "cis-2-butene"
        ListaFluidiLocalDT.Rows(8).Item("NameFluidoUser") = "cyclohexane"
        ListaFluidiLocalDT.Rows(9).Item("NameFluidoUser") = "cyclopropane"
        ListaFluidiLocalDT.Rows(10).Item("NameFluidoUser") = "dimethylether(methoxymethane)"
        ListaFluidiLocalDT.Rows(11).Item("NameFluidoUser") = "perfluoropentane"
        ListaFluidiLocalDT.Rows(12).Item("NameFluidoUser") = "dodecane"
        ListaFluidiLocalDT.Rows(13).Item("NameFluidoUser") = "ethane"
        ListaFluidiLocalDT.Rows(14).Item("NameFluidoUser") = "ethanol (ethyl alcohol)"
        ListaFluidiLocalDT.Rows(15).Item("NameFluidoUser") = "ethylene(ethene)"
        ListaFluidiLocalDT.Rows(16).Item("NameFluidoUser") = "heptane"
        ListaFluidiLocalDT.Rows(17).Item("NameFluidoUser") = "hexane"
        ListaFluidiLocalDT.Rows(18).Item("NameFluidoUser") = "isobutane(2 - methylpropane)"
        ListaFluidiLocalDT.Rows(19).Item("NameFluidoUser") = "isobutene (2-methyl-1-propene)"
        ListaFluidiLocalDT.Rows(20).Item("NameFluidoUser") = "isohexane(2 - methylpentane)"
        ListaFluidiLocalDT.Rows(21).Item("NameFluidoUser") = "isopentane(2 - methylbutane)"
        ListaFluidiLocalDT.Rows(22).Item("NameFluidoUser") = "methane"
        ListaFluidiLocalDT.Rows(23).Item("NameFluidoUser") = "methanol"
        ListaFluidiLocalDT.Rows(24).Item("NameFluidoUser") = "pentane"
        ListaFluidiLocalDT.Rows(25).Item("NameFluidoUser") = "propane"
        ListaFluidiLocalDT.Rows(26).Item("NameFluidoUser") = "propylene(propene)"
        ListaFluidiLocalDT.Rows(27).Item("NameFluidoUser") = "sulfur hexafluoride"
        ListaFluidiLocalDT.Rows(28).Item("NameFluidoUser") = "trans-butene"
        ListaFluidiLocalDT.Rows(29).Item("NameFluidoUser") = "trifluoroiodomethane"

        ListaFluidiLocalDT.Rows(0).Item("NameFluidoFile") = "neopentn.fld"
        ListaFluidiLocalDT.Rows(1).Item("NameFluidoFile") = "acetone.fld"
        ListaFluidiLocalDT.Rows(2).Item("NameFluidoFile") = "ammonia.fld"
        ListaFluidiLocalDT.Rows(3).Item("NameFluidoFile") = "benzene.fld"
        ListaFluidiLocalDT.Rows(4).Item("NameFluidoFile") = "butane.fld"
        ListaFluidiLocalDT.Rows(5).Item("NameFluidoFile") = "1butene.fld"
        ListaFluidiLocalDT.Rows(6).Item("NameFluidoFile") = "CO2.fld"
        ListaFluidiLocalDT.Rows(7).Item("NameFluidoFile") = "c2butene.fld"
        ListaFluidiLocalDT.Rows(8).Item("NameFluidoFile") = "cyclohex.fld"
        ListaFluidiLocalDT.Rows(9).Item("NameFluidoFile") = "cyclopro.fld"
        ListaFluidiLocalDT.Rows(10).Item("NameFluidoFile") = "dme.fld"
        ListaFluidiLocalDT.Rows(11).Item("NameFluidoFile") = "c5f12.fld"
        ListaFluidiLocalDT.Rows(12).Item("NameFluidoFile") = "c12.fld"
        ListaFluidiLocalDT.Rows(13).Item("NameFluidoFile") = "ethane.fld"
        ListaFluidiLocalDT.Rows(14).Item("NameFluidoFile") = "ethanol.fld"
        ListaFluidiLocalDT.Rows(15).Item("NameFluidoFile") = "ethylene.fld"
        ListaFluidiLocalDT.Rows(16).Item("NameFluidoFile") = "heptane.fld"
        ListaFluidiLocalDT.Rows(17).Item("NameFluidoFile") = "hexane.fld"
        ListaFluidiLocalDT.Rows(18).Item("NameFluidoFile") = "isobutan.fld"
        ListaFluidiLocalDT.Rows(19).Item("NameFluidoFile") = "ibutene.fld"
        ListaFluidiLocalDT.Rows(20).Item("NameFluidoFile") = "ihexane.fld"
        ListaFluidiLocalDT.Rows(21).Item("NameFluidoFile") = "ipentane.fld"
        ListaFluidiLocalDT.Rows(22).Item("NameFluidoFile") = "methane.fld"
        ListaFluidiLocalDT.Rows(23).Item("NameFluidoFile") = "methanol.fld"
        ListaFluidiLocalDT.Rows(24).Item("NameFluidoFile") = "pentane.fld"
        ListaFluidiLocalDT.Rows(25).Item("NameFluidoFile") = "propane.fld"
        ListaFluidiLocalDT.Rows(26).Item("NameFluidoFile") = "propylen.fld"
        ListaFluidiLocalDT.Rows(27).Item("NameFluidoFile") = "sf6.fld"
        ListaFluidiLocalDT.Rows(28).Item("NameFluidoFile") = "t2butene.fld"
        ListaFluidiLocalDT.Rows(29).Item("NameFluidoFile") = "cf3i.fld"

        'Verify the Directory existance
        If Not My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\fluids") Then
            MsgBox("Impossible to read the folder Fluids")
        End If

        ' Do not modify cont here, else uncomment before the for : ' Cont = ListaFluidiLocalDT.Rows.Count
        For Each file As System.IO.FileInfo In My.Computer.FileSystem.GetDirectoryInfo(My.Application.Info.DirectoryPath & "\fluids\").GetFiles
            fluid = file.Name
            ExtentionLength = file.Extension.Length
            snextfile = Strings.Left(fluid, fluid.Length - ExtentionLength)

            If (Strings.Left(snextfile, 1) = "r" Or Strings.Left(snextfile, 1) = "R") And file.Extension = ".FLD" Then
                FileOpen(1, file.FullName, OpenMode.Input)
                fluid2string = LineInput(1)
                casstring = LineInput(1)
                fullnamestring = LineInput(1)
                FileClose(1)
                'to divide from the comment
                chrpos = Strings.InStr(3, fullnamestring, " ")
                fullname = Strings.Left(fullnamestring, chrpos - 1)
                name1 = snextfile & " (" & fullname & ")"
                name2 = Strings.Left(name1, 2)
                name3 = Strings.Mid(name1, 3)
                name3 = Strings.LCase(name3)
                name1 = name2 & name3
                ' Add the refrigerant to the DataTable
                RowDummy = ListaFluidiLocalDT.NewRow
                RowDummy("IdFluido") = Cont
                RowDummy("NameFluidoCode") = name1
                RowDummy("NameFluidoUser") = name1
                RowDummy("NameFluidoFile") = file.Name
                ListaFluidiLocalDT.Rows.Add(RowDummy)
                Cont = Cont + 1
            End If
        Next

        Me.ListaFluidiDT = ListaFluidiLocalDT.Copy
        ' The DataSourceRefresh is made by the Class DataTable
        Me.RefreshAvailableList()

    End Sub
    Friend Function CrateTBPerSummary() As DataTable
        Dim SummaryTB As New DataTable
        Dim Row As DataRow
        SummaryTB.Columns.Add("Component", System.Type.GetType("System.String"))
        SummaryTB.Columns.Add("MoleFraction", System.Type.GetType("System.Double"))
        SummaryTB.Columns.Add("MassFraction", System.Type.GetType("System.Double"))
        For i As Integer = 0 To Me.MixtureFeature.nc - 1
            Row = SummaryTB.NewRow
            Row("Component") = Me.MixtureComponents(i).fluid
            Row("MoleFraction") = Me.MixtureFeature.X(i)
            Row("MassFraction") = Me.MixtureFeature.WmElements(i)
            SummaryTB.Rows.Add(Row)
        Next i
        Return SummaryTB
    End Function
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        'Creare l'elenco dei componenti con le varie carateristiche
        Dim NewMixtureComponentsNumber As Integer
        Me.PushOk = True
        NewMixtureComponentsNumber = Me.ListaFluidiForNewMixtureDT.Rows.Count
        If NewMixtureComponentsNumber >= 2 Then
            ReDim MixtureComponents(NewMixtureComponentsNumber - 1)
            ReDim MixtureFeature.X(NMaxRefrigrants - 1) : MixtureFeature.X.Initialize()
            ReDim MixtureFeature.comp(NMaxRefrigrants - 1) : MixtureFeature.comp.Initialize()
            ReDim MixtureFeature.WmElements(NMaxRefrigrants - 1) : MixtureFeature.WmElements.Initialize()
            Me.MixtureFeature.nc = NewMixtureComponentsNumber
            Me.MixtureFeature.wm = 0
            For i As Integer = 0 To NewMixtureComponentsNumber - 1
                Me.MixtureFeature.X(i) = 1 / NewMixtureComponentsNumber
                Me.MixtureFeature.comp(i) = Me.ListaFluidiForNewMixtureDT.Rows(i).Item("NameFluidoFile").ToString
                Me.MixtureComponents(i) = FormPure.SetFluidFeature(Me.MixtureFeature.comp(i))
                Me.MixtureFeature.wm += Me.MixtureFeature.X(i) * Me.MixtureComponents(i).wm
            Next i
            For i As Integer = 0 To NewMixtureComponentsNumber - 1
                Me.MixtureFeature.WmElements(i) = Me.MixtureFeature.X(i) * Me.MixtureComponents(i).wm / Me.MixtureFeature.wm
            Next i
            Dim FormMixCompIstance As New FormMixComp
            FormMixCompIstance.MixtureFeature = Me.MixtureFeature
            FormMixCompIstance.MixtureComponents = Me.MixtureComponents
            FormMixCompIstance.TBPerSummary = CrateTBPerSummary.Copy
            FormMixCompIstance.ShowDialog()
            Me.Enabled = False
            If FormMixCompIstance.PushOk Then
                Me.MixtureFeature = FormMixCompIstance.MixtureFeature
                Me.MixtureComponents = FormMixCompIstance.MixtureComponents
                If FormMixCompIstance.FlagStored Then
                    Me.SelectedFluiIndex = My.Computer.FileSystem.GetDirectoryInfo(My.Application.Info.DirectoryPath & "\mixtures\").GetFiles.Count _
                                         + My.Computer.FileSystem.GetDirectoryInfo(UserApplicationFolder & "\UserDefinedMixture").GetFiles.Count - 1
                    Me.SelectedFluidName(0) = Me.MixtureFeature.fluid
                    Me.SelectedFluidName(1) = Me.MixtureFeature.fluid
                    Me.SelectedFluidName(2) = "True"
                Else
                    Me.SelectedFluiIndex =0
                    Me.SelectedFluidName(0) = Me.MixtureFeature.fluid
                    Me.SelectedFluidName(1) = Me.MixtureFeature.fluid
                    Me.SelectedFluidName(2) = "False"
                End If
            End If
            Me.MixtureFeature.fullname = String.Empty
            Me.MixtureFeature.chemname = String.Empty
            Me.MixtureFeature.junk = String.Empty
            Me.MixtureFeature.tnbptstring = String.Empty
            Me.MixtureFeature.wmstring = Me.MixtureFeature.wm.ToString
            Me.MixtureFeature.tcstring = Me.MixtureFeature.tc.ToString
            Me.MixtureFeature.pcstring = Me.MixtureFeature.pc.ToString
            Me.MixtureFeature.dcstring = Me.MixtureFeature.dc.ToString
            Me.MixtureFeature.acfstring = String.Empty
            Me.Enabled = True
        Else
            MsgBox("Mixtures must have at least two components")
        End If
        Me.Close()
    End Sub
    Private Sub RefreshAvailableList()
        Dim ListaFluidiDW As New DataView
        'Refresh the Selected list
        ListaFluidiDW = ListaFluidiDT.DefaultView
        ListaFluidiDW.Sort() = "NameFluidoUser"
        Me.lstAvailable.DataSource = ListaFluidiDW
        Me.lstAvailable.ValueMember = "IdFluido"
        Me.lstAvailable.DisplayMember = "NameFluidoUser"
    End Sub
    Private Sub RefreshSelectedList()
        'Refresh the Selected list
        Me.lstSelected.DataSource = ListaFluidiForNewMixtureDT
        Me.lstSelected.ValueMember = "IdFluido"
        Me.lstSelected.DisplayMember = "NameFluidoUser"
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click, lstAvailable.MouseDoubleClick
        Dim RowToImportRemove As DataRow
        ' Warning the refrigerants number is geater than the set max
        If ListaFluidiForNewMixtureDT.Rows.Count >= NMaxRefrigrants Then
            MsgBox("Maximum number of fluids exceeded")
        Else
            'ListaFluidiDT.WriteXml(My.Computer.FileSystem.SpecialDirectories.Desktop & "\PureFluid.xml", XmlWriteMode.WriteSchema)
            'Import the row corresponding to the selected refrigerant
            RowToImportRemove = ListaFluidiDT.Rows.Find(Me.lstAvailable.SelectedValue)
            ListaFluidiForNewMixtureDT.ImportRow(RowToImportRemove)
            Me.RefreshSelectedList()
            ListaFluidiDT.Rows.Remove(RowToImportRemove)
            Me.RefreshAvailableList()
            Me.lstSelected.SelectedItem = Me.lstSelected.Items(Me.lstSelected.Items.Count - 1)
        End If
    End Sub
    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click, lstSelected.MouseDoubleClick
        Dim RowToImportRemove As DataRow
        If ListaFluidiForNewMixtureDT.Rows.Count > 0 Then
            RowToImportRemove = ListaFluidiForNewMixtureDT.Rows.Find(Me.lstSelected.SelectedValue)
            ListaFluidiDT.ImportRow(RowToImportRemove)
            Me.RefreshAvailableList()
            ListaFluidiForNewMixtureDT.Rows.Remove(RowToImportRemove)
            Me.RefreshSelectedList()
        End If
    End Sub
   
End Class