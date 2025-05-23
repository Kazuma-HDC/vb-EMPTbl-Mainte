<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEMPlns
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEMPEmpno = New System.Windows.Forms.TextBox()
        Me.txtEMPEname = New System.Windows.Forms.TextBox()
        Me.txtEMPJob = New System.Windows.Forms.TextBox()
        Me.txtEMPMgr = New System.Windows.Forms.TextBox()
        Me.txtEMPHiredate = New System.Windows.Forms.TextBox()
        Me.txtEMPSal = New System.Windows.Forms.TextBox()
        Me.txtEMPComm = New System.Windows.Forms.TextBox()
        Me.txtEMPDeptno = New System.Windows.Forms.TextBox()
        Me.btnEMPIns = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "社員番号:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "従業員名:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "仕事:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "マネージャー:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "採用年月日"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(88, 398)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "給料"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(88, 459)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 12)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "歩合給"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(88, 518)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "部署番号"
        '
        'txtEMPEmpno
        '
        Me.txtEMPEmpno.Location = New System.Drawing.Point(208, 97)
        Me.txtEMPEmpno.Name = "txtEMPEmpno"
        Me.txtEMPEmpno.Size = New System.Drawing.Size(100, 19)
        Me.txtEMPEmpno.TabIndex = 8
        '
        'txtEMPEname
        '
        Me.txtEMPEname.Location = New System.Drawing.Point(208, 168)
        Me.txtEMPEname.Name = "txtEMPEname"
        Me.txtEMPEname.Size = New System.Drawing.Size(100, 19)
        Me.txtEMPEname.TabIndex = 9
        '
        'txtEMPJob
        '
        Me.txtEMPJob.Location = New System.Drawing.Point(208, 225)
        Me.txtEMPJob.Name = "txtEMPJob"
        Me.txtEMPJob.Size = New System.Drawing.Size(100, 19)
        Me.txtEMPJob.TabIndex = 10
        '
        'txtEMPMgr
        '
        Me.txtEMPMgr.Location = New System.Drawing.Point(208, 281)
        Me.txtEMPMgr.Name = "txtEMPMgr"
        Me.txtEMPMgr.Size = New System.Drawing.Size(100, 19)
        Me.txtEMPMgr.TabIndex = 11
        '
        'txtEMPHiredate
        '
        Me.txtEMPHiredate.Location = New System.Drawing.Point(208, 333)
        Me.txtEMPHiredate.Name = "txtEMPHiredate"
        Me.txtEMPHiredate.Size = New System.Drawing.Size(100, 19)
        Me.txtEMPHiredate.TabIndex = 12
        '
        'txtEMPSal
        '
        Me.txtEMPSal.Location = New System.Drawing.Point(208, 391)
        Me.txtEMPSal.Name = "txtEMPSal"
        Me.txtEMPSal.Size = New System.Drawing.Size(100, 19)
        Me.txtEMPSal.TabIndex = 13
        '
        'txtEMPComm
        '
        Me.txtEMPComm.Location = New System.Drawing.Point(208, 452)
        Me.txtEMPComm.Name = "txtEMPComm"
        Me.txtEMPComm.Size = New System.Drawing.Size(100, 19)
        Me.txtEMPComm.TabIndex = 14
        '
        'txtEMPDeptno
        '
        Me.txtEMPDeptno.Location = New System.Drawing.Point(208, 515)
        Me.txtEMPDeptno.Name = "txtEMPDeptno"
        Me.txtEMPDeptno.Size = New System.Drawing.Size(100, 19)
        Me.txtEMPDeptno.TabIndex = 15
        '
        'btnEMPIns
        '
        Me.btnEMPIns.Location = New System.Drawing.Point(233, 600)
        Me.btnEMPIns.Name = "btnEMPIns"
        Me.btnEMPIns.Size = New System.Drawing.Size(75, 23)
        Me.btnEMPIns.TabIndex = 16
        Me.btnEMPIns.Text = "追加"
        Me.btnEMPIns.UseVisualStyleBackColor = True
        '
        'FrmEMPlns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 650)
        Me.Controls.Add(Me.btnEMPIns)
        Me.Controls.Add(Me.txtEMPDeptno)
        Me.Controls.Add(Me.txtEMPComm)
        Me.Controls.Add(Me.txtEMPSal)
        Me.Controls.Add(Me.txtEMPHiredate)
        Me.Controls.Add(Me.txtEMPMgr)
        Me.Controls.Add(Me.txtEMPJob)
        Me.Controls.Add(Me.txtEMPEname)
        Me.Controls.Add(Me.txtEMPEmpno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmEMPlns"
        Me.Text = "社員追加"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEMPEmpno As TextBox
    Friend WithEvents txtEMPEname As TextBox
    Friend WithEvents txtEMPJob As TextBox
    Friend WithEvents txtEMPMgr As TextBox
    Friend WithEvents txtEMPHiredate As TextBox
    Friend WithEvents txtEMPSal As TextBox
    Friend WithEvents txtEMPComm As TextBox
    Friend WithEvents txtEMPDeptno As TextBox
    Friend WithEvents btnEMPIns As Button
End Class
