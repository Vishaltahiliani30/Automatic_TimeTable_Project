Imports System.Data.SqlClient
Imports System.Exception
Public Class btnGenerate
    Dim conn As New SqlConnection
    Dim Myconnection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim result As Integer
    Dim sql As String
    Private Sub Generate_timetable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getAllCourse()
        lblgenerate.Text = "Generate"
        ' lblprint.Text = "PRINT"
    End Sub
    Dim num(6, 6) As String
    Private Sub getnummber()


        Dim d As Integer = 0
        Dim lect_no As Integer = 0
        Dim generator As New Random

        d = generator.Next(0, 6)
        lect_no = generator.Next(0, 6)
        num(d, lect_no) = "JAVA - T"

        For l = 0 To 5
            For j = 0 To 5
                MsgBox("Value at Index --> (" & l & "," & j & ") --> " & num(l, j))
            Next
        Next
    End Sub
    Dim courseId As Integer
    Private Sub getcourseId()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT course_id from course_table where course_name = '" & cmbcoursename.selectedValue & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            courseId = rdr("course_id")
        End While
        con.Close()
    End Sub
    Private Sub getAllCourse()
        cmbcoursename.Clear()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT * from course_table order by course_name")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbcoursename.AddItem(rdr("course_name"))
        End While

    End Sub
    Private Sub getAllBranchesofParticularCourse()
        cmbbranchname.Clear()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT branch_name from branch_table where course_id = " & courseId & "")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbbranchname.AddItem(rdr("branch_name"))
        End While
        cmbbranchname.selectedIndex = -1
        cmbsemester.selectedIndex = -1
    End Sub
    Dim BranchId As Integer = 0
    Private Sub getBranchId()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT branch_id from branch_table where branch_name = '" & cmbbranchname.selectedValue & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            BranchId = rdr("branch_id")
        End While
        con.Close()
    End Sub
    Dim SemesterId As Integer
    Private Sub getSemesterId()
        If cmbsemester.selectedValue <> "" Then
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd1 As SqlCommand = New SqlCommand("SELECT semester_id from semester_table where semester_name = '" & cmbsemester.selectedValue & "'")
            cmd1.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd1.ExecuteReader()
            While (rdr.Read() = True)
                SemesterId = rdr("semester_id")
            End While
            con.Close()
        End If
    End Sub
    Private Sub getAllSemesterofParticularBranch()
        cmbsemester.Clear()
        cmbsemester.selectedIndex = -1
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT semester_name from semester_table where  branch_id = " & BranchId & "")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbsemester.AddItem(rdr("semester_name"))
        End While
    End Sub

    Private Sub cmbcoursename_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbbranchname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbsemester_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim i As Integer = 0
    Dim subject(10) As String
    Dim sid As Integer
    Dim tid As Integer
    Dim pid As Integer
    Dim collision(15) As String
    Dim Day As Integer = 0
    Dim lect_no As Integer = 0
    Dim a As Integer = 0
    Private Sub getsubjects()
        i = 0
        For n = 0 To 9
            subject(n) = ""
        Next
        For l = 0 To 5
            For j = 0 To 5
                num(l, j) = ""
            Next
        Next
        For k = 0 To 14
            collision(k) = ""
        Next
        For x = 0 To 9
            subject(x) = ""
        Next
        a = 0
        Dim profName(10) As String
        Dim sub_type(10) As String
        Dim credits(10) As String

        If cmbsemester.selectedIndex <> -1 Then
            Dim index As Integer = 0
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd1 As SqlCommand = New SqlCommand("SELECT subject_name from subject_table Where semester_id='" & SemesterId & "'")
            cmd1.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd1.ExecuteReader()
            Try
                While (rdr.Read() = True)
                    index = 0
                    subject(i) = rdr("subject_name")

                    Dim con1 As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
                    Dim cmd11 As SqlCommand = New SqlCommand("SELECT professor_name,subject_type,credits from Assign_table Where subject_name='" & subject(i) & "' order by subject_type desc")
                    cmd11.Connection = con1
                    con1.Open()
                    Dim rdr1 As SqlDataReader = cmd11.ExecuteReader()

                    While (rdr1.Read() = True)
                        'subject(i) = rdr("subject_name")
                        profName(index) = rdr1("professor_name").ToString.ToUpper()
                        profName(index) = profName(index).Substring(0, 1) & profName(index).Substring(profName(index).IndexOf(" ") + 1, 1)
                        sub_type(index) = rdr1("subject_type")
                        credits(index) = rdr1("credits")
                        index = index + 1
                    End While

                    sid = getsubid(subject(i))
                    tid = getthrycredits(sid)
                    pid = getPracticalcredits(sid)

                    Dim generator As New Random
                    index = 0
                    For k = 0 To tid - 1
                        Day = generator.Next(0, 6)
                        lect_no = generator.Next(0, 6)

                        If num(Day, lect_no) = "" Then
                            num(Day, lect_no) = subject(i) & "-(T)" & vbCrLf & "    " & "(" & profName(index) & ")"
                        Else
                            collision(a) = subject(i) & "-(T)" & vbCrLf & "    " & "(" & profName(index) & ")"
                            a = a + 1
                        End If
                    Next
                    index = 1
                    pid = pid * 2
                    For k = 0 To pid - 1
                        Day = generator.Next(0, 6)
                        lect_no = generator.Next(0, 6)
                        If num(Day, lect_no) = "" Then
                            If k < 2 Then
                                num(Day, lect_no) = subject(i) & "- (B1)" & vbCrLf & "    " & "(" & profName(index) & ")"
                            Else
                                num(Day, lect_no) = subject(i) & "- (B2)" & vbCrLf & "    " & "(" & profName(index) & ")"
                            End If

                        Else

                            If k < 2 Then
                                collision(a) = subject(i) & "- (B1)" & vbCrLf & "    " & "(" & profName(index) & ")"
                            Else
                                collision(a) = subject(i) & "- (B2)" & vbCrLf & "    " & "(" & profName(index) & ")"
                            End If
                            'collision(a) = subject(i) & "-(P)" & vbCrLf & "    " & "(" & profName(index) & ")"
                            a = a + 1
                        End If
                    Next

                    'MsgBox("Subject is " & subject(i) & " Subject Id is " & sid & " Theory Credits " & tid & " Practical Credits " & pid)
                    i = i + 1
                End While

                'For z = 0 To a - 1
                '    For l = 0 To 5
                '        For j = 0 To 5
                '            If num(i, j) = "" Then
                '                num(l, j) = collision(z)
                '            End If
                '        Next
                '    Next
                'Next

                Dim p As Integer = 0
                For l = 0 To 5
                    For j = 0 To 5
                        If num(l, j) <> "" Then
                            ' MsgBox("Value at Index --> (" & l & "," & j & ") --> " & num(l, j))
                        Else
                            If p <> a Then
                                num(l, j) = collision(p)
                                p = p + 1
                                'MsgBox("Value at Index --> (" & l & "," & j & ") --> " & num(l, j))
                            End If
                        End If
                    Next
                Next

                'For z = 0 To a - 1
                '    MsgBox(collision(z))
                'Next

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Dim subid As Integer
    Private Function getsubid(ByVal subName As String) As Integer

        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT subject_id from subject_table Where subject_name='" & subName & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        Try
            While (rdr.Read() = True)
                subid = rdr("subject_id")
                'MsgBox(subid)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return subid
    End Function

    Dim thry As Integer
    Private Function getthrycredits(ByVal subId As Integer) As Integer
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT credits from credit_table Where subject_id='" & subId & "' and subject_type='Theory'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        Try
            thry = 0
            While (rdr.Read() = True)
                thry = rdr("credits")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return thry
    End Function

    Dim Practical As Integer
    Private Function getPracticalcredits(ByVal subId As Integer) As Integer
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT credits from credit_table Where subject_id='" & subId & "' and subject_type='Practical'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        Try
            Practical = 0
            While (rdr.Read() = True)
                Practical = rdr("credits")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Practical
    End Function

    Private Sub Label20_Click(sender As System.Object, e As System.EventArgs) Handles lbl03.Click

    End Sub

    Private Sub Label19_Click(sender As System.Object, e As System.EventArgs) Handles lbl04.Click

    End Sub

    Private Sub BunifuFlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub cmbcoursename_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcoursename.onItemSelected
        getcourseId()
        getAllBranchesofParticularCourse()
    End Sub

    Private Sub cmbbranchname_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbranchname.onItemSelected
        getBranchId()
        getAllSemesterofParticularBranch()
    End Sub

    Private Sub cmbsemester_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsemester.onItemSelected
        getSemesterId()
        getsubjects()
    End Sub

    Private Sub generatepanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generatepanel.Click
        generate()
    End Sub

    Private Sub lblgenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblgenerate.Click
        generate()
    End Sub
    Private Sub generate()
        showcourse.Text = cmbcoursename.selectedValue
        showbranch.Text = cmbbranchname.selectedValue
        showsemester.Text = cmbsemester.selectedValue

        'For u = 0 To 6
        '    For l = 0 To 6
        '        MsgBox("Value is " & num(u, l))
        '    Next
        'Next

        Dim message As String = ""
        For Each textBox As Label In Panel1.Controls.OfType(Of Label)()
            message = textBox.Name
            If message.Length = 5 Then
                Dim first_index As Integer
                Dim second_index As Integer
                first_index = message.Substring(3, 1)
                second_index = message.Substring(4, 1)
                textBox.Text = num(first_index, second_index)
            End If
            'MsgBox(message)
        Next
        'workloadDivision()
    End Sub

    Dim message As String = ""
    Dim total_lectures As Integer = 0
    Dim per_day_lectures As Integer = 0
    Dim unassigned_lectures As Integer = 0
    Dim lect(36) As String
    Dim k, j As Integer
    Private Sub workloadDivision()
        For k = 0 To 5
            lect(k) = ""
        Next
        total_lectures = 0
        per_day_lectures = 0
        unassigned_lectures = 0
        For Each textBox As Label In Panel1.Controls.OfType(Of Label)()
            message = textBox.Name
            If message.Length = 5 Then
                If textBox.Text <> "" Then
                    lect(k) = textBox.Text
                    k = k + 1
                    total_lectures = total_lectures + 1
                End If
            End If
        Next
        per_day_lectures = Math.Floor(total_lectures / 6)
        unassigned_lectures = total_lectures - (per_day_lectures * 6)
        For l = 0 To 5
            MsgBox("Index at " & l & "" & lect(l))
            Next
        MsgBox(total_lectures)
        MsgBox(per_day_lectures)
        MsgBox(unassigned_lectures)


    End Sub

    Private Sub BunifuGradientPanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuGradientPanel1.Click
        getSemesterId()
        submitData()
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click
        getSemesterId()
        submitData()
    End Sub
    Private Sub removeSemesterDetails()
        conn.ConnectionString = Myconnection
        conn.Open()

        sql = "Delete from time_table where semester_id=" & SemesterId

        cmd.Connection = conn
        cmd.CommandText = sql
        Dim r As Integer
        r = cmd.ExecuteNonQuery()
        conn.Close()

    End Sub
    Dim D As String = ""
    Private Sub submitData()
        removeSemesterDetails()
        Dim r As Integer = 0
        For x = 0 To 5
            For l = 0 To 5
                'MsgBox(num(x, l))
                conn.ConnectionString = Myconnection
                conn.Open()
                If x = 0 Then
                    D = "Mon"
                ElseIf x = 1 Then
                    D = "Tue"
                ElseIf x = 2 Then
                    D = "Wed"
                ElseIf x = 3 Then
                    D = "Thu"
                ElseIf x = 4 Then
                    D = "Fri"
                ElseIf x = 5 Then
                    D = "Sat"
                End If
                sql = "INSERT INTO time_table VALUES (" & SemesterId & ", '" & D & "'," & l & ",'" & num(x, l) & "')"
                cmd.Connection = conn
                cmd.CommandText = sql

                r = cmd.ExecuteNonQuery()
                conn.Close()
            Next
        Next
        If r > 0 Then
            MsgBox("Time Table Inserted to Database")
        End If
    End Sub

End Class
