Imports MySql.Data.MySqlClient

Public Class Pengaturan_Akun
    Private Sub Data_Apoteker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connection()
        Call TampilDataApoteker()
        Call TampilAkunApoteker()
    End Sub

    Private Sub Data_Apoteker_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub

    Sub TampilDataApoteker()
        Perintah = New MySqlCommand("Select * FROM tbApoteker WHERE idAkun= '" & Petugas.Label3.Text & "' ", Koneksi)
        BacaData = Perintah.ExecuteReader()
        While BacaData.Read()
            tbKodeApoteker.Text = BacaData.Item(0)
            tbNamaApoteker.Text = BacaData.Item(1)
            cbJenkelApoteker.Text = BacaData.Item(2)
            tbUsiaApoteker.Text = BacaData.Item(3)
            tbNomorTelepon.Text = BacaData.Item(4)
            tbAlamatApoteker.Text = BacaData.Item(5)
        End While
        BacaData.Close()
    End Sub

    Sub TampilAkunApoteker()
        Perintah = New MySqlCommand("SELECT * FROM akun WHERE idAkun='" & Petugas.Label3.Text & "' ", Koneksi)
        BacaData = Perintah.ExecuteReader()
        While BacaData.Read()
            tbUsernameAkun.Text = BacaData.Item(1)
            tbPasswordAkun.Text = BacaData.Item(2)
        End While
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If tbKodeApoteker.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbKodeApoteker.Focus()
            Exit Sub
        ElseIf tbNamaApoteker.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbNamaApoteker.Focus()
            Exit Sub
        ElseIf tbUsiaApoteker.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbUsiaApoteker.Focus()
            Exit Sub
        ElseIf Val(tbUsiaApoteker.Text) > 50 Or Val(tbUsiaApoteker.Text) < 20 Then
            MessageBox.Show("Usia Apoteker Tidak Memenuhi !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbUsiaApoteker.Focus()
            Exit Sub
        ElseIf tbNomorTelepon.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbNomorTelepon.Focus()
            Exit Sub
        ElseIf tbAlamatApoteker.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbAlamatApoteker.Focus()
            Exit Sub
        ElseIf tbUsernameAkun.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbUsernameAkun.Focus()
            Exit Sub
        ElseIf tbPasswordAkun.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbPasswordAkun.Focus()
            Exit Sub
        Else
            Call Connection()
            BacaData.Close()
            Dim Ubah As String = "UPDATE tbApoteker Set namaApoteker='" & tbNamaApoteker.Text & "',jenisKelamin='" & cbJenkelApoteker.Text & "',usiaApoteker=" & tbUsiaApoteker.Text & ",nomorTelepon='" & tbNomorTelepon.Text & "',alamatApoteker='" & tbAlamatApoteker.Text & "' WHERE idAkun='" & Petugas.Label3.Text & "'"
            Perintah = New MySqlCommand(Ubah, Koneksi)
            Perintah.ExecuteNonQuery()
            Dim UbahAkun As String = "UPDATE akun Set username='" & tbUsernameAkun.Text & "',password='" & tbPasswordAkun.Text & "' WHERE idAkun='" & Petugas.Label3.Text & "'"
            Perintah = New MySqlCommand(UbahAkun, Koneksi)
            Perintah.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Di Ubah !!!", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbKodeApoteker.Focus()
            TampilDataApoteker()
            TampilAkunApoteker()
        End If
    End Sub

    Private Sub tbUsiaApoteker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbUsiaApoteker.KeyPress
        CheckAngka(e)
    End Sub

    Private Sub tbNomorTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNomorTelepon.KeyPress
        CheckAngka(e)
    End Sub
End Class