Imports MySql.Data.MySqlClient

Public Class Laporan_Penjualan
    Private Sub Laporan_Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connection()
        Call TampilLaporanPenjualan()
        Call MengaturGrid()
    End Sub

    Private Sub Data_Penjualan_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub

    Sub TampilLaporanPenjualan()
        DataAdapter = New MySqlDataAdapter("SELECT * FROM tbPenjualan", Koneksi)
        DataSet = New DataSet
        DataSet.Clear()
        DataAdapter.Fill(DataSet, "dgvLaporanPenjualan")
        dgvLaporanPenjualan.DataSource = DataSet.Tables("dgvLaporanPenjualan")
        dgvLaporanPenjualan.Refresh()
    End Sub

    Sub MengaturGrid()
        With dgvLaporanPenjualan
            .Columns(0).HeaderText = "KODE PENJUALAN"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "TANGGAL TRANSAKSI"
            .Columns(1).Width = 200
            .Columns(2).HeaderText = "KODE APOTEKER"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "KODE PELANGGAN"
            .Columns(3).Width = 150
            .Columns(4).HeaderText = "TOTAL PEMBAYARAN"
            .Columns(4).Width = 150
        End With
    End Sub

    Private Sub tbCariLaporanPenjualan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCariLaporanPenjualan.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Connection()
            Perintah = New MySqlCommand("Select * FROM tbPenjualan WHERE kodePenjualan LIKE '%" & tbCariLaporanPenjualan.Text & "%' OR tanggalTransaksi LIKE '%" & tbCariLaporanPenjualan.Text & "%' OR kodeApoteker LIKE '%" & tbCariLaporanPenjualan.Text & "%' OR kodePelanggan LIKE '%" & tbCariLaporanPenjualan.Text & "%'", Koneksi)
            BacaData = Perintah.ExecuteReader()
            BacaData.Read()
            If BacaData.HasRows Then
                BacaData.Close()
                DataAdapter = New MySqlDataAdapter("Select * FROM tbPenjualan WHERE kodePenjualan LIKE '%" & tbCariLaporanPenjualan.Text & "%' OR tanggalTransaksi LIKE '%" & tbCariLaporanPenjualan.Text & "%' OR kodeApoteker LIKE '%" & tbCariLaporanPenjualan.Text & "%' OR kodePelanggan LIKE '%" & tbCariLaporanPenjualan.Text & "%'", Koneksi)
                DataSet = New DataSet
                DataSet.Clear()
                DataAdapter.Fill(DataSet, "Dapat")
                dgvLaporanPenjualan.DataSource = DataSet.Tables("Dapat")
                dgvLaporanPenjualan.ReadOnly = True
            Else
                BacaData.Close()
                MessageBox.Show("Data Tidak Ditemukan !!!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgvDataPelanggan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvLaporanPenjualan.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            Me.dgvLaporanPenjualan.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(106, 187, 109)
        Else
            Me.dgvLaporanPenjualan.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        CetakLaporanPenjualan.Show()
    End Sub
End Class