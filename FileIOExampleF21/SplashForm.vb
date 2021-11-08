Public Class SplashForm
    Private Sub SplashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.istockphoto_1208790371_612x612
        Me.BackgroundImageLayout = ImageLayout.Zoom
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Timer1.Interval = 5000
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        FileIOForm.Show()
        Me.Close()
    End Sub
End Class