Imports System.IO
Imports System.Runtime.InteropServices

Public Class FormMixComp
    Friend MixtureFeature As FluidFeatureSTR
    Friend MixtureComponents() As FluidFeatureSTR
    Friend TBPerSummary As DataTable
    Private ColumnEnabled, ColumnNotEnabled As Integer
    Private FirstPassage As Boolean
    Private MixName As String = String.Empty
    Friend MixFileName As String = String.Empty
    Friend PushOk As Boolean = False
    Friend FlagStored As Boolean            'T: Stored , F:Just Ok
    Private Sub FormMixComp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FirstPassage = True
        Me.GridComposition.DataSource = TBPerSummary.Copy

        'YYJ[2020.0727]ltgen2: Saving *.FLD filename to TableInfo.txt (hide FLD column)
        Me.GridComposition.Columns(3).Visible = False

        Me.GridComposition.Height = Me.GridComposition.RowTemplate.Height * (Me.GridComposition.Rows.Count + 1) + 1

        Me.GridComposition.Size = New System.Drawing.Size(282, ((Me.MixtureFeature.nc + 1) * 23))
        If Me.MixtureFeature.nc > 4 Then
            Me.frm2.Height = 217 + (Me.MixtureFeature.nc - 5) * 28
        Else
            Me.frm2.Height = 217 + (Me.MixtureFeature.nc - 5) * 20
        End If
        Me.cmdStore.Location = New Point(12, 10 + (277 + (Me.MixtureFeature.nc - 5) * 28))
        Me.cmdOk.Location = New Point(144, 10 + (277 + (Me.MixtureFeature.nc - 5) * 28))
        Me.cmdCancel.Location = New Point(259, 10 + (277 + (Me.MixtureFeature.nc - 5) * 28))
        Me.Height = 344 + (Me.MixtureFeature.nc - 5) * 28 + 30
        Me.comboFraction.SelectedIndex = 1
        Me.comboFraction_SelectedIndexChanged(Nothing, Nothing)
        'Start with the Molar mass
        For i As Integer = 0 To Me.GridComposition.Columns.Count - 1
            Me.GridComposition.Columns(i).SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Next i
        Me.GridComposition.Columns(0).DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GridComposition.Columns(0).DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        Me.GridComposition.Columns(0).DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLight
        For i As Integer = 0 To MixtureFeature.nc - 1
            MixName = MixName & MixtureComponents(i).fluid
            If i <> (MixtureFeature.nc - 1) Then MixName = MixName & "-"
        Next i
        Me.TextAddress.Text = MixName
        Me.TextSum.Text = CStr(Math.Round(1.0, 3))
        'Me.GridComposition.CurrentCell.Selected = False
    End Sub
    Private Sub GridComposition_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles GridComposition.CellBeginEdit
        If (Me.GridComposition.CurrentCell.ColumnIndex = 0 Or Me.GridComposition.CurrentCell.ColumnIndex = ColumnNotEnabled) Then
            e.Cancel = True                                             'Stop edit
            Me.GridComposition.CurrentCell.Selected = False             'Stop selection
            Dim mio_stile As New DataGridViewAdvancedBorderStyle
            mio_stile.All = DataGridViewAdvancedCellBorderStyle.None
            Me.GridComposition.Rows(e.RowIndex).Cells(e.ColumnIndex).AdjustCellBorderStyle(mio_stile, mio_stile, False, False, False, False)
        End If
    End Sub
    Private Sub comboFraction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboFraction.SelectedIndexChanged
        Dim sum As Double
        If Me.comboFraction.SelectedIndex = 0 Then 'Mass fraction
            ColumnNotEnabled = 1
            ColumnEnabled = 2
        Else                                        'Molar fraction
            ColumnNotEnabled = 2
            ColumnEnabled = 1
        End If
        'Refresh the sum Text box
        sum = 0
        For i As Integer = 0 To Me.GridComposition.RowCount - 1
            sum += CDbl(Me.GridComposition.Item(ColumnEnabled, i).Value)
        Next i
        Me.TextSum.Text = Math.Round(sum, 3).ToString
        Me.GridComposition.Columns(ColumnEnabled).DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
        Me.GridComposition.Columns(ColumnEnabled).DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlText
        Me.GridComposition.Columns(ColumnEnabled).DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.GridComposition.Columns(ColumnNotEnabled).DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GridComposition.Columns(ColumnNotEnabled).DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        Me.GridComposition.Columns(ColumnNotEnabled).DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLight
        If Me.GridComposition.CurrentCell IsNot Nothing Then Me.GridComposition.CurrentCell.Selected = False

        FirstPassage = False
    End Sub
    Private Sub GridComposition_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridComposition.CellEndEdit
        If Not FirstPassage Then
            Dim WmMixture As Double = 0
            Dim sum As Double = 0
            Me.GridComposition.RefreshEdit()
            For i As Integer = 0 To Me.MixtureFeature.nc - 1
                If ColumnEnabled = 1 Then 'Molar fraction
                    WmMixture += CDbl(Me.GridComposition.Item(ColumnEnabled, i).Value) * Me.MixtureComponents(i).wm
                    sum += CDbl(Me.GridComposition.Item(ColumnEnabled, i).Value)
                Else
                    WmMixture += (CDbl(Me.GridComposition.Item(ColumnEnabled, i).Value)) / Me.MixtureComponents(i).wm
                    sum += CDbl(Me.GridComposition.Item(ColumnEnabled, i).Value)
                End If
            Next i
            If ColumnEnabled = 2 Then WmMixture = 1 / WmMixture
            Me.MixtureFeature.wm = WmMixture
            Me.TextSum.Text = Math.Round(sum, 3).ToString
            For i As Integer = 0 To Me.MixtureFeature.nc - 1
                If ColumnEnabled = 1 Then 'Molar fraction
                    Me.GridComposition.Item(ColumnNotEnabled, i).Value = CDbl(Me.GridComposition.Item(ColumnEnabled, i).Value) * Me.MixtureComponents(i).wm / Me.MixtureFeature.wm
                Else
                    Me.GridComposition.Item(ColumnNotEnabled, i).Value = CDbl(Me.GridComposition.Item(ColumnEnabled, i).Value) / Me.MixtureComponents(i).wm * Me.MixtureFeature.wm
                End If
            Next i
        End If
    End Sub
    Private Sub GridComposition_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridComposition.Leave
        Me.GridComposition.CurrentCell.Selected = False
    End Sub
    Private Sub GridComposition_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles GridComposition.DataError
        MsgBox("A numerical value must be inserted")
    End Sub
    Private Sub cmdStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStore.Click
        Dim StringDummy As String
        If SumControlOk() = False Then
            Exit Sub
        End If
        Me.PushOk = True
        ' Go to the local user folder and create the UserMixtureFolder if it does not exist

        'YYJ[2020.1119]ltgen2: make a portable version - s
        If Not My.Computer.FileSystem.DirectoryExists(ApplicationFolder & "\UserDefinedMixture") Then
            My.Computer.FileSystem.CreateDirectory(ApplicationFolder & "\UserDefinedMixture")
        End If
        'If Not My.Computer.FileSystem.DirectoryExists(UserApplicationFolder & "\UserDefinedMixture") Then
        '    My.Computer.FileSystem.CreateDirectory(UserApplicationFolder & "\UserDefinedMixture")
        'End If
        'YYJ[2020.1119]ltgen2: make a portable version - e

        On Error GoTo ErrorHandler

        'YYJ[2020.1119]ltgen2: make a portable version - s
        Me.SaveFileDialog1.InitialDirectory = ApplicationFolder & "\UserDefinedMixture"
        Me.SaveFileDialog1.InitialDirectory = ApplicationFolder & "\UserDefinedMixture"
        'YYJ[2020.1119]ltgen2: make a portable version - e

        Me.SaveFileDialog1.FileName = ""
        Me.SaveFileDialog1.DefaultExt = ".mix"
        Me.SaveFileDialog1.Filter = "(*.mix)|*.mix"
        Me.SaveFileDialog1.AddExtension = True
        Me.SaveFileDialog1.OverwritePrompt = True
        Dim Risultato As Boolean = CBool(Me.SaveFileDialog1.ShowDialog)
        If Risultato = True Then
            'Refesh the data for the mixture
            Me.RefreshData()
            MixFileName = Strings.Right(Me.SaveFileDialog1.FileName, Strings.Len(Me.SaveFileDialog1.FileName) - Strings.InStrRev(Me.SaveFileDialog1.FileName, "\"))
            MixName = Strings.Left(MixFileName, Strings.InStrRev(MixFileName, ".") - 1)
            FileOpen(1, Me.SaveFileDialog1.FileName, OpenMode.Output)
            With MixtureFeature
                'Set the file name over the mixture name, else the name assigned in the Text box remain
                .fluid = MixName
                PrintLine(1, MixName)
                PrintLine(1, .wm, .tc, .pc, .dc)
                PrintLine(1, .nc)
                For i As Integer = 0 To .nc - 1
                    PrintLine(1, .comp(i))
                Next i
                For i As Integer = 0 To .nc - 1
                    PrintLine(1, .X(i))
                Next i
                PrintLine(1, 0)
                FileClose(1)
                If Internat Then ' The file must be written with doc as separator
                    Dim StartMolFrac As Integer
                    Dim lines As String() = File.ReadAllLines(Me.SaveFileDialog1.FileName)
                    lines(1) = Replace(lines(1), ",", ".")
                    StartMolFrac = 3 + .nc          'Only the double are replaced
                    For i = StartMolFrac To StartMolFrac + .nc - 1
                        lines(i) = Replace(lines(i), ",", ".")
                    Next i
                    File.WriteAllLines(Me.SaveFileDialog1.FileName, lines)
                End If
            End With
            Me.FlagStored = True
        End If
        'MsgBox("Number:" & CStr(Err.Number) & vbCrLf & "An unknown error occurred. Please report it to piotr.domanski@nist.gov.", MsgBoxStyle.OkOnly)
ErrorHandler:
        Select Case Err.Number
            Case 53
            Case 0
            Case 5
                Exit Sub
            Case 70
                MsgBox("The file is already open.  Please close the file and try again or specify a different file name.")
                Me.SaveFileDialog1.FileName = ""
                Call cmdStore_Click(cmdStore, New System.EventArgs())
            Case 75
                Exit Sub
            Case Else
                MsgBox("ErrorCode:" & CStr(Err.Number) & vbCrLf & "An unknown error occurred. Please report it to piotr.domanski@nist.gov.", MsgBoxStyle.OkOnly)
        End Select
        Me.Close()
    End Sub
    Private Function SumControlOk() As Boolean
        SumControlOk = True
        'Control over the mass/mole fraction Sum
        If CDbl(Me.TextSum.Text) > 1.0001 And Me.comboFraction.SelectedIndex = 1 Then 'Mole fraction
            MsgBox("The sum of the mole fractions cannot exceed one.  Please try again.")
            SumControlOk = False
        ElseIf CDbl(Me.TextSum.Text) > 1.0001 And Me.comboFraction.SelectedIndex = 0 Then 'Mass fraction
            MsgBox("The sum of the mass fractions cannot exceed one.  Please try again.")
            SumControlOk = False
        ElseIf CDbl(Me.TextSum.Text) < 0.9999 And Me.comboFraction.SelectedIndex = 1 Then
            MsgBox("The sum of the mole fractions must equal one.  Please try again.")
            SumControlOk = False
        ElseIf CDbl(Me.TextSum.Text) < 0.9999 And Me.comboFraction.SelectedIndex = 0 Then
            MsgBox("The sum of the mass fractions must equal one.  Please try again.")
            SumControlOk = False
        End If
        'Grid control
        For j As Integer = 0 To Me.GridComposition.Columns.Count - 1
            For i As Integer = 0 To Me.GridComposition.Rows.Count - 1
                If TypeOf (Me.GridComposition.Item(j, i).Value) Is Double Then
                    If CDbl(Me.GridComposition.Item(j, i).Value) <= 0 Then
                        MsgBox("A coefficient value >=0 must be inserted")
                        SumControlOk = False
                        Exit Function
                    End If
                End If
            Next i
        Next j
    End Function
    Private Sub RefreshData()
        Dim t0ref, h0ref, s0ref, p0ref As Double
        Dim herr(255 - 1), hfmix(255 - 1) As Char
        Dim hrf(3) As Char
        Dim hfld(10000 - 1) As Char
        Dim ierr As Integer
        Me.GridComposition.Refresh()
        Dim SummaryTB As New DataTable
        SummaryTB = CType(Me.GridComposition.DataSource, DataTable)
        Dim Row As DataRow
        Me.MixtureFeature.fluid = Me.TextAddress.Text
        Me.MixtureFeature.wm = 0
        Me.MixtureFeature.X.Initialize()
        For i As Integer = 0 To SummaryTB.Rows.Count - 1
            Row = SummaryTB.Rows(i)
            Me.MixtureComponents(i).fluid = Row("Component").ToString
            Me.MixtureFeature.X(i) = CDbl(Row("MoleFraction"))
            Me.MixtureFeature.WmElements(i) = CDbl(Row("MassFraction"))
            Me.MixtureFeature.wm += Me.MixtureFeature.X(i) * Me.MixtureComponents(i).wm
        Next i

        'YYJ[2020.0425]ltgen2: remove RfLkDLL - s
        'Dim FS As String
        'FS = "|fluids\" 'YYJ[2020.0305] specify full path string

        'With Me.MixtureFeature
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
        '    Directory.SetCurrentDirectory(ApplicationFolder)

        '    Try
        '        hfmix = CType("fluids\hmx.bnc", Char())
        '        ReDim Preserve hfmix(255 - 1) 'YYJ[2020.0312] BugFix: ReDim Preserve hfmix(255)
        '        hrf = CType("DEF", Char())

        '        'YYJ[2020.0305] I/F with Wrapper - s
        '        Dim hFldSTR, hFmixSTR, hRfSTR, hErrSTR As String
        '        Dim nFld_len, nFmix_len, nRf_len, nErr_len As Integer

        '        hFldSTR = CStr(hfld)
        '        hFmixSTR = CStr(hfmix)
        '        hFmixSTR += Space(255 - hFmixSTR.Length())
        '        hRfSTR = CStr(hrf)
        '        hErrSTR = Space(255)
        '        nFld_len = hFldSTR.Length()
        '        nFmix_len = hFmixSTR.Length()
        '        nRf_len = hRfSTR.Length()
        '        nErr_len = hErrSTR.Length()

        '        Call SETUP0(.nc, hFldSTR, hFmixSTR, hRfSTR, ierr, hErrSTR, nFld_len, nFmix_len, nRf_len, nErr_len)
        '        Call SATSPLN_dll(.X(0), ierr, hErrSTR, nErr_len)

        '        If (.nc > 1) Then
        '            Call SETREF_dll(hRfSTR, 2, .X(0), h0ref, s0ref, t0ref, p0ref, ierr, hErrSTR, nRf_len, nErr_len)
        '        End If

        '        .tc = 0 : .pc = 0 : .dc = 0
        '        Call CRITP_dll(.X(0), .tc, .pc, .dc, ierr, hErrSTR, nErr_len)
        '        Call WMOL_dll(.X(0), .wm)
        '        'YYJ[2020.0305] I/F with Wrapper - e


        '    Catch ex As Exception
        '        MsgBox("An exception occurred, please restart the program and try again.")
        '    End Try
        'End With
        'YYJ[2020.0425]ltgen2: remove RfLkDLL - e
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If SumControlOk() = False Then
            Exit Sub
        Else
            Me.RefreshData()
            Me.PushOk = True
            Me.FlagStored = False
            Me.Close()
        End If
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.FlagStored = False
        Me.Close()
    End Sub
End Class