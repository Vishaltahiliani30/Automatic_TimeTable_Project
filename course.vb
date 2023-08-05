Imports System.Data.SqlClient
Public Class course
    Dim conn As New SqlConnection
    Dim Myconnection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter

    Dim result As Integer
    Dim sql As String
    Private Sub getAllCourses()
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


    Private Sub resetAll()
        cmbcoursename.selectedIndex = -1
        txtcname.Text = ""
        txtnewcourse.Text = ""
    End Sub
    Private Sub getId()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("SELECT MAX(course_id) + 1 as Id FROM course_table", con)
            lblid.Text = cmd.ExecuteScalar().ToString()
            If lblid.Text = "" Then
                lblid.Text = 1
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BunifuTileButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If btnsave.LabelText = "Save" Then
            Try
                If txtcname.Text <> "" Then
                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "INSERT INTO course_table VALUES (" & Convert.ToInt32(lblid.Text) & ", '" & txtcname.Text & "')"
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Course Record hass been Saved!")
                        getId()
                        resetAll()
                    Else
                        MsgBox("No record has been saved!")
                    End If
                Else
                    MsgBox("No record has been saved!")
                    resetAll()
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf btnsave.LabelText = "Update" Then

            Try
                If txtnewcourse.Text <> "" Then
                    conn.ConnectionString = Myconnection
                    conn.Open()

                    sql = "UPDATE course_table SET course_name='" & txtnewcourse.Text & "' where course_id=" & lblid.Text


                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Course Updated!")
                        'cmbcoursename.SelectedIndex = -1
                        txtnewcourse.Text = ""
                        lblid.Text = "-"
                        cmbcoursename.selectedIndex = -1
                        getAllCourses()
                    Else
                        MsgBox("No record has been updated!")
                    End If
                Else
                    MsgBox("No record has been updated!")

                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf btnsave.LabelText = "Delete" Then
            Try
                If lblid.Text <> "-" Then
                    conn.ConnectionString = Myconnection
                    conn.Open()

                    sql = "Delete from course_table where course_id=" & lblid.Text

                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Course Deleted!")
                        'cmbcoursename.SelectedIndex = -1
                        lblid.Text = "-"
                        cmbcoursename.selectedIndex = -1
                        cmbcoursename.Clear()
                        getAllCourses()
                    Else
                        MsgBox("No record has been Deleted!")
                    End If
                Else
                    MsgBox("No record has been Deleted!")
                    lblid.Text = "-"
                    cmbcoursename.selectedIndex = -1
                    cmbcoursename.Clear()
                    getAllCourses()
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    Private Sub course_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnadd.LabelText = "Add Course"
        btndelete.LabelText = "Delete Course"
        btnupdate.LabelText = "Update Course"
        btnview.LabelText = "View Course"
        lblcid.Hide()
        lblid.Hide()
        txtcname.Hide()
        txtcoursename.Hide()
        btnsave.Hide()
        DataGridView1.Hide()
        cmbcoursename.Hide()
        lblnewcourse.Hide()
        txtnewcourse.Hide()
    End Sub
    Private Sub cmbcoursename_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        lblcid.Show()
        DataGridView1.Hide()
        lblid.Show()
        txtcname.Show()
        btnsave.LabelText = "Save"
        txtcoursename.Show()
        btnsave.Show()
        lblnewcourse.Hide()
        txtnewcourse.Hide()
        cmbcoursename.Hide()
        getId()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        lblnewcourse.Hide()
        txtnewcourse.Hide()
        DataGridView1.Hide()
        txtcname.Hide()
        btnsave.Show()
        lblcid.Show()
        lblid.Show()
        txtcoursename.Show()
        cmbcoursename.Show()
        btnsave.LabelText = "Delete"
        getAllCourses()
        lblid.Text = "-"
        resetAll()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        lblcid.Show()
        lblid.Show()
        txtcname.Hide()
        lblid.Text = "-"
        btnsave.LabelText = "Update"
        lblnewcourse.Show()
        txtcoursename.Show()
        txtnewcourse.Show()
        cmbcoursename.Show()
        DataGridView1.Hide()
        cmbcoursename.Show()
        btnsave.Show()
        getAllCourses()
        resetAll()
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        DataGridView1.Rows.Clear()
        Dim course_id As String
        Dim course_name As String
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As SqlCommand = New SqlCommand("Select course_id,course_name from course_table", con)
        con.Open()
        Dim rdr As SqlDataReader = com.ExecuteReader
        While rdr.Read
            course_id = rdr("course_id")
            course_name = rdr("course_name")
            DataGridView1.Rows.Add(course_id, course_name)
        End While

        lblcid.Hide()
        lblid.Hide()
        txtcname.Hide()
        txtcoursename.Hide()
        btnsave.Hide()
        DataGridView1.Show()
        cmbcoursename.Hide()
        lblnewcourse.Hide()
        txtnewcourse.Hide()
    End Sub

    Private Sub cmbcoursename_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcoursename.onItemSelected
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT course_id from course_table Where course_name='" & cmbcoursename.selectedValue & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        If (rdr.Read() = True) Then
            lblid.Text = rdr("course_id")
        End If
        txtnewcourse.Enabled = True
    End Sub
End Class
