Imports MIS.GV
Imports MIS.Login
Imports System.Data.OleDb
Public Class CourseHandle
    Dim objCon As New OleDb.OleDbConnection
    Dim Config As Configuration.ConfigurationSettings
    Dim strConnection As String = Config.AppSettings("MyDBConnectionString")
    Dim dataAdapter As New OleDb.OleDbDataAdapter
    Dim dataset As New DataSet
    Dim sem
    Private Sub exitCourses_Click(sender As Object, e As EventArgs) Handles exitCourses.Click
        Me.Hide()
    End Sub

    Private Sub Toright_Click(sender As Object, e As EventArgs) Handles ToRight.Click
        'gives the number of courses selected
        Dim v = listbox.CheckedItems.Count()

        For Each Item In listbox.CheckedItems
            While Not listbox2.Items.Contains(Item)
                listbox2.Items.Add(Item)
            End While
        Next

        If listbox.Items.Count() = 0 Then
            MsgBox("Please, you are not handling any course this semester")
            Me.Close()
        End If

    End Sub

    Private Sub CourseHandle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartPosition = FormStartPosition.CenterScreen
        objCon.ConnectionString = strConnection
        If objCon.State = ConnectionState.Closed Then
            objCon.Open()
        Else
            objCon.Close()
            MsgBox("failed")
        End If

        table = "Courses"
        sem = semSelected

        If sem = "1" Then
            sem1Check.Checked = True
            sem2Check.Checked = False
        ElseIf sem = "2" Then
            sem2Check.Checked = True
            sem1Check.Checked = False
        End If

        deptName.Text = dept + " Courses for the semester"

        dataset.Clear()
        strSQL = "Select CourseName,Dept,Semester from " & table & " where Dept ='" & dept & "' and Semester = '" & sem & "' "
        dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
        Dim a = dataAdapter.Fill(DataSet, "Database1")
        'MsgBox(a.ToString)
        Dim r = DataSet.Tables("Database1").Rows.Count

        For i = 0 To (r - 1)
            co = dataset.Tables("Database1").Rows(i).Item(0)
            listbox.Items.Insert(i, co.ToString)
        Next

    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        If objCon.State = ConnectionState.Closed Then
            objCon.Open()
        End If

        If listbox2.Items.Count = 0 Then
            MsgBox("Please select a Course")

        Else
            Dim n = listbox2.Items.Count
            Dim arr(n) As String
            For i = 1 To n
                For Each item In listbox2.Items
                    arr(i) = item
                    strSQL = "Insert into Staff_Courses([Course],[StaffID]) values(?,?)"
                    Dim cmd As New OleDbCommand(strSQL, objCon)
                    cmd.Parameters.Add(New OleDbParameter("Course", arr(i)))
                    cmd.Parameters.Add(New OleDbParameter("StaffID", CType(id, String)))

                    Try
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                    Catch ex As Exception
                        'MsgBox("A course selected is already handled by one of your fellow lecturers")
                    End Try
                Next
            Next
            MsgBox("Thanks for your cooperation ", MsgBoxStyle.OkOnly)
        End If

    End Sub

    Private Sub bks_Click(sender As Object, e As EventArgs) Handles bks.Click
        listbox2.Items.Clear()
    End Sub

End Class