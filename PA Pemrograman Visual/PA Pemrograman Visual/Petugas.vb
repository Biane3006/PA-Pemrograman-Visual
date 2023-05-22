Imports MySql.Data.MySqlClient

Public Class Petugas
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Petugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Operator <> adalah operator "Tidak Sama dengan"
        'Kondisi Jika yang login adalah APOTEKER
        If Login.tbIdAkun.Text <> 0 Then
            'Menyembunyikan Menu CRUD Obat (CRUD Langsung)
            btnMenuObat.Hide()
            'Menyembunyikan Menu CRUD Pegawai
            btnMenuPegawai.Hide()
            'Menyembunyikan Menu Laporan
            btnMenuLaporanPembelian.Hide()
            btnMenuLaporanPenjualan.Hide()
        Else 'Kondisi Jika yang login adalah OWNER
            'Menyembunyikan Pengaturan Akun dari OWNER
            btnMenuPengaturan.Hide()
            'Menyembunyikan Menu TRANSAKSI PENJUALAN dan TRANSAKSI PEMBELIAN dari OWNER
            btnMenuBeliObat.Hide()
            btnMenuJualObat.Hide()
        End If
        Label2.Text = Login.tbUsername.Text
        Label3.Text = Login.tbIdAkun.Text
        labelApotekSamarinda.Focus()
        'Setting Posisi Label Menu Aktif dan Label Copyright
        labelMenuAktif.Location = New Point((Panel4.Width / 2) - (labelMenuAktif.Width / 2))
        labelCopyright.Location = New Point((Panel5.Width / 2) - (labelCopyright.Width / 2))
    End Sub

    'Mengubah Warna Button Yang Aktif
    Private Sub btnMenuObat_Click(sender As Object, e As EventArgs) Handles btnMenuObat.Click
        'Mengisi Label Aktif
        labelMenuAktif.Text = "DATA OBAT"
        labelMenuAktif.Location = New Point((Panel4.Width / 2) - (labelMenuAktif.Width / 2))
        With Data_Obat
            .TopLevel = False
            .Left = Panel3.Width - .Width
            Panel3.Controls.Clear()
            Panel3.Controls.Add(Data_Obat)
            .BringToFront()
            .Show()
        End With
        'Mengubah warna button saat aktif
        'Ubah warnanya menjadi hijau pudar (Menu Aktif)
        btnMenuObat.BackColor = Color.FromArgb(106, 187, 109)
        'ubahwarnanya menjadi hijau tua (Menu Non-Aktif)
        btnMenuPelanggan.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPegawai.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuSupplier.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuBeliObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuJualObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuLaporanPembelian.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuLaporanPenjualan.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPengaturan.BackColor = Color.FromArgb(30, 97, 36)
    End Sub

    Private Sub btnMenuPelanggan_Click(sender As Object, e As EventArgs) Handles btnMenuPelanggan.Click
        'Mengisi Label Aktif
        labelMenuAktif.Text = "DATA PELANGGAN"
        labelMenuAktif.Location = New Point((Panel4.Width / 2) - (labelMenuAktif.Width / 2))
        With Data_Pelanggan
            .TopLevel = False
            .Left = Panel3.Width - .Width
            Panel3.Controls.Clear()
            Panel3.Controls.Add(Data_Pelanggan)
            .BringToFront()
            .Show()
        End With
        'Mengubah warna button saat aktif
        'Ubah warnanya menjadi hijau pudar (Menu Aktif)
        btnMenuPelanggan.BackColor = Color.FromArgb(106, 187, 109)
        'ubahwarnanya menjadi hijau tua (Menu Non-Aktif)
        btnMenuObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPegawai.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuSupplier.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuBeliObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuJualObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuLaporanPembelian.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuLaporanPenjualan.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPengaturan.BackColor = Color.FromArgb(30, 97, 36)
    End Sub

    Private Sub btnMenuPegawai_Click(sender As Object, e As EventArgs) Handles btnMenuPegawai.Click
        'Mengisi Label Aktif
        labelMenuAktif.Text = "DATA PEGAWAI"
        labelMenuAktif.Location = New Point((Panel4.Width / 2) - (labelMenuAktif.Width / 2))
        With Data_Apoteker
            .TopLevel = False
            .Left = Panel3.Width - .Width
            Panel3.Controls.Clear()
            Panel3.Controls.Add(Data_Apoteker)
            .BringToFront()
            .Show()
        End With
        'Mengubah warna button saat aktif
        'Ubah warnanya menjadi hijau pudar (Menu Aktif)
        btnMenuPegawai.BackColor = Color.FromArgb(106, 187, 109)
        'ubahwarnanya menjadi hijau tua (Menu Non-Aktif)
        btnMenuObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPelanggan.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuSupplier.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuBeliObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuJualObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuLaporanPembelian.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuLaporanPenjualan.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPengaturan.BackColor = Color.FromArgb(30, 97, 36)
    End Sub

    Private Sub btnMenuSupplier_Click(sender As Object, e As EventArgs) Handles btnMenuSupplier.Click
        'Mengisi Label Aktif
        labelMenuAktif.Text = "DATA SUPPLIER"
        labelMenuAktif.Location = New Point((Panel4.Width / 2) - (labelMenuAktif.Width / 2))
        With Data_Supplier
            .TopLevel = False
            .Left = Panel3.Width - .Width
            Panel3.Controls.Clear()
            Panel3.Controls.Add(Data_Supplier)
            .BringToFront()
            .Show()
        End With
        'Mengubah warna button saat aktif
        'Ubah warnanya menjadi hijau pudar (Menu Aktif)
        btnMenuSupplier.BackColor = Color.FromArgb(106, 187, 109)
        'ubahwarnanya menjadi hijau tua (Menu Non-Aktif)
        btnMenuObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPelanggan.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPegawai.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuBeliObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuJualObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuLaporanPembelian.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuLaporanPenjualan.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPengaturan.BackColor = Color.FromArgb(30, 97, 36)
    End Sub

    Private Sub btnMenuBeliObat_Click(sender As Object, e As EventArgs) Handles btnMenuBeliObat.Click
        'Mengisi Label Aktif
        labelMenuAktif.Text = "TRANSAKSI PEMBELIAN OBAT"
        labelMenuAktif.Location = New Point((Panel4.Width / 2) - (labelMenuAktif.Width / 2))

        With Pembelian
            .TopLevel = False
            .Left = Panel3.Width - .Width
            Panel3.Controls.Clear()
            Panel3.Controls.Add(Pembelian)
            .BringToFront()
            .Show()
        End With
        'Mengubah warna button saat aktif
        'Ubah warnanya menjadi hijau pudar (Menu Aktif)
        btnMenuBeliObat.BackColor = Color.FromArgb(106, 187, 109)
        'ubahwarnanya menjadi hijau tua (Menu Non-Aktif)
        btnMenuObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPelanggan.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPegawai.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuSupplier.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuJualObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuLaporanPembelian.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuLaporanPenjualan.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPengaturan.BackColor = Color.FromArgb(30, 97, 36)
    End Sub

    Private Sub btnMenuJualObat_Click(sender As Object, e As EventArgs) Handles btnMenuJualObat.Click
        'Mengisi Label Aktif
        labelMenuAktif.Text = "TRANSAKSI PENJUALAN OBAT"
        labelMenuAktif.Location = New Point((Panel4.Width / 2) - (labelMenuAktif.Width / 2))
        With Penjualan
            .TopLevel = False
            .Left = Panel3.Width - .Width
            Panel3.Controls.Clear()
            Panel3.Controls.Add(Penjualan)
            .BringToFront()
            .Show()
        End With
        'Mengubah warna button saat aktif
        'Ubah warnanya menjadi hijau pudar (Menu Aktif)
        btnMenuJualObat.BackColor = Color.FromArgb(106, 187, 109)
        'ubahwarnanya menjadi hijau tua (Menu Non-Aktif)
        btnMenuObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPelanggan.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPegawai.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuSupplier.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuBeliObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuLaporanPembelian.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuLaporanPenjualan.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPengaturan.BackColor = Color.FromArgb(30, 97, 36)
    End Sub

    Private Sub btnMenuLaporanPembelian_Click(sender As Object, e As EventArgs) Handles btnMenuLaporanPembelian.Click
        'Mengisi Label Aktif
        labelMenuAktif.Text = "LAPORAN PEMBELIAN OBAT"
        labelMenuAktif.Location = New Point((Panel4.Width / 2) - (labelMenuAktif.Width / 2))
        With Laporan_Pembelian
            .TopLevel = False
            .Left = Panel3.Width - .Width
            Panel3.Controls.Clear()
            Panel3.Controls.Add(Laporan_Pembelian)
            .BringToFront()
            .Show()
        End With
        'Mengubah warna button saat aktif
        'Ubah warnanya menjadi hijau pudar (Menu Aktif)
        btnMenuLaporanPembelian.BackColor = Color.FromArgb(106, 187, 109)
        'ubahwarnanya menjadi hijau tua (Menu Non-Aktif)
        btnMenuObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPelanggan.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPegawai.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuSupplier.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuBeliObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuJualObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuLaporanPenjualan.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPengaturan.BackColor = Color.FromArgb(30, 97, 36)
    End Sub

    Private Sub btnMenuLaporanPenjualan_Click(sender As Object, e As EventArgs) Handles btnMenuLaporanPenjualan.Click
        'Mengisi Label Aktif
        labelMenuAktif.Text = "LAPORAN PENJUALAN OBAT"
        labelMenuAktif.Location = New Point((Panel4.Width / 2) - (labelMenuAktif.Width / 2))
        With Laporan_Penjualan
            .TopLevel = False
            .Left = Panel3.Width - .Width
            Panel3.Controls.Clear()
            Panel3.Controls.Add(Laporan_Penjualan)
            .BringToFront()
            .Show()
        End With
        'Mengubah warna button saat aktif
        'Ubah warnanya menjadi hijau pudar (Menu Aktif)
        btnMenuLaporanPenjualan.BackColor = Color.FromArgb(106, 187, 109)
        'ubahwarnanya menjadi hijau tua (Menu Non-Aktif)
        btnMenuObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPelanggan.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPegawai.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuSupplier.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuBeliObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuJualObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuLaporanPembelian.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPengaturan.BackColor = Color.FromArgb(30, 97, 36)
    End Sub

    Private Sub btnMenuPengaturan_Click(sender As Object, e As EventArgs) Handles btnMenuPengaturan.Click
        'Mengisi Label Aktif
        labelMenuAktif.Text = "PENGATURAN AKUN"
        labelMenuAktif.Location = New Point((Panel4.Width / 2) - (labelMenuAktif.Width / 2))
        With Pengaturan_Akun
            .TopLevel = False
            .Left = Panel3.Width - .Width
            Panel3.Controls.Clear()
            Panel3.Controls.Add(Pengaturan_Akun)
            .BringToFront()
            .Show()
        End With
        'Mengubah warna button saat aktif
        'Ubah warnanya menjadi hijau pudar (Menu Aktif)
        btnMenuPengaturan.BackColor = Color.FromArgb(106, 187, 109)
        'ubahwarnanya menjadi hijau tua (Menu Non-Aktif)
        btnMenuObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPelanggan.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuPegawai.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuSupplier.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuBeliObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuJualObat.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuLaporanPembelian.BackColor = Color.FromArgb(30, 97, 36)
        btnMenuLaporanPenjualan.BackColor = Color.FromArgb(30, 97, 36)
    End Sub
End Class