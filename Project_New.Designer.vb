<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class New_Project
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.TreeView_WorkingDirectory = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ApproveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApproveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmbWorkingDirectory = New System.Windows.Forms.ComboBox()
        Me.GroupBox_Directory = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnToggleTree1 = New System.Windows.Forms.Button()
        Me.Button_SaveTemplate = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbProjectStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox_Tips_Notes = New System.Windows.Forms.GroupBox()
        Me.TextBox_Notes = New System.Windows.Forms.TextBox()
        Me.GroupBox_ProjectInfo = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CheckedListSelected_TeamMembers = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListSelected_ProjectManagers = New System.Windows.Forms.CheckedListBox()
        Me.ComboBoxMemberGroup = New System.Windows.Forms.ComboBox()
        Me.ComboBoxProjectManagerGroup = New System.Windows.Forms.ComboBox()
        Me.CheckedListBox_ProjectManagers = New System.Windows.Forms.CheckedListBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CheckedListBox_TeamMembers = New System.Windows.Forms.CheckedListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txbProjectDescription = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmbClient = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txb_ProjectShortName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txb_ProjectName = New System.Windows.Forms.TextBox()
        Me.ComboBox_Label = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnDeleteLabel = New System.Windows.Forms.Button()
        Me.GroupBoxProjectNumber = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBoxProjectNumber = New System.Windows.Forms.TextBox()
        Me.cmbProjectNumber = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox_Years = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbClassification = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox_project_group = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxConfidentialDirectory = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnToggleTree2 = New System.Windows.Forms.Button()
        Me.CmbConfidentialDirectory = New System.Windows.Forms.ComboBox()
        Me.Button_SaveTemplate2 = New System.Windows.Forms.Button()
        Me.TreeView_ConfidentialDirectory = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox_Directory.SuspendLayout()
        Me.GroupBox_Tips_Notes.SuspendLayout()
        Me.GroupBox_ProjectInfo.SuspendLayout()
        Me.GroupBoxProjectNumber.SuspendLayout()
        Me.GroupBoxConfidentialDirectory.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 1198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "* - Cannot be Left Blank"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(962, 746)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(151, 24)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(807, 746)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(151, 24)
        Me.btnOK.TabIndex = 20
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'TreeView_WorkingDirectory
        '
        Me.TreeView_WorkingDirectory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView_WorkingDirectory.BackColor = System.Drawing.SystemColors.Window
        Me.TreeView_WorkingDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView_WorkingDirectory.CheckBoxes = True
        Me.TreeView_WorkingDirectory.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TreeView_WorkingDirectory.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView_WorkingDirectory.Indent = 20
        Me.TreeView_WorkingDirectory.ItemHeight = 20
        Me.TreeView_WorkingDirectory.LabelEdit = True
        Me.TreeView_WorkingDirectory.Location = New System.Drawing.Point(6, 48)
        Me.TreeView_WorkingDirectory.Name = "TreeView_WorkingDirectory"
        Me.TreeView_WorkingDirectory.Size = New System.Drawing.Size(263, 314)
        Me.TreeView_WorkingDirectory.TabIndex = 15
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddFolderToolStripMenuItem, Me.OpenFolderToolStripMenuItem, Me.RenameToolStripMenuItem, Me.DeleteFolderToolStripMenuItem, Me.ToolStripSeparator1, Me.ApproveToolStripMenuItem, Me.ApproveAllToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(137, 142)
        '
        'AddFolderToolStripMenuItem
        '
        Me.AddFolderToolStripMenuItem.Name = "AddFolderToolStripMenuItem"
        Me.AddFolderToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AddFolderToolStripMenuItem.Text = "Add"
        '
        'OpenFolderToolStripMenuItem
        '
        Me.OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem"
        Me.OpenFolderToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.OpenFolderToolStripMenuItem.Text = "Open"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'DeleteFolderToolStripMenuItem
        '
        Me.DeleteFolderToolStripMenuItem.Name = "DeleteFolderToolStripMenuItem"
        Me.DeleteFolderToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.DeleteFolderToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(133, 6)
        '
        'ApproveToolStripMenuItem
        '
        Me.ApproveToolStripMenuItem.Enabled = False
        Me.ApproveToolStripMenuItem.Name = "ApproveToolStripMenuItem"
        Me.ApproveToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ApproveToolStripMenuItem.Text = "Approve"
        '
        'ApproveAllToolStripMenuItem
        '
        Me.ApproveAllToolStripMenuItem.Enabled = False
        Me.ApproveAllToolStripMenuItem.Name = "ApproveAllToolStripMenuItem"
        Me.ApproveAllToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ApproveAllToolStripMenuItem.Text = "Approve All"
        '
        'CmbWorkingDirectory
        '
        Me.CmbWorkingDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbWorkingDirectory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWorkingDirectory.FormattingEnabled = True
        Me.CmbWorkingDirectory.Location = New System.Drawing.Point(6, 21)
        Me.CmbWorkingDirectory.Name = "CmbWorkingDirectory"
        Me.CmbWorkingDirectory.Size = New System.Drawing.Size(263, 21)
        Me.CmbWorkingDirectory.TabIndex = 14
        '
        'GroupBox_Directory
        '
        Me.GroupBox_Directory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Directory.Controls.Add(Me.Label16)
        Me.GroupBox_Directory.Controls.Add(Me.BtnToggleTree1)
        Me.GroupBox_Directory.Controls.Add(Me.CmbWorkingDirectory)
        Me.GroupBox_Directory.Controls.Add(Me.Button_SaveTemplate)
        Me.GroupBox_Directory.Controls.Add(Me.TreeView_WorkingDirectory)
        Me.GroupBox_Directory.Location = New System.Drawing.Point(607, 12)
        Me.GroupBox_Directory.Name = "GroupBox_Directory"
        Me.GroupBox_Directory.Size = New System.Drawing.Size(275, 434)
        Me.GroupBox_Directory.TabIndex = 90
        Me.GroupBox_Directory.TabStop = False
        Me.GroupBox_Directory.Text = "Working Directory"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 365)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(259, 26)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "- Select folder(s) to include contained files for QC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Right-click for more opti" &
    "ons"
        '
        'BtnToggleTree1
        '
        Me.BtnToggleTree1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnToggleTree1.Location = New System.Drawing.Point(6, 405)
        Me.BtnToggleTree1.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnToggleTree1.Name = "BtnToggleTree1"
        Me.BtnToggleTree1.Size = New System.Drawing.Size(100, 24)
        Me.BtnToggleTree1.TabIndex = 16
        Me.BtnToggleTree1.Text = "Expand All"
        Me.BtnToggleTree1.UseVisualStyleBackColor = True
        '
        'Button_SaveTemplate
        '
        Me.Button_SaveTemplate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_SaveTemplate.Location = New System.Drawing.Point(169, 405)
        Me.Button_SaveTemplate.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_SaveTemplate.Name = "Button_SaveTemplate"
        Me.Button_SaveTemplate.Size = New System.Drawing.Size(100, 24)
        Me.Button_SaveTemplate.TabIndex = 17
        Me.Button_SaveTemplate.Text = "Save Template As.."
        Me.Button_SaveTemplate.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 751)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "Project Status"
        '
        'cmbProjectStatus
        '
        Me.cmbProjectStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbProjectStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProjectStatus.FormattingEnabled = True
        Me.cmbProjectStatus.Location = New System.Drawing.Point(188, 748)
        Me.cmbProjectStatus.Name = "cmbProjectStatus"
        Me.cmbProjectStatus.Size = New System.Drawing.Size(408, 21)
        Me.cmbProjectStatus.TabIndex = 19
        '
        'GroupBox_Tips_Notes
        '
        Me.GroupBox_Tips_Notes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Tips_Notes.Controls.Add(Me.TextBox_Notes)
        Me.GroupBox_Tips_Notes.Location = New System.Drawing.Point(888, 12)
        Me.GroupBox_Tips_Notes.Name = "GroupBox_Tips_Notes"
        Me.GroupBox_Tips_Notes.Size = New System.Drawing.Size(234, 720)
        Me.GroupBox_Tips_Notes.TabIndex = 91
        Me.GroupBox_Tips_Notes.TabStop = False
        Me.GroupBox_Tips_Notes.Text = "Tips/Notes :"
        '
        'TextBox_Notes
        '
        Me.TextBox_Notes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Notes.Location = New System.Drawing.Point(3, 18)
        Me.TextBox_Notes.Multiline = True
        Me.TextBox_Notes.Name = "TextBox_Notes"
        Me.TextBox_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_Notes.Size = New System.Drawing.Size(228, 699)
        Me.TextBox_Notes.TabIndex = 18
        Me.TextBox_Notes.Text = "- Yellow highlighted Folders are present on your Disk but not approved. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Red h" &
    "ighlighted Folders are approved but doesn't exist on your Disk."
        '
        'GroupBox_ProjectInfo
        '
        Me.GroupBox_ProjectInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.Label20)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.Label19)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.CheckedListSelected_TeamMembers)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.CheckedListSelected_ProjectManagers)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.ComboBoxMemberGroup)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.ComboBoxProjectManagerGroup)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.CheckedListBox_ProjectManagers)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.Label17)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.CheckedListBox_TeamMembers)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.Label10)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.Label13)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.txbProjectDescription)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.Label12)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.Label11)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.CmbClient)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.Label4)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.txb_ProjectShortName)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.Label5)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.txb_ProjectName)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.ComboBox_Label)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.Label8)
        Me.GroupBox_ProjectInfo.Controls.Add(Me.BtnDeleteLabel)
        Me.GroupBox_ProjectInfo.Location = New System.Drawing.Point(14, 163)
        Me.GroupBox_ProjectInfo.Name = "GroupBox_ProjectInfo"
        Me.GroupBox_ProjectInfo.Size = New System.Drawing.Size(588, 569)
        Me.GroupBox_ProjectInfo.TabIndex = 96
        Me.GroupBox_ProjectInfo.TabStop = False
        Me.GroupBox_ProjectInfo.Text = "Project Info"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(386, 249)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 107
        Me.Label20.Text = "Selected :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(384, 389)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 13)
        Me.Label19.TabIndex = 106
        Me.Label19.Text = "Selected :"
        '
        'CheckedListSelected_TeamMembers
        '
        Me.CheckedListSelected_TeamMembers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedListSelected_TeamMembers.CheckOnClick = True
        Me.CheckedListSelected_TeamMembers.FormattingEnabled = True
        Me.CheckedListSelected_TeamMembers.HorizontalScrollbar = True
        Me.CheckedListSelected_TeamMembers.IntegralHeight = False
        Me.CheckedListSelected_TeamMembers.Location = New System.Drawing.Point(384, 409)
        Me.CheckedListSelected_TeamMembers.MaximumSize = New System.Drawing.Size(415, 500)
        Me.CheckedListSelected_TeamMembers.Name = "CheckedListSelected_TeamMembers"
        Me.CheckedListSelected_TeamMembers.Size = New System.Drawing.Size(197, 136)
        Me.CheckedListSelected_TeamMembers.TabIndex = 104
        '
        'CheckedListSelected_ProjectManagers
        '
        Me.CheckedListSelected_ProjectManagers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedListSelected_ProjectManagers.CheckOnClick = True
        Me.CheckedListSelected_ProjectManagers.FormattingEnabled = True
        Me.CheckedListSelected_ProjectManagers.HorizontalScrollbar = True
        Me.CheckedListSelected_ProjectManagers.IntegralHeight = False
        Me.CheckedListSelected_ProjectManagers.Location = New System.Drawing.Point(384, 272)
        Me.CheckedListSelected_ProjectManagers.MaximumSize = New System.Drawing.Size(415, 500)
        Me.CheckedListSelected_ProjectManagers.Name = "CheckedListSelected_ProjectManagers"
        Me.CheckedListSelected_ProjectManagers.Size = New System.Drawing.Size(197, 89)
        Me.CheckedListSelected_ProjectManagers.TabIndex = 102
        '
        'ComboBoxMemberGroup
        '
        Me.ComboBoxMemberGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxMemberGroup.FormattingEnabled = True
        Me.ComboBoxMemberGroup.Location = New System.Drawing.Point(174, 384)
        Me.ComboBoxMemberGroup.Name = "ComboBoxMemberGroup"
        Me.ComboBoxMemberGroup.Size = New System.Drawing.Size(201, 21)
        Me.ComboBoxMemberGroup.TabIndex = 101
        '
        'ComboBoxProjectManagerGroup
        '
        Me.ComboBoxProjectManagerGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxProjectManagerGroup.FormattingEnabled = True
        Me.ComboBoxProjectManagerGroup.Location = New System.Drawing.Point(174, 247)
        Me.ComboBoxProjectManagerGroup.Name = "ComboBoxProjectManagerGroup"
        Me.ComboBoxProjectManagerGroup.Size = New System.Drawing.Size(201, 21)
        Me.ComboBoxProjectManagerGroup.TabIndex = 100
        '
        'CheckedListBox_ProjectManagers
        '
        Me.CheckedListBox_ProjectManagers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedListBox_ProjectManagers.CheckOnClick = True
        Me.CheckedListBox_ProjectManagers.FormattingEnabled = True
        Me.CheckedListBox_ProjectManagers.HorizontalScrollbar = True
        Me.CheckedListBox_ProjectManagers.IntegralHeight = False
        Me.CheckedListBox_ProjectManagers.Location = New System.Drawing.Point(175, 272)
        Me.CheckedListBox_ProjectManagers.MaximumSize = New System.Drawing.Size(415, 500)
        Me.CheckedListBox_ProjectManagers.Name = "CheckedListBox_ProjectManagers"
        Me.CheckedListBox_ProjectManagers.Size = New System.Drawing.Size(200, 89)
        Me.CheckedListBox_ProjectManagers.TabIndex = 97
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(5, 250)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 13)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "Project Managers"
        '
        'CheckedListBox_TeamMembers
        '
        Me.CheckedListBox_TeamMembers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedListBox_TeamMembers.CheckOnClick = True
        Me.CheckedListBox_TeamMembers.FormattingEnabled = True
        Me.CheckedListBox_TeamMembers.HorizontalScrollbar = True
        Me.CheckedListBox_TeamMembers.IntegralHeight = False
        Me.CheckedListBox_TeamMembers.Location = New System.Drawing.Point(175, 409)
        Me.CheckedListBox_TeamMembers.MaximumSize = New System.Drawing.Size(415, 500)
        Me.CheckedListBox_TeamMembers.Name = "CheckedListBox_TeamMembers"
        Me.CheckedListBox_TeamMembers.Size = New System.Drawing.Size(200, 136)
        Me.CheckedListBox_TeamMembers.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 387)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "Team Members"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "(Optional)"
        '
        'txbProjectDescription
        '
        Me.txbProjectDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txbProjectDescription.Location = New System.Drawing.Point(174, 138)
        Me.txbProjectDescription.MaximumSize = New System.Drawing.Size(409, 116)
        Me.txbProjectDescription.Multiline = True
        Me.txbProjectDescription.Name = "txbProjectDescription"
        Me.txbProjectDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txbProjectDescription.Size = New System.Drawing.Size(409, 90)
        Me.txbProjectDescription.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 141)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Description"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Client"
        '
        'CmbClient
        '
        Me.CmbClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbClient.FormattingEnabled = True
        Me.CmbClient.Location = New System.Drawing.Point(173, 81)
        Me.CmbClient.Name = "CmbClient"
        Me.CmbClient.Size = New System.Drawing.Size(409, 21)
        Me.CmbClient.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Name"
        '
        'txb_ProjectShortName
        '
        Me.txb_ProjectShortName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txb_ProjectShortName.Location = New System.Drawing.Point(173, 49)
        Me.txb_ProjectShortName.Name = "txb_ProjectShortName"
        Me.txb_ProjectShortName.Size = New System.Drawing.Size(409, 22)
        Me.txb_ProjectShortName.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Short Name"
        '
        'txb_ProjectName
        '
        Me.txb_ProjectName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txb_ProjectName.Location = New System.Drawing.Point(173, 17)
        Me.txb_ProjectName.Name = "txb_ProjectName"
        Me.txb_ProjectName.Size = New System.Drawing.Size(409, 22)
        Me.txb_ProjectName.TabIndex = 6
        '
        'ComboBox_Label
        '
        Me.ComboBox_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Label.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Label.FormattingEnabled = True
        Me.ComboBox_Label.Location = New System.Drawing.Point(174, 110)
        Me.ComboBox_Label.Name = "ComboBox_Label"
        Me.ComboBox_Label.Size = New System.Drawing.Size(320, 21)
        Me.ComboBox_Label.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Mail Labels"
        '
        'BtnDeleteLabel
        '
        Me.BtnDeleteLabel.Location = New System.Drawing.Point(500, 108)
        Me.BtnDeleteLabel.Name = "BtnDeleteLabel"
        Me.BtnDeleteLabel.Size = New System.Drawing.Size(81, 24)
        Me.BtnDeleteLabel.TabIndex = 11
        Me.BtnDeleteLabel.Text = "Delete"
        Me.BtnDeleteLabel.UseVisualStyleBackColor = True
        '
        'GroupBoxProjectNumber
        '
        Me.GroupBoxProjectNumber.Controls.Add(Me.Label18)
        Me.GroupBoxProjectNumber.Controls.Add(Me.TextBoxProjectNumber)
        Me.GroupBoxProjectNumber.Controls.Add(Me.cmbProjectNumber)
        Me.GroupBoxProjectNumber.Controls.Add(Me.Label7)
        Me.GroupBoxProjectNumber.Controls.Add(Me.ComboBox_Years)
        Me.GroupBoxProjectNumber.Controls.Add(Me.Label2)
        Me.GroupBoxProjectNumber.Controls.Add(Me.cmbClassification)
        Me.GroupBoxProjectNumber.Controls.Add(Me.Label3)
        Me.GroupBoxProjectNumber.Location = New System.Drawing.Point(14, 43)
        Me.GroupBoxProjectNumber.Name = "GroupBoxProjectNumber"
        Me.GroupBoxProjectNumber.Size = New System.Drawing.Size(588, 114)
        Me.GroupBoxProjectNumber.TabIndex = 95
        Me.GroupBoxProjectNumber.TabStop = False
        Me.GroupBoxProjectNumber.Text = "Project Directory : YY-XXZZ"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(5, 81)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 13)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Project Number"
        '
        'TextBoxProjectNumber
        '
        Me.TextBoxProjectNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxProjectNumber.Location = New System.Drawing.Point(172, 78)
        Me.TextBoxProjectNumber.Name = "TextBoxProjectNumber"
        Me.TextBoxProjectNumber.Size = New System.Drawing.Size(409, 22)
        Me.TextBoxProjectNumber.TabIndex = 55
        Me.TextBoxProjectNumber.Text = "YY-XXZZ"
        '
        'cmbProjectNumber
        '
        Me.cmbProjectNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbProjectNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProjectNumber.FormattingEnabled = True
        Me.cmbProjectNumber.Location = New System.Drawing.Point(412, 51)
        Me.cmbProjectNumber.Name = "cmbProjectNumber"
        Me.cmbProjectNumber.Size = New System.Drawing.Size(170, 21)
        Me.cmbProjectNumber.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(173, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Classification (XX)"
        '
        'ComboBox_Years
        '
        Me.ComboBox_Years.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Years.FormattingEnabled = True
        Me.ComboBox_Years.Location = New System.Drawing.Point(6, 51)
        Me.ComboBox_Years.Name = "ComboBox_Years"
        Me.ComboBox_Years.Size = New System.Drawing.Size(161, 21)
        Me.ComboBox_Years.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Year (YY)"
        '
        'cmbClassification
        '
        Me.cmbClassification.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClassification.FormattingEnabled = True
        Me.cmbClassification.Location = New System.Drawing.Point(172, 51)
        Me.cmbClassification.Name = "cmbClassification"
        Me.cmbClassification.Size = New System.Drawing.Size(234, 21)
        Me.cmbClassification.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(412, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Number (ZZ)"
        '
        'ComboBox_project_group
        '
        Me.ComboBox_project_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_project_group.FormattingEnabled = True
        Me.ComboBox_project_group.Location = New System.Drawing.Point(187, 13)
        Me.ComboBox_project_group.Name = "ComboBox_project_group"
        Me.ComboBox_project_group.Size = New System.Drawing.Size(409, 21)
        Me.ComboBox_project_group.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Project Group"
        '
        'GroupBoxConfidentialDirectory
        '
        Me.GroupBoxConfidentialDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxConfidentialDirectory.Controls.Add(Me.Label15)
        Me.GroupBoxConfidentialDirectory.Controls.Add(Me.BtnToggleTree2)
        Me.GroupBoxConfidentialDirectory.Controls.Add(Me.CmbConfidentialDirectory)
        Me.GroupBoxConfidentialDirectory.Controls.Add(Me.Button_SaveTemplate2)
        Me.GroupBoxConfidentialDirectory.Controls.Add(Me.TreeView_ConfidentialDirectory)
        Me.GroupBoxConfidentialDirectory.Location = New System.Drawing.Point(607, 451)
        Me.GroupBoxConfidentialDirectory.Name = "GroupBoxConfidentialDirectory"
        Me.GroupBoxConfidentialDirectory.Size = New System.Drawing.Size(275, 281)
        Me.GroupBoxConfidentialDirectory.TabIndex = 97
        Me.GroupBoxConfidentialDirectory.TabStop = False
        Me.GroupBoxConfidentialDirectory.Text = "Confidential Directory"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 231)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(158, 13)
        Me.Label15.TabIndex = 92
        Me.Label15.Text = "- Right-click for more options"
        '
        'BtnToggleTree2
        '
        Me.BtnToggleTree2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnToggleTree2.Location = New System.Drawing.Point(5, 252)
        Me.BtnToggleTree2.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnToggleTree2.Name = "BtnToggleTree2"
        Me.BtnToggleTree2.Size = New System.Drawing.Size(100, 24)
        Me.BtnToggleTree2.TabIndex = 16
        Me.BtnToggleTree2.Text = "Expand All"
        Me.BtnToggleTree2.UseVisualStyleBackColor = True
        '
        'CmbConfidentialDirectory
        '
        Me.CmbConfidentialDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbConfidentialDirectory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbConfidentialDirectory.FormattingEnabled = True
        Me.CmbConfidentialDirectory.Location = New System.Drawing.Point(6, 21)
        Me.CmbConfidentialDirectory.Name = "CmbConfidentialDirectory"
        Me.CmbConfidentialDirectory.Size = New System.Drawing.Size(263, 21)
        Me.CmbConfidentialDirectory.TabIndex = 14
        '
        'Button_SaveTemplate2
        '
        Me.Button_SaveTemplate2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_SaveTemplate2.Location = New System.Drawing.Point(169, 252)
        Me.Button_SaveTemplate2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_SaveTemplate2.Name = "Button_SaveTemplate2"
        Me.Button_SaveTemplate2.Size = New System.Drawing.Size(100, 24)
        Me.Button_SaveTemplate2.TabIndex = 17
        Me.Button_SaveTemplate2.Text = "Save Template As.."
        Me.Button_SaveTemplate2.UseVisualStyleBackColor = True
        '
        'TreeView_ConfidentialDirectory
        '
        Me.TreeView_ConfidentialDirectory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView_ConfidentialDirectory.BackColor = System.Drawing.SystemColors.Window
        Me.TreeView_ConfidentialDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView_ConfidentialDirectory.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TreeView_ConfidentialDirectory.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView_ConfidentialDirectory.Indent = 20
        Me.TreeView_ConfidentialDirectory.ItemHeight = 20
        Me.TreeView_ConfidentialDirectory.LabelEdit = True
        Me.TreeView_ConfidentialDirectory.Location = New System.Drawing.Point(6, 48)
        Me.TreeView_ConfidentialDirectory.Name = "TreeView_ConfidentialDirectory"
        Me.TreeView_ConfidentialDirectory.Size = New System.Drawing.Size(263, 180)
        Me.TreeView_ConfidentialDirectory.TabIndex = 15
        '
        'New_Project
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1134, 781)
        Me.Controls.Add(Me.GroupBoxConfidentialDirectory)
        Me.Controls.Add(Me.GroupBox_ProjectInfo)
        Me.Controls.Add(Me.GroupBoxProjectNumber)
        Me.Controls.Add(Me.ComboBox_project_group)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox_Directory)
        Me.Controls.Add(Me.GroupBox_Tips_Notes)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cmbProjectStatus)
        Me.Controls.Add(Me.btnOK)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(2000, 1200)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1150, 820)
        Me.Name = "New_Project"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Project"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox_Directory.ResumeLayout(False)
        Me.GroupBox_Directory.PerformLayout()
        Me.GroupBox_Tips_Notes.ResumeLayout(False)
        Me.GroupBox_Tips_Notes.PerformLayout()
        Me.GroupBox_ProjectInfo.ResumeLayout(False)
        Me.GroupBox_ProjectInfo.PerformLayout()
        Me.GroupBoxProjectNumber.ResumeLayout(False)
        Me.GroupBoxProjectNumber.PerformLayout()
        Me.GroupBoxConfidentialDirectory.ResumeLayout(False)
        Me.GroupBoxConfidentialDirectory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents btnCancel As Windows.Forms.Button
    Friend WithEvents btnOK As Windows.Forms.Button
    Friend WithEvents TreeView_WorkingDirectory As Windows.Forms.TreeView
    Friend WithEvents CmbWorkingDirectory As Windows.Forms.ComboBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents cmbProjectStatus As Windows.Forms.ComboBox
    Friend WithEvents Button_SaveTemplate As Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As Windows.Forms.ContextMenuStrip
    Friend WithEvents AddFolderToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox_Directory As Windows.Forms.GroupBox
    Friend WithEvents DeleteFolderToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnToggleTree1 As Windows.Forms.Button
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents GroupBox_Tips_Notes As Windows.Forms.GroupBox
    Friend WithEvents TextBox_Notes As Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ApproveToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox_ProjectInfo As Windows.Forms.GroupBox
    Friend WithEvents CheckedListBox_ProjectManagers As Windows.Forms.CheckedListBox
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents CheckedListBox_TeamMembers As Windows.Forms.CheckedListBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents txbProjectDescription As Windows.Forms.TextBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents CmbClient As Windows.Forms.ComboBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txb_ProjectShortName As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txb_ProjectName As Windows.Forms.TextBox
    Friend WithEvents ComboBox_Label As Windows.Forms.ComboBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents BtnDeleteLabel As Windows.Forms.Button
    Friend WithEvents GroupBoxProjectNumber As Windows.Forms.GroupBox
    Friend WithEvents cmbProjectNumber As Windows.Forms.ComboBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents ComboBox_Years As Windows.Forms.ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents cmbClassification As Windows.Forms.ComboBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents ComboBox_project_group As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBoxConfidentialDirectory As Windows.Forms.GroupBox
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents BtnToggleTree2 As Windows.Forms.Button
    Friend WithEvents CmbConfidentialDirectory As Windows.Forms.ComboBox
    Friend WithEvents Button_SaveTemplate2 As Windows.Forms.Button
    Friend WithEvents TreeView_ConfidentialDirectory As Windows.Forms.TreeView
    Friend WithEvents OpenFolderToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents TextBoxProjectNumber As Windows.Forms.TextBox
    Friend WithEvents ComboBoxMemberGroup As Windows.Forms.ComboBox
    Friend WithEvents ComboBoxProjectManagerGroup As Windows.Forms.ComboBox
    Friend WithEvents CheckedListSelected_ProjectManagers As Windows.Forms.CheckedListBox
    Friend WithEvents CheckedListSelected_TeamMembers As Windows.Forms.CheckedListBox
    Friend WithEvents Label20 As Windows.Forms.Label
    Friend WithEvents Label19 As Windows.Forms.Label
    Friend WithEvents ApproveAllToolStripMenuItem As Windows.Forms.ToolStripMenuItem
End Class
