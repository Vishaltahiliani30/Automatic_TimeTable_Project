<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lecture_credits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lecture_credits))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblcreditid = New System.Windows.Forms.Label()
        Me.btnsave = New Bunifu.Framework.UI.BunifuTileButton()
        Me.lblshowid = New System.Windows.Forms.Label()
        Me.lblcoursename = New System.Windows.Forms.Label()
        Me.lblbranchname = New System.Windows.Forms.Label()
        Me.lblsemestername = New System.Windows.Forms.Label()
        Me.lblsubjectname = New System.Windows.Forms.Label()
        Me.lblcredit = New System.Windows.Forms.Label()
        Me.lblshow1 = New System.Windows.Forms.Label()
        Me.lblshow2 = New System.Windows.Forms.Label()
        Me.btnadd = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btndelete = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnupdate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnview = New Bunifu.Framework.UI.BunifuTileButton()
        Me.cmbcoursename = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbbranchname = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbsemestername = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbsubname = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txtget1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtget2 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.DataGridView2 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Brnach_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Course_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Branch_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcreditid
        '
        Me.lblcreditid.AutoSize = True
        Me.lblcreditid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcreditid.ForeColor = System.Drawing.Color.White
        Me.lblcreditid.Location = New System.Drawing.Point(14, 16)
        Me.lblcreditid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcreditid.Name = "lblcreditid"
        Me.lblcreditid.Size = New System.Drawing.Size(98, 20)
        Me.lblcreditid.TabIndex = 35
        Me.lblcreditid.Text = "Credit I'd :-"
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
        Me.btnsave.Location = New System.Drawing.Point(471, 121)
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
        Me.lblshowid.Location = New System.Drawing.Point(261, 16)
        Me.lblshowid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblshowid.Name = "lblshowid"
        Me.lblshowid.Size = New System.Drawing.Size(15, 20)
        Me.lblshowid.TabIndex = 37
        Me.lblshowid.Text = "-"
        '
        'lblcoursename
        '
        Me.lblcoursename.AutoSize = True
        Me.lblcoursename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoursename.ForeColor = System.Drawing.Color.White
        Me.lblcoursename.Location = New System.Drawing.Point(14, 72)
        Me.lblcoursename.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcoursename.Name = "lblcoursename"
        Me.lblcoursename.Size = New System.Drawing.Size(133, 20)
        Me.lblcoursename.TabIndex = 38
        Me.lblcoursename.Text = "Course Name :-"
        '
        'lblbranchname
        '
        Me.lblbranchname.AutoSize = True
        Me.lblbranchname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbranchname.ForeColor = System.Drawing.Color.White
        Me.lblbranchname.Location = New System.Drawing.Point(14, 132)
        Me.lblbranchname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblbranchname.Name = "lblbranchname"
        Me.lblbranchname.Size = New System.Drawing.Size(133, 20)
        Me.lblbranchname.TabIndex = 43
        Me.lblbranchname.Text = "Branch Name :-"
        '
        'lblsemestername
        '
        Me.lblsemestername.AutoSize = True
        Me.lblsemestername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsemestername.ForeColor = System.Drawing.Color.White
        Me.lblsemestername.Location = New System.Drawing.Point(14, 179)
        Me.lblsemestername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsemestername.Name = "lblsemestername"
        Me.lblsemestername.Size = New System.Drawing.Size(153, 20)
        Me.lblsemestername.TabIndex = 44
        Me.lblsemestername.Text = "Semester Name :-"
        '
        'lblsubjectname
        '
        Me.lblsubjectname.AutoSize = True
        Me.lblsubjectname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubjectname.ForeColor = System.Drawing.Color.White
        Me.lblsubjectname.Location = New System.Drawing.Point(490, 27)
        Me.lblsubjectname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsubjectname.Name = "lblsubjectname"
        Me.lblsubjectname.Size = New System.Drawing.Size(137, 20)
        Me.lblsubjectname.TabIndex = 50
        Me.lblsubjectname.Text = "Subject Name :-"
        '
        'lblcredit
        '
        Me.lblcredit.AutoSize = True
        Me.lblcredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcredit.ForeColor = System.Drawing.Color.White
        Me.lblcredit.Location = New System.Drawing.Point(490, 92)
        Me.lblcredit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcredit.Name = "lblcredit"
        Me.lblcredit.Size = New System.Drawing.Size(82, 20)
        Me.lblcredit.TabIndex = 51
        Me.lblcredit.Text = "Credits :-"
        '
        'lblshow1
        '
        Me.lblshow1.AutoSize = True
        Me.lblshow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshow1.ForeColor = System.Drawing.Color.White
        Me.lblshow1.Location = New System.Drawing.Point(878, 91)
        Me.lblshow1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblshow1.Name = "lblshow1"
        Me.lblshow1.Size = New System.Drawing.Size(15, 20)
        Me.lblshow1.TabIndex = 54
        Me.lblshow1.Text = "-"
        '
        'lblshow2
        '
        Me.lblshow2.AutoSize = True
        Me.lblshow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshow2.ForeColor = System.Drawing.Color.White
        Me.lblshow2.Location = New System.Drawing.Point(878, 148)
        Me.lblshow2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblshow2.Name = "lblshow2"
        Me.lblshow2.Size = New System.Drawing.Size(15, 20)
        Me.lblshow2.TabIndex = 55
        Me.lblshow2.Text = "-"
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
        Me.btnadd.Location = New System.Drawing.Point(87, 624)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(165, 110)
        Me.btnadd.TabIndex = 56
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
        Me.btndelete.Location = New System.Drawing.Point(311, 624)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(165, 110)
        Me.btndelete.TabIndex = 57
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
        Me.btnupdate.Location = New System.Drawing.Point(537, 624)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(165, 110)
        Me.btnupdate.TabIndex = 58
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
        Me.btnview.Location = New System.Drawing.Point(761, 624)
        Me.btnview.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(165, 110)
        Me.btnview.TabIndex = 59
        '
        'cmbcoursename
        '
        Me.cmbcoursename.BackColor = System.Drawing.Color.Transparent
        Me.cmbcoursename.BorderRadius = 3
        Me.cmbcoursename.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcoursename.ForeColor = System.Drawing.Color.Black
        Me.cmbcoursename.Items = New String(-1) {}
        Me.cmbcoursename.Location = New System.Drawing.Point(192, 61)
        Me.cmbcoursename.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbcoursename.Name = "cmbcoursename"
        Me.cmbcoursename.NomalColor = System.Drawing.Color.White
        Me.cmbcoursename.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbcoursename.selectedIndex = -1
        Me.cmbcoursename.Size = New System.Drawing.Size(206, 31)
        Me.cmbcoursename.TabIndex = 101
        '
        'cmbbranchname
        '
        Me.cmbbranchname.BackColor = System.Drawing.Color.Transparent
        Me.cmbbranchname.BorderRadius = 3
        Me.cmbbranchname.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbranchname.ForeColor = System.Drawing.Color.Black
        Me.cmbbranchname.Items = New String(-1) {}
        Me.cmbbranchname.Location = New System.Drawing.Point(192, 121)
        Me.cmbbranchname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbbranchname.Name = "cmbbranchname"
        Me.cmbbranchname.NomalColor = System.Drawing.Color.White
        Me.cmbbranchname.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbbranchname.selectedIndex = -1
        Me.cmbbranchname.Size = New System.Drawing.Size(206, 31)
        Me.cmbbranchname.TabIndex = 102
        '
        'cmbsemestername
        '
        Me.cmbsemestername.BackColor = System.Drawing.Color.Transparent
        Me.cmbsemestername.BorderRadius = 3
        Me.cmbsemestername.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsemestername.ForeColor = System.Drawing.Color.Black
        Me.cmbsemestername.Items = New String(-1) {}
        Me.cmbsemestername.Location = New System.Drawing.Point(192, 168)
        Me.cmbsemestername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbsemestername.Name = "cmbsemestername"
        Me.cmbsemestername.NomalColor = System.Drawing.Color.White
        Me.cmbsemestername.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbsemestername.selectedIndex = -1
        Me.cmbsemestername.Size = New System.Drawing.Size(206, 31)
        Me.cmbsemestername.TabIndex = 103
        '
        'cmbsubname
        '
        Me.cmbsubname.BackColor = System.Drawing.Color.Transparent
        Me.cmbsubname.BorderRadius = 3
        Me.cmbsubname.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsubname.ForeColor = System.Drawing.Color.Black
        Me.cmbsubname.Items = New String(-1) {}
        Me.cmbsubname.Location = New System.Drawing.Point(667, 16)
        Me.cmbsubname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbsubname.Name = "cmbsubname"
        Me.cmbsubname.NomalColor = System.Drawing.Color.White
        Me.cmbsubname.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbsubname.selectedIndex = -1
        Me.cmbsubname.Size = New System.Drawing.Size(206, 31)
        Me.cmbsubname.TabIndex = 104
        '
        'txtget1
        '
        Me.txtget1.BorderColor = System.Drawing.Color.Black
        Me.txtget1.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtget1.Location = New System.Drawing.Point(667, 91)
        Me.txtget1.MaxLength = 10
        Me.txtget1.Name = "txtget1"
        Me.txtget1.Size = New System.Drawing.Size(206, 25)
        Me.txtget1.TabIndex = 105
        '
        'txtget2
        '
        Me.txtget2.BorderColor = System.Drawing.Color.Black
        Me.txtget2.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtget2.Location = New System.Drawing.Point(667, 143)
        Me.txtget2.MaxLength = 10
        Me.txtget2.Name = "txtget2"
        Me.txtget2.Size = New System.Drawing.Size(206, 25)
        Me.txtget2.TabIndex = 106
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.ColumnHeadersHeight = 35
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Brnach_Id, Me.Course_Id, Me.Branch_Name, Me.credits})
        Me.DataGridView2.DoubleBuffered = True
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView2.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.DataGridView2.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView2.Location = New System.Drawing.Point(242, 249)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.RowHeadersWidth = 4
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView2.Size = New System.Drawing.Size(592, 368)
        Me.DataGridView2.TabIndex = 107
        '
        'Brnach_Id
        '
        Me.Brnach_Id.HeaderText = "Credit Id"
        Me.Brnach_Id.Name = "Brnach_Id"
        Me.Brnach_Id.ReadOnly = True
        Me.Brnach_Id.Width = 150
        '
        'Course_Id
        '
        Me.Course_Id.HeaderText = "Subject Id"
        Me.Course_Id.Name = "Course_Id"
        Me.Course_Id.ReadOnly = True
        Me.Course_Id.Width = 150
        '
        'Branch_Name
        '
        Me.Branch_Name.HeaderText = "Subject Type"
        Me.Branch_Name.Name = "Branch_Name"
        Me.Branch_Name.ReadOnly = True
        Me.Branch_Name.Width = 180
        '
        'credits
        '
        Me.credits.HeaderText = "Credits"
        Me.credits.Name = "credits"
        Me.credits.ReadOnly = True
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(192, 216)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(681, 24)
        Me.BunifuSeparator1.TabIndex = 108
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(170, 229)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(44, 392)
        Me.BunifuSeparator2.TabIndex = 109
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = True
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(850, 229)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(44, 392)
        Me.BunifuSeparator3.TabIndex = 110
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = True
        '
        'lecture_credits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.txtget2)
        Me.Controls.Add(Me.txtget1)
        Me.Controls.Add(Me.cmbsubname)
        Me.Controls.Add(Me.cmbsemestername)
        Me.Controls.Add(Me.cmbbranchname)
        Me.Controls.Add(Me.cmbcoursename)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.lblshow2)
        Me.Controls.Add(Me.lblshow1)
        Me.Controls.Add(Me.lblcredit)
        Me.Controls.Add(Me.lblsubjectname)
        Me.Controls.Add(Me.lblsemestername)
        Me.Controls.Add(Me.lblbranchname)
        Me.Controls.Add(Me.lblcoursename)
        Me.Controls.Add(Me.lblshowid)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.lblcreditid)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "lecture_credits"
        Me.Size = New System.Drawing.Size(1066, 792)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcreditid As System.Windows.Forms.Label
    Friend WithEvents btnsave As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents lblshowid As System.Windows.Forms.Label
    Friend WithEvents lblcoursename As System.Windows.Forms.Label
    Friend WithEvents lblbranchname As System.Windows.Forms.Label
    Friend WithEvents lblsemestername As System.Windows.Forms.Label
    Friend WithEvents lblsubjectname As System.Windows.Forms.Label
    Friend WithEvents lblcredit As System.Windows.Forms.Label
    Friend WithEvents lblshow1 As System.Windows.Forms.Label
    Friend WithEvents lblshow2 As System.Windows.Forms.Label
    Friend WithEvents btnadd As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btndelete As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnupdate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnview As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents cmbcoursename As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbbranchname As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbsemestername As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbsubname As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents txtget1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtget2 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents DataGridView2 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Brnach_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Course_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Branch_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents credits As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator

End Class
