<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.TemperatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PressureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imglstToolbar = New System.Windows.Forms.ImageList(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintSetup = New System.Windows.Forms.PrintDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsDefaultFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReferenceStateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMixingParametersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartupPreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalyzeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayResultsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpIndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsingHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutREfleakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.New_But = New System.Windows.Forms.ToolStripButton()
        Me.Open_But = New System.Windows.Forms.ToolStripButton()
        Me.Save = New System.Windows.Forms.ToolStripButton()
        Me.Print_But = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.Run_But = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpBut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TemperatureToolStripMenuItem
        '
        Me.TemperatureToolStripMenuItem.Name = "TemperatureToolStripMenuItem"
        Me.TemperatureToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TemperatureToolStripMenuItem.Text = "Temperature"
        '
        'PressureToolStripMenuItem
        '
        Me.PressureToolStripMenuItem.Name = "PressureToolStripMenuItem"
        Me.PressureToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PressureToolStripMenuItem.Text = "Pressure"
        '
        'imglstToolbar
        '
        Me.imglstToolbar.ImageStream = CType(resources.GetObject("imglstToolbar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglstToolbar.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.imglstToolbar.Images.SetKeyName(0, "")
        Me.imglstToolbar.Images.SetKeyName(1, "")
        Me.imglstToolbar.Images.SetKeyName(2, "")
        Me.imglstToolbar.Images.SetKeyName(3, "")
        Me.imglstToolbar.Images.SetKeyName(4, "")
        Me.imglstToolbar.Images.SetKeyName(5, "")
        Me.imglstToolbar.Images.SetKeyName(6, "")
        Me.imglstToolbar.Images.SetKeyName(7, "")
        Me.imglstToolbar.Images.SetKeyName(8, "")
        Me.imglstToolbar.Images.SetKeyName(9, "")
        Me.imglstToolbar.Images.SetKeyName(10, "")
        Me.imglstToolbar.Images.SetKeyName(11, "")
        '
        'SaveFileDialog1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintSetup
        '
        Me.PrintSetup.PrintToFile = True
        Me.PrintSetup.UseEXDialog = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.SaveAsDefaultFileToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'SaveAsDefaultFileToolStripMenuItem
        '
        Me.SaveAsDefaultFileToolStripMenuItem.AutoSize = False
        Me.SaveAsDefaultFileToolStripMenuItem.Name = "SaveAsDefaultFileToolStripMenuItem"
        Me.SaveAsDefaultFileToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.SaveAsDefaultFileToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.SaveAsDefaultFileToolStripMenuItem.Text = "Save As Default File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.PrintToolStripMenuItem.Text = "Print..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnitsToolStripMenuItem, Me.ReferenceStateToolStripMenuItem, Me.ViewMixingParametersToolStripMenuItem, Me.StartupPreferencesToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'UnitsToolStripMenuItem
        '
        Me.UnitsToolStripMenuItem.Name = "UnitsToolStripMenuItem"
        Me.UnitsToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.UnitsToolStripMenuItem.Text = "Units"
        '
        'ReferenceStateToolStripMenuItem
        '
        Me.ReferenceStateToolStripMenuItem.Name = "ReferenceStateToolStripMenuItem"
        Me.ReferenceStateToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ReferenceStateToolStripMenuItem.Text = "Reference State..."
        '
        'ViewMixingParametersToolStripMenuItem
        '
        Me.ViewMixingParametersToolStripMenuItem.Name = "ViewMixingParametersToolStripMenuItem"
        Me.ViewMixingParametersToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ViewMixingParametersToolStripMenuItem.Text = "View Mixing Parameters..."
        '
        'StartupPreferencesToolStripMenuItem
        '
        Me.StartupPreferencesToolStripMenuItem.Name = "StartupPreferencesToolStripMenuItem"
        Me.StartupPreferencesToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.StartupPreferencesToolStripMenuItem.Text = "Startup Preferences..."
        '
        'AnalyzeToolStripMenuItem
        '
        Me.AnalyzeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem})
        Me.AnalyzeToolStripMenuItem.Name = "AnalyzeToolStripMenuItem"
        Me.AnalyzeToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AnalyzeToolStripMenuItem.Text = "Analyze"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'DisplayResultsToolStripMenuItem
        '
        Me.DisplayResultsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayResultsToolStripMenuItem1})
        Me.DisplayResultsToolStripMenuItem.Name = "DisplayResultsToolStripMenuItem"
        Me.DisplayResultsToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.DisplayResultsToolStripMenuItem.Text = "Display Results"
        '
        'DisplayResultsToolStripMenuItem1
        '
        Me.DisplayResultsToolStripMenuItem1.Name = "DisplayResultsToolStripMenuItem1"
        Me.DisplayResultsToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.DisplayResultsToolStripMenuItem1.Text = "Display Results"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpIndexToolStripMenuItem, Me.UsingHelpToolStripMenuItem, Me.AboutREfleakToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpIndexToolStripMenuItem
        '
        Me.HelpIndexToolStripMenuItem.Name = "HelpIndexToolStripMenuItem"
        Me.HelpIndexToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.HelpIndexToolStripMenuItem.Text = "Help Index..."
        '
        'UsingHelpToolStripMenuItem
        '
        Me.UsingHelpToolStripMenuItem.Name = "UsingHelpToolStripMenuItem"
        Me.UsingHelpToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.UsingHelpToolStripMenuItem.Text = "Using Help..."
        '
        'AboutREfleakToolStripMenuItem
        '
        Me.AboutREfleakToolStripMenuItem.Name = "AboutREfleakToolStripMenuItem"
        Me.AboutREfleakToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.AboutREfleakToolStripMenuItem.Text = "About Refleak..."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.AnalyzeToolStripMenuItem, Me.DisplayResultsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(975, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'New_But
        '
        Me.New_But.AutoSize = False
        Me.New_But.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.New_But.Image = CType(resources.GetObject("New_But.Image"), System.Drawing.Image)
        Me.New_But.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.New_But.Name = "New_But"
        Me.New_But.Size = New System.Drawing.Size(25, 25)
        Me.New_But.Text = "&New"
        '
        'Open_But
        '
        Me.Open_But.AutoSize = False
        Me.Open_But.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Open_But.Image = CType(resources.GetObject("Open_But.Image"), System.Drawing.Image)
        Me.Open_But.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Open_But.Name = "Open_But"
        Me.Open_But.Size = New System.Drawing.Size(25, 25)
        Me.Open_But.Text = "&Open"
        '
        'Save
        '
        Me.Save.AutoSize = False
        Me.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Save.Image = CType(resources.GetObject("Save.Image"), System.Drawing.Image)
        Me.Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(25, 25)
        Me.Save.Text = "&Save"
        '
        'Print_But
        '
        Me.Print_But.AutoSize = False
        Me.Print_But.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Print_But.Image = CType(resources.GetObject("Print_But.Image"), System.Drawing.Image)
        Me.Print_But.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Print_But.Name = "Print_But"
        Me.Print_But.Size = New System.Drawing.Size(25, 25)
        Me.Print_But.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 28)
        '
        'Run_But
        '
        Me.Run_But.AutoSize = False
        Me.Run_But.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Run_But.Image = CType(resources.GetObject("Run_But.Image"), System.Drawing.Image)
        Me.Run_But.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Run_But.Name = "Run_But"
        Me.Run_But.Size = New System.Drawing.Size(25, 25)
        Me.Run_But.Text = "Run simulation"
        Me.Run_But.ToolTipText = "Analyze"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 28)
        '
        'HelpBut
        '
        Me.HelpBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpBut.Image = CType(resources.GetObject("HelpBut.Image"), System.Drawing.Image)
        Me.HelpBut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpBut.Name = "HelpBut"
        Me.HelpBut.Size = New System.Drawing.Size(23, 25)
        Me.HelpBut.Text = "&Help"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.New_But, Me.Open_But, Me.Save, Me.Print_But, Me.toolStripSeparator, Me.Run_But, Me.toolStripSeparator3, Me.HelpBut})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(975, 28)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.Visible = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 627)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thermophysical Property Look-up Table Generator for EVAP-COND 5.0 (Last Updated: " &
    "2020-11-19)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents imglstToolbar As System.Windows.Forms.ImageList
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TemperatureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PressureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSetup As System.Windows.Forms.PrintDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsDefaultFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnitsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReferenceStateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewMixingParametersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartupPreferencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnalyzeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayResultsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayResultsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpIndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsingHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutREfleakToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents New_But As ToolStripButton
    Friend WithEvents Open_But As ToolStripButton
    Friend WithEvents Save As ToolStripButton
    Friend WithEvents Print_But As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents Run_But As ToolStripButton
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents HelpBut As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
End Class
