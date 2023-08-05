<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subject))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblsubid = New System.Windows.Forms.Label()
        Me.lblshowid = New System.Windows.Forms.Label()
        Me.btnsave = New Bunifu.Framework.UI.BunifuTileButton()
        Me.lblcoursename = New System.Windows.Forms.Label()
        Me.lblbranchname = New System.Windows.Forms.Label()
        Me.lblsemestername = New System.Windows.Forms.Label()
        Me.lblsubname = New System.Windows.Forms.Label()
        Me.lblnewsubname = New System.Windows.Forms.Label()
        Me.chbtheory = New System.Windows.Forms.CheckBox()
        Me.chbpractical = New System.Windows.Forms.CheckBox()
        Me.btnadd = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btndelete = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnupdate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnview = New Bunifu.Framework.UI.BunifuTileButton()
        Me.cmbsubname = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbsemester = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbbranchname = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbcoursename = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txtsubname = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtnewsubname = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.DataGridView1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Brnach_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Course_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Branch_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblsubid
        '
        Me.lblsubid.AutoSize = True
        Me.lblsubid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubid.ForeColor = System.Drawing.Color.White
        Me.lblsubid.Location = New System.Drawing.Point(21, 43)
        Me.lblsubid.Name = "lblsubid"
        Me.lblsubid.Size = New System.Drawing.Size(135, 25)
        Me.lblsubid.TabIndex = 29
        Me.lblsubid.Text = "Subject I'd :-"
        '
        'lblshowid
        '
        Me.lblshowid.AutoSize = True
        Me.lblshowid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshowid.ForeColor = System.Drawing.Color.White
        Me.lblshowid.Location = New System.Drawing.Point(368, 43)
        Me.lblshowid.Name = "lblshowid"
        Me.lblshowid.Size = New System.Drawing.Size(20, 25)
        Me.lblshowid.TabIndex = 34
        Me.lblshowid.Text = "-"
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
        Me.btnsave.Location = New System.Drawing.Point(208, 505)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(115, 106)
        Me.btnsave.TabIndex = 35
        '
        'lblcoursename
        '
        Me.lblcoursename.AutoSize = True
        Me.lblcoursename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoursename.ForeColor = System.Drawing.Color.White
        Me.lblcoursename.Location = New System.Drawing.Point(21, 107)
        Me.lblcoursename.Name = "lblcoursename"
        Me.lblcoursename.Size = New System.Drawing.Size(165, 25)
        Me.lblcoursename.TabIndex = 36
        Me.lblcoursename.Text = "Course Name :-"
        '
        'lblbranchname
        '
        Me.lblbranchname.AutoSize = True
        Me.lblbranchname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbranchname.ForeColor = System.Drawing.Color.White
        Me.lblbranchname.Location = New System.Drawing.Point(21, 176)
        Me.lblbranchname.Name = "lblbranchname"
        Me.lblbranchname.Size = New System.Drawing.Size(163, 25)
        Me.lblbranchname.TabIndex = 37
        Me.lblbranchname.Text = "Branch Name :-"
        '
        'lblsemestername
        '
        Me.lblsemestername.AutoSize = True
        Me.lblsemestername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsemestername.ForeColor = System.Drawing.Color.White
        Me.lblsemestername.Location = New System.Drawing.Point(21, 251)
        Me.lblsemestername.Name = "lblsemestername"
        Me.lblsemestername.Size = New System.Drawing.Size(187, 25)
        Me.lblsemestername.TabIndex = 38
        Me.lblsemestername.Text = "Semester Name :-"
        '
        'lblsubname
        '
        Me.lblsubname.AutoSize = True
        Me.lblsubname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubname.ForeColor = System.Drawing.Color.White
        Me.lblsubname.Location = New System.Drawing.Point(21, 322)
        Me.lblsubname.Name = "lblsubname"
        Me.lblsubname.Size = New System.Drawing.Size(168, 25)
        Me.lblsubname.TabIndex = 39
        Me.lblsubname.Text = "Subject Name :-"
        '
        'lblnewsubname
        '
        Me.lblnewsubname.AutoSize = True
        Me.lblnewsubname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewsubname.ForeColor = System.Drawing.Color.White
        Me.lblnewsubname.Location = New System.Drawing.Point(21, 395)
        Me.lblnewsubname.Name = "lblnewsubname"
        Me.lblnewsubname.Size = New System.Drawing.Size(216, 25)
        Me.lblnewsubname.TabIndex = 40
        Me.lblnewsubname.Text = "New Subject Name :-"
        '
        'chbtheory
        '
        Me.chbtheory.AutoSize = True
        Me.chbtheory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbtheory.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chbtheory.Location = New System.Drawing.Point(587, 313)
        Me.chbtheory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chbtheory.Name = "chbtheory"
        Me.chbtheory.Size = New System.Drawing.Size(81, 21)
        Me.chbtheory.TabIndex = 48
        Me.chbtheory.Text = "Theory"
        Me.chbtheory.UseVisualStyleBackColor = True
        '
        'chbpractical
        '
        Me.chbpractical.AutoSize = True
        Me.chbpractical.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbpractical.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chbpractical.Location = New System.Drawing.Point(587, 338)
        Me.chbpractical.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chbpractical.Name = "chbpractical"
        Me.chbpractical.Size = New System.Drawing.Size(93, 21)
        Me.chbpractical.TabIndex = 49
        Me.chbpractical.Text = "Practical"
        Me.chbpractical.UseVisualStyleBackColor = True
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
        Me.btnadd.Location = New System.Drawing.Point(251, 730)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(220, 135)
        Me.btnadd.TabIndex = 57
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
        Me.btndelete.Location = New System.Drawing.Point(549, 730)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(220, 135)
        Me.btndelete.TabIndex = 58
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
        Me.btnupdate.Location = New System.Drawing.Point(851, 730)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(220, 135)
        Me.btnupdate.TabIndex = 59
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
        Me.btnview.Location = New System.Drawing.Point(1149, 730)
        Me.btnview.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(220, 135)
        Me.btnview.TabIndex = 60
        '
        'cmbsubname
        '
        Me.cmbsubname.BackColor = System.Drawing.Color.Transparent
        Me.cmbsubname.BorderRadius = 3
        Me.cmbsubname.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsubname.ForeColor = System.Drawing.Color.Black
        Me.cmbsubname.Items = New String(-1) {}
        Me.cmbsubname.Location = New System.Drawing.Point(303, 313)
        Me.cmbsubname.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbsubname.Name = "cmbsubname"
        Me.cmbsubname.NomalColor = System.Drawing.Color.White
        Me.cmbsubname.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbsubname.selectedIndex = -1
        Me.cmbsubname.Size = New System.Drawing.Size(276, 38)
        Me.cmbsubname.TabIndex = 68
        '
        'cmbsemester
        '
        Me.cmbsemester.BackColor = System.Drawing.Color.Transparent
        Me.cmbsemester.BorderRadius = 3
        Me.cmbsemester.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsemester.ForeColor = System.Drawing.Color.Black
        Me.cmbsemester.Items = New String(-1) {}
        Me.cmbsemester.Location = New System.Drawing.Point(304, 238)
        Me.cmbsemester.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbsemester.Name = "cmbsemester"
        Me.cmbsemester.NomalColor = System.Drawing.Color.White
        Me.cmbsemester.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbsemester.selectedIndex = -1
        Me.cmbsemester.Size = New System.Drawing.Size(275, 38)
        Me.cmbsemester.TabIndex = 69
        '
        'cmbbranchname
        '
        Me.cmbbranchname.BackColor = System.Drawing.Color.Transparent
        Me.cmbbranchname.BorderRadius = 3
        Me.cmbbranchname.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbranchname.ForeColor = System.Drawing.Color.Black
        Me.cmbbranchname.Items = New String(-1) {}
        Me.cmbbranchname.Location = New System.Drawing.Point(304, 162)
        Me.cmbbranchname.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbbranchname.Name = "cmbbranchname"
        Me.cmbbranchname.NomalColor = System.Drawing.Color.White
        Me.cmbbranchname.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbbranchname.selectedIndex = -1
        Me.cmbbranchname.Size = New System.Drawing.Size(275, 38)
        Me.cmbbranchname.TabIndex = 70
        '
        'cmbcoursename
        '
        Me.cmbcoursename.BackColor = System.Drawing.Color.Transparent
        Me.cmbcoursename.BorderRadius = 3
        Me.cmbcoursename.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcoursename.ForeColor = System.Drawing.Color.Black
        Me.cmbcoursename.Items = New String(-1) {}
        Me.cmbcoursename.Location = New System.Drawing.Point(304, 94)
        Me.cmbcoursename.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbcoursename.Name = "cmbcoursename"
        Me.cmbcoursename.NomalColor = System.Drawing.Color.White
        Me.cmbcoursename.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbcoursename.selectedIndex = -1
        Me.cmbcoursename.Size = New System.Drawing.Size(275, 38)
        Me.cmbcoursename.TabIndex = 71
        '
        'txtsubname
        '
        Me.txtsubname.BorderColor = System.Drawing.Color.Black
        Me.txtsubname.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubname.Location = New System.Drawing.Point(304, 320)
        Me.txtsubname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsubname.Name = "txtsubname"
        Me.txtsubname.Size = New System.Drawing.Size(273, 29)
        Me.txtsubname.TabIndex = 72
        '
        'txtnewsubname
        '
        Me.txtnewsubname.BorderColor = System.Drawing.Color.Black
        Me.txtnewsubname.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewsubname.Location = New System.Drawing.Point(304, 389)
        Me.txtnewsubname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnewsubname.Name = "txtnewsubname"
        Me.txtnewsubname.Size = New System.Drawing.Size(273, 29)
        Me.txtnewsubname.TabIndex = 73
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Brnach_Id, Me.Course_Id, Me.Branch_Name})
        Me.DataGridView1.DoubleBuffered = True
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.DataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(821, 69)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 4
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(585, 514)
        Me.DataGridView1.TabIndex = 75
        '
        'Brnach_Id
        '
        Me.Brnach_Id.HeaderText = "Subject Id"
        Me.Brnach_Id.Name = "Brnach_Id"
        Me.Brnach_Id.ReadOnly = True
        Me.Brnach_Id.Width = 150
        '
        'Course_Id
        '
        Me.Course_Id.HeaderText = "Semester Id"
        Me.Course_Id.Name = "Course_Id"
        Me.Course_Id.ReadOnly = True
        Me.Course_Id.Width = 150
        '
        'Branch_Name
        '
        Me.Branch_Name.HeaderText = "Subject Name"
        Me.Branch_Name.Name = "Branch_Name"
        Me.Branch_Name.ReadOnly = True
        Me.Branch_Name.Width = 180
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(723, 69)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(47, 514)
        Me.BunifuSeparator1.TabIndex = 76
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'subject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtnewsubname)
        Me.Controls.Add(Me.cmbcoursename)
        Me.Controls.Add(Me.cmbbranchname)
        Me.Controls.Add(Me.cmbsemester)
        Me.Controls.Add(Me.cmbsubname)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.chbpractical)
        Me.Controls.Add(Me.chbtheory)
        Me.Controls.Add(Me.lblnewsubname)
        Me.Controls.Add(Me.lblsubname)
        Me.Controls.Add(Me.lblsemestername)
        Me.Controls.Add(Me.lblbranchname)
        Me.Controls.Add(Me.lblcoursename)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.lblshowid)
        Me.Controls.Add(Me.lblsubid)
        Me.Controls.Add(Me.txtsubname)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "subject"
        Me.Size = New System.Drawing.Size(1440, 1022)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblsubid As System.Windows.Forms.Label
    Friend WithEvents lblshowid As System.Windows.Forms.Label
    Friend WithEvents btnsave As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents lblcoursename As System.Windows.Forms.Label
    Friend WithEvents lblbranchname As System.Windows.Forms.Label
    Friend WithEvents lblsemestername As System.Windows.Forms.Label
    Friend WithEvents lblsubname As System.Windows.Forms.Label
    Friend WithEvents lblnewsubname As System.Windows.Forms.Label
    Friend WithEvents chbtheory As System.Windows.Forms.CheckBox
    Friend WithEvents chbpractical As System.Windows.Forms.CheckBox
    Friend WithEvents btnadd As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btndelete As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnupdate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnview As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents cmbsubname As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbsemester As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbbranchname As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbcoursename As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents txtsubname As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtnewsubname As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents DataGridView1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Brnach_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Course_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Branch_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator

End Class
