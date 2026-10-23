Imports System.Globalization

Public Module GlobalModule
    'Max number of refrigerants per mixture
   
    Public TypeRefrigerant2 As Integer      '0: Pure; 1: Predefined; 2: UserDefinedMixture

    'YYJ[2020.0727]ltgen2: maximum component reduced 10 --> 6 - s
    Public Const NMaxRefrigrants = 6
    'Public Const NMaxRefrigrants = 10
    'YYJ[2020.0727]ltgen2: maximum component reduced 10 --> 6 - e

    Public IIF As Integer
    Public mixing_value_changed(50) As Integer
        Public inter_coeff_input1_set(50), inter_coeff_input2_set(50), inter_coeff_input3_set(50), inter_coeff_input4_set(50), inter_coeff_input5_set(50) As Double
        Public mixing_mode_set(50) As String
        Public mixing_mode As String
        Public mixing_mode_changed(50) As Integer
        Public FillTempK, FillTempC, FillTempF As Double
        Public InitTempK, InitTempC, InitTempF As Double
        Public initialVQ As Double
        Public blnlblUserDefined(0 To 44) As Boolean
        Public mixingmodeset(0 To 44) As String
        Public refrigerant_a(50), refrigerant_b(50) As String
        Public TB(0 To 1000) As Double, PB(0 To 1000) As Double, VLB(0 To 1000) As Double, VVB(0 To 1000) As Double, VQB(0 To 1000) As Double, QB(0 To 1000) As Double
        Public PMOLEB(0 To 1000) As Double, PMASSB(0 To 1000) As Double
        Public XLB(0 To 9, 0 To 1000) As Double, XVB(0 To 9, 0 To 1000) As Double
    Public calcVQ As Boolean, vqfracviewed As Boolean, fill As Boolean
    Public detect As Boolean



    Public Structure FluidFeatureSTR
        Friend fluid As String
        Friend cas As String
        Friend fullname As String
        Friend chemname As String
        Friend FileName As String
        Friend junk As String
        Friend wmstring As String
        Friend wm As Double
        Friend tnbptstring As String
        Friend tnbpt As Double
        Friend tcstring As String
        Friend tc As Double
        Friend pcstring As String
        Friend pc As Double
        Friend dcstring As String
        Friend dc As Double
        Friend acfstring As String
        Friend acf As Double
        'Mixture properties
        Friend nc As Integer
        Friend comp() As String
        Friend X() As Double
        Friend WmElements() As Double
        Friend ShortName As String 'YYJ[2020.0704]ltgen2: Handling ShortName
    End Structure
    Public BordConditions As New BordConditionClass
        Public BordConditionPreferences As New BordConditionClass
        'Internat: flag decimal separator T:comma, F:dot
        Private var_Internat As Boolean
        'DataTable Units
        Public DataTableUnits As New DataTable
        'Folder addresses
        Private var_ApplicationFolderLocal As String
        Private var_LocalUserFolderLocal As String
        Private var_AllUsersFolderLocal As String
        Private var_UserDocumentsFolder As String
        Private var_Refleak_In_UserDocumentsFolder As String
        Private var_ExamplesFolder As String
        Private var_MixturesFolderPath As String
        Private var_UserDefinedMixtureFolderPath As String
        'Table within version number
        Private var_DataTableVersion As New DataTable
        Private var_VersionNumber As Double
        Public ReadOnly Property ApplicationFolder As String
            Get
                Return var_ApplicationFolderLocal
            End Get
        End Property
        Public ReadOnly Property UserApplicationFolder As String
            Get
                Return var_LocalUserFolderLocal
            End Get
        End Property
        Public ReadOnly Property Internat As Boolean
            Get
                Return var_Internat
            End Get
        End Property
        Public ReadOnly Property AllApplicationUsersFolder As String
            Get
                Return var_AllUsersFolderLocal
            End Get
        End Property
        Public ReadOnly Property UserDocumentsFolder As String
            Get
                Return var_UserDocumentsFolder
            End Get
        End Property
        Public ReadOnly Property Refleak_In_UserDocumentsFolder As String
            Get
                Return var_Refleak_In_UserDocumentsFolder
            End Get
        End Property
        Public ReadOnly Property VersionNumber As Double
            Get
                Return var_VersionNumber
            End Get
        End Property
        Public ReadOnly Property DataTableVersion As DataTable
            Get
                Return var_DataTableVersion
            End Get
        End Property
        Public ReadOnly Property MixturesFolderPath As String
            Get
                Return var_MixturesFolderPath
            End Get
        End Property
        Public ReadOnly Property UserDefinedMixtureFolderPath As String
            Get
                Return var_UserDefinedMixtureFolderPath
            End Get
        End Property
    Public Sub SetGlobalConditions()
        Dim RowDummy As DataRow

        'YYJ[2020.0903]ltgen2: make a portable version // note: My.Application.Info.DirectoryPath == C:\NIST\09\LtGen2\LTGen2\bin\Debug
        DataTableUnits.ReadXml(My.Application.Info.DirectoryPath & "\Unit.xml")

        var_ApplicationFolderLocal = My.Application.Info.DirectoryPath

        'YYJ[2020.1119]ltgen2: remove unused codes - s
        'var_LocalUserFolderLocal = Application.LocalUserAppDataPath
        'var_AllUsersFolderLocal = Application.CommonAppDataPath
        'var_UserDocumentsFolder = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        'var_Refleak_In_UserDocumentsFolder = var_UserDocumentsFolder & "\LTGEN2"
        ''var_Refleak_In_UserDocumentsFolder = var_UserDocumentsFolder & "\REFLEAK 6.0"
        'YYJ[2020.1119]ltgen2: remove unused codes - e

        'YYJ[2020.0903]ltgen2: make a portable version - s
        var_MixturesFolderPath = var_ApplicationFolderLocal & "\MIXTURES\"
        var_UserDefinedMixtureFolderPath = var_ApplicationFolderLocal & "\UserDefinedMixture\"
        'var_MixturesFolderPath = My.Application.Info.DirectoryPath & "\mixtures\"
        'var_UserDefinedMixtureFolderPath = var_LocalUserFolderLocal & "\UserDefinedMixture\"
        'YYJ[2020.0903]ltgen2: make a portable version - e

        ' Go to look the decimal separator
        If CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator = "," Then
            var_Internat = True
        Else
            var_Internat = False
        End If
        'Create a DataTable within the version
        var_VersionNumber = 1.0
        var_DataTableVersion.TableName = "ProgramVersion"
        var_DataTableVersion.Columns.Add("Version", System.Type.GetType("System.Double"))
        RowDummy = var_DataTableVersion.NewRow
        RowDummy.Item("Version") = var_VersionNumber
        var_DataTableVersion.Rows.Add(RowDummy)

    End Sub
End Module
