Public Class frmInput
 
    Private FlagRadingASavedFile As Boolean = False
    Private TypeRefrigerant As Integer      '0: Pure; 1: Predefined; 2: UserDefinedMixture
    Private SelectedFluidIndex As Integer
    'PURE FLUID 0:NameFluidoCode; 1:NameFluidoUser; 2:NameFluidoFile 
    'MIX. '0:NameMixture; 1:NameMixtureUser; 2:MixtureStored
    Private SelectedFluidName(2) As String
    Private FlagLetTabPageChange As Boolean = True
    Friend FlagControlFluidOk As Boolean
    Public FlagControlFluidOk2 As Integer
    Friend FlagcontrolsOk, FlagControlPostDataOk, blnError, FlagMustControlPostDataFalse As Boolean

    Public PureFld_Mix_FeatureLocalInst As New MixtureFeatureClass
    Public PureFld_FeatureLocalInst As New PureFluidFeatureClass
    Public Mixture_FeatureLocalInst As New MixtureFeatureClass

    Public BordConditionsLocalInstance As New BordConditionFormInputClass
    'Variables to set the value changing the units
    Private DataSetUnit As New DataSet
    Private FormatLength, FormatArea, FormatT, FormatP, FormatUA, FormatLMTD, FormatMassFlux, FormatPower As String
    Private FormatLengthDisp, FormatAreaDisp, FormatTDisp, FormatPDisp, FormatUADisp, FormatLMTDDisp, FormatMassFluxDisp, FormatPowerDisp As String
    Private FormatEfficiencyStrings As String = "{0:N2}"
    'Output: two DS within the cycle points and original dll output respectively 
    Friend CyclePointOutputDS As DataSet
    Friend CyclePointFromDllDS As DataSet
    'This path is the path from where the file has been opened or where it has been saved
    Friend FilePathComplete As String
    Friend FileName As String
    Friend InputChart As InputChartSTR
    Friend InitialTempK, InitialTempC, InitialTempF As Double
    Friend FillTempK, FillTempC, FillTempF As Double
    Friend NumberOfRecharges As Integer
    Friend PercentOfRecharge As Double
    Private FormMainCallling As FormMain
    Private Sub frmInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SetUnitLabels()
        Me.SetEnabledControls()

        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
        'If (txtFracFill.Text = "" Or txtFillTemp.Text = "") Then
        '    btnCalculate.Enabled = False
        'Else
        '    btnCalculate.Enabled = True
        'End If
        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e

        Me.FlagControlFluidOk2 = 1

        Me.btnDisplay.Enabled = False
        If TypeOf Me.MdiParent Is FormMain Then
            FormMainCallling = CType(Me.MdiParent, FormMain)
        End If

        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
        ''YYJ[2020.0319] rbLeakOnly is TRUE while Form_Load event, inactive 'Recharge Process'
        'If Me.rbLeakOnly.Checked = True Then
        '    Me.frmRechargeProcess.Enabled = False
        'End If
        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e


    End Sub
    Friend Sub SetEnabledControls()
        'If Me.PureFld_Mix_FeatureLocalInst.MixtureFeature.fluid = Nothing Then
        '    btnViewMixing.Enabled = False
        '    btnAnalyze.Enabled = False
        '    ' btnDisplay.Enabled = False
        '    chkLiquid.Enabled = False
        '    chkVapor.Enabled = False
        'Else
        '    btnViewMixing.Enabled = True
        '    btnAnalyze.Enabled = True
        '    chkLiquid.Enabled = True
        '    chkVapor.Enabled = True

        '    'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e
        '    'If (txtInitialTemp.Text <> "" And txtInitialVolQual.Text <> "") Then
        '    '    If (rbLeakOnly.Checked = True) Then
        '    '        Me.FormMainCallling.Run_But.Enabled = True : Me.FormMainCallling.AnalyzeToolStripMenuItem.Enabled = True
        '    '        Me.FormMainCallling.Run_But.Visible = True : Me.btnAnalyze.Enabled = True
        '    '    Else
        '    '        If (txtNumRecharges.Text <> Nothing And txtMassLoss.Text <> Nothing) Then
        '    '            '''''If (((txtNumRecharges.Text <> "" And txtMassLoss.Text <> "") Or (txtNumRecharges.Text <> " " And txtMassLoss.Text <> "") Or (txtNumRecharges.Text <> "  " And txtMassLoss.Text <> "  ")) And (txtNumRecharges.Text <> "0" Or txtNumRecharges.Text <> "0")) Then
        '    '            Me.FormMainCallling.Run_But.Enabled = True : Me.FormMainCallling.AnalyzeToolStripMenuItem.Enabled = True
        '    '            Me.FormMainCallling.Run_But.Visible = True : Me.btnAnalyze.Enabled = True
        '    '            If txtNumRecharges.Text = Nothing Or txtMassLoss.Text = Nothing Then
        '    '                Me.FormMainCallling.Run_But.Enabled = False : Me.FormMainCallling.AnalyzeToolStripMenuItem.Enabled = False
        '    '                Me.FormMainCallling.Run_But.Visible = False : Me.btnAnalyze.Enabled = False
        '    '            Else
        '    '                Me.FormMainCallling.Run_But.Enabled = True : Me.FormMainCallling.AnalyzeToolStripMenuItem.Enabled = True
        '    '                Me.FormMainCallling.Run_But.Visible = True : Me.btnAnalyze.Enabled = True
        '    '            End If
        '    '        Else
        '    '            Me.FormMainCallling.Run_But.Enabled = False : Me.FormMainCallling.AnalyzeToolStripMenuItem.Enabled = False
        '    '            Me.FormMainCallling.Run_But.Visible = False : Me.btnAnalyze.Enabled = False
        '    '        End If
        '    '    End If
        '    'Else
        '    '    Me.FormMainCallling.Run_But.Enabled = True : Me.FormMainCallling.AnalyzeToolStripMenuItem.Enabled = True
        '    '    Me.FormMainCallling.Run_But.Visible = True : Me.btnAnalyze.Enabled = True
        '    'End If
        '    'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e
        'End If
    End Sub

    'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
    'Private Sub check()
    '    If rbLeakandRecharge.Checked = True Then
    '        FormMain.Run_But.Enabled = False
    '        btnAnalyze.Enabled = False
    '        FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '        Me.FlagcontrolsOk = False
    '    Else
    '        FormMain.Run_But.Enabled = False
    '        btnAnalyze.Enabled = False
    '        FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '        Me.FlagcontrolsOk = False
    '    End If 
    'End Sub
    'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e

    Private Sub cmdPredefinedMixture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPredefinedMixture.Click

        Dim FormPredefinedInstance As New FormPredefined
        If Me.TypeRefrigerant = 1 Or Me.TypeRefrigerant = 2 Then
            FormPredefinedInstance.SelectedFluidIndex = Me.SelectedFluidIndex
        Else
            FormPredefinedInstance.SelectedFluidIndex = 0
        End If
        FormPredefinedInstance.ShowDialog()

        If FormPredefinedInstance.PushOk Then
            Me.frmComponents.Visible = True
            'Set the right system unit in ArrayTP
            Me.TypeRefrigerant = 1
            TypeRefrigerant2 = 1
            Me.Mixture_FeatureLocalInst.SetProperties(Me.TypeRefrigerant, FormPredefinedInstance.MixtureComponents, FormPredefinedInstance.MixtureFeature)
            Me.REfNameLBL.Text = FormPredefinedInstance.MixtureFeature.fluid

            Me.lblRefNameOutTab.Text = FormPredefinedInstance.MixtureFeature.fluid
            Me.SelectedFluidIndex = FormPredefinedInstance.SelectedFluidIndex
            Me.SelectedFluidName = FormPredefinedInstance.SelectedFluidName

            Me.SetCritT_PUnit()

            Me.GridComposition.DataSource = FormPredefined.CreateTBPerSummaryinFormInput(FormPredefinedInstance.MixtureFeature, FormPredefinedInstance.MixtureComponents).Copy

            'YYJ[2020.0727]ltgen2: Saving *.FLD filename to TableInfo.txt (hide FLD column)
            Me.GridComposition.Columns(3).Visible = False

            Me.SetGridCompositionHeight()

            Me.SetEnabledControls()
            Me.ControlAndSetUpFluid()
            FormMixingParameters.MixtureFeature.SetProperties(Me.TypeRefrigerant, FormPredefinedInstance.MixtureComponents, FormPredefinedInstance.MixtureFeature)
            FormMixingParameters.FormMixingParameters_Load(Nothing, Nothing)
            FormMixingParameters.btnReset_Click(Nothing, Nothing)
        End If
        Me.Enabled = True
        If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
            btnDisplay.Enabled = False
            FormMain.DisplayResultsToolStripMenuItem.Enabled = False
        End If

    End Sub
    Private Sub cmdDefineNewMixture_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Me.Enabled = False
        'Dim FormDefineInstance As New formDefine
        'FormDefineInstance.ShowDialog()
        'If FormDefineInstance.PushOk Then
        '    Me.TypeRefrigerant = 2
        '    TypeRefrigerant2 = 2
        '    Me.PureFld_Mix_FeatureLocalInst.SetProperties(Me.TypeRefrigerant, FormDefineInstance.MixtureComponents, FormDefineInstance.MixtureFeature)
        '    Me.REfNameLBL.Text = FormDefineInstance.MixtureFeature.fluid
        '    Me.lblRefNameOutTab.Text = FormDefineInstance.MixtureFeature.fluid
        '    Me.lblRefNameOutTab.Text = FormDefineInstance.MixtureFeature.fluid
        '    Me.SelectedFluidIndex = FormDefineInstance.SelectedFluidIndex
        '    Me.SelectedFluidName = FormDefineInstance.SelectedFluidName
        '    Me.SetCritT_PUnit()
        '    Me.GridComposition.DataSource = FormDefineInstance.CrateTBPerSummary.Copy
        '    Me.SetGridCompositionHeight()
        '    Me.SetEnabledControls()
        '    Me.ControlAndSetUpFluid()
        '    FormMixingParameters.MixtureFeature.SetProperties(Me.TypeRefrigerant, FormDefineInstance.MixtureComponents, FormDefineInstance.MixtureFeature)
        '    FormMixingParameters.FormMixingParameters_Load(Nothing, Nothing)
        '    FormMixingParameters.btnReset_Click(Nothing, Nothing)
        'End If
        'Me.Enabled = True
        'If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
        '    btnDisplay.Enabled = False
        '    FormMain.DisplayResultsToolStripMenuItem.Enabled = False
        'End If
    End Sub
    Private Sub SetGridCompositionHeight()
        For i As Integer = 0 To Me.GridComposition.Columns.Count - 1
            Me.GridComposition.Columns(i).SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Next i
        Me.GridComposition.Height = Me.GridComposition.RowTemplate.Height * (Me.GridComposition.Rows.Count + 1)

        'YYJ[2020.0326] Adjust Cell Width  (due to font change): 262 --> 300  '.Size(262,  ((       
        '               Adjust Cell Height (due to font change): 22 --> 23  '* 22))      
        Me.GridComposition.Size = New System.Drawing.Size(300, ((Mixture_FeatureLocalInst.MixtureFeature.nc + 1) * 23))

        Me.frmComponents.Height = (Mixture_FeatureLocalInst.MixtureFeature.nc * 25 + 70)

    End Sub
    Friend Sub SetUnitLabels()
        'YYJ[2020.0727]ltgen2: skip this routine(only use degC and kPa) - s
        'Select Case BordConditions.Unit
        '    Case "SI with K"
        '        'First TabControl Page
        '        Me.lblUnitTemp.Text = DataTableUnits.Rows(0).Item("Temperature").ToString
        '        Me.lblUnitPressure.Text = DataTableUnits.Rows(0).Item("Pressure").ToString

        '        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
        '        'Me.lblUnitInitialTemp.Text = DataTableUnits.Rows(0).Item("Temperature").ToString
        '        'Me.lblUnitFillTemp.Text = DataTableUnits.Rows(0).Item("Temperature").ToString

        '        ''YYJ[2020.0312] Delete redundant expression  '"Optional Calculation of Initial Volumetric Quality at 298.15 K"
        '        'Me.frmOptCalc.Text = "Optional Calculation of Initial Volumetric Quality"

        '        'Me.txtInitialTemp.Text = Format(InitialTempK, "#0.00")
        '        'If Me.txtFillTemp.Text = "" Then
        '        'Else
        '        '    Me.txtFillTemp.Text = Format(FillTempK, "#0.00")
        '        'End If
        '        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e

        '    Case "SI with °C"
        '        'First TabControl Page
        '        Me.lblUnitTemp.Text = DataTableUnits.Rows(1).Item("Temperature").ToString
        '        Me.lblUnitPressure.Text = DataTableUnits.Rows(1).Item("Pressure").ToString

        '        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
        '        'Me.lblUnitInitialTemp.Text = DataTableUnits.Rows(1).Item("Temperature").ToString
        '        'Me.lblUnitFillTemp.Text = DataTableUnits.Rows(1).Item("Temperature").ToString

        '        ''YYJ[2020.0312] Delete redundant expression  '"Optional Calculation of Initial Volumetric Quality at 25 °C"
        '        'Me.frmOptCalc.Text = "Optional Calculation of Initial Volumetric Quality"

        '        'Me.txtInitialTemp.Text = Format(InitialTempC, "#0.00")
        '        'If Me.txtFillTemp.Text = "" Then
        '        'Else
        '        '    Me.txtFillTemp.Text = Format(FillTempC, "#0.00")
        '        'End If
        '        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e

        '    Case "I-P Inch-Pound"
        '        'First TabControl Page
        '        Me.lblUnitTemp.Text = DataTableUnits.Rows(2).Item("Temperature").ToString
        '        Me.lblUnitPressure.Text = DataTableUnits.Rows(2).Item("Pressure").ToString

        '        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
        '        'Me.lblUnitInitialTemp.Text = DataTableUnits.Rows(2).Item("Temperature").ToString
        '        'Me.lblUnitFillTemp.Text = DataTableUnits.Rows(2).Item("Temperature").ToString

        '        ''YYJ[2020.0312] Delete redundant expression  '"Optional Calculation of Initial Volumetric Quality at 77 °F"
        '        'Me.frmOptCalc.Text = "Optional Calculation of Initial Volumetric Quality"

        '        'Me.txtInitialTemp.Text = Format(InitialTempF, "#0.00")
        '        'If Me.txtFillTemp.Text = "" Then
        '        'Else
        '        '    Me.txtFillTemp.Text = Format(FillTempF, "#0.00")
        '        'End If
        '        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e

        '    Case Else
        '        Me.lblUnitTemp.Text = DataTableUnits.Rows(0).Item("Temperature").ToString
        '        Me.lblUnitPressure.Text = DataTableUnits.Rows(0).Item("Pressure").ToString

        '        'YYJ[2020.0425]ltgen2: remove 'Leak/Recharge' logics - s
        '        'Me.lblUnitInitialTemp.Text = DataTableUnits.Rows(0).Item("Temperature").ToString
        '        'Me.lblUnitFillTemp.Text = DataTableUnits.Rows(0).Item("Temperature").ToString

        '        ''YYJ[2020.0312] Delete redundant expression  '"Optional Calculation of Initial Volumetric Quality at 298.15 K"
        '        'Me.frmOptCalc.Text = "Optional Calculation of Initial Volumetric Quality"

        '        'Me.txtInitialTemp.Text = Format(InitialTempK, "#0.00")
        '        'If Me.txtFillTemp.Text = "" Then
        '        'Else
        '        '    Me.txtFillTemp.Text = Format(FillTempK, "#0.00")
        '        'End If
        '        'YYJ[2020.0425]ltgen2: remove 'Leak/Recharge' logics - e

        'End Select
        'YYJ[2020.0727]ltgen2: skip this routine(only use degC and kPa) - e
    End Sub
    Friend Sub SetCritT_PUnit()
        'Dim ArrayTP(1) As Double
        ''This Sub convert the critical pressure/temperature when changing the system unit
        'If Me.TypeRefrigerant = 0 Then
        '    'ArrayTP(0) = Me.PureFluidFeatureLocalInstance.FluidFeature.tc
        '    'ArrayTP(1) = Me.PureFluidFeatureLocalInstance.FluidFeature.pc
        'ElseIf Me.TypeRefrigerant = 1 Or Me.TypeRefrigerant = 2 Then
        '    ArrayTP(0) = Me.PureFld_Mix_FeatureLocalInst.MixtureFeature.tc
        '    ArrayTP(1) = Me.PureFld_Mix_FeatureLocalInst.MixtureFeature.pc
        '    Me.CritTLBL.Text = Math.Round(ArrayTP(0), 3).ToString
        '    Me.CritPLBL.Text = Math.Round(ArrayTP(1), 3).ToString

        '    'YYJ[2020.0329] Remove lower limit on T or P - s
        '    'If ArrayTP(0) < 0.00000001 Or ArrayTP(1) < 0.0000001 Then
        '    '    Me.CritTLBL.Text = ""
        '    '    Me.CritPLBL.Text = ""
        '    'End If
        '    'YYJ[2020.0329] Remove lower limit on T or P - e

        'End If
        'Select Case BordConditions.Unit 'All ok
        '    Case "SI with K"
        '    Case "SI with °C"
        '        If CritTLBL.Text <> "" And CritPLBL.Text <> "" Then
        '            ArrayTP(0) = TKtoTC(ArrayTP(0))
        '        End If
        '    Case "I-P Inch-Pound"
        '        If CritTLBL.Text <> "" Or CritPLBL.Text <> "" Then
        '            ArrayTP(0) = TKtoTE(ArrayTP(0)) : ArrayTP(1) = KPAtoPSI(ArrayTP(1))
        '        End If
        '    Case Else '= SI with K
        'End Select
        'Me.CritTLBL.Text = Math.Round(ArrayTP(0), 2).ToString
        'Me.CritPLBL.Text = Math.Round(ArrayTP(1), 2).ToString

        ''YYJ[2020.0329] Remove lower limit on T or P - s
        ''If ArrayTP(0) < 0.00000001 Or ArrayTP(1) < 0.0000001 Then
        ''    Me.CritTLBL.Text = ""
        ''    Me.CritPLBL.Text = ""
        ''End If
        ''YYJ[2020.0329] Remove lower limit on T or P - s

    End Sub
    Private Sub SetFluidProperties(ByVal IndexFluid As Integer)
        'Dim NameFilePathComplete, NameFile As String
        'Dim RowToFind As DataRow
        'Dim MixtureComponentsFeature() As FluidFeatureSTR = Nothing
        'Dim MixtureFeature As FluidFeatureSTR
        'Dim TableFluids As DataTable = Nothing
        ''Save File index and the fluid index
        'RowToFind = TableFluids.Rows.Find(IndexFluid)
        ''IndexFluidType is the index counted from 0 for each type of fluid
        'Me.SelectedFluidIndex = CInt(RowToFind("IndexFluidType"))
        'Me.TypeRefrigerant = CInt(RowToFind("FluidType"))
        'NameFile = RowToFind("NameFluidoFile").ToString
        'If CInt(RowToFind("FluidType")) = 1 Then
        '    NameFilePathComplete = ApplicationFolder & "\mixtures\" & NameFile
        '    MixtureFeature = FormPredefined.SetMixtureFeature(NameFilePathComplete, NameFile, MixtureComponentsFeature)
        '    Me.PureFld_Mix_FeatureLocalInst.SetProperties(CInt(RowToFind("FluidType")), MixtureComponentsFeature, MixtureFeature)
        '    Me.SelectedFluidName(0) = CStr(RowToFind("NameFluidoCode"))
        '    Me.SelectedFluidName(1) = CStr(RowToFind("NameFluidoUser"))
        '    Me.SelectedFluidName(2) = "True"
        '    Me.TypeRefrigerant = 1
        '    TypeRefrigerant2 = 1
        '    Me.REfNameLBL.Text = MixtureFeature.fluid
        '    Me.lblRefNameOutTab.Text = MixtureFeature.fluid
        '    Me.SelectedFluidIndex = SelectedFluidIndex
        '    Me.SelectedFluidName = SelectedFluidName
        '    Me.GridComposition.DataSource = FormPredefined.CreateTBPerSummaryinFormInput(MixtureFeature, MixtureComponentsFeature).Copy
        'ElseIf CInt(RowToFind("FluidType")) = 2 Then
        '    NameFilePathComplete = UserApplicationFolder & "\UserDefinedMixture\" & NameFile
        '    MixtureFeature = FormPredefined.SetMixtureFeature(NameFilePathComplete, NameFile, MixtureComponentsFeature)
        '    Me.PureFld_Mix_FeatureLocalInst.SetProperties(CInt(RowToFind("FluidType")), MixtureComponentsFeature, MixtureFeature)
        '    Me.SelectedFluidName(0) = CStr(RowToFind("NameFluidoCode"))
        '    Me.SelectedFluidName(1) = CStr(RowToFind("NameFluidoUser"))
        '    Me.SelectedFluidName(2) = "False"
        '    Me.TypeRefrigerant = 1
        '    TypeRefrigerant2 = 1
        '    Me.REfNameLBL.Text = MixtureFeature.fluid
        '    Me.lblRefNameOutTab.Text = MixtureFeature.fluid
        '    Me.SelectedFluidIndex = SelectedFluidIndex
        '    Me.SelectedFluidName = SelectedFluidName
        '    Me.GridComposition.DataSource = FormPredefined.CreateTBPerSummaryinFormInput(MixtureFeature, MixtureComponentsFeature).Copy
        'End If
        'Me.SetCritT_PUnit()
        'Me.SetGridCompositionHeight()
    End Sub

    Private Sub cmdPreDefPureFld_Click(sender As Object, e As EventArgs) Handles cmdPreDefPureFld.Click
        Me.Enabled = False

        Dim FrmPreDefPureLfdInst As New frmPreDefPureFld 'Dim FormPredefinedInstance As New FormPredefined
        If Me.TypeRefrigerant = 1 Or Me.TypeRefrigerant = 2 Then
            FrmPreDefPureLfdInst.SelectedFluidIndex = Me.SelectedFluidIndex 'FormPredefinedInstance.SelectedFluidIndex = Me.SelectedFluidIndex
        Else
            FrmPreDefPureLfdInst.SelectedFluidIndex = 0 'FormPredefinedInstance.SelectedFluidIndex = 0
        End If
        FrmPreDefPureLfdInst.ShowDialog() 'FormPredefinedInstance.ShowDialog()

        If FrmPreDefPureLfdInst.PushOk = True Then
            Me.frmComponents.Visible = False
            Me.TypeRefrigerant = 0 'Me.TypeRefrigerant = 1  '<--0: Pure; 1: Predefined; 2: UserDefinedMixture
            TypeRefrigerant2 = 0 'TypeRefrigerant2 = 1  '<--0: Pure; 1: Predefined; 2: UserDefinedMixture

            Me.PureFld_FeatureLocalInst.SetProperties(Me.TypeRefrigerant,
                                                      FrmPreDefPureLfdInst.PureFldFeature)

            Me.REfNameLBL.Text = FrmPreDefPureLfdInst.PureFldFeature.ShortName 'Me.REfNameLBL.Text = FormPredefinedInstance.MixtureFeature.fluid
            Me.lblRefNameOutTab.Text = FrmPreDefPureLfdInst.PureFldFeature.ShortName 'Me.lblRefNameOutTab.Text = FormPredefinedInstance.MixtureFeature.fluid
            'Me.REfNameLBL.Text = FrmPreDefPureLfdInst.PureFldFeature.fluid 'Me.REfNameLBL.Text = FormPredefinedInstance.MixtureFeature.fluid
            'Me.lblRefNameOutTab.Text = FrmPreDefPureLfdInst.PureFldFeature.fluid 'Me.lblRefNameOutTab.Text = FormPredefinedInstance.MixtureFeature.fluid


            Me.SelectedFluidIndex = FrmPreDefPureLfdInst.SelectedFluidIndex 'Me.SelectedFluidIndex = FormPredefinedInstance.SelectedFluidIndex
            Me.SelectedFluidName = FrmPreDefPureLfdInst.SelectedFluidName 'Me.SelectedFluidName = FormPredefinedInstance.SelectedFluidName

            'Me.SetCritT_PUnit()

            Me.GridComposition.DataSource = frmPreDefPureFld.CreateTBPerSummary_PureFld_frmInput(FrmPreDefPureLfdInst.PureFldFeature).Copy() 'Me.GridComposition.DataSource = FormPredefined.CreateTBPerSummaryinFormInput(FormPredefinedInstance.MixtureFeature, FormPredefinedInstance.MixtureComponents).Copy

            'YYJ[2020.0727]ltgen2: Saving *.FLD filename to TableInfo.txt (hide FLD column)
            Me.GridComposition.Columns(3).Visible = False

            Me.SetGridCompositionHeight()
            Me.SetEnabledControls()
            Me.ControlAndSetUpFluid()

            '포팅: 아래것들은 포팅 안해도 되지 않을런지...?
            'FormMixingParameters.MixtureFeature.SetProperties(Me.TypeRefrigerant, FormPredefinedInstance.MixtureComponents, FormPredefinedInstance.MixtureFeature)
            'FormMixingParameters.FormMixingParameters_Load(Nothing, Nothing)
            'FormMixingParameters.btnReset_Click(Nothing, Nothing)

        End If

        Me.Enabled = True
        'If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
        '    btnDisplay.Enabled = False
        '    FormMain.DisplayResultsToolStripMenuItem.Enabled = False
        'End If
    End Sub



    Private Sub Fill_Vars_RefInfoTable()
        Dim i As Integer

        With Me.GridComposition
            inumber = .Rows.Count() 'YYJ[2020.0425] total number of components

            For i = 0 To inumber - 1
                refname(i) = CType(.Rows(i).Cells("Component").Value, String)
                refcomp(i) = CType(.Rows(i).Cells("MassFraction").Value, Double)
                refcomp_STR(i) = Format(refcomp(i), "#0.000")

                'YYJ[2020.0727]ltgen2: Saving *.FLD filename to TableInfo.txt (write to TableInfo.txt)
                refFLDname(i) = CType(.Rows(i).Cells("FLD").Value, String)
            Next
        End With
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Try
            Call Fill_Vars_RefInfoTable() 'YYJ[2020.0425] Fill RefComp(*), RefName(*), and inumber using GridComposition table

            'YYJ[2020.1028] Alweays use Linear scale - s
            iscale = 1
            'If rbtScale1.Checked = True Then
            '    iscale = 1
            'Else
            '    iscale = 2
            'End If
            'YYJ[2020.1028] Alweays use Linear scale - e

            rname = Me.REfNameLBL.Text

            If refname(0) = "" Or refcomp(0) = 0.0 Or txtHP.Text = "" Or txtLP.Text = "" Or rname = "" Or txtHP.Text = "" Or txtLP.Text = "" Then
                MsgBox("Empty Input(s) Found. Please check your inputs!")
                'MsgBox("Please check your inputs!", vbCritical + vbOKOnly, "Lookup Table Generator")
                Exit Sub
            End If

            hp = CDbl(txtHP.Text)
            lp = CDbl(txtLP.Text)

            If hp <= lp Then
                MsgBox("Invalid Pressure Condition. Please check your inputs!")
                'MsgBox("Please check your inputs!", vbCritical + vbOKOnly, "Lookup Table Generator")
                Exit Sub
            End If

            np = CInt(nudP.Value)
            nh = CInt(nudH.Value)

            ' write the info to the tableinfo.txt file
            Dim outfile As IO.StreamWriter

            outfile = IO.File.CreateText("TableInfo.txt")

            outfile.WriteLine(rname)

            outfile.WriteLine(inumber)

            'YYJ[2020.0727]ltgen2: Saving *.FLD filename to TableInfo.txt - s
            For i As Integer = 0 To inumber - 2
                outfile.Write(refFLDname(i) & " ")
            Next
            outfile.WriteLine(refFLDname(inumber - 1))
            'For i As Integer = 0 To inumber - 2
            '    outfile.Write(refname(i) & " ")
            'Next
            'outfile.WriteLine(refname(inumber - 1))
            'YYJ[2020.0727]ltgen2: Saving *.FLD filename to TableInfo.txt - e

            For i As Integer = 0 To inumber - 2
                outfile.Write(refcomp_STR(i) & " ")
                'outfile.Write(refcomp(i) & " ")
            Next
            outfile.WriteLine(refcomp_STR(inumber - 1))
            'outfile.WriteLine(refcomp(inumber - 1))

            outfile.WriteLine(lp & " " & hp)
            outfile.WriteLine(np & " " & nh)

            outfile.WriteLine(iscale - 1) 'YYJ[2020.0703]ltgen2: 0 for lin-scale, 1 for log-scale

            outfile.Close()

            cmdGen.Enabled = True

            Me.WriteControlVariables()


            'YYJ[2020.0908]ltgen2: make a portable version - s
            Me.BordConditionsLocalInstance.SaveFile(ApplicationFolder & "\Last(LtG2).xml")
            'Me.BordConditionsLocalInstance.SaveFile(UserApplicationFolder & "\Last(LtG2).xml")
            'YYJ[2020.0908]ltgen2: make a portable version - e

        Catch ex As System.ComponentModel.Win32Exception
            Return
        End Try
    End Sub

    Private Sub cmdGen_Click(sender As Object, e As EventArgs) Handles cmdGen.Click

        Dim info As System.Diagnostics.ProcessStartInfo
        info = New System.Diagnostics.ProcessStartInfo()


        'YYJ[2020.0703]ltgen2: Calling Linear Table Generator - s
        info.FileName = "gen-table.exe"
        'If iscale = 1 Then
        '    info.FileName = "gen-table-lin.exe" '"user-gen-table.exe"
        'Else
        '    info.FileName = "gen-table-log.exe" '"user-gen-table-log.exe"
        'End If
        'YYJ[2020.0703]ltgen2: Calling Linear Table Generator - e

        info.WorkingDirectory = Application.StartupPath

        Dim Proc As System.Diagnostics.Process

        Try
            Proc = System.Diagnostics.Process.Start(info)
        Catch ex As System.ComponentModel.Win32Exception
            MsgBox("Error: External Program, <gen-table.exe>, is not found.")
            'If iscale = 1 Then
            '    MsgBox("Error: External Program for LINEAR scale, <gen-table-lin.exe>, is not found.")
            'Else
            '    MsgBox("Error: External Program for LOG scale, <gen-table-lin.exe>, is not found.")
            'End If

        End Try

        'MsgBox("The property lookup table of " & rname & " has been successfully generated", vbOKOnly + vbInformation, "Lookup table generator")


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub cmdDefineNewMixture_Click(sender As Object, e As EventArgs) Handles cmdDefineNewMixture.Click

        Me.Enabled = False
        Dim FormDefineInstance As New formDefine
        FormDefineInstance.ShowDialog()
        If FormDefineInstance.PushOk Then
            Me.frmComponents.Visible = True
            Me.TypeRefrigerant = 2
            TypeRefrigerant2 = 2
            Me.Mixture_FeatureLocalInst.SetProperties(Me.TypeRefrigerant, FormDefineInstance.MixtureComponents, FormDefineInstance.MixtureFeature)
            Me.REfNameLBL.Text = FormDefineInstance.MixtureFeature.fluid
            Me.lblRefNameOutTab.Text = FormDefineInstance.MixtureFeature.fluid
            Me.lblRefNameOutTab.Text = FormDefineInstance.MixtureFeature.fluid
            Me.SelectedFluidIndex = FormDefineInstance.SelectedFluidIndex
            Me.SelectedFluidName = FormDefineInstance.SelectedFluidName
            Me.SetCritT_PUnit()

            Me.GridComposition.DataSource = FormDefineInstance.CrateTBPerSummary.Copy

            'YYJ[2020.0727]ltgen2: Saving *.FLD filename to TableInfo.txt (hide FLD column)
            Me.GridComposition.Columns(3).Visible = False

            Me.SetGridCompositionHeight()
            Me.SetEnabledControls()
            Me.ControlAndSetUpFluid()
            FormMixingParameters.MixtureFeature.SetProperties(Me.TypeRefrigerant, FormDefineInstance.MixtureComponents, FormDefineInstance.MixtureFeature)
            FormMixingParameters.FormMixingParameters_Load(Nothing, Nothing)
            FormMixingParameters.btnReset_Click(Nothing, Nothing)
        End If
        Me.Enabled = True
        If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
            btnDisplay.Enabled = False
            FormMain.DisplayResultsToolStripMenuItem.Enabled = False
        End If
    End Sub

    'Set the format and the Controls units
    Private Sub UpdateUnitsValue(ByVal NameControl As String, ByVal TypeControl As String, ByVal Value As Double)
        Dim Value0, Value1, Value2 As Double
        Dim IndexUnit As Integer = BordConditions.UnitInteger
        'The Cases are set = to Control name
        Select Case TypeControl
            Case "DTemperature"
                If IndexUnit = 0 Then 'SI with K
                    Value0 = Value : Value1 = Value : Value2 = DTKtoDTE(Value)
                ElseIf IndexUnit = 1 Then 'SI with °C
                    Value0 = Value : Value1 = Value : Value2 = DTKtoDTE(Value)
                ElseIf IndexUnit = 2 Then  'I-p
                    Value0 = DTEtoDTK(Value) : Value1 = DTEtoDTK(Value) : Value2 = Value
                End If
            Case "Temperature"
                If IndexUnit = 0 Then 'SI with K
                    Value0 = Value : Value1 = TKtoTC(Value) : Value2 = TKtoTE(Value)
                ElseIf IndexUnit = 1 Then 'SI with °C
                    Value0 = TCtoTK(Value) : Value1 = Value : Value2 = TCtoTE(Value)
                ElseIf IndexUnit = 2 Then  'I-p
                    Value0 = TEtoTK(Value) : Value1 = TEtoTC(Value) : Value2 = Value
                End If
            Case "Pressure"
                If IndexUnit = 0 Then 'SI with K
                    Value0 = Value : Value1 = Value : Value2 = KPAtoPSI(Value)
                ElseIf IndexUnit = 1 Then 'SI with °C
                    Value0 = Value : Value1 = Value : Value2 = KPAtoPSI(Value)
                ElseIf IndexUnit = 2 Then  'I-p
                    Value0 = PSItokPa(Value) : Value1 = PSItokPa(Value) : Value2 = Value
                End If
            Case "Length"
                If IndexUnit = 0 Then 'SI with K
                    Value0 = Value : Value1 = Value : Value2 = LmtoLft(Value)
                ElseIf IndexUnit = 1 Then 'SI with °C
                    Value0 = Value : Value1 = Value : Value2 = LmtoLft(Value)
                ElseIf IndexUnit = 2 Then  'I-p
                    Value0 = LfttoLm(Value) : Value1 = LfttoLm(Value) : Value2 = Value
                End If
            Case "Area"
                If IndexUnit = 0 Then 'SI with K
                    Value0 = Value : Value1 = Value : Value2 = Lm2toLft2(Value)
                ElseIf IndexUnit = 1 Then 'SI with °C
                    Value0 = Value : Value1 = Value : Value2 = Lm2toLft2(Value)
                ElseIf IndexUnit = 2 Then  'I-p
                    Value0 = Lf2ttoLm2(Value) : Value1 = Lf2ttoLm2(Value) : Value2 = Value
                End If
            Case "UA"
                If IndexUnit = 0 Then 'SI with K
                    Value0 = Value : Value1 = Value : Value2 = KASItoKAE(Value)
                ElseIf IndexUnit = 1 Then 'SI with °C
                    Value0 = Value : Value1 = Value : Value2 = KASItoKAE(Value)
                ElseIf IndexUnit = 2 Then  'I-p
                    Value0 = KAEtoKASI(Value) : Value1 = KAEtoKASI(Value) : Value2 = Value
                End If
            Case "MassFlux"
                If IndexUnit = 0 Then 'SI with K
                    Value0 = Value : Value1 = Value : Value2 = MassFluxSItoMassFluxE(Value)
                ElseIf IndexUnit = 1 Then 'SI with °C
                    Value0 = Value : Value1 = Value : Value2 = MassFluxSItoMassFluxE(Value)
                ElseIf IndexUnit = 2 Then  'I-p
                    Value0 = MassFluxEtoMassFluxSI(Value) : Value1 = MassFluxEtoMassFluxSI(Value) : Value2 = Value
                End If
            Case "Power"
                If IndexUnit = 0 Then 'SI with K
                    Value0 = Value : Value1 = Value : Value2 = kWSItoTonsE(Value)
                ElseIf IndexUnit = 1 Then 'SI with °C
                    Value0 = Value : Value1 = Value : Value2 = kWSItoTonsE(Value)
                ElseIf IndexUnit = 2 Then  'I-p
                    Value0 = TonsSItoEkW(Value) : Value1 = TonsSItoEkW(Value) : Value2 = Value
                End If
        End Select
        DataSetUnit.Tables(TypeControl).Rows(0).Item(NameControl) = Value0
        DataSetUnit.Tables(TypeControl).Rows(1).Item(NameControl) = Value1
        DataSetUnit.Tables(TypeControl).Rows(2).Item(NameControl) = Value2
    End Sub
    Private Function CalculateTheAbsoluteZeroTemp(ByVal UnitSystemType As String, ByRef LabelTemp As String) As Double
        Dim TempMinInAssignedUnit As Double
        Select Case BordConditions.Unit 'All ok
            Case "SI with K"
                TempMinInAssignedUnit = 0
                LabelTemp = DataTableUnits.Rows(0).Item("Temperature").ToString
            Case "SI with °C"
                TempMinInAssignedUnit = TKtoTC(0)
                LabelTemp = DataTableUnits.Rows(1).Item("Temperature").ToString
            Case "I-P Inch-Pound"
                TempMinInAssignedUnit = TKtoTE(0)
                LabelTemp = DataTableUnits.Rows(2).Item("Temperature").ToString
            Case Else
                TempMinInAssignedUnit = 0
                LabelTemp = DataTableUnits.Rows(0).Item("Temperature").ToString
        End Select
        CalculateTheAbsoluteZeroTemp = TempMinInAssignedUnit
    End Function
    Private Sub tabMain_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles tabMain.Selecting
        If Me.FlagLetTabPageChange = False Then
            e.Cancel = True
        End If
        If FlagControlFluidOk2 = 1 Then
            Call ControlAndSetUpFluid()
        Else
            Me.FlagControlFluidOk2 = 1
            Exit Sub
        End If

    End Sub
    'Dll Calling
    Friend Sub ControlAndSetUpFluid()
        ' The flag could be set False when called control, if it will remain True, the controls contro is Ok
        Me.FlagControlFluidOk = True

        If Me.PureFld_FeatureLocalInst.FluidFeature.fluid = Nothing And
                Me.Mixture_FeatureLocalInst.MixtureFeature.fluid = Nothing Then
            'If Me.Mixture_FeatureLocalInst.MixtureFeature.fluid = Nothing Then
            MsgBox("You must select a refrigerant")
            Me.FlagControlFluidOk = False
            Me.FlagControlFluidOk2 = 2
            Me.tabMain.SelectedIndex = 0
            Me.tabMain.SelectedTab.Focus()
            Me.FlagControlFluidOk2 = 1
            Exit Sub
        End If

        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
        ''YYJ[2020.0207] ''' --> '''' (3 to 4)
        '''''If (txtNumRecharges.Text <> "" And txtNumRecharges.Text <> " " And txtNumRecharges.Text <> "  " And txtNumRecharges.Text <> "   ") Then
        'If txtNumRecharges.Text <> Nothing Then
        '    If CDbl(txtNumRecharges.Text) = 0 Then
        '        txtNumRecharges.Text = ""
        '    End If
        'End If
        '''''If (txtMassLoss.Text <> "" And txtMassLoss.Text <> " " And txtMassLoss.Text <> "  " And txtMassLoss.Text <> "   ") Then
        'If txtMassLoss.Text <> Nothing Then
        '    If CDbl(txtMassLoss.Text) = 0 Then
        '        txtMassLoss.Text = ""
        '    End If
        'End If
        'If txtFracFill.Text <> "" Then
        '    If CDbl(txtFracFill.Text) = 0 Then
        '        txtFracFill.Text = ""
        '        txtFillTemp.Text = ""
        '    End If
        'End If
        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e

        'If Me.TypeRefrigerant = 0 Then
        '    Call CAllRefpropSetUp(Me.TypeRefrigerant, PureFluidFeatureLocalInstance.FluidFeature)
        'ElseIf Me.TypeRefrigerant = 1 Or Me.TypeRefrigerant = 2 Then
        '    Call CAllRefpropSetUp(Me.TypeRefrigerant, PureFld_Mix_FeatureLocalInst.MixtureFeature)
        'End If
    End Sub
    Friend Sub VerifyInput()
        'Dim RefCondHTFin, RefCondHTFout As FluidPropertyesRefpropSTR
        'RefCondHTFin = Nothing : RefCondHTFout = Nothing
        Dim IntUnit As Integer = BordConditions.UnitInteger
        Dim CriticalTemperatureSIK, CriticalPressureSIK As Double
        Dim ii(0 To 4) As Integer
        Dim xx(0 To 4) As Double
        Dim DbNum As Double
        If Me.FlagControlFluidOk = False Then 'the fluid control was negative
            Me.FlagControlFluidOk = False
            Exit Sub
        End If
        'If Me.TypeRefrigerant = 1 Or Me.TypeRefrigerant = 2 Then
        '    CriticalTemperatureSIK = Me.PureFld_Mix_FeatureLocalInst.MixtureFeature.tc
        '    CriticalPressureSIK = Me.PureFld_Mix_FeatureLocalInst.MixtureFeature.pc
        'End If
        ' The flag could be set False when called control, if it will remain True, the program can run.
        Me.FlagcontrolsOk = True
        detect = False

        'Control path and mixture names
        'YYJ[2020.1119]ltgen2: make a portable version - s
        If ApplicationFolder.Length >= 240 Then
            'If UserApplicationFolder.Length >= 240 Then
            'YYJ[2020.1119]ltgen2: make a portable version - e

            MsgBox(" The fluid folder path length exceeds the maximum of 240 characters")
            Me.FlagcontrolsOk = False
            Exit Sub
        ElseIf Me.TypeRefrigerant = 2 Then 'Predefined mixture
            For i As Integer = 0 To Me.Mixture_FeatureLocalInst.MixtureFeature.nc - 1
                If Me.Mixture_FeatureLocalInst.MixtureFeature.comp(i).Length - 1 >= 80 Then
                    MsgBox("The mixture component number: " & CStr(i) & "name length exceeds the maximum of 80 characters")
                    Me.FlagcontrolsOk = False
                    Exit Sub
                End If
            Next i
        End If

        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
        'If rbLeakOnly.Checked = False And rbLeakandRecharge.Checked = False Then
        '    MsgBox("Select simulation either to be leak only or leak and recharge.")
        '    Me.FlagcontrolsOk = False
        '    btnAnalyze.Enabled = False
        '    FormMain.Run_But.Enabled = False
        '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
        '    Exit Sub
        'End If
        'If rbLeakandRecharge.Checked = True Then
        '    If (txtNumRecharges.Text = Nothing And txtMassLoss.Text = Nothing) Then
        '        MsgBox("You must input valid data for the number of recharges and the leaked mass percentage. Please try again.")
        '        Me.FlagcontrolsOk = False
        '        Exit Sub
        '    End If
        '    Try
        '        DbNum = CDbl(txtNumRecharges.Text)
        '    Catch ex As InvalidCastException
        '        If txtNumRecharges.Text = Nothing Then
        '            Exit Sub
        '        End If
        '        MsgBox("Please insert a numeric value.")
        '        FormMain.Run_But.Enabled = False
        '        btnAnalyze.Enabled = False
        '        FormMain.AnalyzeToolStripMenuItem.Enabled = False
        '        Me.FlagcontrolsOk = False
        '        Exit Sub
        '    End Try
        '    Try
        '        DbNum = CDbl(txtMassLoss.Text)
        '    Catch ex As InvalidCastException
        '        If txtMassLoss.Text = Nothing Then
        '            Exit Sub
        '        End If
        '        MsgBox("Please insert a numeric value.")
        '        FormMain.Run_But.Enabled = False
        '        btnAnalyze.Enabled = False
        '        FormMain.AnalyzeToolStripMenuItem.Enabled = False
        '        Me.FlagcontrolsOk = False
        '        Exit Sub
        '    End Try
        '    ''''If (txtNumRecharges.Text <> "" And txtNumRecharges.Text <> " " And txtNumRecharges.Text <> "  " And txtNumRecharges.Text <> "   ") Then
        '    If txtNumRecharges.Text <> Nothing Then
        '        ii(1) = CInt(txtNumRecharges.Text)
        '    End If
        '    ''''If (txtMassLoss.Text <> "" And txtMassLoss.Text <> " " And txtMassLoss.Text <> "  " And txtMassLoss.Text <> "   ") Then
        '    If txtMassLoss.Text <> Nothing Then
        '        xx(0) = CDbl(txtMassLoss.Text)
        '    End If
        '    ''''If (ii(1) < 1 Or ii(1) > 20 Or (txtNumRecharges.Text = "" Or txtNumRecharges.Text = " " Or txtNumRecharges.Text = "  " Or txtNumRecharges.Text = "   ")) Then
        '    If (ii(1) < 1 Or ii(1) > 20 Or txtNumRecharges.Text = Nothing) Then
        '        MsgBox("The number of recharges must be an integer greater than zero and less than or equal to 20.")
        '        Me.FlagcontrolsOk = False
        '        FormMain.AnalyzeToolStripMenuItem.Enabled = False
        '        btnAnalyze.Enabled = False
        '        FormMain.Run_But.Enabled = False
        '        txtNumRecharges.SelectAll()
        '        txtNumRecharges.Focus()
        '        Exit Sub
        '    End If
        '    If (xx(0) < 0 Or xx(0) > 100) Then
        '        MsgBox("The leaked mass fraction must be a numeric value between 0 and 100 %.")
        '        Me.FlagcontrolsOk = False
        '        btnAnalyze.Enabled = False
        '        FormMain.Run_But.Enabled = False
        '        FormMain.AnalyzeToolStripMenuItem.Enabled = False
        '        txtMassLoss.SelectAll()
        '        txtMassLoss.Focus()
        '        Exit Sub
        '    End If

        'End If

        'If rbIsothermal.Checked = False And rbAdiabatic.Checked = False Then
        '    MsgBox("Select either isothermal or abiabatic leak conditions.")
        '    Me.FlagcontrolsOk = False
        '    btnAnalyze.Enabled = False
        '    FormMain.Run_But.Enabled = False
        '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
        '    Exit Sub
        'End If

        'If rbVapor.Checked = False And rbLiquid.Checked = False Then
        '    MsgBox("Select the leaking phase either to be vapor or liquid.")
        '    Me.FlagcontrolsOk = False
        '    btnAnalyze.Enabled = False
        '    FormMain.Run_But.Enabled = False
        '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
        '    Exit Sub
        'End If
        'If txtInitialTemp.Text = "" Then
        '    MsgBox("Input an initial temperature.")
        '    Me.FlagcontrolsOk = False
        '    btnAnalyze.Enabled = False
        '    FormMain.Run_But.Enabled = False
        '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
        '    txtInitialTemp.SelectAll()
        '    txtInitialTemp.Focus()
        '    Exit Sub
        'End If
        'If txtInitialVolQual.Text = "" Then
        '    MsgBox("Input an initial quality.")
        '    Me.FlagcontrolsOk = False
        '    Me.btnAnalyze.Enabled = False
        '    FormMain.Run_But.Enabled = False
        '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
        '    txtInitialVolQual.SelectAll()
        '    txtInitialVolQual.Focus()
        '    Exit Sub
        'End If
        'If txtInitialTemp.Text = "NaN" Then
        '    MsgBox("Initial temperature must be a numeric value.")
        '    Me.FlagcontrolsOk = False
        '    btnAnalyze.Enabled = False
        '    FormMain.Run_But.Enabled = False
        '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
        '    txtInitialTemp.SelectAll()
        '    txtInitialTemp.Focus()
        '    Exit Sub
        'End If
        'If txtInitialVolQual.Text = "NaN" Then
        '    Me.FlagcontrolsOk = False
        '    MsgBox("Initial quality must be a numeric value.")
        '    Me.FlagcontrolsOk = False
        '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
        '    btnAnalyze.Enabled = False
        '    FormMain.Run_But.Enabled = False
        '    txtInitialVolQual.SelectAll()
        '    txtInitialVolQual.Focus()
        '    Exit Sub
        'End If
        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e


        If Me.chkVapor.Checked = False And Me.chkLiquid.Checked = False Then
            MsgBox("At least one of the vapor or liquid boxes should be checked." & Environment.NewLine &
                  "These boxes determine what simulation data is displayed.")
            FlagcontrolsOk = False
            Exit Sub
        End If

        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
        'CheckTextBoxTInit(txtInitialTemp)
        'CheckTextBox(txtInitialVolQual)
        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e

        If Me.FlagcontrolsOk = False Then
            Exit Sub
        End If
        Me.FlagcontrolsOk = True
        FormMain.AnalyzeToolStripMenuItem.Enabled = True
        btnAnalyze.Enabled = True
        FormMain.Run_But.Enabled = True
        FormMain.Run_But.Visible = True

        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
        'Select Case BordConditions.Unit 'All ok
        '    Case "SI with K"
        '        InitTempK = CDbl(txtInitialTemp.Text)
        '        InitTempC = TKtoTC(InitTempK)
        '        InitTempF = TKtoTE(InitTempK)
        '    Case "SI with °C"
        '        InitTempC = CDbl(txtInitialTemp.Text)
        '        InitTempK = TCtoTK(InitTempC)
        '        InitTempF = TCtoTE(InitTempC)
        '    Case "I-P Inch-Pound"
        '        InitTempF = CDbl(txtInitialTemp.Text)
        '        InitTempK = TEtoTK(InitTempF)
        '        InitTempC = TEtoTC(InitTempF)
        '    Case Else
        '        InitTempK = CDbl(txtInitialTemp.Text)
        '        InitTempC = TKtoTC(InitTempK)
        '        InitTempF = TKtoTE(InitTempK)
        'End Select
        'initialVQ = CDbl(txtInitialVolQual.Text)
        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e
    End Sub

    Friend Sub CallDllFortran()

        'Save the last used file

        Me.WriteControlVariables()
        'Me.BordConditionsLocalInstance.SaveFile(UserApplicationFolder & "\Last.xml")

        'YYJ[2020.0425]ltgen2: remove RfLkDLL - s
        '        '''''''''''''''''' Dim IIF As Integer
        '        Dim aa(239), bb(239) As Char
        '        Dim aaDummy(79), aaDummyHRF(79) As Char
        '        Dim aa1(79), aa2(79), aa3(79), aa4(79), aa5(79), aa6(79), aa7(79), aa8(79), aa9(79), aa10(79) As Char
        '        Dim aa11(79) As Char
        '        Dim i, j As Integer
        '        Dim StringDummy As String = Nothing
        '        Dim StringDummyArray(NMaxRefrigrants - 1) As String
        '        Dim ii(7) As Integer
        '        Dim iii(10) As Integer
        '        Dim xx(2) As Double
        '        Dim XLocal(NMaxRefrigrants - 1) As Double
        '        Dim xmixpar1(44) As Double, xmixpar2(44) As Double, xmixpar3(44) As Double, xmixpar4(44) As Double, xmixpar5(44) As Double
        '        Dim xMXM(144) As Char
        '        Dim xMXMdummy(3) As Char

        '        Dim ncLocal As Integer
        '        Dim ijk1, ijk2, ijk3, icomp, jcomp As Integer

        '        'Path for the DLL, the files written by the DLL must be written on the UserApplicationFolderLength
        '        Dim UserApplicationFolderLength As Integer = UserApplicationFolder.Length
        '        Dim ApplicationFolderLength As Integer = ApplicationFolder.Length
        '        Dim UserApplicationFolderLocal As String = UserApplicationFolder
        '        Dim UserApplicationFolderChar(239), ApplicationFolderChar(239) As Char



        '        For i = 0 To 6
        '            ii(i) = 0
        '        Next
        '        For i = 0 To 2
        '            xx(i) = 0
        '        Next

        '        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
        '        ii(0) = 1
        '        'If rbLeakOnly.Checked = True Then
        '        '    ii(0) = 1
        '        'End If
        '        'If rbLeakandRecharge.Checked = True Then
        '        '    ii(0) = 2
        '        'End If
        '        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e

        '        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
        '        'If rbLeakandRecharge.Checked = True Then
        '        '    ''''If (Me.txtNumRecharges.Text = "" Or Me.txtNumRecharges.Text = " " Or Me.txtNumRecharges.Text = "  " Or Me.txtNumRecharges.Text = "   " Or Me.txtNumRecharges.Text = "    " Or Me.txtNumRecharges.Text = "     " Or Me.txtNumRecharges.Text = "      " Or Me.txtNumRecharges.Text = "       ") Then
        '        '    If Me.txtNumRecharges.Text = Nothing Then
        '        '        MsgBox("Please input valid values for the number of recharges.")
        '        '        Exit Sub
        '        '    End If
        '        '    '''''If (Me.txtMassLoss.Text = "" Or Me.txtMassLoss.Text = " " Or Me.txtMassLoss.Text = "  " Or Me.txtMassLoss.Text = "   " Or Me.txtMassLoss.Text = "    " Or Me.txtMassLoss.Text = "     " Or Me.txtMassLoss.Text = "      " Or Me.txtMassLoss.Text = "       ") Then
        '        '    If Me.txtMassLoss.Text = Nothing Then
        '        '        MsgBox("Please input valid values for the percent mass loss.")
        '        '        Exit Sub
        '        '    End If
        '        '    ii(1) = CInt(txtNumRecharges.Text)
        '        '    xx(0) = CDbl(txtMassLoss.Text)
        '        'Else
        '        '    ii(1) = 0
        '        '    xx(0) = 0
        '        'End If
        '        'If rbIsothermal.Checked = True Then
        '        '    ii(2) = 1
        '        'End If
        '        'If rbAdiabatic.Checked = True Then
        '        '    ii(2) = 2
        '        'End If
        '        'If rbVapor.Checked = True Then
        '        '    ii(3) = 1
        '        'End If
        '        'If rbLiquid.Checked = True Then
        '        '    ii(3) = 2
        '        'End If
        '        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e

        '        ii(4) = Me.PureFld_Mix_FeatureLocalInst.MixtureFeature.nc

        '        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
        '        'If BordConditions.UnitInteger = 0 Then
        '        '    xx(1) = CDbl(txtInitialTemp.Text)
        '        'ElseIf BordConditions.UnitInteger = 1 Then
        '        '    xx(1) = TCtoTK(CDbl(txtInitialTemp.Text))
        '        'ElseIf BordConditions.UnitInteger = 2 Then
        '        '    xx(1) = TEtoTK(CDbl(txtInitialTemp.Text))
        '        'End If

        '        'xx(2) = CDbl(txtInitialVolQual.Text)
        '        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e

        '        If ii(4) = 2 Then j = 1
        '        If ii(4) = 3 Then j = 3
        '        If ii(4) = 4 Then j = 6
        '        If ii(4) = 5 Then j = 10
        '        If ii(4) = 6 Then j = 15
        '        If ii(4) = 7 Then j = 21
        '        If ii(4) = 8 Then j = 28
        '        If ii(4) = 9 Then j = 36
        '        If ii(4) = 10 Then j = 45

        '        ii(5) = j


        '        ncLocal = Me.PureFld_Mix_FeatureLocalInst.MixtureFeature.nc
        '        XLocal = Me.PureFld_Mix_FeatureLocalInst.MixtureFeature.X

        '        'FormMixingParameters.FormMixingParameters_Load(Nothing, Nothing)

        '        Dim nLoopCounter As Integer
        '        nLoopCounter = 0


        '        For i = 0 To j - 1
        '            With FormMixingParameters
        '                'need to put models as well
        '                If blnlblUserDefined(i) = False Then

        '                    ijk1 = 0
        '                    For ijk2 = 1 To ncLocal - 1
        '                        For ijk3 = ijk2 + 1 To ncLocal
        '                            If (ijk1 = i) Then
        '                                icomp = ijk2
        '                                jcomp = ijk3

        '                                .refprop_coeff(icomp, jcomp, mixingmodeset(ijk1))
        '                                nLoopCounter = nLoopCounter + 1


        '                            End If
        '                            ijk1 = ijk1 + 1

        '                        Next ijk3


        '                    Next ijk2

        '                    xmixpar1(i) = .inter_coeff_input1
        '                    xmixpar2(i) = .inter_coeff_input2
        '                    xmixpar3(i) = .inter_coeff_input3
        '                    xmixpar4(i) = .inter_coeff_input4
        '                    xmixpar5(i) = .inter_coeff_input5

        '                    xMXMdummy = CType(mixing_mode, Char())
        '                    Array.ConstrainedCopy(xMXMdummy, 0, xMXM, i * 3, 3)

        '                    'xMXM(i) = mixing_mode
        '                Else
        '                    xmixpar1(i) = inter_coeff_input1_set(i)
        '                    xmixpar2(i) = inter_coeff_input2_set(i)
        '                    xmixpar3(i) = inter_coeff_input3_set(i)
        '                    xmixpar4(i) = inter_coeff_input4_set(i)
        '                    xmixpar5(i) = inter_coeff_input5_set(i)
        '                    xMXMdummy = CType(mixingmodeset(i), Char())
        '                    Array.ConstrainedCopy(xMXMdummy, 0, xMXM, i * 3, 3)
        '                    'xMXM(i) = mixingmodeset(i)
        '                End If
        '            End With
        '        Next i

        '        '  xMXMdummy = CType("KWR", Char())

        '        XLocal.Initialize()

        '        For i = 0 To Me.PureFld_Mix_FeatureLocalInst.MixtureFeature.nc - 1
        '            StringDummyArray(i) = Me.PureFld_Mix_FeatureLocalInst.MixtureFeature.comp(i)
        '        Next i

        '        aa1 = CType(StringDummyArray(0), Char())
        '        aa2 = CType(StringDummyArray(1), Char())
        '        aa3 = CType(StringDummyArray(2), Char())
        '        aa4 = CType(StringDummyArray(3), Char())
        '        aa5 = CType(StringDummyArray(4), Char())
        '        aa6 = CType(StringDummyArray(5), Char())
        '        aa7 = CType(StringDummyArray(6), Char())
        '        aa8 = CType(StringDummyArray(7), Char())
        '        aa9 = CType(StringDummyArray(8), Char())
        '        aa10 = CType(StringDummyArray(9), Char())

        '        For i = 0 To iii.Length - 2
        '            If i <= ncLocal - 1 Then
        '                iii(i) = Me.PureFld_Mix_FeatureLocalInst.MixtureFeature.comp(i).Length
        '            Else
        '                iii(i) = 0
        '            End If
        '        Next i

        '        'Reference state
        '        aaDummyHRF = CType(BordConditions.RefStateString, Char())
        '        aa11 = CType(aaDummyHRF, Char())
        '        iii(10) = aaDummyHRF.Length

        '        StringDummy = Me.PureFld_Mix_FeatureLocalInst.MixtureFeature.fluid

        '        UserApplicationFolderChar = CType(UserApplicationFolderLocal, Char())
        '        Array.ConstrainedCopy(UserApplicationFolderChar, 0, aa, 0, UserApplicationFolderChar.Length)
        '        ApplicationFolderChar = CType(ApplicationFolder, Char())
        '        Array.ConstrainedCopy(ApplicationFolderChar, 0, bb, 0, ApplicationFolderChar.Length)


        '        'If ncLocal = 1 Then
        '        'xx(0) = XLocal(0)
        '        'Else
        '        'With Me.PureFld_Mix_FeatureLocalInst.MixtureFeature
        '        'Array.ConstrainedCopy(.WmElements, 0, xx, 0, .WmElements.Length)
        '        'End With
        '        'End If


        '        ii(6) = UserApplicationFolderLength
        '        ii(7) = ApplicationFolderLength


        '        For i = 0 To 1000
        '            TB(0) = 0
        '            PB(0) = 0
        '            VLB(0) = 0
        '            VVB(0) = 0
        '            VQB(0) = 0
        '            QB(0) = 0
        '            PMOLEB(0) = 0
        '            PMASSB(0) = 0
        '        Next i

        '        For i = 0 To 1000
        '            For j = 0 To 9
        '                XLB(j, i) = 0
        '                XVB(j, i) = 0
        '            Next
        '        Next

        '        System.IO.Directory.SetCurrentDirectory(UserApplicationFolder)

        '        Call REFLEAKB_V60(ii(0), iii(0), xx(0), XLocal(0), xmixpar1(0), xmixpar2(0), xmixpar3(0), xmixpar4(0), xmixpar5(0), aa, bb _
        '                         , aa1, aa2, aa3, aa4, aa5, aa6, aa7, aa8, aa9, aa10, aa11, xMXM, TB(0), PB(0), VLB(0), VVB(0), QB(0), VQB(0),
        '        PMOLEB(0), PMASSB(0), XLB(0, 0), XVB(0, 0), IIF)

        '        Me.FlagControlPostDataOk = True
        '        Call postdata()
        '        ' Set the structure containing the parameters for the chart


        'errhandler:
        '        Select Case Err.Number
        '            Case 55 'File already open
        '                Me.VerifyInput()
        '            Case 0
        '            Case Else

        '        End Select
        'YYJ[2020.0425]ltgen2: remove RfLkDLL - e
    End Sub
    Friend Sub postdata()
        'Dim fn As Integer
        'Dim line_input As String
        'Dim NameFilePathComplete As String
        'Dim istatus As Integer
        'Dim nclocal As Integer
        'Dim XLocal(NMaxRefrigrants - 1) As Double


        'If My.Computer.FileSystem.GetFileInfo(UserApplicationFolder & "\ERREF.txt").Length = 0 Then
        '    blnError = False
        'Else
        '    blnError = True
        'End If
        '' these have to go somewhere Me.FlagMustControlPostDataFalse = True
        '' these have to go somewhere Me.FlagControlPostDataOk = False


        'NameFilePathComplete = UserApplicationFolder & "\Status"

        'fn = FreeFile()

        'FileOpen(fn, NameFilePathComplete, OpenMode.Input)
        'line_input = LineInput(fn)
        'istatus = CInt(line_input)

        'FileClose(fn)

        'If (istatus = 999 And detect = False) Then
        '    MsgBox("The simulation did not yield valid results. Please modify input data and/or fluid and try again.")
        '    Me.FlagControlPostDataOk = False
        '    Exit Sub
        'ElseIf (istatus = 999 And detect = True) Then
        '    Me.FlagControlPostDataOk = False
        '    Exit Sub
        'Else
        '    Me.FlagControlPostDataOk = True
        'End If


        'nclocal = Me.PureFld_Mix_FeatureLocalInst.MixtureFeature.nc
        'XLocal = Me.PureFld_Mix_FeatureLocalInst.MixtureFeature.X
        'Dim IIF2 As Integer
        'IIF2 = IIF
        'For ij = 0 To IIF2
        '    If TB(ij) < (InitTempK - 5) Then
        '        IIF = ij - 1
        '    End If
        'Next
        'Dim ISIMUL, NORECG, ICASE, IPHASE As Integer
        'Dim ShowLiquid, ShowVapor As Boolean
        'Dim PercentOfRecharge As Double

        ''YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
        'ISIMUL = 0
        'IPHASE = 0
        'NORECG = 0
        'PercentOfRecharge = 0
        'ICASE = 0
        ''If Me.rbLeakOnly.Checked Then
        ''    ISIMUL = 0
        ''ElseIf Me.rbLeakandRecharge.Checked Then
        ''    ISIMUL = 1
        ''End If
        ''If Me.rbLiquid.Checked Then
        ''    IPHASE = 0
        ''ElseIf Me.rbVapor.Checked Then
        ''    IPHASE = 1
        ''End If
        ''Try
        ''    NORECG = CInt(Me.txtNumRecharges.Text)
        ''Catch ex As InvalidCastException
        ''    NORECG = 0
        ''End Try
        ''Try
        ''    PercentOfRecharge = CDbl(Me.txtMassLoss.Text)
        ''Catch ex As InvalidCastException
        ''    PercentOfRecharge = 0
        ''End Try
        ''If Me.rbIsothermal.Checked Then
        ''    ICASE = 0
        ''ElseIf Me.rbAdiabatic.Checked Then
        ''    ICASE = 1
        ''End If
        ''YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e

        'ShowLiquid = Me.chkLiquid.Checked
        'ShowVapor = Me.chkVapor.Checked

        'If (detect = False) Then

        '    Me.InputChart.IIF = IIF
        '    Me.InputChart.nc = nclocal
        '    Me.InputChart.ISIMUL = ISIMUL
        '    Me.InputChart.NORECG = NORECG
        '    Me.InputChart.ICASE = ICASE
        '    Me.InputChart.IPHASE = IPHASE
        '    Me.InputChart.PercentOfRecharge = PercentOfRecharge
        '    Me.InputChart.ShowLiquid = ShowLiquid
        '    Me.InputChart.ShowVapor = ShowVapor
        '    ReDim Me.InputChart.TB(IIF)
        '    Array.Copy(TB, Me.InputChart.TB, IIF + 1)
        '    ReDim Me.InputChart.PB(IIF)
        '    Array.Copy(PB, Me.InputChart.PB, IIF + 1)
        '    ReDim Me.InputChart.VLB(IIF)
        '    Array.Copy(VLB, Me.InputChart.VLB, IIF + 1)
        '    ReDim Me.InputChart.VVB(IIF)
        '    Array.Copy(VVB, Me.InputChart.VVB, IIF + 1)
        '    ReDim Me.InputChart.VQB(IIF)
        '    Array.Copy(VQB, Me.InputChart.VQB, IIF + 1)
        '    ReDim Me.InputChart.QB(IIF)
        '    Array.Copy(QB, Me.InputChart.QB, IIF + 1)
        '    ReDim Me.InputChart.PMOLEB(IIF)
        '    Array.Copy(PMOLEB, Me.InputChart.PMOLEB, IIF + 1)
        '    ReDim Me.InputChart.PMASSB(IIF)
        '    Array.Copy(PMASSB, Me.InputChart.PMASSB, IIF + 1)
        '    ReDim Me.InputChart.XLBArrays(nclocal - 1)
        '    ReDim Me.InputChart.XVBArrays(nclocal - 1)
        '    Me.InputChart.XLB = XLB
        '    Me.InputChart.XVB = XVB
        '    For i = 0 To nclocal - 1
        '        ReDim Me.InputChart.XLBArrays(i)(IIF)
        '        ReDim Me.InputChart.XVBArrays(i)(IIF)
        '        For j = 0 To IIF
        '            Me.InputChart.XLBArrays(i)(j) = XLB(i, j)
        '            Me.InputChart.XVBArrays(i)(j) = XVB(i, j)
        '        Next j
        '    Next i
        '    Me.FlagControlPostDataOk = True
        'Else
        '    Me.FlagControlPostDataOk = False
        'End If
    End Sub

    'Set the variables over the Bord condition class to save them in a file
    Friend Sub WriteControlVariables()
        With Me.BordConditionsLocalInstance
            .LTG_HPlimit = CInt(Me.txtHP.Text)
            .LTG_LPlimit = CInt(Me.txtLP.Text)
            .LTG_Pnum = CInt(Me.nudP.Value)
            .LTG_Hnum = CInt(Me.nudH.Value)

            'YYJ[2020.1028] Alweays use Linear scale - s
            .LTG_LINscl = 1
            .LTG_LOGscl = 0
            '.LTG_LINscl = CInt(Me.rbtScale1.Checked)
            '.LTG_LOGscl = CInt(Me.rbtScale2.Checked)
            'YYJ[2020.1028] Alweays use Linear scale - e

            .TypeRefrigerant = Me.TypeRefrigerant
            .SelectedIndex = Me.SelectedFluidIndex
            .SelectedFluidName = Me.SelectedFluidName

            If Me.TypeRefrigerant = 0 Then
                .PureFluidFeatureinstance.SetProperties(.TypeRefrigerant,
                                                        Me.PureFld_FeatureLocalInst.FluidFeature)
            Else
                .MixtureFeatureinstance.SetProperties(.TypeRefrigerant,
                                                      Me.Mixture_FeatureLocalInst.FluidsFeature,
                                                      Me.Mixture_FeatureLocalInst.MixtureFeature)
            End If

            If Me.chkVapor.Checked And Me.chkLiquid.Checked Then
                .VaporLiquidDisplayResults = 0
            ElseIf Me.chkVapor.Checked And Not Me.chkLiquid.Checked Then
                .VaporLiquidDisplayResults = 1
            ElseIf Not Me.chkVapor.Checked And Me.chkLiquid.Checked Then
                .VaporLiquidDisplayResults = 2
            Else
                .VaporLiquidDisplayResults = 0
            End If

            'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e
            .LeakType = 0
            .LeakingPhase = 0
            .Simulation = 0
            .NumberOfRecharge = 0
            .PercentMassLossForRecharging = 0
            .InletTemperature = 0
            .IntialVolumetricQuality = 0
            .FillTemperature = 0
            .FractionOfMaximumLiquidFill = 0
            'If Me.rbIsothermal.Checked Then
            '    .LeakType = 0
            'ElseIf Me.rbAdiabatic.Checked Then
            '    .LeakType = 1
            'End If
            'If Me.rbVapor.Checked Then
            '    .LeakingPhase = 0
            'ElseIf Me.rbLiquid.Checked Then
            '    .LeakingPhase = 1
            'End If
            'If Me.rbLeakOnly.Checked Then
            '    .Simulation = 0
            'ElseIf Me.rbLeakandRecharge.Checked Then
            '    .Simulation = 1
            'End If
            'Try
            '    .NumberOfRecharge = CInt(Me.txtNumRecharges.Text)
            'Catch ex As InvalidCastException
            '    .NumberOfRecharge = 0
            'End Try
            'Try
            '    .PercentMassLossForRecharging = CDbl(Me.txtMassLoss.Text)
            'Catch ex As InvalidCastException
            '    .PercentMassLossForRecharging = 0
            'End Try
            'Try
            '    .InletTemperature = CDbl(Me.txtInitialTemp.Text)
            'Catch ex As InvalidCastException
            '    .InletTemperature = 0
            'End Try
            'Try
            '    .IntialVolumetricQuality = CDbl(Me.txtInitialVolQual.Text)
            'Catch ex As InvalidCastException
            '    .IntialVolumetricQuality = 0
            'End Try
            'Try
            '    .FillTemperature = CDbl(Me.txtFillTemp.Text)
            'Catch ex As InvalidCastException
            '    .FillTemperature = 0
            'End Try
            'Try
            '    .FractionOfMaximumLiquidFill = CDbl(Me.txtFracFill.Text)
            'Catch ex As InvalidCastException
            '    .FractionOfMaximumLiquidFill = 0
            'End Try
            'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e
        End With
    End Sub
    'Read the variables over the Bord condition class to save them in a file
    Friend Sub ReadControlVariables()
        Me.FlagRadingASavedFile = True
        With Me.BordConditionsLocalInstance
            Me.txtHP.Text = CStr(.LTG_HPlimit)
            Me.txtLP.Text = CStr(.LTG_LPlimit)
            Me.nudP.Value = CInt(.LTG_Pnum)
            Me.nudH.Value = CInt(.LTG_Hnum)
            'YYJ[2020.1028] Alweays use Linear scale - s
            Me.rbtScale1.Checked = True
            Me.rbtScale2.Checked = False
            'Me.rbtScale1.Checked = CBool(.LTG_LINscl)
            'Me.rbtScale2.Checked = CBool(.LTG_LOGscl)
            'YYJ[2020.1028] Alweays use Linear scale - e
            Me.TypeRefrigerant = .TypeRefrigerant
            Me.SelectedFluidIndex = .SelectedIndex
            Me.SelectedFluidName = .SelectedFluidName

            'Set the refrigerant feature
            If .TypeRefrigerant = 1 Or .TypeRefrigerant = 2 Then
                Me.Mixture_FeatureLocalInst.SetProperties(.TypeRefrigerant,
                                                          .MixtureFeatureinstance.FluidsFeature,
                                                          .MixtureFeatureinstance.MixtureFeature)
                Me.GridComposition.DataSource = FormPredefined.CreateTBPerSummaryinFormInput(.MixtureFeatureinstance.MixtureFeature, .MixtureFeatureinstance.FluidsFeature).Copy
                Me.REfNameLBL.Text = Me.Mixture_FeatureLocalInst.MixtureFeature.fluid
                Me.lblRefNameOutTab.Text = Me.Mixture_FeatureLocalInst.MixtureFeature.fluid
                FormMixingParameters.MixtureFeature.SetProperties(.TypeRefrigerant, .MixtureFeatureinstance.FluidsFeature, .MixtureFeatureinstance.MixtureFeature)
            Else
                Me.PureFld_FeatureLocalInst.SetProperties(.TypeRefrigerant,
                                                          .PureFluidFeatureinstance.FluidFeature)

                Me.GridComposition.DataSource = frmPreDefPureFld.CreateTBPerSummary_PureFld_frmInput(.PureFluidFeatureinstance.FluidFeature).Copy()
                Me.frmComponents.Visible = False

                'YYJ[2020.0704]ltgen2: Handling ShortName - s
                Dim PureFldShortName As String = Me.PureFld_FeatureLocalInst.FluidFeature.ShortName
                Me.REfNameLBL.Text = PureFldShortName
                Me.lblRefNameOutTab.Text = PureFldShortName
                'Me.REfNameLBL.Text = Me.PureFld_FeatureLocalInst.FluidFeature.fluid
                'Me.lblRefNameOutTab.Text = Me.PureFld_FeatureLocalInst.FluidFeature.fluid
                'YYJ[2020.0704]ltgen2: Handling ShortName - e

                'FormMixingParameters.MixtureFeature.SetProperties(.TypeRefrigerant, .MixtureFeatureinstance.FluidsFeature, .MixtureFeatureinstance.MixtureFeature)
            End If


            Me.SetCritT_PUnit()
            Me.SetGridCompositionHeight()
            If .VaporLiquidDisplayResults = 0 Then
                Me.chkVapor.Checked = True
                Me.chkLiquid.Checked = True
            ElseIf .VaporLiquidDisplayResults = 1 Then
                Me.chkVapor.Checked = True
                Me.chkLiquid.Checked = False
            ElseIf .VaporLiquidDisplayResults = 2 Then
                Me.chkVapor.Checked = False
                Me.chkLiquid.Checked = True
            Else
                Me.chkVapor.Checked = True
                Me.chkLiquid.Checked = True
            End If

            'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
            'If .LeakType = 0 Then
            '    Me.rbIsothermal.Checked = True
            'ElseIf .LeakType = 1 Then
            '    Me.rbAdiabatic.Checked = True
            'End If
            'If .LeakingPhase = 0 Then
            '    Me.rbVapor.Checked = True
            'ElseIf .LeakingPhase = 1 Then
            '    Me.rbLiquid.Checked = True
            'End If
            'If .Simulation = 0 Then
            '    Me.rbLeakOnly.Checked = True
            'ElseIf .Simulation = 1 Then
            '    Me.rbLeakandRecharge.Checked = True
            'End If
            'Me.txtNumRecharges.Text = CStr(.NumberOfRecharge)
            'Me.txtMassLoss.Text = CStr(.PercentMassLossForRecharging)
            'Me.txtInitialTemp.Text = CStr(.InletTemperature)
            'Me.txtInitialVolQual.Text = CStr(.IntialVolumetricQuality)
            'Me.txtFillTemp.Text = CStr(.FillTemperature)
            'Me.txtFracFill.Text = CStr(.FractionOfMaximumLiquidFill)
            'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e

            If BordConditions.UnitInteger = 0 Then
                Me.InitialTempK = .InletTemperature
                Me.InitialTempC = TKtoTC(.InletTemperature)
                Me.InitialTempF = TKtoTE(.InletTemperature)
                Me.FillTempK = .FillTemperature
                Me.FillTempC = TKtoTC(.FillTemperature)
                Me.FillTempF = TKtoTE(.FillTemperature)
            ElseIf BordConditions.UnitInteger = 1 Then
                Me.InitialTempK = TCtoTK(.InletTemperature)
                Me.InitialTempC = .InletTemperature
                Me.InitialTempF = TCtoTE(.InletTemperature)
                Me.FillTempK = TCtoTK(.FillTemperature)
                Me.FillTempC = .FillTemperature
                Me.FillTempF = TCtoTE(.FillTemperature)
            ElseIf BordConditions.UnitInteger = 2 Then
                Me.InitialTempK = TEtoTK(.InletTemperature)
                Me.InitialTempC = TEtoTC(.InletTemperature)
                Me.InitialTempF = .InletTemperature
                Me.FillTempK = TEtoTK(.FillTemperature)
                Me.FillTempC = TEtoTC(.FillTemperature)
                Me.FillTempF = .FillTemperature
            Else
                Me.InitialTempK = .InletTemperature
                Me.InitialTempC = TKtoTC(.InletTemperature)
                Me.InitialTempF = TKtoTE(.InletTemperature)
                Me.FillTempK = .FillTemperature
                Me.FillTempC = TKtoTC(.FillTemperature)
                Me.FillTempF = TKtoTE(.FillTemperature)
            End If
        End With
        Me.FlagRadingASavedFile = False

        'YYJ[2020.0727]ltgen2: Saving *.FLD filename to TableInfo.txt (hide FLD column)
        Me.GridComposition.Columns(3).Visible = False

    End Sub
    Private Sub frmInput_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.tabMain.Select() 'To avoid textbox message opening when closing the form
        'Look how many frm input remain opened!
        Dim FormMain As FormMain
        Dim FrmInputCount As Integer = 0
        If Me.MdiParent.Name = "FormMain" Then

            'YYJ[2020.0425]ltgen2: 'LTGen2' from Project_>Property->Application_>...
            FormMain = CType(Me.MdiParent, LTGen2.FormMain)
            'FormMain = CType(Me.MdiParent, REFLEAK.FormMain)

            For Each Children As Form In Me.MdiParent.MdiChildren
                If TypeOf Children Is frmInput Then
                    FrmInputCount += 1
                End If
            Next
            If FrmInputCount = 1 Then
                FormMain.SetControlsAsBeforeRunnigSimulation()
                FormMain.FlagOPenNewChildren = False
                FormMain.Run_But.Visible = False : FormMain.AnalyzeToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub

    Private Function Round(ByVal ToRound As Double) As Double
        If ToRound < 10 Then
            Round = Math.Round(ToRound, 3)
        ElseIf ToRound < 1000 Then
            Round = Math.Round(ToRound, 2)
        Else
            Round = Math.Round(ToRound, 1)
        End If
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        FormMain.Close()
        Application.Exit()
    End Sub

    'YYJ[2020.0425]ltgen2: remove 'Chart' logics - s
    'Public Sub btnAnalyze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalyze.Click
    '    For Each Form As Form In My.Application.OpenForms
    '        If TypeOf Form Is Chart Then
    '            Form.Close()
    '            Exit For
    '        End If
    '    Next
    '    Call FormMain.Analyze()
    'End Sub
    'YYJ[2020.0425]ltgen2: remove 'Chart' logics - e

    'YYJ[2020.0425]ltgen2: remove 'Chart' logics - s
    'Public Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
    '    Dim FlagFormAlreadyOpened As Boolean = False
    '    Dim FormChart As Chart = Nothing
    '    For Each Form As Form In Application.OpenForms
    '        If TypeOf Form Is Chart Then
    '            FlagFormAlreadyOpened = True
    '            FormChart = CType(Form, Chart)
    '            Exit For
    '        End If
    '    Next Form
    '    If FlagFormAlreadyOpened Then
    '        FormChart.BringToFront()
    '    Else
    '        Dim ChartInstance As New Chart
    '        ChartInstance.InputChart = Me.InputChart
    '        ChartInstance.FlagTimerEnabled = False
    '        With Me.PureFld_Mix_FeatureLocalInst
    '            ChartInstance.FluidMixtureClass.SetProperties(.TypeRefrigerant, .FluidsFeature, .MixtureFeature)
    '        End With
    '        ChartInstance.Show()
    '    End If
    '    FormMain.Print_But.Enabled = True
    '    FormMain.PrintToolStripMenuItem.Enabled = True
    'End Sub
    'YYJ[2020.0425]ltgen2: remove 'Chart' logics - e

    Private Sub btnViewMixing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewMixing.Click
        Call ControlAndSetUpFluid()
        If FlagControlFluidOk = False Then Exit Sub
        FormMixingParameters.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        formUnits.Show()
    End Sub

    'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
    '    Private Sub rbLeakOnly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If Me.rbLeakOnly.Checked = True Then
    '            frmRechargeProcess.Enabled = False
    '            Me.SetEnabledControls()
    '        Else
    '            frmRechargeProcess.Enabled = True
    '            Me.SetEnabledControls()
    '        End If
    '        If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
    '            btnDisplay.Enabled = False
    '            FormMain.DisplayResultsToolStripMenuItem.Enabled = False
    '        End If
    '    End Sub

    '    Private Sub rbLeakandRecharge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If Me.rbLeakOnly.Checked = True Then
    '            frmRechargeProcess.Enabled = False
    '            Me.SetEnabledControls()
    '        Else
    '            frmRechargeProcess.Enabled = True
    '            Me.SetEnabledControls()
    '        End If
    '        If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
    '            btnDisplay.Enabled = False
    '            FormMain.DisplayResultsToolStripMenuItem.Enabled = False
    '        End If
    '    End Sub

    '    Private Sub txtFracFill_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If (txtFracFill.Text = "" Or txtFillTemp.Text = "") Then
    '            btnCalculate.Enabled = False
    '        Else
    '            btnCalculate.Enabled = True
    '            If (vqfracviewed = True) Then
    '                fill = True
    '                txtInitialVolQual.Text = ""
    '            End If
    '        End If
    '        If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
    '            btnDisplay.Enabled = False
    '            FormMain.DisplayResultsToolStripMenuItem.Enabled = False
    '        End If
    '    End Sub
    '    Private Sub txtFillTemp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If (txtFracFill.Text = "" Or txtFillTemp.Text = "") Then
    '            btnCalculate.Enabled = False
    '        Else
    '            btnCalculate.Enabled = True
    '            If (vqfracviewed = True) Then
    '                fill = True
    '                txtInitialVolQual.Text = ""
    '            End If
    '        End If
    '        If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
    '            btnDisplay.Enabled = False
    '            FormMain.DisplayResultsToolStripMenuItem.Enabled = False
    '        End If
    '    End Sub
    '    Private Sub txtFillTemp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim i As Integer
    '        If calcVQ = True Then
    '            Exit Sub
    '        ElseIf (vqfracviewed = False) Then
    '            vqfracviewed = True
    '            i = MsgBox("If you choose to use this optional calculation method, you cannot independently specify the initial volumetric quality data shown above (it will be calculated for you by the program). Do you wish to continue with the optional calculation method?", vbYesNo)
    '        End If
    '        If (i = 6) Then
    '            txtInitialVolQual.Text = ""
    '            calcVQ = True
    '            txtFillTemp.TabStop = True
    '            txtFracFill.TabStop = True
    '            Me.SetEnabledControls()
    '            If (txtInitialTemp.Text = "" Or txtInitialVolQual.Text = "") Then
    '                btnAnalyze.Enabled = False
    '                FormMain.Run_But.Enabled = False
    '                FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '                If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
    '                    btnDisplay.Enabled = False
    '                    FormMain.DisplayResultsToolStripMenuItem.Enabled = False
    '                End If
    '            Else
    '                btnAnalyze.Enabled = True
    '                FormMain.Run_But.Enabled = True
    '                FormMain.AnalyzeToolStripMenuItem.Enabled = True
    '            End If
    '        End If
    '        If (i = 7) Then
    '            txtFillTemp.Text = ""
    '            txtFracFill.Text = ""
    '            calcVQ = False
    '            txtFillTemp.TabStop = False
    '            txtFracFill.TabStop = False
    '            txtInitialVolQual.SelectAll()
    '            txtInitialVolQual.Focus()
    '            Me.SetEnabledControls()
    '            If (txtInitialTemp.Text = "" Or txtInitialVolQual.Text = "") Then
    '                btnAnalyze.Enabled = False
    '                FormMain.Run_But.Enabled = False
    '                FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '                If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
    '                    btnDisplay.Enabled = False
    '                    FormMain.DisplayResultsToolStripMenuItem.Enabled = False
    '                End If
    '            Else
    '                btnAnalyze.Enabled = True
    '                FormMain.Run_But.Enabled = True
    '                FormMain.AnalyzeToolStripMenuItem.Enabled = True
    '            End If
    '            Exit Sub
    '        End If
    '    End Sub
    '    Private Sub txtFracFill_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim i As Integer
    '        If calcVQ = True Then
    '            Exit Sub
    '        ElseIf (vqfracviewed = False) Then
    '            vqfracviewed = True
    '            i = MsgBox("If you choose to use this optional calculation method, you cannot independently specify the initial volumetric quality data shown above (it will be calculated for you by the program). Do you wish to continue with the optional calculation method?", vbYesNo)
    '        End If
    '        If (i = 6) Then
    '            txtInitialVolQual.Text = ""
    '            calcVQ = True
    '            txtFillTemp.TabStop = True
    '            txtFracFill.TabStop = True
    '            Me.SetEnabledControls()
    '            If (txtInitialTemp.Text = "" Or txtInitialVolQual.Text = "") Then
    '                btnAnalyze.Enabled = False
    '                FormMain.Run_But.Enabled = False
    '                FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '            Else
    '                btnAnalyze.Enabled = True
    '                FormMain.Run_But.Enabled = True
    '                FormMain.AnalyzeToolStripMenuItem.Enabled = True
    '            End If
    '        End If
    '        If (i = 7) Then
    '            txtFillTemp.Text = ""
    '            txtFracFill.Text = ""
    '            calcVQ = False
    '            txtFillTemp.TabStop = False
    '            txtFracFill.TabStop = False
    '            txtInitialVolQual.SelectAll()
    '            txtInitialVolQual.Focus()
    '            Me.SetEnabledControls()
    '            If (txtInitialTemp.Text = "" Or txtInitialVolQual.Text = "") Then
    '                btnAnalyze.Enabled = False
    '                FormMain.Run_But.Enabled = False
    '                FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '            Else
    '                btnAnalyze.Enabled = True
    '                FormMain.Run_But.Enabled = True
    '                FormMain.AnalyzeToolStripMenuItem.Enabled = True
    '            End If


    '        End If
    '    End Sub
    '    Private Sub txtFracFill_Leave(ByVal sender As Object,
    '    ByVal e As System.EventArgs)
    '        Me.CheckTextBox(txtFracFill)
    '        If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
    '            btnDisplay.Enabled = False
    '            FormMain.DisplayResultsToolStripMenuItem.Enabled = False
    '        End If
    '    End Sub
    '    Private Sub txtInitialVolQual_Leave(ByVal sender As Object,
    'ByVal e As System.EventArgs)
    '        Me.CheckTextBox(txtInitialVolQual)
    '        If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
    '            btnDisplay.Enabled = False
    '            FormMain.DisplayResultsToolStripMenuItem.Enabled = False
    '        End If
    '    End Sub

    'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e


    Private Sub CheckTextBox(ByVal ActualControl As TextBox)
        Dim DbNum As Double
        'If (ActualControl.Text = "") Then
        'FormMain.Run_But.Enabled = False
        'btnAnalyze.Enabled = False
        'FormMain.AnalyzeToolStripMenuItem.Enabled = False
        'Me.FlagcontrolsOk = False
        'Exit Sub
        'End If
        If Me.FlagcontrolsOk = False Then
            Exit Sub
        End If
        Try
            DbNum = CDbl(ActualControl.Text)
        Catch ex As InvalidCastException
            MsgBox("Please insert a numeric value. The value must be between 0 and 1 inclusive.")
            Me.FlagcontrolsOk = False
            FormMain.Run_But.Enabled = False
            btnAnalyze.Enabled = False
            FormMain.AnalyzeToolStripMenuItem.Enabled = False
            ActualControl.SelectAll()
            ActualControl.Focus()
            Exit Sub
        End Try
        If DbNum < 0 Or DbNum > 1 Then
            MsgBox("The value must be between 0 and 1 inclusive.")
            Me.FlagcontrolsOk = False
            FormMain.Run_But.Enabled = False
            btnAnalyze.Enabled = False
            FormMain.AnalyzeToolStripMenuItem.Enabled = False
            ActualControl.SelectAll()
            ActualControl.Focus()
            Exit Sub
        End If
        ActualControl.Text = Format(DbNum, "#0.000")

        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
        'If (txtInitialTemp.Text <> "" And txtInitialVolQual.Text <> "") Then
        '    FormMain.Run_But.Enabled = True
        '    btnAnalyze.Enabled = True
        '    FormMain.AnalyzeToolStripMenuItem.Enabled = True
        'Else
        '    FormMain.Run_But.Enabled = False
        '    btnAnalyze.Enabled = False
        '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
        '    Me.FlagcontrolsOk = False
        'End If
        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e

    End Sub

    'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s

    '   Private Sub txtInitialTemp_Leave(ByVal sender As Object,
    'ByVal e As System.EventArgs)
    '       Me.CheckTextBoxTInit(txtInitialTemp)
    '       If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
    '           btnDisplay.Enabled = False
    '           FormMain.DisplayResultsToolStripMenuItem.Enabled = False
    '       End If
    '   End Sub
    '    Private Sub txtNumRecharges_Leave(ByVal sender As Object,
    'ByVal e As System.EventArgs)
    '        Me.CheckNumRecharges(txtNumRecharges)
    '        If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
    '            btnDisplay.Enabled = False
    '            FormMain.DisplayResultsToolStripMenuItem.Enabled = False
    '        End If
    '    End Sub
    'Private Sub txtMassLoss_Leave(ByVal sender As Object, _
    'ByVal e As System.EventArgs) Handles txtMassLoss.Leave
    'Me.CheckMassLoss(txtMassLoss)
    'If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
    'btnDisplay.Enabled = False
    'FormMain.DisplayResultsToolStripMenuItem.Enabled = False
    'End If
    'End Sub

    'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e

    Private Sub CheckMassLoss(ByVal ActualControl As TextBox)
        Dim DbNum As Double
        If (ActualControl.Text = "") Then
            FormMain.Run_But.Enabled = False
            btnAnalyze.Enabled = False
            FormMain.AnalyzeToolStripMenuItem.Enabled = False
            Me.FlagcontrolsOk = False
            Exit Sub
        End If
        Try
            DbNum = CDbl(ActualControl.Text)
        Catch ex As InvalidCastException
            MsgBox("Please insert a numeric value. The value must be between 0 and 100, exclusive of them.")
            FormMain.Run_But.Enabled = False
            btnAnalyze.Enabled = False
            FormMain.AnalyzeToolStripMenuItem.Enabled = False
            Me.FlagcontrolsOk = False
            ActualControl.SelectAll()
            ActualControl.Focus()
            Exit Sub
        End Try
        PercentOfRecharge = CDbl(ActualControl.Text)
        If PercentOfRecharge <= 0 Or PercentOfRecharge >= 100 Then
            MsgBox("The value must be between 0 and 100, exclusive of them")
            FormMain.Run_But.Enabled = False
            btnAnalyze.Enabled = False
            FormMain.AnalyzeToolStripMenuItem.Enabled = False
            Me.FlagcontrolsOk = False
            ActualControl.SelectAll()
            ActualControl.Focus()
            Exit Sub
        End If

        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics 
        'txtMassLoss.Text = Format(PercentOfRecharge, "#0.00")

        '''''''Call VerifyInput()
    End Sub



    'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s

    'Private Sub CheckNumRecharges(ByVal ActualControl As TextBox)
    '    Dim DbNum As Double
    '    If (ActualControl.Text = "") Then
    '        FormMain.Run_But.Enabled = False
    '        btnAnalyze.Enabled = False
    '        FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '        Me.FlagcontrolsOk = False
    '        Exit Sub
    '    End If
    '    Try
    '        DbNum = CDbl(ActualControl.Text)
    '    Catch ex As InvalidCastException
    '        MsgBox("Please insert a numeric value. The value must be an integer value between 1 and 20 inclusive.")
    '        FormMain.Run_But.Enabled = False
    '        FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '        Me.FlagcontrolsOk = False
    '        ActualControl.SelectAll()
    '        ActualControl.Focus()
    '        btnAnalyze.Enabled = False
    '        Exit Sub
    '    End Try
    '    NumberOfRecharges = CInt(ActualControl.Text)
    '    If NumberOfRecharges < 1 Or NumberOfRecharges > 20 Then
    '        MsgBox("The value must be an integer value between 1 and 20 inclusive.")
    '        FormMain.Run_But.Enabled = False
    '        FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '        Me.FlagcontrolsOk = False
    '        ActualControl.SelectAll()
    '        ActualControl.Focus()
    '        btnAnalyze.Enabled = False
    '        Exit Sub
    '    End If
    '    txtNumRecharges.Text = Format(NumberOfRecharges, "#0")
    '    Call VerifyInput()
    'End Sub

    '   Private Sub CheckTextBoxTInit(ByVal ActualControl As TextBox)
    '       Dim DbNum As Double

    '       'YYJ[2020.0318] Judge uppper limit of Init Temp - s
    '       Dim DblCritTemp As Double
    '       DblCritTemp = CDbl(Me.CritTLBL.Text)
    '       'YYJ[2020.0318] Judge uppper limit of Init Temp - e

    '       'YYJ[2020.0316] Unmasking below 'IF' block to handle 'empty input': structure is similar to CheckNumRecharges(*)
    '       If (ActualControl.Text = "") Then
    '           FormMain.Run_But.Enabled = False
    '           btnAnalyze.Enabled = False
    '           FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '           Me.FlagcontrolsOk = False
    '           Exit Sub
    '       End If

    '       'YYJ[2020.0316] Masking below 'IF' block to update initial temp
    '       'If Me.FlagcontrolsOk = False Then
    '       'Exit Sub
    '       'End If

    '       Try
    '           DbNum = CDbl(ActualControl.Text)
    '       Catch ex As InvalidCastException
    '           MsgBox("Please insert a numeric value.")
    '           Me.FlagcontrolsOk = False
    '           FormMain.Run_But.Enabled = False
    '           FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '           ActualControl.SelectAll()
    '           ActualControl.Focus()
    '           btnAnalyze.Enabled = False
    '           Exit Sub
    '       End Try

    '       Select Case BordConditions.Unit
    '           Case "SI with K"
    '               InitialTempK = CDbl(txtInitialTemp.Text)
    '               InitialTempC = TKtoTC(InitialTempK)
    '               InitialTempF = TKtoTE(InitialTempK)
    '               If InitialTempK > DblCritTemp Then 'YYJ[2020.0318] Judge uppper limit of Init Temp ' > 333.15 Then
    '                   MsgBox("The temperature must be less than the critical temperature (" & Me.CritTLBL.Text & " " & lblUnitInitialTemp.Text & ")")
    '                   Me.FlagcontrolsOk = False
    '                   FormMain.Run_But.Enabled = False
    '                   btnAnalyze.Enabled = False
    '                   FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '                   ActualControl.SelectAll()
    '                   ActualControl.Focus()
    '                   Exit Sub
    '               End If

    '               'YYJ[2020.0328] Remove temperatrue restriction for lower bound - s
    '               'If InitialTempK < 233.15 Then
    '               '    MsgBox("The temperature must be greater than 233.15 K.")
    '               '    Me.FlagcontrolsOk = False
    '               '    FormMain.Run_But.Enabled = False
    '               '    btnAnalyze.Enabled = False
    '               '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '               '    ActualControl.SelectAll()
    '               '    ActualControl.Focus()
    '               '    Exit Sub
    '               'End If
    '               'YYJ[2020.0328] Remove temperatrue restriction for lower bound - e

    '               txtInitialTemp.Text = Format(InitialTempK, "#0.00")
    '               If (txtInitialTemp.Text <> "" And txtInitialVolQual.Text <> "") Then
    '                   FormMain.Run_But.Enabled = True
    '                   btnAnalyze.Enabled = True
    '                   FormMain.AnalyzeToolStripMenuItem.Enabled = True
    '               Else
    '                   FormMain.Run_But.Enabled = False
    '                   btnAnalyze.Enabled = False
    '                   Me.FlagcontrolsOk = False
    '                   FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '               End If

    '           Case "SI with °C"
    '               InitialTempC = CDbl(txtInitialTemp.Text)
    '               InitialTempK = TCtoTK(InitialTempC)
    '               InitialTempF = TCtoTE(InitialTempC)

    '               'YYJ[2020.0328] Remove temperatrue restriction for lower bound - s
    '               'If InitialTempC < -40 Then
    '               '    MsgBox("The temperature must be greater than -40 °C.")
    '               '    Me.FlagcontrolsOk = False
    '               '    FormMain.Run_But.Enabled = False
    '               '    btnAnalyze.Enabled = False
    '               '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '               '    ActualControl.SelectAll()
    '               '    ActualControl.Focus()
    '               '    Exit Sub
    '               'End If
    '               'YYJ[2020.0328] Remove temperatrue restriction for lower bound - e

    '               If InitialTempC > DblCritTemp Then 'YYJ[2020.0318] Judge uppper limit of Init Temp ' > 60 then
    '                   MsgBox("The temperature must be less than the critical temperature (" & Me.CritTLBL.Text & " " & lblUnitInitialTemp.Text & ")")
    '                   Me.FlagcontrolsOk = False
    '                   FormMain.Run_But.Enabled = False
    '                   btnAnalyze.Enabled = False
    '                   FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '                   ActualControl.SelectAll()
    '                   ActualControl.Focus()
    '                   Exit Sub
    '               End If
    '               txtInitialTemp.Text = Format(InitialTempC, "#0.00")
    '               If (txtInitialTemp.Text <> "" And txtInitialVolQual.Text <> "") Then
    '                   FormMain.Run_But.Enabled = True
    '                   btnAnalyze.Enabled = True
    '                   FormMain.AnalyzeToolStripMenuItem.Enabled = True
    '               Else
    '                   FormMain.Run_But.Enabled = False
    '                   btnAnalyze.Enabled = False
    '                   FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '                   Me.FlagcontrolsOk = False
    '               End If

    '           Case "I-P Inch-Pound"
    '               InitialTempF = CDbl(txtInitialTemp.Text)
    '               InitialTempC = TEtoTC(InitialTempF)
    '               InitialTempK = TEtoTK(InitialTempF)

    '               'YYJ[2020.0328] Remove temperatrue restriction for lower bound - s
    '               'If InitialTempF < -40 Then
    '               '    MsgBox("The temperature must be greater than -40 °F.")
    '               '    Me.FlagcontrolsOk = False
    '               '    FormMain.Run_But.Enabled = False
    '               '    btnAnalyze.Enabled = False
    '               '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '               '    ActualControl.SelectAll()
    '               '    ActualControl.Focus()
    '               '    Exit Sub
    '               'End If
    '               'YYJ[2020.0328] Remove temperatrue restriction for lower bound - e

    '               If InitialTempF > DblCritTemp Then 'YYJ[2020.0318] Judge uppper limit of Init Temp ' > 140 Then
    '                   MsgBox("The temperature must be less than the critical temperature (" & Me.CritTLBL.Text & " " & lblUnitInitialTemp.Text & ")")
    '                   Me.FlagcontrolsOk = False
    '                   FormMain.Run_But.Enabled = False
    '                   btnAnalyze.Enabled = False
    '                   FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '                   ActualControl.SelectAll()
    '                   ActualControl.Focus()
    '                   Exit Sub
    '               End If
    '               txtInitialTemp.Text = Format(InitialTempF, "#0.00")
    '               If (txtInitialTemp.Text <> "" And txtInitialVolQual.Text <> "") Then
    '                   FormMain.Run_But.Enabled = True
    '                   btnAnalyze.Enabled = True
    '                   FormMain.AnalyzeToolStripMenuItem.Enabled = True
    '               Else
    '                   FormMain.Run_But.Enabled = False
    '                   btnAnalyze.Enabled = False
    '                   FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '                   Me.FlagcontrolsOk = False
    '               End If

    '           Case Else
    '               InitialTempK = CDbl(txtInitialTemp.Text)
    '               InitialTempC = TKtoTC(InitialTempK)
    '               InitialTempF = TKtoTE(InitialTempK)

    '               'YYJ[2020.0328] Remove temperatrue restriction for lower bound - s
    '               'If InitialTempK < 233.15 Then
    '               '    MsgBox("The temperature must be greater than 233.15 K.")
    '               '    Me.FlagcontrolsOk = False
    '               '    FormMain.Run_But.Enabled = False
    '               '    btnAnalyze.Enabled = False
    '               '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '               '    ActualControl.SelectAll()
    '               '    ActualControl.Focus()
    '               '    Exit Sub
    '               'End If
    '               'YYJ[2020.0328] Remove temperatrue restriction for lower bound - s

    '               txtInitialTemp.Text = Format(InitialTempK, "#0.00")
    '               If (txtInitialTemp.Text <> "" And txtInitialVolQual.Text <> "") Then
    '                   FormMain.Run_But.Enabled = True
    '                   btnAnalyze.Enabled = True
    '                   FormMain.AnalyzeToolStripMenuItem.Enabled = True
    '               Else
    '                   FormMain.Run_But.Enabled = False
    '                   btnAnalyze.Enabled = False
    '                   FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '                   Me.FlagcontrolsOk = False
    '               End If
    '       End Select
    '   End Sub
    '   Private Sub txtfilltemp_Leave(ByVal sender As Object,
    'ByVal e As System.EventArgs)
    '       Me.CheckTextBoxTFill(txtFillTemp)
    '       If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
    '           btnDisplay.Enabled = False
    '           FormMain.DisplayResultsToolStripMenuItem.Enabled = False
    '       End If
    '   End Sub

    '   Private Sub CheckTextBoxTFill(ByVal ActualControl As TextBox)
    '       Dim DbNum As Double
    '       'YYJ[2020.0328] Judge uppper limit of Fill Temp - s
    '       Dim DblCritTemp As Double
    '       DblCritTemp = CDbl(Me.CritTLBL.Text)
    '       'YYJ[2020.0328] Judge uppper limit of Fill Temp - e
    '       'If (ActualControl.Text = "") Then
    '       'Exit Sub
    '       'End If
    '       ''''''''''''''''''''''''''If Me.FlagcontrolsOk = False Then
    '       ''''''''''''''''''''''''''Exit Sub
    '       ''''''''''''''''''''''''''End If
    '       Try
    '           DbNum = CDbl(ActualControl.Text)
    '       Catch ex As InvalidCastException
    '           MsgBox("Please insert a numeric value.")
    '           FormMain.Run_But.Enabled = False
    '           btnAnalyze.Enabled = False
    '           FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '           Me.FlagcontrolsOk = False
    '           ActualControl.SelectAll()
    '           ActualControl.Focus()
    '           Exit Sub
    '       End Try

    '       Select Case BordConditions.Unit
    '           Case "SI with K"
    '               FillTempK = CDbl(txtFillTemp.Text)
    '               FillTempC = TKtoTC(FillTempK)
    '               FillTempF = TKtoTE(FillTempK)

    '               If FillTempK > DblCritTemp Then 'YYJ[2020.0328] Judge uppper limit of Fill Temp ' > 333.15 Then
    '                   MsgBox("The temperature must be less than the critical temperature (" & Me.CritTLBL.Text & " " & lblUnitInitialTemp.Text & ")")
    '                   FormMain.Run_But.Enabled = False
    '                   btnAnalyze.Enabled = False
    '                   FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '                   Me.FlagcontrolsOk = False
    '                   ActualControl.SelectAll()
    '                   ActualControl.Focus()
    '                   Exit Sub
    '               End If

    '               'YYJ[2020.0328] Remove temperatrue restriction for lower bound - s
    '               'If FillTempK < 233.15 Then
    '               '    MsgBox("The temperature must be greater than 233.15 K.")
    '               '    FormMain.Run_But.Enabled = False
    '               '    btnAnalyze.Enabled = False
    '               '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '               '    Me.FlagcontrolsOk = False
    '               '    ActualControl.SelectAll()
    '               '    ActualControl.Focus()
    '               '    Exit Sub
    '               'End If
    '               'YYJ[2020.0328] Remove temperatrue restriction for lower bound - e

    '               txtFillTemp.Text = Format(FillTempK, "#0.00")

    '           Case "SI with °C"
    '               FillTempC = CDbl(txtFillTemp.Text)
    '               FillTempK = TCtoTK(FillTempC)
    '               FillTempF = TCtoTE(FillTempC)

    '               'YYJ[2020.0328] Remove temperatrue restriction for lower bound - s
    '               'If FillTempC < -40 Then
    '               '    MsgBox("The temperature must be greater than -40 °C.")
    '               '    FormMain.Run_But.Enabled = False
    '               '    btnAnalyze.Enabled = False
    '               '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '               '    Me.FlagcontrolsOk = False
    '               '    ActualControl.SelectAll()
    '               '    ActualControl.Focus()
    '               '    Exit Sub
    '               'End If
    '               'YYJ[2020.0328] Remove temperatrue restriction for lower bound - e

    '               If FillTempC > DblCritTemp Then 'YYJ[2020.0328] Judge uppper limit of Fill Temp ' > 60 Then
    '                   MsgBox("The temperature must be less than the critical temperature (" & Me.CritTLBL.Text & " " & lblUnitInitialTemp.Text & ")")
    '                   FormMain.Run_But.Enabled = False
    '                   btnAnalyze.Enabled = False
    '                   FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '                   Me.FlagcontrolsOk = False
    '                   ActualControl.SelectAll()
    '                   ActualControl.Focus()
    '                   Exit Sub
    '               End If
    '               txtFillTemp.Text = Format(FillTempC, "#0.00")

    '           Case "I-P Inch-Pound"
    '               FillTempF = CDbl(txtFillTemp.Text)
    '               FillTempC = TEtoTC(FillTempF)
    '               FillTempK = TEtoTK(FillTempF)

    '               'YYJ[2020.0328] Remove temperatrue restriction for lower bound - s
    '               'If FillTempF < -40 Then
    '               '    MsgBox("The temperature must be greater than -40 °F.")
    '               '    FormMain.Run_But.Enabled = False
    '               '    btnAnalyze.Enabled = False
    '               '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '               '    Me.FlagcontrolsOk = False
    '               '    ActualControl.SelectAll()
    '               '    ActualControl.Focus()
    '               '    Exit Sub
    '               'End If
    '               'YYJ[2020.0328] Remove temperatrue restriction for lower bound - e

    '               If FillTempF > DblCritTemp Then 'YYJ[2020.0328] Judge uppper limit of Fill Temp ' > 140 Then
    '                   MsgBox("The temperature must be less than the critical temperature (" & Me.CritTLBL.Text & " " & lblUnitInitialTemp.Text & ")")
    '                   FormMain.Run_But.Enabled = False
    '                   btnAnalyze.Enabled = False
    '                   FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '                   Me.FlagcontrolsOk = False
    '                   ActualControl.SelectAll()
    '                   ActualControl.Focus()
    '                   Exit Sub
    '               End If
    '               txtFillTemp.Text = Format(FillTempF, "#0.00")

    '           Case Else
    '               FillTempK = CDbl(txtFillTemp.Text)
    '               FillTempC = TKtoTC(FillTempK)
    '               FillTempF = TKtoTE(FillTempK)

    '               'YYJ[2020.0328] Remove temperatrue restriction for lower bound - s
    '               'If FillTempK < 233.15 Then
    '               '    MsgBox("The temperature must be greater than 233.15 K.")
    '               '    FormMain.Run_But.Enabled = False
    '               '    btnAnalyze.Enabled = False
    '               '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '               '    Me.FlagcontrolsOk = False
    '               '    ActualControl.SelectAll()
    '               '    ActualControl.Focus()
    '               '    Exit Sub
    '               'End If
    '               'YYJ[2020.0328] Remove temperatrue restriction for lower bound - e

    '               txtFillTemp.Text = Format(FillTempK, "#0.00")
    '               FormMain.Run_But.Enabled = True
    '               btnAnalyze.Enabled = True
    '               FormMain.AnalyzeToolStripMenuItem.Enabled = True
    '               Me.FlagcontrolsOk = True
    '               Call VerifyInput()
    '       End Select
    '   End Sub

    'Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Const MaxComps As Integer = 20
    '    Dim ierr As Integer
    '    Dim herr(254) As Char
    '    Dim PBUB As Double, RHOBL As Double, RHOBV As Double
    '    Dim XBL(MaxComps - 1) As Double, XBV(MaxComps - 1) As Double
    '    Dim fract As Double
    '    Dim Ro As Double
    '    Dim Pleak As Double, DlLeak As Double, DvLeak As Double, QLeak As Double
    '    Dim Ujunk As Double, Hjunk As Double, Sjunk As Double, cvjunk As Double, cpjunk As Double, Wjunk As Double
    '    Dim Vliq As Double, Vvap As Double, Vq As Double
    '    Dim XI(MaxComps - 1) As Double
    '    Dim ncomps As Integer, i As Integer
    '    Dim t0ref, h0ref, x0ref(MaxComps - 1), s0ref, p0ref As Double
    '    Dim hfmix(254) As Char
    '    Dim hrf(3) As Char
    '    Dim hfld(10000 - 1) As Char

    '    System.IO.Directory.SetCurrentDirectory(ApplicationFolder)

    '    Dim FS As String
    '    FS = "|fluids\" 'YYJ[2020.0305] specify full path string

    '    With PureFld_Mix_FeatureLocalInst.MixtureFeature
    '        If .nc = 2 Then
    '            hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & "|", Char())
    '        ElseIf .nc = 3 Then
    '            hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & "|", Char())
    '        ElseIf .nc = 4 Then
    '            hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & "|", Char())
    '        ElseIf .nc = 5 Then
    '            hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & "|", Char())
    '        ElseIf .nc = 6 Then
    '            hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & FS & .comp(5) & "|", Char())
    '        ElseIf .nc = 7 Then
    '            hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & FS & .comp(5) & FS & .comp(6) & "|", Char())
    '        ElseIf .nc = 8 Then
    '            hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & FS & .comp(5) & FS & .comp(6) & FS & .comp(7) & "|", Char())
    '        ElseIf .nc = 9 Then
    '            hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & FS & .comp(5) & FS & .comp(6) & FS & .comp(7) & FS & .comp(8) & "|", Char())
    '        ElseIf .nc = 10 Then
    '            hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & FS & .comp(5) & FS & .comp(6) & FS & .comp(7) & FS & .comp(8) & FS & .comp(9) & "|", Char())
    '        End If

    '        ReDim Preserve hfld(10000 - 1)

    '        Try
    '            Array.ConstrainedCopy(CType("fluids\hmx.bnc", Char()), 0, hfmix, 0, "fluids\hmx.bnc".Length)
    '            hrf = CType("DEF", Char())
    '            ncomps = PureFld_Mix_FeatureLocalInst.MixtureFeature.nc
    '            For i = 0 To ncomps - 1
    '                XI(i) = PureFld_Mix_FeatureLocalInst.MixtureFeature.X(i)
    '                x0ref(i) = PureFld_Mix_FeatureLocalInst.MixtureFeature.X(i)
    '            Next

    '            'YYJ[2020.0305] I/F with Wrapper - s
    '            Dim hFldSTR, hFmixSTR, hRfSTR, hErrSTR As String
    '            Dim nFld_len, nFmix_len, nRf_len, nErr_len As Integer

    '            hFldSTR = CStr(hfld)

    '            hFmixSTR = CStr(hfmix)
    '            hFmixSTR += Space(255 - hFmixSTR.Length())

    '            hRfSTR = CStr(hrf)

    '            hErrSTR = Space(255)
    '            nFld_len = hFldSTR.Length()
    '            nFmix_len = hFmixSTR.Length()
    '            nRf_len = hRfSTR.Length()
    '            nErr_len = hErrSTR.Length()
    '            Call SETUP0(.nc, hFldSTR, hFmixSTR, hRfSTR, ierr, hErrSTR, nFld_len, nFmix_len, nRf_len, nErr_len)

    '            If (.nc > 1) Then
    '                Call SETREF_dll(hRfSTR, 2, x0ref(0), h0ref, s0ref, t0ref, p0ref, ierr, hErrSTR, nRf_len, nErr_len)
    '            End If

    '            fract = CDbl(Me.txtFracFill.Text)

    '            '---Calcualte the reference liq. density
    '            Call SATT_dll(FillTempK, XI(0), 1&, PBUB, RHOBL, RHOBV, XBL(0), XBV(0), ierr, hErrSTR, nErr_len)
    '            'Wrap it!
    '            'Call SATT_dll(FillTempK, XI(0), 1&, PBUB, RHOBL, RHOBV, XBL(0), XBV(0), ierr, herr)

    '            Ro = fract * RHOBL

    '            '---Calc. the state pt. defined by initial leak temperature and Ro
    '            Call TDFLSH_DLL(InitialTempK, Ro, XI(0), Pleak, DlLeak, DvLeak, XBL(0), XBV(0), QLeak, Ujunk, Hjunk, Sjunk, cvjunk, cpjunk, Wjunk,
    '                            ierr, hErrSTR, nErr_len)
    '            'Wrap it!
    '            'Call TDFLSH_DLL(InitialTempK, Ro, XI(0), Pleak, DlLeak, DvLeak, XBL(0), XBV(0), QLeak, Ujunk, Hjunk, Sjunk, cvjunk, cpjunk, Wjunk, _

    '            'YYJ[2020.0305] I/F with Wrapper - e

    '            QLeak = (1 / Ro - 1 / DlLeak) / (1 / DvLeak - 1 / DlLeak)


    '            '---Calc. volumetric quality at the initial temp. Tleak
    '            Vliq = (1.0 - QLeak) / DlLeak
    '            Vvap = QLeak / DvLeak
    '            '---Volumetric quality
    '            Vq = Vvap / (Vvap + Vliq)

    '            If (Vq > 1 Or Vq < 0) Then
    '                MsgBox("The input parameters for the Optional Calculation of Initial Volumetric Quality result in an unrealistic value. Please try again.")
    '                Exit Sub
    '            End If

    '            txtInitialVolQual.Text = Format(Vq, "#0.000")
    '            txtFillTemp.Text = ""
    '            txtFracFill.Text = ""


    '        Catch ex As Exception
    '            MsgBox("An exception occurred, please restart the program and try again.")
    '        End Try
    '    End With


    '    btnCalculate.Enabled = False
    '    btnAnalyze.Enabled = True
    '    FormMain.Run_But.Enabled = True
    '    FormMain.AnalyzeToolStripMenuItem.Enabled = False
    'End Sub





    'Private Sub rbAdiabatic_CheckedChanged(sender As Object, e As EventArgs)
    '    If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
    '        btnDisplay.Enabled = False
    '        FormMain.DisplayResultsToolStripMenuItem.Enabled = False
    '    End If

    '    'YYJ[2020.0312] Inactive ribbon 'Leak and Recharge Process' when 'fast leak' is selected
    '    If Me.rbLeakandRecharge.Enabled = True Then
    '        Me.txtNumRecharges.Text = ""
    '        Me.txtMassLoss.Text = ""
    '        Me.rbLeakandRecharge.Enabled = False
    '        Me.rbLeakOnly.Checked = True
    '    End If

    '    'YYJ[2020.0312] Inactive group 'Recharge Process' when 'fast leak' is selected
    '    If Me.frmRechargeProcess.Enabled = True Then
    '        Me.frmRechargeProcess.Enabled = False
    '    End If

    'End Sub

    'Private Sub rbIsothermal_CheckedChanged(sender As Object, e As EventArgs)
    '    If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
    '        btnDisplay.Enabled = False
    '        FormMain.DisplayResultsToolStripMenuItem.Enabled = False
    '    End If

    '    'YYJ[2020.0312] Re-active ribbon 'Leak and Recharge Process' when 'slow leak' is selected
    '    If Me.rbLeakandRecharge.Enabled = False Then
    '        Me.rbLeakandRecharge.Enabled = True
    '    End If

    '    'YYJ[2020.0320] Pre-requisitive added: group 'Recharge Process' has meaningful when 'Leak and Recharge Process' is selected
    '    'YYJ[2020.0312] Re-active group 'Recharge Process' when 'fast leak' is selected
    '    If Me.rbLeakandRecharge.Checked = True Then
    '        If Me.frmRechargeProcess.Enabled = False Then
    '            Me.frmRechargeProcess.Enabled = True
    '        End If
    '    Else
    '        'do nothing
    '    End If

    'End Sub

    'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e

    Private Sub rbVapor_CheckedChanged(sender As Object, e As EventArgs)
        If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
            btnDisplay.Enabled = False
            FormMain.DisplayResultsToolStripMenuItem.Enabled = False
        End If

    End Sub

    Private Sub rbLiquid_CheckedChanged(sender As Object, e As EventArgs)
        If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
            btnDisplay.Enabled = False
            FormMain.DisplayResultsToolStripMenuItem.Enabled = False
        End If

    End Sub

    Shared Sub btnDisplay_Click()
        Throw New NotImplementedException
    End Sub

    Private Sub chkVapor_CheckedChanged(sender As Object, e As EventArgs) Handles chkVapor.CheckedChanged
        If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
            btnDisplay.Enabled = False
            FormMain.DisplayResultsToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub chkLiquid_CheckedChanged(sender As Object, e As EventArgs) Handles chkLiquid.CheckedChanged
        If btnDisplay.Enabled = True Or FormMain.DisplayResultsToolStripMenuItem.Enabled = True Then
            btnDisplay.Enabled = False
            FormMain.DisplayResultsToolStripMenuItem.Enabled = False
        End If
    End Sub

    'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
    'Private Sub txtInitialVolQual_TextChanged(sender As Object, e As EventArgs)
    '    If fill = True Then
    '        fill = False
    '        Exit Sub
    '    End If
    '    txtFillTemp.Text = ""
    '    txtFracFill.Text = ""
    '    btnCalculate.Enabled = False
    '    If rbLeakandRecharge.Checked = False Then
    '        If txtInitialTemp.Text IsNot Nothing And txtInitialVolQual.Text IsNot Nothing Then
    '            FormMain.Run_But.Enabled = True
    '            btnAnalyze.Enabled = True
    '            FormMain.AnalyzeToolStripMenuItem.Enabled = True
    '        Else
    '            FormMain.Run_But.Enabled = False
    '            btnAnalyze.Enabled = False
    '            FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '        End If
    '    Else
    '        If (txtMassLoss.Text IsNot Nothing And txtNumRecharges.Text IsNot Nothing) Then
    '            FormMain.Run_But.Enabled = True
    '            btnAnalyze.Enabled = True
    '            FormMain.AnalyzeToolStripMenuItem.Enabled = True
    '        Else
    '            FormMain.Run_But.Enabled = False
    '            btnAnalyze.Enabled = False
    '            FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '        End If
    '    End If

    'End Sub

    'Private Sub txtInitialTemp_TextChanged(sender As Object, e As EventArgs)
    '    If rbLeakandRecharge.Checked = False Then
    '        If txtInitialTemp.Text Is Nothing And txtInitialVolQual.Text Is Nothing Then
    '            FormMain.Run_But.Enabled = False
    '            btnAnalyze.Enabled = False
    '            FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '        Else
    '            FormMain.Run_But.Enabled = True
    '            btnAnalyze.Enabled = True
    '            FormMain.AnalyzeToolStripMenuItem.Enabled = True
    '        End If
    '    Else
    '        If txtMassLoss.Text Is Nothing And txtNumRecharges.Text Is Nothing Then
    '            FormMain.Run_But.Enabled = False
    '            btnAnalyze.Enabled = False
    '            FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '        Else
    '            FormMain.Run_But.Enabled = True
    '            btnAnalyze.Enabled = True
    '            FormMain.AnalyzeToolStripMenuItem.Enabled = True
    '        End If
    '    End If

    'End Sub

    'Private Sub txtNumRecharges_TextChanged(sender As Object, e As EventArgs)
    '    Dim DbNum As Double
    '    If rbLeakandRecharge.Checked = False Then
    '        Exit Sub
    '    End If
    '    If txtMassLoss.Text Is Nothing Or txtNumRecharges.Text Is Nothing Then
    '        FormMain.Run_But.Enabled = False
    '        btnAnalyze.Enabled = False
    '        FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '    Else
    '        FormMain.Run_But.Enabled = True
    '        btnAnalyze.Enabled = True
    '        FormMain.AnalyzeToolStripMenuItem.Enabled = True
    '    End If
    '    Try
    '        DbNum = CDbl(txtNumRecharges.Text)
    '    Catch ex As InvalidCastException
    '        FormMain.Run_But.Enabled = False
    '        btnAnalyze.Enabled = False
    '        FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '        Me.FlagcontrolsOk = False
    '        Exit Sub
    '    End Try
    '    Try
    '        DbNum = CDbl(txtMassLoss.Text)
    '    Catch ex As InvalidCastException
    '        FormMain.Run_But.Enabled = False
    '        btnAnalyze.Enabled = False
    '        FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '        Me.FlagcontrolsOk = False
    '        Exit Sub
    '    End Try
    'End Sub

    'Private Sub txtMassLoss_TextChanged(sender As Object, e As EventArgs)
    '    Dim DbNum As Double
    '    If rbLeakandRecharge.Checked = False Then
    '        Exit Sub
    '    End If
    '    If txtMassLoss.Text Is Nothing Or txtNumRecharges.Text Is Nothing Then
    '        FormMain.Run_But.Enabled = False
    '        btnAnalyze.Enabled = False
    '        FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '    Else
    '        FormMain.Run_But.Enabled = True
    '        btnAnalyze.Enabled = True
    '        FormMain.AnalyzeToolStripMenuItem.Enabled = True
    '    End If
    '    Try
    '        DbNum = CDbl(txtNumRecharges.Text)
    '    Catch ex As InvalidCastException
    '        FormMain.Run_But.Enabled = False
    '        btnAnalyze.Enabled = False
    '        FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '        Me.FlagcontrolsOk = False
    '        Exit Sub
    '    End Try
    '    Try
    '        DbNum = CDbl(txtMassLoss.Text)
    '    Catch ex As InvalidCastException
    '        FormMain.Run_But.Enabled = False
    '        btnAnalyze.Enabled = False
    '        FormMain.AnalyzeToolStripMenuItem.Enabled = False
    '        Me.FlagcontrolsOk = False
    '        Exit Sub
    '    End Try
    'End Sub
    'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e
End Class