Public Class frmquanlyhanghoa

    Dim data As New class_data()

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub loaddata()
        data.getdata("select * from SanPham")
        Dim dt As DataTable = data.laydulieu()
        dgr_HangHoa.DataSource = dt
    End Sub



    Private Sub btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        Dim ten As String = txt_tensp.Text
        Dim soluong As String = txt_soluong.Text
        Dim donvitinh As String = txt_donvi.Text
        Dim gianhap As String = txt_gianhap.Text
        Dim giaba As String = txt_giaban.Text
        Dim maloai As String = txt_maloaisp.Text
        Dim mota As String = txt_mota.Text
        data.execute("Insert into SanPham (TenSP,SoLuong,DonViTinh,GiaNhap,GiaBan,MaLoaiSP,MoTa) values (N'" + ten + "','" + soluong + "','" + donvitinh + "','" + gianhap + "','" + giaba + "','" + maloai + "',N'" + mota + "')")
        If data.staturs = "ok" Then

            MessageBox.Show("đã thêm thành công")
            loaddata()
        Else
            MessageBox.Show("không thành công")
        End If
    End Sub

    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        Dim vitri As Integer = dgr_HangHoa.CurrentCell.RowIndex
        Dim Idsanpham As Integer = Integer.Parse(dgr_HangHoa.Rows(vitri).Cells(0).Value.ToString)
        data.execute("delete from SanPham where idsanpham = " & Idsanpham)
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
        Dim vitri As Integer = dgr_HangHoa.CurrentCell.RowIndex
        Dim MaSanPham As Integer = Integer.Parse(dgr_HangHoa.Rows(vitri).Cells(0).Value.ToString)
        data.execute("update SanPham set TenSP = N'" & txt_tensp.Text & "',soluong='" & txt_soluong.Text & "',donvitinh='" & txt_donvi.Text & "',gianhap='" & txt_gianhap.Text & "',giaban='" & txt_giaban.Text & "',MaLoaiSP='" & txt_maloaisp.Text & "',mota=N'" & txt_mota.Text & "' where IDSanPham = '" & MaSanPham & "'")
        Dim status As String
        status = data.staturs
        If status.ToUpper() = "OK" Then
            MessageBox.Show("Đã Sửa Thành công")
            loaddata()
        Else
            MessageBox.Show(" Sửa không thành công")
        End If
    End Sub

    Private Sub dgr_HangHoa_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgr_HangHoa.CellClick
        Dim vitri As Integer = dgr_HangHoa.CurrentCell.RowIndex
        txt_idsanpham.Text = dgr_HangHoa.Rows(vitri).Cells(0).Value.ToString
        txt_tensp.Text = dgr_HangHoa.Rows(vitri).Cells(1).Value.ToString
        txt_soluong.Text = dgr_HangHoa.Rows(vitri).Cells(2).Value.ToString
        txt_donvi.Text = dgr_HangHoa.Rows(vitri).Cells(3).Value.ToString
        txt_gianhap.Text = dgr_HangHoa.Rows(vitri).Cells(4).Value.ToString
        txt_giaban.Text = dgr_HangHoa.Rows(vitri).Cells(5).Value.ToString
        txt_maloaisp.Text = dgr_HangHoa.Rows(vitri).Cells(6).Value.ToString
        txt_mota.Text = dgr_HangHoa.Rows(vitri).Cells(7).Value.ToString
    End Sub

    Private Sub dgr_HangHoa_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgr_HangHoa.CellContentClick

    End Sub
End Class