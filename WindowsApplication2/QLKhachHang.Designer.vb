<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkhachhang
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
        Me.lb_makhachhang = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtMaKh = New System.Windows.Forms.TextBox()
        Me.lb_tenkhachhang = New System.Windows.Forms.Label()
        Me.lb_sodienthoai = New System.Windows.Forms.Label()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.lb_diachi = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLoaiKH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxGT = New System.Windows.Forms.ComboBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_makhachhang
        '
        Me.lb_makhachhang.AutoSize = True
        Me.lb_makhachhang.Location = New System.Drawing.Point(41, 29)
        Me.lb_makhachhang.Name = "lb_makhachhang"
        Me.lb_makhachhang.Size = New System.Drawing.Size(85, 13)
        Me.lb_makhachhang.TabIndex = 0
        Me.lb_makhachhang.Text = "Mã Khách Hàng"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(44, 252)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 1
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtMaKh
        '
        Me.txtMaKh.BackColor = System.Drawing.SystemColors.Control
        Me.txtMaKh.Location = New System.Drawing.Point(162, 29)
        Me.txtMaKh.Name = "txtMaKh"
        Me.txtMaKh.ReadOnly = True
        Me.txtMaKh.Size = New System.Drawing.Size(167, 20)
        Me.txtMaKh.TabIndex = 2
        '
        'lb_tenkhachhang
        '
        Me.lb_tenkhachhang.AutoSize = True
        Me.lb_tenkhachhang.Location = New System.Drawing.Point(41, 55)
        Me.lb_tenkhachhang.Name = "lb_tenkhachhang"
        Me.lb_tenkhachhang.Size = New System.Drawing.Size(89, 13)
        Me.lb_tenkhachhang.TabIndex = 3
        Me.lb_tenkhachhang.Text = "Tên Khách Hàng"
        '
        'lb_sodienthoai
        '
        Me.lb_sodienthoai.AutoSize = True
        Me.lb_sodienthoai.Location = New System.Drawing.Point(41, 84)
        Me.lb_sodienthoai.Name = "lb_sodienthoai"
        Me.lb_sodienthoai.Size = New System.Drawing.Size(75, 13)
        Me.lb_sodienthoai.TabIndex = 4
        Me.lb_sodienthoai.Text = "Số Điện Thoại"
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(162, 55)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(167, 20)
        Me.txtTenKH.TabIndex = 5
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(162, 81)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(167, 20)
        Me.txtSDT.TabIndex = 6
        '
        'lb_diachi
        '
        Me.lb_diachi.AutoSize = True
        Me.lb_diachi.Location = New System.Drawing.Point(41, 110)
        Me.lb_diachi.Name = "lb_diachi"
        Me.lb_diachi.Size = New System.Drawing.Size(41, 13)
        Me.lb_diachi.TabIndex = 7
        Me.lb_diachi.Text = "Địa Chỉ"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(162, 107)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(167, 20)
        Me.txtDiaChi.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(344, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(700, 292)
        Me.DataGridView1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Giới tính"
        '
        'txtLoaiKH
        '
        Me.txtLoaiKH.Location = New System.Drawing.Point(162, 158)
        Me.txtLoaiKH.Name = "txtLoaiKH"
        Me.txtLoaiKH.Size = New System.Drawing.Size(167, 20)
        Me.txtLoaiKH.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Loại Khách hàng"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(162, 184)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(167, 20)
        Me.txtGhiChu.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Ghi chú"
        '
        'cbxGT
        '
        Me.cbxGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGT.FormattingEnabled = True
        Me.cbxGT.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.cbxGT.Location = New System.Drawing.Point(162, 133)
        Me.cbxGT.Name = "cbxGT"
        Me.cbxGT.Size = New System.Drawing.Size(121, 21)
        Me.cbxGT.TabIndex = 16
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(150, 252)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 17
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(254, 252)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 18
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'frmkhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 316)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.cbxGT)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLoaiKH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.lb_diachi)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.lb_sodienthoai)
        Me.Controls.Add(Me.lb_tenkhachhang)
        Me.Controls.Add(Me.txtMaKh)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.lb_makhachhang)
        Me.Name = "frmkhachhang"
        Me.Text = "Khách Hàng"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_makhachhang As System.Windows.Forms.Label
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents txtMaKh As System.Windows.Forms.TextBox
    Friend WithEvents lb_tenkhachhang As System.Windows.Forms.Label
    Friend WithEvents lb_sodienthoai As System.Windows.Forms.Label
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents txtSDT As System.Windows.Forms.TextBox
    Friend WithEvents lb_diachi As System.Windows.Forms.Label
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLoaiKH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGhiChu As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxGT As System.Windows.Forms.ComboBox
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
End Class
