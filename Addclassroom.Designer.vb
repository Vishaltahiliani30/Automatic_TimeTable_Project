<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addclassroom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Addclassroom))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnsave = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnview = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnupdate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btndelete = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnadd = New Bunifu.Framework.UI.BunifuTileButton()
        Me.lblcid = New System.Windows.Forms.Label()
        Me.showsid = New System.Windows.Forms.Label()
        Me.lblcname = New System.Windows.Forms.Label()
        Me.lblbname = New System.Windows.Forms.Label()
        Me.lblsemester = New System.Windows.Forms.Label()
        Me.lblcrname = New System.Windows.Forms.Label()
        Me.txtclassname = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.lblclasstype = New System.Windows.Forms.Label()
        Me.lblnewclassroom = New System.Windows.Forms.Label()
        Me.txtnewclassroom = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.lblcoursename = New System.Windows.Forms.Label()
        Me.lblbranchname = New System.Windows.Forms.Label()
        Me.lblsemestername = New System.Windows.Forms.Label()
        Me.lblctype = New System.Windows.Forms.Label()
        Me.cmbcoursename = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbbranchname = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbsemester = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbclasstype = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbclassroom = New Bunifu.Framework.UI.BunifuDropdown()
        Me.DataGridView1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Brnach_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Course_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Branch_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.btnsave.Location = New System.Drawing.Point(592, 377)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(115, 106)
        Me.btnsave.TabIndex = 75
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
        Me.btnview.Location = New System.Drawing.Point(1142, 820)
        Me.btnview.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(247, 135)
        Me.btnview.TabIndex = 79
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
        Me.btnupdate.Location = New System.Drawing.Point(842, 820)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(247, 135)
        Me.btnupdate.TabIndex = 78
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
        Me.btndelete.Location = New System.Drawing.Point(542, 820)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(247, 135)
        Me.btndelete.TabIndex = 77
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
        Me.btnadd.Location = New System.Drawing.Point(242, 820)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(247, 135)
        Me.btnadd.TabIndex = 76
        '
        'lblcid
        '
        Me.lblcid.AutoSize = True
        Me.lblcid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcid.ForeColor = System.Drawing.Color.White
        Me.lblcid.Location = New System.Drawing.Point(69, 64)
        Me.lblcid.Name = "lblcid"
        Me.lblcid.Size = New System.Drawing.Size(117, 25)
        Me.lblcid.TabIndex = 29
        Me.lblcid.Text = "Class I'd :-"
        '
        'showsid
        '
        Me.showsid.AutoSize = True
        Me.showsid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showsid.ForeColor = System.Drawing.Color.White
        Me.showsid.Location = New System.Drawing.Point(364, 64)
        Me.showsid.Name = "showsid"
        Me.showsid.Size = New System.Drawing.Size(20, 25)
        Me.showsid.TabIndex = 30
        Me.showsid.Text = "-"
        '
        'lblcname
        '
        Me.lblcname.AutoSize = True
        Me.lblcname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcname.ForeColor = System.Drawing.Color.White
        Me.lblcname.Location = New System.Drawing.Point(69, 140)
        Me.lblcname.Name = "lblcname"
        Me.lblcname.Size = New System.Drawing.Size(165, 25)
        Me.lblcname.TabIndex = 69
        Me.lblcname.Text = "Course Name :-"
        '
        'lblbname
        '
        Me.lblbname.AutoSize = True
        Me.lblbname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbname.ForeColor = System.Drawing.Color.White
        Me.lblbname.Location = New System.Drawing.Point(69, 232)
        Me.lblbname.Name = "lblbname"
        Me.lblbname.Size = New System.Drawing.Size(163, 25)
        Me.lblbname.TabIndex = 70
        Me.lblbname.Text = "Branch Name :-"
        '
        'lblsemester
        '
        Me.lblsemester.AutoSize = True
        Me.lblsemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsemester.ForeColor = System.Drawing.Color.White
        Me.lblsemester.Location = New System.Drawing.Point(69, 317)
        Me.lblsemester.Name = "lblsemester"
        Me.lblsemester.Size = New System.Drawing.Size(187, 25)
        Me.lblsemester.TabIndex = 71
        Me.lblsemester.Text = "Semester Name :-"
        '
        'lblcrname
        '
        Me.lblcrname.AutoSize = True
        Me.lblcrname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcrname.ForeColor = System.Drawing.Color.White
        Me.lblcrname.Location = New System.Drawing.Point(658, 232)
        Me.lblcrname.Name = "lblcrname"
        Me.lblcrname.Size = New System.Drawing.Size(198, 25)
        Me.lblcrname.TabIndex = 80
        Me.lblcrname.Text = "Classroom Name :-"
        '
        'txtclassname
        '
        Me.txtclassname.BorderColor = System.Drawing.Color.Black
        Me.txtclassname.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclassname.Location = New System.Drawing.Point(934, 232)
        Me.txtclassname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtclassname.Name = "txtclassname"
        Me.txtclassname.Size = New System.Drawing.Size(226, 29)
        Me.txtclassname.TabIndex = 81
        '
        'lblclasstype
        '
        Me.lblclasstype.AutoSize = True
        Me.lblclasstype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclasstype.ForeColor = System.Drawing.Color.White
        Me.lblclasstype.Location = New System.Drawing.Point(662, 140)
        Me.lblclasstype.Name = "lblclasstype"
        Me.lblclasstype.Size = New System.Drawing.Size(191, 25)
        Me.lblclasstype.TabIndex = 83
        Me.lblclasstype.Text = "Classroom Type :-"
        '
        'lblnewclassroom
        '
        Me.lblnewclassroom.AutoSize = True
        Me.lblnewclassroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewclassroom.ForeColor = System.Drawing.Color.White
        Me.lblnewclassroom.Location = New System.Drawing.Point(658, 317)
        Me.lblnewclassroom.Name = "lblnewclassroom"
        Me.lblnewclassroom.Size = New System.Drawing.Size(246, 25)
        Me.lblnewclassroom.TabIndex = 84
        Me.lblnewclassroom.Text = "New Classroom Name :-"
        '
        'txtnewclassroom
        '
        Me.txtnewclassroom.BorderColor = System.Drawing.Color.Black
        Me.txtnewclassroom.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewclassroom.Location = New System.Drawing.Point(928, 317)
        Me.txtnewclassroom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnewclassroom.Name = "txtnewclassroom"
        Me.txtnewclassroom.Size = New System.Drawing.Size(273, 29)
        Me.txtnewclassroom.TabIndex = 85
        '
        'lblcoursename
        '
        Me.lblcoursename.AutoSize = True
        Me.lblcoursename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoursename.ForeColor = System.Drawing.Color.White
        Me.lblcoursename.Location = New System.Drawing.Point(275, 143)
        Me.lblcoursename.Name = "lblcoursename"
        Me.lblcoursename.Size = New System.Drawing.Size(20, 25)
        Me.lblcoursename.TabIndex = 87
        Me.lblcoursename.Text = "-"
        '
        'lblbranchname
        '
        Me.lblbranchname.AutoSize = True
        Me.lblbranchname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbranchname.ForeColor = System.Drawing.Color.White
        Me.lblbranchname.Location = New System.Drawing.Point(275, 232)
        Me.lblbranchname.Name = "lblbranchname"
        Me.lblbranchname.Size = New System.Drawing.Size(20, 25)
        Me.lblbranchname.TabIndex = 88
        Me.lblbranchname.Text = "-"
        '
        'lblsemestername
        '
        Me.lblsemestername.AutoSize = True
        Me.lblsemestername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsemestername.ForeColor = System.Drawing.Color.White
        Me.lblsemestername.Location = New System.Drawing.Point(279, 325)
        Me.lblsemestername.Name = "lblsemestername"
        Me.lblsemestername.Size = New System.Drawing.Size(20, 25)
        Me.lblsemestername.TabIndex = 89
        Me.lblsemestername.Text = "-"
        '
        'lblctype
        '
        Me.lblctype.AutoSize = True
        Me.lblctype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblctype.ForeColor = System.Drawing.Color.White
        Me.lblctype.Location = New System.Drawing.Point(943, 132)
        Me.lblctype.Name = "lblctype"
        Me.lblctype.Size = New System.Drawing.Size(20, 25)
        Me.lblctype.TabIndex = 90
        Me.lblctype.Text = "-"
        '
        'cmbcoursename
        '
        Me.cmbcoursename.BackColor = System.Drawing.Color.Transparent
        Me.cmbcoursename.BorderRadius = 3
        Me.cmbcoursename.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcoursename.ForeColor = System.Drawing.Color.Black
        Me.cmbcoursename.Items = New String(-1) {}
        Me.cmbcoursename.Location = New System.Drawing.Point(279, 140)
        Me.cmbcoursename.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbcoursename.Name = "cmbcoursename"
        Me.cmbcoursename.NomalColor = System.Drawing.Color.White
        Me.cmbcoursename.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbcoursename.selectedIndex = -1
        Me.cmbcoursename.Size = New System.Drawing.Size(227, 38)
        Me.cmbcoursename.TabIndex = 95
        '
        'cmbbranchname
        '
        Me.cmbbranchname.BackColor = System.Drawing.Color.Transparent
        Me.cmbbranchname.BorderRadius = 3
        Me.cmbbranchname.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbranchname.ForeColor = System.Drawing.Color.Black
        Me.cmbbranchname.Items = New String(-1) {}
        Me.cmbbranchname.Location = New System.Drawing.Point(279, 232)
        Me.cmbbranchname.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbbranchname.Name = "cmbbranchname"
        Me.cmbbranchname.NomalColor = System.Drawing.Color.White
        Me.cmbbranchname.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbbranchname.selectedIndex = -1
        Me.cmbbranchname.Size = New System.Drawing.Size(227, 38)
        Me.cmbbranchname.TabIndex = 96
        '
        'cmbsemester
        '
        Me.cmbsemester.BackColor = System.Drawing.Color.Transparent
        Me.cmbsemester.BorderRadius = 3
        Me.cmbsemester.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsemester.ForeColor = System.Drawing.Color.Black
        Me.cmbsemester.Items = New String(-1) {}
        Me.cmbsemester.Location = New System.Drawing.Point(279, 317)
        Me.cmbsemester.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbsemester.Name = "cmbsemester"
        Me.cmbsemester.NomalColor = System.Drawing.Color.White
        Me.cmbsemester.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbsemester.selectedIndex = -1
        Me.cmbsemester.Size = New System.Drawing.Size(227, 38)
        Me.cmbsemester.TabIndex = 97
        '
        'cmbclasstype
        '
        Me.cmbclasstype.BackColor = System.Drawing.Color.Transparent
        Me.cmbclasstype.BorderRadius = 3
        Me.cmbclasstype.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbclasstype.ForeColor = System.Drawing.Color.Black
        Me.cmbclasstype.Items = New String() {"ClassRoom", "Lab"}
        Me.cmbclasstype.Location = New System.Drawing.Point(934, 119)
        Me.cmbclasstype.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbclasstype.Name = "cmbclasstype"
        Me.cmbclasstype.NomalColor = System.Drawing.Color.White
        Me.cmbclasstype.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbclasstype.selectedIndex = -1
        Me.cmbclasstype.Size = New System.Drawing.Size(227, 38)
        Me.cmbclasstype.TabIndex = 98
        '
        'cmbclassroom
        '
        Me.cmbclassroom.BackColor = System.Drawing.Color.Transparent
        Me.cmbclassroom.BorderRadius = 3
        Me.cmbclassroom.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbclassroom.ForeColor = System.Drawing.Color.Black
        Me.cmbclassroom.Items = New String() {""}
        Me.cmbclassroom.Location = New System.Drawing.Point(934, 232)
        Me.cmbclassroom.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbclassroom.Name = "cmbclassroom"
        Me.cmbclassroom.NomalColor = System.Drawing.Color.White
        Me.cmbclassroom.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbclassroom.selectedIndex = -1
        Me.cmbclassroom.Size = New System.Drawing.Size(227, 38)
        Me.cmbclassroom.TabIndex = 99
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Brnach_Id, Me.Course_Id, Me.Branch_Name, Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.DoubleBuffered = True
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.DataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(36, 64)
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
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.Size = New System.Drawing.Size(1195, 450)
        Me.DataGridView1.TabIndex = 100
        '
        'Brnach_Id
        '
        Me.Brnach_Id.HeaderText = "Class Id"
        Me.Brnach_Id.Name = "Brnach_Id"
        Me.Brnach_Id.ReadOnly = True
        Me.Brnach_Id.Width = 150
        '
        'Course_Id
        '
        Me.Course_Id.HeaderText = "Course Name"
        Me.Course_Id.Name = "Course_Id"
        Me.Course_Id.ReadOnly = True
        Me.Course_Id.Width = 150
        '
        'Branch_Name
        '
        Me.Branch_Name.HeaderText = "Branch Name"
        Me.Branch_Name.Name = "Branch_Name"
        Me.Branch_Name.ReadOnly = True
        Me.Branch_Name.Width = 180
        '
        'Column1
        '
        Me.Column1.HeaderText = "Semester Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 170
        '
        'Column2
        '
        Me.Column2.HeaderText = "Class Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 130
        '
        'Column3
        '
        Me.Column3.HeaderText = "Class Type"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 130
        '
        'Addclassroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Controls.Add(Me.cmbclassroom)
        Me.Controls.Add(Me.lblctype)
        Me.Controls.Add(Me.lblsemestername)
        Me.Controls.Add(Me.lblbranchname)
        Me.Controls.Add(Me.lblcoursename)
        Me.Controls.Add(Me.txtnewclassroom)
        Me.Controls.Add(Me.lblnewclassroom)
        Me.Controls.Add(Me.lblclasstype)
        Me.Controls.Add(Me.txtclassname)
        Me.Controls.Add(Me.lblcrname)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.lblsemester)
        Me.Controls.Add(Me.lblbname)
        Me.Controls.Add(Me.lblcname)
        Me.Controls.Add(Me.showsid)
        Me.Controls.Add(Me.lblcid)
        Me.Controls.Add(Me.cmbcoursename)
        Me.Controls.Add(Me.cmbbranchname)
        Me.Controls.Add(Me.cmbsemester)
        Me.Controls.Add(Me.cmbclasstype)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Addclassroom"
        Me.Size = New System.Drawing.Size(1440, 1022)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsave As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnview As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnupdate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btndelete As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnadd As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents lblcid As System.Windows.Forms.Label
    Friend WithEvents showsid As System.Windows.Forms.Label
    Friend WithEvents lblcname As System.Windows.Forms.Label
    Friend WithEvents lblbname As System.Windows.Forms.Label
    Friend WithEvents lblsemester As System.Windows.Forms.Label
    Friend WithEvents lblcrname As System.Windows.Forms.Label
    Friend WithEvents txtclassname As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents lblclasstype As System.Windows.Forms.Label
    Friend WithEvents lblnewclassroom As System.Windows.Forms.Label
    Friend WithEvents txtnewclassroom As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents lblcoursename As System.Windows.Forms.Label
    Friend WithEvents lblbranchname As System.Windows.Forms.Label
    Friend WithEvents lblsemestername As System.Windows.Forms.Label
    Friend WithEvents lblctype As System.Windows.Forms.Label
    Friend WithEvents cmbcoursename As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbbranchname As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbsemester As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbclasstype As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbclassroom As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents DataGridView1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Brnach_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Course_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Branch_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
