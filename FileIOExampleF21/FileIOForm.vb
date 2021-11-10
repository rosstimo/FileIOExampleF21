Public Class FileIOForm
    Dim fileName As String = "../../CleanData2.txt"
    Dim users(199, 8) As String
    Dim filteredUsers As New List(Of String)


    'TODO:
    'filter display results
    'use temp array to align list index with array/list index
    'Use temp file to update/remove records

    'FileIO
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

    Sub AddUser()
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
        OpenFileDialog.FileName = ""
        OpenFileDialog.Filter = "All files (*.*)|*.*"

        If OpenFileDialog.ShowDialog() = 1 Then
            Me.fileName = OpenFileDialog.FileName
        End If
        Me.Text = Me.fileName
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
        'Me.Text = CStr(DisplayListBox.Items.Count)
    End Sub

    'Filter
    Function FilterSelection() As Integer
        Dim selection As Integer = -1
        Select Case True
            Case FirstNameRadioButton.Checked
                selection = 0
            Case LastNameRadioButton.Checked
                selection = 1
            Case CityRadioButton.Checked
                selection = 3
        End Select
        Return selection
    End Function

    Sub FilterByFirstName()
        For i = LBound(Me.users) To UBound(Me.users)
            If InStr(users(i, 0), FilterTextBox.Text) >= 1 Then
                Me.filteredUsers.Add($"{users(i, 0)},{users(i, 1)},{users(i, 2)},{users(i, 3)},{users(i, 4)},{users(i, 5)},{users(i, 6)},{users(i, 7)}")
            End If
        Next
    End Sub

    Sub FilterByLastName()
        For i = LBound(Me.users) To UBound(Me.users)
            If InStr(users(i, 1), FilterTextBox.Text) >= 1 Then
                Me.filteredUsers.Add($"{users(i, 0)},{users(i, 1)},{users(i, 2)},{users(i, 3)},{users(i, 4)},{users(i, 5)},{users(i, 6)},{users(i, 7)}")
            End If
        Next
    End Sub

    Sub FilterResults()
        'TODO add case sensitive check box CompareMethod.Text = 1 CompareMethod.Binary = 0
        Me.filteredUsers.Clear()
        For i = LBound(Me.users) To UBound(Me.users)
            If InStr(users(i, FilterSelection()), FilterTextBox.Text, CompareMethod.Text) >= 1 Then
                Me.filteredUsers.Add($"{users(i, 0)},{users(i, 1)},{users(i, 2)},{users(i, 3)},{users(i, 4)},{users(i, 5)},{users(i, 6)},{users(i, 7)}")
            End If
        Next
    End Sub

    'Display
    Sub Display()
        DisplayListBox.Items.Clear()
        Dim temp() As String
        'For i = LBound(Me.users) To UBound(Me.users)
        '    DisplayListBox.Items.Add($"{users(i, 0)} {users(i, 1)} ")
        'Next

        For Each currentUser In Me.filteredUsers
            temp = Split(currentUser, ",")
            DisplayListBox.Items.Add($"{temp(0)} {temp(1)}")
        Next

    End Sub

    Sub SetDefaults()
        ShowAllRadioButton.Checked = True
    End Sub

    'Event Handlers
    Private Sub FileIOForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
        'WriteFile()
        'AppendFile()
        ReadRecords()
        'Me.Close()
        'Display()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        FilterResults()
        Display()
    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        Dim temp() As String
        temp = Split(filteredUsers.Item(DisplayListBox.SelectedIndex), ",")

        FirstNameTextBox.Text = temp(0)
        LastNameTextBox.Text = temp(1)
        StreetTextBox.Text = temp(2)
        CityTextBox.Text = temp(3)
        StateTextBox.Text = temp(4)
        ZipTextBox.Text = temp(5)
        PhoneTextBox.Text = temp(6)
        EmailTextBox.Text = temp(7)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        ChooseFile()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
        Me.Hide()
    End Sub

    Private Sub ExitHandler(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Testing

    Sub testListOfArrays()
        Dim records As New List(Of String())
        'had an issue with a list of arrays where it seemed to be adding duplicates of the last values
        'assigned to the array. seemed like what was being loaded into the list was a reference to the array rather than a copy
        'below is an attempt to avoid this by not declaring a variable and simply assigning array values during the list add.
        For i = LBound(users) To UBound(users)
            records.Add({users(i, 0), users(i, 1), users(i, 2), users(i, 3), users(i, 4), users(i, 5), users(i, 6), users(i, 7)})
        Next

        DisplayListBox.Items.Clear()
        For Each record In records
            DisplayListBox.Items.Add($"{record(0)} {record(1)}")
        Next
    End Sub


End Class
