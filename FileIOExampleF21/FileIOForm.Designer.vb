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
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
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
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterGroupBox = New System.Windows.Forms.GroupBox()
        Me.FirstNameRadioButton = New System.Windows.Forms.RadioButton()
        Me.LastNameRadioButton = New System.Windows.Forms.RadioButton()
        Me.CityRadioButton = New System.Windows.Forms.RadioButton()
        Me.ShowAllRadioButton = New System.Windows.Forms.RadioButton()
        Me.FilterTextBox = New System.Windows.Forms.TextBox()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.UserInfoGroupBox.SuspendLayout()
        Me.ActionsGroupBox.SuspendLayout()
        Me.DataGroupBox.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.FilterGroupBox.SuspendLayout()
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
        Me.UserInfoGroupBox.Location = New System.Drawing.Point(12, 55)
        Me.UserInfoGroupBox.Name = "UserInfoGroupBox"
        Me.UserInfoGroupBox.Size = New System.Drawing.Size(321, 320)
        Me.UserInfoGroupBox.TabIndex = 0
        Me.UserInfoGroupBox.TabStop = False
        Me.UserInfoGroupBox.Text = "User Information"
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
        Me.ActionsGroupBox.Location = New System.Drawing.Point(339, 382)
        Me.ActionsGroupBox.Name = "ActionsGroupBox"
        Me.ActionsGroupBox.Size = New System.Drawing.Size(449, 132)
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
        Me.DataGroupBox.Location = New System.Drawing.Point(339, 55)
        Me.DataGroupBox.Name = "DataGroupBox"
        Me.DataGroupBox.Size = New System.Drawing.Size(449, 320)
        Me.DataGroupBox.TabIndex = 1
        Me.DataGroupBox.TabStop = False
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.Location = New System.Drawing.Point(6, 36)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(437, 264)
        Me.DisplayListBox.TabIndex = 0
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.TopMenuStrip.TabIndex = 3
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'FilterGroupBox
        '
        Me.FilterGroupBox.Controls.Add(Me.SearchLabel)
        Me.FilterGroupBox.Controls.Add(Me.FilterTextBox)
        Me.FilterGroupBox.Controls.Add(Me.ShowAllRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.CityRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.LastNameRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.FirstNameRadioButton)
        Me.FilterGroupBox.Location = New System.Drawing.Point(13, 382)
        Me.FilterGroupBox.Name = "FilterGroupBox"
        Me.FilterGroupBox.Size = New System.Drawing.Size(320, 132)
        Me.FilterGroupBox.TabIndex = 4
        Me.FilterGroupBox.TabStop = False
        Me.FilterGroupBox.Text = "Filter"
        '
        'FirstNameRadioButton
        '
        Me.FirstNameRadioButton.AutoSize = True
        Me.FirstNameRadioButton.Location = New System.Drawing.Point(9, 42)
        Me.FirstNameRadioButton.Name = "FirstNameRadioButton"
        Me.FirstNameRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.FirstNameRadioButton.TabIndex = 0
        Me.FirstNameRadioButton.TabStop = True
        Me.FirstNameRadioButton.Text = "First Name"
        Me.FirstNameRadioButton.UseVisualStyleBackColor = True
        '
        'LastNameRadioButton
        '
        Me.LastNameRadioButton.AutoSize = True
        Me.LastNameRadioButton.Location = New System.Drawing.Point(9, 65)
        Me.LastNameRadioButton.Name = "LastNameRadioButton"
        Me.LastNameRadioButton.Size = New System.Drawing.Size(76, 17)
        Me.LastNameRadioButton.TabIndex = 1
        Me.LastNameRadioButton.TabStop = True
        Me.LastNameRadioButton.Text = "Last Name"
        Me.LastNameRadioButton.UseVisualStyleBackColor = True
        '
        'CityRadioButton
        '
        Me.CityRadioButton.AutoSize = True
        Me.CityRadioButton.Location = New System.Drawing.Point(9, 88)
        Me.CityRadioButton.Name = "CityRadioButton"
        Me.CityRadioButton.Size = New System.Drawing.Size(42, 17)
        Me.CityRadioButton.TabIndex = 2
        Me.CityRadioButton.TabStop = True
        Me.CityRadioButton.Text = "City"
        Me.CityRadioButton.UseVisualStyleBackColor = True
        '
        'ShowAllRadioButton
        '
        Me.ShowAllRadioButton.AutoSize = True
        Me.ShowAllRadioButton.Location = New System.Drawing.Point(9, 19)
        Me.ShowAllRadioButton.Name = "ShowAllRadioButton"
        Me.ShowAllRadioButton.Size = New System.Drawing.Size(66, 17)
        Me.ShowAllRadioButton.TabIndex = 3
        Me.ShowAllRadioButton.TabStop = True
        Me.ShowAllRadioButton.Text = "Show All"
        Me.ShowAllRadioButton.UseVisualStyleBackColor = True
        '
        'FilterTextBox
        '
        Me.FilterTextBox.Location = New System.Drawing.Point(93, 39)
        Me.FilterTextBox.Name = "FilterTextBox"
        Me.FilterTextBox.Size = New System.Drawing.Size(193, 20)
        Me.FilterTextBox.TabIndex = 4
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Location = New System.Drawing.Point(93, 20)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(41, 13)
        Me.SearchLabel.TabIndex = 5
        Me.SearchLabel.Text = "Search"
        '
        'FileIOForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 532)
        Me.Controls.Add(Me.FilterGroupBox)
        Me.Controls.Add(Me.ActionsGroupBox)
        Me.Controls.Add(Me.DataGroupBox)
        Me.Controls.Add(Me.UserInfoGroupBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "FileIOForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Form"
        Me.UserInfoGroupBox.ResumeLayout(False)
        Me.UserInfoGroupBox.PerformLayout()
        Me.ActionsGroupBox.ResumeLayout(False)
        Me.DataGroupBox.ResumeLayout(False)
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.FilterGroupBox.ResumeLayout(False)
        Me.FilterGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilterGroupBox As GroupBox
    Friend WithEvents SearchLabel As Label
    Friend WithEvents FilterTextBox As TextBox
    Friend WithEvents ShowAllRadioButton As RadioButton
    Friend WithEvents CityRadioButton As RadioButton
    Friend WithEvents LastNameRadioButton As RadioButton
    Friend WithEvents FirstNameRadioButton As RadioButton
End Class
