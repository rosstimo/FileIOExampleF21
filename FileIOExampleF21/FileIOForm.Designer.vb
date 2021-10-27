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
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.StreetLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.ActionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DataGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
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
        Me.UserInfoGroupBox.Controls.Add(Me.EmailTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.EmailLabel)
        Me.UserInfoGroupBox.Controls.Add(Me.PhoneTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.PhoneLabel)
        Me.UserInfoGroupBox.Controls.Add(Me.StateTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.StateLabel)
        Me.UserInfoGroupBox.Controls.Add(Me.ZipTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.ZipLabel)
        Me.UserInfoGroupBox.Controls.Add(Me.CityTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.CityLabel)
        Me.UserInfoGroupBox.Controls.Add(Me.StreetTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.StreetLabel)
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
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(66, 192)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(221, 20)
        Me.PhoneTextBox.TabIndex = 13
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Location = New System.Drawing.Point(21, 195)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(38, 13)
        Me.PhoneLabel.TabIndex = 12
        Me.PhoneLabel.Text = "Phone"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(66, 140)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(221, 20)
        Me.StateTextBox.TabIndex = 11
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(21, 147)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(32, 13)
        Me.StateLabel.TabIndex = 10
        Me.StateLabel.Text = "State"
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(66, 166)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(221, 20)
        Me.ZipTextBox.TabIndex = 9
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(21, 169)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(22, 13)
        Me.ZipLabel.TabIndex = 8
        Me.ZipLabel.Text = "Zip"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(66, 114)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(221, 20)
        Me.CityTextBox.TabIndex = 7
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(21, 121)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(24, 13)
        Me.CityLabel.TabIndex = 6
        Me.CityLabel.Text = "City"
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Location = New System.Drawing.Point(66, 88)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(221, 20)
        Me.StreetTextBox.TabIndex = 5
        '
        'StreetLabel
        '
        Me.StreetLabel.AutoSize = True
        Me.StreetLabel.Location = New System.Drawing.Point(21, 91)
        Me.StreetLabel.Name = "StreetLabel"
        Me.StreetLabel.Size = New System.Drawing.Size(35, 13)
        Me.StreetLabel.TabIndex = 4
        Me.StreetLabel.Text = "Street"
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
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(66, 36)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(221, 20)
        Me.FirstNameTextBox.TabIndex = 1
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
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(307, 19)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(136, 75)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
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
        'DataGroupBox
        '
        Me.DataGroupBox.Controls.Add(Me.DisplayListBox)
        Me.DataGroupBox.Location = New System.Drawing.Point(339, 12)
        Me.DataGroupBox.Name = "DataGroupBox"
        Me.DataGroupBox.Size = New System.Drawing.Size(449, 320)
        Me.DataGroupBox.TabIndex = 1
        Me.DataGroupBox.TabStop = False
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.Location = New System.Drawing.Point(6, 43)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(437, 264)
        Me.DisplayListBox.TabIndex = 0
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(66, 218)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(221, 20)
        Me.EmailTextBox.TabIndex = 15
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(21, 221)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(32, 13)
        Me.EmailLabel.TabIndex = 14
        Me.EmailLabel.Text = "Email"
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
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents StateLabel As Label
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents ZipLabel As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents StreetLabel As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents EmailLabel As Label
End Class
