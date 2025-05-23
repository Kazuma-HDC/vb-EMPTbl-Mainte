<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEMPSel
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
        Me.dgvEMP = New System.Windows.Forms.DataGridView()
        Me.btnKensaku = New System.Windows.Forms.Button()
        CType(Me.dgvEMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEMP
        '
        Me.dgvEMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEMP.Location = New System.Drawing.Point(36, 84)
        Me.dgvEMP.Name = "dgvEMP"
        Me.dgvEMP.RowTemplate.Height = 21
        Me.dgvEMP.Size = New System.Drawing.Size(752, 273)
        Me.dgvEMP.TabIndex = 0
        '
        'btnKensaku
        '
        Me.btnKensaku.Location = New System.Drawing.Point(669, 403)
        Me.btnKensaku.Name = "btnKensaku"
        Me.btnKensaku.Size = New System.Drawing.Size(75, 23)
        Me.btnKensaku.TabIndex = 1
        Me.btnKensaku.Text = "検索"
        Me.btnKensaku.UseVisualStyleBackColor = True
        '
        'FrmEMPSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnKensaku)
        Me.Controls.Add(Me.dgvEMP)
        Me.Name = "FrmEMPSel"
        Me.Text = "社員検索"
        CType(Me.dgvEMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvEMP As DataGridView
    Friend WithEvents btnKensaku As Button
End Class
