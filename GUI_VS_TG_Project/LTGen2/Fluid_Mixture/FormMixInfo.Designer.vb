<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMixInfo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMixInfo))
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.lblCritDens = New System.Windows.Forms.Label()
        Me.lblDensity = New System.Windows.Forms.Label()
        Me.lblCritPress = New System.Windows.Forms.Label()
        Me.lblPressure = New System.Windows.Forms.Label()
        Me.lblCritTemp = New System.Windows.Forms.Label()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.lblFluid = New System.Windows.Forms.Label()
        Me.FluidName = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.GridComposition = New System.Windows.Forms.DataGridView()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.GridComposition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdOk.Location = New System.Drawing.Point(140, 425)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(92, 30)
        Me.cmdOk.TabIndex = 0
        Me.cmdOk.Text = "&OK"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.lblCritDens)
        Me.Frame1.Controls.Add(Me.lblDensity)
        Me.Frame1.Controls.Add(Me.lblCritPress)
        Me.Frame1.Controls.Add(Me.lblPressure)
        Me.Frame1.Controls.Add(Me.lblCritTemp)
        Me.Frame1.Controls.Add(Me.lblTemperature)
        Me.Frame1.Location = New System.Drawing.Point(19, 55)
        Me.Frame1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Frame1.Size = New System.Drawing.Size(337, 121)
        Me.Frame1.TabIndex = 8
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Estimated critical properties"
        '
        'lblCritDens
        '
        Me.lblCritDens.Location = New System.Drawing.Point(140, 90)
        Me.lblCritDens.Name = "lblCritDens"
        Me.lblCritDens.Size = New System.Drawing.Size(190, 20)
        Me.lblCritDens.TabIndex = 8
        Me.lblCritDens.Text = "lblCritDens"
        '
        'lblDensity
        '
        Me.lblDensity.AutoSize = True
        Me.lblDensity.Location = New System.Drawing.Point(9, 90)
        Me.lblDensity.Name = "lblDensity"
        Me.lblDensity.Size = New System.Drawing.Size(51, 15)
        Me.lblDensity.TabIndex = 7
        Me.lblDensity.Text = "Density:"
        '
        'lblCritPress
        '
        Me.lblCritPress.Location = New System.Drawing.Point(140, 60)
        Me.lblCritPress.Name = "lblCritPress"
        Me.lblCritPress.Size = New System.Drawing.Size(190, 20)
        Me.lblCritPress.TabIndex = 6
        Me.lblCritPress.Text = "lblCritPress"
        '
        'lblPressure
        '
        Me.lblPressure.AutoSize = True
        Me.lblPressure.Location = New System.Drawing.Point(9, 60)
        Me.lblPressure.Name = "lblPressure"
        Me.lblPressure.Size = New System.Drawing.Size(61, 15)
        Me.lblPressure.TabIndex = 5
        Me.lblPressure.Text = "Pressure:"
        '
        'lblCritTemp
        '
        Me.lblCritTemp.Location = New System.Drawing.Point(140, 29)
        Me.lblCritTemp.Name = "lblCritTemp"
        Me.lblCritTemp.Size = New System.Drawing.Size(190, 20)
        Me.lblCritTemp.TabIndex = 4
        Me.lblCritTemp.Text = "lblCritTemp"
        '
        'lblTemperature
        '
        Me.lblTemperature.AutoSize = True
        Me.lblTemperature.Location = New System.Drawing.Point(9, 29)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(80, 15)
        Me.lblTemperature.TabIndex = 3
        Me.lblTemperature.Text = "Temperature:"
        '
        'lblFluid
        '
        Me.lblFluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFluid.Location = New System.Drawing.Point(152, 19)
        Me.lblFluid.Name = "lblFluid"
        Me.lblFluid.Size = New System.Drawing.Size(216, 20)
        Me.lblFluid.TabIndex = 10
        Me.lblFluid.Text = "lblFluid"
        '
        'FluidName
        '
        Me.FluidName.AutoSize = True
        Me.FluidName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FluidName.Location = New System.Drawing.Point(28, 19)
        Me.FluidName.Name = "FluidName"
        Me.FluidName.Size = New System.Drawing.Size(72, 13)
        Me.FluidName.TabIndex = 9
        Me.FluidName.Text = "Fluid name:"
        '
        'Frame2
        '
        Me.Frame2.Controls.Add(Me.GridComposition)
        Me.Frame2.Location = New System.Drawing.Point(19, 194)
        Me.Frame2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Frame2.Size = New System.Drawing.Size(337, 186)
        Me.Frame2.TabIndex = 11
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Components and composition"
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
        Me.GridComposition.Location = New System.Drawing.Point(13, 29)
        Me.GridComposition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridComposition.Name = "GridComposition"
        Me.GridComposition.RowHeadersVisible = False
        Me.GridComposition.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.GridComposition.Size = New System.Drawing.Size(306, 150)
        Me.GridComposition.TabIndex = 2
        '
        'FormMixInfo
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdOk
        Me.ClientSize = New System.Drawing.Size(378, 472)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.lblFluid)
        Me.Controls.Add(Me.FluidName)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdOk)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMixInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blend Information"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        CType(Me.GridComposition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents Frame1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCritDens As System.Windows.Forms.Label
    Friend WithEvents lblDensity As System.Windows.Forms.Label
    Friend WithEvents lblCritPress As System.Windows.Forms.Label
    Friend WithEvents lblPressure As System.Windows.Forms.Label
    Friend WithEvents lblCritTemp As System.Windows.Forms.Label
    Friend WithEvents lblTemperature As System.Windows.Forms.Label
    Friend WithEvents lblFluid As System.Windows.Forms.Label
    Friend WithEvents FluidName As System.Windows.Forms.Label
    Friend WithEvents Frame2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridComposition As System.Windows.Forms.DataGridView
End Class
