<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPureInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPureInfo))
        Me.FluidName = New System.Windows.Forms.Label()
        Me.lblFluid = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.lblCritDens = New System.Windows.Forms.Label()
        Me.lblDensity = New System.Windows.Forms.Label()
        Me.lblCritPress = New System.Windows.Forms.Label()
        Me.lblPressure = New System.Windows.Forms.Label()
        Me.lblCritTemp = New System.Windows.Forms.Label()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.lblNBP = New System.Windows.Forms.Label()
        Me.lblNormalBoilingPoint = New System.Windows.Forms.Label()
        Me.lblWm = New System.Windows.Forms.Label()
        Me.lblMolarMass = New System.Windows.Forms.Label()
        Me.lblCAS = New System.Windows.Forms.Label()
        Me.lblCAS1 = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblFullName1 = New System.Windows.Forms.Label()
        Me.lblChemName = New System.Windows.Forms.Label()
        Me.lblChemicalName = New System.Windows.Forms.Label()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FluidName
        '
        Me.FluidName.AutoSize = True
        Me.FluidName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FluidName.Location = New System.Drawing.Point(24, 24)
        Me.FluidName.Name = "FluidName"
        Me.FluidName.Size = New System.Drawing.Size(72, 13)
        Me.FluidName.TabIndex = 0
        Me.FluidName.Text = "Fluid name:"
        '
        'lblFluid
        '
        Me.lblFluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFluid.Location = New System.Drawing.Point(136, 24)
        Me.lblFluid.Name = "lblFluid"
        Me.lblFluid.Size = New System.Drawing.Size(217, 17)
        Me.lblFluid.TabIndex = 1
        Me.lblFluid.Text = "lblFluid"
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.lblCritDens)
        Me.Frame1.Controls.Add(Me.lblDensity)
        Me.Frame1.Controls.Add(Me.lblCritPress)
        Me.Frame1.Controls.Add(Me.lblPressure)
        Me.Frame1.Controls.Add(Me.lblCritTemp)
        Me.Frame1.Controls.Add(Me.lblTemperature)
        Me.Frame1.Location = New System.Drawing.Point(16, 56)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(345, 105)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Critical Properties"
        '
        'lblCritDens
        '
        Me.lblCritDens.Location = New System.Drawing.Point(120, 78)
        Me.lblCritDens.Name = "lblCritDens"
        Me.lblCritDens.Size = New System.Drawing.Size(217, 17)
        Me.lblCritDens.TabIndex = 8
        Me.lblCritDens.Text = "lblCritDens"
        '
        'lblDensity
        '
        Me.lblDensity.AutoSize = True
        Me.lblDensity.Location = New System.Drawing.Point(8, 78)
        Me.lblDensity.Name = "lblDensity"
        Me.lblDensity.Size = New System.Drawing.Size(45, 13)
        Me.lblDensity.TabIndex = 7
        Me.lblDensity.Text = "Density:"
        '
        'lblCritPress
        '
        Me.lblCritPress.Location = New System.Drawing.Point(120, 52)
        Me.lblCritPress.Name = "lblCritPress"
        Me.lblCritPress.Size = New System.Drawing.Size(217, 17)
        Me.lblCritPress.TabIndex = 6
        Me.lblCritPress.Text = "lblCritPress"
        '
        'lblPressure
        '
        Me.lblPressure.AutoSize = True
        Me.lblPressure.Location = New System.Drawing.Point(8, 52)
        Me.lblPressure.Name = "lblPressure"
        Me.lblPressure.Size = New System.Drawing.Size(51, 13)
        Me.lblPressure.TabIndex = 5
        Me.lblPressure.Text = "Pressure:"
        '
        'lblCritTemp
        '
        Me.lblCritTemp.Location = New System.Drawing.Point(120, 25)
        Me.lblCritTemp.Name = "lblCritTemp"
        Me.lblCritTemp.Size = New System.Drawing.Size(217, 17)
        Me.lblCritTemp.TabIndex = 4
        Me.lblCritTemp.Text = "lblCritTemp"
        '
        'lblTemperature
        '
        Me.lblTemperature.AutoSize = True
        Me.lblTemperature.Location = New System.Drawing.Point(8, 25)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(70, 13)
        Me.lblTemperature.TabIndex = 3
        Me.lblTemperature.Text = "Temperature:"
        '
        'Frame2
        '
        Me.Frame2.Controls.Add(Me.lblNBP)
        Me.Frame2.Controls.Add(Me.lblNormalBoilingPoint)
        Me.Frame2.Controls.Add(Me.lblWm)
        Me.Frame2.Controls.Add(Me.lblMolarMass)
        Me.Frame2.Controls.Add(Me.lblCAS)
        Me.Frame2.Controls.Add(Me.lblCAS1)
        Me.Frame2.Controls.Add(Me.lblFullName)
        Me.Frame2.Controls.Add(Me.lblFullName1)
        Me.Frame2.Controls.Add(Me.lblChemName)
        Me.Frame2.Controls.Add(Me.lblChemicalName)
        Me.Frame2.Location = New System.Drawing.Point(16, 176)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(345, 169)
        Me.Frame2.TabIndex = 9
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Critical Properties"
        '
        'lblNBP
        '
        Me.lblNBP.Location = New System.Drawing.Point(118, 126)
        Me.lblNBP.Name = "lblNBP"
        Me.lblNBP.Size = New System.Drawing.Size(217, 17)
        Me.lblNBP.TabIndex = 12
        Me.lblNBP.Text = "lblNBP"
        '
        'lblNormalBoilingPoint
        '
        Me.lblNormalBoilingPoint.AutoSize = True
        Me.lblNormalBoilingPoint.Location = New System.Drawing.Point(8, 126)
        Me.lblNormalBoilingPoint.Name = "lblNormalBoilingPoint"
        Me.lblNormalBoilingPoint.Size = New System.Drawing.Size(102, 13)
        Me.lblNormalBoilingPoint.TabIndex = 11
        Me.lblNormalBoilingPoint.Text = "Normal boiling point:"
        '
        'lblWm
        '
        Me.lblWm.Location = New System.Drawing.Point(118, 100)
        Me.lblWm.Name = "lblWm"
        Me.lblWm.Size = New System.Drawing.Size(217, 17)
        Me.lblWm.TabIndex = 10
        Me.lblWm.Text = "lblWm"
        '
        'lblMolarMass
        '
        Me.lblMolarMass.AutoSize = True
        Me.lblMolarMass.Location = New System.Drawing.Point(8, 100)
        Me.lblMolarMass.Name = "lblMolarMass"
        Me.lblMolarMass.Size = New System.Drawing.Size(64, 13)
        Me.lblMolarMass.TabIndex = 9
        Me.lblMolarMass.Text = "Molar Mass:"
        '
        'lblCAS
        '
        Me.lblCAS.Location = New System.Drawing.Point(120, 78)
        Me.lblCAS.Name = "lblCAS"
        Me.lblCAS.Size = New System.Drawing.Size(217, 17)
        Me.lblCAS.TabIndex = 8
        Me.lblCAS.Text = "lblCAS"
        '
        'lblCAS1
        '
        Me.lblCAS1.AutoSize = True
        Me.lblCAS1.Location = New System.Drawing.Point(8, 78)
        Me.lblCAS1.Name = "lblCAS1"
        Me.lblCAS1.Size = New System.Drawing.Size(41, 13)
        Me.lblCAS1.TabIndex = 7
        Me.lblCAS1.Text = "CAS #:"
        '
        'lblFullName
        '
        Me.lblFullName.Location = New System.Drawing.Point(120, 52)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(217, 17)
        Me.lblFullName.TabIndex = 6
        Me.lblFullName.Text = "lblFullName"
        '
        'lblFullName1
        '
        Me.lblFullName1.AutoSize = True
        Me.lblFullName1.Location = New System.Drawing.Point(8, 52)
        Me.lblFullName1.Name = "lblFullName1"
        Me.lblFullName1.Size = New System.Drawing.Size(55, 13)
        Me.lblFullName1.TabIndex = 5
        Me.lblFullName1.Text = "Full name:"
        '
        'lblChemName
        '
        Me.lblChemName.Location = New System.Drawing.Point(120, 25)
        Me.lblChemName.Name = "lblChemName"
        Me.lblChemName.Size = New System.Drawing.Size(217, 17)
        Me.lblChemName.TabIndex = 4
        Me.lblChemName.Text = "lblChemName"
        '
        'lblChemicalName
        '
        Me.lblChemicalName.AutoSize = True
        Me.lblChemicalName.Location = New System.Drawing.Point(8, 25)
        Me.lblChemicalName.Name = "lblChemicalName"
        Me.lblChemicalName.Size = New System.Drawing.Size(82, 13)
        Me.lblChemicalName.TabIndex = 3
        Me.lblChemicalName.Text = "Chemical name:"
        '
        'cmdOk
        '
        Me.cmdOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdOk.Location = New System.Drawing.Point(144, 360)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(79, 26)
        Me.cmdOk.TabIndex = 10
        Me.cmdOk.Text = "&OK"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'FormPureInfo
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdOk
        Me.ClientSize = New System.Drawing.Size(376, 399)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.lblFluid)
        Me.Controls.Add(Me.FluidName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPureInfo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fluid Information"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FluidName As System.Windows.Forms.Label
    Friend WithEvents lblFluid As System.Windows.Forms.Label
    Friend WithEvents Frame1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCritDens As System.Windows.Forms.Label
    Friend WithEvents lblDensity As System.Windows.Forms.Label
    Friend WithEvents lblCritPress As System.Windows.Forms.Label
    Friend WithEvents lblPressure As System.Windows.Forms.Label
    Friend WithEvents lblCritTemp As System.Windows.Forms.Label
    Friend WithEvents lblTemperature As System.Windows.Forms.Label
    Friend WithEvents Frame2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNBP As System.Windows.Forms.Label
    Friend WithEvents lblNormalBoilingPoint As System.Windows.Forms.Label
    Friend WithEvents lblWm As System.Windows.Forms.Label
    Friend WithEvents lblMolarMass As System.Windows.Forms.Label
    Friend WithEvents lblCAS As System.Windows.Forms.Label
    Friend WithEvents lblCAS1 As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents lblFullName1 As System.Windows.Forms.Label
    Friend WithEvents lblChemName As System.Windows.Forms.Label
    Friend WithEvents lblChemicalName As System.Windows.Forms.Label
    Friend WithEvents cmdOk As System.Windows.Forms.Button
End Class
