'Mengambil Library MySql untuk melakukan perintah SQL database
Imports MySql.Data.MySqlClient

Public Class Login
    'Event Ketika Form Login Reload (Kebuka)
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connection() 'Membuka Koneksi Ke Database (Method/Function Connection ada di Module)
        tbPassword.UseSystemPasswordChar = False 'UseSystemPasswordChar digunakan untuk menyembunyikan Password saat diinput. Ketika False maka passowrd akan terlihat saat diinputkan
        'Mengubah lebar Panel1 sesuai dengan lebar form dibagi 2,3
        Panel1.Width = Me.Width / 2.3
        Panel2.Width = Me.Width - Panel1.Width
        Panel2.Location = New Point(Panel1.Width, 0)
        'Mengubah tinggi Panel1 menjadi sama dengan tinggi Form nya
        Panel1.Height = Me.Height
        Panel2.Height = Me.Height
        'Setting lokasi panel menjadi x=0 dan y=0 agar berada di sebelah kiri Form
        Panel1.Location = New Point(0, 0)
        'Set warna background Label1 menjadi transparan
        labelTeksBerjalan.BackColor = Color.Transparent
        'Menyalakan Password Char
        tbPassword.UseSystemPasswordChar = True
        'Set lokasi Label1(Teks Berjalan)
        labelTeksBerjalan.Location = New Point(Me.Width, Me.Height / 10)
        labelLogin.BackColor = Color.Transparent
        'set lokasi Label2 agar berada di tengah
        labelLogin.Location = New Point(Panel1.Width / 2 - (labelLogin.Width / 2), Me.Height / 10)
        'set lokasi PictureBox1 agar berada ditengah
        PictureBox1.Location = New Point((Panel1.Width / 2) - (PictureBox1.Width / 2), Me.Height / 5)
        'set lokasi PictureBox2 agar berada ditengah
        PictureBox2.Location = New Point((Panel2.Width / 2) - (PictureBox2.Width / 2), Me.Height / 5)
        cbShowPassword.Location = New Point(tbPassword.Location.X, tbPassword.Location.Y + tbPassword.Height + 20)
        'set lokasi label "Apotek Samarinda" dan label "Siap Melayani Anda 24 Jam"
        labelApotekSamarinda.Location = New Point((Panel2.Width / 2) - (labelApotekSamarinda.Width / 2), (Me.Height / 2) + 200)
        labelSiapMelayaniAnda.Location = New Point((Panel2.Width / 2) - (labelSiapMelayaniAnda.Width / 2), labelApotekSamarinda.Location.Y + labelApotekSamarinda.Height)
        'Mengatur Posisi Button Close (X)
        btnClose.Size = New Size(60, 60)
        btnClose.Location = New Point(Panel2.Width - btnClose.Width, 0)
    End Sub

    'Event ketika Checkbox ShowPassword di aktifkan
    Private Sub cbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassword.CheckedChanged
        'Kondisi ketika Check Box Show Password ditekan maka akan FALSE, artinya Password akan diperlihatkan
        If cbShowPassword.Checked = True Then
            tbPassword.UseSystemPasswordChar = False
        Else
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    'Event untuk membuat animasi Tulisan Berjalan
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If labelTeksBerjalan.Right <= Panel1.Width Then
            'Posisi awal saat label sudah melebihi lebar Form, sehingga akan mengulang ke awal
            labelTeksBerjalan.Left = Me.Width
        Else
            labelTeksBerjalan.Left = labelTeksBerjalan.Left - 10
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call Connection()
        Perintah = New MySqlCommand("SELECT * FROM akun WHERE username= '" & tbUsername.Text & "' and password='" & tbPassword.Text & "'", Koneksi)
        Dim BacaDataAkun As MySqlDataReader = Perintah.ExecuteReader()
        While (BacaDataAkun.Read())
            tbIdAkun.Text = BacaDataAkun.Item(0)
        End While
        If BacaDataAkun.HasRows Then
            BacaDataAkun.Close()
            Petugas.Show()
            Me.Close()
        Else
            BacaDataAkun.Close()
            MessageBox.Show("Akun Tidak Ditemukan", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        tbUsername.Focus()
        Koneksi.Close()
    End Sub

    'event close
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class