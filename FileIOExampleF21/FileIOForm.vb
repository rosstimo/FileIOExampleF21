Public Class FileIOForm
    Dim fileName As String = "../../UserData.txt"

    Private Sub FileIOForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'WriteFile()
        'AppendFile()
        'ReadRecords()
        'Me.Close()
        Display()
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
        'Dim fileName As String = "../../XexampleF21.txt"
        Dim recordData As String


        Try
            FileOpen(1, fileName, OpenMode.Input)

        Catch notFound As System.IO.FileNotFoundException
            'If the file does not exist open a dialog for user to choose file
            'OpenFileDialog.InitialDirectory 
            OpenFileDialog.FileName = "CoolFile.txt"
            OpenFileDialog.Filter = "txt files (*.txt)|*.txt|image (*.jpg)|*.jpg|Soto (*.soto)|*.soto|All files (*.*)|*.*"


            If OpenFileDialog.ShowDialog() = 1 Then
                fileName = OpenFileDialog.FileName
                FileOpen(1, fileName, OpenMode.Input)
            End If
        Catch e As Exception
            MsgBox($"{e.GetType.FullName}:{vbCrLf}{e.Message}")
        End Try

        'For i = 0 To 14
        '    Input(1, recordData)
        '    Console.WriteLine(recordData)
        'Next
        Do Until EOF(1)
            Input(1, recordData)
            Console.WriteLine(recordData)
        Loop

        FileClose(1)
    End Sub

    Sub AddCustomer()
        Dim fileName As String = "../../CustomerData.txt"
        Dim fileNum As Integer = FreeFile()

        FileOpen(fileNum, fileName, OpenMode.Append)
        Write(fileNum, FirstNameTextBox.Text)
        Write(fileNum, LastNameTextBox.Text)
        WriteLine(fileNum)
        FileClose(fileNum)

    End Sub

    Sub Display()
        'Dim fileName As String = "../../CustomerData.txt"
        Dim fileNum As Integer = FreeFile()
        Dim currentRecord As String
        Dim formattedInfo As String


        Try
            FileOpen(fileNum, Me.fileName, OpenMode.Input)

        Catch notFound As System.IO.FileNotFoundException
            'If the file does not exist open a dialog for user to choose file
            'OpenFileDialog.InitialDirectory 
            OpenFileDialog.FileName = ""
            OpenFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"


            If OpenFileDialog.ShowDialog() = 1 Then
                Me.fileName = OpenFileDialog.FileName
            Else
                Me.fileName = "../../temp.txt"
                FileOpen(fileNum, fileName, OpenMode.Append)
                FileClose(fileNum)
            End If
            FileOpen(fileNum, fileName, OpenMode.Input)
        Catch e As Exception
            MsgBox($"{e.GetType.FullName}:{vbCrLf}{e.Message}")
        End Try

        Try
            Do Until EOF(fileNum)
                Input(fileNum, currentRecord)
                If currentRecord <> "" Then
                    SeperateRecords(currentRecord)
                    DisplayListBox.Items.Add(currentRecord)
                End If
                'Input(fileNum, currentRecord)

                'DisplayListBox.Items.Add(formattedInfo)
            Loop
        Catch
        End Try
        FileClose(fileNum)




    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'AddCustomer()
        Display()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Function SeperateRecords(ByVal record As String) As String
        Dim temp() As String

        temp = Split(record, ",")
        Try
            FirstNameTextBox.Text = temp(0)
            LastNameTextBox.Text = temp(1)
            CityTextBox.Text = temp(2)
            EmailTextBox.Text = temp(3)
        Catch
        End Try
        Return ""
    End Function

End Class
