<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pengaturan_Akun
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbUsernameAkun = New MetroFramework.Controls.MetroTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbPasswordAkun = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbKodeApoteker = New MetroFramework.Controls.MetroTextBox()
        Me.tbNamaApoteker = New MetroFramework.Controls.MetroTextBox()
        Me.tbAlamatApoteker = New MetroFramework.Controls.MetroTextBox()
        Me.cbJenkelApoteker = New MetroFramework.Controls.MetroComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbUsiaApoteker = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNomorTelepon = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1040, 640)
        Me.Panel1.TabIndex = 0
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Transparent
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSimpan.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSimpan.Location = New System.Drawing.Point(845, 353)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(100, 35)
        Me.btnSimpan.TabIndex = 1
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseSelectable = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbUsernameAkun)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tbPasswordAkun)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(47, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(898, 124)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATA AKUN"
        '
        'tbUsernameAkun
        '
        Me.tbUsernameAkun.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbUsernameAkun.Lines = New String(-1) {}
        Me.tbUsernameAkun.Location = New System.Drawing.Point(183, 36)
        Me.tbUsernameAkun.MaxLength = 200
        Me.tbUsernameAkun.Name = "tbUsernameAkun"
        Me.tbUsernameAkun.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUsernameAkun.PromptText = "Username"
        Me.tbUsernameAkun.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbUsernameAkun.SelectedText = ""
        Me.tbUsernameAkun.Size = New System.Drawing.Size(200, 29)
        Me.tbUsernameAkun.TabIndex = 25
        Me.tbUsernameAkun.UseSelectable = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 23)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Password             :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 23)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Username            :"
        '
        'tbPasswordAkun
        '
        Me.tbPasswordAkun.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbPasswordAkun.Lines = New String(-1) {}
        Me.tbPasswordAkun.Location = New System.Drawing.Point(183, 75)
        Me.tbPasswordAkun.MaxLength = 50
        Me.tbPasswordAkun.Name = "tbPasswordAkun"
        Me.tbPasswordAkun.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPasswordAkun.PromptText = "Password"
        Me.tbPasswordAkun.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbPasswordAkun.SelectedText = ""
        Me.tbPasswordAkun.Size = New System.Drawing.Size(200, 29)
        Me.tbPasswordAkun.TabIndex = 27
        Me.tbPasswordAkun.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbKodeApoteker)
        Me.GroupBox1.Controls.Add(Me.tbNamaApoteker)
        Me.GroupBox1.Controls.Add(Me.tbAlamatApoteker)
        Me.GroupBox1.Controls.Add(Me.cbJenkelApoteker)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbUsiaApoteker)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbNomorTelepon)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(47, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(898, 169)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA PEGAWAI"
        '
        'tbKodeApoteker
        '
        Me.tbKodeApoteker.Enabled = False
        Me.tbKodeApoteker.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbKodeApoteker.Lines = New String(-1) {}
        Me.tbKodeApoteker.Location = New System.Drawing.Point(183, 28)
        Me.tbKodeApoteker.MaxLength = 32767
        Me.tbKodeApoteker.Name = "tbKodeApoteker"
        Me.tbKodeApoteker.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbKodeApoteker.PromptText = "Kode Apoteker"
        Me.tbKodeApoteker.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbKodeApoteker.SelectedText = ""
        Me.tbKodeApoteker.Size = New System.Drawing.Size(200, 29)
        Me.tbKodeApoteker.TabIndex = 2
        Me.tbKodeApoteker.UseSelectable = True
        '
        'tbNamaApoteker
        '
        Me.tbNamaApoteker.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbNamaApoteker.Lines = New String(-1) {}
        Me.tbNamaApoteker.Location = New System.Drawing.Point(183, 63)
        Me.tbNamaApoteker.MaxLength = 200
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
        'tbAlamatApoteker
        '
        Me.tbAlamatApoteker.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbAlamatApoteker.Lines = New String(-1) {}
        Me.tbAlamatApoteker.Location = New System.Drawing.Point(600, 98)
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
        'cbJenkelApoteker
        '
        Me.cbJenkelApoteker.FormattingEnabled = True
        Me.cbJenkelApoteker.ItemHeight = 23
        Me.cbJenkelApoteker.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cbJenkelApoteker.Location = New System.Drawing.Point(183, 98)
        Me.cbJenkelApoteker.Name = "cbJenkelApoteker"
        Me.cbJenkelApoteker.PromptText = "Jenis Kelamin"
        Me.cbJenkelApoteker.Size = New System.Drawing.Size(200, 29)
        Me.cbJenkelApoteker.TabIndex = 8
        Me.cbJenkelApoteker.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nama Apoteker   :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(429, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 23)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Usia                      :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Kode Apoteker     :"
        '
        'tbUsiaApoteker
        '
        Me.tbUsiaApoteker.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbUsiaApoteker.Lines = New String(-1) {}
        Me.tbUsiaApoteker.Location = New System.Drawing.Point(600, 28)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Jenis Kelamin       :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(429, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 23)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Nomor Telepon    :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(429, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Alamat                 :"
        '
        'tbNomorTelepon
        '
        Me.tbNomorTelepon.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbNomorTelepon.Lines = New String(-1) {}
        Me.tbNomorTelepon.Location = New System.Drawing.Point(600, 63)
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
        'Pengaturan_Akun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 640)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pengaturan_Akun"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbKodeApoteker As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSimpan As MetroFramework.Controls.MetroButton
    Friend WithEvents tbAlamatApoteker As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbNamaApoteker As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbJenkelApoteker As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbUsiaApoteker As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbNomorTelepon As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbPasswordAkun As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbUsernameAkun As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
