Imports System.Data.SqlClient
Public Class subject
    Dim conn As New SqlConnection
    Dim Myconnection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim result As Integer
    Dim sql As String
    Private Sub txtnewsemester_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim subject_type As String
    Dim a As Boolean
    Private Sub checktypeofsubject()
        a = False
        If chbtheory.Checked = True Then
            subject_type = chbtheory.Text
            a = True
        End If
        If chbpractical.Checked = True Then
            subject_type = chbpractical.Text
            If a = True Then
                subject_type = "Theory & Practical"
            End If
        End If
    End Sub
    Private Sub get_checkboxstate_of_perticularsubject()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT subject_type from subject_table where subject_id = '" & lblshowid.Text & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            subject_type = rdr("subject_type")
        End While
        con.Close()
        Dim str_len As Integer = subject_type.Length
        If str_len = "6" Then
            chbtheory.Checked = True
            chbpractical.Checked = False
        ElseIf str_len = "9" Then
            chbpractical.Checked = True
            chbtheory.Checked = False
        Else
            chbpractical.Checked = True
            chbtheory.Checked = True
        End If
    End Sub
    Private Sub Subject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnadd.LabelText = "Add Subject"
        btnupdate.LabelText = "Update Subject"
        btndelete.LabelText = "Delete Subject"
        btnview.LabelText = "View Subject"
        btnsave.Hide()
        lblsubid.Hide()
        lblshowid.Hide()
        lblcoursename.Hide()
        cmbcoursename.Hide()
        lblbranchname.Hide()
        cmbbranchname.Hide()
        lblsemestername.Hide()
        cmbsemester.Hide()
        lblsubname.Hide()
        txtsubname.Hide()
        cmbsubname.Hide()
        lblnewsubname.Hide()
        txtnewsubname.Hide()
        btnsave.Hide()
        DataGridView1.Hide()
        chbpractical.Hide()
        chbtheory.Hide()
        subject_type = ""
    End Sub
    Private Sub resetall()
        cmbbranchname.selectedIndex = -1
        cmbcoursename.selectedIndex = -1
        cmbsemester.selectedIndex = -1
        txtsubname.Text = ""
        cmbsubname.selectedIndex = -1
        txtnewsubname.Text = ""
        lblshowid.Text = "-"
    End Sub
    Private Sub getSId()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("SELECT MAX(subject_id) + 1 as Id FROM subject_table", con)
            lblshowid.Text = cmd.ExecuteScalar().ToString()
            If lblshowid.Text = "" Then
                lblshowid.Text = 1
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        cmbsubname.selectedIndex = -1
        chbtheory.Checked = False
        chbpractical.Checked = False
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
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT semester_id from semester_table where semester_name = '" & cmbsemester.selectedValue & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            SemesterId = rdr("semester_id")
        End While
        con.Close()
    End Sub
    Private Sub getAllSemesterofParticularBranch()
        cmbsemester.Clear()
        cmbsemester.selectedIndex = -1
        cmbsubname.selectedIndex = -1
        chbtheory.Checked = False
        chbpractical.Checked = False
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT semester_name from semester_table where  branch_id = " & BranchId & "")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbsemester.AddItem(rdr("semester_name"))
        End While
    End Sub
    Private Sub getAllSubjectofParticularSemester()
        cmbsubname.Clear()
        cmbsubname.selectedIndex = -1
        chbtheory.Checked = False
        chbpractical.Checked = False
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT subject_name from subject_table where  semester_id = " & SemesterId & "")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbsubname.AddItem(rdr("subject_name"))
        End While
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If btnsave.LabelText = "Save" Then
            getSemesterId()
            checktypeofsubject()
            Try
                If subject_type <> "" And txtsubname.Text <> "" Then
                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "INSERT INTO subject_table VALUES (" & Convert.ToInt32(lblshowid.Text) & ",'" & txtsubname.Text & "'," & SemesterId & ",'" & subject_type & "')"
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Subject Record hass been Saved!")
                        getSId()
                        subject_type = ""
                        chbpractical.Checked = False
                        chbtheory.Checked = False
                        resetall()
                    Else
                        MsgBox("No record has been saved!")
                    End If
                Else
                    MessageBox.Show("No record has been saved!")
                    subject_type = ""
                    chbpractical.Checked = False
                    chbtheory.Checked = False
                    resetall()
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf btnsave.LabelText = "Update" Then
            checktypeofsubject()
            Try
                If subject_type <> "" And txtnewsubname.Text <> "" Then
                    conn.ConnectionString = Myconnection
                    conn.Open()

                    sql = "UPDATE subject_table SET subject_name='" & txtnewsubname.Text & "',subject_type = '" & subject_type & "' where subject_id=" & lblshowid.Text
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Subject Updated!")
                        cmbcoursename.SelectedIndex = -1
                        txtnewsubname.Clear()
                        lblshowid.Text = "-"
                        getAllCourse()
                        cmbcoursename.selectedIndex = -1
                        cmbbranchname.selectedIndex = -1
                        cmbsemester.selectedIndex = -1
                        chbpractical.Checked = False
                        chbtheory.Checked = False
                        'getAllBranches()
                    Else
                        MsgBox("No record has been updated!")
                    End If
                Else
                    MessageBox.Show("No record has been updated!")
                    subject_type = ""
                    lblshowid.Text = "-"
                    chbpractical.Checked = False
                    chbtheory.Checked = False
                    resetall()
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf btnsave.LabelText = "Delete" Then
            Try

                conn.ConnectionString = Myconnection
                conn.Open()

                sql = "Delete from subject_table where subject_id=" & lblshowid.Text

                cmd.Connection = conn
                cmd.CommandText = sql
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Subject Deleted!")
                    'cmbcoursename.SelectedIndex = -1
                    lblshowid.Text = "-"
                    cmbcoursename.selectedIndex = -1
                    cmbbranchname.selectedIndex = -1
                    cmbbranchname.Clear()
                    cmbcoursename.Clear()
                    getAllCourse()
                    resetall()
                Else
                    MsgBox("No record has been Deleted!")
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmbcoursename_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbbranchname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbsemester_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbsubname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub cmbsubname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        resetall()
        btnsave.LabelText = "Save"
        btnsave.Show()
        btnsave.Show()
        lblsubid.Show()
        lblshowid.Show()
        lblcoursename.Show()
        cmbcoursename.Show()
        lblbranchname.Show()
        cmbbranchname.Show()
        lblsemestername.Show()
        cmbsemester.Show()
        lblsubname.Show()
        txtsubname.Show()
        cmbsubname.Hide()
        DataGridView1.Hide()
        chbtheory.Show()
        chbpractical.Show()
        chbtheory.Checked = False
        chbpractical.Checked = False
        getSId()
        getAllCourse()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        resetall()
        lblsubid.Show()
        lblshowid.Show()
        lblcoursename.Show()
        cmbcoursename.Show()
        lblbranchname.Show()
        cmbbranchname.Show()
        lblsemestername.Show()
        cmbsemester.Show()
        lblsubname.Show()
        txtsubname.Hide()
        cmbsubname.Show()
        lblnewsubname.Hide()
        txtnewsubname.Hide()
        DataGridView1.Hide()
        btnsave.Show()
        getAllCourse()
        lblshowid.Text = "-"
        btnsave.LabelText = "Delete"
        getAllCourse()
        chbpractical.Show()
        chbpractical.Checked = False
        chbtheory.Show()
        chbtheory.Checked = False
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        resetall()
        lblsubid.Show()
        lblshowid.Show()
        lblcoursename.Show()
        cmbcoursename.Show()
        lblbranchname.Show()
        cmbbranchname.Show()
        lblsemestername.Show()
        cmbsemester.Show()
        lblsubname.Show()
        txtsubname.Hide()
        cmbsubname.Show()
        lblnewsubname.Show()
        txtnewsubname.Show()
        btnsave.Show()
        DataGridView1.Hide()
        getAllCourse()
        lblshowid.Text = "-"
        btnsave.LabelText = "Update"
        getAllCourse()
        chbpractical.Show()
        chbpractical.Checked = False
        chbtheory.Show()
        chbtheory.Checked = False
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        DataGridView1.Rows.Clear()
        btnsave.Hide()
        lblsubid.Hide()
        lblshowid.Hide()
        lblcoursename.Hide()
        cmbcoursename.Hide()
        lblbranchname.Hide()
        cmbbranchname.Hide()
        lblsemestername.Hide()
        cmbsemester.Hide()
        lblsubname.Hide()
        txtsubname.Hide()
        cmbsubname.Hide()
        lblnewsubname.Hide()
        txtnewsubname.Hide()
        btnsave.Hide()
        DataGridView1.Show()
        chbpractical.Hide()
        chbtheory.Hide()
        Dim subject_id As String
        Dim subject_name As String
        Dim semester_id As String
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As SqlCommand = New SqlCommand("Select subject_id,semester_id,subject_name from subject_table", con)
        con.Open()
        Dim rdr As SqlDataReader = com.ExecuteReader
        While rdr.Read
            semester_id = rdr("semester_id")
            subject_id = rdr("subject_id")
            subject_name = rdr("subject_name")
            DataGridView1.Rows.Add(subject_id, semester_id, subject_name)
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

    Private Sub cmbsemester_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsemester.onItemSelected
        getSemesterId()
        getAllSubjectofParticularSemester()
    End Sub

    Private Sub cmbsubname_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsubname.onItemSelected
        If cmbsubname.selectedValue <> "" Then
            ' cmbsubname.SelectedIndex = 0
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd1 As SqlCommand = New SqlCommand("SELECT subject_id from subject_table Where subject_name='" & cmbsubname.selectedValue & "'")
            cmd1.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd1.ExecuteReader()
            If (rdr.Read() = True) Then
                lblshowid.Text = rdr("subject_id")
            End If
        End If
        get_checkboxstate_of_perticularsubject()
    End Sub

    Private Sub cmbsubname_Leave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsubname.Leave
        txtnewsubname.Text = cmbsubname.Text
    End Sub
End Class
