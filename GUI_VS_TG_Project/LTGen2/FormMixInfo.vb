Public Class FormMixInfo
    Friend TBPerSummary As DataTable
    Friend MixtureFeature As FluidFeatureSTR
    Private Sub FormMixInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim UnitPressure, UnitTemp, UnitDensity As String
        Dim CritPressure, CritTemp, Density As Double
        CritTemp = Me.MixtureFeature.tc : CritPressure = Me.MixtureFeature.pc
        Density = Me.MixtureFeature.dc * Me.MixtureFeature.wm
        Select Case BordConditions.Unit
            Case "SI with K"
                'First TabControl Page
                UnitPressure = DataTableUnits.Rows(0).Item("Pressure").ToString
                UnitTemp = DataTableUnits.Rows(0).Item("Temperature").ToString
                UnitDensity = DataTableUnits.Rows(0).Item("Density").ToString
            Case "SI with °C"
                UnitPressure = DataTableUnits.Rows(1).Item("Pressure").ToString
                UnitTemp = DataTableUnits.Rows(1).Item("Temperature").ToString
                UnitDensity = DataTableUnits.Rows(1).Item("Density").ToString
                CritTemp = TKtoTC(CritTemp)
            Case "I-P Inch-Pund"
                UnitPressure = DataTableUnits.Rows(2).Item("Pressure").ToString
                UnitTemp = DataTableUnits.Rows(2).Item("Temperature").ToString
                UnitDensity = DataTableUnits.Rows(2).Item("Density").ToString
                CritPressure = KPAtoPSI(CritPressure) : CritTemp = TKtoTE(CritTemp)
                Density = DSItoDE(Density)
            Case Else   ' "SI with K"
                UnitPressure = DataTableUnits.Rows(0).Item("Pressure").ToString
                UnitTemp = DataTableUnits.Rows(0).Item("Temperature").ToString
                UnitDensity = DataTableUnits.Rows(0).Item("Density").ToString
        End Select
        Me.lblFluid.Text = Me.MixtureFeature.fluid
        Me.lblCritTemp.Text = Math.Round(CritTemp, 2).ToString & " " & UnitTemp
        Me.lblCritPress.Text = Math.Round(CritPressure, 2).ToString & " " & UnitPressure
        Me.lblCritDens.Text = Math.Round(Density, 2).ToString & " " & UnitDensity

        Me.GridComposition.DataSource = TBPerSummary.Copy
        For i As Integer = 0 To Me.GridComposition.Columns.Count - 1
            Me.GridComposition.Columns(i).SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Next i
        Me.GridComposition.Height = Me.GridComposition.RowTemplate.Height * (Me.GridComposition.Rows.Count + 1)
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Me.Close()
    End Sub
End Class