Imports MySql.Data.MySqlClient

Public Class Data_Supplier
    Private Sub Data_Perusahaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connection()
        Call TampilDataSupplier()
        Call Kosong()
        Call MengaturGrid()
    End Sub

    Private Sub Data_Supplier_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub

    Sub Kosong()
        tbKodeSupplier.Clear()
        tbNamaSupplier.Clear()
        tbNamaPerusahaan.Clear()
        tbNomorTelepon.Clear()
        tbAlamat.Clear()
        tbKodeSupplier.Focus()
    End Sub

    Sub TampilDataSupplier()
        DataAdapter = New MySqlDataAdapter("SELECT * FROM tbSupplier", Koneksi)
        DataSet = New DataSet
        DataSet.Clear()
        DataAdapter.Fill(DataSet, "dgvDataSupplier")
        dgvDataSupplier.DataSource = DataSet.Tables("dgvDataSupplier")
        dgvDataSupplier.Refresh()
    End Sub

    Sub MengaturGrid()
        With dgvDataSupplier
            .Columns(0).HeaderText = "KODE SUPPLIER"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "NAMA SUPPLIER"
            .Columns(1).Width = 200
            .Columns(2).HeaderText = "NAMA PERUSAHAAN"
            .Columns(2).Width = 200
            .Columns(3).HeaderText = "NOMOR TELEPON"
            .Columns(3).Width = 150
            .Columns(4).HeaderText = "ALAMAT PERUSAHAAN"
            .Columns(4).Width = 300
        End With
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If tbKodeSupplier.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbKodeSupplier.Focus()
            Exit Sub
        ElseIf tbNamaSupplier.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbNamaSupplier.Focus()
            Exit Sub
        ElseIf tbNamaPerusahaan.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbNamaPerusahaan.Focus()
            Exit Sub
        ElseIf tbNomorTelepon.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbNomorTelepon.Focus()
            Exit Sub
        ElseIf tbAlamat.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbAlamat.Focus()
            Exit Sub
        Else
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbSupplier WHERE kodeSupplier= '" & tbKodeSupplier.Text & "' ", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If Not BacaData.HasRows Then
                BacaData.Close()
                Dim Simpan As String = "Insert Into tbSupplier values ('" & tbKodeSupplier.Text & "' ,'" & tbNamaSupplier.Text & "','" & tbNamaPerusahaan.Text & "','" & tbNomorTelepon.Text & "','" & tbAlamat.Text & "' )"
                Perintah = New MySqlCommand(Simpan, Koneksi)
                Perintah.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Simpan !!!", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Kosong()
                tbKodeSupplier.Focus()
            Else
                MessageBox.Show("Kode Supplier Sudah Digunakan !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BacaData.Close()
                tbKodeSupplier.Focus()
            End If
            Call TampilDataSupplier()
        End If
    End Sub

    'Pada saat Cell diklik atau dipilih akan menngisi form nya
    Private Sub dgvDataSupplier_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataSupplier.CellEnter
        Dim indeksRow As Integer = Me.dgvDataSupplier.CurrentRow.Index
        With dgvDataSupplier.Rows.Item(indeksRow)
            Me.tbKodeSupplier.Text = .Cells(0).Value
            Me.tbNamaSupplier.Text = .Cells(1).Value
            Me.tbNamaPerusahaan.Text = .Cells(2).Value
            Me.tbNomorTelepon.Text = .Cells(3).Value
            Me.tbAlamat.Text = .Cells(4).Value
        End With
    End Sub

    'Mengubah data
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If tbKodeSupplier.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbKodeSupplier.Focus()
            Exit Sub
        ElseIf tbNamaSupplier.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbNamaSupplier.Focus()
            Exit Sub
        ElseIf tbNamaPerusahaan.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbNamaPerusahaan.Focus()
            Exit Sub
        ElseIf tbNomorTelepon.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbNomorTelepon.Focus()
            Exit Sub
        ElseIf tbAlamat.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbAlamat.Focus()
            Exit Sub
        Else
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbSupplier WHERE kodeSupplier= '" & tbKodeSupplier.Text & "' ", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows() Then
                BacaData.Close()
                Dim Ubah As String = "UPDATE tbSupplier Set namaSupplier='" & tbNamaSupplier.Text & "',namaPerusahaan='" & tbNamaPerusahaan.Text & "',nomorTelepon='" & tbNomorTelepon.Text & "',alamatPerusahaan='" & tbAlamat.Text & "' WHERE kodeSupplier='" & tbKodeSupplier.Text & "'"
                Perintah = New MySqlCommand(Ubah, Koneksi)
                Perintah.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Ubah !!!", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call TampilDataSupplier()
                Call Kosong()
                tbKodeSupplier.Focus()
            Else
                MessageBox.Show("Kode Supplier Tidak Ditemukan !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BacaData.Close()
                tbKodeSupplier.Focus()
            End If
            TampilDataSupplier()
        End If
    End Sub

    'Hapus data
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If tbKodeSupplier.Text = "" Then
            MessageBox.Show("Kode Supplier Belum Diisi !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Perintah = New MySqlCommand("Select * FROM tbSupplier WHERE kodeSupplier='" & tbKodeSupplier.Text & "'", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows Then
                BacaData.Close()
                If MessageBox.Show("Apakah anda yakin untuk menghapus data Pelanggan " & tbKodeSupplier.Text & " ? ", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim Hapus As String = "DELETE from tbSupplier WHERE kodeSupplier='" & tbKodeSupplier.Text & "'"
                    Perintah = New MySqlCommand(Hapus, Koneksi)
                    Perintah.ExecuteNonQuery()
                    MessageBox.Show("Data Berhasil Di Hapus !!!", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Kosong()
                    tbKodeSupplier.Focus()
                End If
            Else
                MessageBox.Show("Kode Supplier Tidak Ditemukan !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BacaData.Close()
                tbKodeSupplier.Focus()
            End If
            Call TampilDataSupplier()
        End If
    End Sub

    'Batal isi form
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call Kosong()
    End Sub

    Private Sub tbKodeSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbKodeSupplier.KeyPress
        tbKodeSupplier.MaxLength = 7
        If e.KeyChar = Chr(13) Then
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbSupplier WHERE kodeSupplier= '" & tbKodeSupplier.Text & "' ", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows Then
                tbKodeSupplier.Text = BacaData.Item(0)
                tbNamaSupplier.Text = BacaData.Item(1)
                tbNamaPerusahaan.Text = BacaData.Item(2)
                tbNomorTelepon.Text = BacaData.Item(3)
                tbAlamat.Text = BacaData.Item(4)
            Else
                tbKodeSupplier.Focus()
            End If
        End If
    End Sub

    Private Sub tbCariDataSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCariDataSupplier.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbSupplier WHERE kodeSupplier LIKE '%" & tbCariDataSupplier.Text & "%' OR namaSupplier LIKE '%" & tbCariDataSupplier.Text & "%' OR namaPerusahaan LIKE '%" & tbCariDataSupplier.Text & "%'", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows Then
                BacaData.Close()
                DataAdapter = New MySqlDataAdapter("Select * FROM tbSupplier WHERE kodeSupplier LIKE '%" & tbCariDataSupplier.Text & "%' OR namaSupplier LIKE '%" & tbCariDataSupplier.Text & "%' OR namaPerusahaan LIKE '%" & tbCariDataSupplier.Text & "%'", Koneksi)
                DataSet = New DataSet
                DataSet.Clear()
                DataAdapter.Fill(DataSet, "Dapat")
                dgvDataSupplier.DataSource = DataSet.Tables("Dapat")
                dgvDataSupplier.ReadOnly = True
            Else
                BacaData.Close()
                MessageBox.Show("Data Tidak Ditemukan !!!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgvDataPelanggan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDataSupplier.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            Me.dgvDataSupplier.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(106, 187, 109)
        Else
            Me.dgvDataSupplier.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub tbNomorTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNomorTelepon.KeyPress
        CheckAngka(e)
    End Sub
End Class