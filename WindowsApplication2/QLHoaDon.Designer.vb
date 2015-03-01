<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_hoadon
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
        Me.dgr_HoaDon = New System.Windows.Forms.DataGridView()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.lb_mhd = New System.Windows.Forms.Label()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.lb_shd = New System.Windows.Forms.Label()
        Me.lb_ngaytaohd = New System.Windows.Forms.Label()
        Me.lb_Manv = New System.Windows.Forms.Label()
        Me.lb_makh = New System.Windows.Forms.Label()
        Me.lb_tongtien = New System.Windows.Forms.Label()
        Me.lb_ghichu = New System.Windows.Forms.Label()
        Me.txt_mahd = New System.Windows.Forms.TextBox()
        Me.txt_sohd = New System.Windows.Forms.TextBox()
        Me.txt_ngaytaohd = New System.Windows.Forms.TextBox()
        Me.txt_manv = New System.Windows.Forms.TextBox()
        Me.txt_makh = New System.Windows.Forms.TextBox()
        Me.txt_tongtien = New System.Windows.Forms.TextBox()
        Me.txt_ghichu = New System.Windows.Forms.TextBox()
        CType(Me.dgr_HoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgr_HoaDon
        '
        Me.dgr_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgr_HoaDon.Location = New System.Drawing.Point(12, 250)
        Me.dgr_HoaDon.Name = "dgr_HoaDon"
        Me.dgr_HoaDon.Size = New System.Drawing.Size(430, 188)
        Me.dgr_HoaDon.TabIndex = 0
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(346, 53)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 1
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'lb_mhd
        '
        Me.lb_mhd.AutoSize = True
        Me.lb_mhd.Location = New System.Drawing.Point(23, 22)
        Me.lb_mhd.Name = "lb_mhd"
        Me.lb_mhd.Size = New System.Drawing.Size(68, 13)
        Me.lb_mhd.TabIndex = 2
        Me.lb_mhd.Text = "Mã Hóa Đơn"
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(346, 91)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 3
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(346, 130)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 4
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'lb_shd
        '
        Me.lb_shd.AutoSize = True
        Me.lb_shd.Location = New System.Drawing.Point(23, 53)
        Me.lb_shd.Name = "lb_shd"
        Me.lb_shd.Size = New System.Drawing.Size(66, 13)
        Me.lb_shd.TabIndex = 5
        Me.lb_shd.Text = "Số Hóa Đơn"
        '
        'lb_ngaytaohd
        '
        Me.lb_ngaytaohd.AutoSize = True
        Me.lb_ngaytaohd.Location = New System.Drawing.Point(23, 83)
        Me.lb_ngaytaohd.Name = "lb_ngaytaohd"
        Me.lb_ngaytaohd.Size = New System.Drawing.Size(73, 13)
        Me.lb_ngaytaohd.TabIndex = 6
        Me.lb_ngaytaohd.Text = "Ngày Tạo HĐ"
        '
        'lb_Manv
        '
        Me.lb_Manv.AutoSize = True
        Me.lb_Manv.Location = New System.Drawing.Point(23, 114)
        Me.lb_Manv.Name = "lb_Manv"
        Me.lb_Manv.Size = New System.Drawing.Size(75, 13)
        Me.lb_Manv.TabIndex = 7
        Me.lb_Manv.Text = "Mã Nhân Viên"
        '
        'lb_makh
        '
        Me.lb_makh.AutoSize = True
        Me.lb_makh.Location = New System.Drawing.Point(23, 147)
        Me.lb_makh.Name = "lb_makh"
        Me.lb_makh.Size = New System.Drawing.Size(85, 13)
        Me.lb_makh.TabIndex = 8
        Me.lb_makh.Text = "Mã Khách Hàng"
        '
        'lb_tongtien
        '
        Me.lb_tongtien.AutoSize = True
        Me.lb_tongtien.Location = New System.Drawing.Point(23, 174)
        Me.lb_tongtien.Name = "lb_tongtien"
        Me.lb_tongtien.Size = New System.Drawing.Size(56, 13)
        Me.lb_tongtien.TabIndex = 9
        Me.lb_tongtien.Text = "Tổng Tiền"
        '
        'lb_ghichu
        '
        Me.lb_ghichu.AutoSize = True
        Me.lb_ghichu.Location = New System.Drawing.Point(23, 204)
        Me.lb_ghichu.Name = "lb_ghichu"
        Me.lb_ghichu.Size = New System.Drawing.Size(45, 13)
        Me.lb_ghichu.TabIndex = 10
        Me.lb_ghichu.Text = "Ghi Chú"
        '
        'txt_mahd
        '
        Me.txt_mahd.BackColor = System.Drawing.SystemColors.Control
        Me.txt_mahd.Location = New System.Drawing.Point(115, 20)
        Me.txt_mahd.Name = "txt_mahd"
        Me.txt_mahd.ReadOnly = True
        Me.txt_mahd.Size = New System.Drawing.Size(217, 20)
        Me.txt_mahd.TabIndex = 11
        '
        'txt_sohd
        '
        Me.txt_sohd.Location = New System.Drawing.Point(115, 49)
        Me.txt_sohd.Name = "txt_sohd"
        Me.txt_sohd.Size = New System.Drawing.Size(217, 20)
        Me.txt_sohd.TabIndex = 12
        '
        'txt_ngaytaohd
        '
        Me.txt_ngaytaohd.Location = New System.Drawing.Point(115, 79)
        Me.txt_ngaytaohd.Name = "txt_ngaytaohd"
        Me.txt_ngaytaohd.Size = New System.Drawing.Size(217, 20)
        Me.txt_ngaytaohd.TabIndex = 13
        '
        'txt_manv
        '
        Me.txt_manv.Location = New System.Drawing.Point(115, 108)
        Me.txt_manv.Name = "txt_manv"
        Me.txt_manv.Size = New System.Drawing.Size(217, 20)
        Me.txt_manv.TabIndex = 14
        '
        'txt_makh
        '
        Me.txt_makh.Location = New System.Drawing.Point(115, 140)
        Me.txt_makh.Name = "txt_makh"
        Me.txt_makh.Size = New System.Drawing.Size(217, 20)
        Me.txt_makh.TabIndex = 15
        '
        'txt_tongtien
        '
        Me.txt_tongtien.Location = New System.Drawing.Point(115, 170)
        Me.txt_tongtien.Name = "txt_tongtien"
        Me.txt_tongtien.Size = New System.Drawing.Size(217, 20)
        Me.txt_tongtien.TabIndex = 16
        '
        'txt_ghichu
        '
        Me.txt_ghichu.Location = New System.Drawing.Point(115, 197)
        Me.txt_ghichu.Name = "txt_ghichu"
        Me.txt_ghichu.Size = New System.Drawing.Size(217, 20)
        Me.txt_ghichu.TabIndex = 17
        '
        'frm_hoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 450)
        Me.Controls.Add(Me.txt_ghichu)
        Me.Controls.Add(Me.txt_tongtien)
        Me.Controls.Add(Me.txt_makh)
        Me.Controls.Add(Me.txt_manv)
        Me.Controls.Add(Me.txt_ngaytaohd)
        Me.Controls.Add(Me.txt_sohd)
        Me.Controls.Add(Me.txt_mahd)
        Me.Controls.Add(Me.lb_ghichu)
        Me.Controls.Add(Me.lb_tongtien)
        Me.Controls.Add(Me.lb_makh)
        Me.Controls.Add(Me.lb_Manv)
        Me.Controls.Add(Me.lb_ngaytaohd)
        Me.Controls.Add(Me.lb_shd)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.lb_mhd)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.dgr_HoaDon)
        Me.Name = "frm_hoadon"
        Me.Text = "Quản Lý Hóa Đơn"
        CType(Me.dgr_HoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgr_HoaDon As System.Windows.Forms.DataGridView
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents lb_mhd As System.Windows.Forms.Label
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents lb_shd As System.Windows.Forms.Label
    Friend WithEvents lb_ngaytaohd As System.Windows.Forms.Label
    Friend WithEvents lb_Manv As System.Windows.Forms.Label
    Friend WithEvents lb_makh As System.Windows.Forms.Label
    Friend WithEvents lb_tongtien As System.Windows.Forms.Label
    Friend WithEvents lb_ghichu As System.Windows.Forms.Label
    Friend WithEvents txt_mahd As System.Windows.Forms.TextBox
    Friend WithEvents txt_sohd As System.Windows.Forms.TextBox
    Friend WithEvents txt_ngaytaohd As System.Windows.Forms.TextBox
    Friend WithEvents txt_manv As System.Windows.Forms.TextBox
    Friend WithEvents txt_makh As System.Windows.Forms.TextBox
    Friend WithEvents txt_tongtien As System.Windows.Forms.TextBox
    Friend WithEvents txt_ghichu As System.Windows.Forms.TextBox
End Class
