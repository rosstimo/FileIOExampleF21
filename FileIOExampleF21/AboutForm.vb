Public Class AboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AboutLabel.Text =
$"User Data Program
Version 0.001 Alpha
By Tim Rossiter
Fall 2021
Use at your own risk"
    End Sub

    Private Sub AboutForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FileIOForm.Show()
    End Sub
End Class