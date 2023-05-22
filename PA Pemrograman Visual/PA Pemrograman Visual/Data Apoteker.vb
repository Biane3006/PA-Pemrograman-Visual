Imports MySql.Data.MySqlClient

Public Class Data_Apoteker
    Private Sub Data_Apoteker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connection()
        Call TampilDataApoteker()
        Call Kosong()
        Call MengaturGrid()
    End Sub

    Private Sub Data_Apoteker_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub

    Sub Kosong()
        tbKodeApoteker.Clear()
        tbNamaApoteker.Clear()
        cbJenkelApoteker.SelectedItem = Nothing
        tbUsiaApoteker.Clear()
        tbNomorTelepon.Clear()
        tbAlamatApoteker.Clear()
        tbKodeApoteker.Focus()
    End Sub

    Sub TampilDataApoteker()
        DataAdapter = New MySqlDataAdapter("SELECT * FROM tbApoteker", Koneksi)
        DataSet = New DataSet
        DataSet.Clear()
        DataAdapter.Fill(DataSet, "dgvDataApoteker")
        dgvDataApoteker.DataSource = DataSet.Tables("dgvDataApoteker")
        dgvDataApoteker.Columns("idAkun").Visible = False
        dgvDataApoteker.Refresh()
    End Sub

    Sub MengaturGrid()
        With dgvDataApoteker
            .Columns(0).HeaderText = "KODE APOTEKER"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "NAMA APOTEKER"
            .Columns(1).Width = 200
            .Columns(2).HeaderText = "JENIS KELAMIN"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "USIA"
            .Columns(3).Width = 100
            .Columns(4).HeaderText = "TELEPON"
            .Columns(4).Width = 100
            .Columns(5).HeaderText = "ALAMAT"
            .Columns(5).Width = 300
        End With
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
        ElseIf cbJenkelApoteker.SelectedItem Is Nothing Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbJenkelApoteker.Focus()
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
        Else
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbApoteker WHERE kodeApoteker= '" & tbKodeApoteker.Text & "' ", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If Not BacaData.HasRows Then
                BacaData.Close()
                Dim Simpan As String = "Insert Into tbApoteker values ('" & tbKodeApoteker.Text & "' ,'" & tbNamaApoteker.Text & "','" & cbJenkelApoteker.Text & "'," & tbUsiaApoteker.Text & ",'" & tbNomorTelepon.Text & "','" & tbAlamatApoteker.Text & "','' )"
                Perintah = New MySqlCommand(Simpan, Koneksi)
                Perintah.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Simpan !!!", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Kosong()
                tbKodeApoteker.Focus()
            Else
                MessageBox.Show("Kode Apoteker Sudah Digunakan !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BacaData.Close()
                tbKodeApoteker.Focus()
            End If
            Call TampilDataApoteker()
        End If
    End Sub

    'Pada saat Cell diklik atau dipilih akan menngisi form nya
    Private Sub dgvDataApoteker_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataApoteker.CellEnter
        Dim indeksRow As Integer = Me.dgvDataApoteker.CurrentRow.Index
        With dgvDataApoteker.Rows.Item(indeksRow)
            Me.tbKodeApoteker.Text = .Cells(0).Value
            Me.tbNamaApoteker.Text = .Cells(1).Value
            Me.cbJenkelApoteker.Text = .Cells(2).Value
            Me.tbUsiaApoteker.Text = .Cells(3).Value
            Me.tbNomorTelepon.Text = .Cells(4).Value
            Me.tbAlamatApoteker.Text = .Cells(5).Value
        End With
    End Sub

    'Mengubah data
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
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
        Else
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbApoteker WHERE kodeApoteker= '" & tbKodeApoteker.Text & "' ", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows() Then
                BacaData.Close()
                Dim Ubah As String = "UPDATE tbApoteker Set namaApoteker='" & tbNamaApoteker.Text & "',jenisKelamin='" & cbJenkelApoteker.Text & "',usiaApoteker=" & tbUsiaApoteker.Text & ",nomorTelepon='" & tbNomorTelepon.Text & "',alamatApoteker='" & tbAlamatApoteker.Text & "',idAkun='' WHERE kodeApoteker='" & tbKodeApoteker.Text & "'"
                Perintah = New MySqlCommand(Ubah, Koneksi)
                Perintah.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Ubah !!!", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call TampilDataApoteker()
                Call Kosong()
                tbKodeApoteker.Focus()
            Else
                MessageBox.Show("Kode Apoteker Tidak Ditemukan !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BacaData.Close()
                tbKodeApoteker.Focus()
            End If
            TampilDataApoteker()
        End If
    End Sub

    'Hapus data
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If tbKodeApoteker.Text = "" Then
            MessageBox.Show("Kode Apoteker Belum Diisi !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Perintah = New MySqlCommand("Select * FROM tbApoteker WHERE kodeApoteker='" & tbKodeApoteker.Text & "'", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows Then
                BacaData.Close()
                If MessageBox.Show("Apakah anda yakin untuk menghapus data Apoteker " & tbKodeApoteker.Text & " ? ", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim Hapus As String = "DELETE from tbApoteker WHERE kodeApoteker='" & tbKodeApoteker.Text & "'"
                    Perintah = New MySqlCommand(Hapus, Koneksi)
                    Perintah.ExecuteNonQuery()
                    MessageBox.Show("Data Berhasil Di Hapus !!!", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Kosong()
                    tbKodeApoteker.Focus()
                End If
            Else
                MessageBox.Show("Kode Apoteker Tidak Ditemukan !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BacaData.Close()
                tbKodeApoteker.Focus()
            End If
            Call TampilDataApoteker()
        End If
    End Sub

    'Batal isi form
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Kosong()
    End Sub

    Private Sub tbCariDataApoteker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCariDataApoteker.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbApoteker WHERE kodeApoteker LIKE '%" & tbCariDataApoteker.Text & "%' OR namaApoteker LIKE '%" & tbCariDataApoteker.Text & "%'", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows Then
                BacaData.Close()
                DataAdapter = New MySqlDataAdapter("Select * FROM tbApoteker WHERE kodeApoteker LIKE '%" & tbCariDataApoteker.Text & "%' OR namaApoteker LIKE '%" & tbCariDataApoteker.Text & "%'", Koneksi)
                DataSet = New DataSet
                DataSet.Clear()
                DataAdapter.Fill(DataSet, "Dapat")
                dgvDataApoteker.DataSource = DataSet.Tables("Dapat")
                dgvDataApoteker.ReadOnly = True
            Else
                BacaData.Close()
                MessageBox.Show("Data Tidak Ditemukan !!!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgvDataApoteker_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDataApoteker.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            Me.dgvDataApoteker.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(106, 187, 109)
        Else
            Me.dgvDataApoteker.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
        End If
    End Sub

    'ERROR HANDLING & LOGICAL ERROR

    Private Sub tbKodeApoteker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbKodeApoteker.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbApoteker WHERE kodeApoteker= '" & tbKodeApoteker.Text & "' ", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows Then
                tbKodeApoteker.Text = BacaData.Item(0)
                tbNamaApoteker.Text = BacaData.Item(1)
                cbJenkelApoteker.Text = BacaData.Item(2)
                tbUsiaApoteker.Text = BacaData.Item(3)
                tbNomorTelepon.Text = BacaData.Item(4)
                tbAlamatApoteker.Text = BacaData.Item(5)
            Else
                tbNamaApoteker.Clear()
                cbJenkelApoteker.SelectedItem = Nothing
                tbUsiaApoteker.Clear()
                tbNomorTelepon.Clear()
                tbAlamatApoteker.Clear()
                tbKodeApoteker.Focus()
            End If
        End If
    End Sub

    Private Sub tbUsiaApoteker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbUsiaApoteker.KeyPress
        Call CheckAngka(e)
    End Sub

    Private Sub tbNomorTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNomorTelepon.KeyPress
        Call CheckAngka(e)
    End Sub
End Class