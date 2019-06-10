Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_importe_total.Text = 0
    End Sub

    Private Sub Btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        lbl_importe_total.Show()
        txt_kw = txt_kw
        lbl_importe_total.Text = Modulo1.Calcular(txt_kw.Text)
    End Sub
End Class
