<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRefState
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formRefState))
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Option3 = New System.Windows.Forms.RadioButton()
        Me.Option2 = New System.Windows.Forms.RadioButton()
        Me.Option1 = New System.Windows.Forms.RadioButton()
        Me.Option0 = New System.Windows.Forms.RadioButton()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Location = New System.Drawing.Point(323, 181)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(92, 30)
        Me.cmdOk.TabIndex = 6
        Me.cmdOk.Text = "&OK"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(418, 181)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(92, 30)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.Option3)
        Me.Frame1.Controls.Add(Me.Option2)
        Me.Frame1.Controls.Add(Me.Option1)
        Me.Frame1.Controls.Add(Me.Option0)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.Location = New System.Drawing.Point(14, 14)
        Me.Frame1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Frame1.Size = New System.Drawing.Size(496, 149)
        Me.Frame1.TabIndex = 8
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Enthalpy and entropy reference state"
        '
        'Option3
        '
        Me.Option3.AutoSize = True
        Me.Option3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option3.Location = New System.Drawing.Point(7, 102)
        Me.Option3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Option3.Name = "Option3"
        Me.Option3.Size = New System.Drawing.Size(432, 19)
        Me.Option3.TabIndex = 3
        Me.Option3.TabStop = True
        Me.Option3.Text = "Enthalpy = 200 kJ/kg, entropy = 1 kJ/kg-K for the saturated liquid at 0 C (II&R)"
        Me.Option3.UseVisualStyleBackColor = True
        '
        'Option2
        '
        Me.Option2.AutoSize = True
        Me.Option2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option2.Location = New System.Drawing.Point(8, 76)
        Me.Option2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Option2.Name = "Option2"
        Me.Option2.Size = New System.Drawing.Size(367, 19)
        Me.Option2.TabIndex = 2
        Me.Option2.TabStop = True
        Me.Option2.Text = "Enthalpy, entropy = 0 for the saturated liquid at -40 C (&ASHRAE)"
        Me.Option2.UseVisualStyleBackColor = True
        '
        'Option1
        '
        Me.Option1.AutoSize = True
        Me.Option1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option1.Location = New System.Drawing.Point(8, 50)
        Me.Option1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Option1.Name = "Option1"
        Me.Option1.Size = New System.Drawing.Size(446, 19)
        Me.Option1.TabIndex = 1
        Me.Option1.TabStop = True
        Me.Option1.Text = "Enthalpy, entropy = 0 for the saturated liquid at the normal boiling point (N&BP)" &
    " "
        Me.Option1.UseVisualStyleBackColor = True
        '
        'Option0
        '
        Me.Option0.AutoSize = True
        Me.Option0.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option0.Location = New System.Drawing.Point(8, 22)
        Me.Option0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Option0.Name = "Option0"
        Me.Option0.Size = New System.Drawing.Size(193, 19)
        Me.Option0.TabIndex = 0
        Me.Option0.TabStop = True
        Me.Option0.Text = "Use the &default reference state"
        Me.Option0.UseVisualStyleBackColor = True
        '
        'formRefState
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(525, 224)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdCancel)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formRefState"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Reference State"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Frame1 As System.Windows.Forms.GroupBox
    Friend WithEvents Option3 As System.Windows.Forms.RadioButton
    Friend WithEvents Option2 As System.Windows.Forms.RadioButton
    Friend WithEvents Option1 As System.Windows.Forms.RadioButton
    Friend WithEvents Option0 As System.Windows.Forms.RadioButton
End Class
