Imports System.Data
Imports System.Data.SqlClient
Public Class class_data
    'Khai báo kết nối
    Dim con As New SqlConnection()
    'khai báo lấy dữ liệu
    Dim dt As DataTable
    Public Sub getdata(ByVal cmd As String)
        openconnect()
        Dim com As New SqlCommand(cmd, con)
        Dim da As New SqlDataAdapter(com)
        dt = New DataTable()
        da.Fill(dt)
        closeconnect()
    End Sub
    Public Function laydulieu() As DataTable
        Return dt
    End Function
    'mở kết nối
    Private Sub openconnect()
        con = New SqlConnection("Data Source=NhaNgheo-PC\SQLEXPRESS;Initial Catalog=QLSanPham_CSDL;Integrated Security=True")
        con.Open()
    End Sub
    'đóng kết nối
    Private Sub closeconnect()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub
    Public staturs = ""
    Public Sub execute(ByVal cmd As String)
        Try
            openconnect()
            Dim com As New SqlCommand(cmd, con)
            com.ExecuteNonQuery()
            closeconnect()
            staturs = "ok"
        Catch ex As Exception
            staturs = "error"
        End Try

    End Sub
End Class
