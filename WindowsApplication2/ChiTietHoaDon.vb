Public Class frm_chitiethd
    Dim data As New class_data()
    Private Sub frm_chitiethd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Private Sub loaddata()
        Data.getdata("select * from ChiTietHoaDon")
        Dim dt As DataTable = data.laydulieu()
        dgr_chitiethd.DataSource = dt
    End Sub

    Private Sub btn_them_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_them.Click
        Dim status As String

        data.execute("Insert into ChiTietHoaDon (MaHD,IDSanPham,SoLuong,ThanhTien,GhiChu) values ('" + txt_MaHD.Text + "','" + txt_IDsanpham.Text + "','" + txt_soluong.Text + "','" + txt_thanhtien.Text + "',N'" + txt_ghichu.Text + "')")
        status = data.staturs
        If status = "ok" Then
            MessageBox.Show("Thêm dữ liệu thành công")
            loaddata()
        Else
            MessageBox.Show("không thành công")
        End If
    End Sub

    Private Sub btn_xoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_xoa.Click
        Dim vitri As Integer = dgr_chitiethd.CurrentCell.RowIndex
        Dim MaChitiethd As Integer = Integer.Parse(dgr_chitiethd.Rows(vitri).Cells(0).Value.ToString)
        data.execute("delete from ChiTietHoaDon where MaChitietHD = " & MaChitiethd)
        Dim status As String
        status = data.staturs
        If status.ToUpper() = "OK" Then
            MessageBox.Show("Đã Xóa Thành công")
            loaddata()
        Else
            MessageBox.Show("không thành công")
        End If
    End Sub

    Private Sub dgr_chitiethd_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgr_chitiethd.CellClick
        Dim vitri As Integer = dgr_chitiethd.CurrentCell.RowIndex
        txt_maCTHD.Text = dgr_chitiethd.Rows(vitri).Cells(0).Value.ToString
        txt_MaHD.Text = dgr_chitiethd.Rows(vitri).Cells(1).Value.ToString
        txt_IDsanpham.Text = dgr_chitiethd.Rows(vitri).Cells(2).Value.ToString
        txt_soluong.Text = dgr_chitiethd.Rows(vitri).Cells(3).Value.ToString
        txt_thanhtien.Text = dgr_chitiethd.Rows(vitri).Cells(4).Value.ToString
        txt_ghichu.Text = dgr_chitiethd.Rows(vitri).Cells(5).Value.ToString
    End Sub

    Private Sub btn_sua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sua.Click
        data.execute("update ChiTietHoaDon set MaHD='" & txt_MaHD.Text & "',IDSanPham='" & txt_IDsanpham.Text & "',SoLuong='" & txt_soluong.Text & "',ThanhTien='" & txt_thanhtien.Text & "',GhiChu=N'" & txt_ghichu.Text & "' where MaChiTietHD = '" & txt_maCTHD.Text & "'")
        Dim status As String = ""
        status = data.staturs
        If status = "ok" Then
            MessageBox.Show("Đã Sửa Thành công")
            loaddata()
        Else
            MessageBox.Show(" Sửa không thành công")
        End If
    End Sub
End Class