<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileIOForm
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
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.UserInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.ActionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.DataGroupBox = New System.Windows.Forms.GroupBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UserInfoGroupBox.SuspendLayout()
        Me.ActionsGroupBox.SuspendLayout()
        Me.DataGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'UserInfoGroupBox
        '
        Me.UserInfoGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.LastNameLabel)
        Me.UserInfoGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.UserInfoGroupBox.Location = New System.Drawing.Point(13, 12)
        Me.UserInfoGroupBox.Name = "UserInfoGroupBox"
        Me.UserInfoGroupBox.Size = New System.Drawing.Size(321, 320)
        Me.UserInfoGroupBox.TabIndex = 0
        Me.UserInfoGroupBox.TabStop = False
        Me.UserInfoGroupBox.Text = "User Information"
        '
        'ActionsGroupBox
        '
        Me.ActionsGroupBox.Controls.Add(Me.ExitButton)
        Me.ActionsGroupBox.Controls.Add(Me.UpdateButton)
        Me.ActionsGroupBox.Location = New System.Drawing.Point(339, 338)
        Me.ActionsGroupBox.Name = "ActionsGroupBox"
        Me.ActionsGroupBox.Size = New System.Drawing.Size(449, 100)
        Me.ActionsGroupBox.TabIndex = 2
        Me.ActionsGroupBox.TabStop = False
        '
        'DataGroupBox
        '
        Me.DataGroupBox.Controls.Add(Me.DisplayListBox)
        Me.DataGroupBox.Location = New System.Drawing.Point(339, 12)
        Me.DataGroupBox.Name = "DataGroupBox"
        Me.DataGroupBox.Size = New System.Drawing.Size(449, 320)
        Me.DataGroupBox.TabIndex = 1
        Me.DataGroupBox.TabStop = False
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(21, 39)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(26, 13)
        Me.FirstNameLabel.TabIndex = 0
        Me.FirstNameLabel.Text = "First"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(66, 36)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(221, 20)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(66, 62)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(221, 20)
        Me.LastNameTextBox.TabIndex = 3
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(21, 69)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(27, 13)
        Me.LastNameLabel.TabIndex = 2
        Me.LastNameLabel.Text = "Last"
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.Location = New System.Drawing.Point(6, 43)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(437, 264)
        Me.DisplayListBox.TabIndex = 0
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(165, 19)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(136, 75)
        Me.UpdateButton.TabIndex = 0
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(307, 19)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(136, 75)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FileIOForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ActionsGroupBox)
        Me.Controls.Add(Me.DataGroupBox)
        Me.Controls.Add(Me.UserInfoGroupBox)
        Me.Name = "FileIOForm"
        Me.Text = "User Form"
        Me.UserInfoGroupBox.ResumeLayout(False)
        Me.UserInfoGroupBox.PerformLayout()
        Me.ActionsGroupBox.ResumeLayout(False)
        Me.DataGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents UserInfoGroupBox As GroupBox
    Friend WithEvents ActionsGroupBox As GroupBox
    Friend WithEvents DataGroupBox As GroupBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DisplayListBox As ListBox
End Class
