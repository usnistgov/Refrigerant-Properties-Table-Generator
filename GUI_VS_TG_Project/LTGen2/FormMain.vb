Option Strict Off
Option Explicit On
Imports System.Windows.Forms
Imports System.IO
Public Class FormMain
    Private intOpenNum As Integer = 1
    Private FlagRunAtLeastOneSimulation As Boolean = False
    Friend FlagOPenNewChildren As Boolean = False
    Friend FlagQuitButPushed As Boolean

    Private Property e As Object

    Private Sub ExecInitByFormOpening()
        Call SetGlobalConditions()
        vqfracviewed = False
        detect = False
        TypeRefrigerant2 = 0
    End Sub

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FontName As String = "Font con grassetto"
        Dim FontSize As Single = 10
        Dim FS As New Font(FontName, FontSize, FontStyle.Bold)

        Call ExecInitByFormOpening() 'YYJ[2020.0425]ltgen2: Call initializa routine (previously called by Opening form)

        'YYJ[2020.0425]ltgen2: remove toolbar and menubar - s 
        'For i As Integer = 4 To Me.ToolStrip1.Items.Count - 2
        '    Me.ToolStrip1.Items(i).Image = Me.imglstToolbar.Images(i)
        'Next i
        'YYJ[2020.0425]ltgen2: remove toolbar and menubar - e

        Me.SetVisibleControls()
        ' Call SetGlobalConditions()
        'Check the if the folders exist on the User App Data
        Me.CheckFolders()
        'Read the Startup preferences in BordCondition 
        BordConditionPreferences.ReadStartupPreferencesFile()
        BordConditions = BordConditionPreferences.BordConditionClone

        BordConditions.Unit = "SI with °C" 'YYJ[2020.0425]ltgen2: override unit

        'YYJ[2020.0425]ltgen2: remove related to 'Opening form' - s
        'If BordConditions.DislayOpeningWindow Then
        '    Dim FormOpeninginstance As New FormOpening
        '    'The following lines would need to be uncommented if one wanted the opening screen to appear for 3 secs and then disappear
        '    ''''''''''''''''''''''''FormOpeninginstance.ScreenShot = True
        '    ''''''''''''''''''''''''FormOpeninginstance.Ok_BUT.Hide()
        '    ''''''''''''''''''''''''FormOpeninginstance.Show()
        '    ''''''''''''''''''''''''FormOpeninginstance.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        '    ''''''''''''''''''''''''FormOpeninginstance.Refresh()
        '    'keep it showning for 3 seconds then close it
        '    ''''''''''''''''''''''''System.Threading.Thread.Sleep(3000)
        '    ''chiudo la form
        '    ''''''''''''''''''''''''FormOpeninginstance.Close()
        'End If
        'YYJ[2020.0425]ltgen2: remove related to 'Opening form' - e


        'YYJ[2020.09083]ltgen2: make a portable version - s
        Me.OpenAnExistingFile(My.Application.Info.DirectoryPath & "\Last(LtG2).xml")
        ''Based on the startup preference, the last/Default files are opened, and the BordConditions class opened
        'If BordConditionPreferences.FileLoad = 0 Then                   'Last
        '    If FileIO.FileSystem.FileExists(UserApplicationFolder & "\Last(LtG2).xml") Then  '~ & "\Last.xml") Then
        '        Me.OpenAnExistingFile(UserApplicationFolder & "\Last(LtG2).xml") ' & "\Last.xml") Then
        '    Else
        '        Me.OpenAnExistingFile(My.Application.Info.DirectoryPath & "\Last(LtG2).xml") 'YYJ[2020.0710]ltgen2: exception handling
        '        'MsgBox("The file ""Last(LTG)"" does not exist, please try to restart the application.")
        '    End If
        'ElseIf BordConditionPreferences.FileLoad = 1 Then               'Default
        '    If FileIO.FileSystem.FileExists(UserApplicationFolder & "\Default.xml") Then
        '        Me.OpenAnExistingFile(UserApplicationFolder & "\Default.xml")
        '    Else
        '        'LTGen2 does not need 'default setting' xml file, so nothing to do in this block
        '        'MsgBox("The file ""Default.xml"" does not exit. Please save one before exiting REFLEAK. (Tab 'File' and then select 'Save As Default File')")
        '    End If
        'End If
        'YYJ[2020.09083]ltgen2: make a portable version - e

    End Sub
    Friend Sub SetVisibleControls()
        If Me.FlagOPenNewChildren Then
            Me.SaveToolStripMenuItem.Enabled = True
            Me.Save.Enabled = True
            Me.SaveAsToolStripMenuItem.Enabled = True
            Me.SaveAsDefaultFileToolStripMenuItem.Enabled = True
            Me.DisplayResultsToolStripMenuItem.Enabled = False
        Else
            Me.SaveToolStripMenuItem.Enabled = False
            Me.Save.Enabled = False
            Me.SaveAsToolStripMenuItem.Enabled = False
            Me.SaveAsDefaultFileToolStripMenuItem.Enabled = False
            Me.Print_But.Enabled = False
            Me.PrintToolStripMenuItem.Enabled = False
            Me.AnalyzeToolStripMenuItem.Enabled = False
            Me.DisplayResultsToolStripMenuItem.Enabled = False
            Me.Run_But.Visible = False
            frmInput.btnAnalyze.Enabled = False
        End If
    End Sub
    Friend Sub SetControlsAfterSimulation()
        Me.Print_But.Enabled = True
        Me.PrintToolStripMenuItem.Enabled = True
        Me.DisplayResultsToolStripMenuItem.Enabled = True
        Me.Run_But.Enabled = True : Me.AnalyzeToolStripMenuItem.Enabled = True
        frmInput.btnAnalyze.Enabled = True
    End Sub
    Friend Sub SetControlsAsBeforeRunnigSimulation()
        Me.Print_But.Enabled = False
        Me.PrintToolStripMenuItem.Enabled = False
        Me.DisplayResultsToolStripMenuItem.Enabled = False
    End Sub
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click, New_But.Click
        Me.CloseMDIResult()     'Close any form opened
        Me.FlagOPenNewChildren = True
        Dim FRMInputChild As New frmInput
        FRMInputChild.MdiParent = Me
        FRMInputChild.Text = "<Leak Simulation #" & CStr(intOpenNum) & ">"
        intOpenNum += 1
        FRMInputChild.Show()
        FRMInputChild.InitialTempC = 25
        FRMInputChild.InitialTempF = TCtoTE(FRMInputChild.InitialTempC)
        FRMInputChild.InitialTempK = TCtoTK(FRMInputChild.InitialTempC)

        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - s
        'If BordConditions.UnitInteger = 0 Then
        '    FRMInputChild.txtInitialTemp.Text = Format(FRMInputChild.InitialTempK, "#0.00")
        'ElseIf BordConditions.UnitInteger = 1 Then
        '    FRMInputChild.txtInitialTemp.Text = Format(FRMInputChild.InitialTempC, "#0.00")
        'ElseIf BordConditions.UnitInteger = 2 Then
        '    FRMInputChild.txtInitialTemp.Text = Format(FRMInputChild.InitialTempF, "#0.00")
        'Else
        '    FRMInputChild.txtInitialTemp.Text = Format(FRMInputChild.InitialTempK, "#0.00")
        'End If
        'FRMInputChild.txtInitialVolQual.Text = Format(0.2, "#0.000")
        'YYJ[2020-0425]ltgen2: remove 'Leak/Recharge' logics - e

        Me.SetVisibleControls()
        Me.Run_But.Visible = False : Me.AnalyzeToolStripMenuItem.Enabled = False : FRMInputChild.btnAnalyze.Enabled = False
    End Sub
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click, Open_But.Click
        'YYJ[2020.1119]ltgen2: remove unused codes - s
        ''This Sub is called by Save if the file has not already created and by SaveAs
        'Me.OpenFileDialog1.InitialDirectory = Refleak_In_UserDocumentsFolder
        'Me.OpenFileDialog1.FileName = ""
        'Me.OpenFileDialog1.DefaultExt = ".xml"
        'Me.OpenFileDialog1.Filter = "(*.xml)|*.xml"
        'Me.OpenFileDialog1.AddExtension = True
        'Me.OpenFileDialog1.ShowDialog()
        'YYJ[2020.1119]ltgen2: remove unused codes - e
    End Sub
    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Me.OpenAnExistingFile(Me.OpenFileDialog1.FileName)
    End Sub
    Private Sub OpenAnExistingFile(ByVal FileNameComplete As String)
        'This subroutine is used by Open an existing fle and by  intial load of either the last or the default files
        Dim FileName As String
        Dim ExtentionLength As Integer
        Dim Children As frmInput
        Me.CloseMDIResult()              'Close any form opened
        Children = Me.ActiveMdiChild
        If My.Computer.FileSystem.FileExists(FileNameComplete) Then
            If Children Is Nothing Then
                Children = New frmInput
                Children.MdiParent = Me
                Children.Show()
            End If

            BordConditions.ReadFile(FileNameComplete)
            BordConditions.Unit = "SI with °C" 'YYJ[2020.0425]ltgen2: override unit

            Children.BordConditionsLocalInstance.LoadFile(FileNameComplete)
            Children.ReadControlVariables()
            Children.FilePathComplete = Me.OpenFileDialog1.FileName
            FileName = My.Computer.FileSystem.GetFileInfo(FileNameComplete).Name
            ExtentionLength = My.Computer.FileSystem.GetFileInfo(FileNameComplete).Extension.Length
            FileName = Strings.Left(FileName, FileName.Length - ExtentionLength)

            'YYJ[2020.0727]ltgen2: change title of the frmInput window as starting time - s
            Children.FileName = "started at: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            'Children.FileName = FileName
            'YYJ[2020.0727]ltgen2: change title of the frmInput window as starting time - e

            Children.Text = Children.FileName

            Children.SetEnabledControls()
            Children.FlagControlFluidOk = True

            Children.ActiveControl = Nothing
        Else
            MsgBox("The file" & FileNameComplete & "does not exist")
        End If
        Me.FlagOPenNewChildren = True
        Me.SetVisibleControls()
        Me.Run_But.Visible = True : Me.AnalyzeToolStripMenuItem.Enabled = True : frmInput.btnAnalyze.Enabled = True

        Me.SetChildrenUnit()
        TypeRefrigerant2 = 1

    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click, Save.Click
        For Each Children As Form In Me.MdiChildren
            If TypeOf Me.ActiveMdiChild Is frmInput Then
                Dim ChildrenInput As frmInput = Children
                If My.Computer.FileSystem.FileExists(ChildrenInput.FilePathComplete) Then
                    ChildrenInput.WriteControlVariables()
                    ChildrenInput.BordConditionsLocalInstance.SaveFile(ChildrenInput.FilePathComplete)
                Else
                    Me.SaveFileAs()
                End If
            End If
        Next
    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        Me.SaveFileAs()
    End Sub
    Private Sub SaveFileAs()
        'YYJ[2020.1119]ltgen2: remove unused codes - s
        ''This Sub is called by Save if the file has not been already created by SaveAs
        'Me.SaveFileDialog1.InitialDirectory = Refleak_In_UserDocumentsFolder
        'Me.SaveFileDialog1.FileName = ""
        'Me.SaveFileDialog1.DefaultExt = ".xml"
        'Me.SaveFileDialog1.Filter = "(*.xml)|*.xml"
        'Me.SaveFileDialog1.AddExtension = True
        'Me.SaveFileDialog1.OverwritePrompt = True
        'Me.SaveFileDialog1.ShowDialog()
        'YYJ[2020.1119]ltgen2: remove unused codes - e
    End Sub
    Private Sub SaveAsDefaultFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsDefaultFileToolStripMenuItem.Click
        Dim Children As frmInput
        If Me.ActiveMdiChild IsNot Nothing Then
            If TypeOf Me.ActiveMdiChild Is frmInput Then
                Children = Me.ActiveMdiChild
                Children.WriteControlVariables()

                'YYJ[2020.1119]ltgen2: make a portable version - s
                Children.BordConditionsLocalInstance.SaveFile(ApplicationFolder & "\Default.xml")
                'Children.BordConditionsLocalInstance.SaveFile(UserApplicationFolder & "\Default.xml")
                'YYJ[2020.1119]ltgen2: make a portable version - e

                MsgBox("The default file has been saved.")
            End If
        End If
    End Sub
    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim FileName As String
        Dim ExtentionLength As Integer
        Dim ChildrenInput As frmInput
        For Each Children As Form In Me.MdiChildren
            If TypeOf Children Is frmInput Then
                ChildrenInput = Children
                Try
                    ChildrenInput.WriteControlVariables()
                    ChildrenInput.BordConditionsLocalInstance.SaveFile(Me.SaveFileDialog1.FileName)
                Catch ex As Exception
                    MsgBox("An error occurred while saving the file")
                End Try
                ChildrenInput.FilePathComplete = Me.SaveFileDialog1.FileName
                'Write the file name- extention in the form text
                FileName = My.Computer.FileSystem.GetFileInfo(Me.SaveFileDialog1.FileName).Name
                ExtentionLength = My.Computer.FileSystem.GetFileInfo(Me.SaveFileDialog1.FileName).Extension.Length
                FileName = Strings.Left(FileName, FileName.Length - ExtentionLength)
                ChildrenInput.FileName = FileName
                Children.Text = ChildrenInput.FileName
            End If
        Next
    End Sub
    Private Sub ReferenceStateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReferenceStateToolStripMenuItem.Click
        Me.Enabled = False
        formRefState.ShowDialog()
        If formRefState.ChangeRefState = True Then
            'Close all the result forms, ad disable the controls
            Me.CloseFormResultOpened()
            Me.SetControlsAsBeforeRunnigSimulation()
        End If
        Me.Enabled = True
    End Sub



    Private Sub StartupPreferencesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartupPreferencesToolStripMenuItem.Click
        Me.Enabled = False
        formPreferences.ShowDialog()
        Me.Enabled = True
    End Sub
    Private Sub SIKelvinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Set SI Unit with K
        BordConditions.Unit = "SI with K"
        Me.SetChildrenUnit()
    End Sub
    Private Sub SIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Set SI Unit with °C
        BordConditions.Unit = "SI with °C"
        Me.SetChildrenUnit()
    End Sub
    Private Sub IPInchPoundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Set SI Unit with K
        BordConditions.Unit = "I-P Inch-Pound"
        Me.SetChildrenUnit()
    End Sub
    Public Sub SetChildrenUnit()
        'Set the units label
        Dim ChildrenInput As frmInput
        For Each Children As Form In Me.MdiChildren
            If TypeOf Children Is frmInput Then
                ChildrenInput = Children
                ChildrenInput.SetUnitLabels()
                ChildrenInput.SetCritT_PUnit()
            End If
        Next
    End Sub

    'Public Sub Analyze()
    '    'Close the results opened forms
    '    Me.CloseFormResultOpened()
    '    Dim ChildrenInput As frmInput

    '    For Each Children As Form In Me.MdiChildren
    '        If TypeOf Children Is frmInput Then
    '            ChildrenInput = Children
    '            ChildrenInput.FlagControlFluidOk2 = 1
    '            ChildrenInput.VerifyInput()
    '            If ChildrenInput.FlagcontrolsOk Then              'Input check ok
    '                ChildrenInput.ControlAndSetUpFluid()
    '                Cursor = Windows.Forms.Cursors.WaitCursor
    '                Me.Run_But.Enabled = False : Me.AnalyzeToolStripMenuItem.Enabled = False : ChildrenInput.btnAnalyze.Enabled = True
    '                'Gestore di thread
    '                If Not BackgroundWorker1.IsBusy Then
    '                    Me.SetControlsAsBeforeRunnigSimulation()
    '                    BackgroundWorker1.RunWorkerAsync()
    '                    'Dim FormWait As New FrmWait
    '                    FrmWait.FormCalling = Me
    '                    'FormWait.ShowDialog()
    '                    FrmWait.Show()
    '                    Me.FlagQuitButPushed = False
    '                End If
    '                ' Uncomment the following lnes to take off the background worker
    '                '    ChildrenInput.CallDllFortran()
    '                'FrmWait.Close()
    '                'Cursor = Windows.Forms.Cursors.Default
    '                'If ChildrenInput.FlagControlPostDataOk Then  'Output check ok
    '                '    Me.SetControlsAfterSimulation()
    '                'End If
    '            End If

    '            'ChildrenInput.CallDllFortran()
    '        Else
    '            Me.Run_But.Enabled = False : Me.AnalyzeToolStripMenuItem.Enabled = False : ChildrenInput.btnAnalyze.Enabled = False
    '        End If

    '    Next

    'End Sub
    'Private Sub Run_But_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click, Run_But.Click
    '    Call Analyze()
    'End Sub
    Private Sub CloseFormResultOpened()
        For Each Children As Form In Me.MdiChildren
            'YYJ[2020.0425]ltgen2: remove 'Chart' logics - s
            'If TypeOf Children Is FrmPrint Then
            '    Children.Close()
            'ElseIf TypeOf Children Is Chart Then
            '    Children.Close()
            'End If
            'YYJ[2020.0425]ltgen2: remove 'Chart' logics - e
        Next Children

        For Each Form As Form In Application.OpenForms
            If TypeOf Form Is FormError Then
                Form.Close()

                'YYJ[2020.0425]ltgen2: remove 'Chart' logics - s
                'ElseIf TypeOf Form Is OptionForChart Then
                '    OptionForChart.Close()
                'YYJ[2020.0425]ltgen2: remove 'Chart' logics - e
            End If

        Next
    End Sub
    Private Sub CloseMDIResult()
        If Me.MdiChildren.Length > 0 Then
            For Each children As Form In Me.MdiChildren
                children.Close()
            Next children
        End If
    End Sub

    'YYJ[2020.0425]ltgen2: remove 'Chart' logics - s
    ''Print
    'Private Sub Print_But_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click, Print_But.Click
    '    FrmPrint.MdiParent = Me
    '    Chart.MdiParent = Me
    '    FrmPrint.FlagRunAtLeastOneSimulation = Me.FlagRunAtLeastOneSimulation
    '    'FrmPrint.Show()
    '    Chart.BringToFront()
    '    FrmPrint.PrintSelection(0)
    'End Sub
    'YYJ[2020.0425]ltgen2: remove 'Chart' logics - e

    'Help
    Private Sub HelpIndexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpIndexToolStripMenuItem.Click, HelpBut.Click
        Dim HelpPath As String = ApplicationFolder & "\Help Files\refleak.chm"
        Help.ShowHelpIndex(Me, HelpPath)
    End Sub
    Private Sub UsingHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsingHelpToolStripMenuItem.Click
        Dim HelpPath As String = ApplicationFolder & "\Help Files\refleak.chm"
        Help.ShowHelp(Me, HelpPath, HelpNavigator.Find, String.Empty)
    End Sub

    'YYJ[2020.0425]ltgen2: remove menubar function
    'Private Sub AboutCYCLEDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutREfleakToolStripMenuItem.Click
    '    Dim FormOpeninginstance As New FormOpening
    '    FormOpeninginstance.CallByInfo = True
    '    Me.Enabled = False
    '    FormOpeninginstance.ShowDialog()
    '    Me.Enabled = True
    'End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.F1
                Me.HelpIndexToolStripMenuItem_Click(Nothing, Nothing)
            Case Else
                Return MyBase.ProcessCmdKey(msg, keyData)
        End Select
        Return True
    End Function
    Private Sub FormMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Update the startap preference file
        BordConditionPreferences.WriteStartupPreferencesFile()
    End Sub
    'Background worker events
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim ChildrenInput As frmInput
        For Each Children As Form In Me.MdiChildren
            If TypeOf Children Is frmInput Then
                ChildrenInput = Children
                If ChildrenInput.FlagcontrolsOk Then
                    ChildrenInput.CallDllFortran()
                End If
            End If
        Next
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'FrmWait.Close()
        Cursor = Windows.Forms.Cursors.Default
        Dim ChildrenInput As frmInput
        Dim Choice As Integer
        For Each Children As Form In Me.MdiChildren
            If TypeOf Children Is frmInput Then
                ChildrenInput = Children
                'Show the error message
                If ChildrenInput.blnError = True Then
                    Choice = MsgBox("The program encountered problems during the simulation." & vbCrLf & "Would you like to view the diagnostic messages?", vbYesNo)
                    If Choice = vbYes Then
                        Dim FormErrorinstance As New FormError
                        FormErrorinstance.ShowDialog()
                    End If
                End If
                If ChildrenInput.FlagControlPostDataOk And Me.FlagQuitButPushed = False Then  'Output check ok
                    Me.SetControlsAfterSimulation()
                End If
                If ChildrenInput.FlagControlPostDataOk = False Then
                    Exit Sub
                End If
                'YYJ[2020.0425]ltgen2: remove 'Chart' logics - s
                ''To update when the post data will be done !!!!!
                'Dim ChartInstance As New Chart
                'ChartInstance.InputChart = ChildrenInput.InputChart
                'With ChildrenInput.PureFld_Mix_FeatureLocalInst
                '    ChartInstance.FluidMixtureClass.SetProperties(.TypeRefrigerant, .FluidsFeature, .MixtureFeature)
                'End With
                'ChartInstance.Show()
                'YYJ[2020.0425]ltgen2: remove 'Chart' logics - e

                ChildrenInput.btnDisplay.Enabled = True
                Me.FlagRunAtLeastOneSimulation = True
                Me.SetControlsAfterSimulation()
            End If
        Next
        Me.AnalyzeToolStripMenuItem.Enabled = True
        Me.Run_But.Enabled = True
    End Sub
    Private Sub CheckFolders()
        'YYJ[2020.0903]ltgen2: make a portable version - s
        If Not Directory.Exists(ApplicationFolder & "\FLUIDS") Then
            MessageBox.Show("'Fluids' folder not found under " & ApplicationFolder, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End If
        If Not Directory.Exists(ApplicationFolder & "\MIXTURES") Then
            MessageBox.Show("'Mixtures' folder not found under " & ApplicationFolder, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End If
        If Not Directory.Exists(ApplicationFolder & "\UserDefinedMixture") Then
            MessageBox.Show("'UserDefinedMixture' folder not found under " & ApplicationFolder, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End If
        'If Not Directory.Exists(UserApplicationFolder & "\FLUIDS") Then 'copy fluids in userapplicationfolder
        '    Try
        '        My.Computer.FileSystem.CopyDirectory(ApplicationFolder & "\FLUIDS", UserApplicationFolder & "\FLUIDS", True)
        '    Catch ex As Exception
        '        MsgBox("unable to copy: """ & UserApplicationFolder & "\FLUIDS" & """ folder")
        '    End Try
        'End If
        'If Not Directory.Exists(UserApplicationFolder & "\MIXTURES") Then 'Copy mixtures in UserApplicationFolder
        '    Try
        '        My.Computer.FileSystem.CopyDirectory(ApplicationFolder & "\MIXTURES", UserApplicationFolder & "\MIXTURES", True)
        '    Catch ex As Exception
        '        MsgBox("Unable to copy: """ & UserApplicationFolder & "\MIXTURES" & """ folder")
        '    End Try
        'End If
        'If Not Directory.Exists(UserApplicationFolder & "\UserDefinedMixture") Then 'Create UserDefinedMixture in UserApplicationFolder
        '    Try
        '        My.Computer.FileSystem.CreateDirectory(UserApplicationFolder & "\UserDefinedMixture")
        '    Catch ex As Exception
        '        MsgBox("Unable to create: """ & UserApplicationFolder & "\UserDefinedMixture" & """ folder")
        '    End Try
        'End If
        'YYJ[2020.0903]ltgen2: make a portable version - e


        'YYJ[2020.0908]ltgen2: make a portable version - s
        If Not File.Exists(ApplicationFolder & "\Last(LtG2).xml") Then
            MessageBox.Show("'Last(LtG2).xml' file not found under " & ApplicationFolder, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End If
        'If Not File.Exists(UserApplicationFolder & "\Last(LtG2).xml") Then '~ & "\Last(LTG).xml") Then
        '    Try
        '        File.Copy(ApplicationFolder & "\Last(LtG2).xml", UserApplicationFolder & "\Last(LtG2).xml") '~ & "\Last(LTG).xml") 
        '    Catch ex As Exception
        '        MsgBox("Unable to copy the default <LAST(LtG2).XML> file used")
        '    End Try
        'End If
        ''If Not File.Exists(UserApplicationFolder & "\StartupPreferences.xml") Then
        ''    Try
        ''        File.Copy(ApplicationFolder & "\StartupPreferences.xml", UserApplicationFolder & "\StartupPreferences.xml")
        ''    Catch ex As Exception
        ''        MsgBox("Unable to copy the default StartupPreferences file")
        ''    End Try
        ''End If
        'YYJ[2020.09083]ltgen2: make a portable version - e
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Application.Exit()
    End Sub

    'YYJ[2020.0425]ltgen2: remove 'Chart' logics - s
    'Private Sub DisplayResultsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DisplayResultsToolStripMenuItem1.Click
    '    Dim FormInput As frmInput = Nothing
    '    For Each Form As Form In Application.OpenForms
    '        If TypeOf Form Is frmInput Then
    '            FormInput = CType(Form, frmInput)
    '            FormInput.btnDisplay_Click(Nothing, Nothing)
    '            Exit For
    '        End If
    '    Next Form
    'End Sub
    'YYJ[2020.0425]ltgen2: remove 'Chart' logics - e

    Private Sub btnDisplay_Click(p1 As Object, p2 As Object)
        Throw New NotImplementedException
    End Sub





    Private Sub ViewMixingParametersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMixingParametersToolStripMenuItem.Click
        If TypeRefrigerant2 = 1 Or TypeRefrigerant2 = 2 Then
            FormMixingParameters.Show()
        Else
            MsgBox("You must select a refrigerant")
            Exit Sub
        End If

    End Sub


    Private Sub UnitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitsToolStripMenuItem.Click
        formUnits.Show()
    End Sub


End Class