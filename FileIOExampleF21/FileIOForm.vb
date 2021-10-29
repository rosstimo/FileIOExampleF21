Public Class FileIOForm
    Dim fileName As String = "../../CleanData2.txt"
    Dim records As New List(Of String)
    Dim users(199, 8) As String

    Private Function FileExists(ByRef path As String) As Boolean
        Try
            FileLen(path)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function


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
    Sub AddCustomer()
        Dim fileName As String = "../../clean.txt"
        Dim fileNum As Integer = FreeFile()

        FileOpen(fileNum, fileName, OpenMode.Append)
        Write(fileNum, FirstNameTextBox.Text)
        Write(fileNum, LastNameTextBox.Text)
        Write(fileNum, StreetTextBox.Text)
        Write(fileNum, CityTextBox.Text)
        Write(fileNum, StateTextBox.Text)
        Write(fileNum, ZipTextBox.Text)
        Write(fileNum, PhoneTextBox.Text)
        Write(fileNum, EmailTextBox.Text)

        WriteLine(fileNum)
        FileClose(fileNum)

    End Sub

    Sub ChooseFile()
        OpenFileDialog.FileName = Me.fileName
        OpenFileDialog.Filter = "All files (*.*)|*.*"

        If OpenFileDialog.ShowDialog() = 1 Then
            Me.fileName = OpenFileDialog.FileName
            Me.Text = Me.fileName
        End If
    End Sub


    Sub ReadLines()
        Dim currentLine As String
        Dim fileNum As Integer = FreeFile()

        If FileExists(Me.fileName) Then
            Try
                FileOpen(fileNum, Me.fileName, OpenMode.Input)
                Do Until EOF(fileNum)
                    'Input(fileNum, recordData)
                    currentLine = LineInput(fileNum)
                    'SeperateRecords(currentLine)
                    'Me.records.Add(currentLine)
                    DisplayListBox.Items.Add(currentLine)
                    'Console.WriteLine(currentLine)
                Loop
            Catch e As Exception
                MsgBox($"{e.GetType.FullName}:{vbCrLf}{e.Message}")
            End Try
            FileClose(fileNum)
        Else
            ChooseFile()
        End If
    End Sub

    Sub ReadRecords()
        Dim currentRecord As String
        Dim fileNum As Integer = FreeFile()
        Dim userString As String
        Dim user As Integer
        If FileExists(Me.fileName) Then
            Try
                FileOpen(fileNum, Me.fileName, OpenMode.Input)
                Do Until EOF(fileNum)
                    For record = 0 To 8
                        Input(fileNum, currentRecord)
                        'userString &= currentRecord
                        Me.users(user, record) = currentRecord
                    Next
                    'DisplayListBox.Items.Add(userString)
                    userString = ""
                    user += 1
                Loop
            Catch e As Exception
                MsgBox($"{e.GetType.FullName}:{vbCrLf}{e.Message}")
            End Try
            FileClose(fileNum)
        Else
            ChooseFile()
        End If
        Me.Text = CStr(DisplayListBox.Items.Count)
    End Sub

    Sub Display()
        DisplayListBox.Items.Clear()
        For i = LBound(Me.users) To UBound(Me.users)
            DisplayListBox.Items.Add($"{users(i, 0)} {users(i, 1)} ")
        Next
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'AddCustomer()
        'ReadLines()
        ReadRecords()
        Display()

    End Sub


    Function SeperateRecords(ByVal record As String) As String
        Dim temp() As String
        Dim noise() As String
        temp = Split(record, ",")
        Try
            noise = Split(temp(0), "$$")
            FirstNameTextBox.Text = noise(1) 'temp(0)
            LastNameTextBox.Text = temp(1)
            StateTextBox.Text = "ID"
            CityTextBox.Text = temp(2)
            noise = Split(temp(3), Chr(34))
            EmailTextBox.Text = noise(0) 'temp(3)
        Catch
        End Try
        AddCustomer()
        Return ""
    End Function

    Private Sub FileIOForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'WriteFile()
        'AppendFile()
        'ReadRecords()
        'Me.Close()
        'Display()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        Me.Text = CStr(DisplayListBox.SelectedIndex)
        CityTextBox.Text = users(DisplayListBox.SelectedIndex, 3)
    End Sub
End Class
