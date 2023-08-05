Imports System.Data.SqlClient
Public Class Assign_subject
    Dim conn As New SqlConnection
    Dim Myconnection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
    Dim cmd As New SqlCommand
    Dim cmd1 As New SqlCommand
    Dim cmd2 As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim result As Integer
    Dim sql As String
    Dim sql1 As String
    Dim sql2 As String
    Dim chkforupdate As Boolean
    Private Sub Assign_subject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnadd.LabelText = "Assign Subject"
        btnupdate.LabelText = "Update"
        btndelete.LabelText = "Delete"
        btnview.LabelText = "View Data"
        lblassignid.Hide()
        lblshowid.Hide()
        lblcoursename.Hide()
        cmbcoursename.Hide()
        lblbranchname.Hide()
        cmbbranchname.Hide()
        lblsemestername.Hide()
        cmbsemestername.Hide()
        lblsubjectname.Hide()
        cmbsubjectname.Hide()
        lblselectprofessor.Hide()
        cmbselectprofessor.Hide()
        btnsave.Hide()
        DataGridView1.Hide()
        lblcredit.Hide()
        txtget1.Hide()
        txtget2.Hide()
        lblshow1.Hide()
        lblshow2.Hide()
        chbpractical.Hide()
        chbtheory.Hide()
        lbltheory.Hide()
        lblpractical.Hide()
        showcredits1.Hide()
        showcredits2.Hide()
        showprofessor.Hide()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        lblassignid.Show()
        lblshowid.Show()
        lblcoursename.Show()
        cmbcoursename.Show()
        lblbranchname.Show()
        cmbbranchname.Show()
        lblsemestername.Show()
        cmbsemestername.Show()
        lblsubjectname.Show()
        cmbsubjectname.Show()
        lblselectprofessor.Show()
        cmbselectprofessor.Show()
        btnsave.Show()
        DataGridView1.Hide()
        btnsave.LabelText = "Save"
        lblcredit.Show()
        txtget1.Hide()
        txtget2.Hide()
        lblshow1.Hide()
        lblshow2.Hide()
        getSId()
        getAllCourse()
        chkforupdate = False
        subject_type = "-"
        resetall()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        lblassignid.Show()
        lblshowid.Show()
        lblcoursename.Show()
        cmbcoursename.Show()
        lblbranchname.Show()
        cmbbranchname.Show()
        lblsemestername.Show()
        cmbsemestername.Show()
        lblsubjectname.Show()
        cmbsubjectname.Show()
        chbtheory.Hide()
        chbpractical.Hide()
        lblselectprofessor.Show()
        cmbselectprofessor.Hide()
        showprofessor.Hide()
        btnsave.Show()
        DataGridView1.Hide()
        btnsave.LabelText = "Delete"
        lblcredit.Show()
        txtget1.Hide()
        txtget2.Hide()
        lblshow1.Hide()
        lblshow2.Hide()
        lblshowid.Text = "-"
        getAllCourse()
        chkforupdate = True
        lblshowid.Text = "-"
        subject_type = "-"
        resetall()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        lblassignid.Show()
        lblshowid.Show()
        lblcoursename.Show()
        cmbcoursename.Show()
        lblbranchname.Show()
        cmbbranchname.Show()
        lblsemestername.Show()
        cmbsemestername.Show()
        lblsubjectname.Show()
        cmbsubjectname.Show()
        lblselectprofessor.Show()
        cmbselectprofessor.Show()
        btnsave.Show()
        DataGridView1.Hide()
        btnsave.LabelText = "Update"
        lblcredit.Show()
        txtget1.Hide()
        txtget2.Hide()
        lblshow1.Hide()
        lblshow2.Hide()
        lblshowid.Text = "-"
        getAllCourse()
        chkforupdate = True
        lblshowid.Text = "-"
        subject_type = "-"
        resetall()
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        DataGridView1.Rows.Clear()
        lblassignid.Hide()
        lblshowid.Hide()
        lblcoursename.Hide()
        cmbcoursename.Hide()
        lblbranchname.Hide()
        cmbbranchname.Hide()
        lblsemestername.Hide()
        cmbsemestername.Hide()
        lblsubjectname.Hide()
        cmbsubjectname.Hide()
        lblselectprofessor.Hide()
        cmbselectprofessor.Hide()
        btnsave.Hide()
        DataGridView1.Show()
        lblcredit.Hide()
        txtget1.Hide()
        txtget2.Hide()
        lblshow1.Hide()
        lblshow2.Hide()
        chbpractical.Hide()
        chbtheory.Hide()
        lbltheory.Hide()
        lblpractical.Hide()
        showcredits1.Hide()
        showcredits2.Hide()
        showprofessor.Hide()
        DataGridView1.Show()
        DataGridView1.Rows.Clear()
        Dim subjectname As String
        Dim subjecttype As String
        Dim credits As Integer
        Dim pro_name As String
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As SqlCommand = New SqlCommand("Select subject_name,subject_type,credits,professor_name  from assign_table", con)
        con.Open()
        Dim rdr As SqlDataReader = com.ExecuteReader
        While rdr.Read
            subjectname = rdr("subject_name")
            subjecttype = rdr("subject_type")
            credits = rdr("credits")
            pro_name = rdr("professor_name")

            DataGridView1.Rows.Add(subjectname, subjecttype, credits, pro_name)
        End While
        con.Close()
    End Sub
    Private Sub getSId()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("SELECT MAX(assign_id) + 1 as Id FROM assign_table", con)
            lblshowid.Text = cmd.ExecuteScalar().ToString()
            If lblshowid.Text = "" Then
                lblshowid.Text = 1
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        cmbsemestername.selectedIndex = -1
        cmbsubjectname.selectedIndex = -1
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
    Private Sub getAllSemesterofParticularBranch()
        cmbsemestername.Clear()
        cmbsemestername.selectedIndex = -1
        cmbsubjectname.selectedIndex = -1
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT semester_name from semester_table where  branch_id = " & BranchId & "")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbsemestername.AddItem(rdr("semester_name"))
        End While
    End Sub


    Dim SemesterId As Integer
    Private Sub getSemesterId()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT semester_id from semester_table where semester_name = '" & cmbsemestername.selectedValue & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            SemesterId = rdr("semester_id")
        End While
        con.Close()
    End Sub
    Private Sub getAllSubjectofParticularSemester()
        cmbsubjectname.Clear()
        cmbsubjectname.selectedIndex = -1
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT subject_name from subject_table where  semester_id = " & SemesterId & "")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbsubjectname.AddItem(rdr("subject_name"))
        End While
    End Sub


    Private Sub getprofessor()
        cmbselectprofessor.Clear()
        cmbselectprofessor.selectedIndex = -1
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT staff_name from staff_table")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbselectprofessor.AddItem(rdr("staff_name"))
        End While
    End Sub
    Private Sub getdata()
        DataGridView1.Show()
        DataGridView1.Rows.Clear()
        Dim subjectname As String
        Dim subjecttype As String
        Dim credits As Integer
        Dim pro_name As String
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As SqlCommand = New SqlCommand("Select subject_name,subject_type,credits,professor_name  from assign_table where subject_id = " & SubjectId & " ", con)
        con.Open()
        Dim rdr As SqlDataReader = com.ExecuteReader
        While rdr.Read
            subjectname = rdr("subject_name")
            subjecttype = rdr("subject_type")
            credits = rdr("credits")
            pro_name = rdr("professor_name")

            DataGridView1.Rows.Add(subjectname, subjecttype, credits, pro_name)
        End While
        con.Close()
    End Sub
    Private Sub cmbsubjectname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim SubjectId As Integer = 0
    Private Sub getsubjectid()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT subject_id from subject_table where subject_name = '" & cmbsubjectname.selectedValue & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            SubjectId = (rdr("subject_id"))
        End While
        con.Close()
    End Sub
    Dim subtype As String
    Dim t As Boolean = False
    Dim p As Boolean = False
    Private Sub gettypeofsubject()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT subject_type from subject_table where subject_id = '" & SubjectId & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            subtype = (rdr("subject_type"))
        End While
        If subtype = "Theory" Then
            lbltheory.Show()
            lbltheory.Text = "Theory"
            lblpractical.Hide()
            chbtheory.Hide()
            chbpractical.Hide()
            txtget1.Show()
            lblshow1.Show()
            lblshow1.Text = "Credits Of Theory Lecture"
            txtget2.Hide()
            lblshow2.Hide()
            t = True
            p = False
        ElseIf subtype = "Practical" Then
            lblpractical.Show()
            lblpractical.Text = "Practical"
            chbtheory.Hide()
            chbpractical.Hide()
            lbltheory.Hide()
            txtget2.Hide()
            lblshow2.Hide()
            txtget1.Show()
            lblshow1.Show()
            lblshow1.Text = "Credits Of Practical Labs"
            t = False
            p = True
        Else
            lbltheory.Show()
            lblpractical.Show()
            lbltheory.Text = "Theory"
            lblpractical.Text = "Practical"
            chbtheory.Show()
            chbpractical.Show()
            If chkforupdate = False Then
                txtget1.Hide()
                txtget2.Hide()
                lblshow1.Hide()
                lblshow2.Hide()
            End If
            t = True
            p = True
        End If
        con.Close()
    End Sub
    Private Sub getcredits()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT credits from credit_table where subject_id = '" & SubjectId & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        Dim c As Integer = 0
        While (rdr.Read() = True)
            subtype = rdr("credits")
            If btnsave.LabelText = "Save" Then
                If txtget2.Enabled = True And c = 1 Then
                    txtget2.Text = subtype
                End If
                If txtget1.Enabled = True And c = 0 Then
                    txtget1.Text = subtype
                    c = 1
                End If
            ElseIf btnsave.LabelText = "Delete" Then
                If showcredits2.Enabled = True And c = 1 Then
                    showcredits2.Text = subtype
                End If
                If showcredits1.Enabled = True And c = 0 Then
                    showcredits1.Text = subtype
                    c = 1
                End If
            End If
        End While
        con.Close()
    End Sub
    Private Sub resetall()
        cmbcoursename.Clear()
        cmbcoursename.selectedIndex = -1
        getAllCourse()
        cmbbranchname.selectedIndex = -1
        cmbbranchname.Clear()
        cmbsemestername.selectedIndex = -1
        cmbsemestername.Clear()
        cmbsubjectname.selectedIndex = -1
        cmbsubjectname.Clear()
        cmbselectprofessor.selectedIndex = -1
        cmbselectprofessor.Clear()
        txtget1.Hide()
        txtget2.Hide()
        chbpractical.Checked = False
        chbtheory.Checked = False
        chbpractical.Checked = False
        lblshow1.Hide()
        lblshow2.Hide()
    End Sub
    Dim flag As Boolean = False
    Dim counterth As Integer
    Dim counterpt As Integer
    Dim counterfort As Integer
    Dim counterforp As Integer
    Dim updatecredit As Boolean = False
    Dim getsubtypethoery As String
    Dim getsubtypepractical As String
    Dim gprofessor As String
    Private Sub upcredit()
        Dim totalfort As Integer = counterth
        Dim totalforp As Integer = counterpt
        If t = True And p = False Then
            totalfort += txtget1.Text
            Try
                If counterfort >= totalfort And gprofessor = cmbselectprofessor.selectedValue Then
                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "UPDATE assign_table SET credits ='" & totalfort & "' where subject_id = " & SubjectId & " and professor_name = '" & gprofessor & "' and subject_type = '" & "Theory" & "'"
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Credits has been Updated!")
                        lblshowid.Text = "-"
                        subject_type = "-"
                        updatecredit = True
                        getdata()
                        resetall()
                    Else
                        MsgBox("No record has been updated!")
                    End If
                    subject_type = ""
                    lblshowid.Text = "-"
                    resetall()
                    conn.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf p = True And t = False Then
            totalforp += txtget1.Text
            Try
                If counterfort >= totalforp And gprofessor = cmbselectprofessor.selectedValue Then
                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "UPDATE assign_table SET credits ='" & totalforp & "' where subject_id = " & SubjectId & " and professor_name = '" & gprofessor & "' and subject_type = '" & "Practical" & "' "
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Credits has been Updated!")
                        lblshowid.Text = "-"
                        subject_type = "-"
                        updatecredit = True
                        getdata()
                        resetall()
                    Else
                        MsgBox("No record has been updated!")
                    End If
                    subject_type = ""
                    lblshowid.Text = "-"
                    resetall()
                    conn.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf p = True And t = True Then
            totalfort += txtget1.Text
            totalforp += txtget2.Text
            Try
                If counterfort >= totalfort And gprofessor = cmbselectprofessor.selectedValue Then
                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "UPDATE assign_table SET credits ='" & totalfort & "' where subject_id = " & SubjectId & " and professor_name = '" & gprofessor & "' and subject_type = '" & "Theory" & "'"
                    sql1 = "UPDATE assign_table SET credits ='" & totalforp & "' where subject_id = " & SubjectId & " and professor_name = '" & gprofessor & "' and subject_type = '" & "Practical" & "'"
                    cmd.Connection = conn
                    cmd1.Connection = conn
                    cmd.CommandText = sql
                    cmd1.CommandText = sql1
                    Dim r As Integer
                    Dim q As Integer
                    r = cmd.ExecuteNonQuery()
                    q = cmd1.ExecuteNonQuery
                    If r > 0 And q > 0 Then
                        MsgBox("Credits has been Updated!")
                        lblshowid.Text = "-"
                        subject_type = "-"
                        updatecredit = True
                        getdata()
                        resetall()
                    Else
                        MsgBox("No record has been updated!")
                    End If
                    subject_type = ""
                    lblshowid.Text = "-"
                    resetall()
                    conn.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            totalfort -= txtget1.Text
            totalforp -= txtget2.Text
        End If
    End Sub
    Private Sub getsubtypeandprofessor()
        If t = True And False = False Then
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT subject_type from assign_table where subject_id = '" & SubjectId & "' and subject_type = '" & "Theory" & "'")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            While (rdr.Read() = True)
                getsubtypethoery = rdr("subject_type")
            End While
            con.Close()
            Dim con1 As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd1 As SqlCommand = New SqlCommand("SELECT professor_name from assign_table where subject_id = '" & SubjectId & "' and subject_type = '" & "Theory" & "'")
            cmd1.Connection = con1
            con1.Open()
            Dim rdr1 As SqlDataReader = cmd1.ExecuteReader()
            While (rdr1.Read() = True)
                gprofessor = rdr1("professor_name")
            End While
            con1.Close()
        ElseIf t = False And p = True Then
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT subject_type from assign_table where subject_id = '" & SubjectId & "' and subject_type = '" & "Practical" & "'")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            While (rdr.Read() = True)
                getsubtypepractical = rdr("subject_type")
            End While
            con.Close()
            Dim con1 As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd1 As SqlCommand = New SqlCommand("SELECT professor_name from assign_table where subject_id = '" & SubjectId & "' and subject_type = '" & "Practical" & "'")
            cmd1.Connection = con1
            con1.Open()
            Dim rdr1 As SqlDataReader = cmd1.ExecuteReader()
            While (rdr1.Read() = True)
                gprofessor = rdr1("professor_name")
            End While
            con1.Close()
        ElseIf p = True And t = True Then
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT subject_type from assign_table where subject_id = '" & SubjectId & "' and subject_type = '" & "Practical" & "'")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            While (rdr.Read() = True)
                getsubtypepractical = rdr("subject_type")
            End While
            con.Close()
            Dim con2 As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd2 As SqlCommand = New SqlCommand("SELECT subject_type from assign_table where subject_id = '" & SubjectId & "' and subject_type = '" & "Theory" & "'")
            cmd2.Connection = con2
            con2.Open()
            Dim rdr2 As SqlDataReader = cmd2.ExecuteReader()
            While (rdr2.Read() = True)
                getsubtypethoery = rdr2("subject_type")
            End While
            con2.Close()
            Dim con1 As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd1 As SqlCommand = New SqlCommand("SELECT professor_name from assign_table where subject_id = '" & SubjectId & "' and subject_type = '" & "Practical" & "'")
            cmd1.Connection = con1
            con1.Open()
            Dim rdr1 As SqlDataReader = cmd1.ExecuteReader()
            While (rdr1.Read() = True)
                gprofessor = rdr1("professor_name")
            End While
            con1.Close()
        End If
    End Sub
    Private Sub gettotalcredits()
        If t = True And p = False Then
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT credits from credit_table where subject_id = '" & SubjectId & "'")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            While (rdr.Read() = True)
                counterfort = rdr("credits")
            End While
            con.Close()
        ElseIf t = False And p = True Then
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT credits from credit_table where subject_id = '" & SubjectId & "'")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            While (rdr.Read() = True)
                counterforp = rdr("credits")
            End While
            con.Close()
        ElseIf t = True And p = True Then
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT credits from credit_table where subject_id = '" & SubjectId & "' and subject_type = '" & "Theory" & "' ")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            While (rdr.Read() = True)
                counterfort = rdr("credits")
            End While
            con.Close()
            Dim con1 As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd1 As SqlCommand = New SqlCommand("SELECT credits from credit_table where subject_id = '" & SubjectId & "' and subject_type =  '" & "Practical" & "' ")
            cmd1.Connection = con1
            con1.Open()
            Dim rdr1 As SqlDataReader = cmd1.ExecuteReader()
            While (rdr1.Read() = True)
                counterforp = rdr1("credits")
            End While
            con.Close()
        End If
    End Sub
    Private Sub checkfinal()
        counterth = 0
        counterpt = 0
        If t = True And p = False Then
            counterth += txtget1.Text
            If counterfort >= counterth Then
                flag = True
            Else
                flag = False
                MsgBox("Error !!")
                counterth -= txtget1.Text
            End If
        ElseIf t = False And p = True Then
            counterpt += txtget1.Text
            If counterforp >= counterpt Then
                flag = True
            Else
                flag = False
                MsgBox("Error !!")
                counterpt -= txtget1.Text
            End If
        Else
            counterth += txtget1.Text
            counterpt += txtget2.Text
            If counterforp >= counterpt And counterfort >= counterth Then
                flag = True
            Else
                flag = False
                MsgBox("Error !!")
                counterth -= txtget1.Text
                counterpt -= txtget2.Text
            End If
        End If
    End Sub
    Private Sub checkcondition()
        counterpt = 0
        counterth = 0
        If t = True And p = False Then
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT credits from Assign_table where subject_id = '" & SubjectId & "'and subject_type = '" & "Theory" & "' ")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            While (rdr.Read() = True)
                counterth = counterth + rdr("credits")
            End While
            con.Close()
        ElseIf t = False And p = True Then
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT credits from Assign_table where subject_id = '" & SubjectId & "'and subject_type = '" & "Practical" & "' ")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            While (rdr.Read() = True)
                counterpt = counterpt + rdr("credits")
            End While
            con.Close()
        ElseIf t = True And p = True Then
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT credits from Assign_table where subject_id = '" & SubjectId & "' And subject_type = '" & "Theory" & "' ")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            While (rdr.Read() = True)
                counterth = counterth + rdr("credits")
            End While
            con.Close()
            Dim con1 As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd1 As SqlCommand = New SqlCommand("SELECT credits from Assign_table where subject_id = '" & SubjectId & "' And subject_type = '" & "Practical" & "' ")
            cmd1.Connection = con1
            con1.Open()
            Dim rdr1 As SqlDataReader = cmd1.ExecuteReader()
            While (rdr1.Read() = True)
                counterpt = counterpt + rdr1("credits")
            End While
            con.Close()
        End If
    End Sub
    Dim flag1 As Integer
    Dim professor As String
    Dim subject_type As String
    Private Sub update_same_professor_credits()


    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If chkforupdate = False Then
            upcredit()
        End If
        If btnsave.LabelText = "Save" Then
            checkfinal()
            If flag = False Then
                MsgBox("Please check credits !!")
            Else
                If updatecredit = True Then
                Else
                    If t = False And p = True Then

                        Try
                            conn.ConnectionString = Myconnection
                            conn.Open()
                            sql = "INSERT INTO Assign_table VALUES (" & Convert.ToInt32(lblshowid.Text) & "," & SubjectId & ",'" & cmbselectprofessor.selectedValue & "','" & "Practical" & "'," & txtget1.Text & ",'" & cmbsubjectname.selectedValue & "')"
                            cmd.Connection = conn
                            cmd.CommandText = sql
                            Dim r As Integer
                            r = cmd.ExecuteNonQuery()
                            If r > 0 Then
                                MsgBox("Credits has been Saved!")

                                getSId()
                                getdata()
                                resetall()
                                checkcondition()
                            Else
                                MsgBox("No record has been saved!")
                            End If
                            resetall()
                            getdata()
                            conn.Close()
                            checkcondition()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    ElseIf t = True And p = False Then
                        Try
                            conn.ConnectionString = Myconnection
                            conn.Open()
                            sql = "INSERT INTO Assign_table VALUES (" & Convert.ToInt32(lblshowid.Text) & "," & SubjectId & ",'" & cmbselectprofessor.selectedValue & "','" & "Theory" & "'," & txtget1.Text & ",'" & cmbsubjectname.selectedValue & "')"
                            cmd.Connection = conn
                            cmd.CommandText = sql
                            Dim r As Integer
                            r = cmd.ExecuteNonQuery()
                            If r > 0 Then
                                MsgBox("Credits has been Saved!")
                                getSId()
                                getdata()
                                resetall()
                            Else
                                MsgBox("No record has been saved!")
                            End If
                            resetall()
                            getdata()
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
                            sql = "INSERT INTO Assign_table VALUES (" & Convert.ToInt32(lblshowid.Text) & "," & SubjectId & ",'" & cmbselectprofessor.selectedValue & "','" & "Practical" & "'," & txtget2.Text & ",'" & cmbsubjectname.selectedValue & "')"
                            sql1 = "INSERT INTO Assign_table VALUES (" & id & "," & SubjectId & ",'" & cmbselectprofessor.selectedValue & "','" & "Theory" & "'," & txtget1.Text & ",'" & cmbsubjectname.selectedValue & "')"
                            cmd.Connection = conn
                            cmd1.Connection = conn
                            cmd.CommandText = sql
                            cmd1.CommandText = sql1
                            Dim r As Integer
                            Dim q As Integer
                            r = cmd.ExecuteNonQuery()
                            q = cmd1.ExecuteNonQuery()
                            If r > 0 And q > 0 Then
                                MsgBox("Data has been Saved!")
                                getSId()
                                getdata()
                                resetall()
                            Else
                                MsgBox("No record has been saved!")
                            End If
                            resetall()
                            getdata()
                            conn.Close()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    End If
                End If
            End If
        ElseIf btnsave.LabelText = "Update" Then
            If chbtheory.Checked = True And chbpractical.Checked = False Then
                If txtget1.Text <= counterfort Then
                    Try
                        conn.ConnectionString = Myconnection
                        conn.Open()
                        sql = "UPDATE assign_table SET credits ='" & txtget1.Text & "'  , professor_name = '" & cmbselectprofessor.selectedValue & "' , subject_name = '" & cmbsubjectname.selectedValue & "'  where subject_id = '" & SubjectId & "' and subject_type = '" & "Theory" & "' "
                        cmd.Connection = conn
                        cmd.CommandText = sql
                        Dim r As Integer
                        r = cmd.ExecuteNonQuery()
                        If r > 0 Then
                            MsgBox("Credits has been Updated!")
                            lblshowid.Text = "-"
                            subject_type = "-"
                            updatecredit = True
                            getdata()
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
                End If
            ElseIf chbtheory.Checked = False And chbpractical.Checked = True Then
                If txtget1.Text <= counterforp Then
                    Try
                        conn.ConnectionString = Myconnection
                        conn.Open()
                        sql = "UPDATE assign_table SET credits ='" & txtget1.Text & "' , professor_name = '" & cmbselectprofessor.selectedValue & "' , subject_name = '" & cmbsubjectname.selectedValue & "'  where subject_id = '" & SubjectId & "' and subject_type = '" & "Practical" & "' "
                        cmd.Connection = conn
                        cmd.CommandText = sql
                        Dim r As Integer
                        r = cmd.ExecuteNonQuery()
                        If r > 0 Then
                            MsgBox("Credits has been Updated!")
                            lblshowid.Text = "-"
                            subject_type = "-"
                            updatecredit = True
                            getdata()
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
                Else
                    MsgBox("Invalid Credits !!")
                End If
            End If
        ElseIf btnsave.LabelText = "Delete" Then

            If chbtheory.Checked = True And chbpractical.Checked = False Then
                Try
                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "Delete from assign_table where subject_id = '" & SubjectId & "' and subject_type = '" & "Theory" & "'"
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Credits has been Deleted!")
                        lblshowid.Text = "-"
                        subject_type = "-"
                        updatecredit = True
                        getdata()
                        resetall()
                        showcredits1.Hide()
                        showcredits2.Hide()
                        showprofessor.Hide()
                        chbpractical.Hide()
                        chbtheory.Hide()
                    Else
                        MsgBox("No record has been Deleted!")
                    End If
                    subject_type = ""
                    lblshowid.Text = "-"
                    resetall()
                    showcredits1.Hide()
                    showcredits2.Hide()
                    showprofessor.Hide()
                    chbpractical.Hide()
                    chbtheory.Hide()
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            ElseIf chbpractical.Checked = True And chbtheory.Checked = False Then
                Try
                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "Delete from assign_table where subject_id = '" & SubjectId & "' and subject_type = '" & "Practical" & "'"
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Credits has been Deleted!")
                        lblshowid.Text = "-"
                        subject_type = "-"
                        updatecredit = True
                        getdata()
                        resetall()
                        chbpractical.Hide()
                        chbtheory.Hide()
                        showcredits1.Hide()
                        showcredits2.Hide()
                        showprofessor.Hide()
                    Else
                        MsgBox("No record has been Deleted!")
                    End If
                    subject_type = ""
                    lblshowid.Text = "-"
                    resetall()
                    showcredits1.Hide()
                    showcredits2.Hide()
                    showprofessor.Hide()
                    chbpractical.Hide()
                    chbtheory.Hide()
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            ElseIf chbpractical.Checked = True And chbtheory.Checked = True Then
                Try
                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "Delete from assign_table where subject_id = '" & SubjectId & "' and subject_type = '" & "Practical" & "'"
                    sql1 = "Delete from assign_table where subject_id = '" & SubjectId & "' and subject_type = '" & "Theory" & "'"
                    cmd.Connection = conn
                    cmd1.Connection = conn
                    cmd.CommandText = sql
                    cmd1.CommandText = sql1
                    Dim r As Integer
                    Dim q As Integer
                    r = cmd.ExecuteNonQuery()
                    q = cmd1.ExecuteNonQuery()
                    If r > 0 And q > 0 Then
                        MsgBox("Data has been Deleted!")
                        getdata()
                        resetall()
                        subject_type = ""
                        lblshowid.Text = "-"
                        resetall()
                        showcredits1.Hide()
                        showcredits2.Hide()
                        showprofessor.Hide()
                        chbpractical.Hide()
                        chbtheory.Hide()
                    Else
                        MsgBox("No record has been Deleted!")
                    End If
                    resetall()
                    getdata()
                    subject_type = ""
                    lblshowid.Text = "-"
                    showcredits1.Hide()
                    showcredits2.Hide()
                    showprofessor.Hide()
                    chbpractical.Hide()
                    chbtheory.Hide()
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

        End If
    End Sub
    Private Sub getassignid()
        gettypeofsubject()
        If chkforupdate = True Then
            If t = True And p = False Then
                Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
                Dim cmd As SqlCommand = New SqlCommand("SELECT assign_id from Assign_table where subject_id = '" & SubjectId & "' And subject_type = '" & "Theory" & "' ")
                cmd.Connection = con
                con.Open()
                Dim rdr As SqlDataReader = cmd.ExecuteReader()
                While (rdr.Read() = True)
                    lblshowid.Text = rdr("assign_id")
                End While
                con.Close()
            ElseIf t = False And p = True Then
                Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
                Dim cmd As SqlCommand = New SqlCommand("SELECT assign_id from Assign_table where subject_id = '" & SubjectId & "' And subject_type = '" & "Practical" & "' ")
                cmd.Connection = con
                con.Open()
                Dim rdr As SqlDataReader = cmd.ExecuteReader()
                While (rdr.Read() = True)
                    lblshowid.Text = rdr("assign_id")
                End While
                con.Close()
            ElseIf t = True And p = True Then
                Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
                Dim cmd As SqlCommand = New SqlCommand("SELECT assign_id from Assign_table where subject_id = '" & SubjectId & "' And subject_type = '" & "Practical" & "' ")
                cmd.Connection = con
                con.Open()
                Dim rdr As SqlDataReader = cmd.ExecuteReader()
                While (rdr.Read() = True)
                    lblshowid.Text = rdr("assign_id")
                End While
                con.Close()
            End If
        End If
    End Sub
    Private Sub chbtheory_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbtheory.CheckedChanged
        If btnsave.LabelText = "Update" Then
            If chbtheory.Checked = True Then
                chbpractical.Checked = False
            End If
            checkchkcon()
            getdataforupadte()
        ElseIf btnsave.LabelText = "Delete" Then
            checkchkcon()
            getdataforupadte()
        Else
            checkchkcon()
        End If
    End Sub

    Private Sub chbpractical_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbpractical.CheckedChanged
        If btnsave.LabelText = "Update" Then
            If chbpractical.Checked = True Then
                chbtheory.Checked = False
            End If
            checkchkcon()
            getdataforupadte()
        ElseIf btnsave.LabelText = "Delete" Then
            checkchkcon()
            getdataforupadte()
        Else
            checkchkcon()
        End If
    End Sub
    Private Sub checkchkcon()
        If chkforupdate = False And btnsave.LabelText = "Save" Then
            If chbpractical.Checked = True And chbtheory.Checked = False Then
                txtget2.Hide()
                lblshow2.Hide()
                txtget1.Hide()
                lblshow1.Hide()
                txtget1.Show()
                lblshow1.Show()
                lblshow1.Text = "Credits Of Practical Labs"
                t = False
                p = True
                If chkforupdate = False Then
                    getcredits()
                End If
                If txtget2.Text > 0 Then
                    txtget1.Text = txtget2.Text
                End If
            ElseIf chbpractical.Checked = False And chbtheory.Checked = True Then
                'txtget1.Hide()
                lblshow1.Hide()
                txtget1.Show()
                lblshow1.Show()
                lblshow1.Text = "Credits Of Theory Lecture"
                txtget2.Hide()
                lblshow2.Hide()
                If chkforupdate = False Then
                    getcredits()
                End If
                t = True
                p = False
            ElseIf chbpractical.Checked = True And chbtheory.Checked = True Then
                txtget1.Show()
                txtget2.Show()
                lblshow2.Show()
                lblshow1.Show()
                lblshow1.Text = "Credits Of Theory Lectures"
                lblshow2.Text = "Credits Of Practical Labs"
                If chkforupdate = False Then
                    getcredits()
                End If
                t = True
                p = True
            ElseIf chbpractical.Checked = False And chbtheory.Checked = False Then
                txtget1.Hide()
                txtget2.Hide()
                lblshow1.Hide()
                lblshow2.Hide()
            End If
        ElseIf btnsave.LabelText = "Delete" Then
            txtget1.Hide()
            txtget2.Hide()
            If chbpractical.Checked = True And chbtheory.Checked = False Then
                showcredits2.Hide()
                lblshow2.Hide()
                txtget1.Hide()
                lblshow1.Hide()
                showcredits1.Show()
                lblshow1.Show()
                lblshow1.Text = "Credits Of Practical Labs"
                t = False
                p = True
                If chkforupdate = False Then
                    getcredits()
                End If
                If showcredits1.Text > "0" Then
                    showcredits1.Text = showcredits2.Text
                End If
            ElseIf chbpractical.Checked = False And chbtheory.Checked = True Then
                'txtget1.Hide()
                lblshow1.Hide()
                lblshow1.Show()
                lblshow1.Text = "Credits Of Theory Lecture"
                showcredits2.Hide()
                showcredits1.Show()
                lblshow2.Hide()
                If chkforupdate = False Then
                    getcredits()
                End If
                t = True
                p = False
            ElseIf chbpractical.Checked = True And chbtheory.Checked = True Then
                showcredits1.Show()
                showcredits2.Show()
                lblshow2.Show()
                lblshow1.Show()
                lblshow1.Text = "Credits Of Theory Lectures"
                lblshow2.Text = "Credits Of Practical Labs"
                If chkforupdate = False Then
                    getcredits()
                End If
                t = True
                p = True
            ElseIf chbpractical.Checked = False And chbtheory.Checked = False Then
                txtget1.Hide()
                txtget2.Hide()
                showcredits1.Hide()
                showcredits2.Hide()
                lblshow1.Hide()
                lblshow2.Hide()
                showprofessor.Hide()
            End If
        Else
            If chbpractical.Checked = True And chbtheory.Checked = False Then
                txtget2.Hide()
                lblshow2.Hide()
                txtget1.Hide()
                lblshow1.Hide()
                txtget1.Show()
                lblshow1.Show()
                lblshow1.Text = "Credits Of Practical Labs"
                t = False
                p = True
            ElseIf chbpractical.Checked = False And chbtheory.Checked = True Then
                'txtget1.Hide()
                lblshow1.Hide()
                txtget1.Visible = True
                lblshow1.Text = "Credits Of Theory Lecture"
                lblshow1.Show()
                txtget2.Hide()
                lblshow2.Hide()
                t = True
                p = False
            ElseIf chbpractical.Checked = True And chbtheory.Checked = True Then
                txtget1.Show()
                txtget2.Show()
                lblshow2.Show()
                lblshow1.Show()
                lblshow1.Text = "Credits Of Theory Lectures"
                lblshow2.Text = "Credits Of Practical Labs"
                t = True
                p = True
            ElseIf chbpractical.Checked = False And chbtheory.Checked = False Then
                txtget1.Hide()
                txtget2.Hide()
                lblshow1.Hide()
                lblshow2.Hide()
            End If
            getassignid()
        End If
    End Sub
    Private Sub getdataforupadte()
        If chbtheory.Checked = True Then
            Dim i As Integer = 0
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT professor_name from Assign_table where subject_id = '" & SubjectId & "' and subject_type = '" & "Theory" & "' ")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            Dim str As String
            While (rdr.Read() = True)
                If btnsave.LabelText = "Update" Then
                    cmbselectprofessor.selectedIndex = 0
                    For i = 0 To cmbselectprofessor.Items.Length
                        str = cmbselectprofessor.selectedValue
                        If str = rdr("professor_name") Then
                            Exit For
                        End If
                    Next
                    cmbselectprofessor.selectedIndex = i
                ElseIf btnsave.LabelText = "Delete" Then
                    showprofessor.Show()
                    showprofessor.Text = rdr("professor_name")
                End If
            End While
            con.Close()
        ElseIf chbpractical.Checked = True Then
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT professor_name from Assign_table where subject_id = '" & SubjectId & "' and subject_type = '" & "Practical" & "' ")
            cmd.Connection = con
            Dim str As String
            Dim i As Integer
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            While (rdr.Read() = True)
                If btnsave.LabelText = "Update" Then
                    cmbselectprofessor.selectedIndex = 0
                    For i = 0 To cmbselectprofessor.Items.Length
                        Str = cmbselectprofessor.selectedValue
                        If str = rdr("professor_name") Then
                            Exit For
                        End If
                    Next
                    cmbselectprofessor.selectedIndex = i
                    'cmbselectprofessor.SelectedItem = rdr("professor_name")
                ElseIf btnsave.LabelText = "Delete" Then
                    showprofessor.Show()
                    showprofessor.Text = rdr("professor_name")
                End If
            End While
            con.Close()
        End If
        If lblshowid.Text <> "-" Then
            Dim id As Integer = lblshowid.Text + 1
            If t = True Or p = True Then
                If chbtheory.Checked = True And chbpractical.Checked = False Then
                    Dim con1 As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
                    Dim cmd1 As SqlCommand = New SqlCommand("SELECT credits from Assign_table where subject_id = '" & SubjectId & "' and subject_type = '" & "Theory" & "' ")
                    cmd1.Connection = con1
                    con1.Open()
                    Dim rdr1 As SqlDataReader = cmd1.ExecuteReader()
                    While (rdr1.Read() = True)
                        If btnsave.LabelText = "Update" Then
                            txtget1.Text = rdr1("credits")
                        ElseIf btnsave.LabelText = "Delete" Then
                            showcredits1.Text = rdr1("credits")
                        End If
                    End While
                    con1.Close()
                ElseIf chbtheory.Checked = False And chbpractical.Checked = True Then
                    Dim con1 As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
                    Dim cmd1 As SqlCommand = New SqlCommand("SELECT credits from Assign_table where subject_id = '" & SubjectId & "' and subject_type = '" & "Practical" & "' ")
                    cmd1.Connection = con1
                    con1.Open()
                    Dim rdr1 As SqlDataReader = cmd1.ExecuteReader()
                    While (rdr1.Read() = True)
                        If btnsave.LabelText = "Update" Then
                            txtget1.Text = rdr1("credits")
                        ElseIf btnsave.LabelText = "Delete" Then
                            showcredits1.Text = rdr1("credits")
                        End If
                    End While
                    con1.Close()
                ElseIf chbpractical.Checked = True And chbtheory.Checked = True Then
                    Dim con1 As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
                    Dim cmd1 As SqlCommand = New SqlCommand("SELECT credits from Assign_table where assign_id = '" & lblshowid.Text & "' and subject_type = '" & "Practical" & "' ")
                    cmd1.Connection = con1
                    con1.Open()
                    Dim rdr1 As SqlDataReader = cmd1.ExecuteReader()
                    While (rdr1.Read() = True)
                        If btnsave.LabelText = "Update" Then
                            txtget2.Text = rdr1("credits")
                        ElseIf btnsave.LabelText = "Delete" Then
                            showcredits2.Text = rdr1("credits")
                        End If
                    End While
                    con1.Close()
                    Dim con2 As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
                    Dim cmd2 As SqlCommand = New SqlCommand("SELECT credits from Assign_table where assign_id = '" & id & "' and subject_type = '" & "Theory" & "' ")
                    cmd2.Connection = con2
                    con2.Open()
                    Dim rdr2 As SqlDataReader = cmd2.ExecuteReader()
                    While (rdr2.Read() = True)
                        If btnsave.LabelText = "Update" Then
                            txtget1.Text = rdr2("credits")
                        ElseIf btnsave.LabelText = "Delete" Then
                            showcredits1.Text = rdr2("credits")
                        End If
                    End While
                    con1.Close()
                End If
            End If
        Else
            getassignid()
        End If
    End Sub
    Private Sub cmbselectprofessor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtget1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtget1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtget1.Text < 0 Then
            MsgBox(txtget1.Text & "   Enter positive Value !!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub txtget2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtget2.Text < 0 Then
            MsgBox(txtget2.Text & "   Enter positive Value !!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub lblselectprofessor_Click(sender As System.Object, e As System.EventArgs) Handles lblselectprofessor.Click

    End Sub

    Private Sub lblsubjectname_Click(sender As System.Object, e As System.EventArgs) Handles lblsubjectname.Click

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

    Private Sub cmbsubjectname_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsubjectname.onItemSelected
        If chkforupdate = False Then
            getprofessor()
            getsubjectid()
            gettypeofsubject()
            getcredits()
            getdata()
            gettotalcredits()
            chbtheory.Checked = False
            chbpractical.Checked = False
            getsubtypeandprofessor()
            checkcondition()
        End If
        If chkforupdate = True Then
            gettypeofsubject()
            getsubjectid()
            chbtheory.Checked = False
            chbpractical.Checked = False
            getdata()
            getprofessor()
            getassignid()
            gettotalcredits()
            getdataforupadte()
            checkcondition()
        End If
    End Sub

    Private Sub cmbselectprofessor_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbselectprofessor.onItemSelected

    End Sub
End Class
