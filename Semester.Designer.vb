<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Semester
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Semester))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblsid = New System.Windows.Forms.Label()
        Me.showsid = New System.Windows.Forms.Label()
        Me.lblcname = New System.Windows.Forms.Label()
        Me.lblbname = New System.Windows.Forms.Label()
        Me.lblsemester = New System.Windows.Forms.Label()
        Me.lblnewsemester = New System.Windows.Forms.Label()
        Me.btnsave = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnadd = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btndelete = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnupdate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnview = New Bunifu.Framework.UI.BunifuTileButton()
        Me.txtsemester = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtnewsemester = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.cmbsemester = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbbranchname = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbcoursename = New Bunifu.Framework.UI.BunifuDropdown()
        Me.DataGridView1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Brnach_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Course_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Branch_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblsid
        '
        Me.lblsid.AutoSize = True
        Me.lblsid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsid.ForeColor = System.Drawing.Color.White
        Me.lblsid.Location = New System.Drawing.Point(25, 86)
        Me.lblsid.Name = "lblsid"
        Me.lblsid.Size = New System.Drawing.Size(154, 25)
        Me.lblsid.TabIndex = 28
        Me.lblsid.Text = "Semester I'd :-"
        '
        'showsid
        '
        Me.showsid.AutoSize = True
        Me.showsid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showsid.ForeColor = System.Drawing.Color.White
        Me.showsid.Location = New System.Drawing.Point(376, 86)
        Me.showsid.Name = "showsid"
        Me.showsid.Size = New System.Drawing.Size(20, 25)
        Me.showsid.TabIndex = 29
        Me.showsid.Text = "-"
        '
        'lblcname
        '
        Me.lblcname.AutoSize = True
        Me.lblcname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcname.ForeColor = System.Drawing.Color.White
        Me.lblcname.Location = New System.Drawing.Point(25, 150)
        Me.lblcname.Name = "lblcname"
        Me.lblcname.Size = New System.Drawing.Size(165, 25)
        Me.lblcname.TabIndex = 30
        Me.lblcname.Text = "Course Name :-"
        '
        'lblbname
        '
        Me.lblbname.AutoSize = True
        Me.lblbname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbname.ForeColor = System.Drawing.Color.White
        Me.lblbname.Location = New System.Drawing.Point(25, 217)
        Me.lblbname.Name = "lblbname"
        Me.lblbname.Size = New System.Drawing.Size(163, 25)
        Me.lblbname.TabIndex = 32
        Me.lblbname.Text = "Branch Name :-"
        '
        'lblsemester
        '
        Me.lblsemester.AutoSize = True
        Me.lblsemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsemester.ForeColor = System.Drawing.Color.White
        Me.lblsemester.Location = New System.Drawing.Point(25, 281)
        Me.lblsemester.Name = "lblsemester"
        Me.lblsemester.Size = New System.Drawing.Size(187, 25)
        Me.lblsemester.TabIndex = 34
        Me.lblsemester.Text = "Semester Name :-"
        '
        'lblnewsemester
        '
        Me.lblnewsemester.AutoSize = True
        Me.lblnewsemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewsemester.ForeColor = System.Drawing.Color.White
        Me.lblnewsemester.Location = New System.Drawing.Point(25, 367)
        Me.lblnewsemester.Name = "lblnewsemester"
        Me.lblnewsemester.Size = New System.Drawing.Size(235, 25)
        Me.lblnewsemester.TabIndex = 36
        Me.lblnewsemester.Text = "Semester New Name :-"
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
        Me.btnsave.Location = New System.Drawing.Point(224, 492)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(115, 106)
        Me.btnsave.TabIndex = 27
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
        Me.btnadd.Location = New System.Drawing.Point(245, 730)
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
        'txtsemester
        '
        Me.txtsemester.BorderColor = System.Drawing.Color.Black
        Me.txtsemester.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsemester.Location = New System.Drawing.Point(293, 274)
        Me.txtsemester.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtsemester.Name = "txtsemester"
        Me.txtsemester.Size = New System.Drawing.Size(273, 29)
        Me.txtsemester.TabIndex = 64
        '
        'txtnewsemester
        '
        Me.txtnewsemester.BorderColor = System.Drawing.Color.Black
        Me.txtnewsemester.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewsemester.Location = New System.Drawing.Point(293, 361)
        Me.txtnewsemester.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnewsemester.Name = "txtnewsemester"
        Me.txtnewsemester.Size = New System.Drawing.Size(273, 29)
        Me.txtnewsemester.TabIndex = 65
        '
        'cmbsemester
        '
        Me.cmbsemester.BackColor = System.Drawing.Color.Transparent
        Me.cmbsemester.BorderRadius = 3
        Me.cmbsemester.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsemester.ForeColor = System.Drawing.Color.Black
        Me.cmbsemester.Items = New String(-1) {}
        Me.cmbsemester.Location = New System.Drawing.Point(293, 267)
        Me.cmbsemester.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmbsemester.Name = "cmbsemester"
        Me.cmbsemester.NomalColor = System.Drawing.Color.White
        Me.cmbsemester.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbsemester.selectedIndex = -1
        Me.cmbsemester.Size = New System.Drawing.Size(275, 38)
        Me.cmbsemester.TabIndex = 66
        '
        'cmbbranchname
        '
        Me.cmbbranchname.BackColor = System.Drawing.Color.Transparent
        Me.cmbbranchname.BorderRadius = 3
        Me.cmbbranchname.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbranchname.ForeColor = System.Drawing.Color.Black
        Me.cmbbranchname.Items = New String(-1) {}
        Me.cmbbranchname.Location = New System.Drawing.Point(293, 203)
        Me.cmbbranchname.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmbbranchname.Name = "cmbbranchname"
        Me.cmbbranchname.NomalColor = System.Drawing.Color.White
        Me.cmbbranchname.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbbranchname.selectedIndex = -1
        Me.cmbbranchname.Size = New System.Drawing.Size(275, 38)
        Me.cmbbranchname.TabIndex = 67
        '
        'cmbcoursename
        '
        Me.cmbcoursename.BackColor = System.Drawing.Color.Transparent
        Me.cmbcoursename.BorderRadius = 3
        Me.cmbcoursename.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcoursename.ForeColor = System.Drawing.Color.Black
        Me.cmbcoursename.Items = New String(-1) {}
        Me.cmbcoursename.Location = New System.Drawing.Point(293, 137)
        Me.cmbcoursename.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmbcoursename.Name = "cmbcoursename"
        Me.cmbcoursename.NomalColor = System.Drawing.Color.White
        Me.cmbcoursename.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbcoursename.selectedIndex = -1
        Me.cmbcoursename.Size = New System.Drawing.Size(275, 38)
        Me.cmbcoursename.TabIndex = 68
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
        Me.DataGridView1.Location = New System.Drawing.Point(804, 58)
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
        Me.DataGridView1.Size = New System.Drawing.Size(585, 514)
        Me.DataGridView1.TabIndex = 74
        '
        'Brnach_Id
        '
        Me.Brnach_Id.HeaderText = "Semester Id"
        Me.Brnach_Id.Name = "Brnach_Id"
        Me.Brnach_Id.ReadOnly = True
        Me.Brnach_Id.Width = 150
        '
        'Course_Id
        '
        Me.Course_Id.HeaderText = "Branch Id"
        Me.Course_Id.Name = "Course_Id"
        Me.Course_Id.ReadOnly = True
        Me.Course_Id.Width = 150
        '
        'Branch_Name
        '
        Me.Branch_Name.HeaderText = "Semester Name"
        Me.Branch_Name.Name = "Branch_Name"
        Me.Branch_Name.ReadOnly = True
        Me.Branch_Name.Width = 180
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(672, 58)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(47, 514)
        Me.BunifuSeparator1.TabIndex = 75
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'Semester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbcoursename)
        Me.Controls.Add(Me.cmbbranchname)
        Me.Controls.Add(Me.cmbsemester)
        Me.Controls.Add(Me.txtnewsemester)
        Me.Controls.Add(Me.txtsemester)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.lblnewsemester)
        Me.Controls.Add(Me.lblsemester)
        Me.Controls.Add(Me.lblbname)
        Me.Controls.Add(Me.lblcname)
        Me.Controls.Add(Me.showsid)
        Me.Controls.Add(Me.lblsid)
        Me.Controls.Add(Me.btnsave)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Semester"
        Me.Size = New System.Drawing.Size(1421, 975)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsave As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents lblsid As System.Windows.Forms.Label
    Friend WithEvents showsid As System.Windows.Forms.Label
    Friend WithEvents lblcname As System.Windows.Forms.Label
    Friend WithEvents lblbname As System.Windows.Forms.Label
    Friend WithEvents lblsemester As System.Windows.Forms.Label
    Friend WithEvents lblnewsemester As System.Windows.Forms.Label
    Friend WithEvents btnadd As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btndelete As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnupdate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnview As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents txtsemester As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtnewsemester As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents cmbsemester As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbbranchname As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbcoursename As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents DataGridView1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Brnach_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Course_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Branch_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator

End Class
