<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading))
        Me.labelLogin = New System.Windows.Forms.Label()
        Me.logoPlus = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.logoPlus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelLogin
        '
        Me.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelLogin.AutoSize = True
        Me.labelLogin.BackColor = System.Drawing.Color.Transparent
        Me.labelLogin.Font = New System.Drawing.Font("Segoe UI", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelLogin.Location = New System.Drawing.Point(70, 243)
        Me.labelLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelLogin.Name = "labelLogin"
        Me.labelLogin.Size = New System.Drawing.Size(719, 89)
        Me.labelLogin.TabIndex = 15
        Me.labelLogin.Text = "APOTEK SAMARINDA"
        Me.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'logoPlus
        '
        Me.logoPlus.Image = CType(resources.GetObject("logoPlus.Image"), System.Drawing.Image)
        Me.logoPlus.Location = New System.Drawing.Point(344, 13)
        Me.logoPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.logoPlus.Name = "logoPlus"
        Me.logoPlus.Size = New System.Drawing.Size(200, 200)
        Me.logoPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoPlus.TabIndex = 16
        Me.logoPlus.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 377)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(896, 23)
        Me.ProgressBar1.TabIndex = 17
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(920, 432)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.logoPlus)
        Me.Controls.Add(Me.labelLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loading"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        CType(Me.logoPlus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelLogin As Label
    Friend WithEvents logoPlus As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
