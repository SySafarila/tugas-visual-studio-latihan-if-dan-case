<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbKodeBarang = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNamaBarang = New System.Windows.Forms.TextBox()
        Me.tbHargaBarang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbJumlahBarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbTunai = New System.Windows.Forms.RadioButton()
        Me.rbKredit = New System.Windows.Forms.RadioButton()
        Me.tbDiskon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbTotalBayar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnIsiData = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'cbKodeBarang
        '
        Me.cbKodeBarang.FormattingEnabled = True
        Me.cbKodeBarang.Location = New System.Drawing.Point(91, 10)
        Me.cbKodeBarang.Name = "cbKodeBarang"
        Me.cbKodeBarang.Size = New System.Drawing.Size(121, 21)
        Me.cbKodeBarang.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Barang"
        '
        'tbNamaBarang
        '
        Me.tbNamaBarang.Location = New System.Drawing.Point(91, 43)
        Me.tbNamaBarang.Name = "tbNamaBarang"
        Me.tbNamaBarang.Size = New System.Drawing.Size(121, 20)
        Me.tbNamaBarang.TabIndex = 3
        '
        'tbHargaBarang
        '
        Me.tbHargaBarang.Location = New System.Drawing.Point(91, 69)
        Me.tbHargaBarang.Name = "tbHargaBarang"
        Me.tbHargaBarang.Size = New System.Drawing.Size(121, 20)
        Me.tbHargaBarang.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Harga Barang"
        '
        'tbJumlahBarang
        '
        Me.tbJumlahBarang.Location = New System.Drawing.Point(91, 98)
        Me.tbJumlahBarang.Name = "tbJumlahBarang"
        Me.tbJumlahBarang.Size = New System.Drawing.Size(121, 20)
        Me.tbJumlahBarang.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Jumlah Barang"
        '
        'tbTotalHarga
        '
        Me.tbTotalHarga.Location = New System.Drawing.Point(91, 127)
        Me.tbTotalHarga.Name = "tbTotalHarga"
        Me.tbTotalHarga.Size = New System.Drawing.Size(121, 20)
        Me.tbTotalHarga.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cara Beli"
        '
        'rbTunai
        '
        Me.rbTunai.AutoSize = True
        Me.rbTunai.Location = New System.Drawing.Point(91, 156)
        Me.rbTunai.Name = "rbTunai"
        Me.rbTunai.Size = New System.Drawing.Size(52, 17)
        Me.rbTunai.TabIndex = 11
        Me.rbTunai.TabStop = True
        Me.rbTunai.Text = "Tunai"
        Me.rbTunai.UseVisualStyleBackColor = True
        '
        'rbKredit
        '
        Me.rbKredit.AutoSize = True
        Me.rbKredit.Location = New System.Drawing.Point(160, 156)
        Me.rbKredit.Name = "rbKredit"
        Me.rbKredit.Size = New System.Drawing.Size(52, 17)
        Me.rbKredit.TabIndex = 12
        Me.rbKredit.TabStop = True
        Me.rbKredit.Text = "Kredit"
        Me.rbKredit.UseVisualStyleBackColor = True
        '
        'tbDiskon
        '
        Me.tbDiskon.Location = New System.Drawing.Point(91, 179)
        Me.tbDiskon.Name = "tbDiskon"
        Me.tbDiskon.Size = New System.Drawing.Size(121, 20)
        Me.tbDiskon.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Diskon"
        '
        'tbTotalBayar
        '
        Me.tbTotalBayar.Location = New System.Drawing.Point(91, 205)
        Me.tbTotalBayar.Name = "tbTotalBayar"
        Me.tbTotalBayar.Size = New System.Drawing.Size(121, 20)
        Me.tbTotalBayar.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Total Bayar"
        '
        'btnIsiData
        '
        Me.btnIsiData.Location = New System.Drawing.Point(13, 235)
        Me.btnIsiData.Name = "btnIsiData"
        Me.btnIsiData.Size = New System.Drawing.Size(75, 23)
        Me.btnIsiData.TabIndex = 17
        Me.btnIsiData.Text = "Isi Data"
        Me.btnIsiData.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(94, 235)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(175, 235)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 23)
        Me.btnTutup.TabIndex = 19
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnIsiData)
        Me.Controls.Add(Me.tbTotalBayar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbDiskon)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rbKredit)
        Me.Controls.Add(Me.rbTunai)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbTotalHarga)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbJumlahBarang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbHargaBarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbNamaBarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbKodeBarang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbKodeBarang As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbNamaBarang As TextBox
    Friend WithEvents tbHargaBarang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbJumlahBarang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbTotalHarga As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rbTunai As RadioButton
    Friend WithEvents rbKredit As RadioButton
    Friend WithEvents tbDiskon As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbTotalBayar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnIsiData As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnTutup As Button
End Class
