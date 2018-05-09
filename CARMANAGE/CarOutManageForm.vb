Public Class CarOutManageForm
    Private Sub CarOutManageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“CarManageDataSet.CarOutInfo”中。您可以根据需要移动或删除它。
        Me.CarOutInfoTableAdapter.Fill(Me.CarManageDataSet.CarOutInfo)
        Me.MdiParent = MainForm

    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PCDExcelPrint()
        GC.Collect()
    End Sub

    Private Sub PCDExcelPrint()
        Dim ManKS, ManXM, CarPZ, ManDH As String

        ManKS = ManInfoTableAdapter.FindManKSbyManID(CarOutInfoDataGridView.SelectedRows.Item(0).Cells(1).Value)
        'ManXM = ManInfoTableAdapter.FindManXMbyManID(CarOutInfoDataGridView.SelectedRows.Item(0).Cells(1).Value)
        'CarPZ = CarInfoTableAdapter.FindCarPZbyCarID(CarOutInfoDataGridView.SelectedRows.Item(0).Cells(5).Value)
        ManDH = ManInfoTableAdapter.FindManDHbyManID(CarOutInfoDataGridView.SelectedRows.Item(0).Cells(1).Value)

        Dim ExcelApp As New Microsoft.Office.Interop.Excel.Application()

        Dim Book As Microsoft.Office.Interop.Excel.Workbook
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet
        Dim xlsPath As String

        xlsPath = My.Application.Info.DirectoryPath + "\派车单.xls"
        ExcelApp = New Microsoft.Office.Interop.Excel.Application

        ws = ExcelApp.Workbooks.Open(xlsPath).Worksheets("sheet1")

        ws.Cells(2, 2) = ManKS
        ws.Cells(2, 7) = ManKS

        ws.Cells(2, 4) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(2).Value
        ws.Cells(2, 9) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(2).Value

        ws.Cells(6, 4) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(2).Value
        ws.Cells(6, 9) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(2).Value

        ws.Cells(7, 4) = ManDH
        ws.Cells(7, 9) = ManDH

        ws.Cells(3, 4) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(3).Value
        ws.Cells(3, 9) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(3).Value

        ws.Cells(4, 4) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(4).Value
        ws.Cells(4, 9) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(4).Value

        ws.Cells(5, 4) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(5).Value
        ws.Cells(5, 9) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(5).Value

        ws.Cells(4, 4) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(4).Value
        ws.Cells(4, 9) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(4).Value

        ws.Cells(8, 2) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(7).Value
        ws.Cells(8, 7) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(7).Value

        ws.Cells(9, 2) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(8).Value
        ws.Cells(9, 7) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(8).Value

        ws.Cells(10, 2) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(9).Value
        ws.Cells(10, 7) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(9).Value

        ws.Cells(13, 2) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(10).Value
        ws.Cells(13, 7) = CarOutInfoDataGridView.SelectedRows.Item(0).Cells(10).Value

        ExcelApp.Visible = False
        ws.PrintOutEx()
        ExcelApp.DisplayAlerts = False
        ExcelApp.Quit()

        ExcelApp = Nothing
        Book = Nothing
        MsgBox("派车单打印成功")
    End Sub



    Private Sub DisplayManXMinDatagridview()
        For i = 0 To CarOutInfoDataGridView.Rows.Count - 1
            CarOutInfoDataGridView.Rows(i).Cells(2).Value = ManInfoTableAdapter.FindManXMbyManID(CarOutInfoDataGridView.Rows(i).Cells(1).Value)
        Next
    End Sub
    Private Sub DisplayCarPZinDatagridview()
        For i = 0 To CarOutInfoDataGridView.Rows.Count - 1
            CarOutInfoDataGridView.Rows(i).Cells(7).Value = CarInfoTableAdapter.FindCarPZbyCarID(CarOutInfoDataGridView.Rows(i).Cells(6).Value)
        Next
    End Sub

    Private Sub CarOutInfoDataGridView_Paint(sender As Object, e As PaintEventArgs) Handles CarOutInfoDataGridView.Paint
        DisplayManXMinDatagridview()
        DisplayCarPZinDatagridview()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

    End Sub

    Private Sub DelButton_Click(sender As Object, e As EventArgs) Handles DelButton.Click
        Dim DelRowID As Integer
        If CarOutInfoDataGridView.SelectedRows.Count > 0 Then
            If MessageBox.Show("确定要删除选择的行吗？删除后将不可恢复！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                DelRowID = CarOutInfoDataGridView.SelectedRows.Item(0).Index
                CarManageDataSet.CarOutInfo.Rows(DelRowID).Delete()
                Try
                    CarOutInfoTableAdapter.Update(CarManageDataSet.CarOutInfo)
                    MsgBox("删除成功")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

        End If
    End Sub
End Class