Imports System.Data.OleDb
Imports MIS.Login
Imports MIS.GV
Public Class Record
    Dim objCon As New OleDb.OleDbConnection
    Dim Config As Configuration.ConfigurationSettings
    Dim strConnection As String = Config.AppSettings("MyDBConnectionString")
    Dim dataAdapter As New OleDb.OleDbDataAdapter
    Dim dataset As New DataSet
    Dim sem
    Private Sub exitRecord_Click(sender As Object, e As EventArgs) Handles exitRecord.Click
        Me.Close()
    End Sub

    Private Sub Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartPosition = FormStartPosition.CenterScreen
        objCon.ConnectionString = strConnection
        If objCon.State = ConnectionState.Closed Then
            objCon.Open()
        Else
            objCon.Close()
            MsgBox("failed")
        End If

        dataset.Clear()
        strSQL = "Select Course,Grade from RegCrs where IndexNo = '" & id & "' "
        dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
        Dim a = dataAdapter.Fill(dataset, "Database1")
        Dim r = dataset.Tables("Database1").Rows.Count

        For i = 0 To (r - 1)
            c = dataset.Tables("Database1").Rows(i).Item(0)
            CrsTitle.Items.Insert(i, c.ToString)
            h = dataset.Tables("Database1").Rows(i).Item(1)
            gradelist.Items.Insert(i, h.ToString)
        Next


        dataset.Clear()
        strSQL = "Select Courses.CourseID, Courses.CreditHrs from Courses inner join RegCrs on Courses.CourseName = RegCrs.Course where RegCrs.IndexNo= '" & id & "' "
        dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
        dataAdapter.Fill(dataset, "Database1")
        Dim v = dataset.Tables("Database1").Rows.Count
        crsCode.Items.Clear()
        hrs.Items.Clear()

        For i = 0 To (v - 1)
            y = dataset.Tables("Database1").Rows(i).Item("CourseID")
            Dim u = dataset.Tables("Database1").Rows(i).Item("CreditHrs")
            crsCode.Items.Insert(i, y.ToString)
            hrs.Items.Insert(i, u.ToString)
        Next


    End Sub

    Private Sub urGPa_Click(sender As Object, e As EventArgs) Handles urGPa.Click

        dataset.Clear()
        strSQL = "Select RegCrs.Grade, Courses.CreditHrs from Courses inner join RegCrs on Courses.CourseName = RegCrs.Course where RegCrs.IndexNo= '" & id & "' "
        dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
        dataAdapter.Fill(dataset, "Database1")
        Dim y = dataset.Tables("Database1").Rows.Count
        ''crsCode.Items.Clear()
        ''hrs.Items.Clear()
        Dim f1 = 0.0
        Dim sum = 0.0
        Dim totalCredit = 0.0
        For i = 0 To (y - 1)
            c = dataset.Tables("Database1").Rows(i).Item("Grade")
            Dim u = dataset.Tables("Database1").Rows(i).Item("CreditHrs")

            If c = ga Then
                mk = 4.0
                f1 = u * mk
                ListBox5.Items.Insert(i, f1.ToString)
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gbp Then
                mk = 3.5
                f1 = u * mk
                ListBox5.Items.Insert(i, f1.ToString)
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gb Then
                mk = 3.0
                f1 = u * mk
                ListBox5.Items.Insert(i, f1.ToString)
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gcp Then
                mk = 2.5
                f1 = u * mk
                ListBox5.Items.Insert(i, f1.ToString)
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gc Then
                mk = 2.0
                f1 = u * mk
                ListBox5.Items.Insert(i, f1.ToString)
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gdp Then
                mk = 1.5
                f1 = u * mk
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gd Then
                mk = 1.0
                f1 = u * mk
                ListBox5.Items.Insert(i, f1.ToString)
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = ge Then
                mk = 0.5
                f1 = u * mk
                ListBox5.Items.Insert(i, f1.ToString)
                sum = sum + f1
                totalCredit = totalCredit + u
            ElseIf c = gf Then
                mk = 0.0
                f1 = u * mk
                ListBox5.Items.Insert(i, f1.ToString)
                sum = sum + f1
                totalCredit = totalCredit + u
            End If


        Next
        Dim gpa = 0.0
        gpa = Math.Round(sum / totalCredit, 2)

        Dim gpa1 = gpa.ToString
        MsgBox("Hello " + FirstName + "," + vbNewLine + "This is your GPA " + gpa1)
        Dim tex As String = ""
        If gpa >= 3.6 And gpa <= 4.0 Then
            tex = "FIRST CLASS DIVISION"
        ElseIf gpa <= 3.59 And gpa >= 3.0 Then
            tex = "UPPER CLASS DIVISION"
        ElseIf gpa <= 2.99 And gpa >= 2.0 Then
            tex = "LOWER CLASS DIVISION"
        ElseIf gpa < 1.99 And gpa >= 1.0 Then
            tex = "THIRD CLASS DIVISION"
        ElseIf gpa < 0.9 And gpa > 0.0 Then
            tex = "PASS DIVISION"
        End If
        If gpa = 0 Then
            MsgBox("Hello " + FirstName + "," + vbNewLine + "GPA not calculated yet")
        Else
            MsgBox("Hello " + FirstName + "," + vbNewLine + "This is your class division : " + tex)
        End If

    End Sub


End Class