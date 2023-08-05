Imports System.Data.SqlClient
Public Class Addclassroom
    Dim conn As New SqlConnection
    Dim Myconnection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim result As Integer
    Dim sql As String
    Private Sub showsid_Click(sender As System.Object, e As System.EventArgs) Handles showsid.Click

    End Sub

    Private Sub Addclassroom_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnadd.LabelText = "Add Classroom"
        btndelete.LabelText = "Delete Classroom"
        btnupdate.LabelText = "Update Classroom"
        btnview.LabelText = "View Classroom"
        lblcid.Hide()
        showsid.Hide()
        lblcname.Hide()
        cmbcoursename.Hide()
        lblbname.Hide()
        cmbbranchname.Hide()
        lblsemester.Hide()
        cmbsemester.Hide()
        lblcrname.Hide()
        txtclassname.Hide()
        lblclasstype.Hide()
        cmbclasstype.Hide()
        btnsave.Hide()
        lblnewclassroom.Hide()
        txtnewclassroom.Hide()
        cmbclassroom.Hide()
        lblcoursename.Hide()
        lblbranchname.Hide()
        lblsemestername.Hide()
        lblctype.Hide()
        DataGridView1.Hide()
    End Sub

    Private Sub btnadd_Click(sender As System.Object, e As System.EventArgs) Handles btnadd.Click
        btnsave.LabelText = "Save"
        btnsave.Show()
        lblcid.Show()
        showsid.Show()
        lblcname.Show()
        cmbcoursename.Show()
        lblbname.Show()
        cmbbranchname.Show()
        lblsemester.Show()
        cmbsemester.Show()
        lblcrname.Show()
        txtclassname.Show()
        lblclasstype.Show()
        cmbclasstype.Show()
        lblnewclassroom.Hide()
        txtnewclassroom.Hide()
        cmbclassroom.Hide()
        lblcoursename.Hide()
        lblbranchname.Hide()
        lblsemestername.Hide()
        lblctype.Hide()
        resetall()
        getcId()
        DataGridView1.Hide()
        getAllCourse()
    End Sub
    Private Sub getcId()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("SELECT MAX(class_id) + 1 as Id FROM classroom_table", con)
            showsid.Text = cmd.ExecuteScalar().ToString()
            If showsid.Text = "" Then
                showsid.Text = 1
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
    Dim Semestername As String = ""
    Private Sub getSemesterId()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT semester_name from semester_table where semester_name = '" & cmbsemester.selectedValue & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            Semestername = rdr("semester_name")
        End While
        con.Close()
    End Sub
    Private Sub getAllclassroomofParticularSemester()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT class_name from classroom_table where  semester_name = '" & Semestername & "'")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbclassroom.AddItem(rdr("class_name"))
        End While
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

    Private Sub cmbbranchname_onItemSelected(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub resetall()
        cmbcoursename.Clear()
        cmbbranchname.Clear()
        cmbsemester.Clear()
        txtclassname.Text = ""
        cmbclassroom.Clear()
        txtnewclassroom.Text = ""
        lblcoursename.Text = "-"
        lblbranchname.Text = "-"
        lblsemestername.Text = "-"
        lblctype.Text = "-"
        showsid.Text = "-"
        cmbclasstype.Clear()
        cmbclasstype.AddItem("ClassRoom")
        cmbclasstype.AddItem("Lab")
        getAllCourse()
    End Sub
    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        If btnsave.LabelText = "Save" Then
            If cmbcoursename.selectedIndex <> "-1" And cmbbranchname.selectedIndex <> "-1" And cmbsemester.selectedIndex <> "-1" And cmbclasstype.selectedIndex <> "-1" And txtclassname.Text <> "" Then
                Try

                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "INSERT INTO classroom_table VALUES (" & Convert.ToInt32(showsid.Text) & ", '" & cmbcoursename.selectedValue & "','" & cmbbranchname.selectedValue & "', '" & cmbsemester.selectedValue & "', '" & txtclassname.Text & "' , '" & cmbclasstype.selectedValue & "' )"
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Record hass been Saved!")
                        resetall()
                    Else
                        MsgBox("No record has been saved!")
                        resetall()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MsgBox("Please Enter All Values")
            End If
        ElseIf btnsave.LabelText = "Update" Then
            If txtnewclassroom.Text <> "" And cmbcoursename.selectedIndex <> "-1" And cmbbranchname.selectedIndex <> "-1" And cmbsemester.selectedIndex <> "-1" And cmbclasstype.selectedIndex <> "-1" Then

            End If
        ElseIf btnsave.LabelText = "Delete" Then
            If cmbclassroom.selectedIndex <> "-1" Then
                Try

                    conn.ConnectionString = Myconnection
                    conn.Open()
                    sql = "Delete from classroom_table where class_id=" & showsid.Text
                    cmd.Connection = conn
                    cmd.CommandText = sql
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery()
                    If r > 0 Then
                        MsgBox("Record hass been Deleted!")
                        resetall()
                        getallclassroom()
                    Else
                        MsgBox("No record has been Deleted!")
                        resetall()
                        getallclassroom()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MsgBox("Please Select Classroom Fisrt")
            End If
        End If
        conn.Close()
    End Sub

    Private Sub btnupdate_Click(sender As System.Object, e As System.EventArgs) Handles btnupdate.Click
        btnsave.LabelText = "Update"
        btnsave.Show()
        lblcid.Show()
        showsid.Show()
        lblcname.Show()
        cmbcoursename.Show()
        lblbname.Show()
        cmbbranchname.Show()
        lblsemester.Show()
        cmbsemester.Show()
        lblcrname.Show()
        txtclassname.Hide()
        lblclasstype.Show()
        cmbclasstype.Show()
        lblnewclassroom.Show()
        txtnewclassroom.Show()
        cmbclassroom.Show()
        lblcoursename.Hide()
        lblbranchname.Hide()
        lblsemestername.Hide()
        lblctype.Hide()
        resetall()
        getcId()
        getAllCourse()
        getallclassroom()
        DataGridView1.Hide()
    End Sub

    Private Sub txtnewclassroom_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnewclassroom.TextChanged

    End Sub

    Private Sub txtnewclassroom_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles txtnewclassroom.MouseClick
        If cmbclassroom.selectedIndex = -1 Then
            MsgBox("Please Select Classroom First")
        End If
    End Sub

    Private Sub cmbsemester_onItemSelected(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cmbclassroom_onItemSelected(sender As System.Object, e As System.EventArgs)
        getalldatafordelete()
    End Sub

    Private Sub btndelete_Click(sender As System.Object, e As System.EventArgs) Handles btndelete.Click
        lblcid.Show()
        showsid.Show()
        lblcname.Show()
        cmbcoursename.Hide()
        lblcoursename.Show()
        lblbname.Show()
        cmbbranchname.Hide()
        lblbranchname.Show()
        lblsemester.Show()
        cmbsemester.Hide()
        lblsemestername.Show()
        lblclasstype.Show()
        cmbclasstype.Hide()
        lblctype.Show()
        lblcrname.Show()
        cmbclassroom.Show()
        lblnewclassroom.Hide()
        txtnewclassroom.Hide()
        btnsave.Show()
        btnsave.LabelText = "Delete"
        showsid.Text = "-"
        getallclassroom()
        DataGridView1.Hide()
    End Sub
    Private Sub getallclassroom()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT class_name from classroom_table ")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbclassroom.AddItem(rdr("class_name"))
        End While
    End Sub
    Private Sub getalldatafordelete()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT * from classroom_table where class_name ='" & cmbclassroom.selectedValue & "'")
        If cmbclassroom.selectedValue <> "" Then


            cmd1.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd1.ExecuteReader()
            If (rdr.Read() = True) Then
                showsid.Text = rdr("class_id")
                lblcoursename.Text = rdr("course_name")
                lblbranchname.Text = rdr("branch_name")
                lblsemestername.Text = rdr("semester_name")
                lblctype.Text = rdr("class_type")
            Else
                MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical, "Student Grade Calculator")
                resetall()
                cmbclassroom.Focus()
            End If
        Else
            cmbclassroom.Focus()
        End If
        con.Close()
    End Sub
    Private Sub cmbcoursename_onItemSelected(sender As System.Object, e As System.EventArgs) Handles cmbcoursename.onItemSelected
        getcourseId()
        getAllBranchesofParticularCourse()
    End Sub

    Private Sub cmbbranchname_onItemSelected_1(sender As System.Object, e As System.EventArgs) Handles cmbbranchname.onItemSelected
        getBranchId()
        getAllSemesterofParticularBranch()
    End Sub

    Private Sub cmbsemester_onItemSelected_1(sender As System.Object, e As System.EventArgs) Handles cmbsemester.onItemSelected
        getSemesterId()
        getAllclassroomofParticularSemester()
    End Sub

    Private Sub cmbclasstype_onItemSelected(sender As System.Object, e As System.EventArgs) Handles cmbclasstype.onItemSelected

    End Sub

    Private Sub cmbclassroom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cmbclassroom_onItemSelected_1(sender As System.Object, e As System.EventArgs) Handles cmbclassroom.onItemSelected
        getalldatafordelete()
    End Sub

    Private Sub btnview_Click(sender As System.Object, e As System.EventArgs) Handles btnview.Click
        lblcid.Hide()
        showsid.Hide()
        lblcname.Hide()
        cmbcoursename.Hide()
        lblbname.Hide()
        cmbbranchname.Hide()
        lblsemester.Hide()
        cmbsemester.Hide()
        lblcrname.Hide()
        txtclassname.Hide()
        lblclasstype.Hide()
        cmbclasstype.Hide()
        btnsave.Hide()
        lblnewclassroom.Hide()
        txtnewclassroom.Hide()
        cmbclassroom.Hide()
        lblcoursename.Hide()
        lblbranchname.Hide()
        lblsemestername.Hide()
        lblctype.Hide()
        DataGridView1.Show()
        Dim class_id As String
        Dim course_name As String
        Dim branch_name As String
        Dim semester_name As String
        Dim class_type As String
        Dim class_name As String
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As SqlCommand = New SqlCommand("Select * from classroom_table", con)
        con.Open()
        Dim rdr As SqlDataReader = com.ExecuteReader
        While rdr.Read
            class_id = rdr("class_id")
            course_name = rdr("course_name")
            branch_name = rdr("branch_name")
            semester_name = rdr("semester_name")
            class_name = rdr("class_name")
            class_type = rdr("class_type")
            DataGridView1.Rows.Add(class_id, course_name, branch_name, semester_name, class_name, class_type)
        End While
    End Sub
End Class
