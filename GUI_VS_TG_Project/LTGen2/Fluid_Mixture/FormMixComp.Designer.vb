<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMixComp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMixComp))
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdStore = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblBlendName = New System.Windows.Forms.Label()
        Me.TextAddress = New System.Windows.Forms.TextBox()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.comboFraction = New System.Windows.Forms.ComboBox()
        Me.GridComposition = New System.Windows.Forms.DataGridView()
        Me.frm2 = New System.Windows.Forms.GroupBox()
        Me.TextSum = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.GridComposition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frm2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(146, 422)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(92, 36)
        Me.cmdOk.TabIndex = 2
        Me.cmdOk.Text = "&OK"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdStore
        '
        Me.cmdStore.Location = New System.Drawing.Point(13, 422)
        Me.cmdStore.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdStore.Name = "cmdStore"
        Me.cmdStore.Size = New System.Drawing.Size(92, 36)
        Me.cmdStore.TabIndex = 4
        Me.cmdStore.Text = "&Store"
        Me.cmdStore.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(266, 422)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(92, 36)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'lblBlendName
        '
        Me.lblBlendName.AutoSize = True
        Me.lblBlendName.Location = New System.Drawing.Point(14, 10)
        Me.lblBlendName.Name = "lblBlendName"
        Me.lblBlendName.Size = New System.Drawing.Size(79, 15)
        Me.lblBlendName.TabIndex = 7
        Me.lblBlendName.Text = "Blend Name:"
        '
        'TextAddress
        '
        Me.TextAddress.Location = New System.Drawing.Point(100, 8)
        Me.TextAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextAddress.Name = "TextAddress"
        Me.TextAddress.Size = New System.Drawing.Size(258, 21)
        Me.TextAddress.TabIndex = 0
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(10, 30)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(36, 15)
        Me.lblSum.TabIndex = 3
        Me.lblSum.Text = "Sum:"
        '
        'comboFraction
        '
        Me.comboFraction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboFraction.FormattingEnabled = True
        Me.comboFraction.Items.AddRange(New Object() {"Mass Fraction", "Mole Fraction"})
        Me.comboFraction.Location = New System.Drawing.Point(208, 26)
        Me.comboFraction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.comboFraction.Name = "comboFraction"
        Me.comboFraction.Size = New System.Drawing.Size(112, 23)
        Me.comboFraction.TabIndex = 1
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
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridComposition.DefaultCellStyle = DataGridViewCellStyle2
        Me.GridComposition.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.GridComposition.Location = New System.Drawing.Point(26, 66)
        Me.GridComposition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridComposition.MultiSelect = False
        Me.GridComposition.Name = "GridComposition"
        Me.GridComposition.RowHeadersVisible = False
        Me.GridComposition.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.GridComposition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridComposition.Size = New System.Drawing.Size(294, 150)
        Me.GridComposition.StandardTab = True
        Me.GridComposition.TabIndex = 2
        '
        'frm2
        '
        Me.frm2.Controls.Add(Me.TextSum)
        Me.frm2.Controls.Add(Me.GridComposition)
        Me.frm2.Controls.Add(Me.comboFraction)
        Me.frm2.Controls.Add(Me.lblSum)
        Me.frm2.Location = New System.Drawing.Point(14, 38)
        Me.frm2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.frm2.Name = "frm2"
        Me.frm2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.frm2.Size = New System.Drawing.Size(337, 278)
        Me.frm2.TabIndex = 1
        Me.frm2.TabStop = False
        Me.frm2.Text = "&Components and composition"
        '
        'TextSum
        '
        Me.TextSum.BackColor = System.Drawing.Color.Transparent
        Me.TextSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextSum.Location = New System.Drawing.Point(53, 25)
        Me.TextSum.Name = "TextSum"
        Me.TextSum.Size = New System.Drawing.Size(82, 23)
        Me.TextSum.TabIndex = 0
        Me.TextSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormMixComp
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(373, 478)
        Me.Controls.Add(Me.frm2)
        Me.Controls.Add(Me.TextAddress)
        Me.Controls.Add(Me.lblBlendName)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdStore)
        Me.Controls.Add(Me.cmdCancel)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMixComp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Specify Blend Composition"
        CType(Me.GridComposition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frm2.ResumeLayout(False)
        Me.frm2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdStore As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents lblBlendName As System.Windows.Forms.Label
    Friend WithEvents TextAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents comboFraction As System.Windows.Forms.ComboBox
    Friend WithEvents GridComposition As System.Windows.Forms.DataGridView
    Friend WithEvents frm2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextSum As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
