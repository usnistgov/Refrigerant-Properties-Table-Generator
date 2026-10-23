<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDefine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formDefine))
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lstAvailable = New System.Windows.Forms.ListBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.lstSelected = New System.Windows.Forms.ListBox()
        Me.AvailableFluidsLBL = New System.Windows.Forms.Label()
        Me.SelectedBlendComponentsLBL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(441, 349)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(79, 26)
        Me.cmdOk.TabIndex = 5
        Me.cmdOk.Text = "&OK"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(522, 349)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(79, 26)
        Me.cmdCancel.TabIndex = 6
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'lstAvailable
        '
        Me.lstAvailable.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAvailable.FormattingEnabled = True
        Me.lstAvailable.ItemHeight = 15
        Me.lstAvailable.Location = New System.Drawing.Point(12, 29)
        Me.lstAvailable.Name = "lstAvailable"
        Me.lstAvailable.Size = New System.Drawing.Size(266, 289)
        Me.lstAvailable.TabIndex = 0
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(299, 128)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(79, 26)
        Me.cmdAdd.TabIndex = 3
        Me.cmdAdd.Text = "&Add -->"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdRemove
        '
        Me.cmdRemove.Location = New System.Drawing.Point(299, 176)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(79, 26)
        Me.cmdRemove.TabIndex = 4
        Me.cmdRemove.Text = "<-- &Remove"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'lstSelected
        '
        Me.lstSelected.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSelected.FormattingEnabled = True
        Me.lstSelected.ItemHeight = 15
        Me.lstSelected.Location = New System.Drawing.Point(394, 29)
        Me.lstSelected.Name = "lstSelected"
        Me.lstSelected.Size = New System.Drawing.Size(266, 289)
        Me.lstSelected.TabIndex = 1
        '
        'AvailableFluidsLBL
        '
        Me.AvailableFluidsLBL.AutoSize = True
        Me.AvailableFluidsLBL.Location = New System.Drawing.Point(13, 13)
        Me.AvailableFluidsLBL.Name = "AvailableFluidsLBL"
        Me.AvailableFluidsLBL.Size = New System.Drawing.Size(77, 13)
        Me.AvailableFluidsLBL.TabIndex = 10
        Me.AvailableFluidsLBL.Text = "Available fluids"
        '
        'SelectedBlendComponentsLBL
        '
        Me.SelectedBlendComponentsLBL.AutoSize = True
        Me.SelectedBlendComponentsLBL.Location = New System.Drawing.Point(391, 13)
        Me.SelectedBlendComponentsLBL.Name = "SelectedBlendComponentsLBL"
        Me.SelectedBlendComponentsLBL.Size = New System.Drawing.Size(139, 13)
        Me.SelectedBlendComponentsLBL.TabIndex = 11
        Me.SelectedBlendComponentsLBL.Text = "Selected blend components"
        '
        'formDefine
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(681, 387)
        Me.Controls.Add(Me.SelectedBlendComponentsLBL)
        Me.Controls.Add(Me.AvailableFluidsLBL)
        Me.Controls.Add(Me.lstSelected)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lstAvailable)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formDefine"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Define New Blend"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents lstAvailable As System.Windows.Forms.ListBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdRemove As System.Windows.Forms.Button
    Friend WithEvents lstSelected As System.Windows.Forms.ListBox
    Friend WithEvents AvailableFluidsLBL As System.Windows.Forms.Label
    Friend WithEvents SelectedBlendComponentsLBL As System.Windows.Forms.Label
End Class
