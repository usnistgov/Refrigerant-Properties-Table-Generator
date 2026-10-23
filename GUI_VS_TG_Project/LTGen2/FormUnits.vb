Public Class formUnits
    Public blnUnitsSIC, blnUnitsSIK, blnUnitsIP As Boolean
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If radbtnSIK.Checked = True Then
            BordConditions.Unit = "SI with K"
        End If
        If radbtnSIC.Checked = True Then
            BordConditions.Unit = "SI with °C"
        End If
        If radbtnIP.Checked = True Then
            BordConditions.Unit = "I-P Inch-Pound"
        End If
        FormMain.SetChildrenUnit()
        Me.Close()
    End Sub

    Private Sub formUnits_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If BordConditions.Unit = "SI with K" Then
            radbtnSIK.Checked = True
            radbtnSIC.Checked = False
            radbtnIP.Checked = False
        End If
        If BordConditions.Unit = "SI with °C" Then
            radbtnSIK.Checked = False
            radbtnSIC.Checked = True
            radbtnIP.Checked = False
        End If
        If BordConditions.Unit = "I-P Inch-Pound" Then
            radbtnSIK.Checked = False
            radbtnSIC.Checked = False
            radbtnIP.Checked = True
        End If
        If radbtnSIK.Checked = True Then
            blnUnitsSIK = True
            blnUnitsSIC = False
            blnUnitsIP = False
        ElseIf radbtnSIC.Checked = True Then
            blnUnitsSIK = False
            blnUnitsSIC = True
            blnUnitsIP = False
        Else
            blnUnitsSIK = False
            blnUnitsSIC = False
            blnUnitsIP = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If blnUnitsSIK = True Then
            radbtnSIK.Checked = True
            radbtnSIC.Checked = False
            radbtnIP.Checked = False
        ElseIf blnUnitsSIC = True Then
            radbtnSIK.Checked = False
            radbtnSIC.Checked = True
            radbtnIP.Checked = False
        Else
            radbtnSIK.Checked = False
            radbtnSIC.Checked = False
            radbtnIP.Checked = True
        End If
        Me.Close()
    End Sub
End Class