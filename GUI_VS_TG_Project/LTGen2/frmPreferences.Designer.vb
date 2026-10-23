<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPreferences
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPreferences))
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.FrameOpeningWindow = New System.Windows.Forms.GroupBox()
        Me.OptOpeningWindow_1 = New System.Windows.Forms.RadioButton()
        Me.OptOpeningWindow_0 = New System.Windows.Forms.RadioButton()
        Me.FrameDefaultData = New System.Windows.Forms.GroupBox()
        Me.OptInitialFile_2 = New System.Windows.Forms.RadioButton()
        Me.OptInitialFile_1 = New System.Windows.Forms.RadioButton()
        Me.OptInitialFile_0 = New System.Windows.Forms.RadioButton()
        Me.FrameUnits = New System.Windows.Forms.GroupBox()
        Me.OptInitialUnits_2 = New System.Windows.Forms.RadioButton()
        Me.OptInitialUnits_1 = New System.Windows.Forms.RadioButton()
        Me.OptInitialUnits_0 = New System.Windows.Forms.RadioButton()
        Me.NoteLBL = New System.Windows.Forms.Label()
        Me.FrameReferenceState = New System.Windows.Forms.GroupBox()
        Me.OptInitialReferenceState_3 = New System.Windows.Forms.RadioButton()
        Me.OptInitialReferenceState_2 = New System.Windows.Forms.RadioButton()
        Me.OptInitialReferenceState_1 = New System.Windows.Forms.RadioButton()
        Me.OptInitialReferenceState_0 = New System.Windows.Forms.RadioButton()
        Me.FrameOpeningWindow.SuspendLayout()
        Me.FrameDefaultData.SuspendLayout()
        Me.FrameUnits.SuspendLayout()
        Me.FrameReferenceState.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Location = New System.Drawing.Point(330, 373)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(92, 30)
        Me.cmdOk.TabIndex = 5
        Me.cmdOk.Text = "&OK"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(425, 373)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(92, 30)
        Me.cmdCancel.TabIndex = 6
        Me.cmdCancel.Text = " &Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'FrameOpeningWindow
        '
        Me.FrameOpeningWindow.Controls.Add(Me.OptOpeningWindow_1)
        Me.FrameOpeningWindow.Controls.Add(Me.OptOpeningWindow_0)
        Me.FrameOpeningWindow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameOpeningWindow.Location = New System.Drawing.Point(12, 13)
        Me.FrameOpeningWindow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FrameOpeningWindow.Name = "FrameOpeningWindow"
        Me.FrameOpeningWindow.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FrameOpeningWindow.Size = New System.Drawing.Size(233, 84)
        Me.FrameOpeningWindow.TabIndex = 0
        Me.FrameOpeningWindow.TabStop = False
        Me.FrameOpeningWindow.Text = "Display Opening Window?"
        '
        'OptOpeningWindow_1
        '
        Me.OptOpeningWindow_1.AutoSize = True
        Me.OptOpeningWindow_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptOpeningWindow_1.Location = New System.Drawing.Point(8, 50)
        Me.OptOpeningWindow_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptOpeningWindow_1.Name = "OptOpeningWindow_1"
        Me.OptOpeningWindow_1.Size = New System.Drawing.Size(41, 19)
        Me.OptOpeningWindow_1.TabIndex = 1
        Me.OptOpeningWindow_1.TabStop = True
        Me.OptOpeningWindow_1.Text = "No"
        Me.OptOpeningWindow_1.UseVisualStyleBackColor = True
        '
        'OptOpeningWindow_0
        '
        Me.OptOpeningWindow_0.AutoSize = True
        Me.OptOpeningWindow_0.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptOpeningWindow_0.Location = New System.Drawing.Point(8, 22)
        Me.OptOpeningWindow_0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptOpeningWindow_0.Name = "OptOpeningWindow_0"
        Me.OptOpeningWindow_0.Size = New System.Drawing.Size(45, 19)
        Me.OptOpeningWindow_0.TabIndex = 0
        Me.OptOpeningWindow_0.TabStop = True
        Me.OptOpeningWindow_0.Text = "Yes"
        Me.OptOpeningWindow_0.UseVisualStyleBackColor = True
        '
        'FrameDefaultData
        '
        Me.FrameDefaultData.Controls.Add(Me.OptInitialFile_2)
        Me.FrameDefaultData.Controls.Add(Me.OptInitialFile_1)
        Me.FrameDefaultData.Controls.Add(Me.OptInitialFile_0)
        Me.FrameDefaultData.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameDefaultData.Location = New System.Drawing.Point(273, 13)
        Me.FrameDefaultData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FrameDefaultData.Name = "FrameDefaultData"
        Me.FrameDefaultData.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FrameDefaultData.Size = New System.Drawing.Size(240, 121)
        Me.FrameDefaultData.TabIndex = 1
        Me.FrameDefaultData.TabStop = False
        Me.FrameDefaultData.Text = "Load an Initial File?"
        '
        'OptInitialFile_2
        '
        Me.OptInitialFile_2.AutoSize = True
        Me.OptInitialFile_2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptInitialFile_2.Location = New System.Drawing.Point(8, 89)
        Me.OptInitialFile_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptInitialFile_2.Name = "OptInitialFile_2"
        Me.OptInitialFile_2.Size = New System.Drawing.Size(149, 19)
        Me.OptInitialFile_2.TabIndex = 2
        Me.OptInitialFile_2.TabStop = True
        Me.OptInitialFile_2.Text = "No, do not load any file"
        Me.OptInitialFile_2.UseVisualStyleBackColor = True
        '
        'OptInitialFile_1
        '
        Me.OptInitialFile_1.AutoSize = True
        Me.OptInitialFile_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptInitialFile_1.Location = New System.Drawing.Point(8, 55)
        Me.OptInitialFile_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptInitialFile_1.Name = "OptInitialFile_1"
        Me.OptInitialFile_1.Size = New System.Drawing.Size(154, 19)
        Me.OptInitialFile_1.TabIndex = 1
        Me.OptInitialFile_1.TabStop = True
        Me.OptInitialFile_1.Text = "Yes, load the default file"
        Me.OptInitialFile_1.UseVisualStyleBackColor = True
        '
        'OptInitialFile_0
        '
        Me.OptInitialFile_0.AutoSize = True
        Me.OptInitialFile_0.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptInitialFile_0.Location = New System.Drawing.Point(8, 22)
        Me.OptInitialFile_0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptInitialFile_0.Name = "OptInitialFile_0"
        Me.OptInitialFile_0.Size = New System.Drawing.Size(168, 19)
        Me.OptInitialFile_0.TabIndex = 0
        Me.OptInitialFile_0.TabStop = True
        Me.OptInitialFile_0.Text = "Yes, load the last file used"
        Me.OptInitialFile_0.UseVisualStyleBackColor = True
        '
        'FrameUnits
        '
        Me.FrameUnits.Controls.Add(Me.OptInitialUnits_2)
        Me.FrameUnits.Controls.Add(Me.OptInitialUnits_1)
        Me.FrameUnits.Controls.Add(Me.OptInitialUnits_0)
        Me.FrameUnits.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameUnits.Location = New System.Drawing.Point(12, 105)
        Me.FrameUnits.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FrameUnits.Name = "FrameUnits"
        Me.FrameUnits.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FrameUnits.Size = New System.Drawing.Size(233, 106)
        Me.FrameUnits.TabIndex = 2
        Me.FrameUnits.TabStop = False
        Me.FrameUnits.Text = "Initial Units"
        '
        'OptInitialUnits_2
        '
        Me.OptInitialUnits_2.AutoSize = True
        Me.OptInitialUnits_2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptInitialUnits_2.Location = New System.Drawing.Point(8, 75)
        Me.OptInitialUnits_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptInitialUnits_2.Name = "OptInitialUnits_2"
        Me.OptInitialUnits_2.Size = New System.Drawing.Size(114, 19)
        Me.OptInitialUnits_2.TabIndex = 3
        Me.OptInitialUnits_2.TabStop = True
        Me.OptInitialUnits_2.Text = "I-P (Inch-Pound)"
        Me.OptInitialUnits_2.UseVisualStyleBackColor = True
        '
        'OptInitialUnits_1
        '
        Me.OptInitialUnits_1.AutoSize = True
        Me.OptInitialUnits_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptInitialUnits_1.Location = New System.Drawing.Point(8, 49)
        Me.OptInitialUnits_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptInitialUnits_1.Name = "OptInitialUnits_1"
        Me.OptInitialUnits_1.Size = New System.Drawing.Size(89, 19)
        Me.OptInitialUnits_1.TabIndex = 2
        Me.OptInitialUnits_1.TabStop = True
        Me.OptInitialUnits_1.Text = "SI - Celsius"
        Me.OptInitialUnits_1.UseVisualStyleBackColor = True
        '
        'OptInitialUnits_0
        '
        Me.OptInitialUnits_0.AutoSize = True
        Me.OptInitialUnits_0.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptInitialUnits_0.Location = New System.Drawing.Point(8, 22)
        Me.OptInitialUnits_0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptInitialUnits_0.Name = "OptInitialUnits_0"
        Me.OptInitialUnits_0.Size = New System.Drawing.Size(79, 19)
        Me.OptInitialUnits_0.TabIndex = 1
        Me.OptInitialUnits_0.TabStop = True
        Me.OptInitialUnits_0.Text = "SI - Kelvin"
        Me.OptInitialUnits_0.UseVisualStyleBackColor = True
        '
        'NoteLBL
        '
        Me.NoteLBL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteLBL.Location = New System.Drawing.Point(270, 143)
        Me.NoteLBL.Name = "NoteLBL"
        Me.NoteLBL.Size = New System.Drawing.Size(244, 78)
        Me.NoteLBL.TabIndex = 11
        Me.NoteLBL.Text = "Note: When a file is loaded, the reference state and units associated with this f" &
    "ile become the current settings for the session and must be changed manually, if" &
    " desired."
        '
        'FrameReferenceState
        '
        Me.FrameReferenceState.Controls.Add(Me.OptInitialReferenceState_3)
        Me.FrameReferenceState.Controls.Add(Me.OptInitialReferenceState_2)
        Me.FrameReferenceState.Controls.Add(Me.OptInitialReferenceState_1)
        Me.FrameReferenceState.Controls.Add(Me.OptInitialReferenceState_0)
        Me.FrameReferenceState.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrameReferenceState.Location = New System.Drawing.Point(12, 225)
        Me.FrameReferenceState.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FrameReferenceState.Name = "FrameReferenceState"
        Me.FrameReferenceState.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FrameReferenceState.Size = New System.Drawing.Size(502, 142)
        Me.FrameReferenceState.TabIndex = 4
        Me.FrameReferenceState.TabStop = False
        Me.FrameReferenceState.Text = "Initial Reference State"
        '
        'OptInitialReferenceState_3
        '
        Me.OptInitialReferenceState_3.AutoSize = True
        Me.OptInitialReferenceState_3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptInitialReferenceState_3.Location = New System.Drawing.Point(7, 111)
        Me.OptInitialReferenceState_3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptInitialReferenceState_3.Name = "OptInitialReferenceState_3"
        Me.OptInitialReferenceState_3.Size = New System.Drawing.Size(432, 19)
        Me.OptInitialReferenceState_3.TabIndex = 3
        Me.OptInitialReferenceState_3.TabStop = True
        Me.OptInitialReferenceState_3.Text = "Enthalpy = 200 kJ/kg, entropy = 1 kJ/kg-K for the saturated liquid at 0 C (IIR)"
        Me.OptInitialReferenceState_3.UseVisualStyleBackColor = True
        '
        'OptInitialReferenceState_2
        '
        Me.OptInitialReferenceState_2.AutoSize = True
        Me.OptInitialReferenceState_2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptInitialReferenceState_2.Location = New System.Drawing.Point(8, 81)
        Me.OptInitialReferenceState_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptInitialReferenceState_2.Name = "OptInitialReferenceState_2"
        Me.OptInitialReferenceState_2.Size = New System.Drawing.Size(367, 19)
        Me.OptInitialReferenceState_2.TabIndex = 2
        Me.OptInitialReferenceState_2.TabStop = True
        Me.OptInitialReferenceState_2.Text = "Enthalpy, entropy = 0 for the saturated liquid at -40 C (ASHRAE)"
        Me.OptInitialReferenceState_2.UseVisualStyleBackColor = True
        '
        'OptInitialReferenceState_1
        '
        Me.OptInitialReferenceState_1.AutoSize = True
        Me.OptInitialReferenceState_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptInitialReferenceState_1.Location = New System.Drawing.Point(8, 51)
        Me.OptInitialReferenceState_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptInitialReferenceState_1.Name = "OptInitialReferenceState_1"
        Me.OptInitialReferenceState_1.Size = New System.Drawing.Size(446, 19)
        Me.OptInitialReferenceState_1.TabIndex = 1
        Me.OptInitialReferenceState_1.TabStop = True
        Me.OptInitialReferenceState_1.Text = "Enthalpy, entropy = 0 for the saturated liquid at the normal boiling point (NBP) " &
    ""
        Me.OptInitialReferenceState_1.UseVisualStyleBackColor = True
        '
        'OptInitialReferenceState_0
        '
        Me.OptInitialReferenceState_0.AutoSize = True
        Me.OptInitialReferenceState_0.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptInitialReferenceState_0.Location = New System.Drawing.Point(8, 22)
        Me.OptInitialReferenceState_0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OptInitialReferenceState_0.Name = "OptInitialReferenceState_0"
        Me.OptInitialReferenceState_0.Size = New System.Drawing.Size(171, 19)
        Me.OptInitialReferenceState_0.TabIndex = 0
        Me.OptInitialReferenceState_0.TabStop = True
        Me.OptInitialReferenceState_0.Text = "The default reference state"
        Me.OptInitialReferenceState_0.UseVisualStyleBackColor = True
        '
        'formPreferences
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(528, 410)
        Me.Controls.Add(Me.FrameReferenceState)
        Me.Controls.Add(Me.NoteLBL)
        Me.Controls.Add(Me.FrameUnits)
        Me.Controls.Add(Me.FrameDefaultData)
        Me.Controls.Add(Me.FrameOpeningWindow)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdCancel)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPreferences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Startup Preferences"
        Me.FrameOpeningWindow.ResumeLayout(False)
        Me.FrameOpeningWindow.PerformLayout()
        Me.FrameDefaultData.ResumeLayout(False)
        Me.FrameDefaultData.PerformLayout()
        Me.FrameUnits.ResumeLayout(False)
        Me.FrameUnits.PerformLayout()
        Me.FrameReferenceState.ResumeLayout(False)
        Me.FrameReferenceState.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents FrameOpeningWindow As System.Windows.Forms.GroupBox
    Friend WithEvents OptOpeningWindow_1 As System.Windows.Forms.RadioButton
    Friend WithEvents OptOpeningWindow_0 As System.Windows.Forms.RadioButton
    Friend WithEvents FrameDefaultData As System.Windows.Forms.GroupBox
    Friend WithEvents OptInitialFile_1 As System.Windows.Forms.RadioButton
    Friend WithEvents OptInitialFile_0 As System.Windows.Forms.RadioButton
    Friend WithEvents OptInitialFile_2 As System.Windows.Forms.RadioButton
    Friend WithEvents FrameUnits As System.Windows.Forms.GroupBox
    Friend WithEvents OptInitialUnits_2 As System.Windows.Forms.RadioButton
    Friend WithEvents OptInitialUnits_1 As System.Windows.Forms.RadioButton
    Friend WithEvents OptInitialUnits_0 As System.Windows.Forms.RadioButton
    Friend WithEvents NoteLBL As System.Windows.Forms.Label
    Friend WithEvents FrameReferenceState As System.Windows.Forms.GroupBox
    Friend WithEvents OptInitialReferenceState_3 As System.Windows.Forms.RadioButton
    Friend WithEvents OptInitialReferenceState_2 As System.Windows.Forms.RadioButton
    Friend WithEvents OptInitialReferenceState_1 As System.Windows.Forms.RadioButton
    Friend WithEvents OptInitialReferenceState_0 As System.Windows.Forms.RadioButton
End Class
