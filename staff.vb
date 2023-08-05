Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic
Public Class staff
    Dim conn As New SqlConnection
    Dim Myconnection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim result As Integer
    Dim sql As String


    Private Sub staff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblnewstaff.Hide()
        txtnewstaff.Hide()
        btnadd.LabelText = "Add Staff"
        btndelete.LabelText = "Delete Staff"
        btnupdate.LabelText = "Update Staff"
        btnview.LabelText = "View Staff"
        lblsfid.Hide()
        lblshowid.Hide()
        lblsfname.Hide()
        txtstaffname.Hide()
        lblstaffgender.Hide()
        rdbmale.Hide()
        rdbfemale.Hide()
        lblstaff_mo_no.Hide()
        txtstaff_mo_no.Hide()
        lblstaff_email.Hide()
        txtstaffemail.Hide()
        btnsave.Hide()
        cmbstaffname.Hide()
        DataGridView1.Hide()
        lblgendername.Hide()
        lblemail.Hide()
        lblmobile.Hide()
    End Sub

    Private Sub lblsfid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblsfid.Click

    End Sub
    Private Sub getId()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("SELECT MAX(staff_id) + 1 as Id FROM staff_table", con)
            lblshowid.Text = cmd.ExecuteScalar().ToString()
            If lblshowid.Text = "" Then
                lblshowid.Text = 1
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim gender As String
    Private Sub getgender()
        If rdbmale.Checked = True Then
            gender = "Male"
        ElseIf rdbfemale.Checked = True Then
            gender = "Female"
        End If
    End Sub
    Private Sub resetAll()
        txtstaffname.Text = ""
        rdbmale.Checked = False
        rdbfemale.Checked = False
        txtstaff_mo_no.Text = ""
        txtstaffemail.Text = ""
        lblgendername.Text = "-"
        lblmobile.Text = "-"
        lblemail.Text = "-"
        cmbstaffname.Clear()
        txtnewstaff.Text = ""
    End Sub
    Private Sub getallstaff()
        'cmbstaffname.Clear()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT * from staff_table order by staff_name")
        cmd1.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd1.ExecuteReader()
        While (rdr.Read() = True)
            cmbstaffname.AddItem(rdr("staff_name"))
        End While
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If btnsave.LabelText = "Save" Then
            Try
                getgender()
                conn.ConnectionString = Myconnection
                conn.Open()
                sql = "INSERT INTO staff_table VALUES (" & Convert.ToInt32(lblshowid.Text) & ", '" & txtstaffname.Text & "','" & gender & "'," & txtstaff_mo_no.Text & ",'" & txtstaffemail.Text & "')"
                cmd.Connection = conn
                cmd.CommandText = sql
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Staff Record hass been Saved!")
                    getId()
                    resetAll()
                Else
                    MsgBox("No record has been saved!")
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf btnsave.LabelText = "Update" Then

            Try
                'Radio Button Logic
                Dim gender As String = ""
                If rdbmale.Checked = True Then
                    gender = "Male"
                Else
                    gender = "Female"
                End If


                conn.ConnectionString = Myconnection
                conn.Open()

                sql = "UPDATE staff_table SET staff_name='" & txtnewstaff.Text & "', staff_gender='" & gender & "', staff_mobile_no='" & txtstaff_mo_no.Text & "',staff_email='" & txtstaffemail.Text & "' where staff_id='" & lblshowid.Text & "'"


                cmd.Connection = conn
                cmd.CommandText = sql
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Staff Record has been Updated!")
                    cmbstaffname.Clear()
                    resetAll()
                    'cmbstaffname.Clear()

                    lblshowid.Text = "-"
                    getallstaff()
                    'getStaffDetails()


                Else
                    MsgBox("No record has been updated!")
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf btnsave.LabelText = "Delete" Then

            cmbstaffname.Clear()
            Try

                conn.ConnectionString = Myconnection
                conn.Open()

                sql = "Delete from staff_table where staff_id=" & lblshowid.Text


                cmd.Connection = conn
                cmd.CommandText = sql
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Staff Record Deleted!")
                    resetAll()
                    ' cmbstaffname.selectedIndex = -1
                    lblshowid.Text = "-"
                    'cmbstaffname.Clear()


                    resetAll()
                    getallstaff()
                Else
                    MsgBox("No record has been Deleted!")

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub txtstaffemail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbstaffname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        lblnewstaff.Hide()
        txtnewstaff.Hide()
        lblsfid.Show()
        lblshowid.Show()
        lblsfname.Show()
        txtstaffname.Show()
        cmbstaffname.Hide()
        lblstaffgender.Show()
        rdbmale.Show()
        rdbfemale.Show()
        lblstaff_mo_no.Show()
        txtstaff_mo_no.Show()
        lblstaff_email.Show()
        txtstaffemail.Show()
        btnsave.Show()
        btnsave.LabelText = "Save"
        getId()
        DataGridView1.Hide()
        lblgendername.Hide()
        lblemail.Hide()
        lblmobile.Hide()
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        DataGridView1.Rows.Clear()
        lblnewstaff.Hide()
        txtnewstaff.Hide()
        Dim staffid As String
        Dim staffname As String
        Dim staffgender As String
        Dim staffno As String
        Dim staffemail As String
        Dim str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
        Dim con As New SqlConnection(str)
        Dim com As SqlCommand = New SqlCommand("Select staff_id,staff_name,staff_gender,staff_mobile_no,staff_email from staff_table", con)
        con.Open()
        Dim rdr As SqlDataReader = com.ExecuteReader
        While rdr.Read
            staffid = rdr("staff_id")
            staffname = rdr("staff_name")
            staffgender = rdr("staff_gender")
            staffemail = rdr("staff_email")
            staffno = rdr("staff_mobile_no")
            DataGridView1.Rows.Add(staffid, staffname, staffgender, staffno, staffemail)
        End While
        lblsfid.Hide()
        lblshowid.Hide()
        lblsfname.Hide()
        txtstaffname.Hide()
        lblstaffgender.Hide()
        rdbmale.Hide()
        rdbfemale.Hide()
        lblstaff_mo_no.Hide()
        txtstaff_mo_no.Hide()
        lblstaff_email.Hide()
        txtstaffemail.Hide()
        btnsave.Hide()
        cmbstaffname.Hide()
        DataGridView1.Show()
        lblgendername.Hide()
        lblemail.Hide()
        lblmobile.Hide()

    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        lblnewstaff.Show()
        txtnewstaff.Show()
        cmbstaffname.Clear()
        lblsfid.Show()
        lblshowid.Show()
        lblsfname.Show()
        txtstaffname.Hide()
        cmbstaffname.Show()
        lblstaffgender.Show()
        rdbmale.Show()
        rdbfemale.Show()
        lblstaff_mo_no.Show()
        txtstaff_mo_no.Show()
        lblstaff_email.Show()
        txtstaffemail.Show()
        btnsave.Show()
        btnsave.LabelText = "Update"
        lblshowid.Text = "-"
        DataGridView1.Hide()
        getallstaff()
        lblgendername.Hide()
        lblemail.Hide()
        lblmobile.Hide()
    End Sub

    Private Sub txtstaffname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub txtstaff_mo_no_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub txtstaff_mo_no_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim isfound As Integer
    Private Sub getStaffDetails()
        isfound = 1
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT * from staff_table where staff_name ='" & cmbstaffname.selectedValue & "'")
        If cmbstaffname.selectedValue <> "" Then


            cmd1.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd1.ExecuteReader()
            If (rdr.Read() = True) Then
                lblshowid.Text = rdr("staff_id")

                Dim gender As String
                gender = rdr("staff_gender")
                If gender = "Male" Then
                    rdbmale.Checked = True
                Else
                    rdbfemale.Checked = True
                End If
                If btnsave.LabelText = "Update" Then
                    txtstaff_mo_no.Text = rdr("staff_mobile_no")
                    txtstaffemail.Text = rdr("staff_email")
                ElseIf btnsave.LabelText = "Delete" Then
                    lblmobile.Text = rdr("staff_mobile_no")
                    lblgendername.Text = rdr("staff_gender")
                    lblemail.Text = rdr("staff_email")
                End If

            Else
                MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical, "Student Grade Calculator")
                isfound = 0
                resetAll()
                cmbstaffname.Focus()
            End If
        Else
            cmbstaffname.Focus()
        End If
        con.Close()
    End Sub
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        lblnewstaff.Hide()
        txtnewstaff.Hide()
        cmbstaffname.Clear()
        resetAll()
        lblsfid.Show()
        lblshowid.Show()
        lblsfname.Show()
        txtstaffname.Hide()
        cmbstaffname.Show()
        lblstaffgender.Show()
        rdbmale.Hide()
        rdbfemale.Hide()
        lblgendername.Show()
        lblstaff_mo_no.Show()
        txtstaff_mo_no.Hide()
        lblmobile.Show()
        lblstaff_email.Show()
        txtstaffemail.Hide()
        lblemail.Show()
        btnsave.Show()
        btnsave.LabelText = "Delete"
        lblshowid.Text = "-"
        DataGridView1.Hide()
        getallstaff()

    End Sub

    Private Sub cmbstaffname_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstaffname.onItemSelected
        'MsgBox(cmbstaffname.Items.Count)
        If cmbstaffname.selectedValue <> "" Then
            'cmbsemester.SelectedIndex = 0
            getStaffDetails()
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd1 As SqlCommand = New SqlCommand("SELECT staff_id from staff_table Where staff_name='" & cmbstaffname.selectedValue & "'")
            cmd1.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd1.ExecuteReader()
            If (rdr.Read() = True) Then
                lblshowid.Text = rdr("staff_id")
            End If
        End If
    End Sub

    Private Sub txtstaffemail_Leave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstaffemail.Leave
        Dim pattern As String
        pattern = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(txtstaffemail.Text, pattern) Then
        Else
            MsgBox("Not a valid Email address ")
            txtstaffemail.Focus()
        End If
    End Sub

    Private Sub txtstaff_mo_no_Leave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstaff_mo_no.Leave
        If txtstaff_mo_no.Text.Length < 10 Then
            MessageBox.Show("Enter Valid Number")
        End If
    End Sub

    Private Sub txtstaff_mo_no_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstaff_mo_no.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "0" AndAlso e.KeyChar <= "9")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Number!")
        End If
    End Sub

    Private Sub txtstaffemail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstaffemail.KeyPress

        'If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "z") OrElse (e.KeyChar = "@" AndAlso e.KeyChar = ".")) Then
        '    e.Handled = True
        '    MessageBox.Show("You Can Enter Only Character!")
        'End If
    End Sub
End Class
