Imports MySql.Data.MySqlClient

Public Class Penjualan
    Private Sub Data_Obat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dpTanggalTransaksi.Value = DateTime.Now
        Call Connection()
        BacaApoteker()
        Call BacaPelanggan()
        Call BacaDataObat()
        Call Kosong()
    End Sub

    Sub BacaApoteker()
        Perintah = New MySqlCommand("SELECT kodeApoteker,namaApoteker FROM tbApoteker WHERE idAkun='" & Petugas.Label3.Text & "'", Koneksi)
        BacaData = Perintah.ExecuteReader()
        BacaData.Read()
        If BacaData.HasRows Then
            tbKodeApoteker.Text = BacaData.Item(0)
            tbNamaApoteker.Text = BacaData.Item(1)
        End If
        BacaData.Close()
    End Sub

    'Sub BacaPelanggan untuk memasukkan Kode dan Nama Pelanggan ke dalam ComboBox Pelanggan
    Sub BacaPelanggan()
        Perintah = New MySqlCommand("SELECT kodePelanggan,namaPelanggan FROM tbPelanggan", Koneksi)
        BacaData = Perintah.ExecuteReader()
        Do While BacaData.Read()
            cbKodePelanggan.Items.Add(BacaData.Item(0))
            cbNamaPelanggan.Items.Add(BacaData.Item(1))
        Loop
        BacaData.Close()
    End Sub

    Private Sub cbKodePelanggan_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbKodePelanggan.SelectedIndexChanged
        Call Connection()
        Perintah = New MySqlCommand("SELECT namaPelanggan FROM tbPelanggan WHERE kodePelanggan='" & cbKodePelanggan.Text & "'", Koneksi)
        BacaData = Perintah.ExecuteReader()
        BacaData.Read()
        If BacaData.HasRows Then
            cbNamaPelanggan.Text = BacaData.Item(0)
        End If
        BacaData.Close()
    End Sub

    Private Sub cbNamaPelanggan_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbNamaPelanggan.SelectedIndexChanged
        Call Connection()
        Perintah = New MySqlCommand("SELECT kodePelanggan FROM tbPelanggan WHERE namaPelanggan='" & cbNamaPelanggan.Text & "'", Koneksi)
        BacaData = Perintah.ExecuteReader()
        BacaData.Read()
        If BacaData.HasRows Then
            cbKodePelanggan.Text = BacaData.Item(0)
        End If
        BacaData.Close()
    End Sub

    Sub BacaDataObat()
        'Hanya akan mengisi comboBox dengan kodeObat yang stoknya ada.
        Perintah = New MySqlCommand("SELECT kodeObat,namaObat FROM tbObat WHERE jumlahStok > 0", Koneksi)
        BacaData = Perintah.ExecuteReader()
        If BacaData.HasRows Then
            Do While BacaData.Read()
                cbKodeObat.Items.Add(BacaData.Item(0))
                cbNamaObat.Items.Add(BacaData.Item(1))
            Loop
        End If
        BacaData.Close()
    End Sub

    Private Sub cbKodeObat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKodeObat.SelectedIndexChanged
        Call Connection()
        Perintah = New MySqlCommand("SELECT namaObat,hargaJualObat,jumlahStok FROM tbObat WHERE kodeObat='" & cbKodeObat.Text & "'", Koneksi)
        Dim BacaData1 As MySqlDataReader = Perintah.ExecuteReader()
        BacaData1.Read()
        If BacaData1.HasRows Then
            cbNamaObat.Text = BacaData1.Item(0)
            tbHargaObat.Text = BacaData1.Item(1)
            tbSisaStok.Text = BacaData1.Item(2)
        End If
        tbQuantity.Text = 1
        tbTotal.Text = Val(tbHargaObat.Text) * Val(tbQuantity.Text)
        BacaData.Close()
    End Sub

    Private Sub cbNamaObat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNamaObat.SelectedIndexChanged
        Call Connection()
        Perintah = New MySqlCommand("SELECT kodeObat,hargaJualObat,jumlahStok FROM tbObat WHERE namaObat='" & cbNamaObat.Text & "'", Koneksi)
        Dim BacaData2 As MySqlDataReader = Perintah.ExecuteReader()
        BacaData2.Read()
        If BacaData2.HasRows Then
            cbKodeObat.Text = BacaData2.Item(0)
            tbHargaObat.Text = BacaData2.Item(1)
            tbSisaStok.Text = BacaData2.Item(2)
        End If
        tbQuantity.Text = 1
        tbTotal.Text = Val(tbHargaObat.Text) * Val(tbQuantity.Text)
        BacaData.Close()
    End Sub

    Private Sub Data_Obat_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub

    Sub Kosong()
        tbKodePenjualan.Clear()
        cbKodePelanggan.SelectedItem = Nothing
        cbNamaPelanggan.SelectedItem = Nothing
        cbKodeObat.SelectedItem = Nothing
        cbNamaObat.SelectedItem = Nothing
        tbSisaStok.Text = ""
        tbHargaObat.Text = ""
        tbQuantity.Text = ""
        tbTotal.Text = ""
        tbKodePenjualan.Focus()
    End Sub

    'BTN TAMBAH (Memesan Obat)
    Private Sub btnTambahPesanan_Click(sender As Object, e As EventArgs) Handles btnTambahPesanan.Click
        If cbKodeObat.SelectedItem Is Nothing Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbKodeObat.Focus()
        ElseIf tbQuantity.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbQuantity.Focus()
        ElseIf tbQuantity.Text = 0 Then
            MessageBox.Show("Jumlah Obat yang Dijual Tidak Boleh 0 !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbQuantity.Focus()
            'Jika sisa stoknya gak cukup
        ElseIf Val(tbQuantity.Text) > Val(tbSisaStok.Text) Then
            MessageBox.Show("Jumlah Stok Obat Tidak Cukup !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim j As Integer = 0
            Dim sama As Boolean = False
            'Memeriksa Apakah Obat Sudah ada di dalam DATAGRIDVIEW nya
            While (j <= (dgvPenjualanObat.Rows.Count - 1))
                If dgvPenjualanObat.Rows(j).Cells(1).Value.Equals(cbKodeObat.Text) Then
                    sama = True
                    MessageBox.Show("Obat Sudah Dipesan, Silahkan Ganti Quantity Obat!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit While
                End If
                j = j + 1
            End While
            If sama = False Then
                dgvPenjualanObat.Rows.Add("", cbKodeObat.Text, cbNamaObat.Text, tbHargaObat.Text, Val(tbQuantity.Text.ToString), tbTotal.Text, "Batal", tbSisaStok.Text)
                'Membersikan Form Obat
                cbKodeObat.SelectedItem = Nothing
                cbNamaObat.SelectedItem = Nothing
                tbSisaStok.Text = ""
                tbHargaObat.Text = ""
                tbQuantity.Text = ""
                tbTotal.Text = ""
            End If
        End If
        Call Penomoran()

        UpdateTotalPembayaran()
    End Sub

    Private Sub tbQuantity_TextChanged(sender As Object, e As EventArgs) Handles tbQuantity.TextChanged
        tbTotal.Text = Val(tbQuantity.Text) * Val(tbHargaObat.Text)
    End Sub

    'MENGUBAH QUANTITY OBAT DI DATAGRIDVIEWNYA
    Private Sub dgvPenjualanObat_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvPenjualanObat.CurrentCellDirtyStateChanged
        Try
            'Jika Quantity diubah menjadi 0 ataupun negatif maka akan menjadi 1 lagi
            If dgvPenjualanObat.CurrentRow.Cells(4).Value <= 0 Then
                MessageBox.Show("Quantity Tidak Boleh 0 ataupun Negatif !!!", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'Mengisi Quantity menjadi Default 1
                dgvPenjualanObat.CurrentRow.Cells(4).Value = 1
            ElseIf Val(dgvPenjualanObat.CurrentRow.Cells(4).Value.ToString) > Val(dgvPenjualanObat.CurrentRow.Cells(7).Value.ToString) Then
                MessageBox.Show("Jumlah Stok Tidak Cukup !!!", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'Mengisi Quantity menjadi Default 1
                dgvPenjualanObat.CurrentRow.Cells(4).Value = 1
            Else
                'Mengubah Format Angka jika dimasukkan 0001 supaya menjadi 1
                dgvPenjualanObat.CurrentRow.Cells(4).Value = Val(dgvPenjualanObat.CurrentRow.Cells(4).Value.ToString)
            End If
            'Mengupdate Total
            Dim Total As Integer = Val(dgvPenjualanObat.CurrentRow.Cells(3).Value) * Val(dgvPenjualanObat.CurrentRow.Cells(4).Value)
            'Memasukkan hasil perkalian Harga Satuan dengan Quantity
            dgvPenjualanObat.CurrentRow.Cells(5).Value = Total
            Call UpdateTotalPembayaran()
        Catch ex As Exception
            MessageBox.Show("Masukkan Angka!!!", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dgvPenjualanObat.CurrentRow.Cells(4).Value = 1
            Dim Total As Integer = Val(dgvPenjualanObat.CurrentRow.Cells(3).Value) * Val(dgvPenjualanObat.CurrentRow.Cells(4).Value)
            dgvPenjualanObat.CurrentRow.Cells(5).Value = Total
        End Try
    End Sub

    'Mengupdate Total Pembayaran yang harus dibayarkan
    Private Sub UpdateTotalPembayaran()
        If dgvPenjualanObat IsNot Nothing Then
            Dim totalPembayaran As Double = 0
            Dim indeks As Integer
            While (indeks <= dgvPenjualanObat.Rows.Count - 1)
                totalPembayaran = totalPembayaran + dgvPenjualanObat.Rows(indeks).Cells(5).Value
                indeks = indeks + 1
            End While
            tbTotalPembayaran.Text = totalPembayaran
        Else
            tbTotalPembayaran.Text = 0
        End If
    End Sub

    'menghapus pesanan obat
    Private Sub dgvpenjualanobat_cellcontentclick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPenjualanObat.CellContentClick
        If dgvPenjualanObat.Columns(e.ColumnIndex).Name = "btnBatal" Then
            dgvPenjualanObat.Rows.RemoveAt(dgvPenjualanObat.Rows(e.RowIndex).Index)
            Call Penomoran()
            Call UpdateTotalPembayaran()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If tbKodePenjualan.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbKodePenjualan.Focus()
        ElseIf dgvPenjualanObat.RowCount = 0 Then
            MessageBox.Show("Belum Ada Data Obat yang Dipesan !!!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cbKodePelanggan.SelectedIndex = -1 Or cbNamaPelanggan.SelectedIndex = -1 Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbKodePelanggan.Focus()
        Else
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbPenjualan WHERE kodePenjualan='" & tbKodePenjualan.Text & "'", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If Not BacaData.HasRows Then
                BacaData.Close()
                Dim SimpanPenjualan As String = "INSERT INTO tbPenjualan VALUES ('" & tbKodePenjualan.Text & "','" & dpTanggalTransaksi.Value.ToString("yyyy/MM/dd") & "','" & tbKodeApoteker.Text & "','" & cbKodePelanggan.Text & "','" & tbTotalPembayaran.Text & "')"
                Perintah = New MySqlCommand(SimpanPenjualan, Koneksi)
                Perintah.ExecuteNonQuery()

                'Memasukkan data yang ada di DataGridView ke dalam database tbDetailPenjualan
                For Each Baris As DataGridViewRow In dgvPenjualanObat.Rows
                    Dim KodeObat As String = Baris.Cells("KodeObat").Value
                    Dim HargaSatuan As Integer = Baris.Cells("HargaSatuan").Value
                    Dim Quantity As Integer = Baris.Cells("Quantity").Value
                    Dim Total As Integer = Baris.Cells("Total").Value
                    Dim SimpanDetailPenjualan As String = "INSERT INTO tbDetailPenjualan VALUES ('" & tbKodePenjualan.Text & "','" & KodeObat & "'," & HargaSatuan & "," & Quantity & "," & Total & " )"
                    Perintah = New MySqlCommand(SimpanDetailPenjualan, Koneksi)
                    Perintah.ExecuteNonQuery()
                Next
                MessageBox.Show("Data Berhasil Di Simpan !!!", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Kosong()
                dgvPenjualanObat.Rows.Clear()
                tbKodePenjualan.Focus()
            Else
                MessageBox.Show("Kode Penjualan Sudah Digunakan !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BacaData.Close()
                tbKodePenjualan.Focus()
            End If
        End If
    End Sub

    Private Sub Penomoran()
        If dgvPenjualanObat IsNot Nothing Then
            Dim JmlhKolom As Integer = 0
            While (JmlhKolom <= (dgvPenjualanObat.Rows.Count - 1))
                dgvPenjualanObat.Rows(JmlhKolom).Cells(0).Value = String.Format((JmlhKolom + 1).ToString(), "0")
                JmlhKolom = JmlhKolom + 1
            End While
        End If
    End Sub

    Private Sub dgvPenjualan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPenjualanObat.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            Me.dgvPenjualanObat.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Orange
        Else
            Me.dgvPenjualanObat.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub tbQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbQuantity.KeyPress
        CheckAngka(e)
    End Sub
End Class