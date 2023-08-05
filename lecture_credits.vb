Imports System.Data.SqlClient
Public Class lecture_credits
    Dim conn As New SqlConnection
    Dim Myconnection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
    Dim cmd As New SqlCommand
    Dim cmd1 As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim result As Integer
    Dim sql As String
    Dim sql1 As String
    Private Sub lecture_credits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnadd.LabelText = "Add Credits"
        btndelete.LabelText = "Delete Credits"
        btnupdate.LabelText = "Update Credits"
        btnview.LabelText = "View Credits"
        lblcreditid.Hide()
        lblshowid.Hide()
        lblcoursename.Hide()
        cmbcoursename.Hide()
        lblbranchname.Hide()
        cmbbranchname.Hide()
        lblsemestername.Hide()
        cmbsemestername.Hide()
        lblsubjectname.Hide()
        cmbsubname.Hide()
        lblcredit.Hide()
        txtget2.Hide()
        txtget1.Hide()
        lblshow1.Hide()
        lblshow2.Hide()
        btnsave.Hide()
        lblshow1.Hide()
        lblshow2.Hide()
        txtget1.Hide()
        txtget2.Hide()
        DataGridView2.Hide()
    End Sub
    Private Sub getCId()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("SELECT MAX(credit_id) + 1 as Id FROM credit_table", con)
            lblshowid.Text = cmd.ExecuteScalar().ToString()
            If lblshowid.Text = "" Then
                lblshowid.Text = 1
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblshowid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblshowid.Click

    End Sub
    Dim courseId As Integer
    Private Sub getcourseId()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT course_id from course_table where course_name = '" & cmbcoursename.selectedvalue & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            courseId = rdr("course_id")
        End While
        con.Close()
    End Sub
    Private Sub getAllCourse()
        cmbcoursename.clear()
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
        cmbbranchname.clear()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT branch_name from branch_table where course_id = " & courseId & "")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbbranchname.AddItem(rdr("branch_name"))
        End While
        cmbbranchname.selectedIndex = -1
        cmbsemestername.selectedIndex = -1
        cmbsubname.selectedIndex = -1
    End Sub
    Dim BranchId As Integer = 0
    Private Sub getBranchId()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT branch_id from branch_table where branch_name = '" & cmbbranchname.selectedvalue & "'")
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
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT semester_id from semester_table where semester_name = '" & cmbsemestername.selectedvalue & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            SemesterId = rdr("semester_id")
        End While
        con.Close()
    End Sub
    Dim SubjectId As Integer
    Private Sub getSubjectId()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT subject_id from subject_table where subject_name = '" & cmbsubname.selectedvalue & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            SubjectId = rdr("subject_id")

        End While
        con.Close()
    End Sub
    Private Sub getAllSemesterofParticularBranch()
        cmbsemestername.clear()
        cmbsemestername.selectedIndex = -1
        cmbsubname.selectedIndex = -1
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT semester_name from semester_table where  branch_id = " & BranchId & "")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbsemestername.AddItem(rdr("semester_name"))
        End While
    End Sub
    Private Sub getAllSubjectofParticularSemester()
        cmbsubname.clear()
        cmbsubname.selectedIndex = -1
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT subject_name from subject_table where  semester_id = " & SemesterId & "")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbsubname.AddItem(rdr("subject_name"))
        End While
    End Sub
    Dim subject_type As String
    Private Sub GetSubjectType()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT subject_type from subject_table where subject_name = '" & cmbsubname.selectedvalue & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            subject_type = rdr("subject_type")
        End While
        con.Close()
    End Sub
    Dim t As Boolean = False
    Dim p As Boolean = False
    Private Sub check_type_of_subject()
        Dim str_len As Integer
        str_len = subject_type.Length
        If str_len = "6" Then
            txtget1.Show()
            lblshow1.Show()
            lblshow1.Text = "Credits Of Theory Lecture"
            txtget2.Hide()
            lblshow2.Hide()
            t = True
            p = False
        ElseIf str_len = "9" Then
            txtget2.Hide()
            lblshow2.Hide()
            txtget1.Show()
            lblshow1.Show()
            lblshow1.Text = "Credits Of Practical Labs"
            t = False
            p = True
        Else
            t = True
            p = True
            txtget1.Show()
            txtget2.Show()
            lblshow1.Show()
            lblshow2.Show()
            lblshow1.Text = "Credits Of Theory Lecture"
            lblshow2.Text = "Credits Of Practical Labs"
        End If
    End Sub
    Private Sub resetall()
        cmbbranchname.selectedIndex = -1
        cmbcoursename.selectedIndex = -1
        cmbsemestername.selectedIndex = -1
        cmbsubname.selectedIndex = -1
        cmbcoursename.clear()
        cmbbranchname.clear()
        cmbsemestername.clear()
        cmbsubname.clear()
        txtget1.Text = ""
        txtget2.Text = ""
        txtget1.Hide()
        txtget2.Hide()
        lblshow1.Hide()
        lblshow2.Hide()
        getAllCourse()
    End Sub

    Dim flag As Boolean
    Private Sub check()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT subject_id from credit_table where subject_id = '" & SubjectId & "'")
        cmd.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        If (rdr.Read() = True) Then
            flag = True
        Else
            flag = False
        End If
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        check()
        If btnsave.LabelText = "Save" Then
            If flag = True Then
                MsgBox("Subject already Exist !!")
            Else
                If t = False And p = True Then
                    Try
                        conn.ConnectionString = Myconnection
                        conn.Open()
                        sql = "INSERT INTO credit_table VALUES (" & Convert.ToInt32(lblshowid.Text) & "," & SubjectId & ",'" & "Practical" & "'," & txtget1.Text & ")"
                        cmd.Connection = conn
                        cmd.CommandText = sql
                        Dim r As Integer
                        r = cmd.ExecuteNonQuery()
                        If r > 0 Then
                            MsgBox("Credits has been Saved!")
                            getCId()
                            subject_type = ""
                            resetall()
                        Else
                            MsgBox("No record has been saved!")
                        End If
                        subject_type = ""
                        resetall()
                        conn.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                ElseIf t = True And p = False Then
                    Try
                        conn.ConnectionString = Myconnection
                        conn.Open()
                        sql = "INSERT INTO credit_table VALUES (" & Convert.ToInt32(lblshowid.Text) & "," & SubjectId & ",'" & "Theory" & "'," & txtget1.Text & ")"
                        cmd.Connection = conn
                        cmd.CommandText = sql
                        Dim r As Integer
                        r = cmd.ExecuteNonQuery()
                        If r > 0 Then
                            MsgBox("Credits has been Saved!")
                            getCId()
                            subject_type = ""
                            resetall()
                        Else
                            MsgBox("No record has been saved!")
                        End If
                        subject_type = ""
                        resetall()
                        conn.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                ElseIf t = True And p = True Then
                    Dim id As Integer = lblshowid.Text
                    id = id + 1
                    Try
                        conn.ConnectionString = Myconnection
                        conn.Open()
                        sql = "INSERT INTO credit_table VALUES (" & Convert.ToInt32(lblshowid.Text) & "," & SubjectId & ",'" & "Theory" & "'," & txtget1.Text & ")"
                        sql1 = "INSERT INTO credit_table VALUES (" & id & "," & SubjectId & ",'" & "Practical" & "'," & txtget2.Text & ")"
                        cmd.Connection = conn
                        cmd1.Connection = conn
                        cmd.CommandText = sql
                        cmd1.CommandText = sql1
                        Dim r As Integer
                        Dim q As Integer
                        r = cmd.ExecuteNonQuery()
                        q = cmd1.ExecuteNonQuery()
                        If r > 0 And q > 0 Then
                            MsgBox("Credits has been Saved!")
                            getCId()
                            subject_type = ""
                            resetall()
                        Else
                            MsgBox("No record has been saved!")
                        End If
                        subject_type = ""
                        resetall()
                        conn.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            End If
        ElseIf btnsave.LabelText = "Update" Then
            check_type_of_subject()
            If t = False And p = True Then
                Try
                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "UPDATE credit_table SET credits ='" & txtget1.Text & "' where credit_id =" & lblshowid.Text
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Credits has been Updated!")
                        lblshowid.Text = "-"
                        subject_type = "-"
                        resetall()
                    Else
                        MsgBox("No record has been updated!")
                    End If
                    subject_type = ""
                    lblshowid.Text = "-"
                    resetall()
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            ElseIf t = True And p = False Then
                Try
                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "UPDATE credit_table SET credits ='" & txtget1.Text & "' where credit_id =" & lblshowid.Text
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Credits has been UPdated!")
                        lblshowid.Text = "-"
                        subject_type = ""
                        resetall()
                    Else
                        MsgBox("No record has been Updated!")
                    End If
                    subject_type = ""
                    lblshowid.Text = "-"
                    resetall()
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            ElseIf t = True And p = True Then
                Dim id As Integer = lblshowid.Text
                id = id + 1
                Try
                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "UPDATE credit_table SET credits ='" & txtget1.Text & "' where  subject_id = '" & SubjectId & "' and subject_type = '" & "Theory" & "' "
                    sql1 = "UPDATE credit_table SET credits ='" & txtget2.Text & "' where subject_id = '" & SubjectId & "' and subject_type = '" & "Practical" & "' "
                    cmd.Connection = conn
                    cmd1.Connection = conn
                    cmd.CommandText = sql
                    cmd1.CommandText = sql1
                    Dim r As Integer
                    Dim q As Integer
                    r = cmd.ExecuteNonQuery()
                    q = cmd1.ExecuteNonQuery()
                    If r > 0 And q > 0 Then
                        MsgBox("Credits has been Updated!")
                        lblshowid.Text = "-"
                        subject_type = ""
                        resetall()
                    ElseIf q = 0 Then
                        getCId()
                        Try
                            ' conn.ConnectionString = Myconnection
                            ' conn.Open()
                            sql = "INSERT INTO credit_table VALUES (" & Convert.ToInt32(lblshowid.Text) & "," & SubjectId & ",'" & "Practical" & "'," & txtget2.Text & ")"
                            cmd.Connection = conn
                            cmd.CommandText = sql
                            Dim a As Integer
                            a = cmd.ExecuteNonQuery()
                            If a > 0 Then
                                MsgBox("Credits has been Saved!")
                                getCId()
                                subject_type = ""
                                resetall()
                            Else
                                MsgBox("No record has been saved!")
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    ElseIf r = 0 Then
                        getCId()
                        Try
                            ' conn.ConnectionString = Myconnection
                            'conn.Open()
                            sql = "INSERT INTO credit_table VALUES (" & Convert.ToInt32(lblshowid.Text) & "," & SubjectId & ",'" & "Theory" & "'," & txtget1.Text & ")"
                            cmd.Connection = conn
                            cmd.CommandText = sql
                            Dim a As Integer
                            a = cmd.ExecuteNonQuery()
                            If a > 0 Then
                                MsgBox("Credits has been Saved!")
                                getCId()
                                subject_type = ""
                                resetall()
                            Else
                                MsgBox("No record has been saved!")
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    Else
                        MsgBox("No record has been Updated!")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        ElseIf btnsave.LabelText = "Delete" Then
            check_type_of_subject()
            If t = False And p = True Then
                Try
                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "Delete From credit_table where credit_id =" & lblshowid.Text
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Credits has been Deleted!")
                        lblshowid.Text = "-"
                        subject_type = "-"
                        resetall()
                    Else
                        MsgBox("No record has been Deleted!")
                    End If
                    subject_type = ""
                    lblshowid.Text = "-"
                    resetall()
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            ElseIf t = True And p = False Then
                Try
                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "Delete From credit_table where credit_id =" & lblshowid.Text
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Credits has been Deleted!")
                        lblshowid.Text = "-"
                        subject_type = ""
                        resetall()
                    Else
                        MsgBox("No record has been Deleted!")
                    End If
                    subject_type = ""
                    lblshowid.Text = "-"
                    resetall()
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            ElseIf t = True And p = True Then
                Dim id As Integer = lblshowid.Text
                id = id + 1
                Try
                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "Delete From credit_table where credit_id =" & lblshowid.Text
                    sql1 = "Delete From credit_table where credit_id =" & id
                    cmd.Connection = conn
                    cmd1.Connection = conn
                    cmd.CommandText = sql
                    cmd1.CommandText = sql1
                    Dim r As Integer
                    Dim q As Integer
                    r = cmd.ExecuteNonQuery()
                    q = cmd1.ExecuteNonQuery()
                    If r > 0 And q > 0 Then
                        MsgBox("Credits has been Deleted!")
                        lblshowid.Text = "-"
                        subject_type = ""
                        resetall()
                    Else
                        MsgBox("No record has been Deleted!")
                    End If
                    subject_type = ""
                    lblshowid.Text = "-"
                    resetall()
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub cmbsubjectname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbsubjectname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim subtype As String
    Private Sub getcredits()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT credits from credit_table where subject_id = '" & SubjectId & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        Dim c As Integer = 0
        While (rdr.Read() = True)
            subtype = rdr("credits")
            If txtget2.Enabled = True And c = 1 Then
                txtget2.Text = subtype
            End If
            If txtget1.Enabled = True And c = 0 Then
                txtget1.Text = subtype
                c = 1
            End If
        End While
        con.Close()
    End Sub
    Private Sub lbltheory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub BunifuTileButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        txtget1.Hide()
        txtget2.Hide()
        lblshow1.Hide()
        lblshow2.Hide()
        lblcreditid.Show()
        lblshowid.Show()
        lblcoursename.Show()
        cmbcoursename.Show()
        lblbranchname.Show()
        cmbbranchname.Show()
        lblsemestername.Show()
        cmbsemestername.Show()
        lblsubjectname.Show()
        cmbsubname.Show()
        lblcredit.Show()
        btnsave.Show()
        btnsave.LabelText = "Save"
        resetall()
        getCId()
        getAllCourse()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        lblcreditid.Show()
        lblshowid.Show()
        lblcoursename.Show()
        cmbcoursename.Show()
        lblbranchname.Show()
        cmbbranchname.Show()
        lblsemestername.Show()
        cmbsemestername.Show()
        lblsubjectname.Show()
        cmbsubname.Show()
        lblcredit.Show()
        btnsave.Show()
        btnsave.LabelText = "Delete"
        lblshowid.Text = "-"
        resetall()
        getAllCourse()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        lblcreditid.Show()
        lblshowid.Show()
        lblcoursename.Show()
        cmbcoursename.Show()
        lblbranchname.Show()
        cmbbranchname.Show()
        lblsemestername.Show()
        cmbsemestername.Show()
        lblsubjectname.Show()
        cmbsubname.Show()
        lblcredit.Show()
        btnsave.Show()
        btnsave.LabelText = "Update"
        lblshowid.Text = "-"
        resetall()
        getAllCourse()
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        DataGridView2.Rows.Clear()
        lblcreditid.Hide()
        lblshowid.Hide()
        lblcoursename.Hide()
        cmbcoursename.Hide()
        lblbranchname.Hide()
        cmbbranchname.Hide()
        lblsemestername.Hide()
        cmbsemestername.Hide()
        lblsubjectname.Hide()
        cmbsubname.Hide()
        lblcredit.Hide()
        txtget2.Hide()
        txtget1.Hide()
        lblshow1.Hide()
        lblshow2.Hide()
        btnsave.Hide()
        lblshow1.Hide()
        lblshow2.Hide()
        txtget1.Hide()
        txtget2.Hide()
        DataGridView2.Show()
        Dim subject_id As String
        Dim subject_type As String
        Dim credits
        Dim credit_id As String
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As SqlCommand = New SqlCommand("Select credit_id,subject_id,subject_type,credits from credit_table", con)
        con.Open()
        Dim rdr As SqlDataReader = com.ExecuteReader
        While rdr.Read
            credit_id = rdr("credit_id")
            subject_id = rdr("subject_id")
            subject_type = rdr("subject_type")
            credits = rdr("credits")
            DataGridView2.Rows.Add(credit_id, subject_id, subject_type, credits)
        End While
    End Sub

    Private Sub cmbcoursename_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcoursename.onItemSelected
        getcourseId()
        getAllBranchesofParticularCourse()
    End Sub

    Private Sub cmbbranchname_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbranchname.onItemSelected
        getBranchId()
        getAllSemesterofParticularBranch()
    End Sub

    Private Sub cmbsemestername_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsemestername.onItemSelected
        getSemesterId()
        getAllSubjectofParticularSemester()
    End Sub

    Private Sub cmbsubname_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsubname.onItemSelected
        If cmbsubname.selectedValue <> "" Then
            getSubjectId()
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd1 As SqlCommand = New SqlCommand("SELECT credit_id from credit_table Where subject_id = " & SubjectId & " ")
            cmd1.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd1.ExecuteReader()
            If (rdr.Read() = True) Then
                lblshowid.Text = rdr("credit_id")
            End If
        End If
        GetSubjectType()
        check_type_of_subject()
        getcredits()
    End Sub
End Class
