Public Class formRefState
    Private RefStateOld As Integer
    Friend ChangeRefState As Boolean  'T:Changed, F:Not Changed
    Private Sub formRefState_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set the control in this form
        If BordConditions.RefState = 0 Then
            Me.Option0.Checked = True
        ElseIf BordConditions.RefState = 1 Then
            Me.Option1.Checked = True
        ElseIf BordConditions.RefState = 2 Then
            Me.Option2.Checked = True
        ElseIf BordConditions.RefState = 3 Then
            Me.Option3.Checked = True
        End If
        Me.RefStateOld = BordConditions.RefState
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        'Set the new Reference State in the BordConditio
        If Me.Option0.Checked Then
            BordConditions.RefState = 0
        ElseIf Me.Option1.Checked Then
            BordConditions.RefState = 1
        ElseIf Me.Option2.Checked Then
            BordConditions.RefState = 2
        ElseIf Me.Option3.Checked Then
            BordConditions.RefState = 3
        End If
        If BordConditions.RefState <> Me.RefStateOld Then
            Me.ChangeRefState = True
        Else
            Me.ChangeRefState = False
        End If
        Me.Close()
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.ChangeRefState = False
        Me.Close()
    End Sub
End Class