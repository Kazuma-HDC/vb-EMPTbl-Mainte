Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class FrmEMPSel
    Dim DSet As New System.Data.DataSet
    Dim ConnectionString As String = "DRIVER={MySQL ODBC 8.4 ANSI Driver};SERVER=localhost;DATABASE=team;UID=root;OPTION=3"
    Dim Connection As New System.Data.Odbc.OdbcConnection(ConnectionString.ToString)
    Dim DV1Rows As Integer = 0
    Dim SQLStrings As String
    Private Sub btnKensaku_Click(sender As Object, e As EventArgs) Handles btnKensaku.Click
        'オープン
        Connection.Open()


        SQLStrings = "SELECT * FROM EMP ORDER BY DEPTNO"

        'DataSetの初期化
        DSet.Clear()

        'SQLの実行
        Dim DAdapter As New System.Data.Odbc.OdbcDataAdapter(SQLStrings, Connection)
        DAdapter.Fill(DSet, "EMP")

        'DataGridViewへの表示
        dgvEMP.DataSource = DSet.Tables("EMP")

        'DataGridViewの行数取得
        DV1Rows = dgvEMP.Rows.Count



        'クローズ
        Connection.Close()


        '列見出しの設定
        dgvEMP.Columns(0).HeaderText = "EMPNO"
        dgvEMP.Columns(1).HeaderText = "ENAME"
        dgvEMP.Columns(2).HeaderText = "JOB"
        dgvEMP.Columns(3).HeaderText = "MGR"
        dgvEMP.Columns(4).HeaderText = "HIREDATE"
        dgvEMP.Columns(5).HeaderText = "SAL"
        dgvEMP.Columns(6).HeaderText = "COMM"
        dgvEMP.Columns(7).HeaderText = "DEPTNO"
    End Sub
End Class