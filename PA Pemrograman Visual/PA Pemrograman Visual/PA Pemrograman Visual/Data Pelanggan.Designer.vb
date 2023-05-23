<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Pelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Pelanggan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbAlamat = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbKodePelanggan = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNamaPelanggan = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbJenkel = New MetroFramework.Controls.MetroComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCariDataPelanggan = New MetroFramework.Controls.MetroTextBox()
        Me.btnBatal = New MetroFramework.Controls.MetroButton()
        Me.btnHapus = New MetroFramework.Controls.MetroButton()
        Me.btnUbah = New MetroFramework.Controls.MetroButton()
        Me.btnSimpan = New MetroFramework.Controls.MetroButton()
        Me.dgvDataPelanggan = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDataPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.tbCariDataPelanggan)
        Me.Panel1.Controls.Add(Me.btnBatal)
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Controls.Add(Me.btnUbah)
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.dgvDataPelanggan)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1040, 640)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbAlamat)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbKodePelanggan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbNamaPelanggan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbJenkel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(47, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 191)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORMULIR PELANGGAN"
        '
        'tbAlamat
        '
        Me.tbAlamat.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbAlamat.Lines = New String(-1) {}
        Me.tbAlamat.Location = New System.Drawing.Point(557, 48)
        Me.tbAlamat.MaxLength = 1000
        Me.tbAlamat.Multiline = True
        Me.tbAlamat.Name = "tbAlamat"
        Me.tbAlamat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAlamat.PromptText = "Alamat"
        Me.tbAlamat.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbAlamat.SelectedText = ""
        Me.tbAlamat.Size = New System.Drawing.Size(265, 99)
        Me.tbAlamat.TabIndex = 4
        Me.tbAlamat.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(433, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Alamat          :"
        '
        'tbKodePelanggan
        '
        Me.tbKodePelanggan.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbKodePelanggan.Lines = New String(-1) {}
        Me.tbKodePelanggan.Location = New System.Drawing.Point(187, 48)
        Me.tbKodePelanggan.MaxLength = 7
        Me.tbKodePelanggan.Name = "tbKodePelanggan"
        Me.tbKodePelanggan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbKodePelanggan.PromptText = "Kode Pelanggan"
        Me.tbKodePelanggan.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbKodePelanggan.SelectedText = ""
        Me.tbKodePelanggan.Size = New System.Drawing.Size(200, 29)
        Me.tbKodePelanggan.TabIndex = 2
        Me.tbKodePelanggan.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Jenis Kelamin       :"
        '
        'tbNamaPelanggan
        '
        Me.tbNamaPelanggan.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbNamaPelanggan.Lines = New String(-1) {}
        Me.tbNamaPelanggan.Location = New System.Drawing.Point(187, 83)
        Me.tbNamaPelanggan.MaxLength = 200
        Me.tbNamaPelanggan.Name = "tbNamaPelanggan"
        Me.tbNamaPelanggan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNamaPelanggan.PromptText = "Nama Pelanggan"
        Me.tbNamaPelanggan.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbNamaPelanggan.SelectedText = ""
        Me.tbNamaPelanggan.Size = New System.Drawing.Size(200, 29)
        Me.tbNamaPelanggan.TabIndex = 3
        Me.tbNamaPelanggan.UseSelectable = True
        Me.tbNamaPelanggan.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Kode Pelanggan  :"
        '
        'cbJenkel
        '
        Me.cbJenkel.FormattingEnabled = True
        Me.cbJenkel.ItemHeight = 23
        Me.cbJenkel.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cbJenkel.Location = New System.Drawing.Point(187, 118)
        Me.cbJenkel.Name = "cbJenkel"
        Me.cbJenkel.PromptText = "Jenis Kelamin"
        Me.cbJenkel.Size = New System.Drawing.Size(200, 29)
        Me.cbJenkel.TabIndex = 8
        Me.cbJenkel.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nama Pelanggan :"
        '
        'tbCariDataPelanggan
        '
        Me.tbCariDataPelanggan.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbCariDataPelanggan.Icon = CType(resources.GetObject("tbCariDataPelanggan.Icon"), System.Drawing.Image)
        Me.tbCariDataPelanggan.IconRight = True
        Me.tbCariDataPelanggan.Lines = New String(-1) {}
        Me.tbCariDataPelanggan.Location = New System.Drawing.Point(583, 229)
        Me.tbCariDataPelanggan.MaxLength = 32767
        Me.tbCariDataPelanggan.Name = "tbCariDataPelanggan"
        Me.tbCariDataPelanggan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCariDataPelanggan.PromptText = "Cari..."
        Me.tbCariDataPelanggan.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbCariDataPelanggan.SelectedText = ""
        Me.tbCariDataPelanggan.Size = New System.Drawing.Size(200, 29)
        Me.tbCariDataPelanggan.TabIndex = 19
        Me.tbCariDataPelanggan.UseSelectable = True
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
        'dgvDataPelanggan
        '
        Me.dgvDataPelanggan.AllowUserToAddRows = False
        Me.dgvDataPelanggan.AllowUserToDeleteRows = False
        Me.dgvDataPelanggan.AllowUserToResizeColumns = False
        Me.dgvDataPelanggan.AllowUserToResizeRows = False
        Me.dgvDataPelanggan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDataPelanggan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDataPelanggan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDataPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDataPelanggan.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDataPelanggan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDataPelanggan.Location = New System.Drawing.Point(47, 275)
        Me.dgvDataPelanggan.MultiSelect = False
        Me.dgvDataPelanggan.Name = "dgvDataPelanggan"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataPelanggan.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDataPelanggan.RowHeadersVisible = False
        Me.dgvDataPelanggan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDataPelanggan.Size = New System.Drawing.Size(943, 306)
        Me.dgvDataPelanggan.TabIndex = 0
        '
        'Data_Pelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Data_Pelanggan"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDataPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvDataPelanggan As DataGridView
    Friend WithEvents tbKodePelanggan As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSimpan As MetroFramework.Controls.MetroButton
    Friend WithEvents tbAlamat As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbNamaPelanggan As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbJenkel As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnBatal As MetroFramework.Controls.MetroButton
    Friend WithEvents btnHapus As MetroFramework.Controls.MetroButton
    Friend WithEvents btnUbah As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCariDataPelanggan As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
