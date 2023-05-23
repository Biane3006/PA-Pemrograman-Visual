<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Supplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Supplier))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbKodeSupplier = New MetroFramework.Controls.MetroTextBox()
        Me.tbNomorTelepon = New MetroFramework.Controls.MetroTextBox()
        Me.tbNamaSupplier = New MetroFramework.Controls.MetroTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbAlamat = New MetroFramework.Controls.MetroTextBox()
        Me.tbNamaPerusahaan = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCariDataSupplier = New MetroFramework.Controls.MetroTextBox()
        Me.btnBatal = New MetroFramework.Controls.MetroButton()
        Me.btnHapus = New MetroFramework.Controls.MetroButton()
        Me.btnUbah = New MetroFramework.Controls.MetroButton()
        Me.btnSimpan = New MetroFramework.Controls.MetroButton()
        Me.dgvDataSupplier = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDataSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.tbCariDataSupplier)
        Me.Panel1.Controls.Add(Me.btnBatal)
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Controls.Add(Me.btnUbah)
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.dgvDataSupplier)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1040, 640)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.tbKodeSupplier)
        Me.GroupBox1.Controls.Add(Me.tbNomorTelepon)
        Me.GroupBox1.Controls.Add(Me.tbNamaSupplier)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbAlamat)
        Me.GroupBox1.Controls.Add(Me.tbNamaPerusahaan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(47, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 191)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORMULIR SUPPLIER"
        '
        'tbKodeSupplier
        '
        Me.tbKodeSupplier.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbKodeSupplier.Lines = New String(-1) {}
        Me.tbKodeSupplier.Location = New System.Drawing.Point(193, 46)
        Me.tbKodeSupplier.MaxLength = 7
        Me.tbKodeSupplier.Name = "tbKodeSupplier"
        Me.tbKodeSupplier.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbKodeSupplier.PromptText = "Kode Supplier"
        Me.tbKodeSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbKodeSupplier.SelectedText = ""
        Me.tbKodeSupplier.Size = New System.Drawing.Size(200, 29)
        Me.tbKodeSupplier.TabIndex = 2
        Me.tbKodeSupplier.UseSelectable = True
        '
        'tbNomorTelepon
        '
        Me.tbNomorTelepon.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbNomorTelepon.Lines = New String(-1) {}
        Me.tbNomorTelepon.Location = New System.Drawing.Point(589, 46)
        Me.tbNomorTelepon.MaxLength = 13
        Me.tbNomorTelepon.Name = "tbNomorTelepon"
        Me.tbNomorTelepon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNomorTelepon.PromptText = "Nomor Telepon"
        Me.tbNomorTelepon.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbNomorTelepon.SelectedText = ""
        Me.tbNomorTelepon.Size = New System.Drawing.Size(200, 29)
        Me.tbNomorTelepon.TabIndex = 23
        Me.tbNomorTelepon.UseSelectable = True
        Me.tbNomorTelepon.WordWrap = False
        '
        'tbNamaSupplier
        '
        Me.tbNamaSupplier.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbNamaSupplier.Lines = New String(-1) {}
        Me.tbNamaSupplier.Location = New System.Drawing.Point(193, 81)
        Me.tbNamaSupplier.MaxLength = 200
        Me.tbNamaSupplier.Name = "tbNamaSupplier"
        Me.tbNamaSupplier.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNamaSupplier.PromptText = "Nama Supplier"
        Me.tbNamaSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbNamaSupplier.SelectedText = ""
        Me.tbNamaSupplier.Size = New System.Drawing.Size(200, 29)
        Me.tbNamaSupplier.TabIndex = 3
        Me.tbNamaSupplier.UseSelectable = True
        Me.tbNamaSupplier.WordWrap = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(439, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 23)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Nomor Telepon  :"
        '
        'tbAlamat
        '
        Me.tbAlamat.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbAlamat.Lines = New String(-1) {}
        Me.tbAlamat.Location = New System.Drawing.Point(589, 81)
        Me.tbAlamat.MaxLength = 1000
        Me.tbAlamat.Multiline = True
        Me.tbAlamat.Name = "tbAlamat"
        Me.tbAlamat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAlamat.PromptText = "Alamat"
        Me.tbAlamat.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbAlamat.SelectedText = ""
        Me.tbAlamat.Size = New System.Drawing.Size(200, 64)
        Me.tbAlamat.TabIndex = 4
        Me.tbAlamat.UseSelectable = True
        '
        'tbNamaPerusahaan
        '
        Me.tbNamaPerusahaan.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbNamaPerusahaan.Lines = New String(-1) {}
        Me.tbNamaPerusahaan.Location = New System.Drawing.Point(193, 116)
        Me.tbNamaPerusahaan.MaxLength = 200
        Me.tbNamaPerusahaan.Name = "tbNamaPerusahaan"
        Me.tbNamaPerusahaan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNamaPerusahaan.PromptText = "Nama Perusahaan"
        Me.tbNamaPerusahaan.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbNamaPerusahaan.SelectedText = ""
        Me.tbNamaPerusahaan.Size = New System.Drawing.Size(200, 29)
        Me.tbNamaPerusahaan.TabIndex = 21
        Me.tbNamaPerusahaan.UseSelectable = True
        Me.tbNamaPerusahaan.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nama Supplier       :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Kode Supplier        :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(439, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Alamat               :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nama Perusahaan  :"
        '
        'tbCariDataSupplier
        '
        Me.tbCariDataSupplier.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbCariDataSupplier.Icon = CType(resources.GetObject("tbCariDataSupplier.Icon"), System.Drawing.Image)
        Me.tbCariDataSupplier.IconRight = True
        Me.tbCariDataSupplier.Lines = New String(-1) {}
        Me.tbCariDataSupplier.Location = New System.Drawing.Point(583, 229)
        Me.tbCariDataSupplier.MaxLength = 32767
        Me.tbCariDataSupplier.Name = "tbCariDataSupplier"
        Me.tbCariDataSupplier.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCariDataSupplier.PromptText = "Cari..."
        Me.tbCariDataSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbCariDataSupplier.SelectedText = ""
        Me.tbCariDataSupplier.Size = New System.Drawing.Size(200, 29)
        Me.tbCariDataSupplier.TabIndex = 19
        Me.tbCariDataSupplier.UseSelectable = True
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
        'dgvDataSupplier
        '
        Me.dgvDataSupplier.AllowUserToAddRows = False
        Me.dgvDataSupplier.AllowUserToDeleteRows = False
        Me.dgvDataSupplier.AllowUserToResizeColumns = False
        Me.dgvDataSupplier.AllowUserToResizeRows = False
        Me.dgvDataSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDataSupplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDataSupplier.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDataSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDataSupplier.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDataSupplier.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDataSupplier.Location = New System.Drawing.Point(47, 275)
        Me.dgvDataSupplier.MultiSelect = False
        Me.dgvDataSupplier.Name = "dgvDataSupplier"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataSupplier.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDataSupplier.RowHeadersVisible = False
        Me.dgvDataSupplier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDataSupplier.Size = New System.Drawing.Size(943, 306)
        Me.dgvDataSupplier.TabIndex = 0
        '
        'Data_Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Data_Supplier"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDataSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvDataSupplier As DataGridView
    Friend WithEvents tbKodeSupplier As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSimpan As MetroFramework.Controls.MetroButton
    Friend WithEvents tbAlamat As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbNamaSupplier As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnBatal As MetroFramework.Controls.MetroButton
    Friend WithEvents btnHapus As MetroFramework.Controls.MetroButton
    Friend WithEvents btnUbah As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCariDataSupplier As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbNamaPerusahaan As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbNomorTelepon As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
