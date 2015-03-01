Public Class frmkhachhang

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_makhachhang.Click

    End Sub

    Dim data As New class_data
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub loaddata()
        Dim dt = New DataTable
        data.getdata("select * from KhachHang")
        dt = data.laydulieu
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Dim status As String
        Dim gt As String
        If cbxGT.Text = "Nam" Then
            gt = "True"
        Else
            gt = "False"
        End If
        data.execute("Insert into KhachHang (TenKhachHang,DiaChi,GioiTinh,SoDienThoai,LoaiKhachHang,GhiChu) values (N'" + txtTenKH.Text + "',N'" + txtDiaChi.Text + "','" + gt + "','" + txtSDT.Text + "',N'" + txtLoaiKH.Text + "',N'" + txtGhiChu.Text + "')")
        status = data.staturs
        If status = "ok" Then
            MessageBox.Show("Thêm dữ liệu thành công")
            loaddata()
        Else
            MessageBox.Show("không thành công")
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim vitri As Integer = DataGridView1.CurrentCell.RowIndex
        Dim maKH As Integer = Integer.Parse(DataGridView1.Rows(vitri).Cells(0).Value.ToString)
        data.execute("delete from khachhang where maKH = " & maKH)
        Dim status As String
        status = data.staturs
        If status.ToUpper() = "OK" Then
            MessageBox.Show("Đã Xóa Thành công")
            loaddata()
        Else
            MessageBox.Show("không thành công")
        End If
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Dim vitri As Integer = DataGridView1.CurrentCell.RowIndex
        Dim maKH As Integer = Integer.Parse(DataGridView1.Rows(vitri).Cells(0).Value.ToString)
        Dim gt As String
        If cbxGT.Text = "Nam" Then
            gt = "True"
        Else
            gt = "False"
        End If
        data.execute("update khachhang set tenkhachhang = N'" & txtTenKH.Text & "',Diachi = N'" & txtDiaChi.Text & "', gioitinh='" & gt & "', sodienthoai='" & txtSDT.Text & "', loaikhachhang = N'" & txtLoaiKH.Text & "', ghichu=N'" & txtGhiChu.Text & "' where maKH=" & maKH & "")
        Dim status As String
        status = data.staturs
        If status.ToUpper() = "OK" Then
            MessageBox.Show("Đã Sửa Thành công")
            loaddata()
        Else
            MessageBox.Show(" Sửa không thành công")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim vitri As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaKh.Text = DataGridView1.Rows(vitri).Cells(0).Value.ToString
        txtTenKH.Text = DataGridView1.Rows(vitri).Cells(1).Value.ToString
        txtDiaChi.Text = DataGridView1.Rows(vitri).Cells(2).Value.ToString
        txtSDT.Text = DataGridView1.Rows(vitri).Cells(4).Value.ToString
        cbxGT.Text = DataGridView1.Rows(vitri).Cells(3).Value.ToString
        txtLoaiKH.Text = DataGridView1.Rows(vitri).Cells(5).Value.ToString
        txtGhiChu.Text = DataGridView1.Rows(vitri).Cells(6).Value.ToString

    End Sub
End Class