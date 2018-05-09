Public Class NewCarOutForm
    Private Sub CarOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“CarManageDataSet.CarInfo”中。您可以根据需要移动或删除它。
        Me.CarInfoTableAdapter.Fill(Me.CarManageDataSet.CarInfo)
        'TODO: 这行代码将数据加载到表“CarManageDataSet.ManInfo”中。您可以根据需要移动或删除它。
        Me.ManInfoTableAdapter.Fill(Me.CarManageDataSet.ManInfo)
        Me.MdiParent = MainForm
        Resettextinput()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Resettextinput()
    End Sub

    Private Sub Resettextinput()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = "8:30:00"
        TextBox2.Text = "17:30:00"
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Sqbm As String
        Sqbm = ManInfoTableAdapter.FindManKSbyManID(ComboBox1.SelectedValue)
        'MsgBox(Sqbm)

        Dim newrow = CarManageDataSet.CarOutInfo.NewRow

        newrow("ManID") = ComboBox1.SelectedValue
        newrow("CarOutRQ") = DateTimePicker1.Value.ToShortDateString
        newrow("CarOutOUT") = TextBox1.Text
        newrow("CarOutCOME") = TextBox2.Text
        newrow("CarID") = ComboBox2.SelectedValue
        newrow("CarOutQX") = TextBox3.Text
        newrow("CarOutLY") = TextBox4.Text
        newrow("CarOutBZ") = TextBox5.Text

        CarManageDataSet.CarOutInfo.Rows.Add（newrow)

        Try
            Me.Validate()
            CarOutInfoTableAdapter.Update(CarManageDataSet.CarOutInfo)
            MsgBox("保存成功")
            Resettextinput()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("新增失败")
        End Try


    End Sub


End Class