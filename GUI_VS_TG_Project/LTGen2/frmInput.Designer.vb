<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInput
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInput))
        Me.lblSelRef = New System.Windows.Forms.Label()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdGen = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.nudH = New System.Windows.Forms.NumericUpDown()
        Me.nudP = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbtScale2 = New System.Windows.Forms.RadioButton()
        Me.rbtScale1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLP = New System.Windows.Forms.TextBox()
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fraChangeRefrigerant = New System.Windows.Forms.GroupBox()
        Me.cmdDefineNewMixture = New System.Windows.Forms.Button()
        Me.cmdPreDefPureFld = New System.Windows.Forms.Button()
        Me.cmdPredefinedMixture = New System.Windows.Forms.Button()
        Me.frameRefrig = New System.Windows.Forms.GroupBox()
        Me.REfNameLBL = New System.Windows.Forms.Label()
        Me.CritPLBL = New System.Windows.Forms.Label()
        Me.CritTLBL = New System.Windows.Forms.Label()
        Me.lblUnitPressure = New System.Windows.Forms.Label()
        Me.lblUnitTemp = New System.Windows.Forms.Label()
        Me.frmComponents = New System.Windows.Forms.GroupBox()
        Me.GridComposition = New System.Windows.Forms.DataGridView()
        Me.lblCritP = New System.Windows.Forms.Label()
        Me.lblCriticalTemperature = New System.Windows.Forms.Label()
        Me.lblRefNameOutTab = New System.Windows.Forms.Label()
        Me.ToolTip_UADp = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkLiquid = New System.Windows.Forms.CheckBox()
        Me.chkVapor = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnAnalyze = New System.Windows.Forms.Button()
        Me.btnViewMixing = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tabMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.nudH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.fraChangeRefrigerant.SuspendLayout()
        Me.frameRefrig.SuspendLayout()
        Me.frmComponents.SuspendLayout()
        CType(Me.GridComposition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelRef
        '
        Me.lblSelRef.AutoSize = True
        Me.lblSelRef.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelRef.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSelRef.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblSelRef.Location = New System.Drawing.Point(10, 32)
        Me.lblSelRef.Name = "lblSelRef"
        Me.lblSelRef.Size = New System.Drawing.Size(58, 15)
        Me.lblSelRef.TabIndex = 3
        Me.lblSelRef.Text = "Selected:"
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.TabPage1)
        Me.tabMain.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.ItemSize = New System.Drawing.Size(62, 27)
        Me.tabMain.Location = New System.Drawing.Point(12, 0)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(772, 571)
        Me.tabMain.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.CausesValidation = False
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.cmdSave)
        Me.TabPage1.Controls.Add(Me.cmdGen)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.fraChangeRefrigerant)
        Me.TabPage1.Controls.Add(Me.frameRefrig)
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(764, 536)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Look-up Table Generator v.2"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(522, 467)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(149, 40)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "&Exit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(115, 467)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(149, 40)
        Me.cmdSave.TabIndex = 17
        Me.cmdSave.Text = "&Save Table Parameters"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdGen
        '
        Me.cmdGen.Enabled = False
        Me.cmdGen.Location = New System.Drawing.Point(317, 467)
        Me.cmdGen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdGen.Name = "cmdGen"
        Me.cmdGen.Size = New System.Drawing.Size(149, 40)
        Me.cmdGen.TabIndex = 15
        Me.cmdGen.Text = "&Generate Table"
        Me.cmdGen.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.nudH)
        Me.GroupBox5.Controls.Add(Me.nudP)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(456, 328)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(215, 109)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Number of Levels"
        '
        'nudH
        '
        Me.nudH.Location = New System.Drawing.Point(104, 68)
        Me.nudH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudH.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudH.Name = "nudH"
        Me.nudH.Size = New System.Drawing.Size(72, 21)
        Me.nudH.TabIndex = 3
        Me.nudH.Value = New Decimal(New Integer() {48, 0, 0, 0})
        '
        'nudP
        '
        Me.nudP.Location = New System.Drawing.Point(104, 32)
        Me.nudP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudP.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.nudP.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudP.Name = "nudP"
        Me.nudP.Size = New System.Drawing.Size(72, 21)
        Me.nudP.TabIndex = 2
        Me.nudP.Value = New Decimal(New Integer() {49, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Enthalpy"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Pressure"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbtScale2)
        Me.GroupBox6.Controls.Add(Me.rbtScale1)
        Me.GroupBox6.Location = New System.Drawing.Point(490, 483)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(205, 109)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Coordinate of Pressure"
        Me.GroupBox6.Visible = False
        '
        'rbtScale2
        '
        Me.rbtScale2.AutoSize = True
        Me.rbtScale2.Location = New System.Drawing.Point(47, 71)
        Me.rbtScale2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbtScale2.Name = "rbtScale2"
        Me.rbtScale2.Size = New System.Drawing.Size(90, 19)
        Me.rbtScale2.TabIndex = 1
        Me.rbtScale2.Text = "Logarithmic"
        Me.rbtScale2.UseVisualStyleBackColor = True
        '
        'rbtScale1
        '
        Me.rbtScale1.AutoSize = True
        Me.rbtScale1.Checked = True
        Me.rbtScale1.Location = New System.Drawing.Point(47, 35)
        Me.rbtScale1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbtScale1.Name = "rbtScale1"
        Me.rbtScale1.Size = New System.Drawing.Size(60, 19)
        Me.rbtScale1.TabIndex = 0
        Me.rbtScale1.TabStop = True
        Me.rbtScale1.Text = "Linear"
        Me.rbtScale1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtLP)
        Me.GroupBox4.Controls.Add(Me.txtHP)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(115, 327)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(228, 110)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pressure Limits"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(192, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "kPa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "kPa"
        '
        'txtLP
        '
        Me.txtLP.Location = New System.Drawing.Point(125, 67)
        Me.txtLP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLP.Name = "txtLP"
        Me.txtLP.Size = New System.Drawing.Size(57, 21)
        Me.txtLP.TabIndex = 3
        '
        'txtHP
        '
        Me.txtHP.Location = New System.Drawing.Point(125, 27)
        Me.txtHP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(57, 21)
        Me.txtHP.TabIndex = 2
        Me.txtHP.Text = "999999"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Low Pressure"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "High Pressure"
        '
        'fraChangeRefrigerant
        '
        Me.fraChangeRefrigerant.Controls.Add(Me.cmdDefineNewMixture)
        Me.fraChangeRefrigerant.Controls.Add(Me.cmdPreDefPureFld)
        Me.fraChangeRefrigerant.Controls.Add(Me.cmdPredefinedMixture)
        Me.fraChangeRefrigerant.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraChangeRefrigerant.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraChangeRefrigerant.Location = New System.Drawing.Point(15, 15)
        Me.fraChangeRefrigerant.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.fraChangeRefrigerant.Name = "fraChangeRefrigerant"
        Me.fraChangeRefrigerant.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.fraChangeRefrigerant.Size = New System.Drawing.Size(214, 291)
        Me.fraChangeRefrigerant.TabIndex = 0
        Me.fraChangeRefrigerant.TabStop = False
        Me.fraChangeRefrigerant.Text = "Selection"
        '
        'cmdDefineNewMixture
        '
        Me.cmdDefineNewMixture.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDefineNewMixture.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDefineNewMixture.Location = New System.Drawing.Point(37, 210)
        Me.cmdDefineNewMixture.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDefineNewMixture.Name = "cmdDefineNewMixture"
        Me.cmdDefineNewMixture.Size = New System.Drawing.Size(140, 55)
        Me.cmdDefineNewMixture.TabIndex = 5
        Me.cmdDefineNewMixture.Text = "&Define New Blend"
        Me.cmdDefineNewMixture.UseVisualStyleBackColor = True
        '
        'cmdPreDefPureFld
        '
        Me.cmdPreDefPureFld.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPreDefPureFld.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPreDefPureFld.Location = New System.Drawing.Point(37, 32)
        Me.cmdPreDefPureFld.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPreDefPureFld.Name = "cmdPreDefPureFld"
        Me.cmdPreDefPureFld.Size = New System.Drawing.Size(140, 55)
        Me.cmdPreDefPureFld.TabIndex = 4
        Me.cmdPreDefPureFld.Text = "Single-Compound &Fluid"
        Me.cmdPreDefPureFld.UseVisualStyleBackColor = True
        '
        'cmdPredefinedMixture
        '
        Me.cmdPredefinedMixture.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPredefinedMixture.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPredefinedMixture.Location = New System.Drawing.Point(37, 121)
        Me.cmdPredefinedMixture.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPredefinedMixture.Name = "cmdPredefinedMixture"
        Me.cmdPredefinedMixture.Size = New System.Drawing.Size(140, 55)
        Me.cmdPredefinedMixture.TabIndex = 1
        Me.cmdPredefinedMixture.Text = "Predefined &Blend"
        Me.cmdPredefinedMixture.UseVisualStyleBackColor = True
        '
        'frameRefrig
        '
        Me.frameRefrig.AutoSize = True
        Me.frameRefrig.Controls.Add(Me.REfNameLBL)
        Me.frameRefrig.Controls.Add(Me.CritPLBL)
        Me.frameRefrig.Controls.Add(Me.CritTLBL)
        Me.frameRefrig.Controls.Add(Me.lblSelRef)
        Me.frameRefrig.Controls.Add(Me.lblUnitPressure)
        Me.frameRefrig.Controls.Add(Me.lblUnitTemp)
        Me.frameRefrig.Controls.Add(Me.frmComponents)
        Me.frameRefrig.Controls.Add(Me.lblCritP)
        Me.frameRefrig.Controls.Add(Me.lblCriticalTemperature)
        Me.frameRefrig.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frameRefrig.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frameRefrig.Location = New System.Drawing.Point(252, 15)
        Me.frameRefrig.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.frameRefrig.Name = "frameRefrig"
        Me.frameRefrig.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.frameRefrig.Size = New System.Drawing.Size(487, 291)
        Me.frameRefrig.TabIndex = 3
        Me.frameRefrig.TabStop = False
        Me.frameRefrig.Text = " Information "
        '
        'REfNameLBL
        '
        Me.REfNameLBL.AutoSize = True
        Me.REfNameLBL.BackColor = System.Drawing.Color.Transparent
        Me.REfNameLBL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REfNameLBL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.REfNameLBL.Location = New System.Drawing.Point(131, 32)
        Me.REfNameLBL.Name = "REfNameLBL"
        Me.REfNameLBL.Size = New System.Drawing.Size(0, 15)
        Me.REfNameLBL.TabIndex = 13
        Me.REfNameLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CritPLBL
        '
        Me.CritPLBL.BackColor = System.Drawing.Color.Transparent
        Me.CritPLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CritPLBL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CritPLBL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CritPLBL.Location = New System.Drawing.Point(361, 121)
        Me.CritPLBL.Name = "CritPLBL"
        Me.CritPLBL.Size = New System.Drawing.Size(82, 23)
        Me.CritPLBL.TabIndex = 12
        Me.CritPLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CritPLBL.Visible = False
        '
        'CritTLBL
        '
        Me.CritTLBL.BackColor = System.Drawing.Color.Transparent
        Me.CritTLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CritTLBL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CritTLBL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CritTLBL.Location = New System.Drawing.Point(361, 83)
        Me.CritTLBL.Name = "CritTLBL"
        Me.CritTLBL.Size = New System.Drawing.Size(82, 23)
        Me.CritTLBL.TabIndex = 11
        Me.CritTLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CritTLBL.Visible = False
        '
        'lblUnitPressure
        '
        Me.lblUnitPressure.AccessibleDescription = " "
        Me.lblUnitPressure.AutoSize = True
        Me.lblUnitPressure.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitPressure.ForeColor = System.Drawing.Color.Silver
        Me.lblUnitPressure.Location = New System.Drawing.Point(451, 121)
        Me.lblUnitPressure.Name = "lblUnitPressure"
        Me.lblUnitPressure.Size = New System.Drawing.Size(30, 15)
        Me.lblUnitPressure.TabIndex = 10
        Me.lblUnitPressure.Text = "KPa"
        Me.lblUnitPressure.Visible = False
        '
        'lblUnitTemp
        '
        Me.lblUnitTemp.AutoSize = True
        Me.lblUnitTemp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitTemp.ForeColor = System.Drawing.Color.Silver
        Me.lblUnitTemp.Location = New System.Drawing.Point(445, 83)
        Me.lblUnitTemp.Name = "lblUnitTemp"
        Me.lblUnitTemp.Size = New System.Drawing.Size(21, 15)
        Me.lblUnitTemp.TabIndex = 9
        Me.lblUnitTemp.Text = "°C"
        Me.lblUnitTemp.Visible = False
        '
        'frmComponents
        '
        Me.frmComponents.Controls.Add(Me.GridComposition)
        Me.frmComponents.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmComponents.Location = New System.Drawing.Point(13, 68)
        Me.frmComponents.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.frmComponents.Name = "frmComponents"
        Me.frmComponents.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.frmComponents.Size = New System.Drawing.Size(342, 194)
        Me.frmComponents.TabIndex = 8
        Me.frmComponents.TabStop = False
        Me.frmComponents.Text = "Blend composition"
        '
        'GridComposition
        '
        Me.GridComposition.AllowUserToAddRows = False
        Me.GridComposition.AllowUserToDeleteRows = False
        Me.GridComposition.AllowUserToResizeColumns = False
        Me.GridComposition.AllowUserToResizeRows = False
        Me.GridComposition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridComposition.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridComposition.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridComposition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridComposition.DefaultCellStyle = DataGridViewCellStyle2
        Me.GridComposition.Enabled = False
        Me.GridComposition.Location = New System.Drawing.Point(18, 31)
        Me.GridComposition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridComposition.Name = "GridComposition"
        Me.GridComposition.RowHeadersVisible = False
        Me.GridComposition.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.GridComposition.Size = New System.Drawing.Size(288, 136)
        Me.GridComposition.TabIndex = 1
        Me.GridComposition.TabStop = False
        '
        'lblCritP
        '
        Me.lblCritP.AutoSize = True
        Me.lblCritP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCritP.ForeColor = System.Drawing.Color.Silver
        Me.lblCritP.Location = New System.Drawing.Point(358, 108)
        Me.lblCritP.Name = "lblCritP"
        Me.lblCritP.Size = New System.Drawing.Size(101, 15)
        Me.lblCritP.TabIndex = 6
        Me.lblCritP.Text = "Critical pressure:"
        Me.lblCritP.Visible = False
        '
        'lblCriticalTemperature
        '
        Me.lblCriticalTemperature.AutoSize = True
        Me.lblCriticalTemperature.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriticalTemperature.ForeColor = System.Drawing.Color.Silver
        Me.lblCriticalTemperature.Location = New System.Drawing.Point(358, 68)
        Me.lblCriticalTemperature.Name = "lblCriticalTemperature"
        Me.lblCriticalTemperature.Size = New System.Drawing.Size(118, 15)
        Me.lblCriticalTemperature.TabIndex = 4
        Me.lblCriticalTemperature.Text = "Critical temperature:"
        Me.lblCriticalTemperature.Visible = False
        '
        'lblRefNameOutTab
        '
        Me.lblRefNameOutTab.AutoSize = True
        Me.lblRefNameOutTab.BackColor = System.Drawing.Color.Transparent
        Me.lblRefNameOutTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRefNameOutTab.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefNameOutTab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRefNameOutTab.Location = New System.Drawing.Point(164, 0)
        Me.lblRefNameOutTab.Name = "lblRefNameOutTab"
        Me.lblRefNameOutTab.Size = New System.Drawing.Size(2, 17)
        Me.lblRefNameOutTab.TabIndex = 14
        Me.lblRefNameOutTab.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblRefNameOutTab.Visible = False
        '
        'ToolTip_UADp
        '
        Me.ToolTip_UADp.AutoPopDelay = 5000
        Me.ToolTip_UADp.InitialDelay = 200
        Me.ToolTip_UADp.ReshowDelay = 100
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkLiquid)
        Me.Panel1.Controls.Add(Me.chkVapor)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnDisplay)
        Me.Panel1.Controls.Add(Me.btnAnalyze)
        Me.Panel1.Controls.Add(Me.btnViewMixing)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(873, 62)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(131, 457)
        Me.Panel1.TabIndex = 5
        Me.Panel1.Visible = False
        '
        'chkLiquid
        '
        Me.chkLiquid.AutoSize = True
        Me.chkLiquid.Checked = True
        Me.chkLiquid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLiquid.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLiquid.Location = New System.Drawing.Point(34, 346)
        Me.chkLiquid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkLiquid.Name = "chkLiquid"
        Me.chkLiquid.Size = New System.Drawing.Size(60, 19)
        Me.chkLiquid.TabIndex = 6
        Me.chkLiquid.TabStop = False
        Me.chkLiquid.Text = "Liquid"
        Me.chkLiquid.UseVisualStyleBackColor = True
        '
        'chkVapor
        '
        Me.chkVapor.AutoSize = True
        Me.chkVapor.Checked = True
        Me.chkVapor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVapor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVapor.Location = New System.Drawing.Point(34, 326)
        Me.chkVapor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkVapor.Name = "chkVapor"
        Me.chkVapor.Size = New System.Drawing.Size(57, 19)
        Me.chkVapor.TabIndex = 5
        Me.chkVapor.TabStop = False
        Me.chkVapor.Text = "Vapor"
        Me.chkVapor.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(22, 408)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 26)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(22, 259)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(90, 61)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Display &Results"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnalyze.Location = New System.Drawing.Point(22, 185)
        Me.btnAnalyze.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(90, 26)
        Me.btnAnalyze.TabIndex = 2
        Me.btnAnalyze.Text = "&Analyze"
        Me.btnAnalyze.UseVisualStyleBackColor = True
        '
        'btnViewMixing
        '
        Me.btnViewMixing.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewMixing.Location = New System.Drawing.Point(22, 92)
        Me.btnViewMixing.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnViewMixing.Name = "btnViewMixing"
        Me.btnViewMixing.Size = New System.Drawing.Size(90, 54)
        Me.btnViewMixing.TabIndex = 1
        Me.btnViewMixing.Text = "&View Mixing Parameters"
        Me.btnViewMixing.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(22, 26)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Units"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 575)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblRefNameOutTab)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInput"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "LtGen2 "
        Me.tabMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.nudH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.fraChangeRefrigerant.ResumeLayout(False)
        Me.frameRefrig.ResumeLayout(False)
        Me.frameRefrig.PerformLayout()
        Me.frmComponents.ResumeLayout(False)
        CType(Me.GridComposition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelRef As System.Windows.Forms.Label
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents frameRefrig As System.Windows.Forms.GroupBox
    Friend WithEvents frmComponents As System.Windows.Forms.GroupBox
    Friend WithEvents lblCritP As System.Windows.Forms.Label
    Friend WithEvents lblCriticalTemperature As System.Windows.Forms.Label
    Friend WithEvents fraChangeRefrigerant As System.Windows.Forms.GroupBox
    Friend WithEvents GridComposition As System.Windows.Forms.DataGridView
    Friend WithEvents lblUnitPressure As System.Windows.Forms.Label
    Friend WithEvents lblUnitTemp As System.Windows.Forms.Label
    Friend WithEvents CritTLBL As System.Windows.Forms.Label
    Friend WithEvents CritPLBL As System.Windows.Forms.Label
    Friend WithEvents REfNameLBL As System.Windows.Forms.Label
    Friend WithEvents lblRefNameOutTab As System.Windows.Forms.Label
    Friend WithEvents ToolTip_UADp As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnViewMixing As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkLiquid As System.Windows.Forms.CheckBox
    Friend WithEvents chkVapor As System.Windows.Forms.CheckBox
    Friend WithEvents btnAnalyze As System.Windows.Forms.Button
    Friend WithEvents cmdPredefinedMixture As Button
    Friend WithEvents cmdPreDefPureFld As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdGen As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents rbtScale2 As RadioButton
    Friend WithEvents rbtScale1 As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents nudH As NumericUpDown
    Friend WithEvents nudP As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLP As TextBox
    Friend WithEvents txtHP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdDefineNewMixture As Button
End Class
