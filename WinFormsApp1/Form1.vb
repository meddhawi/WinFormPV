Public Class Form1
    ' Variabel untuk menyimpan angka pertama yang diinput
    Private angkaPertama As Double
    ' Variabel untuk menyimpan jenis operasi matematika
    Private jenisOperasi As String
    ' Variabel untuk mengecek apakah angka yang diinput adalah angka baru
    Private angkaBaru As Boolean = True

    ' Fungsi untuk menangani tombol angka
    Private Sub TombolAngka_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim tombol As Button = DirectCast(sender, Button)
        
        ' Jika angka baru, ganti text di layar
        ' Jika bukan angka baru, tambahkan angka di belakangnya
        If angkaBaru Then
            txtDisplay.Text = tombol.Text
            angkaBaru = False
        Else
            txtDisplay.Text &= tombol.Text
        End If
    End Sub

    ' Fungsi untuk menangani tombol operator (+, -, x, ÷)
    Private Sub TombolOperator_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSubtract.Click, btnMultiply.Click, btnDivide.Click
        Dim tombol As Button = DirectCast(sender, Button)
        
        If Not angkaBaru Then
            angkaPertama = Double.Parse(txtDisplay.Text)
            jenisOperasi = tombol.Text
            angkaBaru = True
        End If
    End Sub

    ' Fungsi untuk menangani tombol sama dengan (=)
    Private Sub TombolSamaDengan_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        If Not angkaBaru Then
            Dim angkaKedua As Double = Double.Parse(txtDisplay.Text)
            Dim hasil As Double

            ' Pilih operasi yang akan dilakukan
            Select Case jenisOperasi
                Case "+"
                    hasil = angkaPertama + angkaKedua
                Case "-"
                    hasil = angkaPertama - angkaKedua
                Case "×"
                    hasil = angkaPertama * angkaKedua
                Case "÷"
                    ' Cek pembagian dengan nol
                    If angkaKedua <> 0 Then
                        hasil = angkaPertama / angkaKedua
                    Else
                        MessageBox.Show("Tidak bisa membagi dengan nol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TombolHapus_Click(Nothing, Nothing)
                        Return
                    End If
            End Select

            txtDisplay.Text = hasil.ToString()
            angkaBaru = True
        End If
    End Sub

    ' Fungsi untuk menangani tombol hapus (Clear)
    Private Sub TombolHapus_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = "0"
        angkaPertama = 0
        jenisOperasi = ""
        angkaBaru = True
    End Sub
End Class
