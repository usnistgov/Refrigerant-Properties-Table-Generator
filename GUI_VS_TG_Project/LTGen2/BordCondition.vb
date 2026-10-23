Imports System.IO

Public Class BordConditionFormInputClass               'Bord Conditions for each FormInput
    Private varTypeRefrigerant As Integer               '0: Pure; 1: Predefined; 2: UserDefinedMixture
    Private varSelectedIndex As Integer
    'PURE FLUID 0:NameFluidoCode; 1:NameFluidoUser; 2:NameFluidoFile  'MIX. '0:NameMixture; 1:NameMixtureUser; 2:MixtureStored
    Private varSelectedFluidName(2) As String
    Public varMixtureFeatureinstance As New MixtureFeatureClass
    Public varPureFluidFeatureinstance As New PureFluidFeatureClass
    Private varVaporLiquidDisplayResults As Integer                '0: both,1:Vapor,2:Liquid
    'Single Stage
    Private varLeakType As Integer          '0: isothermal,         1:Adiabatic
    Private varLeakingPhase As Integer      '0: Vapor Phase,        1:Liquid Phase
    Private varSimulation As Integer        '0: Leak Process Only,  1:Leak and Recharge Process
    Private varNumberOfRecharge As Integer
    Private varPercentMassLossForRecharging As Double
    Private varInletTemperature As Double
    Private varIntialVolumetricQuality As Double
    Private varFillTemperature As Double
    Private varFractionOfMaximumLiquidFill As Double

    Private varLTG_HPlimit As Integer
    Private varLTG_LPlimit As Integer
    Private varLTG_Pnum As Integer
    Private varLTG_Hnum As Integer
    Private varLTG_LINscl As Integer
    Private varLTG_LOGscl As Integer
    Public Property LTG_HPlimit() As Integer
        Get
            Return varLTG_HPlimit
        End Get
        Set(value As Integer)
            varLTG_HPlimit = value
        End Set
    End Property
    Public Property LTG_LPlimit() As Integer
        Get
            Return varLTG_LPlimit
        End Get
        Set(value As Integer)
            varLTG_LPlimit = value
        End Set
    End Property
    Public Property LTG_Pnum() As Integer
        Get
            Return varLTG_Pnum
        End Get
        Set(value As Integer)
            varLTG_Pnum = value
        End Set
    End Property
    Public Property LTG_Hnum() As Integer
        Get
            Return varLTG_Hnum
        End Get
        Set(value As Integer)
            varLTG_Hnum = value
        End Set
    End Property
    Public Property LTG_LINscl() As Integer
        Get
            Return varLTG_LINscl
        End Get
        Set(value As Integer)
            varLTG_LINscl = value
        End Set
    End Property
    Public Property LTG_LOGscl() As Integer
        Get
            Return varLTG_LOGscl
        End Get
        Set(value As Integer)
            varLTG_LOGscl = value
        End Set
    End Property

    Public Property TypeRefrigerant() As Integer
        Get
            Return varTypeRefrigerant
        End Get
        Set(ByVal value As Integer)
            varTypeRefrigerant = value
        End Set
    End Property
    Public Property SelectedIndex() As Integer
        Get
            Return varSelectedIndex
        End Get
        Set(ByVal value As Integer)
            varSelectedIndex = value
        End Set
    End Property
    Public Property SelectedFluidName() As String()
        Get
            Return varSelectedFluidName
        End Get
        Set(ByVal value As String())
            varSelectedFluidName = value
        End Set
    End Property
    Public Property MixtureFeatureinstance() As MixtureFeatureClass
        Get
            Return varMixtureFeatureinstance
        End Get
        Set(ByVal value As MixtureFeatureClass)
            varMixtureFeatureinstance = value
        End Set
    End Property
    Public Property PureFluidFeatureinstance() As PureFluidFeatureClass
        Get
            Return varPureFluidFeatureinstance
        End Get
        Set(ByVal value As PureFluidFeatureClass)
            varPureFluidFeatureinstance = value
        End Set
    End Property
    Public Property VaporLiquidDisplayResults() As Integer
        Get
            Return varVaporLiquidDisplayResults
        End Get
        Set(ByVal value As Integer)
            varVaporLiquidDisplayResults = value
        End Set
    End Property
    Public Property LeakType() As Integer
        Get
            Return varLeakType
        End Get
        Set(ByVal value As Integer)
            varLeakType = value
        End Set
    End Property
    Public Property LeakingPhase() As Integer
        Get
            Return varLeakingPhase
        End Get
        Set(ByVal value As Integer)
            varLeakingPhase = value
        End Set
    End Property
    Public Property Simulation() As Integer
        Get
            Return varSimulation
        End Get
        Set(ByVal value As Integer)
            varSimulation = value
        End Set
    End Property
    Public Property NumberOfRecharge() As Integer
        Get
            Return varNumberOfRecharge
        End Get
        Set(ByVal value As Integer)
            varNumberOfRecharge = value
        End Set
    End Property
    Public Property PercentMassLossForRecharging() As Double
        Get
            Return varPercentMassLossForRecharging
        End Get
        Set(ByVal value As Double)
            varPercentMassLossForRecharging = value
        End Set
    End Property
    Public Property InletTemperature() As Double
        Get
            Return varInletTemperature
        End Get
        Set(ByVal value As Double)
            varInletTemperature = value
        End Set
    End Property
    Public Property IntialVolumetricQuality() As Double
        Get
            Return varIntialVolumetricQuality
        End Get
        Set(ByVal value As Double)
            varIntialVolumetricQuality = value
        End Set
    End Property
    Public Property FillTemperature() As Double
        Get
            Return varFillTemperature
        End Get
        Set(ByVal value As Double)
            varFillTemperature = value
        End Set
    End Property
    Public Property FractionOfMaximumLiquidFill() As Double
        Get
            Return varFractionOfMaximumLiquidFill
        End Get
        Set(ByVal value As Double)
            varFractionOfMaximumLiquidFill = value
        End Set
    End Property

    'Save the Input File
     Friend Sub SaveFile(ByVal Address As String)
        Dim DataSetInputSave As New DataSet
        Dim RowDummy As DataRow
        BordConditions.ReadClassPreferencesToSaveIntoAFile()
        DataSetInputSave.Tables.Add(DataTableVersion.Copy)
        DataSetInputSave.Tables.Add(BordConditions.TabToSave.Copy)
        DataSetInputSave.Tables.Add("RefMix")
        DataSetInputSave.Tables.Add("LTGInput")  '~ .Add("RefleakInput")
        'This Table contains as many rows as the mixture components 
        DataSetInputSave.Tables("RefMix").Columns.Add("TypeRefrigerant", System.Type.GetType("System.Int32"))
        DataSetInputSave.Tables("RefMix").Columns.Add("SelectedIndex", System.Type.GetType("System.Int32"))
        DataSetInputSave.Tables("RefMix").Columns.Add("SelectedFluidIndex_0", System.Type.GetType("System.String"))
        DataSetInputSave.Tables("RefMix").Columns.Add("SelectedFluidIndex_1", System.Type.GetType("System.String"))
        DataSetInputSave.Tables("RefMix").Columns.Add("SelectedFluidIndex_2", System.Type.GetType("System.String"))
        DataSetInputSave.Tables("RefMix").Columns.Add("fluid", System.Type.GetType("System.String"))
        DataSetInputSave.Tables("RefMix").Columns.Add("cas", System.Type.GetType("System.String"))
        DataSetInputSave.Tables("RefMix").Columns.Add("fullname", System.Type.GetType("System.String"))
        DataSetInputSave.Tables("RefMix").Columns.Add("chemname", System.Type.GetType("System.String"))

        DataSetInputSave.Tables("RefMix").Columns.Add("FileName", System.Type.GetType("System.String"))
        DataSetInputSave.Tables("RefMix").Columns.Add("ShortName", System.Type.GetType("System.String")) 'YYJ[2020.0704]ltgen2: Handling ShortName

        DataSetInputSave.Tables("RefMix").Columns.Add("junk", System.Type.GetType("System.String"))
        DataSetInputSave.Tables("RefMix").Columns.Add("wmstring", System.Type.GetType("System.String"))
        DataSetInputSave.Tables("RefMix").Columns.Add("wm", System.Type.GetType("System.Double"))
        DataSetInputSave.Tables("RefMix").Columns.Add("tnbptstring", System.Type.GetType("System.String"))
        DataSetInputSave.Tables("RefMix").Columns.Add("tnbpt", System.Type.GetType("System.Double"))
        DataSetInputSave.Tables("RefMix").Columns.Add("tcstring", System.Type.GetType("System.String"))
        DataSetInputSave.Tables("RefMix").Columns.Add("tc", System.Type.GetType("System.Double"))
        DataSetInputSave.Tables("RefMix").Columns.Add("pcstring", System.Type.GetType("System.String"))
        DataSetInputSave.Tables("RefMix").Columns.Add("pc", System.Type.GetType("System.Double"))
        DataSetInputSave.Tables("RefMix").Columns.Add("dcstring", System.Type.GetType("System.String"))
        DataSetInputSave.Tables("RefMix").Columns.Add("dc", System.Type.GetType("System.Double"))
        DataSetInputSave.Tables("RefMix").Columns.Add("acfstring", System.Type.GetType("System.String"))
        DataSetInputSave.Tables("RefMix").Columns.Add("acf", System.Type.GetType("System.Double"))
        DataSetInputSave.Tables("RefMix").Columns.Add("nc", System.Type.GetType("System.Int32"))
        'Only mixture properties
        DataSetInputSave.Tables("RefMix").Columns.Add("comp", System.Type.GetType("System.String"))
        DataSetInputSave.Tables("RefMix").Columns.Add("X", System.Type.GetType("System.Double"))
        DataSetInputSave.Tables("RefMix").Columns.Add("WmElements", System.Type.GetType("System.Double"))
        If Me.TypeRefrigerant = 0 Then
            RowDummy = DataSetInputSave.Tables("RefMix").NewRow
            RowDummy.Item("TypeRefrigerant") = Me.TypeRefrigerant
            RowDummy.Item("SelectedIndex") = Me.SelectedIndex
            RowDummy.Item("SelectedFluidIndex_0") = Me.SelectedFluidName(0)
            RowDummy.Item("SelectedFluidIndex_1") = Me.SelectedFluidName(1)
            RowDummy.Item("SelectedFluidIndex_2") = Me.SelectedFluidName(2)
            RowDummy.Item("fluid") = Me.PureFluidFeatureinstance.FluidFeature.fluid
            RowDummy.Item("cas") = Me.PureFluidFeatureinstance.FluidFeature.cas
            RowDummy.Item("fullname") = Me.PureFluidFeatureinstance.FluidFeature.fullname
            RowDummy.Item("chemname") = Me.PureFluidFeatureinstance.FluidFeature.chemname

            RowDummy.Item("FileName") = Me.PureFluidFeatureinstance.FluidFeature.FileName
            RowDummy.Item("ShortName") = Me.PureFluidFeatureinstance.FluidFeature.ShortName 'YYJ[2020.0704]ltgen2: Write ShortName from XML

            RowDummy.Item("junk") = Me.PureFluidFeatureinstance.FluidFeature.junk
            RowDummy.Item("wmstring") = Me.PureFluidFeatureinstance.FluidFeature.wmstring
            RowDummy.Item("wm") = Me.PureFluidFeatureinstance.FluidFeature.wm
            RowDummy.Item("tnbptstring") = Me.PureFluidFeatureinstance.FluidFeature.tnbptstring
            RowDummy.Item("tnbpt") = Me.PureFluidFeatureinstance.FluidFeature.tnbpt
            RowDummy.Item("tcstring") = Me.PureFluidFeatureinstance.FluidFeature.tcstring
            RowDummy.Item("tc") = Me.PureFluidFeatureinstance.FluidFeature.tc
            RowDummy.Item("pcstring") = Me.PureFluidFeatureinstance.FluidFeature.pcstring
            RowDummy.Item("pc") = Me.PureFluidFeatureinstance.FluidFeature.pc
            RowDummy.Item("dcstring") = Me.PureFluidFeatureinstance.FluidFeature.dcstring
            RowDummy.Item("dc") = Me.PureFluidFeatureinstance.FluidFeature.dc
            RowDummy.Item("acfstring") = Me.PureFluidFeatureinstance.FluidFeature.acfstring
            RowDummy.Item("acf") = Me.PureFluidFeatureinstance.FluidFeature.acf
            RowDummy.Item("nc") = Me.PureFluidFeatureinstance.FluidFeature.nc
            DataSetInputSave.Tables("RefMix").Rows.Add(RowDummy)
        ElseIf Me.TypeRefrigerant = 1 Or Me.TypeRefrigerant = 2 Then
            RowDummy = DataSetInputSave.Tables("RefMix").NewRow
            RowDummy.Item("TypeRefrigerant") = Me.TypeRefrigerant
            RowDummy.Item("SelectedIndex") = Me.SelectedIndex
            RowDummy.Item("SelectedFluidIndex_0") = Me.SelectedFluidName(0)
            RowDummy.Item("SelectedFluidIndex_1") = Me.SelectedFluidName(1)
            RowDummy.Item("SelectedFluidIndex_2") = Me.SelectedFluidName(2)
            RowDummy.Item("fluid") = Me.MixtureFeatureinstance.MixtureFeature.fluid
            RowDummy.Item("cas") = Me.MixtureFeatureinstance.MixtureFeature.cas
            RowDummy.Item("fullname") = Me.MixtureFeatureinstance.MixtureFeature.fullname
            RowDummy.Item("chemname") = Me.MixtureFeatureinstance.MixtureFeature.chemname

            RowDummy.Item("FileName") = Me.MixtureFeatureinstance.MixtureFeature.FileName
            RowDummy.Item("ShortName") = Me.MixtureFeatureinstance.MixtureFeature.FileName 'YYJ[2020.0704]ltgen2: 'YYJ[2020.0702] For mixture fluid, regarding ShortName as its FileName

            RowDummy.Item("junk") = Me.MixtureFeatureinstance.MixtureFeature.junk
            RowDummy.Item("wmstring") = Me.MixtureFeatureinstance.MixtureFeature.wmstring
            RowDummy.Item("wm") = Me.MixtureFeatureinstance.MixtureFeature.wm
            RowDummy.Item("tnbptstring") = Me.MixtureFeatureinstance.MixtureFeature.tnbptstring
            RowDummy.Item("tnbpt") = Me.MixtureFeatureinstance.MixtureFeature.tnbpt
            RowDummy.Item("tcstring") = Me.MixtureFeatureinstance.MixtureFeature.tcstring
            RowDummy.Item("tc") = Me.MixtureFeatureinstance.MixtureFeature.tc
            RowDummy.Item("pcstring") = Me.MixtureFeatureinstance.MixtureFeature.pcstring
            RowDummy.Item("pc") = Me.MixtureFeatureinstance.MixtureFeature.pc
            RowDummy.Item("dcstring") = Me.MixtureFeatureinstance.MixtureFeature.dcstring
            RowDummy.Item("dc") = Me.MixtureFeatureinstance.MixtureFeature.dc
            RowDummy.Item("acfstring") = Me.MixtureFeatureinstance.MixtureFeature.acfstring
            RowDummy.Item("acf") = Me.MixtureFeatureinstance.MixtureFeature.acf
            RowDummy.Item("nc") = Me.MixtureFeatureinstance.MixtureFeature.nc
            DataSetInputSave.Tables("RefMix").Rows.Add(RowDummy)
            For i As Integer = 0 To Me.MixtureFeatureinstance.MixtureFeature.nc - 1
                RowDummy = DataSetInputSave.Tables("RefMix").NewRow
                'Only mixture properties
                RowDummy.Item("comp") = Me.MixtureFeatureinstance.MixtureFeature.comp(i)
                RowDummy.Item("X") = Me.MixtureFeatureinstance.MixtureFeature.X(i)
                RowDummy.Item("WmElements") = Me.MixtureFeatureinstance.MixtureFeature.WmElements(i)
                'Just to do not let empty these five rows
                RowDummy.Item("TypeRefrigerant") = Me.TypeRefrigerant
                RowDummy.Item("SelectedIndex") = Me.SelectedIndex
                RowDummy.Item("SelectedFluidIndex_0") = Me.SelectedFluidName(0)
                RowDummy.Item("SelectedFluidIndex_1") = Me.SelectedFluidName(1)
                RowDummy.Item("SelectedFluidIndex_2") = Me.SelectedFluidName(2)
                RowDummy.Item("fluid") = Me.MixtureFeatureinstance.FluidsFeature(i).fluid
                RowDummy.Item("cas") = Me.MixtureFeatureinstance.FluidsFeature(i).cas
                RowDummy.Item("fullname") = Me.MixtureFeatureinstance.FluidsFeature(i).fullname
                RowDummy.Item("chemname") = Me.MixtureFeatureinstance.FluidsFeature(i).chemname
                RowDummy.Item("junk") = Me.MixtureFeatureinstance.FluidsFeature(i).junk
                RowDummy.Item("wmstring") = Me.MixtureFeatureinstance.FluidsFeature(i).wmstring
                RowDummy.Item("wm") = Me.MixtureFeatureinstance.FluidsFeature(i).wm
                RowDummy.Item("tnbptstring") = Me.MixtureFeatureinstance.FluidsFeature(i).tnbptstring
                RowDummy.Item("tnbpt") = Me.MixtureFeatureinstance.FluidsFeature(i).tnbpt
                RowDummy.Item("tcstring") = Me.MixtureFeatureinstance.FluidsFeature(i).tcstring
                RowDummy.Item("tc") = Me.MixtureFeatureinstance.FluidsFeature(i).tc
                RowDummy.Item("pcstring") = Me.MixtureFeatureinstance.FluidsFeature(i).pcstring
                RowDummy.Item("pc") = Me.MixtureFeatureinstance.FluidsFeature(i).pc
                RowDummy.Item("dcstring") = Me.MixtureFeatureinstance.FluidsFeature(i).dcstring
                RowDummy.Item("dc") = Me.MixtureFeatureinstance.FluidsFeature(i).dc
                RowDummy.Item("acfstring") = Me.MixtureFeatureinstance.FluidsFeature(i).acfstring
                RowDummy.Item("acf") = Me.MixtureFeatureinstance.FluidsFeature(i).acf
                DataSetInputSave.Tables("RefMix").Rows.Add(RowDummy)
            Next i
        End If
        DataSetInputSave.Tables("LTGInput").Columns.Add("VaporLiquidDisplayResults", System.Type.GetType("System.Int32")) '~ .Tables("RefleakInput").Columns. ...
        DataSetInputSave.Tables("LTGInput").Columns.Add("LeakType", System.Type.GetType("System.Int32")) '~ .Tables("RefleakInput").Columns. ...
        DataSetInputSave.Tables("LTGInput").Columns.Add("LeakingPhase", System.Type.GetType("System.Int32")) '~ .Tables("RefleakInput").Columns. ...
        DataSetInputSave.Tables("LTGInput").Columns.Add("Simulation", System.Type.GetType("System.Int32")) '~ .Tables("RefleakInput").Columns. ...
        DataSetInputSave.Tables("LTGInput").Columns.Add("NumberOfRecharge", System.Type.GetType("System.Int32")) '~ .Tables("RefleakInput").Columns. ...
        DataSetInputSave.Tables("LTGInput").Columns.Add("PercentMassLossForRecharging", System.Type.GetType("System.Double")) '~ .Tables("RefleakInput").Columns. ...
        DataSetInputSave.Tables("LTGInput").Columns.Add("InletTemperature", System.Type.GetType("System.Double")) '~ .Tables("RefleakInput").Columns. ...
        DataSetInputSave.Tables("LTGInput").Columns.Add("IntialVolumetricQuality", System.Type.GetType("System.Double")) '~ .Tables("RefleakInput").Columns. ...
        DataSetInputSave.Tables("LTGInput").Columns.Add("FillTemperature", System.Type.GetType("System.Double")) '~ .Tables("RefleakInput").Columns. ...
        DataSetInputSave.Tables("LTGInput").Columns.Add("FractionOfMaximumLiquidFill", System.Type.GetType("System.Double")) '~ .Tables("RefleakInput").Columns. ...

        '/*---
        DataSetInputSave.Tables("LTGInput").Columns.Add("HPlimit", System.Type.GetType("System.Int32"))
        DataSetInputSave.Tables("LTGInput").Columns.Add("LPlimit", System.Type.GetType("System.Int32"))

        DataSetInputSave.Tables("LTGInput").Columns.Add("Pnum", System.Type.GetType("System.Int32"))
        DataSetInputSave.Tables("LTGInput").Columns.Add("Hnum", System.Type.GetType("System.Int32"))

        DataSetInputSave.Tables("LTGInput").Columns.Add("LINscl", System.Type.GetType("System.Int32"))
        DataSetInputSave.Tables("LTGInput").Columns.Add("LOGscl", System.Type.GetType("System.Int32"))
        '/*--


        RowDummy = DataSetInputSave.Tables("LTGInput").NewRow
        RowDummy("VaporLiquidDisplayResults") = Me.VaporLiquidDisplayResults
        RowDummy("LeakType") = Me.LeakType
        RowDummy("LeakingPhase") = Me.LeakingPhase
        RowDummy("Simulation") = Me.Simulation
        RowDummy("NumberOfRecharge") = Me.NumberOfRecharge
        RowDummy("PercentMassLossForRecharging") = Me.PercentMassLossForRecharging
        RowDummy("InletTemperature") = Me.InletTemperature
        RowDummy("IntialVolumetricQuality") = Me.IntialVolumetricQuality
        RowDummy("FillTemperature") = Me.FillTemperature
        RowDummy("FractionOfMaximumLiquidFill") = Me.FractionOfMaximumLiquidFill

        '/*--
        RowDummy("HPlimit") = Me.LTG_HPlimit
        RowDummy("LPlimit") = Me.LTG_LPlimit
        RowDummy("Pnum") = Me.LTG_Pnum
        RowDummy("Hnum") = Me.LTG_Hnum
        RowDummy("LINscl") = Me.LTG_LINscl
        RowDummy("LOGscl") = Me.LTG_LOGscl
        '/*--

        DataSetInputSave.Tables("LTGInput").Rows.Add(RowDummy)

        '  Address =UserApplicationFolder & "\ExamplesFolder" & "\Prova.xml"
        DataSetInputSave.WriteXml(Address, XmlWriteMode.WriteSchema)
    End Sub
    'Load an Input File
    Friend Sub LoadFile(ByVal Address As String)
        Dim VersionNumberRed As Double
        Dim DataSetInputSave As New DataSet
        Dim FluidFeatureLocal As FluidFeatureSTR = Nothing
        Dim MixtureFeatureLocal As FluidFeatureSTR = Nothing
        Dim MixFluidsFeatureLocal() As FluidFeatureSTR
        Try
            DataSetInputSave.ReadXml(Address, XmlReadMode.ReadSchema)
        Catch ex As FileNotFoundException
            MsgBox("The file that you are trying to open has not been found.", vbOKOnly)
        Catch ex As FileLoadException
            MsgBox("The file that you are trying to open cannot be load.", vbOKOnly)
        Catch ex As Exception
            MsgBox("An unknown error occurred while reading file: " & Address & vbCrLf & ". Please report it to piotr.domanski@nist.gov.", vbOKOnly)
            Exit Sub
        End Try

        VersionNumberRed = CDbl(DataSetInputSave.Tables("ProgramVersion").Rows(0).Item("Version"))
        Me.TypeRefrigerant = CInt(DataSetInputSave.Tables("RefMix").Rows(0).Item("TypeRefrigerant"))
        If Me.TypeRefrigerant = 0 Then
            Me.SelectedIndex = CInt(DataSetInputSave.Tables("RefMix").Rows(0).Item("SelectedIndex"))
            Me.SelectedFluidName(0) = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("SelectedFluidIndex_0"))
            Me.SelectedFluidName(1) = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("SelectedFluidIndex_1"))
            Me.SelectedFluidName(2) = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("SelectedFluidIndex_2"))
            FluidFeatureLocal.fluid = Me.SelectedFluidName(0) '= CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("fluid"))
            FluidFeatureLocal.cas = "" ' = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("cas"))
            FluidFeatureLocal.fullname = Me.SelectedFluidName(0) ' = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("fullname"))
            FluidFeatureLocal.chemname = "" ' = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("chemname"))

            FluidFeatureLocal.FileName = Me.SelectedFluidName(0) + ".FLD" ' = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("FileName"))
            FluidFeatureLocal.ShortName = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("ShortName")) 'YYJ[2020.0704]ltgen2: Read ShortName from XML

            FluidFeatureLocal.junk = "" ' = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("junk"))
            FluidFeatureLocal.wmstring = "" ' = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("wmstring"))
            FluidFeatureLocal.wm = CDbl(DataSetInputSave.Tables("RefMix").Rows(0).Item("wm"))
            FluidFeatureLocal.tnbptstring = "" ' = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("tnbptstring"))
            FluidFeatureLocal.tnbpt = CDbl(DataSetInputSave.Tables("RefMix").Rows(0).Item("tnbpt"))
            FluidFeatureLocal.tcstring = "" ' = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("tcstring"))
            FluidFeatureLocal.tc = CDbl(DataSetInputSave.Tables("RefMix").Rows(0).Item("tc"))
            FluidFeatureLocal.pcstring = "" ' = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("pcstring"))
            FluidFeatureLocal.pc = CDbl(DataSetInputSave.Tables("RefMix").Rows(0).Item("pc"))
            FluidFeatureLocal.dcstring = "" ' = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("dcstring"))
            FluidFeatureLocal.dc = CDbl(DataSetInputSave.Tables("RefMix").Rows(0).Item("dc"))
            FluidFeatureLocal.acfstring = "" ' = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("acfstring"))
            FluidFeatureLocal.acf = CDbl(DataSetInputSave.Tables("RefMix").Rows(0).Item("acf"))
            FluidFeatureLocal.nc = CInt(DataSetInputSave.Tables("RefMix").Rows(0).Item("nc"))
            Me.PureFluidFeatureinstance.SetProperties(Me.TypeRefrigerant, FluidFeatureLocal)
        ElseIf Me.TypeRefrigerant = 1 Or Me.TypeRefrigerant = 2 Then
            Me.SelectedIndex = CInt(DataSetInputSave.Tables("RefMix").Rows(0).Item("SelectedIndex"))
            Me.SelectedFluidName(0) = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("SelectedFluidIndex_0"))
            Me.SelectedFluidName(1) = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("SelectedFluidIndex_1"))
            Me.SelectedFluidName(2) = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("SelectedFluidIndex_2"))
            MixtureFeatureLocal.fluid = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("fluid"))
            MixtureFeatureLocal.fullname = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("fullname"))
            MixtureFeatureLocal.chemname = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("chemname"))

            MixtureFeatureLocal.FileName = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("FileName"))
            MixtureFeatureLocal.ShortName = MixtureFeatureLocal.FileName 'YYJ[2020.0704]ltgen2: For mixture fluid, regarding ShortName as its FileName

            MixtureFeatureLocal.junk = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("junk"))
            MixtureFeatureLocal.wmstring = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("wmstring"))
            MixtureFeatureLocal.wm = CDbl(DataSetInputSave.Tables("RefMix").Rows(0).Item("wm"))
            MixtureFeatureLocal.tnbptstring = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("tnbptstring"))
            MixtureFeatureLocal.tnbpt = CDbl(DataSetInputSave.Tables("RefMix").Rows(0).Item("tnbpt"))
            MixtureFeatureLocal.tcstring = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("tcstring"))
            MixtureFeatureLocal.tc = CDbl(DataSetInputSave.Tables("RefMix").Rows(0).Item("tc"))
            MixtureFeatureLocal.pcstring = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("pcstring"))
            MixtureFeatureLocal.pc = CDbl((DataSetInputSave.Tables("RefMix").Rows(0).Item("pc")))
            MixtureFeatureLocal.dcstring = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("dcstring"))
            MixtureFeatureLocal.dc = CDbl(DataSetInputSave.Tables("RefMix").Rows(0).Item("dc"))
            MixtureFeatureLocal.acfstring = CStr(DataSetInputSave.Tables("RefMix").Rows(0).Item("acfstring"))
            MixtureFeatureLocal.acf = CDbl(DataSetInputSave.Tables("RefMix").Rows(0).Item("acf"))
            'Only mixture properties
            MixtureFeatureLocal.nc = CInt(DataSetInputSave.Tables("RefMix").Rows(0).Item("nc"))
            ReDim MixFluidsFeatureLocal(MixtureFeatureLocal.nc - 1)
            ReDim MixtureFeatureLocal.comp(MixtureFeatureLocal.nc - 1)
            ReDim MixtureFeatureLocal.X(MixtureFeatureLocal.nc - 1)
            ReDim MixtureFeatureLocal.WmElements(MixtureFeatureLocal.nc - 1)
            For i As Integer = 0 To MixtureFeatureLocal.nc - 1
                'Only mixture properties
                MixtureFeatureLocal.comp(i) = CStr(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("comp"))
                MixtureFeatureLocal.X(i) = CDbl(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("X"))
                MixtureFeatureLocal.WmElements(i) = CDbl(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("WmElements"))
                MixFluidsFeatureLocal(i).fluid = CStr(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("fluid"))
                MixFluidsFeatureLocal(i).cas = CStr((DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("cas")))
                MixFluidsFeatureLocal(i).fullname = CStr((DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("fullname")))
                MixFluidsFeatureLocal(i).chemname = CStr((DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("chemname")))
                MixFluidsFeatureLocal(i).junk = CStr(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("junk"))
                MixFluidsFeatureLocal(i).wmstring = CStr(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("wmstring"))
                MixFluidsFeatureLocal(i).wm = CDbl(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("wm"))
                MixFluidsFeatureLocal(i).tnbptstring = CStr(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("tnbptstring"))
                MixFluidsFeatureLocal(i).tnbpt = CDbl(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("tnbpt"))
                MixFluidsFeatureLocal(i).tcstring = CStr(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("tcstring"))
                MixFluidsFeatureLocal(i).tc = CDbl(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("tc"))
                MixFluidsFeatureLocal(i).pcstring = CStr(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("pcstring"))
                MixFluidsFeatureLocal(i).pc = CDbl(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("pc"))
                MixFluidsFeatureLocal(i).dcstring = CStr(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("dcstring"))
                MixFluidsFeatureLocal(i).dc = CDbl(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("dc"))
                MixFluidsFeatureLocal(i).acfstring = CStr(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("acfstring"))
                MixFluidsFeatureLocal(i).acf = CDbl(DataSetInputSave.Tables("RefMix").Rows(i + 1).Item("acf"))
            Next i
            Me.MixtureFeatureinstance.SetProperties(Me.TypeRefrigerant, MixFluidsFeatureLocal, MixtureFeatureLocal)
        End If
        Me.VaporLiquidDisplayResults = CInt(DataSetInputSave.Tables("LTGInput").Rows(0).Item("VaporLiquidDisplayResults")) '~ .Tables("RefleakInput").Rows(0) ...
        Me.LeakType = CInt(DataSetInputSave.Tables("LTGInput").Rows(0).Item("LeakType")) '~ .Tables("RefleakInput").Rows(0) ...
        Me.LeakingPhase = CInt(DataSetInputSave.Tables("LTGInput").Rows(0).Item("LeakingPhase")) '~ .Tables("RefleakInput").Rows(0) ...
        Me.Simulation = CInt(DataSetInputSave.Tables("LTGInput").Rows(0).Item("Simulation")) '~ .Tables("RefleakInput").Rows(0) ...
        Me.NumberOfRecharge = CInt(DataSetInputSave.Tables("LTGInput").Rows(0).Item("NumberOfRecharge")) '~ .Tables("RefleakInput").Rows(0) ...
        Me.PercentMassLossForRecharging = CDbl(DataSetInputSave.Tables("LTGInput").Rows(0).Item("PercentMassLossForRecharging")) '~ .Tables("RefleakInput").Rows(0) ...
        Me.InletTemperature = CDbl(DataSetInputSave.Tables("LTGInput").Rows(0).Item("InletTemperature")) '~ .Tables("RefleakInput").Rows(0) ...
        Me.IntialVolumetricQuality = CDbl(DataSetInputSave.Tables("LTGInput").Rows(0).Item("IntialVolumetricQuality")) '~ .Tables("RefleakInput").Rows(0) ...
        Me.FillTemperature = CDbl(DataSetInputSave.Tables("LTGInput").Rows(0).Item("FillTemperature")) '~ .Tables("RefleakInput").Rows(0) ...
        Me.FractionOfMaximumLiquidFill = CDbl(DataSetInputSave.Tables("LTGInput").Rows(0).Item("FractionOfMaximumLiquidFill")) '~ .Tables("RefleakInput").Rows(0) ...

        '/*---
        Me.LTG_HPlimit = CInt(DataSetInputSave.Tables("LTGInput").Rows(0).Item("HPlimit"))
        Me.LTG_LPlimit = CInt(DataSetInputSave.Tables("LTGInput").Rows(0).Item("LPlimit"))
        Me.LTG_Pnum = CInt(DataSetInputSave.Tables("LTGInput").Rows(0).Item("Pnum"))
        Me.LTG_Hnum = CInt(DataSetInputSave.Tables("LTGInput").Rows(0).Item("Hnum"))
        Me.LTG_LINscl = CInt(DataSetInputSave.Tables("LTGInput").Rows(0).Item("LINscl"))
        Me.LTG_LOGscl = CInt(DataSetInputSave.Tables("LTGInput").Rows(0).Item("LOGscl"))
        '/*---


    End Sub
