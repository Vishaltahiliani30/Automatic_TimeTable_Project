Imports System.Data.SqlClient
Public Class forgotpassword
    Dim conn As New SqlConnection
    Dim Myconnection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True"
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter

    Dim result As Integer
    Dim sql As String
    Private Sub cmbsq_onItemSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsq.onItemSelected

    End Sub

    Private Sub btnminimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
        login2.Show()
    End Sub


    Private Sub btnupdatepassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdatepassword.Click
        If txtnewpassword.Text = txtconfirmpassword.Text Then
            updatepassword()
            Me.Hide()
            login2.Show()
        Else
            MsgBox("Your Password is Not Matched", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub getShowPassword()
        If chkshowpassword.Checked = True Then
            txtconfirmpassword.isPassword = False
            txtnewpassword.isPassword = False
        Else
            txtnewpassword.isPassword = True
            txtconfirmpassword.isPassword = True
        End If
    End Sub

    Private Sub forgotpassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtnewpassword.isPassword = True
        txtconfirmpassword.isPassword = True
        txtconfirmpassword.Enabled = False
    End Sub

    Private Sub chkshowpassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkshowpassword.CheckedChanged
        getShowPassword()
    End Sub
    Private Sub updatepassword()
        Try
            If txtconfirmpassword.Text = txtnewpassword.Text Then
                Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
                Dim cmd As SqlCommand = New SqlCommand("UPDATE Login Set Password = '" & txtconfirmpassword.Text & "' where Username ='" & txtusername.Text & "'")
                cmd.Connection = con
                con.Open()
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("Paasword Changed Successfully !")
                    'outcust()
                Else
                    MsgBox("Password is Not Changed !")
                End If
                con.Close()
            Else
                MsgBox("Password MustBe Same", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim usrname As String

    Private Sub txtusername_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.Leave
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("select Username from Login where Username = '" & txtusername.Text & "'")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader

            If (rdr.Read() = True) Then
                usrname = rdr("Username")
                getdata()
            Else
                MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical)
                isfound = 0
                cmbsq.Focus()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim isfound As Integer
    Private Sub getdata()
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("select security_question from Login where Username = '" & txtusername.Text & "'")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader

            If (rdr.Read() = True) Then
                If txtusername.Text = usrname Then
                    cmbsq.AddItem(rdr("security_question"))
                End If

            Else
                MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical)
                isfound = 0
                cmbsq.Focus()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim Answer As String

    Private Sub txtans_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtans.Leave
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("select answer from Login where security_question = '" & cmbsq.selectedValue & "'")
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader

            If (rdr.Read() = True) Then
                Answer = rdr("answer")
                If Answer = txtans.Text Then
                    'MsgBox("Your Answer is Correct")
                    txtnewpassword.Enabled = True
                    txtconfirmpassword.Enabled = True
                Else
                    MsgBox("Yor Answer Is Incorrect")
                End If
            Else
                MsgBox("ERROR : No Record Found ", MsgBoxStyle.Critical)
                isfound = 0
                cmbsq.Focus()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class