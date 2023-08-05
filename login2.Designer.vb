<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login2))
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.lblheading = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtusername = New Bunifu.Framework.UI.BunifuTextbox()
        Me.btncancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnlogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtpassword = New Bunifu.Framework.UI.BunifuTextbox()
        Me.SuspendLayout()
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.BackColor = System.Drawing.Color.Transparent
        Me.lblusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblusername.Location = New System.Drawing.Point(463, 291)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(151, 29)
        Me.lblusername.TabIndex = 1
        Me.lblusername.Text = "User Name:"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.BackColor = System.Drawing.Color.Transparent
        Me.lblpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblpassword.Location = New System.Drawing.Point(463, 363)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(135, 29)
        Me.lblpassword.TabIndex = 2
        Me.lblpassword.Text = "Password:"
        '
        'lblheading
        '
        Me.lblheading.AutoSize = True
        Me.lblheading.BackColor = System.Drawing.Color.Transparent
        Me.lblheading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblheading.Location = New System.Drawing.Point(1233, 239)
        Me.lblheading.Name = "lblheading"
        Me.lblheading.Size = New System.Drawing.Size(15, 20)
        Me.lblheading.TabIndex = 7
        Me.lblheading.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(475, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(457, 108)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "L O G I N"
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.White
        Me.txtusername.BackgroundImage = CType(resources.GetObject("txtusername.BackgroundImage"), System.Drawing.Image)
        Me.txtusername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtusername.ForeColor = System.Drawing.Color.Black
        Me.txtusername.Icon = CType(resources.GetObject("txtusername.Icon"), System.Drawing.Image)
        Me.txtusername.Location = New System.Drawing.Point(669, 276)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(250, 43)
        Me.txtusername.TabIndex = 10
        Me.txtusername.text = ""
        '
        'btncancel
        '
        Me.btncancel.ActiveBorderThickness = 1
        Me.btncancel.ActiveCornerRadius = 20
        Me.btncancel.ActiveFillColor = System.Drawing.Color.Black
        Me.btncancel.ActiveForecolor = System.Drawing.Color.White
        Me.btncancel.ActiveLineColor = System.Drawing.Color.White
        Me.btncancel.BackColor = System.Drawing.SystemColors.Control
        Me.btncancel.BackgroundImage = CType(resources.GetObject("btncancel.BackgroundImage"), System.Drawing.Image)
        Me.btncancel.ButtonText = "Cancel"
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Black
        Me.btncancel.IdleBorderThickness = 1
        Me.btncancel.IdleCornerRadius = 20
        Me.btncancel.IdleFillColor = System.Drawing.Color.White
        Me.btncancel.IdleForecolor = System.Drawing.Color.Black
        Me.btncancel.IdleLineColor = System.Drawing.Color.Black
        Me.btncancel.Location = New System.Drawing.Point(705, 428)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(130, 56)
        Me.btncancel.TabIndex = 24
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnlogin
        '
        Me.btnlogin.ActiveBorderThickness = 1
        Me.btnlogin.ActiveCornerRadius = 20
        Me.btnlogin.ActiveFillColor = System.Drawing.Color.Black
        Me.btnlogin.ActiveForecolor = System.Drawing.Color.White
        Me.btnlogin.ActiveLineColor = System.Drawing.Color.White
        Me.btnlogin.BackColor = System.Drawing.SystemColors.Control
        Me.btnlogin.BackgroundImage = CType(resources.GetObject("btnlogin.BackgroundImage"), System.Drawing.Image)
        Me.btnlogin.ButtonText = "Login"
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.Black
        Me.btnlogin.IdleBorderThickness = 1
        Me.btnlogin.IdleCornerRadius = 20
        Me.btnlogin.IdleFillColor = System.Drawing.Color.White
        Me.btnlogin.IdleForecolor = System.Drawing.Color.Black
        Me.btnlogin.IdleLineColor = System.Drawing.Color.Black
        Me.btnlogin.Location = New System.Drawing.Point(527, 428)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(130, 55)
        Me.btnlogin.TabIndex = 23
        Me.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(614, 519)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(147, 18)
        Me.LinkLabel1.TabIndex = 25
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot Password?"
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.White
        Me.txtpassword.BackgroundImage = CType(resources.GetObject("txtpassword.BackgroundImage"), System.Drawing.Image)
        Me.txtpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtpassword.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.Icon = CType(resources.GetObject("txtpassword.Icon"), System.Drawing.Image)
        Me.txtpassword.Location = New System.Drawing.Point(669, 349)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(250, 43)
        Me.txtpassword.TabIndex = 26
        Me.txtpassword.text = ""
        '
        'login2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1455, 878)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblheading)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblusername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "login2"
        Me.Text = "login2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents lblheading As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtusername As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents btncancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnlogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtpassword As Bunifu.Framework.UI.BunifuTextbox
End Class
