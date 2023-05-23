<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pembelian))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.dgvPembelianObat = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeObat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaObat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBatal = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnSimpan = New MetroFramework.Controls.MetroButton()
        Me.tbKodePembelian = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dpTanggalTransaksi = New MetroFramework.Controls.MetroDateTime()
        Me.tbNamaApoteker = New MetroFramework.Controls.MetroTextBox()
        Me.tbKodeApoteker = New MetroFramework.Controls.MetroTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbTotalPembayaran = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbTotal = New MetroFramework.Controls.MetroTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbQuantity = New MetroFramework.Controls.MetroTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbHargaObat = New MetroFramework.Controls.MetroTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbSisaStok = New MetroFramework.Controls.MetroTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbNamaObat = New MetroFramework.Controls.MetroComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbKodeObat = New MetroFramework.Controls.MetroComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbNamaSupplier = New MetroFramework.Controls.MetroComboBox()
        Me.cbKodeSupplier = New MetroFramework.Controls.MetroComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnTambahPesanan = New MetroFramework.Controls.MetroButton()
        CType(Me.dgvPembelianObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'dgvPembelianObat
        '
        Me.dgvPembelianObat.AllowUserToAddRows = False
        Me.dgvPembelianObat.AllowUserToDeleteRows = False
        Me.dgvPembelianObat.AllowUserToResizeColumns = False
        Me.dgvPembelianObat.AllowUserToResizeRows = False
        Me.dgvPembelianObat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPembelianObat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPembelianObat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPembelianObat.ColumnHeadersHeight = 29
        Me.dgvPembelianObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPembelianObat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.KodeObat, Me.NamaObat, Me.HargaSatuan, Me.Quantity, Me.Total, Me.btnBatal})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPembelianObat.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPembelianObat.Location = New System.Drawing.Point(28, 353)
        Me.dgvPembelianObat.MultiSelect = False
        Me.dgvPembelianObat.Name = "dgvPembelianObat"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPembelianObat.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPembelianObat.RowHeadersVisible = False
        Me.dgvPembelianObat.RowHeadersWidth = 51
        Me.dgvPembelianObat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPembelianObat.Size = New System.Drawing.Size(962, 261)
        Me.dgvPembelianObat.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "No"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'KodeObat
        '
        Me.KodeObat.HeaderText = "Kode Obat"
        Me.KodeObat.MinimumWidth = 6
        Me.KodeObat.Name = "KodeObat"
        Me.KodeObat.ReadOnly = True
        '
        'NamaObat
        '
        Me.NamaObat.HeaderText = "Nama Obat"
        Me.NamaObat.MinimumWidth = 6
        Me.NamaObat.Name = "NamaObat"
        Me.NamaObat.ReadOnly = True
        '
        'HargaSatuan
        '
        Me.HargaSatuan.HeaderText = "Harga Satuan"
        Me.HargaSatuan.MinimumWidth = 6
        Me.HargaSatuan.Name = "HargaSatuan"
        Me.HargaSatuan.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.MinimumWidth = 6
        Me.Quantity.Name = "Quantity"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'btnBatal
        '
        Me.btnBatal.HeaderText = "Batal"
        Me.btnBatal.MinimumWidth = 6
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Transparent
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSimpan.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSimpan.Location = New System.Drawing.Point(28, 312)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(100, 35)
        Me.btnSimpan.TabIndex = 1
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseSelectable = True
        '
        'tbKodePembelian
        '
        Me.tbKodePembelian.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbKodePembelian.Lines = New String(-1) {}
        Me.tbKodePembelian.Location = New System.Drawing.Point(199, 28)
        Me.tbKodePembelian.MaxLength = 32767
        Me.tbKodePembelian.Name = "tbKodePembelian"
        Me.tbKodePembelian.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbKodePembelian.PromptText = "Kode Pembelian"
        Me.tbKodePembelian.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbKodePembelian.SelectedText = ""
        Me.tbKodePembelian.Size = New System.Drawing.Size(200, 29)
        Me.tbKodePembelian.TabIndex = 2
        Me.tbKodePembelian.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tanggal Transaksi  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Kode Pembelian    :"
        '
        'dpTanggalTransaksi
        '
        Me.dpTanggalTransaksi.Enabled = False
        Me.dpTanggalTransaksi.Location = New System.Drawing.Point(199, 72)
        Me.dpTanggalTransaksi.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dpTanggalTransaksi.Name = "dpTanggalTransaksi"
        Me.dpTanggalTransaksi.Size = New System.Drawing.Size(200, 29)
        Me.dpTanggalTransaksi.TabIndex = 24
        '
        'tbNamaApoteker
        '
        Me.tbNamaApoteker.Enabled = False
        Me.tbNamaApoteker.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbNamaApoteker.Lines = New String(-1) {}
        Me.tbNamaApoteker.Location = New System.Drawing.Point(199, 249)
        Me.tbNamaApoteker.MaxLength = 32767
        Me.tbNamaApoteker.Name = "tbNamaApoteker"
        Me.tbNamaApoteker.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNamaApoteker.PromptText = "Nama Apoteker"
        Me.tbNamaApoteker.ReadOnly = True
        Me.tbNamaApoteker.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbNamaApoteker.SelectedText = ""
        Me.tbNamaApoteker.Size = New System.Drawing.Size(200, 29)
        Me.tbNamaApoteker.TabIndex = 28
        Me.tbNamaApoteker.UseSelectable = True
        '
        'tbKodeApoteker
        '
        Me.tbKodeApoteker.Enabled = False
        Me.tbKodeApoteker.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbKodeApoteker.Lines = New String(-1) {}
        Me.tbKodeApoteker.Location = New System.Drawing.Point(199, 204)
        Me.tbKodeApoteker.MaxLength = 32767
        Me.tbKodeApoteker.Name = "tbKodeApoteker"
        Me.tbKodeApoteker.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbKodeApoteker.PromptText = "Kode Apoteker"
        Me.tbKodeApoteker.ReadOnly = True
        Me.tbKodeApoteker.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbKodeApoteker.SelectedText = ""
        Me.tbKodeApoteker.Size = New System.Drawing.Size(200, 29)
        Me.tbKodeApoteker.TabIndex = 27
        Me.tbKodeApoteker.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Kode Apoteker      :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 23)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Nama Apoteker     :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.tbTotalPembayaran)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.btnTambahPesanan)
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.dgvPembelianObat)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1040, 640)
        Me.Panel1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(191, 319)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(157, 23)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Total Pembayaran :"
        '
        'tbTotalPembayaran
        '
        Me.tbTotalPembayaran.Enabled = False
        Me.tbTotalPembayaran.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbTotalPembayaran.Lines = New String(-1) {}
        Me.tbTotalPembayaran.Location = New System.Drawing.Point(354, 318)
        Me.tbTotalPembayaran.MaxLength = 32767
        Me.tbTotalPembayaran.Name = "tbTotalPembayaran"
        Me.tbTotalPembayaran.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotalPembayaran.PromptText = "Total Pembayaran"
        Me.tbTotalPembayaran.ReadOnly = True
        Me.tbTotalPembayaran.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbTotalPembayaran.SelectedText = ""
        Me.tbTotalPembayaran.Size = New System.Drawing.Size(144, 29)
        Me.tbTotalPembayaran.TabIndex = 37
        Me.tbTotalPembayaran.UseSelectable = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbTotal)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.tbQuantity)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.tbHargaObat)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.tbSisaStok)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.cbNamaObat)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cbKodeObat)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(520, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(470, 290)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FORMULIR OBAT"
        '
        'tbTotal
        '
        Me.tbTotal.Enabled = False
        Me.tbTotal.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbTotal.Lines = New String(-1) {}
        Me.tbTotal.Location = New System.Drawing.Point(193, 249)
        Me.tbTotal.MaxLength = 32767
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotal.PromptText = "Total"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbTotal.SelectedText = ""
        Me.tbTotal.Size = New System.Drawing.Size(200, 29)
        Me.tbTotal.TabIndex = 36
        Me.tbTotal.UseSelectable = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(40, 248)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 23)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Total                  :"
        '
        'tbQuantity
        '
        Me.tbQuantity.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbQuantity.Lines = New String(-1) {}
        Me.tbQuantity.Location = New System.Drawing.Point(193, 204)
        Me.tbQuantity.MaxLength = 32767
        Me.tbQuantity.Name = "tbQuantity"
        Me.tbQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbQuantity.PromptText = "Quantity"
        Me.tbQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbQuantity.SelectedText = ""
        Me.tbQuantity.Size = New System.Drawing.Size(200, 29)
        Me.tbQuantity.TabIndex = 34
        Me.tbQuantity.UseSelectable = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(40, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 23)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Quantity            :"
        '
        'tbHargaObat
        '
        Me.tbHargaObat.Enabled = False
        Me.tbHargaObat.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbHargaObat.Lines = New String(-1) {}
        Me.tbHargaObat.Location = New System.Drawing.Point(193, 117)
        Me.tbHargaObat.MaxLength = 32767
        Me.tbHargaObat.Name = "tbHargaObat"
        Me.tbHargaObat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbHargaObat.PromptText = "Harga Obat"
        Me.tbHargaObat.ReadOnly = True
        Me.tbHargaObat.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbHargaObat.SelectedText = ""
        Me.tbHargaObat.Size = New System.Drawing.Size(200, 29)
        Me.tbHargaObat.TabIndex = 32
        Me.tbHargaObat.UseSelectable = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(40, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 23)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Harga Satuan     :"
        '
        'tbSisaStok
        '
        Me.tbSisaStok.Enabled = False
        Me.tbSisaStok.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbSisaStok.Lines = New String(-1) {}
        Me.tbSisaStok.Location = New System.Drawing.Point(193, 161)
        Me.tbSisaStok.MaxLength = 32767
        Me.tbSisaStok.Name = "tbSisaStok"
        Me.tbSisaStok.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSisaStok.PromptText = "Sisa Stok"
        Me.tbSisaStok.ReadOnly = True
        Me.tbSisaStok.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbSisaStok.SelectedText = ""
        Me.tbSisaStok.Size = New System.Drawing.Size(200, 29)
        Me.tbSisaStok.TabIndex = 30
        Me.tbSisaStok.UseSelectable = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(40, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 23)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Sisa Stok            :"
        '
        'cbNamaObat
        '
        Me.cbNamaObat.FormattingEnabled = True
        Me.cbNamaObat.ItemHeight = 23
        Me.cbNamaObat.Location = New System.Drawing.Point(193, 72)
        Me.cbNamaObat.Name = "cbNamaObat"
        Me.cbNamaObat.PromptText = "Nama Obat"
        Me.cbNamaObat.Size = New System.Drawing.Size(200, 29)
        Me.cbNamaObat.TabIndex = 23
        Me.cbNamaObat.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Kode Obat         :"
        '
        'cbKodeObat
        '
        Me.cbKodeObat.FormattingEnabled = True
        Me.cbKodeObat.ItemHeight = 23
        Me.cbKodeObat.Location = New System.Drawing.Point(193, 28)
        Me.cbKodeObat.Name = "cbKodeObat"
        Me.cbKodeObat.PromptText = "Kode Obat"
        Me.cbKodeObat.Size = New System.Drawing.Size(200, 29)
        Me.cbKodeObat.TabIndex = 7
        Me.cbKodeObat.UseSelectable = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(40, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 23)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Nama Obat        :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbNamaApoteker)
        Me.GroupBox2.Controls.Add(Me.cbNamaSupplier)
        Me.GroupBox2.Controls.Add(Me.tbKodeApoteker)
        Me.GroupBox2.Controls.Add(Me.cbKodeSupplier)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dpTanggalTransaksi)
        Me.GroupBox2.Controls.Add(Me.tbKodePembelian)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(28, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 290)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FORMULIR PEMBELIAN"
        '
        'cbNamaSupplier
        '
        Me.cbNamaSupplier.FormattingEnabled = True
        Me.cbNamaSupplier.ItemHeight = 23
        Me.cbNamaSupplier.Location = New System.Drawing.Point(199, 161)
        Me.cbNamaSupplier.Name = "cbNamaSupplier"
        Me.cbNamaSupplier.PromptText = "Nama Supplier"
        Me.cbNamaSupplier.Size = New System.Drawing.Size(200, 29)
        Me.cbNamaSupplier.TabIndex = 38
        Me.cbNamaSupplier.UseSelectable = True
        '
        'cbKodeSupplier
        '
        Me.cbKodeSupplier.FormattingEnabled = True
        Me.cbKodeSupplier.ItemHeight = 23
        Me.cbKodeSupplier.Location = New System.Drawing.Point(199, 117)
        Me.cbKodeSupplier.Name = "cbKodeSupplier"
        Me.cbKodeSupplier.PromptText = "Kode Supplier"
        Me.cbKodeSupplier.Size = New System.Drawing.Size(200, 29)
        Me.cbKodeSupplier.TabIndex = 38
        Me.cbKodeSupplier.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Kode Supplier       :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 23)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Nama Supplier      :"
        '
        'btnTambahPesanan
        '
        Me.btnTambahPesanan.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnTambahPesanan.Location = New System.Drawing.Point(520, 312)
        Me.btnTambahPesanan.Name = "btnTambahPesanan"
        Me.btnTambahPesanan.Size = New System.Drawing.Size(100, 35)
        Me.btnTambahPesanan.TabIndex = 11
        Me.btnTambahPesanan.Text = "Tambah"
        Me.btnTambahPesanan.UseSelectable = True
        '
        'Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pembelian"
        CType(Me.dgvPembelianObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents dgvPembelianObat As DataGridView
    Friend WithEvents btnSimpan As MetroFramework.Controls.MetroButton
    Friend WithEvents tbKodePembelian As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dpTanggalTransaksi As MetroFramework.Controls.MetroDateTime
    Friend WithEvents tbNamaApoteker As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbKodeApoteker As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbNamaObat As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbKodeObat As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tbQuantity As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbHargaObat As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbSisaStok As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbTotalPembayaran As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnTambahPesanan As MetroFramework.Controls.MetroButton
    Friend WithEvents cbKodeSupplier As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbNamaSupplier As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents KodeObat As DataGridViewTextBoxColumn
    Friend WithEvents NamaObat As DataGridViewTextBoxColumn
    Friend WithEvents HargaSatuan As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents btnBatal As DataGridViewButtonColumn
End Class
