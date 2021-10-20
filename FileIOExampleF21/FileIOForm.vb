Public Class FileIOForm
    Private Sub FileIOForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        WriteFile()
    End Sub

    Sub WriteFile()
        'absolute path
        'Dim fileName As String = "C:\Users\rosstimo\OneDrive\Sync\github\FileIOExampleF21\exampleF21.txt"

        'relative path: up two dir levels
        Dim fileName As String = "../../exampleF21.txt"

        FileOpen(1, fileName, OpenMode.Output)

        FileClose(1)

    End Sub



End Class
