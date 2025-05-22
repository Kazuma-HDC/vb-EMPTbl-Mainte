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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'オープン
        Connection.Open()


        SQLStrings = "SELECT * FROM EMP ORDER BY DEPTNO"

        'DataSetの初期化
        DSet.Clear()

        'SQLの実行
        Dim DAdapter As New System.Data.Odbc.OdbcDataAdapter(SQLStrings, Connection)
        DAdapter.Fill(DSet, "EMP")

        'DataGridViewへの表示
        DataGridView1.DataSource = DSet.Tables("EMP")

        'DataGridViewの行数取得
        DV1Rows = DataGridView1.Rows.Count



        'クローズ
        Connection.Close()


        '列見出しの設定
        DataGridView1.Columns(0).HeaderText = "EMPNO"
        DataGridView1.Columns(1).HeaderText = "ENAME"
        DataGridView1.Columns(2).HeaderText = "JOB"
        DataGridView1.Columns(3).HeaderText = "MGR"
        DataGridView1.Columns(4).HeaderText = "HIREDATE"
        DataGridView1.Columns(5).HeaderText = "SAL"
        DataGridView1.Columns(6).HeaderText = "COMM"
        DataGridView1.Columns(7).HeaderText = "DEPTNO"
    End Sub
End Class