<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgotpassword
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forgotpassword))
        Me.chkshowpassword = New System.Windows.Forms.CheckBox()
        Me.txtconfirmpassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtnewpassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtans = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtusername = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.cmbsq = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnupdatepassword = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnminimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnclose = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.btnminimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkshowpassword
        '
        Me.chkshowpassword.AutoSize = True
        Me.chkshowpassword.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkshowpassword.Location = New System.Drawing.Point(350, 426)
        Me.chkshowpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.chkshowpassword.Name = "chkshowpassword"
        Me.chkshowpassword.Size = New System.Drawing.Size(111, 18)
        Me.chkshowpassword.TabIndex = 45
        Me.chkshowpassword.Text = "Show Password"
        Me.chkshowpassword.UseVisualStyleBackColor = True
        '
        'txtconfirmpassword
        '
        Me.txtconfirmpassword.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtconfirmpassword.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtconfirmpassword.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtconfirmpassword.BorderThickness = 2
        Me.txtconfirmpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtconfirmpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirmpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtconfirmpassword.isPassword = False
        Me.txtconfirmpassword.Location = New System.Drawing.Point(227, 370)
        Me.txtconfirmpassword.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtconfirmpassword.Name = "txtconfirmpassword"
        Me.txtconfirmpassword.Size = New System.Drawing.Size(216, 39)
        Me.txtconfirmpassword.TabIndex = 43
        Me.txtconfirmpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtnewpassword
        '
        Me.txtnewpassword.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtnewpassword.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtnewpassword.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtnewpassword.BorderThickness = 2
        Me.txtnewpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnewpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtnewpassword.isPassword = False
        Me.txtnewpassword.Location = New System.Drawing.Point(227, 299)
        Me.txtnewpassword.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtnewpassword.Name = "txtnewpassword"
        Me.txtnewpassword.Size = New System.Drawing.Size(216, 39)
        Me.txtnewpassword.TabIndex = 42
        Me.txtnewpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtans
        '
        Me.txtans.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtans.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtans.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtans.BorderThickness = 2
        Me.txtans.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtans.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtans.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtans.isPassword = False
        Me.txtans.Location = New System.Drawing.Point(228, 228)
        Me.txtans.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtans.Name = "txtans"
        Me.txtans.Size = New System.Drawing.Size(215, 39)
        Me.txtans.TabIndex = 41
        Me.txtans.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtusername
        '
        Me.txtusername.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtusername.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtusername.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtusername.BorderThickness = 2
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtusername.isPassword = False
        Me.txtusername.Location = New System.Drawing.Point(228, 96)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(215, 39)
        Me.txtusername.TabIndex = 40
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cmbsq
        '
        Me.cmbsq.BackColor = System.Drawing.Color.Transparent
        Me.cmbsq.BorderRadius = 3
        Me.cmbsq.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsq.ForeColor = System.Drawing.Color.Black
        Me.cmbsq.Items = New String() {"Do security questions work?", "What is the secret answer?", "How do I answer security questions on Gmail?"}
        Me.cmbsq.Location = New System.Drawing.Point(228, 159)
        Me.cmbsq.Name = "cmbsq"
        Me.cmbsq.NomalColor = System.Drawing.Color.DarkGray
        Me.cmbsq.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbsq.selectedIndex = -1
        Me.cmbsq.Size = New System.Drawing.Size(215, 35)
        Me.cmbsq.TabIndex = 39
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(207, 166)
        Me.BunifuCustomLabel12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(16, 24)
        Me.BunifuCustomLabel12.TabIndex = 38
        Me.BunifuCustomLabel12.Text = ":"
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(207, 236)
        Me.BunifuCustomLabel11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(16, 24)
        Me.BunifuCustomLabel11.TabIndex = 37
        Me.BunifuCustomLabel11.Text = ":"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(207, 308)
        Me.BunifuCustomLabel10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(16, 24)
        Me.BunifuCustomLabel10.TabIndex = 36
        Me.BunifuCustomLabel10.Text = ":"
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(207, 378)
        Me.BunifuCustomLabel9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(16, 24)
        Me.BunifuCustomLabel9.TabIndex = 35
        Me.BunifuCustomLabel9.Text = ":"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(207, 106)
        Me.BunifuCustomLabel8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(16, 24)
        Me.BunifuCustomLabel8.TabIndex = 34
        Me.BunifuCustomLabel8.Text = ":"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(9, 378)
        Me.BunifuCustomLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(162, 24)
        Me.BunifuCustomLabel7.TabIndex = 33
        Me.BunifuCustomLabel7.Text = "Confirm Password"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(122, 11)
        Me.BunifuCustomLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(212, 29)
        Me.BunifuCustomLabel1.TabIndex = 25
        Me.BunifuCustomLabel1.Text = "Forgot Password"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(-5, 38)
        Me.BunifuCustomLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(526, 29)
        Me.BunifuCustomLabel2.TabIndex = 28
        Me.BunifuCustomLabel2.Text = "---------------------------------------------------------"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(9, 308)
        Me.BunifuCustomLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(136, 24)
        Me.BunifuCustomLabel6.TabIndex = 32
        Me.BunifuCustomLabel6.Text = "New Password"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(9, 236)
        Me.BunifuCustomLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(119, 24)
        Me.BunifuCustomLabel5.TabIndex = 31
        Me.BunifuCustomLabel5.Text = "Your Answer"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(9, 166)
        Me.BunifuCustomLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(158, 24)
        Me.BunifuCustomLabel4.TabIndex = 30
        Me.BunifuCustomLabel4.Text = "Security Question"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(9, 106)
        Me.BunifuCustomLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(105, 24)
        Me.BunifuCustomLabel3.TabIndex = 29
        Me.BunifuCustomLabel3.Text = "User Name"
        '
        'btnupdatepassword
        '
        Me.btnupdatepassword.Activecolor = System.Drawing.Color.Transparent
        Me.btnupdatepassword.BackColor = System.Drawing.Color.Transparent
        Me.btnupdatepassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnupdatepassword.BorderRadius = 0
        Me.btnupdatepassword.ButtonText = "          Update Password"
        Me.btnupdatepassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdatepassword.DisabledColor = System.Drawing.Color.Gray
        Me.btnupdatepassword.Iconcolor = System.Drawing.Color.Transparent
        Me.btnupdatepassword.Iconimage = CType(resources.GetObject("btnupdatepassword.Iconimage"), System.Drawing.Image)
        Me.btnupdatepassword.Iconimage_right = Nothing
        Me.btnupdatepassword.Iconimage_right_Selected = Nothing
        Me.btnupdatepassword.Iconimage_Selected = Nothing
        Me.btnupdatepassword.IconMarginLeft = 0
        Me.btnupdatepassword.IconMarginRight = 0
        Me.btnupdatepassword.IconRightVisible = True
        Me.btnupdatepassword.IconRightZoom = 0.0R
        Me.btnupdatepassword.IconVisible = True
        Me.btnupdatepassword.IconZoom = 70.0R
        Me.btnupdatepassword.IsTab = False
        Me.btnupdatepassword.Location = New System.Drawing.Point(134, 478)
        Me.btnupdatepassword.Name = "btnupdatepassword"
        Me.btnupdatepassword.Normalcolor = System.Drawing.Color.Transparent
        Me.btnupdatepassword.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnupdatepassword.OnHoverTextColor = System.Drawing.Color.White
        Me.btnupdatepassword.selected = False
        Me.btnupdatepassword.Size = New System.Drawing.Size(246, 43)
        Me.btnupdatepassword.TabIndex = 44
        Me.btnupdatepassword.Text = "          Update Password"
        Me.btnupdatepassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnupdatepassword.Textcolor = System.Drawing.Color.Black
        Me.btnupdatepassword.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnminimize
        '
        Me.btnminimize.BackColor = System.Drawing.Color.Transparent
        Me.btnminimize.Image = CType(resources.GetObject("btnminimize.Image"), System.Drawing.Image)
        Me.btnminimize.ImageActive = Nothing
        Me.btnminimize.Location = New System.Drawing.Point(434, 4)
        Me.btnminimize.Margin = New System.Windows.Forms.Padding(2)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(37, 43)
        Me.btnminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnminimize.TabIndex = 27
        Me.btnminimize.TabStop = False
        Me.btnminimize.Zoom = 10
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageActive = Nothing
        Me.btnclose.Location = New System.Drawing.Point(475, 4)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(37, 43)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnclose.TabIndex = 26
        Me.btnclose.TabStop = False
        Me.btnclose.Zoom = 10
        '
        'forgotpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 547)
        Me.Controls.Add(Me.chkshowpassword)
        Me.Controls.Add(Me.btnupdatepassword)
        Me.Controls.Add(Me.txtconfirmpassword)
        Me.Controls.Add(Me.txtnewpassword)
        Me.Controls.Add(Me.txtans)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.cmbsq)
        Me.Controls.Add(Me.BunifuCustomLabel12)
        Me.Controls.Add(Me.BunifuCustomLabel11)
        Me.Controls.Add(Me.BunifuCustomLabel10)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.btnminimize)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "forgotpassword"
        Me.Text = "forgotpassword"
        CType(Me.btnminimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkshowpassword As System.Windows.Forms.CheckBox
    Friend WithEvents btnupdatepassword As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtconfirmpassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtnewpassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtans As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtusername As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents cmbsq As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnminimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
