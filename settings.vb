Public Class settings

    Private Sub btnprinter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprinter.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        txtprintername.Text = PrintDialog1.PrinterSettings.PrinterName
    End Sub

    Private Sub settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtprintername.Text = My.Settings.printer
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        My.Settings.printer = txtprintername.Text
        My.Settings.Save()
        Me.Hide()
        'main.Show()
        'main.mainmanu.Show()
    End Sub
End Class