End Class
Public Class BordConditionClass                  'Bord condition set in MainForm
    Private var_DislayOpeningWindow As Boolean   'T:Yes, F:No
    Private var_FileLoad As Integer              '0) Load default 1) no file(start with the last)
    Private var_Unit As String                   '0) "SI with K" 1) "SI with °C" 2)"I-P Inch-Pound" 
    Private var_UnitInteger As Integer
    Private var_InputTypeEvCondSat As Integer    '0: Temperature; 1: Pressure
    Private var_RefState As Integer              '0: Default; 1: NBP; 2: ASHRAE; 3: IIR
    Private var_RefStateString As String         '0: DEF; 1: NBP; 2: ASH; 3: IIR, used in Refprop
    Private var_TabPreferences As DataTable
    Private var_RowChangedPreferences As DataRow 'Used if the user will change the preferences in preferences formmmm 
    Private varTabToSave As DataTable            'Row used to Save in the preferences file
    Private varInputTypeEvCondSatPreviuos As Integer
    Private varChangeOptPressTemp As Boolean      'T:Changed, F:Not Changed
    Public Property DislayOpeningWindow() As Boolean
        Get
            Return var_DislayOpeningWindow
        End Get
        Set(ByVal value As Boolean)
            var_DislayOpeningWindow = value
        End Set
    End Property
    Public Property FileLoad() As Integer
        Get
            Return var_FileLoad
        End Get
        Set(ByVal value As Integer)
            var_FileLoad = value
        End Set
    End Property
    Public Property Unit() As String
        Get
            Return var_Unit
        End Get
        Set(ByVal value As String)
            var_Unit = value
        End Set
    End Property
    ''' <summary>
    ''' 0: "SI with K"
    ''' 1: "SI with °C"
    ''' 2: "I-P Inch-Pound"
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property UnitInteger() As Integer
        Get
            Select Case Me.var_Unit
                Case "SI with K"
                    var_UnitInteger = 0
                Case "SI with °C"
                    var_UnitInteger = 1
                Case "I-P Inch-Pound"
                    var_UnitInteger = 2
                Case Else
                    var_UnitInteger = 0
            End Select

            Return var_UnitInteger
        End Get
    End Property
    Public Property InputTypeEvCondSat() As Integer
        Get
            Return var_InputTypeEvCondSat
        End Get
        Set(ByVal value As Integer)
            'Ceck if the value is changed
            varInputTypeEvCondSatPreviuos = var_InputTypeEvCondSat
            var_InputTypeEvCondSat = value
            If var_InputTypeEvCondSat <> varInputTypeEvCondSatPreviuos Then
                varChangeOptPressTemp = True
            Else
                varChangeOptPressTemp = False
            End If
        End Set
    End Property
    Public ReadOnly Property ChangeOptPressTemp() As Boolean
        Get
            Return varChangeOptPressTemp
        End Get
    End Property
    Public Property RefState() As Integer
        Get
            Return var_RefState
        End Get
        Set(ByVal value As Integer)
            var_RefState = value
        End Set
    End Property
    Public ReadOnly Property RefStateString() As String
        Get
            Select Case Me.var_RefState
                Case Is = 0
                    var_RefStateString = "DEF"
                Case Is = 1
                    var_RefStateString = "NBP"
                Case Is = 2
                    var_RefStateString = "ASH"
                Case Is = 3
                    var_RefStateString = "IIR"
                Case Else
                    var_RefStateString = "DEF"
            End Select
            Return var_RefStateString
        End Get
    End Property
    Public Property TabToSave() As DataTable
        Get
            Return varTabToSave
        End Get
        Set(ByVal value As DataTable)
            varTabToSave = value
        End Set
    End Property
    Friend Sub ReadStartupPreferencesFile()
        'Dim StartupPreferencesDS As New DataSet
        'If FileIO.FileSystem.FileExists(UserApplicationFolder & "\StartupPreferences.xml") Then
        '    Try
        '        StartupPreferencesDS.ReadXml(UserApplicationFolder & "\StartupPreferences.xml")
        '    Catch ex As Exception
        '        MsgBox("Problem encountered reading the file StartupPreferences.xml")
        '    End Try
        '    Me.DislayOpeningWindow = CBool(StartupPreferencesDS.Tables("Startup").Rows(0).Item("DisplayOpeningWindow"))
        '    Me.FileLoad = CInt(StartupPreferencesDS.Tables("Startup").Rows(0).Item("FileLoad"))
        '    'As Default set the table with the last user no load files user preference saved
        '    Me.SetParametersbyTableRow(StartupPreferencesDS.Tables("Preferences").Rows(0))
        'Else
        'MsgBox("YYJ: The startup file does not exist, default preference will be applied." & vbCrLf & "To change the default setting, select option \ default setting")
        Me.DislayOpeningWindow = True
        Me.FileLoad = 0 '2
        Me.var_Unit = "SI with °C" 'YYJ[2020.0425]ltgen2: override unit '~ = "SI with K"
            Me.RefState = 0
            Me.InputTypeEvCondSat = 1
        'End If
    End Sub
    Friend Sub ReadClassPreferencesToSaveIntoAFile()
        Dim TabToSaveLocal As New DataTable
        TabToSaveLocal.TableName = "Preferences"
        TabToSaveLocal.Columns.Add("Unit", System.Type.GetType("System.String"))
        TabToSaveLocal.Columns.Add("InputTypeEvCondSat", System.Type.GetType("System.Int32"))
        TabToSaveLocal.Columns.Add("RefState", System.Type.GetType("System.Int32"))
        Dim Row As DataRow = TabToSaveLocal.NewRow()
        Row("Unit") = Me.Unit
        Row("InputTypeEvCondSat") = Me.InputTypeEvCondSat
        Row("RefState") = Me.RefState
        TabToSaveLocal.Rows.Add(Row)
        Me.TabToSave = TabToSaveLocal.Copy
    End Sub
    Friend Sub ReadFile(ByVal Address As String)
        Dim DataSetLastFile As New DataSet
        DataSetLastFile.ReadXml(Address)
        Me.SetParametersbyTableRow(DataSetLastFile.Tables("Preferences").Rows(0))
    End Sub
    Private Sub SetParametersbyTableRow(ByVal Row As DataRow)
        Me.Unit = CStr(Row.Item("Unit"))
        Me.InputTypeEvCondSat = CInt(Row.Item("InputTypeEvCondSat"))
        Me.RefState = CInt(Row.Item("RefState"))
    End Sub
    Public Function BordConditionClone() As BordConditionClass
        Return DirectCast(MemberwiseClone(), BordConditionClass)
        'The deep clone stuff
    End Function
    Friend Sub WriteStartupPreferencesFile()
        Dim RowDummy As DataRow
        Dim StartupPreferencesDS As New DataSet
        StartupPreferencesDS.Tables.Add(DataTableVersion.Copy)
        StartupPreferencesDS.Tables.Add("Startup")
        StartupPreferencesDS.Tables("Startup").Columns.Add("DisplayOpeningWindow", System.Type.GetType("System.Boolean"))
        StartupPreferencesDS.Tables("Startup").Columns.Add("FileLoad", System.Type.GetType("System.Int32"))
        RowDummy = StartupPreferencesDS.Tables("Startup").NewRow()
        RowDummy("DisplayOpeningWindow") = Me.DislayOpeningWindow
        RowDummy("FileLoad") = Me.FileLoad
        StartupPreferencesDS.Tables("Startup").Rows.Add(RowDummy)
        'The TabToSave is copied from the class property
        Me.ReadClassPreferencesToSaveIntoAFile()
        StartupPreferencesDS.Tables.Add(Me.TabToSave.Copy)

        'YYJ[2020.0903]ltgen2: make a portable version - s
        StartupPreferencesDS.WriteXml(ApplicationFolder & "\StartupPreferences.xml", XmlWriteMode.WriteSchema)
        'StartupPreferencesDS.WriteXml(UserApplicationFolder & "\StartupPreferences.xml", XmlWriteMode.WriteSchema)
        'YYJ[2020.0903]ltgen2: make a portable version - e

    End Sub
    'Friend Sub UpdateStartupPreferencesFile()
    '    Dim StartupPreferencesDS As New DataSet
    '    StartupPreferencesDS.ReadXml(UserApplicationFolder & "\StartupPreferences.xml")
    '    StartupPreferencesDS.Tables("Startup").Rows(0).Item("DisplayOpeningWindow") = Me.DislayOpeningWindow
    '    StartupPreferencesDS.Tables("Startup").Rows(0).Item("FileLoad") = Me.FileLoad
    '    ' The Table "Preferences" has three rows, First containing the last file preferences, 
    '    'Second containing the default ones, third the no file ones
    '    If Me.FileLoad = 0 Then
    '        StartupPreferencesDS.Tables("Preferences").Rows(0).Item("InitialFile") = 0
    '        StartupPreferencesDS.Tables("Preferences").Rows(0).Item("Unit") = Me.Unit
    '        StartupPreferencesDS.Tables("Preferences").Rows(0).Item("InputTypeEvCondSat") = Me.InputTypeEvCondSat
    '        StartupPreferencesDS.Tables("Preferences").Rows(0).Item("RefState") = Me.RefState
    '    ElseIf Me.FileLoad = 1 Then
    '        StartupPreferencesDS.Tables("Preferences").Rows(0).Item("InitialFile") = 1
    '        StartupPreferencesDS.Tables("Preferences").Rows(1).Item("Unit") = Me.Unit
    '        StartupPreferencesDS.Tables("Preferences").Rows(1).Item("InputTypeEvCondSat") = Me.InputTypeEvCondSat
    '        StartupPreferencesDS.Tables("Preferences").Rows(1).Item("RefState") = Me.RefState
    '    ElseIf Me.FileLoad = 2 Then
    '        StartupPreferencesDS.Tables("Preferences").Rows(0).Item("InitialFile") = 2
    '        StartupPreferencesDS.Tables("Preferences").Rows(1).Item("Unit") = Me.Unit
    '        StartupPreferencesDS.Tables("Preferences").Rows(1).Item("InputTypeEvCondSat") = Me.InputTypeEvCondSat
    '        StartupPreferencesDS.Tables("Preferences").Rows(1).Item("RefState") = Me.RefState
    '    End If
    '    StartupPreferencesDS.WriteXml(UserApplicationFolder & "\StartupPreferences.xml", XmlWriteMode.WriteSchema)
    'End Sub
    'Friend Sub WriteStartupPreferencesFile()
    '    Dim RowDummy As DataRow
    '    Dim StartupPreferencesDS As New DataSet
    '    StartupPreferencesDS.Tables.Add("Startup")
    '    StartupPreferencesDS.Tables.Add("Preferences")
    '    StartupPreferencesDS.Tables("Startup").Columns.Add("DisplayOpeningWindow", System.Type.GetType("System.Boolean"))
    '    StartupPreferencesDS.Tables("Startup").Columns.Add("FileLoad", System.Type.GetType("System.Int32"))
    '    'StartupPreferencesDS.Tables("Startup").PrimaryKey = New DataColumn() {StartupPreferencesDS.Tables("Startup").Columns("LoadInitialFile")}
    '    StartupPreferencesDS.Tables("Preferences").Columns.Add("InitialFile", System.Type.GetType("System.Int32"))
    '    StartupPreferencesDS.Tables("Preferences").Columns.Add("Unit", System.Type.GetType("System.String"))
    '    StartupPreferencesDS.Tables("Preferences").Columns.Add("InputTypeEvCondSat", System.Type.GetType("System.Int32"))
    '    StartupPreferencesDS.Tables("Preferences").Columns.Add("RefState", System.Type.GetType("System.Int32"))
    '    'StartupPreferencesDS.Tables("Startup").PrimaryKey = New DataColumn() {StartupPreferencesDS.Tables("Preferences").Columns("LoadInitialFile")}
    '    RowDummy = StartupPreferencesDS.Tables("Startup").NewRow()
    '    RowDummy("DisplayOpeningWindow") = Me.DislayOpeningWindow
    '    RowDummy("FileLoad") = Me.FileLoad
    '    StartupPreferencesDS.Tables("Startup").Rows.Add(RowDummy)
    '    ' Two rows are added the frist is the last file preferences, the second is the default file, 
    '    ' three containing the no file case preferences
    '    RowDummy = StartupPreferencesDS.Tables("Preferences").NewRow()
    '    RowDummy("InitialFile") = Me.FileLoad                 '0:Last, 1:Default, 2:No File
    '    RowDummy("Unit") = Me.Unit
    '    RowDummy("InputTypeEvCondSat") = Me.InputTypeEvCondSat
    '    RowDummy("RefState") = Me.RefState
    '    StartupPreferencesDS.Tables("Preferences").Rows.Add(RowDummy)
    '    StartupPreferencesDS.WriteXml(UserApplicationFolder & "\StartupPreferences.xml", XmlWriteMode.WriteSchema)
    'End Sub
