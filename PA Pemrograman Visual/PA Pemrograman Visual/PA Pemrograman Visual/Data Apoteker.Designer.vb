<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Apoteker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Apoteker))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbAlamatApoteker = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbKodeApoteker = New MetroFramework.Controls.MetroTextBox()
        Me.tbUsiaApoteker = New MetroFramework.Controls.MetroTextBox()
        Me.tbNamaApoteker = New MetroFramework.Controls.MetroTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbJenkelApoteker = New MetroFramework.Controls.MetroComboBox()
        Me.tbNomorTelepon = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCariDataApoteker = New MetroFramework.Controls.MetroTextBox()
        Me.btnBatal = New MetroFramework.Controls.MetroButton()
        Me.btnHapus = New MetroFramework.Controls.MetroButton()
        Me.btnUbah = New MetroFramework.Controls.MetroButton()
        Me.btnSimpan = New MetroFramework.Controls.MetroButton()
        Me.dgvDataApoteker = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDataApoteker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.tbCariDataApoteker)
        Me.Panel1.Controls.Add(Me.btnBatal)
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Controls.Add(Me.btnUbah)
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.dgvDataApoteker)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1040, 640)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbAlamatApoteker)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbKodeApoteker)
        Me.GroupBox1.Controls.Add(Me.tbUsiaApoteker)
        Me.GroupBox1.Controls.Add(Me.tbNamaApoteker)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbJenkelApoteker)
        Me.GroupBox1.Controls.Add(Me.tbNomorTelepon)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(47, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 191)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORMULIR APOTEKER"
        '
        'tbAlamatApoteker
        '
        Me.tbAlamatApoteker.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbAlamatApoteker.Lines = New String(-1) {}
        Me.tbAlamatApoteker.Location = New System.Drawing.Point(604, 118)
        Me.tbAlamatApoteker.MaxLength = 1000
        Me.tbAlamatApoteker.Multiline = True
        Me.tbAlamatApoteker.Name = "tbAlamatApoteker"
        Me.tbAlamatApoteker.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAlamatApoteker.PromptText = "Alamat"
        Me.tbAlamatApoteker.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbAlamatApoteker.SelectedText = ""
        Me.tbAlamatApoteker.Size = New System.Drawing.Size(286, 53)
        Me.tbAlamatApoteker.TabIndex = 4
        Me.tbAlamatApoteker.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(433, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 23)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Usia                      :"
        '
        'tbKodeApoteker
        '
        Me.tbKodeApoteker.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbKodeApoteker.Lines = New String(-1) {}
        Me.tbKodeApoteker.Location = New System.Drawing.Point(187, 48)
        Me.tbKodeApoteker.MaxLength = 7
        Me.tbKodeApoteker.Name = "tbKodeApoteker"
        Me.tbKodeApoteker.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbKodeApoteker.PromptText = "Kode Apoteker"
        Me.tbKodeApoteker.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbKodeApoteker.SelectedText = ""
        Me.tbKodeApoteker.Size = New System.Drawing.Size(200, 29)
        Me.tbKodeApoteker.TabIndex = 2
        Me.tbKodeApoteker.UseSelectable = True
        '
        'tbUsiaApoteker
        '
        Me.tbUsiaApoteker.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbUsiaApoteker.Lines = New String(-1) {}
        Me.tbUsiaApoteker.Location = New System.Drawing.Point(604, 48)
        Me.tbUsiaApoteker.MaxLength = 2
        Me.tbUsiaApoteker.Name = "tbUsiaApoteker"
        Me.tbUsiaApoteker.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUsiaApoteker.PromptText = "Usia"
        Me.tbUsiaApoteker.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbUsiaApoteker.SelectedText = ""
        Me.tbUsiaApoteker.Size = New System.Drawing.Size(200, 29)
        Me.tbUsiaApoteker.TabIndex = 23
        Me.tbUsiaApoteker.UseSelectable = True
        '
        'tbNamaApoteker
        '
        Me.tbNamaApoteker.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbNamaApoteker.Lines = New String(-1) {}
        Me.tbNamaApoteker.Location = New System.Drawing.Point(187, 83)
        Me.tbNamaApoteker.MaxLength = 300
        Me.tbNamaApoteker.Name = "tbNamaApoteker"
        Me.tbNamaApoteker.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNamaApoteker.PromptText = "Nama Apoteker"
        Me.tbNamaApoteker.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbNamaApoteker.SelectedText = ""
        Me.tbNamaApoteker.Size = New System.Drawing.Size(200, 29)
        Me.tbNamaApoteker.TabIndex = 3
        Me.tbNamaApoteker.UseSelectable = True
        Me.tbNamaApoteker.WordWrap = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(433, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 23)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Nomor Telepon    :"
        '
        'cbJenkelApoteker
        '
        Me.cbJenkelApoteker.FormattingEnabled = True
        Me.cbJenkelApoteker.ItemHeight = 23
        Me.cbJenkelApoteker.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cbJenkelApoteker.Location = New System.Drawing.Point(187, 118)
        Me.cbJenkelApoteker.Name = "cbJenkelApoteker"
        Me.cbJenkelApoteker.PromptText = "Jenis Kelamin"
        Me.cbJenkelApoteker.Size = New System.Drawing.Size(200, 29)
        Me.cbJenkelApoteker.TabIndex = 8
        Me.cbJenkelApoteker.UseSelectable = True
        '
        'tbNomorTelepon
        '
        Me.tbNomorTelepon.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbNomorTelepon.Lines = New String(-1) {}
        Me.tbNomorTelepon.Location = New System.Drawing.Point(604, 83)
        Me.tbNomorTelepon.MaxLength = 13
        Me.tbNomorTelepon.Name = "tbNomorTelepon"
        Me.tbNomorTelepon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNomorTelepon.PromptText = "Nomor Telepon"
        Me.tbNomorTelepon.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbNomorTelepon.SelectedText = ""
        Me.tbNomorTelepon.Size = New System.Drawing.Size(200, 29)
        Me.tbNomorTelepon.TabIndex = 21
        Me.tbNomorTelepon.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nama Apoteker   :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Kode Apoteker     :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(433, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Alamat                 :"
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
        'tbCariDataApoteker
        '
        Me.tbCariDataApoteker.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbCariDataApoteker.Icon = CType(resources.GetObject("tbCariDataApoteker.Icon"), System.Drawing.Image)
        Me.tbCariDataApoteker.IconRight = True
        Me.tbCariDataApoteker.Lines = New String(-1) {}
        Me.tbCariDataApoteker.Location = New System.Drawing.Point(583, 229)
        Me.tbCariDataApoteker.MaxLength = 32767
        Me.tbCariDataApoteker.Name = "tbCariDataApoteker"
        Me.tbCariDataApoteker.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCariDataApoteker.PromptText = "Cari..."
        Me.tbCariDataApoteker.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbCariDataApoteker.SelectedText = ""
        Me.tbCariDataApoteker.Size = New System.Drawing.Size(200, 29)
        Me.tbCariDataApoteker.TabIndex = 19
        Me.tbCariDataApoteker.UseSelectable = True
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
        'dgvDataApoteker
        '
        Me.dgvDataApoteker.AllowUserToAddRows = False
        Me.dgvDataApoteker.AllowUserToDeleteRows = False
        Me.dgvDataApoteker.AllowUserToResizeColumns = False
        Me.dgvDataApoteker.AllowUserToResizeRows = False
        Me.dgvDataApoteker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDataApoteker.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDataApoteker.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDataApoteker.ColumnHeadersHeight = 29
        Me.dgvDataApoteker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDataApoteker.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDataApoteker.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDataApoteker.Location = New System.Drawing.Point(47, 275)
        Me.dgvDataApoteker.MultiSelect = False
        Me.dgvDataApoteker.Name = "dgvDataApoteker"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataApoteker.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDataApoteker.RowHeadersVisible = False
        Me.dgvDataApoteker.RowHeadersWidth = 51
        Me.dgvDataApoteker.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDataApoteker.Size = New System.Drawing.Size(943, 306)
        Me.dgvDataApoteker.TabIndex = 0
        '
        'Data_Apoteker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Data_Apoteker"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDataApoteker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvDataApoteker As DataGridView
    Friend WithEvents tbKodeApoteker As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSimpan As MetroFramework.Controls.MetroButton
    Friend WithEvents tbAlamatApoteker As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbNamaApoteker As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbJenkelApoteker As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnBatal As MetroFramework.Controls.MetroButton
    Friend WithEvents btnHapus As MetroFramework.Controls.MetroButton
    Friend WithEvents btnUbah As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCariDataApoteker As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbUsiaApoteker As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbNomorTelepon As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
