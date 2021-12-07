Public Class Form1
    Dim caraBayar As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbKodeBarang.Items.Add("001")
        cbKodeBarang.Items.Add("002")
        tbTotalHarga.Enabled = False
        tbNamaBarang.Enabled = False
        tbHargaBarang.Enabled = False
        tbTotalBayar.Enabled = False
    End Sub

    Private Sub btnIsiData_Click(sender As Object, e As EventArgs) Handles btnIsiData.Click
        tbTotalHarga.Text = tbHargaBarang.Text * tbJumlahBarang.Text
        tbTotalBayar.Text = tbTotalHarga.Text - tbDiskon.Text
    End Sub

    Private Sub rbTunai_CheckedChanged(sender As Object, e As EventArgs) Handles rbTunai.CheckedChanged
        caraBayar = "Tunai"
    End Sub

    Private Sub rbKredit_CheckedChanged(sender As Object, e As EventArgs) Handles rbKredit.CheckedChanged
        caraBayar = "Kredit"
    End Sub

    Private Sub cbKodeBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKodeBarang.SelectedIndexChanged
        Select Case cbKodeBarang.Text
            Case "001"
                tbNamaBarang.Text = "Sepatu"
                tbHargaBarang.Text = 50000

            Case "002"
                tbNamaBarang.Text = "Sandal"
                tbHargaBarang.Text = 7000
        End Select
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbJumlahBarang.Text = ""
        tbDiskon.Text = ""
        rbKredit.Checked = False
        cbKodeBarang.Text = ""
        tbNamaBarang.Text = ""
        tbHargaBarang.Text = ""
        rbTunai.Checked = False
        tbTotalBayar.Text = ""
        tbTotalHarga.Text = ""
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class
