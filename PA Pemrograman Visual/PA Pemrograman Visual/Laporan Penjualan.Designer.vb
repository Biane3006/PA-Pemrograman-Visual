<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Laporan_Penjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laporan_Penjualan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbCariLaporanPenjualan = New MetroFramework.Controls.MetroTextBox()
        Me.btnPrint = New MetroFramework.Controls.MetroButton()
        Me.dgvLaporanPenjualan = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvLaporanPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel1.Controls.Add(Me.tbCariLaporanPenjualan)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.dgvLaporanPenjualan)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1387, 788)
        Me.Panel1.TabIndex = 0
        '
        'tbCariLaporanPenjualan
        '
        Me.tbCariLaporanPenjualan.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbCariLaporanPenjualan.Icon = CType(resources.GetObject("tbCariLaporanPenjualan.Icon"), System.Drawing.Image)
        Me.tbCariLaporanPenjualan.IconRight = True
        Me.tbCariLaporanPenjualan.Lines = New String(-1) {}
        Me.tbCariLaporanPenjualan.Location = New System.Drawing.Point(204, 288)
        Me.tbCariLaporanPenjualan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCariLaporanPenjualan.MaxLength = 32767
        Me.tbCariLaporanPenjualan.Name = "tbCariLaporanPenjualan"
        Me.tbCariLaporanPenjualan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCariLaporanPenjualan.PromptText = "Cari..."
        Me.tbCariLaporanPenjualan.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbCariLaporanPenjualan.SelectedText = ""
        Me.tbCariLaporanPenjualan.Size = New System.Drawing.Size(267, 43)
        Me.tbCariLaporanPenjualan.TabIndex = 19
        Me.tbCariLaporanPenjualan.UseSelectable = True
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPrint.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnPrint.Location = New System.Drawing.Point(63, 288)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(133, 43)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Cetak"
        Me.btnPrint.UseSelectable = True
        '
        'dgvLaporanPenjualan
        '
        Me.dgvLaporanPenjualan.AllowUserToAddRows = False
        Me.dgvLaporanPenjualan.AllowUserToDeleteRows = False
        Me.dgvLaporanPenjualan.AllowUserToResizeColumns = False
        Me.dgvLaporanPenjualan.AllowUserToResizeRows = False
        Me.dgvLaporanPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLaporanPenjualan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLaporanPenjualan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLaporanPenjualan.ColumnHeadersHeight = 29
        Me.dgvLaporanPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLaporanPenjualan.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLaporanPenjualan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvLaporanPenjualan.Location = New System.Drawing.Point(63, 338)
        Me.dgvLaporanPenjualan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvLaporanPenjualan.MultiSelect = False
        Me.dgvLaporanPenjualan.Name = "dgvLaporanPenjualan"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLaporanPenjualan.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLaporanPenjualan.RowHeadersVisible = False
        Me.dgvLaporanPenjualan.RowHeadersWidth = 51
        Me.dgvLaporanPenjualan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvLaporanPenjualan.Size = New System.Drawing.Size(1257, 377)
        Me.dgvLaporanPenjualan.TabIndex = 0
        '
        'Laporan_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1387, 788)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Laporan_Penjualan"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvLaporanPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvLaporanPenjualan As DataGridView
    Friend WithEvents btnPrint As MetroFramework.Controls.MetroButton
    Friend WithEvents tbCariLaporanPenjualan As MetroFramework.Controls.MetroTextBox
End Class
