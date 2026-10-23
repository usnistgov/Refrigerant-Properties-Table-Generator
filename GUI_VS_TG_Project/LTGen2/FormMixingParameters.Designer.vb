<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMixingParameters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMixingParameters))
        Me.lstRefrigs = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblUserDefined = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInput5 = New System.Windows.Forms.TextBox()
        Me.txtInput4 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txtinput3 = New System.Windows.Forms.TextBox()
        Me.txtinput2 = New System.Windows.Forms.TextBox()
        Me.txtinput1 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbRefrigRefrig = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMixingModel = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstRefrigs
        '
        Me.lstRefrigs.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRefrigs.FormattingEnabled = True
        Me.lstRefrigs.HorizontalScrollbar = True
        Me.lstRefrigs.ItemHeight = 15
        Me.lstRefrigs.Location = New System.Drawing.Point(13, 54)
        Me.lstRefrigs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstRefrigs.Name = "lstRefrigs"
        Me.lstRefrigs.Size = New System.Drawing.Size(175, 94)
        Me.lstRefrigs.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Refrigerants"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblUserDefined)
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Controls.Add(Me.btnApply)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtInput5)
        Me.GroupBox1.Controls.Add(Me.txtInput4)
        Me.GroupBox1.Controls.Add(Me.txt5)
        Me.GroupBox1.Controls.Add(Me.txt4)
        Me.GroupBox1.Controls.Add(Me.txtinput3)
        Me.GroupBox1.Controls.Add(Me.txtinput2)
        Me.GroupBox1.Controls.Add(Me.txtinput1)
        Me.GroupBox1.Controls.Add(Me.txt3)
        Me.GroupBox1.Controls.Add(Me.txt2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbRefrigRefrig)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbMixingModel)
        Me.GroupBox1.Controls.Add(Me.lstRefrigs)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(658, 322)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mixing Parameters"
        '
        'lblUserDefined
        '
        Me.lblUserDefined.AutoSize = True
        Me.lblUserDefined.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserDefined.ForeColor = System.Drawing.Color.Red
        Me.lblUserDefined.Location = New System.Drawing.Point(76, 289)
        Me.lblUserDefined.Name = "lblUserDefined"
        Me.lblUserDefined.Size = New System.Drawing.Size(78, 15)
        Me.lblUserDefined.TabIndex = 37
        Me.lblUserDefined.Text = "User defined"
        Me.lblUserDefined.Visible = False
        '
        'txt1
        '
        Me.txt1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1.Enabled = False
        Me.txt1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt1.Location = New System.Drawing.Point(13, 214)
        Me.txt1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(116, 21)
        Me.txt1.TabIndex = 23
        Me.txt1.TabStop = False
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnApply
        '
        Me.btnApply.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(531, 280)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(117, 32)
        Me.btnApply.TabIndex = 36
        Me.btnApply.Text = "&Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(401, 280)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(117, 32)
        Me.btnReset.TabIndex = 35
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(178, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(344, 15)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "(Default values should be used unless new data is available.)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 15)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Mixing Parameters"
        '
        'txtInput5
        '
        Me.txtInput5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput5.Location = New System.Drawing.Point(531, 235)
        Me.txtInput5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInput5.Name = "txtInput5"
        Me.txtInput5.Size = New System.Drawing.Size(116, 21)
        Me.txtInput5.TabIndex = 32
        Me.txtInput5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInput4
        '
        Me.txtInput4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput4.Location = New System.Drawing.Point(401, 235)
        Me.txtInput4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInput4.Name = "txtInput4"
        Me.txtInput4.Size = New System.Drawing.Size(116, 21)
        Me.txtInput4.TabIndex = 31
        Me.txtInput4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5
        '
        Me.txt5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt5.Enabled = False
        Me.txt5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5.Location = New System.Drawing.Point(531, 214)
        Me.txt5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(116, 21)
        Me.txt5.TabIndex = 30
        Me.txt5.TabStop = False
        Me.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt4
        '
        Me.txt4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt4.Enabled = False
        Me.txt4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4.Location = New System.Drawing.Point(401, 214)
        Me.txt4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(116, 21)
        Me.txt4.TabIndex = 29
        Me.txt4.TabStop = False
        Me.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtinput3
        '
        Me.txtinput3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinput3.Location = New System.Drawing.Point(272, 235)
        Me.txtinput3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtinput3.Name = "txtinput3"
        Me.txtinput3.Size = New System.Drawing.Size(116, 21)
        Me.txtinput3.TabIndex = 28
        Me.txtinput3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtinput2
        '
        Me.txtinput2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinput2.Location = New System.Drawing.Point(142, 235)
        Me.txtinput2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtinput2.Name = "txtinput2"
        Me.txtinput2.Size = New System.Drawing.Size(116, 21)
        Me.txtinput2.TabIndex = 27
        Me.txtinput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtinput1
        '
        Me.txtinput1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinput1.Location = New System.Drawing.Point(13, 235)
        Me.txtinput1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtinput1.Name = "txtinput1"
        Me.txtinput1.Size = New System.Drawing.Size(116, 21)
        Me.txtinput1.TabIndex = 26
        Me.txtinput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3
        '
        Me.txt3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt3.Enabled = False
        Me.txt3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.Location = New System.Drawing.Point(272, 214)
        Me.txt3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(116, 21)
        Me.txt3.TabIndex = 25
        Me.txt3.TabStop = False
        Me.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2
        '
        Me.txt2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2.Enabled = False
        Me.txt2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.Location = New System.Drawing.Point(142, 214)
        Me.txt2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(116, 21)
        Me.txt2.TabIndex = 24
        Me.txt2.TabStop = False
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(216, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Refrigerant-Refrigerant"
        '
        'cmbRefrigRefrig
        '
        Me.cmbRefrigRefrig.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRefrigRefrig.FormattingEnabled = True
        Me.cmbRefrigRefrig.Location = New System.Drawing.Point(217, 119)
        Me.cmbRefrigRefrig.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbRefrigRefrig.Name = "cmbRefrigRefrig"
        Me.cmbRefrigRefrig.Size = New System.Drawing.Size(419, 23)
        Me.cmbRefrigRefrig.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Mixing Model"
        '
        'cmbMixingModel
        '
        Me.cmbMixingModel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMixingModel.FormattingEnabled = True
        Me.cmbMixingModel.Location = New System.Drawing.Point(215, 54)
        Me.cmbMixingModel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbMixingModel.Name = "cmbMixingModel"
        Me.cmbMixingModel.Size = New System.Drawing.Size(423, 23)
        Me.cmbMixingModel.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtReference)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 351)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(658, 194)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        '
        'txtReference
        '
        Me.txtReference.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReference.Location = New System.Drawing.Point(7, 16)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtReference.Multiline = True
        Me.txtReference.Name = "txtReference"
        Me.txtReference.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReference.Size = New System.Drawing.Size(643, 170)
        Me.txtReference.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(545, 553)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(117, 32)
        Me.btnOK.TabIndex = 38
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'FormMixingParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 602)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMixingParameters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mixing Parameters"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstRefrigs As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtInput5 As System.Windows.Forms.TextBox
    Friend WithEvents txtInput4 As System.Windows.Forms.TextBox
    Friend WithEvents txt5 As System.Windows.Forms.TextBox
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
    Friend WithEvents txtinput3 As System.Windows.Forms.TextBox
    Friend WithEvents txtinput2 As System.Windows.Forms.TextBox
    Friend WithEvents txtinput1 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbRefrigRefrig As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMixingModel As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtReference As System.Windows.Forms.TextBox
    Friend WithEvents lblUserDefined As System.Windows.Forms.Label
End Class
