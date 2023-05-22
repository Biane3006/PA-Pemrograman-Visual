Imports MySql.Data.MySqlClient

Public Class Data_Pelanggan
    Private Sub Data_Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connection()
        Call TampilDataPelanggan()
        Call Kosong()
        Call MengaturGrid()
    End Sub

    Private Sub Data_Pelanggan_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub

    Sub Kosong()
        tbKodePelanggan.Clear()
        tbNamaPelanggan.Clear()
        cbJenkel.SelectedItem = Nothing
        tbAlamat.Clear()
        tbKodePelanggan.Focus()
    End Sub

    Sub TampilDataPelanggan()
        DataAdapter = New MySqlDataAdapter("SELECT * FROM tbPelanggan", Koneksi)
        DataSet = New DataSet
        DataSet.Clear()
        DataAdapter.Fill(DataSet, "dgvDataPelanggan")
        dgvDataPelanggan.DataSource = DataSet.Tables("dgvDataPelanggan")
        dgvDataPelanggan.Refresh()
    End Sub

    Sub MengaturGrid()
        With dgvDataPelanggan
            .Columns(0).HeaderText = "KODE PELANGGAN"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "NAMA PELANGGAN"
            .Columns(1).Width = 200
            .Columns(2).HeaderText = "JENIS KELAMIN"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "ALAMAT"
            .Columns(3).Width = 300
        End With
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If tbKodePelanggan.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbKodePelanggan.Focus()
            Exit Sub
        ElseIf tbNamaPelanggan.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbNamaPelanggan.Focus()
            Exit Sub
        ElseIf cbJenkel.SelectedItem Is Nothing Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbJenkel.Focus()
            Exit Sub
        ElseIf tbAlamat.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbAlamat.Focus()
            Exit Sub
        Else
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbPelanggan WHERE kodePelanggan= '" & tbKodePelanggan.Text & "' ", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If Not BacaData.HasRows Then
                BacaData.Close()
                Dim Simpan As String = "Insert Into tbPelanggan values ('" & tbKodePelanggan.Text & "' ,'" & tbNamaPelanggan.Text & "','" & cbJenkel.Text & "','" & tbAlamat.Text & "' )"
                Perintah = New MySqlCommand(Simpan, Koneksi)
                Perintah.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Simpan !!!", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Kosong()
                tbKodePelanggan.Focus()
            Else
                MessageBox.Show("Kode Pelanggan Sudah Digunakan !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BacaData.Close()
                tbKodePelanggan.Focus()
            End If
            Call TampilDataPelanggan()
        End If
    End Sub

    'Pada saat Cell diklik atau dipilih akan menngisi form nya
    Private Sub dgvDataPelanggan_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataPelanggan.CellEnter
        Dim indeksRow As Integer = Me.dgvDataPelanggan.CurrentRow.Index
        With dgvDataPelanggan.Rows.Item(indeksRow)
            Me.tbKodePelanggan.Text = .Cells(0).Value
            Me.tbNamaPelanggan.Text = .Cells(1).Value
            Me.cbJenkel.Text = .Cells(2).Value
            Me.tbAlamat.Text = .Cells(3).Value
        End With
    End Sub

    'Mengubah data
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If tbKodePelanggan.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbKodePelanggan.Focus()
            Exit Sub
        ElseIf tbNamaPelanggan.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbNamaPelanggan.Focus()
            Exit Sub
        ElseIf tbAlamat.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbAlamat.Focus()
            Exit Sub
        Else
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbPelanggan WHERE kodePelanggan= '" & tbKodePelanggan.Text & "' ", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows() Then
                BacaData.Close()
                Dim Ubah As String = "UPDATE tbPelanggan Set namaPelanggan='" & tbNamaPelanggan.Text & "',jenisKelamin='" & cbJenkel.Text & "',alamatPelanggan='" & tbAlamat.Text & "' WHERE kodePelanggan='" & tbKodePelanggan.Text & "'"
                Perintah = New MySqlCommand(Ubah, Koneksi)
                Perintah.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Ubah !!!", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call TampilDataPelanggan()
                Call Kosong()
                tbKodePelanggan.Focus()
            Else
                MessageBox.Show("Kode Pelanggan Tidak Ditemukan !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BacaData.Close()
                tbKodePelanggan.Focus()
            End If
            TampilDataPelanggan()
        End If
    End Sub

    'Hapus data
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If tbKodePelanggan.Text = "" Then
            MessageBox.Show("Kode Pelanggan Belum Diisi !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Perintah = New MySqlCommand("Select * FROM tbPelanggan WHERE kodePelanggan='" & tbKodePelanggan.Text & "'", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows Then
                BacaData.Close()
                If MessageBox.Show("Apakah anda yakin untuk menghapus data Pelanggan " & tbKodePelanggan.Text & " ? ", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim Hapus As String = "DELETE from tbPelanggan WHERE kodePelanggan='" & tbKodePelanggan.Text & "'"
                    Perintah = New MySqlCommand(Hapus, Koneksi)
                    Perintah.ExecuteNonQuery()
                    MessageBox.Show("Data Berhasil Di Hapus !!!", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Kosong()
                    tbKodePelanggan.Focus()
                End If
            Else
                MessageBox.Show("Kode Pelanggan Tidak Ditemukan !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BacaData.Close()
                tbKodePelanggan.Focus()
            End If
            Call TampilDataPelanggan()
        End If
    End Sub

    'Batal isi form
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Kosong()
    End Sub

    Private Sub tbKodePelanggan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbKodePelanggan.KeyPress
        tbKodePelanggan.MaxLength = 7
        If e.KeyChar = Chr(13) Then
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbPelanggan WHERE kodePelanggan= '" & tbKodePelanggan.Text & "' ", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows Then
                tbKodePelanggan.Text = BacaData.Item(0)
                tbNamaPelanggan.Text = BacaData.Item(1)
                cbJenkel.Text = BacaData.Item(2)
                tbAlamat.Text = BacaData.Item(3)
            Else
                tbKodePelanggan.Focus()
            End If
        End If
    End Sub

    Private Sub tbCariDataPelanggan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCariDataPelanggan.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbPelanggan WHERE kodePelanggan LIKE '%" & tbCariDataPelanggan.Text & "%' OR namaPelanggan LIKE '%" & tbCariDataPelanggan.Text & "%'", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows Then
                BacaData.Close()
                DataAdapter = New MySqlDataAdapter("Select * FROM tbPelanggan WHERE kodePelanggan LIKE '%" & tbCariDataPelanggan.Text & "%' OR namaPelanggan LIKE '%" & tbCariDataPelanggan.Text & "%'", Koneksi)
                DataSet = New DataSet
                DataSet.Clear()
                DataAdapter.Fill(DataSet, "Dapat")
                dgvDataPelanggan.DataSource = DataSet.Tables("Dapat")
                dgvDataPelanggan.ReadOnly = True
            Else
                BacaData.Close()
                MessageBox.Show("Data Tidak Ditemukan !!!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgvDataPelanggan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDataPelanggan.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            Me.dgvDataPelanggan.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(106, 187, 109)
        Else
            Me.dgvDataPelanggan.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
        End If
    End Sub
End Class