Module ConvertUnit
    'This Modile contains the function to convert the measurement unit
    Public Function TKtoTC(ByVal TK As Double) As Double
        TKtoTC = TK - 273.15
    End Function
    Public Function TCtoTK(ByVal TC As Double) As Double
        TCtoTK = TC + 273.15
    End Function
    Public Function TKtoTE(ByVal TK As Double) As Double
        TKtoTE = (TK - 273.15) * 9 / 5 + 32
    End Function
    Public Function TEtoTK(ByVal TE As Double) As Double
        TEtoTK = 273.15 + (TE - 32) * 5 / 9
    End Function
    Public Function TCtoTE(ByVal TK As Double) As Double
        TCtoTE = TK * 9 / 5 + 32
    End Function
    Public Function TEtoTC(ByVal TE As Double) As Double
        TEtoTC = (TE - 32) * 5 / 9
    End Function
    Public Function DTKtoDTE(ByVal DTK As Double) As Double
        DTKtoDTE = DTK * 9 / 5
    End Function
    Public Function DTEtoDTK(ByVal DTE As Double) As Double
        DTEtoDTK = DTE * 5 / 9
    End Function
    Public Function KPAtoPSI(ByVal KPA As Double) As Double
        KPAtoPSI = KPA / 6.8947
    End Function
    Public Function PSItokPa(ByVal PSI As Double) As Double
        PSItokPa = PSI * 6.8947
    End Function
    Public Function DSItoDE(ByVal DSI As Double) As Double
        DSItoDE = DSI / 16.019
    End Function
    Public Function LmtoLft(ByVal Length As Double) As Double 'meter to ft  
        LmtoLft = Length / 0.3048
    End Function
    Public Function LfttoLm(ByVal Length As Double) As Double 'ft to meter
        LfttoLm = Length * 0.3048
    End Function
    Public Function Lm2toLft2(ByVal Area As Double) As Double 'meter to ft  
        Lm2toLft2 = Area / 0.3048 ^ 2
    End Function
    Public Function Lf2ttoLm2(ByVal Area As Double) As Double 'ft to meter
        Lf2ttoLm2 = Area * 0.3048 ^ 2
    End Function
    Public Function KAEtoKASI(ByVal KA As Double) As Double 'Btu/(h F)to KW/°C
        KAEtoKASI = KA * ((0.293 * 1.8) / 1000)
    End Function
    Public Function KASItoKAE(ByVal KAE As Double) As Double 'KW/°C to Btu/(h F)
        KASItoKAE = KAE / ((0.293 * 1.8) / 1000)
    End Function
    Public Function MassFluxSItoMassFluxE(ByVal MassFlux As Double) As Double 'Kg/m^2s to lb/(ft^2 h)
        MassFluxSItoMassFluxE = MassFlux * (7936.64144 * 0.3048 ^ 2)
    End Function
    Public Function MassFluxEtoMassFluxSI(ByVal MassFlux As Double) As Double 'lb/(ft^2 h)to Kg/m^2s 
        MassFluxEtoMassFluxSI = MassFlux / (7936.64144 * 0.3048 ^ 2)
    End Function
    Public Function kWSItoTonsE(ByVal Power As Double) As Double 'kW to Tons
        kWSItoTonsE = Power / 3.516667
    End Function
    Public Function TonsSItoEkW(ByVal Power As Double) As Double 'Tons To kW
        TonsSItoEkW = Power * 3.516667
    End Function
    Public Function kWtoBtu_h(ByVal Power As Double) As Double 'kW to Btu/h
        kWtoBtu_h = Power / 0.29307107
    End Function
    Public Function Btu_htokW(ByVal Power As Double) As Double 'Btu/h To kW
        Btu_htokW = Power * 0.29307107
    End Function
    Public Function VspecSItoE(ByVal SepcVol As Double) As Double
        VspecSItoE = SepcVol / 0.06243
    End Function
    Public Function VspecEtoSI(ByVal SepcVol As Double) As Double
        VspecEtoSI = SepcVol * 0.06243
    End Function
    Public Function h_SI_to_h_E(ByVal Enthalpy As Double) As Double  'kJ/kg To Btu/lb
        h_SI_to_h_E = Enthalpy * 0.43021
    End Function
    Public Function h_E_to_h_SI(ByVal Enthalpy As Double) As Double  'Btu/lb To kJ/kg
        h_E_to_h_SI = Enthalpy / 0.43021
    End Function
    Public Function s_SI_to_s_E(ByVal Entropy As Double) As Double 'kJ/(kg K) To Btu/(lb R)
        s_SI_to_s_E = Entropy * 0.23901
    End Function
    Public Function s_E_to_s_SI(ByVal Entropy As Double) As Double  'Btu/(lb R) To kJ/(kg K)
        s_E_to_s_SI = Entropy / 0.23901
    End Function

End Module
