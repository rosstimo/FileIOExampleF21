Public Class FileIOForm
    Private Sub FileIOForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'WriteFile()
        'AppendFile()
        ReadRecords()
        Me.Close()
    End Sub

    Sub WriteFile()
        'absolute path
        'Dim fileName As String = "C:\Users\rosstimo\OneDrive\Sync\github\FileIOExampleF21\exampleF21.txt"

        'relative path: up two dir levels
        Dim fileName As String = "../../exampleF21.txt"

        'Open file for write access
        'destroys existing file contents
        FileOpen(1, fileName, OpenMode.Output)
        ' Print text to the file. The quotation marks will be in the display.
        Write(1, "Follow the white rabbit...")
        FileClose(1)

    End Sub


    Sub AppendFile()
        Dim fileName As String = "../../exampleF21.txt"

        'Append to the end of file
        'preserves existing file content
        FileOpen(1, fileName, OpenMode.Append)

        'Write(1, "Follow the white rabbit...")
        'WriteLine(1)'write only a new line delimiter
        'WriteLine(1, "Knock Knock Neo....")
        WriteLine(1, "Zone 1", SPC(10), "Zone 2")
        WriteLine(1, "Zone 1", StrDup(10, " "), "Zone 2")

        FileClose(1)

    End Sub

    Sub ReadLines()

    End Sub

    Sub ReadRecords()
        Dim fileName As String = "../../exampleF21.txt"
        Dim recordData As String

        Try
            FileOpen(1, fileName, OpenMode.Input)

            For i = 0 To 14
                Input(1, recordData)
                Console.WriteLine(recordData)
            Next
            Do Until EOF(1)
                Input(1, recordData)
                Console.WriteLine(recordData)
            Loop

        Catch notFound As System.IO.FileNotFoundException
            MsgBox("oops that file doesn't exist")
        Catch e As Exception
            MsgBox("that was weird!")
        End Try

        FileClose(1)
    End Sub

End Class
