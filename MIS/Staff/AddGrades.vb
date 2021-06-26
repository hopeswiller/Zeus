Imports MIS.GV
Imports MIS.Login
Imports System.Data.OleDb
Public Class AddGrades
    Dim objCon As New OleDb.OleDbConnection
    Dim strSQL As String
    Dim Config As Configuration.ConfigurationSettings
    Dim strConnection As String = Config.AppSettings("MyDBConnectionString")
    Dim dataAdapter As New OleDb.OleDbDataAdapter
    Dim dataset As New DataSet
    Dim attempt As Integer = 0
    Dim std_grade As String

    Private Sub exitgrades_Click(sender As Object, e As EventArgs) Handles exitgrades.Click
        Me.Close()
    End Sub

    Private Sub AddGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartPosition = FormStartPosition.CenterScreen
        Width = 841
        Height = 812

        objCon.ConnectionString = strConnection
        If objCon.State = ConnectionState.Closed Then
            objCon.Open()
        Else
            objCon.Close()
            MsgBox("failed")
        End If


    End Sub

    Private Sub crsdropdwn_DropDown(sender As Object, e As EventArgs) Handles crsdropdwn.DropDown
        dataset.Clear()
        strSQL = "Select Course from Staff_Courses where StaffID = '" & id & "'"
        dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
        Dim a2 = dataAdapter.Fill(dataset, "Database1")
        Dim r2 = dataset.Tables("Database1").Rows.Count
        crsdropdwn.Items.Clear()
        For i = 0 To (r2 - 1)
            m = dataset.Tables("Database1").Rows(i).Item(0)
            crsdropdwn.Items.Insert(i, m.ToString)
            While Not crsdropdwn.Items.Contains(m)
                crsdropdwn.Items.Insert(i, m.ToString)
            End While
        Next
    End Sub

    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown
        z = crsdropdwn.SelectedItem
        dataset.Clear()
        strSQL = "Select IndexNo,Course from RegCrs where Course = '" & z & "'"
        dataAdapter = New OleDb.OleDbDataAdapter(strSQL, objCon)
        dataAdapter.Fill(dataset, "Database1")
        Dim r = dataset.Tables("Database1").Rows.Count
        ComboBox1.Items.Clear()

        For i = 0 To (r - 1)
            h = dataset.Tables("Database1").Rows(i).Item(1)
            ComboBox1.Items.Insert(i, h.ToString)
        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Label1.Text = "Index number" Then
            Label1.Text = ComboBox1.Text
        ElseIf Not Label1.Text = "Index number" And Label2.Text = "Index number" Then
            Label2.Text = ComboBox1.Text
        ElseIf Not Label1.Text = "Index number" And Not Label2.Text = "Index number" And Label3.Text = "Index number" Then
            Label3.Text = ComboBox1.Text
        ElseIf Not Label1.Text = "Index number" And Not Label2.Text = "Index number" And Not Label3.Text = "Index number" Then
            Label4.Text = ComboBox1.Text
        End If

    End Sub

    Private Sub sndGrades_Click(sender As Object, e As EventArgs) Handles sndGrades.Click
        For x = 0 To 3


            If Not Label1.Text = "Index number" And Not Label2.Text = "Index number" And Not TextBox1.Text = "" And Not TextBox2.Text = "" Then


                Dim stdid_Arr(4) As String
                stdid_Arr(0) = (Label1.Text).ToString
                stdid_Arr(1) = (Label2.Text).ToString
                stdid_Arr(2) = (Label3.Text).ToString
                stdid_Arr(3) = (Label4.Text).ToString
                Dim mark_Arr(4) As Integer
                mark_Arr(0) = Integer.Parse(TextBox1.Text)
                mark_Arr(1) = Integer.Parse(TextBox2.Text)
                mark_Arr(2) = Integer.Parse(TextBox3.Text)
                mark_Arr(3) = Integer.Parse(TextBox4.Text)

                Dim mark As Integer = mark_Arr(x)

                If mark >= 80 Then
                    std_grade = "A"
                ElseIf mark >= 75 And mark < 80 Then
                    std_grade = "B+"
                ElseIf mark >= 70 And mark < 75 Then
                    std_grade = "B"
                ElseIf mark >= 65 And mark < 70 Then
                    std_grade = "C+"
                ElseIf mark >= 60 And mark < 65 Then
                    std_grade = "C"
                ElseIf mark >= 55 And mark < 60 Then
                    std_grade = "D+"
                ElseIf mark >= 50 And mark < 55 Then
                    std_grade = "D"
                ElseIf mark >= 45 And mark < 50 Then
                    std_grade = "E"
                ElseIf mark >= 0 And mark < 45 Then
                    std_grade = "F"
                End If


                strSQL = "Update [RegCrs] set [Grade] = '" & std_grade & "' where [IndexNo] = '" & stdid_Arr(x) & "' and [Course]='" & z & "'"
                Dim cmd As New OleDbCommand(strSQL, objCon)

                cmd.ExecuteNonQuery()
                cmd.Dispose()

            Else
                MsgBox("four students must be assigned a grade" + vbNewLine + "Please do so")
            End If
        Next
        MsgBox("Entry of Student grades successful")
        Label1.Text = "Index number"
        Label2.Text = "Index number"
        Label3.Text = "Index number"
        Label4.Text = "Index number"
        TextBox1.Text= ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub



End Class