End Class
Public Class PureFluidFeatureClass
    Private val_TypeRefrigerant As Integer
    Private var_FluidFeature As FluidFeatureSTR
    Public ReadOnly Property FluidFeature() As FluidFeatureSTR
        Get
            Return var_FluidFeature
        End Get
    End Property
    Public Sub SetProperties(ByVal TypeRefrigerant As Integer, ByVal FluidFeature As FluidFeatureSTR)
        var_FluidFeature = FluidFeature
        val_TypeRefrigerant = TypeRefrigerant
    End Sub
End Class
Public Class MixtureFeatureClass
    'This class will be the only remaining for both the fluid and the mixture
    Private val_TypeRefrigerant As Integer
    Private val_NameFolderMixture As String = ""
    Private var_MixtureFeature As FluidFeatureSTR
    Private var_FluidsFeature() As FluidFeatureSTR
    Public ReadOnly Property TypeRefrigerant() As Integer
        Get
            Return val_TypeRefrigerant
        End Get
    End Property
    Public ReadOnly Property MixtureFolderPath() As String
        Get
            If val_TypeRefrigerant = 1 Then
                val_NameFolderMixture = MixturesFolderPath
            ElseIf val_TypeRefrigerant = 2 Then
                val_NameFolderMixture = UserDefinedMixtureFolderPath
            End If
            Return val_NameFolderMixture
        End Get
    End Property
    Public ReadOnly Property NameFolderMixture() As String
        Get
            Return val_NameFolderMixture
        End Get
    End Property
    Public ReadOnly Property MixtureFeature() As FluidFeatureSTR
        Get
            Return var_MixtureFeature
        End Get
    End Property
    Public ReadOnly Property FluidsFeature() As FluidFeatureSTR()
        Get
            Return var_FluidsFeature
        End Get
    End Property
    Public Sub SetProperties(ByVal TypeRefrigerant As Integer, ByVal FluidsFeature() As FluidFeatureSTR, ByVal MixtureFeature As FluidFeatureSTR)
        val_TypeRefrigerant = TypeRefrigerant
        var_FluidsFeature = FluidsFeature
        var_MixtureFeature = MixtureFeature
    End Sub
End Class
Friend Structure InputChartSTR
    Dim ShowLiquid As Boolean
    Dim ShowVapor As Boolean
    Dim IIF As Integer
    Dim ISIMUL As Integer
    Dim IPHASE As Integer
    Dim NORECG As Integer
    Dim nc As Integer
    Dim ICASE As Integer
    Dim PercentOfRecharge As Double
    Dim TB() As Double
    Dim PB() As Double
    Dim VLB() As Double
    Dim VVB() As Double
    Dim VQB() As Double
    Dim QB() As Double
    Dim PMOLEB() As Double
    Dim PMASSB() As Double
    Dim XLB(,) As Double
    Dim XVB(,) As Double
    Dim XLBArrays()() As Double
    Dim XVBArrays()() As Double
End Structure