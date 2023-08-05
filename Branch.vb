Imports System.Data.SqlClient
Public Class Branch
    Dim conn As New SqlConnection
    Dim Myconnection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim result As Integer
    Dim sql As String
    Private Sub resetall()
        cmbbranchname.selectedindex = -1
        showbid.Text = "-"
        cmbcoursename.selectedIndex = -1
        txtbranch.Text = ""
        txtnewbranch.Text = ""
    End Sub
    Private Sub getId()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("SELECT MAX(branch_id) + 1 as Id FROM branch_table", con)
            showbid.Text = cmd.ExecuteScalar().ToString()
            If showbid.Text = "" Then
                showbid.Text = 1
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        cmbbranchname.selectedindex = -1
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


    Private Sub cmbcoursename_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Branch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnadd.LabelText = "Add Branch"
        btndelete.LabelText = "Delete Branch"
        btnupdate.LabelText = "Update Branch"
        btnview.LabelText = "View Brnach"
        btnsave.Hide()
        lblbid.Hide()
        DataGridView1.Hide()
        showbid.Hide()
        cmbbranchname.Hide()
        lblnewbranch.Hide()
        txtnewbranch.Hide()
        lblbname.Hide()
        cmbcoursename.Hide()
        lblcname.Hide()
        txtbranch.Hide()
    End Sub
    Dim courseId As Integer = 0
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


    Private Sub BunifuTileButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If btnsave.LabelText = "Save" Then
            getcourseId()
            Try
                If txtbranch.Text <> "" Then
                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "INSERT INTO branch_table VALUES (" & Convert.ToInt32(showbid.Text) & ", '" & txtbranch.Text & "'," & courseId & ")"
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Branch Record hass been Saved!")
                        getId()
                        resetall()
                    Else
                        MsgBox("No record has been saved!")
                    End If
                Else
                    MsgBox("No record has been saved!")
                    getId()
                    resetall()
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf btnsave.LabelText = "Update" Then
            Try
                If txtnewbranch.Text <> "" And showbid.Text <> "-" Then
                    conn.ConnectionString = Myconnection
                    conn.Open()

                    sql = "UPDATE branch_table SET branch_name='" & txtnewbranch.Text & "' where branch_id=" & showbid.Text


                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Branch Updated!")
                        'cmbcoursename.SelectedIndex = -1
                        resetall()
                        getAllCourse()
                    Else
                        MsgBox("No record has been updated!")
                    End If
                Else
                    MsgBox("No record has been updated!")
                    getAllCourse()
                    resetall()
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf btnsave.LabelText = "Delete" Then
            Try
                If showbid.Text <> "-" Then
                    conn.ConnectionString = Myconnection
                    conn.Open()

                    sql = "Delete from branch_table where branch_id=" & showbid.Text

                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Branch Deleted!")
                        'cmbcoursename.SelectedIndex = -1
                        resetall()
                        getAllCourse()
                    Else
                        MsgBox("No record has been Deleted!")
                    End If
                Else
                    resetall()
                    getAllCourse()
                    MsgBox("No record has been Deleted!")
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub cmbbranchname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub showbid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showbid.Click

    End Sub
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        btnsave.Show()
        lblbid.Show()
        showbid.Show()
        lblnewbranch.Hide()
        txtnewbranch.Hide()
        DataGridView1.Hide()
        lblbname.Show()
        cmbcoursename.Show()
        resetall()
        txtbranch.Show()
        lblcname.Show()
        cmbbranchname.Hide()
        getId()
        getAllCourse()
        btnsave.LabelText = "Save"
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        btnsave.Show()
        resetall()
        lblbid.Show()
        showbid.Show()
        lblbname.Show()
        lblnewbranch.Hide()
        txtnewbranch.Hide()
        cmbcoursename.Show()
        lblcname.Show()
        txtbranch.Hide()
        DataGridView1.Hide()
        cmbbranchname.Show()
        getAllCourse()
        btnsave.LabelText = "Delete"
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        lblbid.Show()
        showbid.Show()
        cmbbranchname.Show()
        lblnewbranch.Show()
        txtnewbranch.Show()
        btnsave.Show()
        DataGridView1.Hide()
        lblbname.Show()
        cmbcoursename.Show()
        lblcname.Show()
        resetall()
        getAllCourse()
        btnsave.LabelText = "Update"
        txtbranch.Hide()
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        DataGridView1.Rows.Clear()
        Dim branch_id As String
        Dim branch_name As String
        Dim course_id As String
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As SqlCommand = New SqlCommand("Select branch_id,course_id,branch_name from branch_table", con)
        con.Open()
        Dim rdr As SqlDataReader = com.ExecuteReader
        While rdr.Read
            branch_id = rdr("branch_id")
            course_id = rdr("course_id")
            branch_name = rdr("branch_name")
            DataGridView1.Rows.Add(branch_id, course_id, branch_name)
        End While

        btnsave.Hide()
        DataGridView1.Show()
        showbid.Hide()
        cmbbranchname.Hide()
        lblnewbranch.Hide()
        lblbid.Hide()
        txtnewbranch.Hide()
        lblbname.Hide()
        cmbcoursename.Hide()
        lblcname.Hide()
        txtbranch.Hide()
    End Sub

    Private Sub cmbbranchname_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbranchname.onItemSelected
        If cmbbranchname.selectedValue <> "" Then
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd1 As SqlCommand = New SqlCommand("SELECT branch_id from branch_table Where branch_name='" & cmbbranchname.selectedValue & "'")
            cmd1.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd1.ExecuteReader()
            If (rdr.Read() = True) Then
                showbid.Text = rdr("branch_id")
            End If
        End If
    End Sub

    Private Sub cmbcoursename_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcoursename.onItemSelected
        getcourseId()
        getAllBranchesofParticularCourse()
    End Sub
End Class
