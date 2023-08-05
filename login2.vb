Imports System.Data.SqlClient
Public Class login2

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblpassword.Click

    End Sub

   
    Dim cnt As Integer
    
    Private Sub clearControls()
        txtusername.text = ""
        txtpassword.Text = ""
        txtusername.Focus()
    End Sub
    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblusername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblusername.Click

    End Sub

    Private Sub pct2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub login2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblheading.Text = "    Smart" & vbCrLf & "Time Table" & vbCrLf & " Generator"

    End Sub

    Private Sub lblheading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblheading.Click

    End Sub

    Private Sub btnlogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Project\Login.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("Select * from Login where [username] = @uname and [password] = @pass")
        If txtusername.text <> "" And txtpassword.Text <> "" Then

            cmd.Parameters.AddWithValue("uname", txtusername.text)
            cmd.Parameters.AddWithValue("pass", txtpassword.Text)
            Dim user As String = ""
            Dim pass As String = ""
            cmd.Connection = con
            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            If (rdr.Read() = True) Then
                user = rdr("UserName")
                pass = rdr("Password")
                If txtusername.text = user And txtpassword.Text = pass Then
                    cnt = 0
                    MsgBox("Info : Login Successful", MsgBoxStyle.Information)
                    main.lblCurrentUser.Text = txtusername.text
                    main.WindowState = FormWindowState.Maximized
                    main.Show()
                    Me.Hide()
                    'formlodin_hide ()
                    clearControls()
                    forgotpassword.Close()
                Else
                    MsgBox("Login Unsuccessful ", MsgBoxStyle.Critical)
                    clearControls()
                End If

            Else
                cnt += 1
                If cnt = 3 Then
                    MsgBox("Error : Sorry this is ypur last attemp !!", MsgBoxStyle.Critical)
                    Application.Exit()
                End If
                MsgBox("ERROR : Please Enter Valid username and Password", MsgBoxStyle.Critical)
                clearControls()
            End If
        End If
        con.Close()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        clearControls()
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        forgotpassword.Show()
        Me.Hide()
    End Sub
End Class