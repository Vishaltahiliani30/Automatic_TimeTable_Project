Imports System.Data.SqlClient
Public Class Semester
    Dim conn As New SqlConnection
    Dim Myconnection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim result As Integer
    Dim sql As String
    Private Sub Semester_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnadd.LabelText = "Add Semester"
        btndelete.LabelText = "Delete Semester"
        btnupdate.LabelText = "Update Semester"
        btnview.LabelText = "View semester"
        btnsave.Hide()
        lblsid.Hide()
        showsid.Hide()
        cmbcoursename.Hide()
        lblcname.Hide()
        lblbname.Hide()
        cmbbranchname.Hide()
        lblsemester.Hide()
        txtsemester.Hide()
        cmbsemester.Hide()
        lblnewsemester.Hide()
        txtnewsemester.Hide()
        DataGridView1.Hide()
    End Sub
    Private Sub resetall()
        cmbbranchname.selectedIndex = -1
        cmbcoursename.selectedIndex = -1
        txtsemester.Text = ""
        showsid.Text = "-"
        cmbsemester.selectedIndex = -1
        txtnewsemester.Text = ""
    End Sub

    Private Sub cmbbranchname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
    Dim courseId As Integer = 0
    Private Sub getSId()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("SELECT MAX(semester_id) + 1 as Id FROM semester_table", con)
            showsid.Text = cmd.ExecuteScalar().ToString()
            If showsid.Text = "" Then
                showsid.Text = 1
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
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

    Private Sub cmbcoursename_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If btnsave.LabelText = "Save" Then
            getBranchId()
            Try
                If txtsemester.Text <> "" Then
                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "INSERT INTO semester_table VALUES (" & Convert.ToInt32(showsid.Text) & ", " & BranchId & ",'" & txtsemester.Text & "')"
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Semester Record hass been Saved!")
                        getSId()
                        resetall()
                    Else
                        MsgBox("No record has been saved!")
                    End If
                Else
                    MsgBox("No record has been saved!")
                    getSId()
                    resetall()
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf btnsave.LabelText = "Update" Then

            Try
                If txtnewsemester.Text <> "" Then
                    conn.ConnectionString = Myconnection
                    conn.Open()

                    sql = "UPDATE semester_table SET semester_name='" & txtnewsemester.Text & "' where semester_id=" & showsid.Text

                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Semester Updated!")
                        cmbcoursename.selectedIndex = -1
                        resetall()
                    Else
                        MsgBox("No record has been updated!")
                    End If
                Else
                    MessageBox.Show("No record has been update!")
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

                sql = "Delete from semester_table where semester_id=" & showsid.Text

                cmd.Connection = conn
                cmd.CommandText = sql
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Semester Deleted!")
                    'cmbcoursename.SelectedIndex = -1
                    showsid.Text = "-"
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

    Private Sub cmbsemester_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        resetall()
        btnsave.LabelText = "Save"
        DataGridView1.Hide()
        btnsave.Show()
        lblsid.Show()
        showsid.Show()
        lblcname.Show()
        cmbcoursename.Show()
        lblbname.Show()
        cmbbranchname.Show()
        lblsemester.Show()
        txtsemester.Show()
        cmbsemester.Hide()
        lblnewsemester.Hide()
        txtnewsemester.Hide()
        DataGridView1.Hide()
        getSId()
        getAllCourse()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        resetall()
        btnsave.LabelText = "Delete"
        btnsave.Show()
        lblsid.Show()
        showsid.Show()
        lblcname.Show()
        cmbcoursename.Show()
        lblbname.Show()
        cmbbranchname.Show()
        lblsemester.Show()
        cmbsemester.Show()
        txtsemester.Hide()
        lblnewsemester.Hide()
        txtnewsemester.Hide()
        DataGridView1.Hide()

        getAllCourse()
        showsid.Text = "-"
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        resetall()
        btnsave.LabelText = "Update"
        DataGridView1.Hide()
        btnsave.Show()
        lblsid.Show()
        showsid.Show()
        lblcname.Show()
        cmbcoursename.Show()
        lblbname.Show()
        cmbbranchname.Show()
        lblsemester.Show()
        txtsemester.Hide()
        cmbsemester.Show()
        lblnewsemester.Show()
        txtnewsemester.Show()
        DataGridView1.Hide()
        getAllCourse()
        showsid.Text = "-"
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        DataGridView1.Rows.Clear()
        Dim branch_id As String
        Dim semester_name As String
        Dim semester_id As String
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As SqlCommand = New SqlCommand("Select semester_id,branch_id,semester_name from semester_table", con)
        con.Open()
        Dim rdr As SqlDataReader = com.ExecuteReader
        While rdr.Read
            semester_id = rdr("semester_id")
            branch_id = rdr("branch_id")
            semester_name = rdr("semester_name")
            DataGridView1.Rows.Add(semester_id, branch_id, semester_name)
        End While
        btnsave.Hide()
        lblsid.Hide()
        showsid.Hide()
        cmbcoursename.Hide()
        lblcname.Hide()
        lblbname.Hide()
        cmbbranchname.Hide()
        lblsemester.Hide()
        txtsemester.Hide()
        cmbsemester.Hide()
        lblnewsemester.Hide()
        txtnewsemester.Hide()
        DataGridView1.Show()
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
        If cmbsemester.selectedValue <> "" Then
            'cmbsemester.SelectedIndex = 0
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd1 As SqlCommand = New SqlCommand("SELECT semester_id from semester_table Where semester_name='" & cmbsemester.selectedValue & "'")
            cmd1.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd1.ExecuteReader()
            If (rdr.Read() = True) Then
                showsid.Text = rdr("semester_id")
            End If
        End If
    End Sub
End Class
