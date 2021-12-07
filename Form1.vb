Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbKodeBarang.Items.Add("001")
        cbKodeBarang.Items.Add("002")
    End Sub

    Private Sub btnIsiData_Click(sender As Object, e As EventArgs) Handles btnIsiData.Click
        tbTotalHarga.Text = tbHargaBarang.Text * tbJumlahBarang.Text
    End Sub
End Class
