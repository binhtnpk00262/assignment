Public Class frm_hoadon
    Dim data As New class_data()
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgr_HoaDon.CellContentClick


    End Sub

    Private Sub frm_hoadon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()

    End Sub
    Private Sub loaddata()
        data.getdata("select * from HoaDon")
        Dim dt As DataTable = data.laydulieu()
        dgr_HoaDon.DataSource = dt

    End Sub

    Private Sub btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        Dim status As String
        
        data.execute("Insert into Hoadon (SoHoaDon,NgayTaoHD,MaNhanVien,MaKhachHang,TongTien,GhiChu) values ('" + txt_sohd.Text + "','" + txt_ngaytaohd.Text + "','" + txt_manv.Text + "','" + txt_makh.Text + "','" + txt_tongtien.Text + "',N'" + txt_ghichu.Text + "')")
        status = data.staturs
        If status = "ok" Then
            MessageBox.Show("Thêm dữ liệu thành công")
            loaddata()
        Else
            MessageBox.Show("không thành công")
        End If
    End Sub

    Private Sub dgr_HoaDon_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgr_HoaDon.CellClick
        Dim vitri As Integer = dgr_HoaDon.CurrentCell.RowIndex
        txt_mahd.Text = dgr_HoaDon.Rows(vitri).Cells(0).Value.ToString
        txt_sohd.Text = dgr_HoaDon.Rows(vitri).Cells(1).Value.ToString
        txt_ngaytaohd.Text = dgr_HoaDon.Rows(vitri).Cells(2).Value.ToString
        txt_manv.Text = dgr_HoaDon.Rows(vitri).Cells(3).Value.ToString
        txt_makh.Text = dgr_HoaDon.Rows(vitri).Cells(4).Value.ToString
        txt_tongtien.Text = dgr_HoaDon.Rows(vitri).Cells(5).Value.ToString
        txt_ghichu.Text = dgr_HoaDon.Rows(vitri).Cells(6).Value.ToString


    End Sub

    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        Dim vitri As Integer = dgr_HoaDon.CurrentCell.RowIndex
        Dim MaHD As Integer = Integer.Parse(dgr_HoaDon.Rows(vitri).Cells(0).Value.ToString)
        data.execute("delete from HoaDon where MaHD = " & MaHD)
        Dim status As String
        status = data.staturs
        If status.ToUpper() = "OK" Then
            MessageBox.Show("Đã Xóa Thành công")
            loaddata()
        Else
            MessageBox.Show("không thành công")
        End If
    End Sub

    Private Sub btnsua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsua.Click
        Dim id As String = txt_mahd.Text
        data.execute("update HoaDon set SoHoaDon = '" & txt_sohd.Text & "',NgayTaoHD='" & txt_ngaytaohd.Text & "',MaNhanVien='" & txt_manv.Text & "',MaKhachHang='" & txt_makh.Text & "',TongTien='" & txt_tongtien.Text & "',GhiChu=N'" & txt_ghichu.Text & "' where MaHD = '" & id & "'")
        Dim status As String
        status = data.staturs
        If status = "ok" Then
            MessageBox.Show("Đã Sửa Thành công")
            loaddata()
        Else
            MessageBox.Show(" Sửa không thành công")
        End If
    End Sub
End Class