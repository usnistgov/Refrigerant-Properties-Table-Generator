Public Class FormPureInfo
    Friend FluidFeature As FluidFeatureSTR
    Private Sub FormPureInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim UnitPressure, UnitTemp, UnitDensity, UnitMolMass As String
        Dim CritPressure, CritTemp, Density, MolMass, NbTemp As Double

        CritPressure = Me.FluidFeature.pc : CritTemp = Me.FluidFeature.tc
        Density = Me.FluidFeature.dc * Me.FluidFeature.wm : MolMass = Me.FluidFeature.wm
        NbTemp = Me.FluidFeature.tnbpt

        Select Case BordConditions.Unit
            Case "SI with K"
                'First TabControl Page
                UnitPressure = DataTableUnits.Rows(0).Item("Pressure").ToString
                UnitTemp = DataTableUnits.Rows(0).Item("Temperature").ToString
                UnitDensity = DataTableUnits.Rows(0).Item("Density").ToString
                UnitMolMass = DataTableUnits.Rows(0).Item("MolecularMass").ToString
            Case "SI with °C"
                UnitPressure = DataTableUnits.Rows(1).Item("Pressure").ToString
                UnitTemp = DataTableUnits.Rows(1).Item("Temperature").ToString
                UnitDensity = DataTableUnits.Rows(1).Item("Density").ToString
                UnitMolMass = DataTableUnits.Rows(1).Item("MolecularMass").ToString
                CritTemp = TKtoTC(CritTemp) : NbTemp = TKtoTC(CritTemp) : NbTemp = TKtoTC(NbTemp)
            Case "I-P Inch-Pund"
                UnitPressure = DataTableUnits.Rows(2).Item("Pressure").ToString
                UnitTemp = DataTableUnits.Rows(2).Item("Temperature").ToString
                UnitDensity = DataTableUnits.Rows(2).Item("Density").ToString
                UnitMolMass = DataTableUnits.Rows(2).Item("MolecularMass").ToString
                CritPressure = KPAtoPSI(CritPressure) : CritTemp = TKtoTE(CritTemp)
                Density = DSItoDE(Density) : NbTemp = TKtoTE(NbTemp)
            Case Else   ' "SI with K"
                UnitPressure = DataTableUnits.Rows(0).Item("Pressure").ToString
                UnitTemp = DataTableUnits.Rows(0).Item("Temperature").ToString
                UnitDensity = DataTableUnits.Rows(0).Item("Density").ToString
                UnitMolMass = DataTableUnits.Rows(0).Item("MolecularMass").ToString
        End Select
        Me.lblFluid.Text = Me.FluidFeature.fluid
        Me.lblCritTemp.Text = Math.Round(CritTemp, 2).ToString & " " & UnitTemp
        Me.lblCritPress.Text = Math.Round(CritPressure, 2).ToString & " " & UnitPressure
        Me.lblCritDens.Text = Math.Round(Density, 2).ToString & " " & UnitDensity
        Me.lblChemName.Text = Me.FluidFeature.chemname
        Me.lblFullName.Text = Me.FluidFeature.fullname
        Me.lblCAS.Text = Me.FluidFeature.cas
        Me.lblWm.Text = Math.Round(MolMass, 2).ToString & " " & UnitMolMass
        Me.lblNBP.Text = Math.Round(Me.FluidFeature.tnbpt, 2).ToString & " " & UnitTemp
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Me.Close()
    End Sub
End Class