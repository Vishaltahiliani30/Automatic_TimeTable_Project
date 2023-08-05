<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.header = New System.Windows.Forms.Panel()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Sidemenu = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton9 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton8 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton7 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnsemesterandbranch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnlogo = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblCurrentUser = New System.Windows.Forms.Label()
        Me.mainmanu = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblsemesterdetail = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblsubjectdetail = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblstaffdetail = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.semesterprogressbar = New Bunifu.Framework.UI.BunifuGauge()
        Me.subjectprogressbar = New Bunifu.Framework.UI.BunifuGauge()
        Me.staffprogressbar = New Bunifu.Framework.UI.BunifuGauge()
        Me.lblbranchdetail = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.branchprogressbar = New Bunifu.Framework.UI.BunifuGauge()
        Me.lblcoursedetail = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.courseprogressbar = New Bunifu.Framework.UI.BunifuGauge()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelTransition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuFlatButton10 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.header.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sidemenu.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainmanu.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.header.Controls.Add(Me.BunifuImageButton3)
        Me.header.Controls.Add(Me.BunifuImageButton1)
        Me.header.Controls.Add(Me.BunifuImageButton2)
        Me.header.Controls.Add(Me.PictureBox1)
        Me.header.Controls.Add(Me.BunifuCustomLabel1)
        Me.PanelTransition.SetDecoration(Me.header, BunifuAnimatorNS.DecorationType.None)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Margin = New System.Windows.Forms.Padding(4)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1920, 58)
        Me.header.TabIndex = 2
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton3.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(1800, 0)
        Me.BunifuImageButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(40, 58)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 5
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1840, 0)
        Me.BunifuImageButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(40, 58)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 4
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(1880, 0)
        Me.BunifuImageButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(40, 58)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 3
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'PictureBox1
        '
        Me.PanelTransition.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 9)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.PanelTransition.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(64, 15)
        Me.BunifuCustomLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(203, 25)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Time Table Generator"
        '
        'Sidemenu
        '
        Me.Sidemenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Sidemenu.Controls.Add(Me.BunifuFlatButton10)
        Me.Sidemenu.Controls.Add(Me.BunifuFlatButton9)
        Me.Sidemenu.Controls.Add(Me.BunifuFlatButton8)
        Me.Sidemenu.Controls.Add(Me.BunifuFlatButton7)
        Me.Sidemenu.Controls.Add(Me.BunifuFlatButton2)
        Me.Sidemenu.Controls.Add(Me.PictureBox2)
        Me.Sidemenu.Controls.Add(Me.BunifuFlatButton6)
        Me.Sidemenu.Controls.Add(Me.BunifuFlatButton5)
        Me.Sidemenu.Controls.Add(Me.BunifuFlatButton4)
        Me.Sidemenu.Controls.Add(Me.BunifuFlatButton3)
        Me.Sidemenu.Controls.Add(Me.btnsemesterandbranch)
        Me.Sidemenu.Controls.Add(Me.BunifuFlatButton1)
        Me.Sidemenu.Controls.Add(Me.btnlogo)
        Me.Sidemenu.Controls.Add(Me.lblCurrentUser)
        Me.PanelTransition.SetDecoration(Me.Sidemenu, BunifuAnimatorNS.DecorationType.None)
        Me.Sidemenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Sidemenu.Location = New System.Drawing.Point(0, 58)
        Me.Sidemenu.Margin = New System.Windows.Forms.Padding(4)
        Me.Sidemenu.Name = "Sidemenu"
        Me.Sidemenu.Size = New System.Drawing.Size(480, 1022)
        Me.Sidemenu.TabIndex = 3
        '
        'BunifuFlatButton9
        '
        Me.BunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton9.BorderRadius = 0
        Me.BunifuFlatButton9.ButtonText = "Settings"
        Me.BunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.BunifuFlatButton9, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.Iconimage = CType(resources.GetObject("BunifuFlatButton9.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton9.Iconimage_right = Nothing
        Me.BunifuFlatButton9.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton9.Iconimage_Selected = Nothing
        Me.BunifuFlatButton9.IconMarginLeft = 0
        Me.BunifuFlatButton9.IconMarginRight = 0
        Me.BunifuFlatButton9.IconRightVisible = True
        Me.BunifuFlatButton9.IconRightZoom = 0.0R
        Me.BunifuFlatButton9.IconVisible = True
        Me.BunifuFlatButton9.IconZoom = 50.0R
        Me.BunifuFlatButton9.IsTab = False
        Me.BunifuFlatButton9.Location = New System.Drawing.Point(-5, 853)
        Me.BunifuFlatButton9.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton9.Name = "BunifuFlatButton9"
        Me.BunifuFlatButton9.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton9.selected = True
        Me.BunifuFlatButton9.Size = New System.Drawing.Size(480, 59)
        Me.BunifuFlatButton9.TabIndex = 10
        Me.BunifuFlatButton9.Text = "Settings"
        Me.BunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton9.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton9.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton8
        '
        Me.BunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton8.BorderRadius = 0
        Me.BunifuFlatButton8.ButtonText = "Print"
        Me.BunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.BunifuFlatButton8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.Iconimage = CType(resources.GetObject("BunifuFlatButton8.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton8.Iconimage_right = Nothing
        Me.BunifuFlatButton8.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton8.Iconimage_Selected = Nothing
        Me.BunifuFlatButton8.IconMarginLeft = 0
        Me.BunifuFlatButton8.IconMarginRight = 0
        Me.BunifuFlatButton8.IconRightVisible = True
        Me.BunifuFlatButton8.IconRightZoom = 0.0R
        Me.BunifuFlatButton8.IconVisible = True
        Me.BunifuFlatButton8.IconZoom = 50.0R
        Me.BunifuFlatButton8.IsTab = False
        Me.BunifuFlatButton8.Location = New System.Drawing.Point(0, 784)
        Me.BunifuFlatButton8.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton8.Name = "BunifuFlatButton8"
        Me.BunifuFlatButton8.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton8.selected = True
        Me.BunifuFlatButton8.Size = New System.Drawing.Size(480, 59)
        Me.BunifuFlatButton8.TabIndex = 9
        Me.BunifuFlatButton8.Text = "Print"
        Me.BunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton8.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton8.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 0
        Me.BunifuFlatButton7.ButtonText = "Assign Subject"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.BunifuFlatButton7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = CType(resources.GetObject("BunifuFlatButton7.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 0
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = True
        Me.BunifuFlatButton7.IconRightZoom = 0.0R
        Me.BunifuFlatButton7.IconVisible = True
        Me.BunifuFlatButton7.IconZoom = 50.0R
        Me.BunifuFlatButton7.IsTab = False
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(0, 715)
        Me.BunifuFlatButton7.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton7.selected = True
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(480, 59)
        Me.BunifuFlatButton7.TabIndex = 8
        Me.BunifuFlatButton7.Text = "Assign Subject"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Semester"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0.0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 60.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(0, 370)
        Me.BunifuFlatButton2.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.selected = True
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(480, 59)
        Me.BunifuFlatButton2.TabIndex = 7
        Me.BunifuFlatButton2.Text = "Semester"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'PictureBox2
        '
        Me.PanelTransition.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(107, 4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(211, 194)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 0
        Me.BunifuFlatButton6.ButtonText = "Lecture Credits"
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.BunifuFlatButton6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = CType(resources.GetObject("BunifuFlatButton6.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 0
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = True
        Me.BunifuFlatButton6.IconRightZoom = 0.0R
        Me.BunifuFlatButton6.IconVisible = True
        Me.BunifuFlatButton6.IconZoom = 70.0R
        Me.BunifuFlatButton6.IsTab = False
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(0, 577)
        Me.BunifuFlatButton6.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton6.selected = True
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(480, 59)
        Me.BunifuFlatButton6.TabIndex = 6
        Me.BunifuFlatButton6.Text = "Lecture Credits"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "Generate Time Table"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = CType(resources.GetObject("BunifuFlatButton5.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0.0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 50.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(0, 646)
        Me.BunifuFlatButton5.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton5.selected = True
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(480, 59)
        Me.BunifuFlatButton5.TabIndex = 3
        Me.BunifuFlatButton5.Text = "Generate Time Table"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "Staff"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = CType(resources.GetObject("BunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0.0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 50.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(0, 508)
        Me.BunifuFlatButton4.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton4.selected = True
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(480, 59)
        Me.BunifuFlatButton4.TabIndex = 5
        Me.BunifuFlatButton4.Text = "Staff"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Subjects"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0.0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 50.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(0, 439)
        Me.BunifuFlatButton3.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton3.selected = True
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(480, 59)
        Me.BunifuFlatButton3.TabIndex = 4
        Me.BunifuFlatButton3.Text = "Subjects"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'btnsemesterandbranch
        '
        Me.btnsemesterandbranch.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnsemesterandbranch.BackColor = System.Drawing.Color.Transparent
        Me.btnsemesterandbranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsemesterandbranch.BorderRadius = 0
        Me.btnsemesterandbranch.ButtonText = "Branch"
        Me.btnsemesterandbranch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.btnsemesterandbranch, BunifuAnimatorNS.DecorationType.None)
        Me.btnsemesterandbranch.DisabledColor = System.Drawing.Color.Gray
        Me.btnsemesterandbranch.Iconcolor = System.Drawing.Color.Transparent
        Me.btnsemesterandbranch.Iconimage = CType(resources.GetObject("btnsemesterandbranch.Iconimage"), System.Drawing.Image)
        Me.btnsemesterandbranch.Iconimage_right = Nothing
        Me.btnsemesterandbranch.Iconimage_right_Selected = Nothing
        Me.btnsemesterandbranch.Iconimage_Selected = Nothing
        Me.btnsemesterandbranch.IconMarginLeft = 0
        Me.btnsemesterandbranch.IconMarginRight = 0
        Me.btnsemesterandbranch.IconRightVisible = True
        Me.btnsemesterandbranch.IconRightZoom = 0.0R
        Me.btnsemesterandbranch.IconVisible = True
        Me.btnsemesterandbranch.IconZoom = 50.0R
        Me.btnsemesterandbranch.IsTab = False
        Me.btnsemesterandbranch.Location = New System.Drawing.Point(0, 302)
        Me.btnsemesterandbranch.Margin = New System.Windows.Forms.Padding(5)
        Me.btnsemesterandbranch.Name = "btnsemesterandbranch"
        Me.btnsemesterandbranch.Normalcolor = System.Drawing.Color.Transparent
        Me.btnsemesterandbranch.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsemesterandbranch.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnsemesterandbranch.selected = True
        Me.btnsemesterandbranch.Size = New System.Drawing.Size(480, 59)
        Me.btnsemesterandbranch.TabIndex = 3
        Me.btnsemesterandbranch.Text = "Branch"
        Me.btnsemesterandbranch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnsemesterandbranch.Textcolor = System.Drawing.Color.Silver
        Me.btnsemesterandbranch.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Course"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 233)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.selected = True
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(480, 59)
        Me.BunifuFlatButton1.TabIndex = 2
        Me.BunifuFlatButton1.Text = "Course"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'btnlogo
        '
        Me.btnlogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnlogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelTransition.SetDecoration(Me.btnlogo, BunifuAnimatorNS.DecorationType.None)
        Me.btnlogo.Image = CType(resources.GetObject("btnlogo.Image"), System.Drawing.Image)
        Me.btnlogo.ImageActive = Nothing
        Me.btnlogo.Location = New System.Drawing.Point(427, 7)
        Me.btnlogo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlogo.Name = "btnlogo"
        Me.btnlogo.Size = New System.Drawing.Size(45, 34)
        Me.btnlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnlogo.TabIndex = 2
        Me.btnlogo.TabStop = False
        Me.btnlogo.Zoom = 10
        '
        'lblCurrentUser
        '
        Me.lblCurrentUser.AutoSize = True
        Me.PanelTransition.SetDecoration(Me.lblCurrentUser, BunifuAnimatorNS.DecorationType.None)
        Me.lblCurrentUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblCurrentUser.ForeColor = System.Drawing.Color.White
        Me.lblCurrentUser.Location = New System.Drawing.Point(144, 202)
        Me.lblCurrentUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(24, 31)
        Me.lblCurrentUser.TabIndex = 1
        Me.lblCurrentUser.Text = "-"
        '
        'mainmanu
        '
        Me.mainmanu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.mainmanu.Controls.Add(Me.BunifuCustomLabel2)
        Me.mainmanu.Controls.Add(Me.lblsemesterdetail)
        Me.mainmanu.Controls.Add(Me.lblsubjectdetail)
        Me.mainmanu.Controls.Add(Me.lblstaffdetail)
        Me.mainmanu.Controls.Add(Me.semesterprogressbar)
        Me.mainmanu.Controls.Add(Me.subjectprogressbar)
        Me.mainmanu.Controls.Add(Me.staffprogressbar)
        Me.mainmanu.Controls.Add(Me.lblbranchdetail)
        Me.mainmanu.Controls.Add(Me.branchprogressbar)
        Me.mainmanu.Controls.Add(Me.lblcoursedetail)
        Me.mainmanu.Controls.Add(Me.courseprogressbar)
        Me.PanelTransition.SetDecoration(Me.mainmanu, BunifuAnimatorNS.DecorationType.None)
        Me.mainmanu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainmanu.Location = New System.Drawing.Point(480, 58)
        Me.mainmanu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mainmanu.Name = "mainmanu"
        Me.mainmanu.Size = New System.Drawing.Size(1440, 1022)
        Me.mainmanu.TabIndex = 0
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.PanelTransition.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Yu Gothic UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(201, 57)
        Me.BunifuCustomLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(892, 67)
        Me.BunifuCustomLabel2.TabIndex = 10
        Me.BunifuCustomLabel2.Text = "D     A     S     H     B     O     A     R     D"
        '
        'lblsemesterdetail
        '
        Me.PanelTransition.SetDecoration(Me.lblsemesterdetail, BunifuAnimatorNS.DecorationType.None)
        Me.lblsemesterdetail.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsemesterdetail.ForeColor = System.Drawing.Color.White
        Me.lblsemesterdetail.Location = New System.Drawing.Point(1052, 415)
        Me.lblsemesterdetail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsemesterdetail.Name = "lblsemesterdetail"
        Me.lblsemesterdetail.Size = New System.Drawing.Size(232, 105)
        Me.lblsemesterdetail.TabIndex = 9
        Me.lblsemesterdetail.Text = "-"
        Me.lblsemesterdetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsubjectdetail
        '
        Me.PanelTransition.SetDecoration(Me.lblsubjectdetail, BunifuAnimatorNS.DecorationType.None)
        Me.lblsubjectdetail.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubjectdetail.ForeColor = System.Drawing.Color.White
        Me.lblsubjectdetail.Location = New System.Drawing.Point(293, 774)
        Me.lblsubjectdetail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsubjectdetail.Name = "lblsubjectdetail"
        Me.lblsubjectdetail.Size = New System.Drawing.Size(232, 105)
        Me.lblsubjectdetail.TabIndex = 8
        Me.lblsubjectdetail.Text = "-"
        Me.lblsubjectdetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblstaffdetail
        '
        Me.PanelTransition.SetDecoration(Me.lblstaffdetail, BunifuAnimatorNS.DecorationType.None)
        Me.lblstaffdetail.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaffdetail.ForeColor = System.Drawing.Color.White
        Me.lblstaffdetail.Location = New System.Drawing.Point(855, 774)
        Me.lblstaffdetail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblstaffdetail.Name = "lblstaffdetail"
        Me.lblstaffdetail.Size = New System.Drawing.Size(232, 105)
        Me.lblstaffdetail.TabIndex = 7
        Me.lblstaffdetail.Text = "-"
        Me.lblstaffdetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'semesterprogressbar
        '
        Me.semesterprogressbar.BackgroundImage = CType(resources.GetObject("semesterprogressbar.BackgroundImage"), System.Drawing.Image)
        Me.PanelTransition.SetDecoration(Me.semesterprogressbar, BunifuAnimatorNS.DecorationType.None)
        Me.semesterprogressbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.semesterprogressbar.ForeColor = System.Drawing.Color.White
        Me.semesterprogressbar.Location = New System.Drawing.Point(1056, 263)
        Me.semesterprogressbar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.semesterprogressbar.Name = "semesterprogressbar"
        Me.semesterprogressbar.ProgressBgColor = System.Drawing.Color.Gray
        Me.semesterprogressbar.ProgressColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.semesterprogressbar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.semesterprogressbar.Size = New System.Drawing.Size(232, 144)
        Me.semesterprogressbar.TabIndex = 6
        Me.semesterprogressbar.Thickness = 30
        Me.semesterprogressbar.Value = 0
        '
        'subjectprogressbar
        '
        Me.subjectprogressbar.BackgroundImage = CType(resources.GetObject("subjectprogressbar.BackgroundImage"), System.Drawing.Image)
        Me.PanelTransition.SetDecoration(Me.subjectprogressbar, BunifuAnimatorNS.DecorationType.None)
        Me.subjectprogressbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.subjectprogressbar.ForeColor = System.Drawing.Color.White
        Me.subjectprogressbar.Location = New System.Drawing.Point(297, 607)
        Me.subjectprogressbar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.subjectprogressbar.Name = "subjectprogressbar"
        Me.subjectprogressbar.ProgressBgColor = System.Drawing.Color.Gray
        Me.subjectprogressbar.ProgressColor1 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.subjectprogressbar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.subjectprogressbar.Size = New System.Drawing.Size(232, 144)
        Me.subjectprogressbar.TabIndex = 5
        Me.subjectprogressbar.Thickness = 30
        Me.subjectprogressbar.Value = 0
        '
        'staffprogressbar
        '
        Me.staffprogressbar.BackgroundImage = CType(resources.GetObject("staffprogressbar.BackgroundImage"), System.Drawing.Image)
        Me.PanelTransition.SetDecoration(Me.staffprogressbar, BunifuAnimatorNS.DecorationType.None)
        Me.staffprogressbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.staffprogressbar.ForeColor = System.Drawing.Color.White
        Me.staffprogressbar.Location = New System.Drawing.Point(859, 607)
        Me.staffprogressbar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.staffprogressbar.Name = "staffprogressbar"
        Me.staffprogressbar.ProgressBgColor = System.Drawing.Color.Gray
        Me.staffprogressbar.ProgressColor1 = System.Drawing.Color.White
        Me.staffprogressbar.ProgressColor2 = System.Drawing.Color.White
        Me.staffprogressbar.Size = New System.Drawing.Size(232, 144)
        Me.staffprogressbar.TabIndex = 4
        Me.staffprogressbar.Thickness = 30
        Me.staffprogressbar.Value = 0
        '
        'lblbranchdetail
        '
        Me.PanelTransition.SetDecoration(Me.lblbranchdetail, BunifuAnimatorNS.DecorationType.None)
        Me.lblbranchdetail.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbranchdetail.ForeColor = System.Drawing.Color.White
        Me.lblbranchdetail.Location = New System.Drawing.Point(571, 415)
        Me.lblbranchdetail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblbranchdetail.Name = "lblbranchdetail"
        Me.lblbranchdetail.Size = New System.Drawing.Size(232, 105)
        Me.lblbranchdetail.TabIndex = 3
        Me.lblbranchdetail.Text = "-"
        Me.lblbranchdetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'branchprogressbar
        '
        Me.branchprogressbar.BackgroundImage = CType(resources.GetObject("branchprogressbar.BackgroundImage"), System.Drawing.Image)
        Me.PanelTransition.SetDecoration(Me.branchprogressbar, BunifuAnimatorNS.DecorationType.None)
        Me.branchprogressbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.branchprogressbar.ForeColor = System.Drawing.Color.White
        Me.branchprogressbar.Location = New System.Drawing.Point(575, 263)
        Me.branchprogressbar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.branchprogressbar.Name = "branchprogressbar"
        Me.branchprogressbar.ProgressBgColor = System.Drawing.Color.Gray
        Me.branchprogressbar.ProgressColor1 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.branchprogressbar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.branchprogressbar.Size = New System.Drawing.Size(232, 144)
        Me.branchprogressbar.TabIndex = 2
        Me.branchprogressbar.Thickness = 30
        Me.branchprogressbar.Value = 0
        '
        'lblcoursedetail
        '
        Me.PanelTransition.SetDecoration(Me.lblcoursedetail, BunifuAnimatorNS.DecorationType.None)
        Me.lblcoursedetail.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoursedetail.ForeColor = System.Drawing.Color.White
        Me.lblcoursedetail.Location = New System.Drawing.Point(87, 415)
        Me.lblcoursedetail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcoursedetail.Name = "lblcoursedetail"
        Me.lblcoursedetail.Size = New System.Drawing.Size(232, 105)
        Me.lblcoursedetail.TabIndex = 1
        Me.lblcoursedetail.Text = "-"
        Me.lblcoursedetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'courseprogressbar
        '
        Me.courseprogressbar.BackgroundImage = CType(resources.GetObject("courseprogressbar.BackgroundImage"), System.Drawing.Image)
        Me.PanelTransition.SetDecoration(Me.courseprogressbar, BunifuAnimatorNS.DecorationType.None)
        Me.courseprogressbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.courseprogressbar.ForeColor = System.Drawing.Color.White
        Me.courseprogressbar.Location = New System.Drawing.Point(87, 263)
        Me.courseprogressbar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.courseprogressbar.Name = "courseprogressbar"
        Me.courseprogressbar.ProgressBgColor = System.Drawing.Color.Gray
        Me.courseprogressbar.ProgressColor1 = System.Drawing.Color.Yellow
        Me.courseprogressbar.ProgressColor2 = System.Drawing.Color.Yellow
        Me.courseprogressbar.Size = New System.Drawing.Size(232, 144)
        Me.courseprogressbar.TabIndex = 0
        Me.courseprogressbar.Thickness = 30
        Me.courseprogressbar.Value = 0
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Nothing
        Me.BunifuDragControl1.Vertical = True
        '
        'PanelTransition
        '
        Me.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.PanelTransition.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.PanelTransition.DefaultAnimation = Animation1
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.header
        Me.BunifuDragControl2.Vertical = True
        '
        'BunifuFlatButton10
        '
        Me.BunifuFlatButton10.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton10.BorderRadius = 0
        Me.BunifuFlatButton10.ButtonText = "Add Classroom"
        Me.BunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.BunifuFlatButton10, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton10.Iconimage = CType(resources.GetObject("BunifuFlatButton10.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton10.Iconimage_right = Nothing
        Me.BunifuFlatButton10.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton10.Iconimage_Selected = Nothing
        Me.BunifuFlatButton10.IconMarginLeft = 0
        Me.BunifuFlatButton10.IconMarginRight = 0
        Me.BunifuFlatButton10.IconRightVisible = True
        Me.BunifuFlatButton10.IconRightZoom = 0.0R
        Me.BunifuFlatButton10.IconVisible = True
        Me.BunifuFlatButton10.IconZoom = 50.0R
        Me.BunifuFlatButton10.IsTab = False
        Me.BunifuFlatButton10.Location = New System.Drawing.Point(0, 922)
        Me.BunifuFlatButton10.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton10.Name = "BunifuFlatButton10"
        Me.BunifuFlatButton10.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton10.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton10.selected = True
        Me.BunifuFlatButton10.Size = New System.Drawing.Size(480, 59)
        Me.BunifuFlatButton10.TabIndex = 11
        Me.BunifuFlatButton10.Text = "Add Classroom"
        Me.BunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton10.Textcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton10.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.mainmanu)
        Me.Controls.Add(Me.Sidemenu)
        Me.Controls.Add(Me.header)
        Me.PanelTransition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "main"
        Me.Text = "main"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sidemenu.ResumeLayout(False)
        Me.Sidemenu.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainmanu.ResumeLayout(False)
        Me.mainmanu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents mainmanu As System.Windows.Forms.Panel
    Friend WithEvents Sidemenu As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnsemesterandbranch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnlogo As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblCurrentUser As System.Windows.Forms.Label
    Friend WithEvents header As System.Windows.Forms.Panel
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PanelTransition As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton7 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblcoursedetail As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents courseprogressbar As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents lblbranchdetail As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents branchprogressbar As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents lblsemesterdetail As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblsubjectdetail As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblstaffdetail As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents semesterprogressbar As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents subjectprogressbar As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents staffprogressbar As Bunifu.Framework.UI.BunifuGauge
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuFlatButton8 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton9 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton10 As Bunifu.Framework.UI.BunifuFlatButton
End Class
