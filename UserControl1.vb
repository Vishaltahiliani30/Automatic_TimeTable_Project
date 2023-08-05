Imports System.Data.SqlClient
Public Class UserControl1

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
        ' getsubjects()
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

    Private Sub UserControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getAllCourse()

    End Sub

    Private Sub BunifuFlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton1.Click
        lblBName.Text = cmbbranchname.selectedValue
        lblCName.Text = cmbcoursename.selectedValue
        lblcurrentdate.Text = Date.Now.ToString("dd-MM-yyyy")
        lblSemName.Text = cmbsemester.selectedValue
        getSemesterId()
        getSemesterTimeTable()
    End Sub
    Dim message As String = ""
    Dim num(6, 6) As String
    Dim u As Integer
    Dim p As Integer
    Private Sub getSemesterTimeTable()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT * from time_table where semester_id =" & SemesterId & "")
        If cmbsemester.selectedValue <> "" Then
            cmd1.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd1.ExecuteReader()
            While (rdr.Read() = True)
                If rdr("Day") = "Mon" Then
                    u = 0
                ElseIf rdr("Day") = "Tue" Then
                    u = 1
                ElseIf rdr("Day") = "Wed" Then
                    u = 2
                ElseIf rdr("Day") = "Thu" Then
                    u = 3
                ElseIf rdr("Day") = "Fri" Then
                    u = 4
                ElseIf rdr("Day") = "Sat" Then
                    u = 5
                End If
                p = rdr("lec_no")
                num(u, p) = rdr("lec_name")
            End While
            con.Close()
            Dim message As String = ""
            For Each textBox As Label In BunifuGradientPanel1.Controls.OfType(Of Label)()
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

        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.BunifuGradientPanel1.Width, Me.BunifuGradientPanel1.Height)
        BunifuGradientPanel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.BunifuGradientPanel1.Width, Me.BunifuGradientPanel1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub


    Private Sub BunifuFlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton2.Click
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()

        'PrintDocument1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintDocument1.PrinterSettings.PrinterName = My.Settings.printer
        'PrintDocument1.Print()
    End Sub
End Class
