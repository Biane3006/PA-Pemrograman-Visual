Imports MySql.Data.MySqlClient

Public Class Data_Obat

    Private Sub Data_Obat_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call Connection()
        Call TampilDataObat()
    End Sub
    Private Sub Data_Obat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connection()
        Call TampilDataObat()
        Call Kosong()
        Call MengaturGrid()
    End Sub

    Private Sub Data_Obat_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub

    Sub Kosong()
        tbKodeObat.Clear()
        tbNamaObat.Clear()
        cbJenisObat.SelectedItem = Nothing
        cbGolongan.SelectedItem = Nothing
        tbHargaJual.Clear()
        tbHargaBeli.Clear()
        tbStok.Clear()
        tbKodeObat.Focus()
    End Sub

    Sub TampilDataObat()
        DataAdapter = New MySqlDataAdapter("SELECT * FROM tbObat", Koneksi)
        DataSet = New DataSet
        DataSet.Clear()
        DataAdapter.Fill(DataSet, "dgvDataObat")
        dgvDataObat.DataSource = DataSet.Tables("dgvDataObat")
        dgvDataObat.Refresh()
    End Sub

    Sub MengaturGrid()
        With dgvDataObat
            .Columns(0).HeaderText = "KODE OBAT"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "NAMA OBAT"
            .Columns(1).Width = 200
            .Columns(2).HeaderText = "JENIS OBAT"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "GOLONGAN"
            .Columns(3).Width = 100
            .Columns(4).HeaderText = "HARGA JUAL"
            .Columns(4).Width = 120
            .Columns(5).HeaderText = "HARGA BELI"
            .Columns(5).Width = 120
            .Columns(6).HeaderText = "STOK"
            .Columns(6).Width = 100
        End With
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If tbKodeObat.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbKodeObat.Focus()
            Exit Sub
        ElseIf tbNamaObat.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbNamaObat.Focus()
            Exit Sub
        ElseIf cbJenisObat.SelectedItem Is Nothing Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbJenisObat.Focus()
            Exit Sub
        ElseIf cbGolongan.SelectedItem Is Nothing Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbGolongan.Focus()
            Exit Sub
        ElseIf tbHargaJual.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbHargaJual.Focus()
            Exit Sub
        ElseIf Val(tbHargaJual.Text) = 0 Then
            MessageBox.Show("Harga Jual Tidak Boleh 0 !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbHargaJual.Focus()
            Exit Sub
        ElseIf tbHargaBeli.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbHargaBeli.Focus()
            Exit Sub
        ElseIf Val(tbHargaBeli.Text) = 0 Then
            MessageBox.Show("Harga Beli Tidak Boleh 0 !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbHargaBeli.Focus()
        ElseIf tbStok.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbStok.Focus()
            Exit Sub
        Else
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbObat WHERE kodeObat= '" & tbKodeObat.Text & "' AND namaObat='" & tbNamaObat.Text & "'", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If Not BacaData.HasRows Then
                BacaData.Close()
                Dim Simpan As String = "Insert Into tbObat values ('" & tbKodeObat.Text & "' ,'" & tbNamaObat.Text & "','" & cbJenisObat.Text & "','" & cbGolongan.Text & "'," & tbHargaJual.Text & "," & tbHargaBeli.Text & "," & tbStok.Text & " )"
                Perintah = New MySqlCommand(Simpan, Koneksi)
                Perintah.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Simpan !!!", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Kosong()
                tbKodeObat.Focus()
            Else
                MessageBox.Show("Kode atau Nama Obat Sudah Digunakan !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BacaData.Close()
                tbKodeObat.Focus()
            End If
            Call TampilDataObat()
        End If
    End Sub

    'Pada saat Cell diklik atau dipilih akan menngisi form nya
    Private Sub dgvDataObat_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataObat.CellEnter
        Dim indeksRow As Integer = Me.dgvDataObat.CurrentRow.Index
        With dgvDataObat.Rows.Item(indeksRow)
            Me.tbKodeObat.Text = .Cells(0).Value
            Me.tbNamaObat.Text = .Cells(1).Value
            Me.cbJenisObat.Text = .Cells(2).Value
            Me.cbGolongan.Text = .Cells(3).Value
            Me.tbHargaJual.Text = .Cells(4).Value
            Me.tbHargaBeli.Text = .Cells(5).Value
            Me.tbStok.Text = .Cells(6).Value
        End With
    End Sub

    'Mengubah data
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If tbKodeObat.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbKodeObat.Focus()
            Exit Sub
        ElseIf tbNamaObat.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbNamaObat.Focus()
            Exit Sub
        ElseIf tbHargaJual.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbHargaJual.Focus()
            Exit Sub
        ElseIf Val(tbHargaJual.Text) = 0 Then
            MessageBox.Show("Harga Jual Tidak Boleh 0 !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbHargaJual.Focus()
            Exit Sub
        ElseIf tbHargaBeli.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbHargaBeli.Focus()
            Exit Sub
        ElseIf Val(tbHargaBeli.Text) = 0 Then
            MessageBox.Show("Harga Beli Tidak Boleh 0 !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbHargaBeli.Focus()
        ElseIf tbStok.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbStok.Focus()
            Exit Sub
        Else
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbObat WHERE kodeObat='" & tbKodeObat.Text & "'", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows Then
                BacaData.Close()
                Dim Ubah As String = "UPDATE tbObat Set namaObat='" & tbNamaObat.Text & "',jenisObat='" & cbJenisObat.Text & "',golonganObat='" & cbGolongan.Text & "',hargaJualObat=" & tbHargaJual.Text & ",hargaBeliObat=" & tbHargaBeli.Text & ",jumlahStok=" & tbStok.Text & " WHERE kodeObat='" & tbKodeObat.Text & "'"
                Perintah = New MySqlCommand(Ubah, Koneksi)
                Perintah.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Ubah !!!", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call TampilDataObat()
                Call Kosong()
                tbKodeObat.Focus()
            Else
                MessageBox.Show("Kode Obat Tidak Ditemukan !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BacaData.Close()
                tbKodeObat.Focus()
            End If
            TampilDataObat()
        End If
    End Sub

    'Hapus data
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If tbKodeObat.Text = "" Then
            MessageBox.Show("Kode Obat Belum Diisi !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Perintah = New MySqlCommand("Select * FROM tbObat WHERE kodeObat='" & tbKodeObat.Text & "'", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows Then
                BacaData.Close()
                If MessageBox.Show("Apakah anda yakin untuk menghapus data Obat " & tbKodeObat.Text & " ? ", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim Hapus As String = "DELETE from tbObat WHERE kodeObat='" & tbKodeObat.Text & "'"
                    Perintah = New MySqlCommand(Hapus, Koneksi)
                    Perintah.ExecuteNonQuery()
                    MessageBox.Show("Data Berhasil Di Hapus !!!", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Kosong()
                    tbKodeObat.Focus()
                End If
            Else
                MessageBox.Show("Kode Obat Tidak Ditemukan !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BacaData.Close()
                tbKodeObat.Focus()
            End If
            Call TampilDataObat()
        End If
    End Sub

    'Batal isi form
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Kosong()
    End Sub

    Private Sub tbKodeObat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbKodeObat.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbObat WHERE kodeObat= '" & tbKodeObat.Text & "' ", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows Then
                tbKodeObat.Text = BacaData.Item(0)
                tbNamaObat.Text = BacaData.Item(1)
                cbJenisObat.Text = BacaData.Item(2)
                cbGolongan.Text = BacaData.Item(3)
                tbHargaJual.Text = BacaData.Item(4)
                tbHargaBeli.Text = BacaData.Item(5)
                tbStok.Text = BacaData.Item(6)
                BacaData.Close()
            Else
                BacaData.Close()
                tbKodeObat.Focus()
            End If
        End If
    End Sub

    Private Sub tbCariDataObat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCariDataObat.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbObat WHERE kodeObat LIKE '%" & tbCariDataObat.Text & "%' OR namaObat LIKE '%" & tbCariDataObat.Text & "%'", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows Then
                BacaData.Close()
                DataAdapter = New MySqlDataAdapter("Select * FROM tbObat WHERE kodeObat LIKE '%" & tbCariDataObat.Text & "%' OR namaObat LIKE '%" & tbCariDataObat.Text & "%'", Koneksi)
                DataSet = New DataSet
                DataSet.Clear()
                DataAdapter.Fill(DataSet, "Dapat")
                dgvDataObat.DataSource = DataSet.Tables("Dapat")
                dgvDataObat.ReadOnly = True
            Else
                BacaData.Close()
                MessageBox.Show("Data Tidak Ditemukan !!!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgvDataObat_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDataObat.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            Me.dgvDataObat.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(106, 187, 109)
        Else
            Me.dgvDataObat.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
        End If
    End Sub

    'Error handling inputan selain angka
    Private Sub tbHargaJual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbHargaJual.KeyPress
        CheckAngka(e)
    End Sub

    Private Sub tbHargaBeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbHargaBeli.KeyPress
        CheckAngka(e)
    End Sub

    Private Sub tbStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbStok.KeyPress
        CheckAngka(e)
    End Sub
End Class