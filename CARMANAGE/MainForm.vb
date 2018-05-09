Public Class MainForm
    Private Sub 派车管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 派车管理ToolStripMenuItem.Click

    End Sub

    Private Sub 新建派车单ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新建派车单ToolStripMenuItem.Click
        NewCarOutForm.Show()
    End Sub

    Private Sub 管理派车单ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 管理派车单ToolStripMenuItem.Click
        CarOutManageForm.Show()
    End Sub

    Private Sub 车辆管理ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 车辆管理ToolStripMenuItem1.Click
        CarManageForm.Show()
    End Sub

    Private Sub 人员管理ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 人员管理ToolStripMenuItem1.Click
        ManManageForm.Show()
    End Sub

    Private Sub 油卡管理ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 油卡管理ToolStripMenuItem1.Click
        OilCardManageForm.Show()
    End Sub
End Class
