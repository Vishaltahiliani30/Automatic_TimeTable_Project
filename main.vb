Imports System.Data.SqlClient
Public Class main

    Private Sub BunifuImageButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuImageButton2.Click
        Application.Exit()

    End Sub

    Private Sub BunifuImageButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuImageButton1.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BunifuImageButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuFlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton1.Click
        Dim uc As New course
        addNewCourseControl(uc)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub addNewCourseControl(ByVal uc As course)
        mainmanu.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        mainmanu.Controls.Add(uc)
    End Sub

    Private Sub btnlogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogo.Click
        If (Sidemenu.Width = 50) Then

            Sidemenu.Visible = False
            Sidemenu.Width = 360
            PanelTransition.ShowSync(Sidemenu)


        Else

            Sidemenu.Visible = False
            Sidemenu.Width = 50
            PanelTransition.ShowSync(Sidemenu)


        End If
    End Sub

    Private Sub mainmanu_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles mainmanu.Paint

    End Sub

    Private Sub btnsemesterandbranch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsemesterandbranch.Click
        Dim uc As New Branch
        addNewBranchControl(uc)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub addNewBranchControl(ByVal uc As Branch)
        mainmanu.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        mainmanu.Controls.Add(uc)
    End Sub
    Private Sub addNewBranchControl(ByVal uc As btnGenerate)
        mainmanu.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        mainmanu.Controls.Add(uc)
    End Sub
    Private Sub BunifuFlatButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton5.Click
        Dim uc As New btnGenerate
        addNewBranchControl(uc)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub addNewSemesterControl(ByVal uc As Semester)
        mainmanu.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        mainmanu.Controls.Add(uc)
    End Sub
    Private Sub BunifuFlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton2.Click
        Dim uc As New Semester
        addNewSemesterControl(uc)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BunifuFlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton4.Click
        Dim uc As New staff
        addNewSemesterControl(uc)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub addNewSemesterControl(ByVal uc As staff)
        mainmanu.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        mainmanu.Controls.Add(uc)
    End Sub

    Private Sub BunifuFlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton3.Click
        Dim uc As New subject
        addNewSemesterControl(uc)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub addNewSemesterControl(ByVal uc As subject)
        mainmanu.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        mainmanu.Controls.Add(uc)
    End Sub

    Private Sub BunifuFlatButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton6.Click
        Dim uc As New lecture_credits
        addNewSemesterControl(uc)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub addNewSemesterControl(ByVal uc As lecture_credits)
        mainmanu.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        mainmanu.Controls.Add(uc)
    End Sub

    Private Sub BunifuFlatButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton7.Click
        Dim uc As New Assign_subject
        addNewSemesterControl(uc)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub addNewSemesterControl(ByVal uc As Assign_subject)
        mainmanu.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        mainmanu.Controls.Add(uc)
    End Sub


    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        coursedetail()
        branchdetail()
        semesterdetail()
        staffdetail()
        subjectdetail()
    End Sub
    Private Sub coursedetail()
        lblcoursedetail.Text = "Course (counted" & vbCrLf & "on the basis" & vbCrLf & "of 10 courses)"
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("Select count(*) from course_table")
        Dim per As Integer
        Dim n As Integer = 10
        Dim a As Integer
        cmd1.Connection = con
        con.Open()
        a = cmd1.ExecuteScalar()
        per = (a * 100) / n
        courseprogressbar.Value = per

    End Sub
    Private Sub branchdetail()
        lblbranchdetail.Text = "Branches (counted" & vbCrLf & "on the basis" & vbCrLf & "of 20 branches)"
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("Select count(*) from branch_table")
        Dim per As Integer
        Dim n As Integer = 20
        Dim a As Integer
        cmd1.Connection = con
        con.Open()
        a = cmd1.ExecuteScalar()
        per = (a * 100) / n
        branchprogressbar.Value = per

    End Sub
    Private Sub subjectdetail()
        lblsubjectdetail.Text = "Subjects (counted" & vbCrLf & "on the basis" & vbCrLf & "of 50 subjects)"
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("Select count(*) from subject_table")
        Dim per As Integer
        Dim n As Integer = 50
        Dim a As Integer
        cmd1.Connection = con
        con.Open()
        a = cmd1.ExecuteScalar()
        per = (a * 100) / n
        subjectprogressbar.Value = per

    End Sub
    Private Sub semesterdetail()
        lblsemesterdetail.Text = "Semesters (counted" & vbCrLf & "on the basis" & vbCrLf & "of 20 semesters)"
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("Select count(*) from semester_table")
        Dim per As Integer
        Dim n As Integer = 20
        Dim a As Integer
        cmd1.Connection = con
        con.Open()
        a = cmd1.ExecuteScalar()
        per = (a * 100) / n
        semesterprogressbar.Value = per

    End Sub
    Private Sub staffdetail()
        lblstaffdetail.Text = "Staff (counted" & vbCrLf & "on the basis" & vbCrLf & "of 20 staff members)"
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("Select count(*) from staff_table")
        Dim per As Integer
        Dim n As Integer = 20
        Dim a As Integer
        cmd1.Connection = con
        con.Open()
        a = cmd1.ExecuteScalar()
        per = (a * 100) / n
        staffprogressbar.Value = per

    End Sub

    Private Sub BunifuFlatButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton8.Click
        Dim uc As New UserControl1
        addNewSemesterControl(uc)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub addNewSemesterControl(ByVal uc As UserControl1)
        mainmanu.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        mainmanu.Controls.Add(uc)
    End Sub

    Private Sub BunifuFlatButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton9.Click
        Dim uc As New settings
        addNewSemesterControl(uc)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub addNewSemesterControl(ByVal uc As settings)
        mainmanu.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        mainmanu.Controls.Add(uc)
    End Sub

    Private Sub addNewSemesterControl(ByVal uc As Addclassroom)
        mainmanu.Controls.Clear()
        uc.Dock = DockStyle.Fill
        uc.BringToFront()
        mainmanu.Controls.Add(uc)
    End Sub
    Private Sub BunifuFlatButton10_Click(sender As System.Object, e As System.EventArgs) Handles BunifuFlatButton10.Click
        Dim uc As New Addclassroom
        addNewSemesterControl(uc)
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class