
Friend Class FormMixingParameters

    Friend mixing_rule_info(50) As String
    Friend nc As Integer
    Friend modstr As String
    Friend inter_coeff_input1, inter_coeff_input2, inter_coeff_input3, inter_coeff_input4, inter_coeff_input5 As Double
    Friend mixing_mode_set(50) As String

    Const Length_hfld As Integer = 999
    Const Length_hfmix As Integer = 254
    Friend hrf(2), hfmix(Length_hfmix) As Char

    Friend Const nmxpar = 6
    Friend fij(nmxpar - 1) As Double
    Friend Shared MixtureFeature As New MixtureFeatureClass
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Friend Sub FormMixingParameters_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Combo box setting - selection of mixing model
        ' Reset refrigerant listbox
        ' Reset mixing model combobox
        ' Reset mixing rule document


        cmbMixingModel.Items.Clear()
        cmbRefrigRefrig.Items.Clear()
        lstRefrigs.Items.Clear()
        txtReference.Text = ""


        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim fn As Integer
        Dim line_input As String
        Dim NameFilePathComplete, NameFile As String


        Dim underline As String


        NameFile = "HMX.bnc"
        NameFilePathComplete = ApplicationFolder & "\FLUIDS\" & NameFile

        nc = MixtureFeature.MixtureFeature.nc
        fn = FreeFile()


        FileOpen(fn, NameFilePathComplete, OpenMode.Input)


        i = 0

        ' initialization
        For j = 0 To 50
            mixing_rule_info(j) = ""
        Next j

        ' read from hmx.bnc files - REFPROP 9.1
        ' read mixing model and it's description

        'YYJ[2020.0328] Parser for 'LITERATURE REFERENCE' - compatible with REFPROP 10
        Dim HMX_BNC_PARSER_REFPROP10 As String
        'Dim INSTRUCTION_HMX_BNC_REFPORP10 As String = "Mixture model for binaries that are based on mixing rules for the reducing parameters only."

        underline = ""
        For j = 1 To 22
            underline = underline & Chr(175)
        Next j

        Do
            line_input = LineInput(fn)

            If Strings.Left(line_input, 4) = "#MXM" Then
                line_input = LineInput(fn)
                cmbMixingModel.Items.Add(RTrim(line_input))

                ' Mixing rule info read from file. max line is 50.
                For j = 0 To 50
                    line_input = LineInput(fn)
                    If Strings.Left(line_input, 1) = "!" Then Exit For

                    ''YYJ[2020.0329] Removing 'Instruction sentence' from MixModelList - s
                    'If Strings.InStr(1, line_input, INSTRUCTION_HMX_BNC_REFPORP10, CompareMethod.Text) > 0 Then
                    '    i = i - 1
                    '    Exit For
                    'End If
                    ''YYJ[2020.0329] Removing 'Instruction sentence' from MixModelList - e

                    'YYJ[2020.0328] Parser for 'LITERATURE REFERENCE' - compatible with REFPROP 10 - s
                    HMX_BNC_PARSER_REFPROP10 = ChgLitRef_REFPROP10(line_input, underline)
                    mixing_rule_info(i) = mixing_rule_info(i) & HMX_BNC_PARSER_REFPROP10
                    'mixing_rule_info(i) = mixing_rule_info(i) & line_input
                    'mixing_rule_info(i) = Strings.Replace(mixing_rule_info(i), "?", "")
                    'mixing_rule_info(i) = Strings.Replace(mixing_rule_info(i), "LITERATURE REFERENCE\", "LITERATURE REFERENCE" & Chr(13) & Chr(10) & underline & Chr(13) & Chr(10))
                    'mixing_rule_info(i) = Strings.Replace(mixing_rule_info(i), "\", Chr(13) & Chr(10) & Chr(13) & Chr(10))
                    'YYJ[2020.0328] Parser for 'LITERATURE REFERENCE' - compatible with REFPROP 10 - e

                Next j
                i = i + 1

            End If
        Loop Until EOF(fn)
        FileClose(fn)

        cmbMixingModel.SelectedIndex = 0
        txtReference.Text = mixing_rule_info(cmbMixingModel.SelectedIndex)
        ' show refrigerant in the list box
        For i = 0 To nc - 1
            lstRefrigs.Items.Add(MixtureFeature.FluidsFeature(i).fluid)
        Next i

        ' show refrigerant-refrigerant in the refrigerant combo list box
        ' k : refrigerant - refrigerant index
        k = 0
        For i = 0 To nc - 2
            For j = i + 1 To nc - 1
                refrigerant_a(k) = MixtureFeature.FluidsFeature(i).fluid
                refrigerant_b(k) = MixtureFeature.FluidsFeature(j).fluid
                cmbRefrigRefrig.Items.Add(refrigerant_a(k) & " - " & refrigerant_b(k))
                k = k + 1
            Next j
        Next i

        ' default refrigerant-refrigerant setting

        cmbRefrigRefrig.SelectedIndex = 0
        i = cmbRefrigRefrig.SelectedIndex

    End Sub


    Private Function ChgLitRef_REFPROP10(ByRef x As String, ByRef ULine As String) As String 'YYJ[2020.0328] Parser for 'LITERATURE REFERENCE' - compatible with REFPROP 10
        Dim Result As String
        Result = Strings.Replace(x, "?", "")

        If Result = "" Then
            Result = vbCrLf
        ElseIf Strings.Left(Result, 1) = "`" And Strings.Right(Result, 1) = "`" Then
            Result = "LITERATURE REFERENCE" & vbCrLf & ULine & vbCrLf
        End If

        Return Result
    End Function


    Private Sub UpdateLabels()

        modstr = Strings.Left(cmbMixingModel.Text, 3)
        If modstr = "KWR" Or modstr = "KWS" Or modstr = "KWT" Or modstr = "KW0" Or modstr = "KW1" Or modstr = "KW2" Or modstr = "KW3" Or modstr = "KW4" Or modstr = "KW5" Or modstr = "KW6" Or modstr = "KW7" Or modstr = "KW8" Then
            txt1.Text = "BetaT"
            txt2.Text = "GammaT"
            txt3.Text = "BetaV" 'YYJ[2020.0316] correcting param name  '= "Fij"
            txt4.Text = "GammaV" 'YYJ[2020.0316] correcting param name  '= "BetaV"
            txt5.Text = "Fij" 'YYJ[2020.0316] correcting param name  '= "GammaV"
            txt3.Visible = True
            txt4.Visible = True
            txt5.Visible = True
            txtinput3.Visible = True
            txtInput4.Visible = True
            txtInput5.Visible = True
            txtinput1.Text = CStr(inter_coeff_input1)
            txtinput2.Text = CStr(inter_coeff_input2)
            txtinput3.Text = CStr(inter_coeff_input3)
            txtInput4.Text = CStr(inter_coeff_input4)
            txtInput5.Text = CStr(inter_coeff_input5)
        ElseIf modstr = "LIN" Then
            txt1.Text = "Kt"
            txt2.Text = "Kv"
            txt3.Visible = False
            txt4.Visible = False
            txt5.Visible = False
            txtinput3.Visible = False
            txtInput4.Visible = False
            txtInput5.Visible = False
            txtinput1.Text = CStr(inter_coeff_input1)
            txtinput2.Text = CStr(inter_coeff_input2)
        ElseIf modstr = "TR1" Then
            txt1.Text = "Kt"
            txt2.Text = "Kv"
            txt3.Text = "alpha"
            txt4.Text = "beta"
            txt5.Text = "gamma"
            txt3.Visible = True
            txt4.Visible = True
            txt5.Visible = True
            txtinput3.Visible = True
            txtInput4.Visible = True
            txtInput5.Visible = True
            txtinput1.Text = CStr(inter_coeff_input1)
            txtinput2.Text = CStr(inter_coeff_input2)
            txtinput3.Text = CStr(inter_coeff_input3)
            txtInput4.Text = CStr(inter_coeff_input4)
            txtInput5.Text = CStr(inter_coeff_input5)
        Else
            txt1.Text = "zeta" 'YYJ[2020.0316] correcting param name  '= "Kt"
            txt2.Text = "xi" 'YYJ[2020.0316] correcting param name  '= "Kv"
            txt3.Text = "Fpq" 'YYJ[2020.0316] correcting param name  '= "alpha"
            txt4.Text = "beta"
            txt5.Text = "gamma"
            txt3.Visible = True
            txt4.Visible = True
            txt5.Visible = True
            txtinput3.Visible = True
            txtInput4.Visible = True
            txtInput5.Visible = True
            txtinput1.Text = CStr(inter_coeff_input1)
            txtinput2.Text = CStr(inter_coeff_input2)
            txtinput3.Text = CStr(inter_coeff_input3)
            txtInput4.Text = CStr(inter_coeff_input4)
            txtInput5.Text = CStr(inter_coeff_input5)
        End If
    End Sub

    Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApply.Click
        Dim txtstr As String
        Dim i As Integer
        If IsNumeric(txtinput1.Text) = False Then
            txtstr = txt1.Text
            MsgBox(txtstr & " must be a numeric value.")
            Exit Sub
        End If
        If IsNumeric(txtinput2.Text) = False Then
            txtstr = txt2.Text
            MsgBox(txtstr & " must be a numeric value.")
            Exit Sub
        End If
        If IsNumeric(txtinput3.Text) = False And Strings.Left(modstr, 3) <> "LIN" Then
            txtstr = txt3.Text
            MsgBox(txtstr & " must be a numeric value.")
            Exit Sub
        End If
        If IsNumeric(txtInput4.Text) = False And Strings.Left(modstr, 3) <> "LIN" Then
            txtstr = txt4.Text
            MsgBox(txtstr & " must be a numeric value.")
            Exit Sub
        End If
        If IsNumeric(txtInput5.Text) = False And Strings.Left(modstr, 3) <> "LIN" Then
            txtstr = txt5.Text
            MsgBox(txtstr & " must be a numeric value.")
            Exit Sub
        End If
        If CDbl(txtinput1.Text) < 0 Then
            txtstr = txt1.Text
            MsgBox(txtstr & " must be greater than zero.")
            Exit Sub
        End If
        If CDbl(txtinput2.Text) < 0 Then
            txtstr = txt2.Text
            MsgBox(txtstr & " must be greater than zero.")
            Exit Sub
        End If
        If CDbl(txtinput3.Text) < 0 Then
            txtstr = txt3.Text
            MsgBox(txtstr & " must be greater than zero.")
            Exit Sub
        End If
        If CDbl(txtInput4.Text) < 0 Then
            txtstr = txt4.Text
            MsgBox(txtstr & " must be greater than zero.")
            Exit Sub
        End If
        If CDbl(txtInput5.Text) < 0 Then
            txtstr = txt5.Text
            MsgBox(txtstr & " must be greater than zero.")
            Exit Sub
        End If
        i = cmbRefrigRefrig.SelectedIndex

        If ((CDbl(txtinput1.Text) <> inter_coeff_input1) Or (CDbl(txtinput2.Text) <> inter_coeff_input2) Or (CDbl(txtinput3.Text) <> inter_coeff_input3) Or (CDbl(txtInput4.Text) <> inter_coeff_input4) Or (CDbl(txtInput5.Text) <> inter_coeff_input5)) Then
            mixing_value_changed(i) = 1
        Else
            mixing_value_changed(i) = 0
        End If

        If Strings.Left(CStr(cmbMixingModel.Items.Item(cmbMixingModel.SelectedIndex)), 3) <> mixing_mode Then
            mixing_mode_changed(i) = 1
        End If

        If (mixing_value_changed(i) = 0 And mixing_mode_changed(i) = 0) Then
            Exit Sub
        End If


        inter_coeff_input1_set(i) = CDbl(txtinput1.Text)
        inter_coeff_input2_set(i) = CDbl(txtinput2.Text)
        inter_coeff_input3_set(i) = CDbl(txtinput3.Text)
        inter_coeff_input4_set(i) = CDbl(txtInput4.Text)
        inter_coeff_input5_set(i) = CDbl(txtInput5.Text)
        mixing_mode_set(i) = Strings.Left(CStr(cmbMixingModel.Items.Item(cmbMixingModel.SelectedIndex)), 3)
        mixingmodeset(i) = mixing_mode_set(i)

        lblUserDefined.Visible = True
        blnlblUserDefined(i) = True

    End Sub

    Private Sub cmbMixingModel_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbMixingModel.SelectedIndexChanged
        Dim i As Integer
        i = cmbMixingModel.SelectedIndex
        txtReference.Text = mixing_rule_info(i)

        Call UpdateLabels()
        'mixing_mode_changed(i) = 1
        Call show_interaction_coeff()
    End Sub

    Private Sub txtinput1_GotFocus(sender As Object, e As EventArgs) Handles txtinput1.GotFocus
        txtinput1.SelectionStart = 0
        txtinput1.SelectionLength = 15
    End Sub

    Private Sub txtinput2_GotFocus(sender As Object, e As EventArgs) Handles txtinput2.GotFocus
        txtinput2.SelectionStart = 0
        txtinput2.SelectionLength = 15
    End Sub
    Private Sub txtinput3_GotFocus(sender As Object, e As EventArgs) Handles txtinput3.GotFocus
        txtinput3.SelectionStart = 0
        txtinput3.SelectionLength = 15
    End Sub
    Private Sub txtinput4_GotFocus(sender As Object, e As EventArgs) Handles txtInput4.GotFocus
        txtInput4.SelectionStart = 0
        txtInput4.SelectionLength = 15
    End Sub
    Private Sub txtinput5_GotFocus(sender As Object, e As EventArgs) Handles txtInput5.GotFocus
        txtInput5.SelectionStart = 0
        txtInput5.SelectionLength = 15
    End Sub

    Friend Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Dim i, j, k As Integer
        Dim nclocal As Integer
        Dim icomp, jcomp As Integer

        mixing_value_changed(i) = 0
        mixing_mode_changed(i) = 0

        k = 0
        nclocal = FormMixingParameters.MixtureFeature.MixtureFeature.nc
        For i = 1 To nclocal - 1
            For j = i + 1 To nclocal
                blnlblUserDefined(k) = False
                lblUserDefined.Visible = False
                mixingmodeset(k) = ""
                mixing_value_changed(k) = 0
                mixing_mode_changed(k) = 0
                icomp = i
                jcomp = j
                Call refprop_coeff(icomp, jcomp, mixingmodeset(k))
                Call show_interaction_coeff()
                k = k + 1
            Next j
        Next i

        Call refprop_coeff(1, 2, mixingmodeset(0))
        Call show_interaction_coeff()
        txtReference.Text = mixing_rule_info(i)
        Call UpdateLabels()
        cmbRefrigRefrig.SelectedIndex = 0


        For j = 1 To cmbMixingModel.Items.Count
            If Strings.Left(CStr(cmbMixingModel.Items.Item(j - 1)), 3) = mixing_mode Then
                cmbMixingModel.SelectedIndex = j - 1
            End If
        Next

    End Sub
    Friend Sub show_interaction_coeff()
        Dim i As Integer
        i = cmbRefrigRefrig.SelectedIndex
        If i < 0 Then i = 0

        Select Case mixing_value_changed(i)
            Case Is = 1
                If Strings.Left(CStr(cmbMixingModel.Items.Item(cmbMixingModel.SelectedIndex)), 3) = mixing_mode_set(i) Then
                    If blnlblUserDefined(i) = True Then
                        lblUserDefined.Visible = True
                    Else
                        lblUserDefined.Visible = False
                    End If
                    txtinput1.Text = CStr(inter_coeff_input1_set(i))
                    txtinput2.Text = CStr(inter_coeff_input2_set(i))
                    txtinput3.Text = CStr(inter_coeff_input3_set(i))
                    txtInput4.Text = CStr(inter_coeff_input4_set(i))
                    txtInput5.Text = CStr(inter_coeff_input5_set(i))
                ElseIf Strings.Left(CStr(cmbMixingModel.Items.Item(cmbMixingModel.SelectedIndex)), 3) = mixing_mode Then
                    If blnlblUserDefined(i) = True Then
                        lblUserDefined.Visible = True
                    Else
                        lblUserDefined.Visible = False
                    End If
                    txtinput1.Text = CStr(inter_coeff_input1)
                    txtinput2.Text = CStr(inter_coeff_input2)
                    txtinput3.Text = CStr(inter_coeff_input3)
                    txtInput4.Text = CStr(inter_coeff_input4)
                    txtInput5.Text = CStr(inter_coeff_input5)
                Else
                    If blnlblUserDefined(i) = True Then
                        lblUserDefined.Visible = True
                    Else
                        lblUserDefined.Visible = False
                    End If
                    txtinput1.Text = CStr(0)
                    txtinput2.Text = CStr(0)
                    txtinput3.Text = CStr(0)
                    txtInput4.Text = CStr(0)
                    txtInput5.Text = CStr(0)
                End If
            Case Is = 0
                If Strings.Left(CStr(cmbMixingModel.Items.Item(cmbMixingModel.SelectedIndex)), 3) = mixing_mode Then
                    If blnlblUserDefined(i) = True Then
                        lblUserDefined.Visible = True
                    Else
                        lblUserDefined.Visible = False
                    End If
                    txtinput1.Text = CStr(inter_coeff_input1)
                    txtinput2.Text = CStr(inter_coeff_input2)
                    txtinput3.Text = CStr(inter_coeff_input3)
                    txtInput4.Text = CStr(inter_coeff_input4)
                    txtInput5.Text = CStr(inter_coeff_input5)
                Else
                    If blnlblUserDefined(i) = True Then
                        lblUserDefined.Visible = True
                    Else
                        lblUserDefined.Visible = False
                    End If
                    txtinput1.Text = CStr(0)
                    txtinput2.Text = CStr(0)
                    txtinput3.Text = CStr(0)
                    txtInput4.Text = CStr(0)
                    txtInput5.Text = CStr(0)
                End If
        End Select

    End Sub
    Friend Sub refprop_coeff(ByVal icomp As Integer, ByVal jcomp As Integer, mixmodeset As String)

        Dim j As Integer
        Dim ijk1, ijk2, ijk3, k As Integer

        Dim hmodijChar(2) As Char
        Dim hmodijSTR As String

        'YYJ[2020.0425]ltgen2: remove RfLkDLL - s
        'Dim ierr As Integer
        'Dim herr(254), hmxnme(254), hfiles(5099) As Char

        'Dim hmodijChar(2), hfijChar(254), hbinpChar(254), hmxrulChar(254) As Char
        ''Dim hmodijChar(2), hfijChar(47), hbinpChar(254), hmxrulChar(254) As Char


        'Dim hfld(10000 - 1) As Char
        'Dim x(19) As Double
        'Dim h0ref, s0ref, t0ref, p0ref As Double

        'Dim FS As String
        'FS = "|fluids\" 'YYJ[2020.0305] specify full path string

        'With FormMixingParameters.MixtureFeature.MixtureFeature
        '    If .nc = 2 Then
        '        hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & "|", Char())
        '    ElseIf .nc = 3 Then
        '        hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & "|", Char())
        '    ElseIf .nc = 4 Then
        '        hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & "|", Char())
        '    ElseIf .nc = 5 Then
        '        hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & "|", Char())
        '    ElseIf .nc = 6 Then
        '        hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & FS & .comp(5) & "|", Char())
        '    ElseIf .nc = 7 Then
        '        hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & FS & .comp(5) & FS & .comp(6) & "|", Char())
        '    ElseIf .nc = 8 Then
        '        hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & FS & .comp(5) & FS & .comp(6) & FS & .comp(7) & "|", Char())
        '    ElseIf .nc = 9 Then
        '        hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & FS & .comp(5) & FS & .comp(6) & FS & .comp(7) & FS & .comp(8) & "|", Char())
        '    ElseIf .nc = 10 Then
        '        hfld = CType("fluids\" & .comp(0) & FS & .comp(1) & FS & .comp(2) & FS & .comp(3) & FS & .comp(4) & FS & .comp(5) & FS & .comp(6) & FS & .comp(7) & FS & .comp(8) & FS & .comp(9) & "|", Char())
        '    End If
        '    ReDim Preserve hfld(10000 - 1)
        '    Try
        '        Array.ConstrainedCopy(CType("fluids\hmx.bnc", Char()), 0, hfmix, 0, "fluids\hmx.bnc".Length)
        '        hrf = CType("DEF", Char())
        '        For i = 0 To .nc - 1
        '            x(i) = FormMixingParameters.MixtureFeature.MixtureFeature.X(i)
        '        Next

        '        'YYJ[2020.0305] I/F with Wrapper - s
        '        Dim hFldSTR, hFmixSTR, hRfSTR, hErrSTR As String
        '        Dim nFld_len, nFmix_len, nRf_len, nErr_len As Integer

        '        hFldSTR = CStr(hfld)
        '        'hFldSTR = "fluids\R32.FLD|fluids\R125.FLD|fluids\R134A.FLD|"       'hFldSTR = "R32.FLD|R125.FLD|R134A.FLD|"

        '        hFmixSTR = CStr(hfmix)
        '        hFmixSTR += Space(255 - hFmixSTR.Length())
        '        'hFmixSTR = "hmx.bnc" + Space(248)

        '        hRfSTR = CStr(hrf)
        '        'hRfSTR = "DEF"

        '        hErrSTR = Space(255)
        '        nFld_len = hFldSTR.Length()
        '        nFmix_len = hFmixSTR.Length()
        '        nRf_len = hRfSTR.Length()
        '        nErr_len = hErrSTR.Length()
        '        Call SETUP0(.nc, hFldSTR, hFmixSTR, hRfSTR, ierr, hErrSTR, nFld_len, nFmix_len, nRf_len, nErr_len)

        '        Call SATSPLN_dll(.X(0), ierr, hErrSTR, nErr_len) 'YYJ[2020.0305] deliver arg#1 not as array but as scalar --> Refprop_.NET_example.vb, L#41 shows similar programming pattern. Keep this way.
        '        'Call SATSPLN_dll(.X(0), ierr, herr)

        '        If (.nc > 1) Then
        '            Call SETREF_dll(hRfSTR, 2, x(0), h0ref, s0ref, t0ref, p0ref, ierr, hErrSTR, nRf_len, nErr_len)
        '        End If
        '        'If (.nc > 1) Then Call SETREF_dll(hrf, 2, x(0), h0ref, s0ref, t0ref, p0ref, ierr, herr)

        '        Call CRITP_dll(.X(0), .tc, .pc, .dc, ierr, hErrSTR, nErr_len) 'YYJ[2020.0305] deliver arg#1 not as array but as scalar --> Refprop_.NET_example.vb, L#41 shows similar programming pattern. Keep this way.
        '        'Call CRITP_dll(.X(0), .tc, .pc, .dc, ierr, herr)

        '        'YYJ[2020.0305] I/F with Wrapper - e


        '        If .FileName = "R401C.mix" And .tc < 384.5 Then
        '            '.tc = Tcfile
        '            'need to check if this is really true; do we have a Tcfile????
        '        End If



        '    Catch ex As Exception
        '        MsgBox("An exception occurred, please restart the program and try again.")
        '    End Try
        'End With

        ''j = 1
        ''k = 2
        'Dim hfmixSTR_org As String = CStr(hfmix)
        'Dim hfijSTR As String = CStr(hfijChar)
        'Dim hbinpSTR As String = CStr(hbinpChar)
        'Dim hmxrulSTR As String = CStr(hmxrulChar)

        ''YYJ[2020.0305] I/F with Wrapper - s 
        'Dim hmodijSTR_len, hfmixSTR_org_len, hfijSTR_len, hbinpSTR_len, hmxrulSTR_len As Integer
        'hmodijSTR_len = hmodijSTR.Length()
        'hfmixSTR_org_len = hfmixSTR_org.Length()
        'hfijSTR_len = hfijSTR.Length()
        'hbinpSTR_len = hbinpSTR.Length()
        'hmxrulSTR_len = hmxrulSTR.Length()
        ''End



        'Call GETKTV(icomp, jcomp, hmodijSTR, fij(0), hfmixSTR_org, hfijSTR, hbinpSTR, hmxrulSTR,
        '            hmodijSTR_len, hfmixSTR_org_len, hfijSTR_len, hbinpSTR_len, hmxrulSTR_len) 'YYJ[2020.0305] TODO: 배열 arg 확인할 것: arg#4 (예전에는 스칼라였음) --> 일단은, Refprop_.NET_example.vb 의 L#41에서도 벡터를 스칼라 취급하고 있으니(기존 legacy code또한 그러했음) 일단은 이 패턴을 따라가본다
        ''Call GETKTV(j, k, hmodij, fij(0), hfmixSTR, hfijSTR, hbinpSTR, hmxrulSTR)
        ''Call GETKTV(icomp, jcomp, hmodij, fij(0), hfmixSTR, hfijSTR, hbinpSTR, hmxrulSTR)
        ''YYJ[2020.0305] I/F with Wrapper - e
        'YYJ[2020.0425]ltgen2: remove RfLkDLL - e
        'End

        hmodijSTR = CStr(hmodijChar)

        k = 0
        For ijk1 = 1 To FormMixingParameters.MixtureFeature.MixtureFeature.nc - 1
            For ijk2 = ijk1 + 1 To FormMixingParameters.MixtureFeature.MixtureFeature.nc
                If (ijk1 = icomp And ijk2 = jcomp) Then
                    ijk3 = k
                End If
                k = k + 1
            Next ijk2
        Next ijk1

        If blnlblUserDefined(ijk3) = True Then
            inter_coeff_input1 = inter_coeff_input1_set(ijk3)
            inter_coeff_input2 = inter_coeff_input2_set(ijk3)
            inter_coeff_input3 = inter_coeff_input3_set(ijk3)
            inter_coeff_input4 = inter_coeff_input4_set(ijk3)
            inter_coeff_input5 = inter_coeff_input5_set(ijk3)

            hmodijSTR = mixmodeset
            'hmodij = mixmodeset

            lblUserDefined.Visible = True
        Else
            inter_coeff_input1 = fij(0)
            inter_coeff_input2 = fij(1)
            inter_coeff_input3 = fij(2)
            inter_coeff_input4 = fij(3)
            inter_coeff_input5 = fij(4)
            lblUserDefined.Visible = True
        End If
        For j = 1 To cmbMixingModel.Items.Count
            If Strings.Left(CStr(cmbMixingModel.Items.Item(j - 1)), 3) = hmodijSTR Then
                'If Strings.Left(CStr(cmbMixingModel.Items.Item(j - 1)), 3) = hmodij Then
                cmbMixingModel.SelectedIndex = j - 1
            End If
        Next
        mixing_mode = hmodijSTR
        'mixing_mode = hmodij
    End Sub
    Private Sub cmbRefrigRefrig_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbRefrigRefrig.SelectedIndexChanged
        Dim i, j, k As Integer
        Dim icomp, jcomp As Integer
        Dim nclocal As Integer

        nclocal = FormMixingParameters.MixtureFeature.MixtureFeature.nc
        k = 0
        For i = 1 To nclocal - 1
            For j = i + 1 To nclocal
                If (k = cmbRefrigRefrig.SelectedIndex) Then
                    icomp = i
                    jcomp = j
                    Call refprop_coeff(icomp, jcomp, mixingmodeset(k))
                    Call show_interaction_coeff()
                End If
                k = k + 1
            Next j
        Next i

        i = cmbMixingModel.SelectedIndex
        j = cmbRefrigRefrig.SelectedIndex + 1
        If mixing_mode_changed(j) = 1 Then
            For k = 1 To cmbMixingModel.Items.Count
                If Strings.Left(CStr(cmbMixingModel.Items.Item(k - 1)), 3) = mixing_mode_set(j) Then
                    cmbMixingModel.SelectedIndex = k - 1
                End If
            Next



        End If
        txtReference.Text = mixing_rule_info(i)


    End Sub

    Private Sub txtinput1_leave(sender As System.Object, e As System.EventArgs) Handles txtinput1.Leave
        Dim DbNum As Double
        Try
            DbNum = CDbl(txtinput1.Text)
        Catch ex As InvalidCastException
            MsgBox("Please insert a numeric value.")
            txtinput1.SelectAll()
            txtinput1.Focus()
            Exit Sub
        End Try
        txtinput1.Text = Format(DbNum, "#0.0000000")
    End Sub
    Private Sub txtinput2_leave(sender As System.Object, e As System.EventArgs) Handles txtinput2.Leave
        Dim DbNum As Double
        Try
            DbNum = CDbl(txtinput2.Text)
        Catch ex As InvalidCastException
            MsgBox("Please insert a numeric value.")
            txtinput2.SelectAll()
            txtinput2.Focus()
            Exit Sub
        End Try
        txtinput2.Text = Format(DbNum, "#0.0000000")
    End Sub
    Private Sub txtinput3_leave(sender As System.Object, e As System.EventArgs) Handles txtinput3.Leave
        Dim DbNum As Double
        Try
            DbNum = CDbl(txtinput3.Text)
        Catch ex As InvalidCastException
            MsgBox("Please insert a numeric value.")
            txtinput3.SelectAll()
            txtinput3.Focus()
            Exit Sub
        End Try
        txtinput3.Text = Format(DbNum, "#0.0000000")
    End Sub
    Private Sub txtinput4_leave(sender As System.Object, e As System.EventArgs) Handles txtInput4.Leave
        Dim DbNum As Double
        Try
            DbNum = CDbl(txtInput4.Text)
        Catch ex As InvalidCastException
            MsgBox("Please insert a numeric value.")
            txtInput4.SelectAll()
            txtInput4.Focus()
            Exit Sub
        End Try
        txtInput4.Text = Format(DbNum, "#0.0000000")
    End Sub
    Private Sub txtinput5_leave(sender As System.Object, e As System.EventArgs) Handles txtInput5.Leave
        Dim DbNum As Double
        Try
            DbNum = CDbl(txtInput5.Text)
        Catch ex As InvalidCastException
            MsgBox("Please insert a numeric value.")
            txtInput5.SelectAll()
            txtInput5.Focus()
            Exit Sub
        End Try
        txtInput5.Text = Format(DbNum, "#0.0000000")
    End Sub

End Class