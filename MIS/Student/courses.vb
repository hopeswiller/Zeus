Imports System.Data.OleDb
Imports MIS.Login
Imports MIS.GV

Public Class courses
    Dim objCon As New OleDb.OleDbConnection
    Dim Config As Configuration.ConfigurationSettings
    Dim strConnection As String = Config.AppSettings("MyDBConnectionString")
    Dim dataAdapter As New OleDb.OleDbDataAdapter
    Dim dataset As New DataSet
    Dim sem
    Private Sub exitCourses_Click(sender As Object, e As EventArgs) Handles exitCourses.Click
        Me.Close()
    End Sub

    Private Sub sem1Check_OnChange(sender As Object, e As EventArgs) Handles sem1Check.OnChange
        If sem1Check.Checked Then
            sem2Check.Enabled = False
            sem = "1"
            Dim table = "Courses"

            dataset.Clear()
            strSQL = "Select * from " & table & " where Semester ='" & sem & "' "
            dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
            dataAdapter.Fill(dataset, "Database1") ' number of items in the query

        Else
            sem2Check.Enabled = True

        End If
    End Sub

    Private Sub sem2Check_OnChange(sender As Object, e As EventArgs) Handles sem2Check.OnChange
        If sem2Check.Checked Then
            sem1Check.Enabled = False
            sem = "2"
            Dim table = "Courses"

            dataset.Clear()
            strSQL = "Select * from " & table & " where Semester ='" & sem & "' "
            dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
            dataAdapter.Fill(dataset, "Database1")

        Else
            sem1Check.Enabled = True

        End If
    End Sub

    Private Sub courses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartPosition = FormStartPosition.CenterScreen

        objCon.ConnectionString = strConnection
        If objCon.State = ConnectionState.Closed Then
            objCon.Open()
        Else
            objCon.Close()
            MsgBox("failed")
        End If

        Label1.Text = "Check a semester and filter the courses" + vbNewLine + "displayed by department and only" + vbNewLine + "the courses available to your level" + vbNewLine +
            "is displayed below"

        dataset.Clear()
        strSQL = "Select * from courses where Level ='" & level & "'"
        dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
        Dim a = dataAdapter.Fill(dataset, "Database1")
        'MsgBox(a.ToString)
        Dim r = dataset.Tables("Database1").Rows.Count
        listbox.Items.Clear()

        For i = 0 To (r - 1)
            c = dataset.Tables("Database1").Rows(i).Item("CourseName")
            co = dataset.Tables("Database1").Rows(i).Item(0)
            listbox.Items.Insert(i, c.ToString)
        Next

    End Sub

    Private Sub depts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles depts.SelectedIndexChanged
        Dim cscd = depts.Items.Item(13)
        Dim math = depts.Items.Item(12)
        Dim stat = depts.Items.Item(14)
        Dim ps = depts.Items.Item(9)
        Dim table = "Courses"

        '' selecting department stat and political science
        If depts.SelectedItem Is stat Or depts.SelectedItem Is ps Then
            Dim z1 = depts.SelectedItem
            If sem1Check.Checked Then
                sem = "1"

                dataset.Clear()
                strSQL = "Select * from " & table & " where Dept ='" & z1 & "' and Semester ='" & sem & "' and Level ='" & level & "'"
                dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
                Dim a = dataAdapter.Fill(dataset, "Database1")
                'MsgBox(a.ToString)
                Dim r = dataset.Tables("Database1").Rows.Count
                listbox.Items.Clear()

                For i = 0 To (r - 1)
                    c = dataset.Tables("Database1").Rows(i).Item(1)
                    co = dataset.Tables("Database1").Rows(i).Item(0)
                    listbox.Items.Insert(i, c.ToString)
                Next
            ElseIf sem2Check.Checked Then
                sem = "2"

                dataset.Clear()
                strSQL = "Select * from " & table & " where Dept ='" & z1 & "' and Semester ='" & sem & "' and Level ='" & level & "'"
                dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
                Dim a = dataAdapter.Fill(dataset, "Database1")
                'MsgBox(a.ToString)
                Dim r = dataset.Tables("Database1").Rows.Count
                listbox.Items.Clear()

                For i = 0 To (r - 1)
                    c = dataset.Tables("Database1").Rows(i).Item(1)
                    co = dataset.Tables("Database1").Rows(i).Item(0)
                    listbox.Items.Insert(i, c.ToString)
                Next
            Else
                listbox.Items.Clear()
                MsgBox("Please select a semester", MsgBoxStyle.Information)

            End If
        End If


        '' selecting department computer science and math
        If depts.SelectedItem = cscd Or depts.SelectedItem = math Then
            Dim z = depts.SelectedItem
            If sem1Check.Checked Then
                'MsgBox(z.ToString)
                sem = "1"

                dataset.Clear()
                strSQL = "Select * from " & table & " where Dept ='" & z & "' and Semester ='" & sem & "' and Level ='" & level & "'"
                dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
                Dim a = dataAdapter.Fill(dataset, "Database1")
                'MsgBox(a.ToString)
                Dim r = dataset.Tables("Database1").Rows.Count
                listbox.Items.Clear()

                For i = 0 To (r - 1)
                    c = dataset.Tables("Database1").Rows(i).Item(1)
                    co = dataset.Tables("Database1").Rows(i).Item(0)
                    listbox.Items.Insert(i, c.ToString)
                Next
            ElseIf sem2Check.Checked Then
                sem = "2"

                dataset.Clear()
                strSQL = "Select * from " & table & " where Dept ='" & z & "' and Semester ='" & sem & "' and Level ='" & level & "'"
                dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
                Dim a = dataAdapter.Fill(dataset, "Database1")
                'MsgBox(a.ToString)
                Dim r = dataset.Tables("Database1").Rows.Count
                listbox.Items.Clear()

                For i = 0 To (r - 1)
                    c = dataset.Tables("Database1").Rows(i).Item(1)
                    co = dataset.Tables("Database1").Rows(i).Item(0)
                    listbox.Items.Insert(i, c.ToString)
                Next

            Else
                listbox.Items.Clear()
                MsgBox("Please select a semester", MsgBoxStyle.Information)
            End If

        End If
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        'objCon.ConnectionString = strConnection
        If objCon.State = ConnectionState.Closed Then
            objCon.Open()
        End If


        Dim n = listbox2.Items.Count
        Dim arr(n) As String
        For i = 1 To n
            For Each item In listbox2.Items
                arr(i) = item
                strSQL = "Insert into RegCrs([Course],[IndexNo],[Dept]) values(?,?,?)"
                Dim cmd As New OleDbCommand(strSQL, objCon)
                cmd.Parameters.Add(New OleDbParameter("Course", arr(i)))
                cmd.Parameters.Add(New OleDbParameter("IndexNo", CType(id, String)))
                cmd.Parameters.Add(New OleDbParameter("Dept", CType(depts.SelectedItem, String)))

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                Catch ex As Exception

                End Try
            Next
        Next
        MsgBox("Course Registration successful.")
        Dim ans = MsgBox(" Would you like to clear the courses ", MsgBoxStyle.YesNo)
        If ans = vbYes Then
            listbox2.Items.Clear()
        End If
    End Sub

    Private Sub registerbtn_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        'gives the number of courses selected
        Dim v = listbox.CheckedItems.Count()

        For Each Item In listbox.CheckedItems
            While Not listbox2.Items.Contains(Item)
                listbox2.Items.Add(Item)

            End While
        Next
    End Sub

    Private Sub deleteCourses_Click(sender As Object, e As EventArgs) Handles deleteCourses.Click
        listbox2.Items.Remove(listbox2.SelectedItem)

    End Sub

    Private Sub listbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listbox.SelectedIndexChanged

    End Sub
End Class