<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Assign_subject
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Assign_subject))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnsave = New Bunifu.Framework.UI.BunifuTileButton()
        Me.lblshowid = New System.Windows.Forms.Label()
        Me.lblassignid = New System.Windows.Forms.Label()
        Me.lblcoursename = New System.Windows.Forms.Label()
        Me.lblbranchname = New System.Windows.Forms.Label()
        Me.lblsemestername = New System.Windows.Forms.Label()
        Me.lblsubjectname = New System.Windows.Forms.Label()
        Me.lblselectprofessor = New System.Windows.Forms.Label()
        Me.btnadd = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btndelete = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnupdate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnview = New Bunifu.Framework.UI.BunifuTileButton()
        Me.chbtheory = New System.Windows.Forms.CheckBox()
        Me.chbpractical = New System.Windows.Forms.CheckBox()
        Me.lblcredit = New System.Windows.Forms.Label()
        Me.lblshow1 = New System.Windows.Forms.Label()
        Me.lblshow2 = New System.Windows.Forms.Label()
        Me.lbltheory = New System.Windows.Forms.Label()
        Me.lblpractical = New System.Windows.Forms.Label()
        Me.showcredits1 = New System.Windows.Forms.Label()
        Me.showcredits2 = New System.Windows.Forms.Label()
        Me.showprofessor = New System.Windows.Forms.Label()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.cmbcoursename = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbbranchname = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbsemestername = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbsubjectname = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbselectprofessor = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txtget1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtget2 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Transparent
        Me.btnsave.color = System.Drawing.Color.Transparent
        Me.btnsave.colorActive = System.Drawing.Color.Transparent
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImagePosition = 13
        Me.btnsave.ImageZoom = 50
        Me.btnsave.LabelPosition = 25
        Me.btnsave.LabelText = ""
        Me.btnsave.Location = New System.Drawing.Point(159, 509)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(86, 86)
        Me.btnsave.TabIndex = 36
        '
        'lblshowid
        '
        Me.lblshowid.AutoSize = True
        Me.lblshowid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshowid.ForeColor = System.Drawing.Color.White
        Me.lblshowid.Location = New System.Drawing.Point(281, 25)
        Me.lblshowid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblshowid.Name = "lblshowid"
        Me.lblshowid.Size = New System.Drawing.Size(15, 20)
        Me.lblshowid.TabIndex = 37
        Me.lblshowid.Text = "-"
        '
        'lblassignid
        '
        Me.lblassignid.AutoSize = True
        Me.lblassignid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblassignid.ForeColor = System.Drawing.Color.White
        Me.lblassignid.Location = New System.Drawing.Point(14, 25)
        Me.lblassignid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblassignid.Name = "lblassignid"
        Me.lblassignid.Size = New System.Drawing.Size(100, 20)
        Me.lblassignid.TabIndex = 38
        Me.lblassignid.Text = "Assign Id :-"
        '
        'lblcoursename
        '
        Me.lblcoursename.AutoSize = True
        Me.lblcoursename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoursename.ForeColor = System.Drawing.Color.White
        Me.lblcoursename.Location = New System.Drawing.Point(14, 80)
        Me.lblcoursename.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcoursename.Name = "lblcoursename"
        Me.lblcoursename.Size = New System.Drawing.Size(138, 20)
        Me.lblcoursename.TabIndex = 39
        Me.lblcoursename.Text = "Course Name :- "
        '
        'lblbranchname
        '
        Me.lblbranchname.AutoSize = True
        Me.lblbranchname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbranchname.ForeColor = System.Drawing.Color.White
        Me.lblbranchname.Location = New System.Drawing.Point(14, 139)
        Me.lblbranchname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblbranchname.Name = "lblbranchname"
        Me.lblbranchname.Size = New System.Drawing.Size(133, 20)
        Me.lblbranchname.TabIndex = 40
        Me.lblbranchname.Text = "Branch Name :-"
        '
        'lblsemestername
        '
        Me.lblsemestername.AutoSize = True
        Me.lblsemestername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsemestername.ForeColor = System.Drawing.Color.White
        Me.lblsemestername.Location = New System.Drawing.Point(14, 208)
        Me.lblsemestername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsemestername.Name = "lblsemestername"
        Me.lblsemestername.Size = New System.Drawing.Size(153, 20)
        Me.lblsemestername.TabIndex = 41
        Me.lblsemestername.Text = "Semester Name :-"
        '
        'lblsubjectname
        '
        Me.lblsubjectname.AutoSize = True
        Me.lblsubjectname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubjectname.ForeColor = System.Drawing.Color.White
        Me.lblsubjectname.Location = New System.Drawing.Point(10, 272)
        Me.lblsubjectname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsubjectname.Name = "lblsubjectname"
        Me.lblsubjectname.Size = New System.Drawing.Size(137, 20)
        Me.lblsubjectname.TabIndex = 42
        Me.lblsubjectname.Text = "Subject Name :-"
        '
        'lblselectprofessor
        '
        Me.lblselectprofessor.AutoSize = True
        Me.lblselectprofessor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblselectprofessor.ForeColor = System.Drawing.Color.White
        Me.lblselectprofessor.Location = New System.Drawing.Point(10, 326)
        Me.lblselectprofessor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblselectprofessor.Name = "lblselectprofessor"
        Me.lblselectprofessor.Size = New System.Drawing.Size(158, 20)
        Me.lblselectprofessor.TabIndex = 43
        Me.lblselectprofessor.Text = "Select Professor :-"
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Transparent
        Me.btnadd.color = System.Drawing.Color.Transparent
        Me.btnadd.colorActive = System.Drawing.Color.Transparent
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.ImagePosition = 16
        Me.btnadd.ImageZoom = 40
        Me.btnadd.LabelPosition = 23
        Me.btnadd.LabelText = ""
        Me.btnadd.Location = New System.Drawing.Point(188, 650)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(165, 110)
        Me.btnadd.TabIndex = 58
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Transparent
        Me.btndelete.color = System.Drawing.Color.Transparent
        Me.btndelete.colorActive = System.Drawing.Color.Transparent
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImagePosition = 16
        Me.btndelete.ImageZoom = 40
        Me.btndelete.LabelPosition = 23
        Me.btndelete.LabelText = ""
        Me.btndelete.Location = New System.Drawing.Point(412, 650)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(165, 110)
        Me.btndelete.TabIndex = 59
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnupdate.color = System.Drawing.Color.Transparent
        Me.btnupdate.colorActive = System.Drawing.Color.Transparent
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Image = CType(resources.GetObject("btnupdate.Image"), System.Drawing.Image)
        Me.btnupdate.ImagePosition = 16
        Me.btnupdate.ImageZoom = 40
        Me.btnupdate.LabelPosition = 23
        Me.btnupdate.LabelText = ""
        Me.btnupdate.Location = New System.Drawing.Point(638, 650)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(165, 110)
        Me.btnupdate.TabIndex = 60
        '
        'btnview
        '
        Me.btnview.BackColor = System.Drawing.Color.Transparent
        Me.btnview.color = System.Drawing.Color.Transparent
        Me.btnview.colorActive = System.Drawing.Color.Transparent
        Me.btnview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnview.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.ForeColor = System.Drawing.Color.White
        Me.btnview.Image = CType(resources.GetObject("btnview.Image"), System.Drawing.Image)
        Me.btnview.ImagePosition = 16
        Me.btnview.ImageZoom = 40
        Me.btnview.LabelPosition = 23
        Me.btnview.LabelText = ""
        Me.btnview.Location = New System.Drawing.Point(859, 650)
        Me.btnview.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(165, 110)
        Me.btnview.TabIndex = 61
        '
        'chbtheory
        '
        Me.chbtheory.AutoSize = True
        Me.chbtheory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbtheory.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chbtheory.Location = New System.Drawing.Point(402, 332)
        Me.chbtheory.Margin = New System.Windows.Forms.Padding(2)
        Me.chbtheory.Name = "chbtheory"
        Me.chbtheory.Size = New System.Drawing.Size(65, 17)
        Me.chbtheory.TabIndex = 62
        Me.chbtheory.Text = "Theory"
        Me.chbtheory.UseVisualStyleBackColor = True
        '
        'chbpractical
        '
        Me.chbpractical.AutoSize = True
        Me.chbpractical.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbpractical.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chbpractical.Location = New System.Drawing.Point(467, 331)
        Me.chbpractical.Margin = New System.Windows.Forms.Padding(2)
        Me.chbpractical.Name = "chbpractical"
        Me.chbpractical.Size = New System.Drawing.Size(76, 17)
        Me.chbpractical.TabIndex = 63
        Me.chbpractical.Text = "Practical"
        Me.chbpractical.UseVisualStyleBackColor = True
        '
        'lblcredit
        '
        Me.lblcredit.AutoSize = True
        Me.lblcredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcredit.ForeColor = System.Drawing.Color.White
        Me.lblcredit.Location = New System.Drawing.Point(10, 402)
        Me.lblcredit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcredit.Name = "lblcredit"
        Me.lblcredit.Size = New System.Drawing.Size(82, 20)
        Me.lblcredit.TabIndex = 64
        Me.lblcredit.Text = "Credits :-"
        '
        'lblshow1
        '
        Me.lblshow1.AutoSize = True
        Me.lblshow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshow1.ForeColor = System.Drawing.Color.White
        Me.lblshow1.Location = New System.Drawing.Point(398, 402)
        Me.lblshow1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblshow1.Name = "lblshow1"
        Me.lblshow1.Size = New System.Drawing.Size(15, 20)
        Me.lblshow1.TabIndex = 67
        Me.lblshow1.Text = "-"
        '
        'lblshow2
        '
        Me.lblshow2.AutoSize = True
        Me.lblshow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshow2.ForeColor = System.Drawing.Color.White
        Me.lblshow2.Location = New System.Drawing.Point(398, 450)
        Me.lblshow2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblshow2.Name = "lblshow2"
        Me.lblshow2.Size = New System.Drawing.Size(15, 20)
        Me.lblshow2.TabIndex = 68
        Me.lblshow2.Text = "-"
        '
        'lbltheory
        '
        Me.lbltheory.AutoSize = True
        Me.lbltheory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltheory.ForeColor = System.Drawing.Color.White
        Me.lbltheory.Location = New System.Drawing.Point(398, 275)
        Me.lbltheory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltheory.Name = "lbltheory"
        Me.lbltheory.Size = New System.Drawing.Size(15, 20)
        Me.lbltheory.TabIndex = 69
        Me.lbltheory.Text = "-"
        '
        'lblpractical
        '
        Me.lblpractical.AutoSize = True
        Me.lblpractical.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpractical.ForeColor = System.Drawing.Color.White
        Me.lblpractical.Location = New System.Drawing.Point(464, 275)
        Me.lblpractical.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpractical.Name = "lblpractical"
        Me.lblpractical.Size = New System.Drawing.Size(15, 20)
        Me.lblpractical.TabIndex = 70
        Me.lblpractical.Text = "-"
        '
        'showcredits1
        '
        Me.showcredits1.AutoSize = True
        Me.showcredits1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showcredits1.ForeColor = System.Drawing.Color.White
        Me.showcredits1.Location = New System.Drawing.Point(280, 405)
        Me.showcredits1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.showcredits1.Name = "showcredits1"
        Me.showcredits1.Size = New System.Drawing.Size(17, 17)
        Me.showcredits1.TabIndex = 71
        Me.showcredits1.Text = "0"
        '
        'showcredits2
        '
        Me.showcredits2.AutoSize = True
        Me.showcredits2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showcredits2.ForeColor = System.Drawing.Color.White
        Me.showcredits2.Location = New System.Drawing.Point(280, 459)
        Me.showcredits2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.showcredits2.Name = "showcredits2"
        Me.showcredits2.Size = New System.Drawing.Size(17, 17)
        Me.showcredits2.TabIndex = 72
        Me.showcredits2.Text = "0"
        '
        'showprofessor
        '
        Me.showprofessor.AutoSize = True
        Me.showprofessor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showprofessor.ForeColor = System.Drawing.Color.White
        Me.showprofessor.Location = New System.Drawing.Point(205, 331)
        Me.showprofessor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.showprofessor.Name = "showprofessor"
        Me.showprofessor.Size = New System.Drawing.Size(14, 17)
        Me.showprofessor.TabIndex = 73
        Me.showprofessor.Text = "-"
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuSeparator2.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(571, 25)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(40, 540)
        Me.BunifuSeparator2.TabIndex = 76
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = True
        '
        'cmbcoursename
        '
        Me.cmbcoursename.BackColor = System.Drawing.Color.Transparent
        Me.cmbcoursename.BorderRadius = 3
        Me.cmbcoursename.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcoursename.ForeColor = System.Drawing.Color.Black
        Me.cmbcoursename.Items = New String(-1) {}
        Me.cmbcoursename.Location = New System.Drawing.Point(188, 69)
        Me.cmbcoursename.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbcoursename.Name = "cmbcoursename"
        Me.cmbcoursename.NomalColor = System.Drawing.Color.White
        Me.cmbcoursename.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbcoursename.selectedIndex = -1
        Me.cmbcoursename.Size = New System.Drawing.Size(206, 31)
        Me.cmbcoursename.TabIndex = 102
        '
        'cmbbranchname
        '
        Me.cmbbranchname.BackColor = System.Drawing.Color.Transparent
        Me.cmbbranchname.BorderRadius = 3
        Me.cmbbranchname.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbranchname.ForeColor = System.Drawing.Color.Black
        Me.cmbbranchname.Items = New String(-1) {}
        Me.cmbbranchname.Location = New System.Drawing.Point(188, 128)
        Me.cmbbranchname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbbranchname.Name = "cmbbranchname"
        Me.cmbbranchname.NomalColor = System.Drawing.Color.White
        Me.cmbbranchname.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbbranchname.selectedIndex = -1
        Me.cmbbranchname.Size = New System.Drawing.Size(206, 31)
        Me.cmbbranchname.TabIndex = 103
        '
        'cmbsemestername
        '
        Me.cmbsemestername.BackColor = System.Drawing.Color.Transparent
        Me.cmbsemestername.BorderRadius = 3
        Me.cmbsemestername.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsemestername.ForeColor = System.Drawing.Color.Black
        Me.cmbsemestername.Items = New String(-1) {}
        Me.cmbsemestername.Location = New System.Drawing.Point(188, 197)
        Me.cmbsemestername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbsemestername.Name = "cmbsemestername"
        Me.cmbsemestername.NomalColor = System.Drawing.Color.White
        Me.cmbsemestername.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbsemestername.selectedIndex = -1
        Me.cmbsemestername.Size = New System.Drawing.Size(206, 31)
        Me.cmbsemestername.TabIndex = 104
        '
        'cmbsubjectname
        '
        Me.cmbsubjectname.BackColor = System.Drawing.Color.Transparent
        Me.cmbsubjectname.BorderRadius = 3
        Me.cmbsubjectname.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsubjectname.ForeColor = System.Drawing.Color.Black
        Me.cmbsubjectname.Items = New String(-1) {}
        Me.cmbsubjectname.Location = New System.Drawing.Point(188, 261)
        Me.cmbsubjectname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbsubjectname.Name = "cmbsubjectname"
        Me.cmbsubjectname.NomalColor = System.Drawing.Color.White
        Me.cmbsubjectname.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbsubjectname.selectedIndex = -1
        Me.cmbsubjectname.Size = New System.Drawing.Size(206, 31)
        Me.cmbsubjectname.TabIndex = 105
        '
        'cmbselectprofessor
        '
        Me.cmbselectprofessor.BackColor = System.Drawing.Color.Transparent
        Me.cmbselectprofessor.BorderRadius = 3
        Me.cmbselectprofessor.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbselectprofessor.ForeColor = System.Drawing.Color.Black
        Me.cmbselectprofessor.Items = New String(-1) {}
        Me.cmbselectprofessor.Location = New System.Drawing.Point(188, 318)
        Me.cmbselectprofessor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbselectprofessor.Name = "cmbselectprofessor"
        Me.cmbselectprofessor.NomalColor = System.Drawing.Color.White
        Me.cmbselectprofessor.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbselectprofessor.selectedIndex = -1
        Me.cmbselectprofessor.Size = New System.Drawing.Size(206, 31)
        Me.cmbselectprofessor.TabIndex = 106
        '
        'txtget1
        '
        Me.txtget1.BorderColor = System.Drawing.Color.Black
        Me.txtget1.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtget1.Location = New System.Drawing.Point(188, 402)
        Me.txtget1.Name = "txtget1"
        Me.txtget1.Size = New System.Drawing.Size(206, 25)
        Me.txtget1.TabIndex = 107
        '
        'txtget2
        '
        Me.txtget2.BorderColor = System.Drawing.Color.Black
        Me.txtget2.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtget2.Location = New System.Drawing.Point(188, 455)
        Me.txtget2.Name = "txtget2"
        Me.txtget2.Size = New System.Drawing.Size(206, 25)
        Me.txtget2.TabIndex = 108
        '
        'Column4
        '
        Me.Column4.HeaderText = "Professor Name"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 170
        '
        'Column3
        '
        Me.Column3.FillWeight = 70.0!
        Me.Column3.HeaderText = "Credits"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Subject Type"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 130
        '
        'Column1
        '
        Me.Column1.HeaderText = "Subject Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 150
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DimGray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.DoubleBuffered = True
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.DataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(616, 25)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersWidth = 5
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(426, 540)
        Me.DataGridView1.TabIndex = 74
        '
        'Assign_subject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Controls.Add(Me.cmbsubjectname)
        Me.Controls.Add(Me.cmbsemestername)
        Me.Controls.Add(Me.cmbbranchname)
        Me.Controls.Add(Me.cmbcoursename)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.showprofessor)
        Me.Controls.Add(Me.showcredits2)
        Me.Controls.Add(Me.showcredits1)
        Me.Controls.Add(Me.lblpractical)
        Me.Controls.Add(Me.lbltheory)
        Me.Controls.Add(Me.lblshow2)
        Me.Controls.Add(Me.lblshow1)
        Me.Controls.Add(Me.lblcredit)
        Me.Controls.Add(Me.chbpractical)
        Me.Controls.Add(Me.chbtheory)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.lblselectprofessor)
        Me.Controls.Add(Me.lblsubjectname)
        Me.Controls.Add(Me.lblsemestername)
        Me.Controls.Add(Me.lblbranchname)
        Me.Controls.Add(Me.lblcoursename)
        Me.Controls.Add(Me.lblassignid)
        Me.Controls.Add(Me.lblshowid)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cmbselectprofessor)
        Me.Controls.Add(Me.txtget1)
        Me.Controls.Add(Me.txtget2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Assign_subject"
        Me.Size = New System.Drawing.Size(1066, 792)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsave As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents lblshowid As System.Windows.Forms.Label
    Friend WithEvents lblassignid As System.Windows.Forms.Label
    Friend WithEvents lblcoursename As System.Windows.Forms.Label
    Friend WithEvents lblbranchname As System.Windows.Forms.Label
    Friend WithEvents lblsemestername As System.Windows.Forms.Label
    Friend WithEvents lblsubjectname As System.Windows.Forms.Label
    Friend WithEvents lblselectprofessor As System.Windows.Forms.Label
    Friend WithEvents btnadd As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btndelete As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnupdate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnview As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents chbtheory As System.Windows.Forms.CheckBox
    Friend WithEvents chbpractical As System.Windows.Forms.CheckBox
    Friend WithEvents lblcredit As System.Windows.Forms.Label
    Friend WithEvents lblshow1 As System.Windows.Forms.Label
    Friend WithEvents lblshow2 As System.Windows.Forms.Label
    Friend WithEvents lbltheory As System.Windows.Forms.Label
    Friend WithEvents lblpractical As System.Windows.Forms.Label
    Friend WithEvents showcredits1 As System.Windows.Forms.Label
    Friend WithEvents showcredits2 As System.Windows.Forms.Label
    Friend WithEvents showprofessor As System.Windows.Forms.Label
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents cmbcoursename As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbbranchname As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbsemestername As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbsubjectname As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbselectprofessor As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents txtget1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtget2 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As Bunifu.Framework.UI.BunifuCustomDataGrid

End Class
