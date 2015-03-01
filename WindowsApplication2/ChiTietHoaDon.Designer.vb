<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_chitiethd
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
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.txt_maCTHD = New System.Windows.Forms.TextBox()
        Me.lb_maCTHD = New System.Windows.Forms.Label()
        Me.Lb_MaHD = New System.Windows.Forms.Label()
        Me.txt_MaHD = New System.Windows.Forms.TextBox()
        Me.LB_IDsanpham = New System.Windows.Forms.Label()
        Me.txt_IDsanpham = New System.Windows.Forms.TextBox()
        Me.Lb_SLuong = New System.Windows.Forms.Label()
        Me.txt_soluong = New System.Windows.Forms.TextBox()
        Me.lb_thanhtien = New System.Windows.Forms.Label()
        Me.txt_thanhtien = New System.Windows.Forms.TextBox()
        Me.lb_Ghichu = New System.Windows.Forms.Label()
        Me.txt_ghichu = New System.Windows.Forms.TextBox()
        Me.dgr_chitiethd = New System.Windows.Forms.DataGridView()
        CType(Me.dgr_chitiethd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_them
        '
        Me.btn_them.Location = New System.Drawing.Point(44, 262)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(75, 23)
        Me.btn_them.TabIndex = 0
        Me.btn_them.Text = "Thêm"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.Location = New System.Drawing.Point(152, 262)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(75, 23)
        Me.btn_xoa.TabIndex = 1
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_sua
        '
        Me.btn_sua.Location = New System.Drawing.Point(99, 302)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(75, 23)
        Me.btn_sua.TabIndex = 2
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'txt_maCTHD
        '
        Me.txt_maCTHD.Location = New System.Drawing.Point(127, 26)
        Me.txt_maCTHD.Name = "txt_maCTHD"
        Me.txt_maCTHD.Size = New System.Drawing.Size(146, 20)
        Me.txt_maCTHD.TabIndex = 3
        '
        'lb_maCTHD
        '
        Me.lb_maCTHD.AutoSize = True
        Me.lb_maCTHD.Location = New System.Drawing.Point(32, 26)
        Me.lb_maCTHD.Name = "lb_maCTHD"
        Me.lb_maCTHD.Size = New System.Drawing.Size(55, 13)
        Me.lb_maCTHD.TabIndex = 4
        Me.lb_maCTHD.Text = "Mã CTHĐ"
        '
        'Lb_MaHD
        '
        Me.Lb_MaHD.AutoSize = True
        Me.Lb_MaHD.Location = New System.Drawing.Point(32, 60)
        Me.Lb_MaHD.Name = "Lb_MaHD"
        Me.Lb_MaHD.Size = New System.Drawing.Size(41, 13)
        Me.Lb_MaHD.TabIndex = 6
        Me.Lb_MaHD.Text = "Mã HĐ"
        '
        'txt_MaHD
        '
        Me.txt_MaHD.Location = New System.Drawing.Point(127, 60)
        Me.txt_MaHD.Name = "txt_MaHD"
        Me.txt_MaHD.Size = New System.Drawing.Size(146, 20)
        Me.txt_MaHD.TabIndex = 5
        '
        'LB_IDsanpham
        '
        Me.LB_IDsanpham.AutoSize = True
        Me.LB_IDsanpham.Location = New System.Drawing.Point(32, 95)
        Me.LB_IDsanpham.Name = "LB_IDsanpham"
        Me.LB_IDsanpham.Size = New System.Drawing.Size(70, 13)
        Me.LB_IDsanpham.TabIndex = 8
        Me.LB_IDsanpham.Text = "ID Sản Phẩm"
        '
        'txt_IDsanpham
        '
        Me.txt_IDsanpham.Location = New System.Drawing.Point(127, 95)
        Me.txt_IDsanpham.Name = "txt_IDsanpham"
        Me.txt_IDsanpham.Size = New System.Drawing.Size(146, 20)
        Me.txt_IDsanpham.TabIndex = 7
        '
        'Lb_SLuong
        '
        Me.Lb_SLuong.AutoSize = True
        Me.Lb_SLuong.Location = New System.Drawing.Point(32, 136)
        Me.Lb_SLuong.Name = "Lb_SLuong"
        Me.Lb_SLuong.Size = New System.Drawing.Size(53, 13)
        Me.Lb_SLuong.TabIndex = 10
        Me.Lb_SLuong.Text = "Số Lượng"
        '
        'txt_soluong
        '
        Me.txt_soluong.Location = New System.Drawing.Point(127, 131)
        Me.txt_soluong.Name = "txt_soluong"
        Me.txt_soluong.Size = New System.Drawing.Size(146, 20)
        Me.txt_soluong.TabIndex = 9
        '
        'lb_thanhtien
        '
        Me.lb_thanhtien.AutoSize = True
        Me.lb_thanhtien.Location = New System.Drawing.Point(32, 173)
        Me.lb_thanhtien.Name = "lb_thanhtien"
        Me.lb_thanhtien.Size = New System.Drawing.Size(62, 13)
        Me.lb_thanhtien.TabIndex = 12
        Me.lb_thanhtien.Text = "Thành Tiền"
        '
        'txt_thanhtien
        '
        Me.txt_thanhtien.Location = New System.Drawing.Point(127, 168)
        Me.txt_thanhtien.Name = "txt_thanhtien"
        Me.txt_thanhtien.Size = New System.Drawing.Size(146, 20)
        Me.txt_thanhtien.TabIndex = 11
        '
        'lb_Ghichu
        '
        Me.lb_Ghichu.AutoSize = True
        Me.lb_Ghichu.Location = New System.Drawing.Point(32, 209)
        Me.lb_Ghichu.Name = "lb_Ghichu"
        Me.lb_Ghichu.Size = New System.Drawing.Size(45, 13)
        Me.lb_Ghichu.TabIndex = 14
        Me.lb_Ghichu.Text = "Ghi Chú"
        '
        'txt_ghichu
        '
        Me.txt_ghichu.Location = New System.Drawing.Point(127, 204)
        Me.txt_ghichu.Name = "txt_ghichu"
        Me.txt_ghichu.Size = New System.Drawing.Size(146, 20)
        Me.txt_ghichu.TabIndex = 13
        '
        'dgr_chitiethd
        '
        Me.dgr_chitiethd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgr_chitiethd.Location = New System.Drawing.Point(297, 18)
        Me.dgr_chitiethd.Name = "dgr_chitiethd"
        Me.dgr_chitiethd.Size = New System.Drawing.Size(637, 301)
        Me.dgr_chitiethd.TabIndex = 15
        '
        'frm_chitiethd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 339)
        Me.Controls.Add(Me.dgr_chitiethd)
        Me.Controls.Add(Me.lb_Ghichu)
        Me.Controls.Add(Me.txt_ghichu)
        Me.Controls.Add(Me.lb_thanhtien)
        Me.Controls.Add(Me.txt_thanhtien)
        Me.Controls.Add(Me.Lb_SLuong)
        Me.Controls.Add(Me.txt_soluong)
        Me.Controls.Add(Me.LB_IDsanpham)
        Me.Controls.Add(Me.txt_IDsanpham)
        Me.Controls.Add(Me.Lb_MaHD)
        Me.Controls.Add(Me.txt_MaHD)
        Me.Controls.Add(Me.lb_maCTHD)
        Me.Controls.Add(Me.txt_maCTHD)
        Me.Controls.Add(Me.btn_sua)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.btn_them)
        Me.Name = "frm_chitiethd"
        Me.Text = "Chi Tiết Hóa Đơn"
        CType(Me.dgr_chitiethd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents btn_xoa As System.Windows.Forms.Button
    Friend WithEvents btn_sua As System.Windows.Forms.Button
    Friend WithEvents txt_maCTHD As System.Windows.Forms.TextBox
    Friend WithEvents lb_maCTHD As System.Windows.Forms.Label
    Friend WithEvents Lb_MaHD As System.Windows.Forms.Label
    Friend WithEvents txt_MaHD As System.Windows.Forms.TextBox
    Friend WithEvents LB_IDsanpham As System.Windows.Forms.Label
    Friend WithEvents txt_IDsanpham As System.Windows.Forms.TextBox
    Friend WithEvents Lb_SLuong As System.Windows.Forms.Label
    Friend WithEvents txt_soluong As System.Windows.Forms.TextBox
    Friend WithEvents lb_thanhtien As System.Windows.Forms.Label
    Friend WithEvents txt_thanhtien As System.Windows.Forms.TextBox
    Friend WithEvents lb_Ghichu As System.Windows.Forms.Label
    Friend WithEvents txt_ghichu As System.Windows.Forms.TextBox
    Friend WithEvents dgr_chitiethd As System.Windows.Forms.DataGridView

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgr_chitiethd.CellContentClick

    End Sub
End Class
