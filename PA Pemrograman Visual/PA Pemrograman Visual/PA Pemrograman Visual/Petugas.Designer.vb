<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Petugas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Petugas))
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.labelApotekSamarinda = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnMenuPengaturan = New System.Windows.Forms.Button()
        Me.btnMenuLaporanPenjualan = New System.Windows.Forms.Button()
        Me.btnMenuLaporanPembelian = New System.Windows.Forms.Button()
        Me.btnMenuBeliObat = New System.Windows.Forms.Button()
        Me.btnMenuSupplier = New System.Windows.Forms.Button()
        Me.btnMenuJualObat = New System.Windows.Forms.Button()
        Me.btnMenuPelanggan = New System.Windows.Forms.Button()
        Me.btnMenuPegawai = New System.Windows.Forms.Button()
        Me.btnMenuObat = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.labelMenuAktif = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labelCopyright = New System.Windows.Forms.Label()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.PanelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLogo.Controls.Add(Me.labelApotekSamarinda)
        Me.PanelLogo.Controls.Add(Me.PictureBox2)
        Me.PanelLogo.Controls.Add(Me.Label3)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(218, 104)
        Me.PanelLogo.TabIndex = 0
        '
        'labelApotekSamarinda
        '
        Me.labelApotekSamarinda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelApotekSamarinda.AutoSize = True
        Me.labelApotekSamarinda.BackColor = System.Drawing.Color.Transparent
        Me.labelApotekSamarinda.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelApotekSamarinda.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelApotekSamarinda.Location = New System.Drawing.Point(1, 66)
        Me.labelApotekSamarinda.Name = "labelApotekSamarinda"
        Me.labelApotekSamarinda.Size = New System.Drawing.Size(217, 28)
        Me.labelApotekSamarinda.TabIndex = 16
        Me.labelApotekSamarinda.Text = "APOTEK SAMARINDA"
        Me.labelApotekSamarinda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(75, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(-4, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "idAkun"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(754, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(54, 41)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(996, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(32, 354)
        Me.Panel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(220, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 41)
        Me.Panel1.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(220, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(776, 354)
        Me.Panel3.TabIndex = 4
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenu.Controls.Add(Me.btnMenuPengaturan)
        Me.PanelMenu.Controls.Add(Me.btnMenuLaporanPenjualan)
        Me.PanelMenu.Controls.Add(Me.btnMenuLaporanPembelian)
        Me.PanelMenu.Controls.Add(Me.btnMenuBeliObat)
        Me.PanelMenu.Controls.Add(Me.btnMenuJualObat)
        Me.PanelMenu.Controls.Add(Me.btnMenuSupplier)
        Me.PanelMenu.Controls.Add(Me.btnMenuPelanggan)
        Me.PanelMenu.Controls.Add(Me.btnMenuPegawai)
        Me.PanelMenu.Controls.Add(Me.btnMenuObat)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 477)
        Me.PanelMenu.TabIndex = 0
        '
        'btnMenuPengaturan
        '
        Me.btnMenuPengaturan.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnMenuPengaturan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuPengaturan.FlatAppearance.BorderSize = 0
        Me.btnMenuPengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuPengaturan.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuPengaturan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMenuPengaturan.Image = CType(resources.GetObject("btnMenuPengaturan.Image"), System.Drawing.Image)
        Me.btnMenuPengaturan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuPengaturan.Location = New System.Drawing.Point(0, 456)
        Me.btnMenuPengaturan.Name = "btnMenuPengaturan"
        Me.btnMenuPengaturan.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnMenuPengaturan.Size = New System.Drawing.Size(218, 44)
        Me.btnMenuPengaturan.TabIndex = 18
        Me.btnMenuPengaturan.Text = "Pengaturan Akun"
        Me.btnMenuPengaturan.UseVisualStyleBackColor = False
        '
        'btnMenuLaporanPenjualan
        '
        Me.btnMenuLaporanPenjualan.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnMenuLaporanPenjualan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuLaporanPenjualan.FlatAppearance.BorderSize = 0
        Me.btnMenuLaporanPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuLaporanPenjualan.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuLaporanPenjualan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMenuLaporanPenjualan.Image = CType(resources.GetObject("btnMenuLaporanPenjualan.Image"), System.Drawing.Image)
        Me.btnMenuLaporanPenjualan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuLaporanPenjualan.Location = New System.Drawing.Point(0, 412)
        Me.btnMenuLaporanPenjualan.Name = "btnMenuLaporanPenjualan"
        Me.btnMenuLaporanPenjualan.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnMenuLaporanPenjualan.Size = New System.Drawing.Size(218, 44)
        Me.btnMenuLaporanPenjualan.TabIndex = 17
        Me.btnMenuLaporanPenjualan.Text = "Laporan Penjualan"
        Me.btnMenuLaporanPenjualan.UseVisualStyleBackColor = False
        '
        'btnMenuLaporanPembelian
        '
        Me.btnMenuLaporanPembelian.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnMenuLaporanPembelian.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuLaporanPembelian.FlatAppearance.BorderSize = 0
        Me.btnMenuLaporanPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuLaporanPembelian.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuLaporanPembelian.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMenuLaporanPembelian.Image = CType(resources.GetObject("btnMenuLaporanPembelian.Image"), System.Drawing.Image)
        Me.btnMenuLaporanPembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuLaporanPembelian.Location = New System.Drawing.Point(0, 368)
        Me.btnMenuLaporanPembelian.Name = "btnMenuLaporanPembelian"
        Me.btnMenuLaporanPembelian.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnMenuLaporanPembelian.Size = New System.Drawing.Size(218, 44)
        Me.btnMenuLaporanPembelian.TabIndex = 16
        Me.btnMenuLaporanPembelian.Text = "Laporan Pembelian"
        Me.btnMenuLaporanPembelian.UseVisualStyleBackColor = False
        '
        'btnMenuBeliObat
        '
        Me.btnMenuBeliObat.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnMenuBeliObat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuBeliObat.FlatAppearance.BorderSize = 0
        Me.btnMenuBeliObat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuBeliObat.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuBeliObat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMenuBeliObat.Image = CType(resources.GetObject("btnMenuBeliObat.Image"), System.Drawing.Image)
        Me.btnMenuBeliObat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuBeliObat.Location = New System.Drawing.Point(0, 324)
        Me.btnMenuBeliObat.Name = "btnMenuBeliObat"
        Me.btnMenuBeliObat.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnMenuBeliObat.Size = New System.Drawing.Size(218, 44)
        Me.btnMenuBeliObat.TabIndex = 14
        Me.btnMenuBeliObat.Text = "Beli Obat"
        Me.btnMenuBeliObat.UseVisualStyleBackColor = False
        '
        'btnMenuSupplier
        '
        Me.btnMenuSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnMenuSupplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuSupplier.FlatAppearance.BorderSize = 0
        Me.btnMenuSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuSupplier.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMenuSupplier.Image = CType(resources.GetObject("btnMenuSupplier.Image"), System.Drawing.Image)
        Me.btnMenuSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuSupplier.Location = New System.Drawing.Point(0, 236)
        Me.btnMenuSupplier.Name = "btnMenuSupplier"
        Me.btnMenuSupplier.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnMenuSupplier.Size = New System.Drawing.Size(218, 44)
        Me.btnMenuSupplier.TabIndex = 13
        Me.btnMenuSupplier.Text = "Data Supplier"
        Me.btnMenuSupplier.UseVisualStyleBackColor = False
        '
        'btnMenuJualObat
        '
        Me.btnMenuJualObat.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnMenuJualObat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuJualObat.FlatAppearance.BorderSize = 0
        Me.btnMenuJualObat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuJualObat.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuJualObat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMenuJualObat.Image = CType(resources.GetObject("btnMenuJualObat.Image"), System.Drawing.Image)
        Me.btnMenuJualObat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuJualObat.Location = New System.Drawing.Point(0, 280)
        Me.btnMenuJualObat.Name = "btnMenuJualObat"
        Me.btnMenuJualObat.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnMenuJualObat.Size = New System.Drawing.Size(218, 44)
        Me.btnMenuJualObat.TabIndex = 15
        Me.btnMenuJualObat.Text = "Jual Obat"
        Me.btnMenuJualObat.UseVisualStyleBackColor = False
        '
        'btnMenuPelanggan
        '
        Me.btnMenuPelanggan.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnMenuPelanggan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuPelanggan.FlatAppearance.BorderSize = 0
        Me.btnMenuPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuPelanggan.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuPelanggan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMenuPelanggan.Image = CType(resources.GetObject("btnMenuPelanggan.Image"), System.Drawing.Image)
        Me.btnMenuPelanggan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuPelanggan.Location = New System.Drawing.Point(0, 192)
        Me.btnMenuPelanggan.Name = "btnMenuPelanggan"
        Me.btnMenuPelanggan.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnMenuPelanggan.Size = New System.Drawing.Size(218, 44)
        Me.btnMenuPelanggan.TabIndex = 11
        Me.btnMenuPelanggan.Text = "Data Pelanggan"
        Me.btnMenuPelanggan.UseVisualStyleBackColor = False
        '
        'btnMenuPegawai
        '
        Me.btnMenuPegawai.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnMenuPegawai.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuPegawai.FlatAppearance.BorderSize = 0
        Me.btnMenuPegawai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuPegawai.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuPegawai.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMenuPegawai.Image = CType(resources.GetObject("btnMenuPegawai.Image"), System.Drawing.Image)
        Me.btnMenuPegawai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuPegawai.Location = New System.Drawing.Point(0, 148)
        Me.btnMenuPegawai.Name = "btnMenuPegawai"
        Me.btnMenuPegawai.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnMenuPegawai.Size = New System.Drawing.Size(218, 44)
        Me.btnMenuPegawai.TabIndex = 12
        Me.btnMenuPegawai.Text = "Data Pegawai"
        Me.btnMenuPegawai.UseVisualStyleBackColor = False
        '
        'btnMenuObat
        '
        Me.btnMenuObat.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnMenuObat.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuObat.FlatAppearance.BorderSize = 0
        Me.btnMenuObat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuObat.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuObat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMenuObat.Image = CType(resources.GetObject("btnMenuObat.Image"), System.Drawing.Image)
        Me.btnMenuObat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuObat.Location = New System.Drawing.Point(0, 104)
        Me.btnMenuObat.Name = "btnMenuObat"
        Me.btnMenuObat.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnMenuObat.Size = New System.Drawing.Size(218, 44)
        Me.btnMenuObat.TabIndex = 10
        Me.btnMenuObat.Text = "Data Obat"
        Me.btnMenuObat.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Panel4.Controls.Add(Me.labelMenuAktif)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(220, 41)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(808, 41)
        Me.Panel4.TabIndex = 4
        '
        'labelMenuAktif
        '
        Me.labelMenuAktif.AutoSize = True
        Me.labelMenuAktif.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMenuAktif.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelMenuAktif.Location = New System.Drawing.Point(298, 3)
        Me.labelMenuAktif.Name = "labelMenuAktif"
        Me.labelMenuAktif.Size = New System.Drawing.Size(261, 37)
        Me.labelMenuAktif.TabIndex = 21
        Me.labelMenuAktif.Text = "SELAMAT DATANG"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel5.Controls.Add(Me.labelCopyright)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(220, 436)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(808, 41)
        Me.Panel5.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'labelCopyright
        '
        Me.labelCopyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelCopyright.AutoSize = True
        Me.labelCopyright.BackColor = System.Drawing.Color.Transparent
        Me.labelCopyright.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCopyright.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelCopyright.Location = New System.Drawing.Point(175, 11)
        Me.labelCopyright.Name = "labelCopyright"
        Me.labelCopyright.Size = New System.Drawing.Size(469, 21)
        Me.labelCopyright.TabIndex = 17
        Me.labelCopyright.Text = "Copyright © 2023 |  Universitas Mulawarman | Informatika 2021"
        Me.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Petugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 477)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Petugas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnMenuPengaturan As Button
    Friend WithEvents btnMenuLaporanPenjualan As Button
    Friend WithEvents btnMenuLaporanPembelian As Button
    Friend WithEvents btnMenuJualObat As Button
    Friend WithEvents btnMenuBeliObat As Button
    Friend WithEvents btnMenuSupplier As Button
    Friend WithEvents btnMenuPegawai As Button
    Friend WithEvents btnMenuPelanggan As Button
    Friend WithEvents btnMenuObat As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents labelApotekSamarinda As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents labelMenuAktif As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labelCopyright As Label
End Class
