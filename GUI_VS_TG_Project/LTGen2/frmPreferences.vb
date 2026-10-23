Public Class formPreferences
    Private OptionTemPressureOld As Integer
    Friend ChangeOptPressTem As Boolean  'T:Changed, F:Not Changed
    Private Sub formPreferences_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetClassControlFromBordConditions()
        Me.ControlsManagement()
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Me.SaveClassControlIntoBordConditions()
        Me.Close()
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
    Private Sub SetClassControlFromBordConditions()
        With BordConditionPreferences
            If .DislayOpeningWindow Then
                Me.OptOpeningWindow_0.Checked = True
            Else
                Me.OptOpeningWindow_1.Checked = True
            End If
            If .FileLoad = 0 Then
                Me.OptInitialFile_0.Checked = True
            ElseIf .FileLoad = 1 Then
                Me.OptInitialFile_1.Checked = True
            ElseIf .FileLoad = 2 Then
                Me.OptInitialFile_2.Checked = True
            End If
            If .Unit = "SI with K" Then
                Me.OptInitialUnits_0.Checked = True
            ElseIf .Unit = "SI with °C" Then
                Me.OptInitialUnits_1.Checked = True
            ElseIf .Unit = "I-P Inch-Pound" Then
                Me.OptInitialUnits_2.Checked = True
            End If
            Me.OptionTemPressureOld = .InputTypeEvCondSat
            If .RefState = 0 Then
                Me.OptInitialReferenceState_0.Checked = True
            ElseIf .RefState = 1 Then
                Me.OptInitialReferenceState_1.Checked = True
            ElseIf .RefState = 2 Then
                Me.OptInitialReferenceState_2.Checked = True
            ElseIf .RefState = 3 Then
                Me.OptInitialReferenceState_3.Checked = True
            End If
        End With
    End Sub
    Private Sub SaveClassControlIntoBordConditions()
        With BordConditionPreferences
            If Me.OptOpeningWindow_0.Checked Then
                .DislayOpeningWindow = True
            ElseIf Me.OptOpeningWindow_1.Checked Then
                .DislayOpeningWindow = False
            End If
            If Me.OptInitialFile_0.Checked Then
                .FileLoad = 0
            ElseIf Me.OptInitialFile_1.Checked Then
                .FileLoad = 1
            ElseIf Me.OptInitialFile_2.Checked Then
                .FileLoad = 2
            End If
            'Save changes in BordConditionPreferences only if no load any files is selected
            If .FileLoad = 2 Then
                If Me.OptInitialUnits_0.Checked Then
                    .Unit = "SI with K"
                ElseIf Me.OptInitialUnits_1.Checked Then
                    .Unit = "SI with °C"
                ElseIf Me.OptInitialUnits_2.Checked Then
                    .Unit = "I-P Inch-Pound"
                End If
                If .InputTypeEvCondSat <> Me.OptionTemPressureOld Then
                    Me.ChangeOptPressTem = True
                Else
                    Me.ChangeOptPressTem = False
                End If
                If Me.OptInitialReferenceState_0.Checked Then
                    .RefState = 0
                ElseIf Me.OptInitialReferenceState_1.Checked Then
                    .RefState = 1
                ElseIf Me.OptInitialReferenceState_2.Checked Then
                    .RefState = 2
                ElseIf Me.OptInitialReferenceState_3.Checked Then
                    .RefState = 3
                End If
            End If
        End With
    End Sub
    Private Sub ControlsManagement()
        If Me.OptInitialFile_0.Checked = True Or Me.OptInitialFile_1.Checked = True Then
            Me.FrameUnits.Enabled = False
            Me.FrameReferenceState.Enabled = False
        ElseIf Me.OptInitialFile_2.Checked = True Then
            Me.FrameUnits.Enabled = True
            Me.FrameReferenceState.Enabled = True
        End If
    End Sub
    Private Sub OptInitialFile_0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptInitialFile_0.CheckedChanged
        Me.ControlsManagement()
    End Sub
    Private Sub OptInitialFile_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptInitialFile_1.CheckedChanged
        Me.ControlsManagement()
    End Sub
    Private Sub OptInitialFile_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptInitialFile_2.CheckedChanged
        Me.ControlsManagement()
    End Sub
End Class