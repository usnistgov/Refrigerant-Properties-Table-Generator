<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreDefPureFld
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreDefPureFld))
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdInfo = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lstPreDefPureFld = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(213, 426)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(92, 38)
        Me.cmdOk.TabIndex = 4
        Me.cmdOk.Text = "&OK"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdInfo
        '
        Me.cmdInfo.Location = New System.Drawing.Point(30, 426)
        Me.cmdInfo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdInfo.Name = "cmdInfo"
        Me.cmdInfo.Size = New System.Drawing.Size(92, 38)
        Me.cmdInfo.TabIndex = 6
        Me.cmdInfo.Text = "&Info"
        Me.cmdInfo.UseVisualStyleBackColor = True
        Me.cmdInfo.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(321, 426)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(92, 38)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'lstPreDefPureFld
        '
        Me.lstPreDefPureFld.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPreDefPureFld.FormattingEnabled = True
        Me.lstPreDefPureFld.ItemHeight = 15
        Me.lstPreDefPureFld.Location = New System.Drawing.Point(30, 27)
        Me.lstPreDefPureFld.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstPreDefPureFld.Name = "lstPreDefPureFld"
        Me.lstPreDefPureFld.Size = New System.Drawing.Size(383, 379)
        Me.lstPreDefPureFld.TabIndex = 7
        '
        'frmPreDefPureFld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(457, 491)
        Me.Controls.Add(Me.lstPreDefPureFld)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdInfo)
        Me.Controls.Add(Me.cmdCancel)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPreDefPureFld"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Single-Compound Fluid"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdInfo As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents lstPreDefPureFld As ListBox
End Class
