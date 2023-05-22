<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labelLogin = New System.Windows.Forms.Label()
        Me.tbIdAkun = New System.Windows.Forms.TextBox()
        Me.btnLogin = New MetroFramework.Controls.MetroButton()
        Me.cbShowPassword = New MetroFramework.Controls.MetroCheckBox()
        Me.tbPassword = New MetroFramework.Controls.MetroTextBox()
        Me.tbUsername = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.labelTeksBerjalan = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.labelSiapMelayaniAnda = New System.Windows.Forms.Label()
        Me.labelApotekSamarinda = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel1.Controls.Add(Me.labelLogin)
        Me.Panel1.Controls.Add(Me.tbIdAkun)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.cbShowPassword)
        Me.Panel1.Controls.Add(Me.tbPassword)
        Me.Panel1.Controls.Add(Me.tbUsername)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(442, 486)
        Me.Panel1.TabIndex = 7
        '
        'labelLogin
        '
        Me.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelLogin.AutoSize = True
        Me.labelLogin.BackColor = System.Drawing.Color.Transparent
        Me.labelLogin.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelLogin.Location = New System.Drawing.Point(90, 3)
        Me.labelLogin.Name = "labelLogin"
        Me.labelLogin.Size = New System.Drawing.Size(240, 37)
        Me.labelLogin.TabIndex = 14
        Me.labelLogin.Text = "L     O     G     I     N"
        Me.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbIdAkun
        '
        Me.tbIdAkun.Enabled = False
        Me.tbIdAkun.Location = New System.Drawing.Point(97, 337)
        Me.tbIdAkun.Name = "tbIdAkun"
        Me.tbIdAkun.ReadOnly = True
        Me.tbIdAkun.Size = New System.Drawing.Size(44, 20)
        Me.tbIdAkun.TabIndex = 12
        Me.tbIdAkun.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(97, 392)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(233, 37)
        Me.btnLogin.TabIndex = 11
        Me.btnLogin.Text = "SUBMIT"
        Me.btnLogin.UseCustomBackColor = True
        Me.btnLogin.UseSelectable = True
        '
        'cbShowPassword
        '
        Me.cbShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbShowPassword.AutoSize = True
        Me.cbShowPassword.BackColor = System.Drawing.Color.Transparent
        Me.cbShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cbShowPassword.Location = New System.Drawing.Point(97, 316)
        Me.cbShowPassword.Name = "cbShowPassword"
        Me.cbShowPassword.Size = New System.Drawing.Size(105, 15)
        Me.cbShowPassword.TabIndex = 10
        Me.cbShowPassword.Text = "Show Password"
        Me.cbShowPassword.UseSelectable = True
        '
        'tbPassword
        '
        Me.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.tbPassword.Icon = CType(resources.GetObject("tbPassword.Icon"), System.Drawing.Image)
        Me.tbPassword.Lines = New String(-1) {}
        Me.tbPassword.Location = New System.Drawing.Point(97, 263)
        Me.tbPassword.MaxLength = 32767
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPassword.PromptText = "Password"
        Me.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbPassword.SelectedText = ""
        Me.tbPassword.Size = New System.Drawing.Size(233, 35)
        Me.tbPassword.TabIndex = 9
        Me.tbPassword.UseSelectable = True
        '
        'tbUsername
        '
        Me.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbUsername.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.tbUsername.Icon = CType(resources.GetObject("tbUsername.Icon"), System.Drawing.Image)
        Me.tbUsername.Lines = New String(-1) {}
        Me.tbUsername.Location = New System.Drawing.Point(97, 222)
        Me.tbUsername.MaxLength = 32767
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUsername.PromptText = "Username"
        Me.tbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbUsername.SelectedText = ""
        Me.tbUsername.Size = New System.Drawing.Size(233, 35)
        Me.tbUsername.TabIndex = 8
        Me.tbUsername.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(134, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'labelTeksBerjalan
        '
        Me.labelTeksBerjalan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelTeksBerjalan.AutoSize = True
        Me.labelTeksBerjalan.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelTeksBerjalan.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTeksBerjalan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelTeksBerjalan.Location = New System.Drawing.Point(447, 9)
        Me.labelTeksBerjalan.Name = "labelTeksBerjalan"
        Me.labelTeksBerjalan.Size = New System.Drawing.Size(1758, 37)
        Me.labelTeksBerjalan.TabIndex = 13
        Me.labelTeksBerjalan.Text = "S  E  L  A  M  A  T     D  A  T  A  N  G     D  I     A  P  L  I  K  A  S  I     " &
    "P  E  N  D  A  T  A  A  N     O  B  A  T     A  P  O  T  E  K     S  A  M  A  R " &
    " I  N  D  A"
        Me.labelTeksBerjalan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(71, 86)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Panel2.Controls.Add(Me.labelSiapMelayaniAnda)
        Me.Panel2.Controls.Add(Me.labelApotekSamarinda)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(447, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(445, 483)
        Me.Panel2.TabIndex = 15
        '
        'labelSiapMelayaniAnda
        '
        Me.labelSiapMelayaniAnda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelSiapMelayaniAnda.AutoSize = True
        Me.labelSiapMelayaniAnda.BackColor = System.Drawing.Color.Transparent
        Me.labelSiapMelayaniAnda.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSiapMelayaniAnda.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelSiapMelayaniAnda.Location = New System.Drawing.Point(53, 444)
        Me.labelSiapMelayaniAnda.Name = "labelSiapMelayaniAnda"
        Me.labelSiapMelayaniAnda.Size = New System.Drawing.Size(369, 37)
        Me.labelSiapMelayaniAnda.TabIndex = 16
        Me.labelSiapMelayaniAnda.Text = "Siap Melayani Anda 24 Jam"
        Me.labelSiapMelayaniAnda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelApotekSamarinda
        '
        Me.labelApotekSamarinda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelApotekSamarinda.AutoSize = True
        Me.labelApotekSamarinda.BackColor = System.Drawing.Color.Transparent
        Me.labelApotekSamarinda.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelApotekSamarinda.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelApotekSamarinda.Location = New System.Drawing.Point(13, 395)
        Me.labelApotekSamarinda.Name = "labelApotekSamarinda"
        Me.labelApotekSamarinda.Size = New System.Drawing.Size(432, 54)
        Me.labelApotekSamarinda.TabIndex = 15
        Me.labelApotekSamarinda.Text = "APOTEK SAMARINDA"
        Me.labelApotekSamarinda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(892, 486)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.labelTeksBerjalan)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogin As MetroFramework.Controls.MetroButton
    Friend WithEvents cbShowPassword As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents tbPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents labelTeksBerjalan As Label
    Friend WithEvents tbIdAkun As TextBox
    Friend WithEvents labelLogin As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents labelSiapMelayaniAnda As Label
    Friend WithEvents labelApotekSamarinda As Label
End Class
