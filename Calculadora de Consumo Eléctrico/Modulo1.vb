Module Modulo1
    Public txt_kw As Double
    Public txt_total As Double
    Public Function Calcular(txt_kw As Double)
        Dim total_kw As Double
        Dim treinta_kw As Double
        Dim cien_kw As Double
        Dim doscientos_kw As Double
        Dim excedente As Double
        If [txt_kw] < 30 Then
            treinta_kw = txt_kw
            treinta_kw = (treinta_kw * 0.5)
            total_kw = treinta_kw
        ElseIf [txt_kw] <= 100 Then
            treinta_kw = 30
            cien_kw = txt_kw
            cien_kw = ((cien_kw - treinta_kw) * 0.7)
            total_kw = ((treinta_kw * 0.5) + cien_kw)
        ElseIf [txt_kw] <= 200 Then
            treinta_kw = 30
            cien_kw = 70
            doscientos_kw = txt_kw
            doscientos_kw = ((doscientos_kw - (treinta_kw + cien_kw)) * 0.85)
            total_kw = ((treinta_kw * 0.5) + (cien_kw * 0.7) + doscientos_kw)
        ElseIf [txt_kw] > 200 Then
            treinta_kw = 30
            cien_kw = 70
            doscientos_kw = 100
            excedente = txt_kw
            excedente = (excedente - (treinta_kw + cien_kw + doscientos_kw) * 1.7)
            total_kw = (treinta_kw * 0.5) + (cien_kw * 0.7) + (doscientos_kw * 0.85) + excedente
        End If
        Return total_kw
    End Function
End Module
