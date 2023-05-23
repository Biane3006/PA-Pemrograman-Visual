Imports MySql.Data.MySqlClient

Public Class Pembelian
    Private Sub Data_Obat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dpTanggalTransaksi.Value = DateTime.Now
        Call Connection()
        BacaApoteker()
        Call BacaSupplier()
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

    'Sub BacaSupplier untuk memasukkan Kode dan Nama Pelanggan ke dalam ComboBox Pelanggan
    Sub BacaSupplier()
        Perintah = New MySqlCommand("SELECT kodeSupplier,namaSupplier FROM tbSupplier", Koneksi)
        BacaData = Perintah.ExecuteReader()
        Do While BacaData.Read()
            cbKodeSupplier.Items.Add(BacaData.Item(0))
            cbNamaSupplier.Items.Add(BacaData.Item(1))
        Loop
        BacaData.Close()
    End Sub

    Private Sub cbKodeSupplier_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbKodeSupplier.SelectedIndexChanged
        Call Connection()
        Perintah = New MySqlCommand("SELECT namaSupplier FROM tbSupplier WHERE kodeSupplier='" & cbKodeSupplier.Text & "'", Koneksi)
        BacaData = Perintah.ExecuteReader()
        BacaData.Read()
        If BacaData.HasRows Then
            cbNamaSupplier.Text = BacaData.Item(0)
        End If
        BacaData.Close()
    End Sub

    Private Sub cbNamaSupplier_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbNamaSupplier.SelectedIndexChanged
        Call Connection()
        Perintah = New MySqlCommand("SELECT kodeSupplier FROM tbSupplier WHERE namaSupplier='" & cbNamaSupplier.Text & "'", Koneksi)
        BacaData = Perintah.ExecuteReader()
        BacaData.Read()
        If BacaData.HasRows Then
            cbKodeSupplier.Text = BacaData.Item(0)
        End If
        BacaData.Close()
    End Sub

    Sub BacaDataObat()
        'Hanya akan mengisi comboBox dengan kodeObat yang stoknya ada.
        Perintah = New MySqlCommand("SELECT kodeObat,namaObat FROM tbObat", Koneksi)
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
        Perintah = New MySqlCommand("SELECT namaObat,hargaBeliObat,jumlahStok FROM tbObat WHERE kodeObat='" & cbKodeObat.Text & "'", Koneksi)
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
        Perintah = New MySqlCommand("SELECT kodeObat,hargaBeliObat,jumlahStok FROM tbObat WHERE namaObat='" & cbNamaObat.Text & "'", Koneksi)
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
        tbKodePembelian.Clear()
        cbKodeSupplier.SelectedItem = Nothing
        cbNamaSupplier.SelectedItem = Nothing
        cbKodeObat.SelectedItem = Nothing
        cbNamaObat.SelectedItem = Nothing
        tbSisaStok.Text = ""
        tbHargaObat.Text = ""
        tbQuantity.Text = ""
        tbTotal.Text = ""
        tbKodePembelian.Focus()
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
            MessageBox.Show("Jumlah Obat yang Dibeli Tidak Boleh 0 !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbQuantity.Focus()
        Else
            Dim j As Integer = 0
            Dim sama As Boolean = False
            'Memeriksa Apakah Obat Sudah ada di dalam DATAGRIDVIEW nya
            While (j <= (dgvPembelianObat.Rows.Count - 1))
                If dgvPembelianObat.Rows(j).Cells(1).Value.Equals(cbKodeObat.Text) Then
                    sama = True
                    MessageBox.Show("Obat Sudah Dipesan, Silahkan Ganti Quantity Obat!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit While
                End If
                j = j + 1
            End While
            If sama = False Then
                dgvPembelianObat.Rows.Add("", cbKodeObat.Text, cbNamaObat.Text, tbHargaObat.Text, Val(tbQuantity.Text.ToString), tbTotal.Text, "Batal")
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
        Call UpdateTotalPembayaran()
    End Sub

    Private Sub tbQuantity_TextChanged(sender As Object, e As EventArgs) Handles tbQuantity.TextChanged
        tbTotal.Text = Val(tbQuantity.Text) * Val(tbHargaObat.Text)
    End Sub

    'MENGUBAH QUANTITY OBAT DI DATAGRIDVIEWNYA
    Private Sub dgvPembelianObat_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvPembelianObat.CurrentCellDirtyStateChanged
        Try
            'Jika Quantity diubah menjadi 0 ataupun negatif maka akan menjadi 1 lagi
            If dgvPembelianObat.CurrentRow.Cells(4).Value <= 0 Then
                MessageBox.Show("Quantity Tidak Boleh 0 ataupun Negatif !!!", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'Mengisi Quantity menjadi Default 1
                dgvPembelianObat.CurrentRow.Cells(4).Value = 1
            Else
                'Mengubah Format Angka jika dimasukkan 0001 supaya menjadi 1
                dgvPembelianObat.CurrentRow.Cells(4).Value = Val(dgvPembelianObat.CurrentRow.Cells(4).Value.ToString)
            End If
            'Mengupdate Total
            Dim Total As Integer = Val(dgvPembelianObat.CurrentRow.Cells(3).Value) * Val(dgvPembelianObat.CurrentRow.Cells(4).Value)
            'Memasukkan hasil perkalian Harga Satuan dengan Quantity
            dgvPembelianObat.CurrentRow.Cells(5).Value = Total
            Call UpdateTotalPembayaran()
        Catch ex As Exception
            MessageBox.Show("Masukkan Angka!!!", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dgvPembelianObat.CurrentRow.Cells(4).Value = 1
            Dim Total As Integer = Val(dgvPembelianObat.CurrentRow.Cells(3).Value) * Val(dgvPembelianObat.CurrentRow.Cells(4).Value)
            dgvPembelianObat.CurrentRow.Cells(5).Value = Total
        End Try
    End Sub

    'Mengupdate Total Pembayaran yang harus dibayarkan
    Private Sub UpdateTotalPembayaran()
        If dgvPembelianObat IsNot Nothing Then
            Dim totalPembayaran As Double = 0
            Dim indeks As Integer
            While (indeks <= dgvPembelianObat.Rows.Count - 1)
                totalPembayaran = totalPembayaran + dgvPembelianObat.Rows(indeks).Cells(5).Value
                indeks = indeks + 1
            End While
            tbTotalPembayaran.Text = totalPembayaran
        Else
            tbTotalPembayaran.Text = 0
        End If
    End Sub

    'Menghapus Pesanan Obat
    Private Sub dgvPenjualanObat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPembelianObat.CellContentClick
        'Ketika Header Column Batal di klik akan terjadi indeks out of range, sehingga dibuatkan percabangan untuk menghindari error
        If e.RowIndex = -1 AndAlso e.ColumnIndex >= 0 Then
            'Tidak terjadi apa-apa
        ElseIf dgvPembelianObat.Columns(e.ColumnIndex).Name = "btnBatal" Then
            dgvPembelianObat.Rows.RemoveAt(dgvPembelianObat.Rows(e.RowIndex).Index)
            Call Penomoran()
            Call UpdateTotalPembayaran()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If tbKodePembelian.Text = "" Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbKodePembelian.Focus()
        ElseIf cbKodeSupplier.SelectedIndex = -1 Or cbNamaSupplier.SelectedIndex = -1 Then
            MessageBox.Show("Data Belum Lengkap !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbKodeSupplier.Focus()
        ElseIf dgvPembelianObat.RowCount = 0 Then
            MessageBox.Show("Belum Ada Data Obat yang Dipesan !!!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbPembelian WHERE kodePembelian='" & tbKodePembelian.Text & "'", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If Not BacaData.HasRows Then
                BacaData.Close()
                Dim SimpanPenjualan As String = "INSERT INTO tbPembelian VALUES ('" & tbKodePembelian.Text & "','" & dpTanggalTransaksi.Value.ToString("yyyy/MM/dd") & "','" & tbKodeApoteker.Text & "','" & cbKodeSupplier.Text & "','" & tbTotalPembayaran.Text & "')"
                Perintah = New MySqlCommand(SimpanPenjualan, Koneksi)
                Perintah.ExecuteNonQuery()

                'Memasukkan data yang ada di DataGridView ke dalam database tbDetailPembelian
                For Each Baris As DataGridViewRow In dgvPembelianObat.Rows
                    Dim KodeObat As String = Baris.Cells("KodeObat").Value
                    Dim HargaSatuan As Integer = Baris.Cells("HargaSatuan").Value
                    Dim Quantity As Integer = Baris.Cells("Quantity").Value
                    Dim Total As Integer = Baris.Cells("Total").Value
                    Dim SimpanDetailPenjualan As String = "INSERT INTO tbDetailPembelian VALUES ('" & tbKodePembelian.Text & "','" & KodeObat & "'," & HargaSatuan & "," & Quantity & "," & Total & " )"
                    Perintah = New MySqlCommand(SimpanDetailPenjualan, Koneksi)
                    Perintah.ExecuteNonQuery()
                Next
                MessageBox.Show("Data Berhasil Di Simpan !!!", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Kosong()
                dgvPembelianObat.Rows.Clear()
                tbKodePembelian.Focus()
            Else
                MessageBox.Show("Kode Pembelian Sudah Digunakan !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BacaData.Close()
                tbKodePembelian.Focus()
            End If
        End If
    End Sub

    Private Sub Penomoran()
        If dgvPembelianObat IsNot Nothing Then
            Dim JmlhKolom As Integer = 0
            While (JmlhKolom <= (dgvPembelianObat.Rows.Count - 1))
                dgvPembelianObat.Rows(JmlhKolom).Cells(0).Value = String.Format((JmlhKolom + 1).ToString(), "0")
                JmlhKolom = JmlhKolom + 1
            End While
        End If
    End Sub

    Private Sub dgvPenjualan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPembelianObat.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            Me.dgvPembelianObat.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Orange
        Else
            Me.dgvPembelianObat.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub tbQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbQuantity.KeyPress
        CheckAngka(e)
    End Sub
End Class