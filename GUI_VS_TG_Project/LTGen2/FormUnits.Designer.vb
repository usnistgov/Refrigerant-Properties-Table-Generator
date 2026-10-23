<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUnits
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formUnits))
        Me.radbtnSIK = New System.Windows.Forms.RadioButton()
        Me.radbtnSIC = New System.Windows.Forms.RadioButton()
        Me.radbtnIP = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'radbtnSIK
        '
        Me.radbtnSIK.AutoSize = True
        Me.radbtnSIK.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radbtnSIK.Location = New System.Drawing.Point(17, 14)
        Me.radbtnSIK.Name = "radbtnSIK"
        Me.radbtnSIK.Size = New System.Drawing.Size(73, 19)
        Me.radbtnSIK.TabIndex = 0
        Me.radbtnSIK.TabStop = True
        Me.radbtnSIK.Text = "SI-Kelvin"
        Me.radbtnSIK.UseVisualStyleBackColor = True
        '
        'radbtnSIC
        '
        Me.radbtnSIC.AutoSize = True
        Me.radbtnSIC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radbtnSIC.Location = New System.Drawing.Point(17, 32)
        Me.radbtnSIC.Name = "radbtnSIC"
        Me.radbtnSIC.Size = New System.Drawing.Size(83, 19)
        Me.radbtnSIC.TabIndex = 1
        Me.radbtnSIC.TabStop = True
        Me.radbtnSIC.Text = "SI-Celsius"
        Me.radbtnSIC.UseVisualStyleBackColor = True
        '
        'radbtnIP
        '
        Me.radbtnIP.AutoSize = True
        Me.radbtnIP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radbtnIP.Location = New System.Drawing.Point(17, 51)
        Me.radbtnIP.Name = "radbtnIP"
        Me.radbtnIP.Size = New System.Drawing.Size(120, 19)
        Me.radbtnIP.TabIndex = 2
        Me.radbtnIP.TabStop = True
        Me.radbtnIP.Text = "I-P (Inch - Pound)"
        Me.radbtnIP.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(195, 80)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(117, 26)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(17, 80)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 26)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'formUnits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 117)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.radbtnIP)
        Me.Controls.Add(Me.radbtnSIC)
        Me.Controls.Add(Me.radbtnSIK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formUnits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Units"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radbtnSIK As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnSIC As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnIP As System.Windows.Forms.RadioButton
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
