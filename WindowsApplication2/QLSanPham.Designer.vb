<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanlyhanghoa
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
        Me.dgr_HangHoa = New System.Windows.Forms.DataGridView()
        Me.lb_idsanpham = New System.Windows.Forms.Label()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.lb_tensp = New System.Windows.Forms.Label()
        Me.lb_soluong = New System.Windows.Forms.Label()
        Me.lb_donvitinh = New System.Windows.Forms.Label()
        Me.txt_idsanpham = New System.Windows.Forms.TextBox()
        Me.txt_tensp = New System.Windows.Forms.TextBox()
        Me.txt_soluong = New System.Windows.Forms.TextBox()
        Me.txt_donvi = New System.Windows.Forms.TextBox()
        Me.txt_gianhap = New System.Windows.Forms.TextBox()
        Me.lb_gianhap = New System.Windows.Forms.Label()
        Me.txt_giaban = New System.Windows.Forms.TextBox()
        Me.lb_giaban = New System.Windows.Forms.Label()
        Me.txt_maloaisp = New System.Windows.Forms.TextBox()
        Me.lb_maloaisp = New System.Windows.Forms.Label()
        Me.txt_mota = New System.Windows.Forms.TextBox()
        Me.lb_masp = New System.Windows.Forms.Label()
        CType(Me.dgr_HangHoa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgr_HangHoa
        '
        Me.dgr_HangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgr_HangHoa.Location = New System.Drawing.Point(345, 23)
        Me.dgr_HangHoa.Name = "dgr_HangHoa"
        Me.dgr_HangHoa.Size = New System.Drawing.Size(566, 301)
        Me.dgr_HangHoa.TabIndex = 0
        '
        'lb_idsanpham
        '
        Me.lb_idsanpham.AutoSize = True
        Me.lb_idsanpham.Location = New System.Drawing.Point(12, 28)
        Me.lb_idsanpham.Name = "lb_idsanpham"
        Me.lb_idsanpham.Size = New System.Drawing.Size(70, 13)
        Me.lb_idsanpham.TabIndex = 1
        Me.lb_idsanpham.Text = "ID Sản Phẩm"
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(28, 301)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 3
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(125, 301)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 4
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(223, 301)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 5
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'lb_tensp
        '
        Me.lb_tensp.AutoSize = True
        Me.lb_tensp.Location = New System.Drawing.Point(11, 51)
        Me.lb_tensp.Name = "lb_tensp"
        Me.lb_tensp.Size = New System.Drawing.Size(43, 13)
        Me.lb_tensp.TabIndex = 7
        Me.lb_tensp.Text = "Tên SP"
        '
        'lb_soluong
        '
        Me.lb_soluong.AutoSize = True
        Me.lb_soluong.Location = New System.Drawing.Point(11, 80)
        Me.lb_soluong.Name = "lb_soluong"
        Me.lb_soluong.Size = New System.Drawing.Size(53, 13)
        Me.lb_soluong.TabIndex = 8
        Me.lb_soluong.Text = "Số Lượng"
        '
        'lb_donvitinh
        '
        Me.lb_donvitinh.AutoSize = True
        Me.lb_donvitinh.Location = New System.Drawing.Point(12, 106)
        Me.lb_donvitinh.Name = "lb_donvitinh"
        Me.lb_donvitinh.Size = New System.Drawing.Size(39, 13)
        Me.lb_donvitinh.TabIndex = 9
        Me.lb_donvitinh.Text = "Đơn Vị"
        '
        'txt_idsanpham
        '
        Me.txt_idsanpham.ForeColor = System.Drawing.SystemColors.Control
        Me.txt_idsanpham.Location = New System.Drawing.Point(95, 23)
        Me.txt_idsanpham.Name = "txt_idsanpham"
        Me.txt_idsanpham.ReadOnly = True
        Me.txt_idsanpham.Size = New System.Drawing.Size(203, 20)
        Me.txt_idsanpham.TabIndex = 10
        '
        'txt_tensp
        '
        Me.txt_tensp.Location = New System.Drawing.Point(95, 48)
        Me.txt_tensp.Name = "txt_tensp"
        Me.txt_tensp.Size = New System.Drawing.Size(203, 20)
        Me.txt_tensp.TabIndex = 12
        '
        'txt_soluong
        '
        Me.txt_soluong.Location = New System.Drawing.Point(95, 74)
        Me.txt_soluong.Name = "txt_soluong"
        Me.txt_soluong.Size = New System.Drawing.Size(203, 20)
        Me.txt_soluong.TabIndex = 13
        '
        'txt_donvi
        '
        Me.txt_donvi.Location = New System.Drawing.Point(95, 103)
        Me.txt_donvi.Name = "txt_donvi"
        Me.txt_donvi.Size = New System.Drawing.Size(203, 20)
        Me.txt_donvi.TabIndex = 14
        '
        'txt_gianhap
        '
        Me.txt_gianhap.Location = New System.Drawing.Point(95, 130)
        Me.txt_gianhap.Name = "txt_gianhap"
        Me.txt_gianhap.Size = New System.Drawing.Size(203, 20)
        Me.txt_gianhap.TabIndex = 16
        '
        'lb_gianhap
        '
        Me.lb_gianhap.AutoSize = True
        Me.lb_gianhap.Location = New System.Drawing.Point(11, 137)
        Me.lb_gianhap.Name = "lb_gianhap"
        Me.lb_gianhap.Size = New System.Drawing.Size(52, 13)
        Me.lb_gianhap.TabIndex = 15
        Me.lb_gianhap.Text = "Giá Nhập"
        '
        'txt_giaban
        '
        Me.txt_giaban.Location = New System.Drawing.Point(95, 162)
        Me.txt_giaban.Name = "txt_giaban"
        Me.txt_giaban.Size = New System.Drawing.Size(203, 20)
        Me.txt_giaban.TabIndex = 18
        '
        'lb_giaban
        '
        Me.lb_giaban.AutoSize = True
        Me.lb_giaban.Location = New System.Drawing.Point(11, 169)
        Me.lb_giaban.Name = "lb_giaban"
        Me.lb_giaban.Size = New System.Drawing.Size(45, 13)
        Me.lb_giaban.TabIndex = 17
        Me.lb_giaban.Text = "Giá Bán"
        '
        'txt_maloaisp
        '
        Me.txt_maloaisp.Location = New System.Drawing.Point(95, 191)
        Me.txt_maloaisp.Name = "txt_maloaisp"
        Me.txt_maloaisp.Size = New System.Drawing.Size(203, 20)
        Me.txt_maloaisp.TabIndex = 20
        '
        'lb_maloaisp
        '
        Me.lb_maloaisp.AutoSize = True
        Me.lb_maloaisp.Location = New System.Drawing.Point(11, 198)
        Me.lb_maloaisp.Name = "lb_maloaisp"
        Me.lb_maloaisp.Size = New System.Drawing.Size(62, 13)
        Me.lb_maloaisp.TabIndex = 19
        Me.lb_maloaisp.Text = "Mã Loại SP"
        '
        'txt_mota
        '
        Me.txt_mota.Location = New System.Drawing.Point(95, 217)
        Me.txt_mota.Multiline = True
        Me.txt_mota.Name = "txt_mota"
        Me.txt_mota.Size = New System.Drawing.Size(203, 52)
        Me.txt_mota.TabIndex = 23
        '
        'lb_masp
        '
        Me.lb_masp.AutoSize = True
        Me.lb_masp.Location = New System.Drawing.Point(12, 224)
        Me.lb_masp.Name = "lb_masp"
        Me.lb_masp.Size = New System.Drawing.Size(34, 13)
        Me.lb_masp.TabIndex = 22
        Me.lb_masp.Text = "Mô tả"
        '
        'frmquanlyhanghoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 352)
        Me.Controls.Add(Me.txt_mota)
        Me.Controls.Add(Me.lb_masp)
        Me.Controls.Add(Me.txt_maloaisp)
        Me.Controls.Add(Me.lb_maloaisp)
        Me.Controls.Add(Me.txt_giaban)
        Me.Controls.Add(Me.lb_giaban)
        Me.Controls.Add(Me.txt_gianhap)
        Me.Controls.Add(Me.lb_gianhap)
        Me.Controls.Add(Me.txt_donvi)
        Me.Controls.Add(Me.txt_soluong)
        Me.Controls.Add(Me.txt_tensp)
        Me.Controls.Add(Me.txt_idsanpham)
        Me.Controls.Add(Me.lb_donvitinh)
        Me.Controls.Add(Me.lb_soluong)
        Me.Controls.Add(Me.lb_tensp)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.lb_idsanpham)
        Me.Controls.Add(Me.dgr_HangHoa)
        Me.Name = "frmquanlyhanghoa"
        Me.Text = "Quản Lý Hàng Hóa"
        CType(Me.dgr_HangHoa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgr_HangHoa As System.Windows.Forms.DataGridView
    Friend WithEvents lb_idsanpham As System.Windows.Forms.Label
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents lb_tensp As System.Windows.Forms.Label
    Friend WithEvents lb_soluong As System.Windows.Forms.Label
    Friend WithEvents lb_donvitinh As System.Windows.Forms.Label
    Friend WithEvents txt_idsanpham As System.Windows.Forms.TextBox
    Friend WithEvents txt_tensp As System.Windows.Forms.TextBox
    Friend WithEvents txt_soluong As System.Windows.Forms.TextBox
    Friend WithEvents txt_donvi As System.Windows.Forms.TextBox
    Friend WithEvents txt_gianhap As System.Windows.Forms.TextBox
    Friend WithEvents lb_gianhap As System.Windows.Forms.Label
    Friend WithEvents txt_giaban As System.Windows.Forms.TextBox
    Friend WithEvents lb_giaban As System.Windows.Forms.Label
    Friend WithEvents txt_maloaisp As System.Windows.Forms.TextBox
    Friend WithEvents lb_maloaisp As System.Windows.Forms.Label
    Friend WithEvents txt_mota As System.Windows.Forms.TextBox
    Friend WithEvents lb_masp As System.Windows.Forms.Label
End Class
