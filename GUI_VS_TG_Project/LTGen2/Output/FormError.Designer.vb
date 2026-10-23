<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormError
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormError))
        Me.CopyBut = New System.Windows.Forms.Button()
        Me.PrintBut = New System.Windows.Forms.Button()
        Me.SaveBut = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ErrorText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CopyBut
        '
        Me.CopyBut.Location = New System.Drawing.Point(14, 526)
        Me.CopyBut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CopyBut.Name = "CopyBut"
        Me.CopyBut.Size = New System.Drawing.Size(115, 31)
        Me.CopyBut.TabIndex = 1
        Me.CopyBut.Text = "&Copy"
        Me.CopyBut.UseVisualStyleBackColor = True
        '
        'PrintBut
        '
        Me.PrintBut.Location = New System.Drawing.Point(351, 526)
        Me.PrintBut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PrintBut.Name = "PrintBut"
        Me.PrintBut.Size = New System.Drawing.Size(115, 31)
        Me.PrintBut.TabIndex = 2
        Me.PrintBut.Text = "&Print"
        Me.PrintBut.UseVisualStyleBackColor = True
        '
        'SaveBut
        '
        Me.SaveBut.Location = New System.Drawing.Point(691, 526)
        Me.SaveBut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SaveBut.Name = "SaveBut"
        Me.SaveBut.Size = New System.Drawing.Size(115, 31)
        Me.SaveBut.TabIndex = 3
        Me.SaveBut.Text = "&Save"
        Me.SaveBut.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        '
        'PrintDoc
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ErrorText
        '
        Me.ErrorText.BackColor = System.Drawing.SystemColors.Window
        Me.ErrorText.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorText.Location = New System.Drawing.Point(2, 4)
        Me.ErrorText.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ErrorText.Multiline = True
        Me.ErrorText.Name = "ErrorText"
        Me.ErrorText.ReadOnly = True
        Me.ErrorText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ErrorText.Size = New System.Drawing.Size(810, 502)
        Me.ErrorText.TabIndex = 0
        '
        'FormError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 576)
        Me.Controls.Add(Me.ErrorText)
        Me.Controls.Add(Me.SaveBut)
        Me.Controls.Add(Me.PrintBut)
        Me.Controls.Add(Me.CopyBut)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(836, 2071)
        Me.MinimizeBox = False
        Me.Name = "FormError"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Diagnostic Message"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CopyBut As System.Windows.Forms.Button
    Friend WithEvents PrintBut As System.Windows.Forms.Button
    Friend WithEvents SaveBut As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents ErrorText As System.Windows.Forms.TextBox
End Class
