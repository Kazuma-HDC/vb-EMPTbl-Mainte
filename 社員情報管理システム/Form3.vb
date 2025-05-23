Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient
Public Class FrmEMPlns

    Private Sub btnEMPlns_Click(sender As Object, e As EventArgs) Handles btnEMPIns.Click
        Dim Connection As New MySqlConnection
        Dim Command As MySqlCommand
        Dim DataReader As MySqlDataReader
        Dim EMPNO As Integer = txtEMPEmpno.Text     '社員番号
        Dim EName As String = txtEMPEname.Text '社員名
        Dim JOB As String = txtEMPJob.Text
        Dim MGR As Integer = txtEMPMgr.Text
        Dim HIREDATE As String = txtEMPHiredate.Text
        Dim SAL As Integer = txtEMPSal.Text
        Dim COMM As Integer = txtEMPComm.Text
        Dim DEPTNO As Integer = txtEMPDeptno.Text

        '接続文字列の設定
        Connection.ConnectionString = "Database=team;Data Source=localhost;User Id=root"

        'オープン
        Connection.Open()

        '削除
        Command = Connection.CreateCommand
        Command.CommandText = "INSERT INTO emp(EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO)" &
                              $" VALUES({EMPNO},'{EName}','{JOB}',{MGR},'{HIREDATE}',{SAL},{COMM},{DEPTNO})"
        'SQLを実行
        DataReader = Command.ExecuteReader

        'クローズ
        DataReader.Close()
        Connection.Close()

        'Dispose
        Command.Dispose()
        Connection.Dispose()

        MessageBox.Show("社員情報を追加しました")

    End Sub
End Class