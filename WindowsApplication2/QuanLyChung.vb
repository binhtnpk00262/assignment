Public Class frm_quanlychung

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LiênHệToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DịchVụToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DịchVụToolStripMenuItem.Click
        frm_Lienhe.ShowDialog()
    End Sub

    Private Sub ThaoTácToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThaoTácToolStripMenuItem.Click
        frmquanlyhanghoa.ShowDialog()
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        frm_chitiethd.ShowDialog()
    End Sub

    Private Sub HỗTrợToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HỗTrợToolStripMenuItem.Click
        frmkhachhang.ShowDialog()
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        frm_hoadon.ShowDialog()
    End Sub
End Class