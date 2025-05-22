Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class FrmEMPlns

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Connection As New MySqlConnection
        Dim Command As MySqlCommand
        Dim DataReader As MySqlDataReader
        Dim EMPNO As Integer = TextBox1.Text     '社員番号
        Dim EName As String = TextBox2.Text '社員名
        Dim JOB As String = TextBox3.Text
        Dim MGR As Integer = TextBox4.Text
        Dim HIREDATE As String = TextBox5.Text
        Dim SAL As Integer = TextBox6.Text
        Dim COMM As Integer = TextBox7.Text
        Dim DEPTNO As Integer = TextBox8.Text

    End Sub
End Class