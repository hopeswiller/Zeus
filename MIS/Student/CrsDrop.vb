Imports MIS.GV
Imports MIS.Login
Imports System.Data.OleDb
Public Class CrsDrop
    Dim objCon As New OleDb.OleDbConnection
    Dim Config As Configuration.ConfigurationSettings
    Dim strConnection As String = Config.AppSettings("MyDBConnectionString")
    Dim dataAdapter As New OleDb.OleDbDataAdapter
    Dim dataset As New DataSet
    Dim sem
    Private Sub listbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listbox.SelectedIndexChanged

    End Sub

    Private Sub CrsDrop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartPosition = FormStartPosition.CenterScreen
        objCon.ConnectionString = strConnection
        If objCon.State = ConnectionState.Closed Then
            objCon.Open()
        Else
            objCon.Close()
            MsgBox("failed")
        End If

        qualif.Text = "This section allows you to drop a registered course " + vbNewLine + "Note a course is dropped, it cannot be registered again "

        table = "RegCrs"

        dataset.Clear()
        strSQL = "Select Course,Dept from " & table & " where IndexNo ='" & id & "' "
        dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
        Dim a = dataAdapter.Fill(dataset, "Database1")
        'MsgBox(a.ToString)
        Dim r = dataset.Tables("Database1").Rows.Count

        For i = 0 To (r - 1)
            co = dataset.Tables("Database1").Rows(i).Item(0)
            c = dataset.Tables("Database1").Rows(i).Item(1)
            listbox.Items.Insert(i, co.ToString)
        Next
    End Sub

    Private Sub dpbtn_Click(sender As Object, e As EventArgs) Handles dpbtn.Click
        'gives the number of courses selected
        Dim v = listbox.CheckedItems.Count()

        For Each Item In listbox.CheckedItems
            While Not listbox2.Items.Contains(Item)
                listbox2.Items.Add(Item)
            End While
        Next

        If listbox.Items.Count() = 0 Then
            MsgBox("you have not registered for any course yet")
            Me.Close()
        End If

    End Sub

    Private Sub exitCourses_Click(sender As Object, e As EventArgs) Handles exitCourses.Click
        ''StudentDashboard.StartPosition = FormStartPosition.CenterScreen
        Me.Close()
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        If objCon.State = ConnectionState.Closed Then
            objCon.Open()
        End If

        Dim n = listbox2.Items.Count
        Dim arr(n) As String
        For i = 1 To n
            For Each item In listbox2.Items
                arr(i) = item
                strSQL = "Delete * from RegCrs where IndexNo = '" & id & "' and Course= '" & arr(i) & "'"
                Dim cmd As New OleDb.OleDbCommand(strSQL, objCon)
                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
        Next
        MsgBox("Course has been dropped successful.")


        listbox2.Items.Clear()


    End Sub
End Class