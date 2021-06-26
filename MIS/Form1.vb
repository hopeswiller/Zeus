Imports System.Data.OleDb
Public Class FirstPage
    Dim objCon As New OleDb.OleDbConnection
    Dim Config As Configuration.ConfigurationSettings
    Dim strConnection As String = Config.AppSettings("MyDBConnectionString")
    Dim dataAdapter As New OleDb.OleDbDataAdapter
    Dim dataset As New DataSet

    Private Sub FirstPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterParent

        objCon.ConnectionString = strConnection

        If objCon.State = ConnectionState.Closed Then
            objCon.Open()
        Else
            objCon.Close()
            MsgBox("failed")
        End If

    End Sub
    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Dim out As String
        out = MsgBox("Please confirm leaving the system", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "System shutdown")
        If out = vbYes Then
            MsgBox("System is closed", MsgBoxStyle.Information)
            Application.Exit()
        ElseIf out = vbNo Then
            MsgBox("System stands by for next instruction", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub getStat_Click(sender As Object, e As EventArgs) Handles getStat.Click
        Me.Hide()
        Dim Login As New Login
        Login.Show()
    End Sub


End Class