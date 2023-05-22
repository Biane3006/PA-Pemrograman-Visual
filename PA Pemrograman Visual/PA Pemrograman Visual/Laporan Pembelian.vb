Imports MySql.Data.MySqlClient

Public Class Laporan_Pembelian
    Private Sub Laporan_Pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connection()
        Call TampilLaporanPembelian()
        Call MengaturGrid()
    End Sub

    Private Sub Data_Pembelian_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub

    Sub TampilLaporanPembelian()
        DataAdapter = New MySqlDataAdapter("SELECT * FROM tbPembelian", Koneksi)
        DataSet = New DataSet
        DataSet.Clear()
        DataAdapter.Fill(DataSet, "dgvLaporanPembelian")
        dgvLaporanPembelian.DataSource = DataSet.Tables("dgvLaporanPembelian")
        dgvLaporanPembelian.Refresh()
    End Sub

    Sub MengaturGrid()
        With dgvLaporanPembelian
            .Columns(0).HeaderText = "KODE PEMBELIAN"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "TANGGAL TRANSAKSI"
            .Columns(1).Width = 200
            .Columns(2).HeaderText = "KODE APOTEKER"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "KODE SUPPLIER"
            .Columns(3).Width = 150
            .Columns(4).HeaderText = "TOTAL PEMBAYARAN"
            .Columns(4).Width = 150
        End With
    End Sub

    Private Sub tbCariLaporanPembelian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCariLaporanPembelian.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbPembelian WHERE kodePembelian LIKE '%" & tbCariLaporanPembelian.Text & "%' OR tanggalTransaksi LIKE '%" & tbCariLaporanPembelian.Text & "%' OR kodeApoteker LIKE '%" & tbCariLaporanPembelian.Text & "%' OR kodeSupplier LIKE '%" & tbCariLaporanPembelian.Text & "%'", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows Then
                BacaData.Close()
                DataAdapter = New MySqlDataAdapter("Select * FROM tbPembelian WHERE kodePembelian LIKE '%" & tbCariLaporanPembelian.Text & "%' OR tanggalTransaksi LIKE '%" & tbCariLaporanPembelian.Text & "%' OR kodeApoteker LIKE '%" & tbCariLaporanPembelian.Text & "%' OR kodeSupplier LIKE '%" & tbCariLaporanPembelian.Text & "%'", Koneksi)
                DataSet = New DataSet
                DataSet.Clear()
                DataAdapter.Fill(DataSet, "Dapat")
                dgvLaporanPembelian.DataSource = DataSet.Tables("Dapat")
                dgvLaporanPembelian.ReadOnly = True
            Else
                BacaData.Close()
                MessageBox.Show("Data Tidak Ditemukan !!!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgvDataPelanggan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvLaporanPembelian.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            Me.dgvLaporanPembelian.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(106, 187, 109)
        Else
            Me.dgvLaporanPembelian.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        CetakLaporanPembelian.Show()
    End Sub
End Class