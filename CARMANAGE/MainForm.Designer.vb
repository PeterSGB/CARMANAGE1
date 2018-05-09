<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.派车管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新建派车单ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.管理派车单ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.车辆管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.油卡管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.人员管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.车辆管理ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.限号管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.油卡管理ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.加油信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.充值信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.人员管理ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.派车管理ToolStripMenuItem, Me.车辆管理ToolStripMenuItem, Me.油卡管理ToolStripMenuItem, Me.人员管理ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1024, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '派车管理ToolStripMenuItem
        '
        Me.派车管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新建派车单ToolStripMenuItem, Me.管理派车单ToolStripMenuItem})
        Me.派车管理ToolStripMenuItem.Name = "派车管理ToolStripMenuItem"
        Me.派车管理ToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.派车管理ToolStripMenuItem.Text = "派车管理"
        '
        '新建派车单ToolStripMenuItem
        '
        Me.新建派车单ToolStripMenuItem.Name = "新建派车单ToolStripMenuItem"
        Me.新建派车单ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.新建派车单ToolStripMenuItem.Text = "新建派车单"
        '
        '管理派车单ToolStripMenuItem
        '
        Me.管理派车单ToolStripMenuItem.Name = "管理派车单ToolStripMenuItem"
        Me.管理派车单ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.管理派车单ToolStripMenuItem.Text = "管理派车单"
        '
        '车辆管理ToolStripMenuItem
        '
        Me.车辆管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.车辆管理ToolStripMenuItem1, Me.限号管理ToolStripMenuItem})
        Me.车辆管理ToolStripMenuItem.Name = "车辆管理ToolStripMenuItem"
        Me.车辆管理ToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.车辆管理ToolStripMenuItem.Text = "车辆管理"
        '
        '油卡管理ToolStripMenuItem
        '
        Me.油卡管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.油卡管理ToolStripMenuItem1, Me.加油信息ToolStripMenuItem, Me.充值信息ToolStripMenuItem})
        Me.油卡管理ToolStripMenuItem.Name = "油卡管理ToolStripMenuItem"
        Me.油卡管理ToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.油卡管理ToolStripMenuItem.Text = "油卡管理"
        '
        '人员管理ToolStripMenuItem
        '
        Me.人员管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.人员管理ToolStripMenuItem1})
        Me.人员管理ToolStripMenuItem.Name = "人员管理ToolStripMenuItem"
        Me.人员管理ToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.人员管理ToolStripMenuItem.Text = "人员管理"
        '
        '车辆管理ToolStripMenuItem1
        '
        Me.车辆管理ToolStripMenuItem1.Name = "车辆管理ToolStripMenuItem1"
        Me.车辆管理ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.车辆管理ToolStripMenuItem1.Text = "车辆管理"
        '
        '限号管理ToolStripMenuItem
        '
        Me.限号管理ToolStripMenuItem.Name = "限号管理ToolStripMenuItem"
        Me.限号管理ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.限号管理ToolStripMenuItem.Text = "限号管理"
        '
        '油卡管理ToolStripMenuItem1
        '
        Me.油卡管理ToolStripMenuItem1.Name = "油卡管理ToolStripMenuItem1"
        Me.油卡管理ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.油卡管理ToolStripMenuItem1.Text = "油卡管理"
        '
        '加油信息ToolStripMenuItem
        '
        Me.加油信息ToolStripMenuItem.Name = "加油信息ToolStripMenuItem"
        Me.加油信息ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.加油信息ToolStripMenuItem.Text = "加油信息"
        '
        '充值信息ToolStripMenuItem
        '
        Me.充值信息ToolStripMenuItem.Name = "充值信息ToolStripMenuItem"
        Me.充值信息ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.充值信息ToolStripMenuItem.Text = "充值信息"
        '
        '人员管理ToolStripMenuItem1
        '
        Me.人员管理ToolStripMenuItem1.Name = "人员管理ToolStripMenuItem1"
        Me.人员管理ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.人员管理ToolStripMenuItem1.Text = "人员管理"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 623)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "车辆管理程序"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 派车管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 车辆管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 油卡管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 人员管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新建派车单ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 管理派车单ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 车辆管理ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 限号管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 油卡管理ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 加油信息ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 充值信息ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 人员管理ToolStripMenuItem1 As ToolStripMenuItem
End Class
