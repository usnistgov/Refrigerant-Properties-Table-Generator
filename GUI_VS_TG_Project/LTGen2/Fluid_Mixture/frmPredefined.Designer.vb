<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPredefined
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPredefined))
        Me.lstPredefined = New System.Windows.Forms.ListBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdInfo = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstPredefined
        '
        Me.lstPredefined.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPredefined.FormattingEnabled = True
        Me.lstPredefined.ItemHeight = 15
        Me.lstPredefined.Location = New System.Drawing.Point(28, 14)
        Me.lstPredefined.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstPredefined.Name = "lstPredefined"
        Me.lstPredefined.Size = New System.Drawing.Size(383, 379)
        Me.lstPredefined.TabIndex = 0
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(324, 424)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(92, 30)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdInfo
        '
        Me.cmdInfo.Enabled = False
        Me.cmdInfo.Location = New System.Drawing.Point(28, 424)
        Me.cmdInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdInfo.Name = "cmdInfo"
        Me.cmdInfo.Size = New System.Drawing.Size(92, 30)
        Me.cmdInfo.TabIndex = 3
        Me.cmdInfo.Text = "&Info"
        Me.cmdInfo.UseVisualStyleBackColor = True
        Me.cmdInfo.Visible = False
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(202, 424)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(92, 30)
        Me.cmdOk.TabIndex = 1
        Me.cmdOk.Text = "&OK"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'FormPredefined
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(440, 480)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdInfo)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.lstPredefined)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPredefined"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Predefined Blend"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstPredefined As System.Windows.Forms.ListBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdInfo As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
End Class
