Imports MIS.GV
Imports MIS.Login
Imports System.Data.OleDb
Public Class classlist
    Dim objCon As New OleDb.OleDbConnection
    Dim strSQL As String
    Dim Config As Configuration.ConfigurationSettings
    Dim strConnection As String = Config.AppSettings("MyDBConnectionString")
    Dim dataAdapter As New OleDb.OleDbDataAdapter
    Dim dataset As New DataSet
    Dim attempt As Integer = 0

    Private Sub clist_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub crs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles crs2.SelectedIndexChanged
        Dim z = crs2.SelectedItem

        dataset.Clear()
        strSQL = "Select IndexNo from RegCrs where Course = '" & z & "'"
        dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
        Dim a2 = dataAdapter.Fill(dataset, "Database1")
        Dim r2 = dataset.Tables("Database1").Rows.Count

        ListBox1.Items.Clear()
        For i = 0 To (r2 - 1)
            h = dataset.Tables("Database1").Rows(i).Item(0)
            ListBox1.Items.Insert(i, h.ToString)

        Next
    End Sub

    Private Sub classlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartPosition = FormStartPosition.CenterScreen
        objCon.ConnectionString = strConnection
        If objCon.State = ConnectionState.Closed Then
            objCon.Open()
        Else
            objCon.Close()
            MsgBox("failed")
        End If

        dataset.Clear()
        strSQL = "Select Course from Staff_Courses where StaffID = '" & id & "'"
        dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
        Dim a2 = dataAdapter.Fill(dataset, "Database1")
        Dim r2 = dataset.Tables("Database1").Rows.Count
        crs2.Items.Clear()

        For i = 0 To (r2 - 1)
            co = dataset.Tables("Database1").Rows(i).Item(0)
            crs2.Items.Insert(i, co.ToString)
            While Not crs2.Items.Contains(co)
                crs2.Items.Insert(i, co.ToString)
            End While
        Next
    End Sub

    Private Sub exitProof_Click(sender As Object, e As EventArgs) Handles exitProof.Click
        Me.Hide()
    End Sub
End Class