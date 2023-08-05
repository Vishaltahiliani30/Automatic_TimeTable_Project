<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Branch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Branch))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblbid = New System.Windows.Forms.Label()
        Me.showbid = New System.Windows.Forms.Label()
        Me.lblbname = New System.Windows.Forms.Label()
        Me.lblcname = New System.Windows.Forms.Label()
        Me.lblnewbranch = New System.Windows.Forms.Label()
        Me.btnsave = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnadd = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btndelete = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnupdate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnview = New Bunifu.Framework.UI.BunifuTileButton()
        Me.cmbcoursename = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbbranchname = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txtbranch = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtnewbranch = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.DataGridView1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Brnach_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Course_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Branch_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblbid
        '
        Me.lblbid.AutoSize = True
        Me.lblbid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbid.ForeColor = System.Drawing.Color.White
        Me.lblbid.Location = New System.Drawing.Point(20, 104)
        Me.lblbid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblbid.Name = "lblbid"
        Me.lblbid.Size = New System.Drawing.Size(107, 20)
        Me.lblbid.TabIndex = 14
        Me.lblbid.Text = "Branch I'd :-"
        '
        'showbid
        '
        Me.showbid.AutoSize = True
        Me.showbid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showbid.ForeColor = System.Drawing.Color.White
        Me.showbid.Location = New System.Drawing.Point(268, 104)
        Me.showbid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.showbid.Name = "showbid"
        Me.showbid.Size = New System.Drawing.Size(15, 20)
        Me.showbid.TabIndex = 15
        Me.showbid.Text = "-"
        '
        'lblbname
        '
        Me.lblbname.AutoSize = True
        Me.lblbname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbname.ForeColor = System.Drawing.Color.White
        Me.lblbname.Location = New System.Drawing.Point(20, 210)
        Me.lblbname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblbname.Name = "lblbname"
        Me.lblbname.Size = New System.Drawing.Size(133, 20)
        Me.lblbname.TabIndex = 16
        Me.lblbname.Text = "Branch Name :-"
        '
        'lblcname
        '
        Me.lblcname.AutoSize = True
        Me.lblcname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcname.ForeColor = System.Drawing.Color.White
        Me.lblcname.Location = New System.Drawing.Point(20, 160)
        Me.lblcname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcname.Name = "lblcname"
        Me.lblcname.Size = New System.Drawing.Size(133, 20)
        Me.lblcname.TabIndex = 17
        Me.lblcname.Text = "Course Name :-"
        '
        'lblnewbranch
        '
        Me.lblnewbranch.AutoSize = True
        Me.lblnewbranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewbranch.ForeColor = System.Drawing.Color.White
        Me.lblnewbranch.Location = New System.Drawing.Point(20, 269)
        Me.lblnewbranch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnewbranch.Name = "lblnewbranch"
        Me.lblnewbranch.Size = New System.Drawing.Size(172, 20)
        Me.lblnewbranch.TabIndex = 22
        Me.lblnewbranch.Text = "New Branch Name :-"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Transparent
        Me.btnsave.color = System.Drawing.Color.Transparent
        Me.btnsave.colorActive = System.Drawing.Color.Transparent
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImagePosition = 25
        Me.btnsave.ImageZoom = 50
        Me.btnsave.LabelPosition = 35
        Me.btnsave.LabelText = "Save"
        Me.btnsave.Location = New System.Drawing.Point(159, 341)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(96, 105)
        Me.btnsave.TabIndex = 20
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
        Me.btnadd.Location = New System.Drawing.Point(188, 593)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(165, 110)
        Me.btnadd.TabIndex = 59
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
        Me.btndelete.Location = New System.Drawing.Point(412, 593)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(165, 110)
        Me.btndelete.TabIndex = 60
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
        Me.btnupdate.Location = New System.Drawing.Point(638, 593)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(165, 110)
        Me.btnupdate.TabIndex = 61
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
        Me.btnview.Location = New System.Drawing.Point(862, 593)
        Me.btnview.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(165, 110)
        Me.btnview.TabIndex = 62
        '
        'cmbcoursename
        '
        Me.cmbcoursename.BackColor = System.Drawing.Color.Transparent
        Me.cmbcoursename.BorderRadius = 3
        Me.cmbcoursename.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcoursename.ForeColor = System.Drawing.Color.Black
        Me.cmbcoursename.Items = New String(-1) {}
        Me.cmbcoursename.Location = New System.Drawing.Point(224, 149)
        Me.cmbcoursename.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbcoursename.Name = "cmbcoursename"
        Me.cmbcoursename.NomalColor = System.Drawing.Color.White
        Me.cmbcoursename.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbcoursename.selectedIndex = -1
        Me.cmbcoursename.Size = New System.Drawing.Size(206, 31)
        Me.cmbcoursename.TabIndex = 67
        '
        'cmbbranchname
        '
        Me.cmbbranchname.BackColor = System.Drawing.Color.Transparent
        Me.cmbbranchname.BorderRadius = 3
        Me.cmbbranchname.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbranchname.ForeColor = System.Drawing.Color.Black
        Me.cmbbranchname.Items = New String(-1) {}
        Me.cmbbranchname.Location = New System.Drawing.Point(224, 199)
        Me.cmbbranchname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbbranchname.Name = "cmbbranchname"
        Me.cmbbranchname.NomalColor = System.Drawing.Color.White
        Me.cmbbranchname.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbbranchname.selectedIndex = -1
        Me.cmbbranchname.Size = New System.Drawing.Size(206, 31)
        Me.cmbbranchname.TabIndex = 68
        '
        'txtbranch
        '
        Me.txtbranch.BorderColor = System.Drawing.Color.Black
        Me.txtbranch.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranch.Location = New System.Drawing.Point(224, 205)
        Me.txtbranch.Name = "txtbranch"
        Me.txtbranch.Size = New System.Drawing.Size(206, 25)
        Me.txtbranch.TabIndex = 69
        '
        'txtnewbranch
        '
        Me.txtnewbranch.BorderColor = System.Drawing.Color.Black
        Me.txtnewbranch.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewbranch.Location = New System.Drawing.Point(224, 264)
        Me.txtnewbranch.Name = "txtnewbranch"
        Me.txtnewbranch.Size = New System.Drawing.Size(206, 25)
        Me.txtnewbranch.TabIndex = 70
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Brnach_Id, Me.Course_Id, Me.Branch_Name})
        Me.DataGridView1.DoubleBuffered = True
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.DataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(622, 42)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 4
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.Size = New System.Drawing.Size(428, 418)
        Me.DataGridView1.TabIndex = 73
        '
        'Brnach_Id
        '
        Me.Brnach_Id.HeaderText = "Branch Id"
        Me.Brnach_Id.Name = "Brnach_Id"
        Me.Brnach_Id.ReadOnly = True
        Me.Brnach_Id.Width = 150
        '
        'Course_Id
        '
        Me.Course_Id.HeaderText = "Course Id"
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
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(512, 42)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(35, 418)
        Me.BunifuSeparator1.TabIndex = 74
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'Branch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtnewbranch)
        Me.Controls.Add(Me.cmbbranchname)
        Me.Controls.Add(Me.cmbcoursename)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.lblnewbranch)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.lblcname)
        Me.Controls.Add(Me.lblbname)
        Me.Controls.Add(Me.showbid)
        Me.Controls.Add(Me.lblbid)
        Me.Controls.Add(Me.txtbranch)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Branch"
        Me.Size = New System.Drawing.Size(1066, 792)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblbid As System.Windows.Forms.Label
    Friend WithEvents showbid As System.Windows.Forms.Label
    Friend WithEvents lblbname As System.Windows.Forms.Label
    Friend WithEvents lblcname As System.Windows.Forms.Label
    Friend WithEvents btnsave As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents lblnewbranch As System.Windows.Forms.Label
    Friend WithEvents btnadd As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btndelete As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnupdate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnview As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents cmbcoursename As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbbranchname As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents txtbranch As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtnewbranch As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents DataGridView1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Brnach_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Course_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Branch_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator

End Class
