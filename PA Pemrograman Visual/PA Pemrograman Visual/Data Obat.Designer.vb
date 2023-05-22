<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Obat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Obat))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbStok = New MetroFramework.Controls.MetroTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbKodeObat = New MetroFramework.Controls.MetroTextBox()
        Me.tbHargaJual = New MetroFramework.Controls.MetroTextBox()
        Me.tbNamaObat = New MetroFramework.Controls.MetroTextBox()
        Me.tbHargaBeli = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbJenisObat = New MetroFramework.Controls.MetroComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbGolongan = New MetroFramework.Controls.MetroComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCariDataObat = New MetroFramework.Controls.MetroTextBox()
        Me.btnBatal = New MetroFramework.Controls.MetroButton()
        Me.btnHapus = New MetroFramework.Controls.MetroButton()
        Me.btnUbah = New MetroFramework.Controls.MetroButton()
        Me.btnSimpan = New MetroFramework.Controls.MetroButton()
        Me.dgvDataObat = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDataObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.tbCariDataObat)
        Me.Panel1.Controls.Add(Me.btnBatal)
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Controls.Add(Me.btnUbah)
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.dgvDataObat)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1040, 640)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbStok)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbKodeObat)
        Me.GroupBox1.Controls.Add(Me.tbHargaJual)
        Me.GroupBox1.Controls.Add(Me.tbNamaObat)
        Me.GroupBox1.Controls.Add(Me.tbHargaBeli)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbJenisObat)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbGolongan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(47, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 191)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORMULIR OBAT"
        '
        'tbStok
        '
        Me.tbStok.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbStok.Lines = New String(-1) {}
        Me.tbStok.Location = New System.Drawing.Point(559, 106)
        Me.tbStok.MaxLength = 7
        Me.tbStok.Name = "tbStok"
        Me.tbStok.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbStok.PromptText = "Stok"
        Me.tbStok.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbStok.SelectedText = ""
        Me.tbStok.Size = New System.Drawing.Size(200, 29)
        Me.tbStok.TabIndex = 6
        Me.tbStok.UseSelectable = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(433, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 23)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Harga Jual   :"
        '
        'tbKodeObat
        '
        Me.tbKodeObat.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbKodeObat.Lines = New String(-1) {}
        Me.tbKodeObat.Location = New System.Drawing.Point(144, 36)
        Me.tbKodeObat.MaxLength = 7
        Me.tbKodeObat.Name = "tbKodeObat"
        Me.tbKodeObat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbKodeObat.PromptText = "Kode Obat"
        Me.tbKodeObat.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbKodeObat.SelectedText = ""
        Me.tbKodeObat.Size = New System.Drawing.Size(200, 29)
        Me.tbKodeObat.TabIndex = 2
        Me.tbKodeObat.UseSelectable = True
        '
        'tbHargaJual
        '
        Me.tbHargaJual.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbHargaJual.Lines = New String(-1) {}
        Me.tbHargaJual.Location = New System.Drawing.Point(559, 36)
        Me.tbHargaJual.MaxLength = 15
        Me.tbHargaJual.Name = "tbHargaJual"
        Me.tbHargaJual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbHargaJual.PromptText = "Harga Jual"
        Me.tbHargaJual.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbHargaJual.SelectedText = ""
        Me.tbHargaJual.Size = New System.Drawing.Size(200, 29)
        Me.tbHargaJual.TabIndex = 21
        Me.tbHargaJual.UseSelectable = True
        '
        'tbNamaObat
        '
        Me.tbNamaObat.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbNamaObat.Lines = New String(-1) {}
        Me.tbNamaObat.Location = New System.Drawing.Point(144, 71)
        Me.tbNamaObat.MaxLength = 200
        Me.tbNamaObat.Name = "tbNamaObat"
        Me.tbNamaObat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNamaObat.PromptText = "Nama Obat"
        Me.tbNamaObat.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbNamaObat.SelectedText = ""
        Me.tbNamaObat.Size = New System.Drawing.Size(200, 29)
        Me.tbNamaObat.TabIndex = 3
        Me.tbNamaObat.UseSelectable = True
        Me.tbNamaObat.WordWrap = False
        '
        'tbHargaBeli
        '
        Me.tbHargaBeli.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbHargaBeli.Lines = New String(-1) {}
        Me.tbHargaBeli.Location = New System.Drawing.Point(559, 71)
        Me.tbHargaBeli.MaxLength = 15
        Me.tbHargaBeli.Name = "tbHargaBeli"
        Me.tbHargaBeli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbHargaBeli.PromptText = "Harga Beli"
        Me.tbHargaBeli.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbHargaBeli.SelectedText = ""
        Me.tbHargaBeli.Size = New System.Drawing.Size(200, 29)
        Me.tbHargaBeli.TabIndex = 4
        Me.tbHargaBeli.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(433, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 23)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Stok            :"
        '
        'cbJenisObat
        '
        Me.cbJenisObat.FormattingEnabled = True
        Me.cbJenisObat.ItemHeight = 23
        Me.cbJenisObat.Items.AddRange(New Object() {"Tablet", "Kapsul", "Kaplet", "Pil", "Serbuk", "Sirup", "Injeksi", "Inhaler", "Tetes", "Salep"})
        Me.cbJenisObat.Location = New System.Drawing.Point(144, 106)
        Me.cbJenisObat.Name = "cbJenisObat"
        Me.cbJenisObat.PromptText = "Jenis Obat"
        Me.cbJenisObat.Size = New System.Drawing.Size(200, 29)
        Me.cbJenisObat.TabIndex = 7
        Me.cbJenisObat.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(433, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Harga Beli   :"
        '
        'cbGolongan
        '
        Me.cbGolongan.FormattingEnabled = True
        Me.cbGolongan.ItemHeight = 23
        Me.cbGolongan.Items.AddRange(New Object() {"Bebas", "Terbatas", "Keras"})
        Me.cbGolongan.Location = New System.Drawing.Point(144, 141)
        Me.cbGolongan.Name = "cbGolongan"
        Me.cbGolongan.PromptText = "Golongan Obat"
        Me.cbGolongan.Size = New System.Drawing.Size(200, 29)
        Me.cbGolongan.TabIndex = 8
        Me.cbGolongan.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Golongan    :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nama Obat :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Jenis Obat   :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Kode Obat  :"
        '
        'tbCariDataObat
        '
        Me.tbCariDataObat.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbCariDataObat.Icon = CType(resources.GetObject("tbCariDataObat.Icon"), System.Drawing.Image)
        Me.tbCariDataObat.IconRight = True
        Me.tbCariDataObat.Lines = New String(-1) {}
        Me.tbCariDataObat.Location = New System.Drawing.Point(583, 229)
        Me.tbCariDataObat.MaxLength = 32767
        Me.tbCariDataObat.Name = "tbCariDataObat"
        Me.tbCariDataObat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCariDataObat.PromptText = "Cari..."
        Me.tbCariDataObat.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbCariDataObat.SelectedText = ""
        Me.tbCariDataObat.Size = New System.Drawing.Size(200, 29)
        Me.tbCariDataObat.TabIndex = 19
        Me.tbCariDataObat.UseSelectable = True
        '
        'btnBatal
        '
        Me.btnBatal.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnBatal.Location = New System.Drawing.Point(412, 223)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(100, 35)
        Me.btnBatal.TabIndex = 11
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseSelectable = True
        '
        'btnHapus
        '
        Me.btnHapus.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnHapus.Location = New System.Drawing.Point(291, 223)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(100, 35)
        Me.btnHapus.TabIndex = 10
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseSelectable = True
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUbah.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnUbah.Location = New System.Drawing.Point(169, 223)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(100, 35)
        Me.btnUbah.TabIndex = 9
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseSelectable = True
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Transparent
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSimpan.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSimpan.Location = New System.Drawing.Point(47, 223)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(100, 35)
        Me.btnSimpan.TabIndex = 1
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseSelectable = True
        '
        'dgvDataObat
        '
        Me.dgvDataObat.AllowUserToAddRows = False
        Me.dgvDataObat.AllowUserToDeleteRows = False
        Me.dgvDataObat.AllowUserToResizeColumns = False
        Me.dgvDataObat.AllowUserToResizeRows = False
        Me.dgvDataObat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDataObat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDataObat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDataObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDataObat.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDataObat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDataObat.Location = New System.Drawing.Point(47, 275)
        Me.dgvDataObat.MultiSelect = False
        Me.dgvDataObat.Name = "dgvDataObat"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataObat.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDataObat.RowHeadersVisible = False
        Me.dgvDataObat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDataObat.Size = New System.Drawing.Size(943, 306)
        Me.dgvDataObat.TabIndex = 0
        '
        'Data_Obat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Data_Obat"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDataObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvDataObat As DataGridView
    Friend WithEvents tbKodeObat As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSimpan As MetroFramework.Controls.MetroButton
    Friend WithEvents tbStok As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbHargaBeli As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbNamaObat As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbGolongan As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbJenisObat As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnBatal As MetroFramework.Controls.MetroButton
    Friend WithEvents btnHapus As MetroFramework.Controls.MetroButton
    Friend WithEvents btnUbah As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCariDataObat As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbHargaJual As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
