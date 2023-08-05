<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        Me.lblprintername = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtprintername = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.btnprinter = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnclose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SuspendLayout()
        '
        'lblprintername
        '
        Me.lblprintername.AutoSize = True
        Me.lblprintername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprintername.ForeColor = System.Drawing.Color.White
        Me.lblprintername.Location = New System.Drawing.Point(53, 77)
        Me.lblprintername.Name = "lblprintername"
        Me.lblprintername.Size = New System.Drawing.Size(129, 20)
        Me.lblprintername.TabIndex = 0
        Me.lblprintername.Text = "Printer Name :-"
        '
        'txtprintername
        '
        Me.txtprintername.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtprintername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprintername.Location = New System.Drawing.Point(210, 77)
        Me.txtprintername.Name = "txtprintername"
        Me.txtprintername.Size = New System.Drawing.Size(195, 26)
        Me.txtprintername.TabIndex = 1
        '
        'btnprinter
        '
        Me.btnprinter.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnprinter.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnprinter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnprinter.BorderRadius = 0
        Me.btnprinter.ButtonText = "Pick"
        Me.btnprinter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprinter.DisabledColor = System.Drawing.Color.Gray
        Me.btnprinter.Iconcolor = System.Drawing.Color.Transparent
        Me.btnprinter.Iconimage = CType(resources.GetObject("btnprinter.Iconimage"), System.Drawing.Image)
        Me.btnprinter.Iconimage_right = Nothing
        Me.btnprinter.Iconimage_right_Selected = Nothing
        Me.btnprinter.Iconimage_Selected = Nothing
        Me.btnprinter.IconMarginLeft = 0
        Me.btnprinter.IconMarginRight = 0
        Me.btnprinter.IconRightVisible = True
        Me.btnprinter.IconRightZoom = 0.0R
        Me.btnprinter.IconVisible = True
        Me.btnprinter.IconZoom = 90.0R
        Me.btnprinter.IsTab = False
        Me.btnprinter.Location = New System.Drawing.Point(237, 127)
        Me.btnprinter.Name = "btnprinter"
        Me.btnprinter.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnprinter.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnprinter.OnHoverTextColor = System.Drawing.Color.White
        Me.btnprinter.selected = False
        Me.btnprinter.Size = New System.Drawing.Size(118, 40)
        Me.btnprinter.TabIndex = 130
        Me.btnprinter.Text = "Pick"
        Me.btnprinter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnprinter.Textcolor = System.Drawing.Color.White
        Me.btnprinter.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnclose
        '
        Me.btnclose.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.BorderRadius = 0
        Me.btnclose.ButtonText = "close"
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.DisabledColor = System.Drawing.Color.Gray
        Me.btnclose.Iconcolor = System.Drawing.Color.Transparent
        Me.btnclose.Iconimage = CType(resources.GetObject("btnclose.Iconimage"), System.Drawing.Image)
        Me.btnclose.Iconimage_right = Nothing
        Me.btnclose.Iconimage_right_Selected = Nothing
        Me.btnclose.Iconimage_Selected = Nothing
        Me.btnclose.IconMarginLeft = 0
        Me.btnclose.IconMarginRight = 0
        Me.btnclose.IconRightVisible = True
        Me.btnclose.IconRightZoom = 0.0R
        Me.btnclose.IconVisible = True
        Me.btnclose.IconZoom = 90.0R
        Me.btnclose.IsTab = False
        Me.btnclose.Location = New System.Drawing.Point(412, 127)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnclose.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnclose.OnHoverTextColor = System.Drawing.Color.White
        Me.btnclose.selected = False
        Me.btnclose.Size = New System.Drawing.Size(118, 40)
        Me.btnclose.TabIndex = 131
        Me.btnclose.Text = "close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.Textcolor = System.Drawing.Color.White
        Me.btnclose.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnprinter)
        Me.Controls.Add(Me.txtprintername)
        Me.Controls.Add(Me.lblprintername)
        Me.Name = "settings"
        Me.Size = New System.Drawing.Size(630, 194)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblprintername As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtprintername As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents btnprinter As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuFlatButton

End Class
