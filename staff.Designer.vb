<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staff))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnsave = New Bunifu.Framework.UI.BunifuTileButton()
        Me.lblsfid = New System.Windows.Forms.Label()
        Me.lblshowid = New System.Windows.Forms.Label()
        Me.lblsfname = New System.Windows.Forms.Label()
        Me.lblstaffgender = New System.Windows.Forms.Label()
        Me.rdbmale = New System.Windows.Forms.RadioButton()
        Me.rdbfemale = New System.Windows.Forms.RadioButton()
        Me.lblstaff_mo_no = New System.Windows.Forms.Label()
        Me.lblstaff_email = New System.Windows.Forms.Label()
        Me.btnadd = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btndelete = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnupdate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnview = New Bunifu.Framework.UI.BunifuTileButton()
        Me.lblgendername = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblmobile = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblemail = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cmbstaffname = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txtstaffname = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtstaff_mo_no = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtstaffemail = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.DataGridView1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.staff_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staff_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staff_gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staff_mono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staff_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lblnewstaff = New System.Windows.Forms.Label()
        Me.txtnewstaff = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
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
        Me.btnsave.Location = New System.Drawing.Point(103, 396)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(86, 86)
        Me.btnsave.TabIndex = 28
        '
        'lblsfid
        '
        Me.lblsfid.AutoSize = True
        Me.lblsfid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsfid.ForeColor = System.Drawing.Color.White
        Me.lblsfid.Location = New System.Drawing.Point(13, 21)
        Me.lblsfid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsfid.Name = "lblsfid"
        Me.lblsfid.Size = New System.Drawing.Size(90, 20)
        Me.lblsfid.TabIndex = 29
        Me.lblsfid.Text = "Staff I'd :-"
        '
        'lblshowid
        '
        Me.lblshowid.AutoSize = True
        Me.lblshowid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblshowid.ForeColor = System.Drawing.Color.White
        Me.lblshowid.Location = New System.Drawing.Point(255, 21)
        Me.lblshowid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblshowid.Name = "lblshowid"
        Me.lblshowid.Size = New System.Drawing.Size(15, 20)
        Me.lblshowid.TabIndex = 40
        Me.lblshowid.Text = "-"
        '
        'lblsfname
        '
        Me.lblsfname.AutoSize = True
        Me.lblsfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsfname.ForeColor = System.Drawing.Color.White
        Me.lblsfname.Location = New System.Drawing.Point(13, 80)
        Me.lblsfname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsfname.Name = "lblsfname"
        Me.lblsfname.Size = New System.Drawing.Size(116, 20)
        Me.lblsfname.TabIndex = 41
        Me.lblsfname.Text = "Staff Name :-"
        '
        'lblstaffgender
        '
        Me.lblstaffgender.AutoSize = True
        Me.lblstaffgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaffgender.ForeColor = System.Drawing.Color.White
        Me.lblstaffgender.Location = New System.Drawing.Point(13, 139)
        Me.lblstaffgender.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblstaffgender.Name = "lblstaffgender"
        Me.lblstaffgender.Size = New System.Drawing.Size(130, 20)
        Me.lblstaffgender.TabIndex = 42
        Me.lblstaffgender.Text = "Staff Gender :-"
        '
        'rdbmale
        '
        Me.rdbmale.AutoSize = True
        Me.rdbmale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbmale.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rdbmale.Location = New System.Drawing.Point(187, 139)
        Me.rdbmale.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbmale.Name = "rdbmale"
        Me.rdbmale.Size = New System.Drawing.Size(60, 21)
        Me.rdbmale.TabIndex = 43
        Me.rdbmale.TabStop = True
        Me.rdbmale.Text = "Male"
        Me.rdbmale.UseVisualStyleBackColor = True
        '
        'rdbfemale
        '
        Me.rdbfemale.AutoSize = True
        Me.rdbfemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbfemale.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rdbfemale.Location = New System.Drawing.Point(259, 141)
        Me.rdbfemale.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbfemale.Name = "rdbfemale"
        Me.rdbfemale.Size = New System.Drawing.Size(78, 21)
        Me.rdbfemale.TabIndex = 44
        Me.rdbfemale.TabStop = True
        Me.rdbfemale.Text = "Female"
        Me.rdbfemale.UseVisualStyleBackColor = True
        '
        'lblstaff_mo_no
        '
        Me.lblstaff_mo_no.AutoSize = True
        Me.lblstaff_mo_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaff_mo_no.ForeColor = System.Drawing.Color.White
        Me.lblstaff_mo_no.Location = New System.Drawing.Point(13, 198)
        Me.lblstaff_mo_no.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblstaff_mo_no.Name = "lblstaff_mo_no"
        Me.lblstaff_mo_no.Size = New System.Drawing.Size(149, 20)
        Me.lblstaff_mo_no.TabIndex = 45
        Me.lblstaff_mo_no.Text = "Staff Mobile No :-"
        '
        'lblstaff_email
        '
        Me.lblstaff_email.AutoSize = True
        Me.lblstaff_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaff_email.ForeColor = System.Drawing.Color.White
        Me.lblstaff_email.Location = New System.Drawing.Point(13, 255)
        Me.lblstaff_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblstaff_email.Name = "lblstaff_email"
        Me.lblstaff_email.Size = New System.Drawing.Size(114, 20)
        Me.lblstaff_email.TabIndex = 46
        Me.lblstaff_email.Text = "Staff Email :-"
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
        Me.btndelete.Location = New System.Drawing.Point(412, 593)
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
        Me.btnupdate.Location = New System.Drawing.Point(638, 593)
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
        Me.btnview.Location = New System.Drawing.Point(862, 593)
        Me.btnview.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(165, 110)
        Me.btnview.TabIndex = 61
        '
        'lblgendername
        '
        Me.lblgendername.AutoSize = True
        Me.lblgendername.BackColor = System.Drawing.Color.Transparent
        Me.lblgendername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgendername.ForeColor = System.Drawing.Color.White
        Me.lblgendername.Location = New System.Drawing.Point(216, 138)
        Me.lblgendername.Name = "lblgendername"
        Me.lblgendername.Size = New System.Drawing.Size(15, 20)
        Me.lblgendername.TabIndex = 65
        Me.lblgendername.Text = "-"
        '
        'lblmobile
        '
        Me.lblmobile.AutoSize = True
        Me.lblmobile.BackColor = System.Drawing.Color.Transparent
        Me.lblmobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmobile.ForeColor = System.Drawing.Color.White
        Me.lblmobile.Location = New System.Drawing.Point(216, 198)
        Me.lblmobile.Name = "lblmobile"
        Me.lblmobile.Size = New System.Drawing.Size(15, 20)
        Me.lblmobile.TabIndex = 66
        Me.lblmobile.Text = "-"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.BackColor = System.Drawing.Color.Transparent
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.ForeColor = System.Drawing.Color.White
        Me.lblemail.Location = New System.Drawing.Point(216, 258)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(15, 20)
        Me.lblemail.TabIndex = 67
        Me.lblemail.Text = "-"
        '
        'cmbstaffname
        '
        Me.cmbstaffname.BackColor = System.Drawing.Color.Transparent
        Me.cmbstaffname.BorderRadius = 3
        Me.cmbstaffname.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstaffname.ForeColor = System.Drawing.Color.Black
        Me.cmbstaffname.Items = New String(-1) {}
        Me.cmbstaffname.Location = New System.Drawing.Point(187, 69)
        Me.cmbstaffname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbstaffname.Name = "cmbstaffname"
        Me.cmbstaffname.NomalColor = System.Drawing.Color.White
        Me.cmbstaffname.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cmbstaffname.selectedIndex = -1
        Me.cmbstaffname.Size = New System.Drawing.Size(206, 31)
        Me.cmbstaffname.TabIndex = 72
        Me.cmbstaffname.UseWaitCursor = True
        '
        'txtstaffname
        '
        Me.txtstaffname.BorderColor = System.Drawing.Color.Black
        Me.txtstaffname.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstaffname.Location = New System.Drawing.Point(187, 75)
        Me.txtstaffname.Name = "txtstaffname"
        Me.txtstaffname.Size = New System.Drawing.Size(206, 25)
        Me.txtstaffname.TabIndex = 74
        '
        'txtstaff_mo_no
        '
        Me.txtstaff_mo_no.BorderColor = System.Drawing.Color.Black
        Me.txtstaff_mo_no.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstaff_mo_no.Location = New System.Drawing.Point(187, 193)
        Me.txtstaff_mo_no.MaxLength = 10
        Me.txtstaff_mo_no.Name = "txtstaff_mo_no"
        Me.txtstaff_mo_no.Size = New System.Drawing.Size(206, 25)
        Me.txtstaff_mo_no.TabIndex = 75
        '
        'txtstaffemail
        '
        Me.txtstaffemail.BorderColor = System.Drawing.Color.Black
        Me.txtstaffemail.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstaffemail.Location = New System.Drawing.Point(187, 250)
        Me.txtstaffemail.Name = "txtstaffemail"
        Me.txtstaffemail.Size = New System.Drawing.Size(206, 25)
        Me.txtstaffemail.TabIndex = 76
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.staff_Id, Me.staff_name, Me.staff_gender, Me.staff_mono, Me.staff_email})
        Me.DataGridView1.DoubleBuffered = True
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.DataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(487, 21)
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
        Me.DataGridView1.Size = New System.Drawing.Size(577, 418)
        Me.DataGridView1.TabIndex = 78
        '
        'staff_Id
        '
        Me.staff_Id.HeaderText = "Staff Id"
        Me.staff_Id.Name = "staff_Id"
        Me.staff_Id.ReadOnly = True
        Me.staff_Id.Width = 120
        '
        'staff_name
        '
        Me.staff_name.HeaderText = "Staff Name"
        Me.staff_name.Name = "staff_name"
        Me.staff_name.ReadOnly = True
        Me.staff_name.Width = 150
        '
        'staff_gender
        '
        Me.staff_gender.HeaderText = "Staff Geneder"
        Me.staff_gender.Name = "staff_gender"
        Me.staff_gender.ReadOnly = True
        Me.staff_gender.Width = 150
        '
        'staff_mono
        '
        Me.staff_mono.HeaderText = "Staff Mobile No."
        Me.staff_mono.Name = "staff_mono"
        Me.staff_mono.ReadOnly = True
        Me.staff_mono.Width = 170
        '
        'staff_email
        '
        Me.staff_email.HeaderText = "Staff Email"
        Me.staff_email.Name = "staff_email"
        Me.staff_email.ReadOnly = True
        Me.staff_email.Width = 160
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(422, 21)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(44, 418)
        Me.BunifuSeparator3.TabIndex = 111
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = True
        '
        'lblnewstaff
        '
        Me.lblnewstaff.AutoSize = True
        Me.lblnewstaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewstaff.ForeColor = System.Drawing.Color.White
        Me.lblnewstaff.Location = New System.Drawing.Point(13, 316)
        Me.lblnewstaff.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnewstaff.Name = "lblnewstaff"
        Me.lblnewstaff.Size = New System.Drawing.Size(155, 20)
        Me.lblnewstaff.TabIndex = 112
        Me.lblnewstaff.Text = "New Staff Name :-"
        '
        'txtnewstaff
        '
        Me.txtnewstaff.BorderColor = System.Drawing.Color.Black
        Me.txtnewstaff.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewstaff.Location = New System.Drawing.Point(187, 311)
        Me.txtnewstaff.Name = "txtnewstaff"
        Me.txtnewstaff.Size = New System.Drawing.Size(206, 25)
        Me.txtnewstaff.TabIndex = 113
        '
        'staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Controls.Add(Me.txtnewstaff)
        Me.Controls.Add(Me.lblnewstaff)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbstaffname)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblmobile)
        Me.Controls.Add(Me.lblgendername)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.lblstaff_email)
        Me.Controls.Add(Me.lblstaff_mo_no)
        Me.Controls.Add(Me.rdbfemale)
        Me.Controls.Add(Me.rdbmale)
        Me.Controls.Add(Me.lblstaffgender)
        Me.Controls.Add(Me.lblsfname)
        Me.Controls.Add(Me.lblshowid)
        Me.Controls.Add(Me.lblsfid)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtstaff_mo_no)
        Me.Controls.Add(Me.txtstaffname)
        Me.Controls.Add(Me.txtstaffemail)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "staff"
        Me.Size = New System.Drawing.Size(1066, 792)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsave As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents lblsfid As System.Windows.Forms.Label
    Friend WithEvents lblshowid As System.Windows.Forms.Label
    Friend WithEvents lblsfname As System.Windows.Forms.Label
    Friend WithEvents lblstaffgender As System.Windows.Forms.Label
    Friend WithEvents rdbmale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbfemale As System.Windows.Forms.RadioButton
    Friend WithEvents lblstaff_mo_no As System.Windows.Forms.Label
    Friend WithEvents lblstaff_email As System.Windows.Forms.Label
    Friend WithEvents btnadd As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btndelete As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnupdate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnview As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents lblgendername As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblmobile As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblemail As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cmbstaffname As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents txtstaffname As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtstaff_mo_no As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtstaffemail As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents DataGridView1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents staff_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staff_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staff_gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staff_mono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staff_email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lblnewstaff As System.Windows.Forms.Label
    Friend WithEvents txtnewstaff As WindowsFormsControlLibrary1.BunifuCustomTextbox

End Class
