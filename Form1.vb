Public Class Form1
    Dim caraBayar As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbKodeBarang.Items.Add("001")
        cbKodeBarang.Items.Add("002")
    End Sub

    Private Sub btnIsiData_Click(sender As Object, e As EventArgs) Handles btnIsiData.Click
        tbTotalHarga.Text = tbHargaBarang.Text * tbJumlahBarang.Text
        MessageBox.Show(caraBayar)
    End Sub

    Private Sub rbTunai_CheckedChanged(sender As Object, e As EventArgs) Handles rbTunai.CheckedChanged
        caraBayar = "Tunai"
    End Sub

    Private Sub rbKredit_CheckedChanged(sender As Object, e As EventArgs) Handles rbKredit.CheckedChanged
        caraBayar = "Kredit"
    End Sub
End Class
