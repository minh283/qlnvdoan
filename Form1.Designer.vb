<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvNhanVien = New System.Windows.Forms.DataGridView()
        Me.lblMaNV = New System.Windows.Forms.Label()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.lblHoTen = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.lblSDT = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.lblNgayLam = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnLamMoi = New System.Windows.Forms.Button()
        Me.dtpNgayLam = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'dgvNhanVien
        '
        Me.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvNhanVien.Location = New System.Drawing.Point(0, 0)
        Me.dgvNhanVien.Name = "dgvNhanVien"
        Me.dgvNhanVien.RowHeadersWidth = 51
        Me.dgvNhanVien.RowTemplate.Height = 24
        Me.dgvNhanVien.Size = New System.Drawing.Size(800, 192)
        Me.dgvNhanVien.TabIndex = 2
        '
        'lblMaNV
        '
        Me.lblMaNV.AutoSize = True
        Me.lblMaNV.Location = New System.Drawing.Point(25, 204)
        Me.lblMaNV.Name = "lblMaNV"
        Me.lblMaNV.Size = New System.Drawing.Size(48, 16)
        Me.lblMaNV.TabIndex = 3
        Me.lblMaNV.Text = "Mã NV"
        '
        'txtMaNV
        '
        Me.txtMaNV.Location = New System.Drawing.Point(101, 198)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(291, 22)
        Me.txtMaNV.TabIndex = 4
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(101, 238)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(291, 22)
        Me.txtHoTen.TabIndex = 6
        '
        'lblHoTen
        '
        Me.lblHoTen.AutoSize = True
        Me.lblHoTen.Location = New System.Drawing.Point(25, 244)
        Me.lblHoTen.Name = "lblHoTen"
        Me.lblHoTen.Size = New System.Drawing.Size(52, 16)
        Me.lblHoTen.TabIndex = 5
        Me.lblHoTen.Text = "Họ Tên"
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(101, 288)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(291, 22)
        Me.txtSDT.TabIndex = 8
        '
        'lblSDT
        '
        Me.lblSDT.AutoSize = True
        Me.lblSDT.Location = New System.Drawing.Point(25, 294)
        Me.lblSDT.Name = "lblSDT"
        Me.lblSDT.Size = New System.Drawing.Size(34, 16)
        Me.lblSDT.TabIndex = 7
        Me.lblSDT.Text = "SĐT"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(101, 340)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(291, 22)
        Me.txtDiaChi.TabIndex = 10
        '
        'lblDiaChi
        '
        Me.lblDiaChi.AutoSize = True
        Me.lblDiaChi.Location = New System.Drawing.Point(25, 346)
        Me.lblDiaChi.Name = "lblDiaChi"
        Me.lblDiaChi.Size = New System.Drawing.Size(49, 16)
        Me.lblDiaChi.TabIndex = 9
        Me.lblDiaChi.Text = "Địa Chỉ"
        '
        'lblNgayLam
        '
        Me.lblNgayLam.AutoSize = True
        Me.lblNgayLam.Location = New System.Drawing.Point(25, 398)
        Me.lblNgayLam.Name = "lblNgayLam"
        Me.lblNgayLam.Size = New System.Drawing.Size(69, 16)
        Me.lblNgayLam.TabIndex = 11
        Me.lblNgayLam.Text = "Ngày Làm"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(439, 244)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(112, 37)
        Me.btnThem.TabIndex = 13
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(439, 356)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(112, 37)
        Me.btnSua.TabIndex = 14
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(632, 244)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(112, 37)
        Me.btnXoa.TabIndex = 15
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Location = New System.Drawing.Point(632, 356)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(112, 37)
        Me.btnLamMoi.TabIndex = 17
        Me.btnLamMoi.Text = "Làm Mới"
        Me.btnLamMoi.UseVisualStyleBackColor = True
        '
        'dtpNgayLam
        '
        Me.dtpNgayLam.Location = New System.Drawing.Point(101, 391)
        Me.dtpNgayLam.Name = "dtpNgayLam"
        Me.dtpNgayLam.Size = New System.Drawing.Size(302, 22)
        Me.dtpNgayLam.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtpNgayLam)
        Me.Controls.Add(Me.btnLamMoi)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.lblNgayLam)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.lblDiaChi)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.lblSDT)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.lblHoTen)
        Me.Controls.Add(Me.txtMaNV)
        Me.Controls.Add(Me.lblMaNV)
        Me.Controls.Add(Me.dgvNhanVien)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvNhanVien As DataGridView
    Friend WithEvents lblMaNV As Label
    Friend WithEvents txtMaNV As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents lblHoTen As Label
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents lblSDT As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents lblDiaChi As Label
    Friend WithEvents lblNgayLam As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnLamMoi As Button
    Friend WithEvents dtpNgayLam As DateTimePicker
End Class
