<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.directorMenu = New System.Windows.Forms.Panel()
        Me.backToHome_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.collection_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.review_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.manageUsers_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.manageUsers_Panel = New System.Windows.Forms.Panel()
        Me.addUser_Btn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.updateUser = New System.Windows.Forms.Button()
        Me.enableAccess = New System.Windows.Forms.ComboBox()
        Me.newPosition = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.usersDataGrid = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsEnabled = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New MidtermProj.Database1DataSet()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.retypeNewPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.newPassword = New System.Windows.Forms.TextBox()
        Me.newUsername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.collectionPanel = New System.Windows.Forms.Panel()
        Me.approvedThesis = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.thesisNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yearLvl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateReceived = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThesisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.forReviewPanel = New System.Windows.Forms.Panel()
        Me.openFile = New System.Windows.Forms.Button()
        Me.reject = New System.Windows.Forms.Button()
        Me.approve = New System.Windows.Forms.Button()
        Me.selectThesis = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.viewDescription = New System.Windows.Forms.TextBox()
        Me.viewTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.viewAuthor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.reviewList = New System.Windows.Forms.ComboBox()
        Me.forRevLabel = New System.Windows.Forms.Label()
        Me.FeedbackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.TableTableAdapter = New MidtermProj.Database1DataSetTableAdapters.TableTableAdapter()
        Me.ThesisTableAdapter1 = New MidtermProj.Database1DataSetTableAdapters.ThesisTableAdapter()
        Me.FeedbackTableAdapter = New MidtermProj.Database1DataSetTableAdapters.FeedbackTableAdapter()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.manageUsers_elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.review_Elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.collection_Elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.backToHome_Elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.form_Elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.directorMenu.SuspendLayout()
        Me.manageUsers_Panel.SuspendLayout()
        CType(Me.usersDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.collectionPanel.SuspendLayout()
        CType(Me.approvedThesis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThesisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.forReviewPanel.SuspendLayout()
        CType(Me.FeedbackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'directorMenu
        '
        Me.directorMenu.BackColor = System.Drawing.SystemColors.Control
        Me.directorMenu.BackgroundImage = CType(resources.GetObject("directorMenu.BackgroundImage"), System.Drawing.Image)
        Me.directorMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.directorMenu.Controls.Add(Me.backToHome_btn)
        Me.directorMenu.Controls.Add(Me.collection_btn)
        Me.directorMenu.Controls.Add(Me.review_btn)
        Me.directorMenu.Controls.Add(Me.manageUsers_btn)
        Me.directorMenu.Controls.Add(Me.Panel2)
        Me.directorMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.directorMenu.Location = New System.Drawing.Point(0, 0)
        Me.directorMenu.Name = "directorMenu"
        Me.directorMenu.Size = New System.Drawing.Size(168, 369)
        Me.directorMenu.TabIndex = 0
        '
        'backToHome_btn
        '
        Me.backToHome_btn.ActiveBorderThickness = 1
        Me.backToHome_btn.ActiveCornerRadius = 20
        Me.backToHome_btn.ActiveFillColor = System.Drawing.Color.Indigo
        Me.backToHome_btn.ActiveForecolor = System.Drawing.Color.White
        Me.backToHome_btn.ActiveLineColor = System.Drawing.Color.Indigo
        Me.backToHome_btn.BackColor = System.Drawing.Color.Transparent
        Me.backToHome_btn.BackgroundImage = CType(resources.GetObject("backToHome_btn.BackgroundImage"), System.Drawing.Image)
        Me.backToHome_btn.ButtonText = "Back to Home"
        Me.backToHome_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backToHome_btn.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backToHome_btn.ForeColor = System.Drawing.Color.Indigo
        Me.backToHome_btn.IdleBorderThickness = 1
        Me.backToHome_btn.IdleCornerRadius = 20
        Me.backToHome_btn.IdleFillColor = System.Drawing.Color.White
        Me.backToHome_btn.IdleForecolor = System.Drawing.Color.Indigo
        Me.backToHome_btn.IdleLineColor = System.Drawing.Color.Indigo
        Me.backToHome_btn.Location = New System.Drawing.Point(10, 216)
        Me.backToHome_btn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.backToHome_btn.Name = "backToHome_btn"
        Me.backToHome_btn.Size = New System.Drawing.Size(133, 43)
        Me.backToHome_btn.TabIndex = 9
        Me.backToHome_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'collection_btn
        '
        Me.collection_btn.ActiveBorderThickness = 1
        Me.collection_btn.ActiveCornerRadius = 20
        Me.collection_btn.ActiveFillColor = System.Drawing.Color.Indigo
        Me.collection_btn.ActiveForecolor = System.Drawing.Color.White
        Me.collection_btn.ActiveLineColor = System.Drawing.Color.Indigo
        Me.collection_btn.BackColor = System.Drawing.Color.Transparent
        Me.collection_btn.BackgroundImage = CType(resources.GetObject("collection_btn.BackgroundImage"), System.Drawing.Image)
        Me.collection_btn.ButtonText = "Collection"
        Me.collection_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.collection_btn.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.collection_btn.ForeColor = System.Drawing.Color.Indigo
        Me.collection_btn.IdleBorderThickness = 1
        Me.collection_btn.IdleCornerRadius = 20
        Me.collection_btn.IdleFillColor = System.Drawing.Color.White
        Me.collection_btn.IdleForecolor = System.Drawing.Color.Indigo
        Me.collection_btn.IdleLineColor = System.Drawing.Color.Indigo
        Me.collection_btn.Location = New System.Drawing.Point(10, 178)
        Me.collection_btn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.collection_btn.Name = "collection_btn"
        Me.collection_btn.Size = New System.Drawing.Size(133, 43)
        Me.collection_btn.TabIndex = 9
        Me.collection_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'review_btn
        '
        Me.review_btn.ActiveBorderThickness = 1
        Me.review_btn.ActiveCornerRadius = 20
        Me.review_btn.ActiveFillColor = System.Drawing.Color.Indigo
        Me.review_btn.ActiveForecolor = System.Drawing.Color.White
        Me.review_btn.ActiveLineColor = System.Drawing.Color.Indigo
        Me.review_btn.BackColor = System.Drawing.Color.Transparent
        Me.review_btn.BackgroundImage = CType(resources.GetObject("review_btn.BackgroundImage"), System.Drawing.Image)
        Me.review_btn.ButtonText = "Review"
        Me.review_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.review_btn.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.review_btn.ForeColor = System.Drawing.Color.Indigo
        Me.review_btn.IdleBorderThickness = 1
        Me.review_btn.IdleCornerRadius = 20
        Me.review_btn.IdleFillColor = System.Drawing.Color.White
        Me.review_btn.IdleForecolor = System.Drawing.Color.Indigo
        Me.review_btn.IdleLineColor = System.Drawing.Color.Indigo
        Me.review_btn.Location = New System.Drawing.Point(10, 137)
        Me.review_btn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.review_btn.Name = "review_btn"
        Me.review_btn.Size = New System.Drawing.Size(133, 45)
        Me.review_btn.TabIndex = 9
        Me.review_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'manageUsers_btn
        '
        Me.manageUsers_btn.ActiveBorderThickness = 1
        Me.manageUsers_btn.ActiveCornerRadius = 20
        Me.manageUsers_btn.ActiveFillColor = System.Drawing.Color.Indigo
        Me.manageUsers_btn.ActiveForecolor = System.Drawing.Color.White
        Me.manageUsers_btn.ActiveLineColor = System.Drawing.Color.Indigo
        Me.manageUsers_btn.BackColor = System.Drawing.Color.Transparent
        Me.manageUsers_btn.BackgroundImage = CType(resources.GetObject("manageUsers_btn.BackgroundImage"), System.Drawing.Image)
        Me.manageUsers_btn.ButtonText = "Manage Users"
        Me.manageUsers_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.manageUsers_btn.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageUsers_btn.ForeColor = System.Drawing.Color.Indigo
        Me.manageUsers_btn.IdleBorderThickness = 1
        Me.manageUsers_btn.IdleCornerRadius = 20
        Me.manageUsers_btn.IdleFillColor = System.Drawing.Color.White
        Me.manageUsers_btn.IdleForecolor = System.Drawing.Color.Indigo
        Me.manageUsers_btn.IdleLineColor = System.Drawing.Color.Indigo
        Me.manageUsers_btn.Location = New System.Drawing.Point(10, 99)
        Me.manageUsers_btn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.manageUsers_btn.Name = "manageUsers_btn"
        Me.manageUsers_btn.Size = New System.Drawing.Size(133, 43)
        Me.manageUsers_btn.TabIndex = 9
        Me.manageUsers_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel2.Location = New System.Drawing.Point(174, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(630, 369)
        Me.Panel2.TabIndex = 1
        '
        'manageUsers_Panel
        '
        Me.manageUsers_Panel.Controls.Add(Me.addUser_Btn)
        Me.manageUsers_Panel.Controls.Add(Me.Label11)
        Me.manageUsers_Panel.Controls.Add(Me.updateUser)
        Me.manageUsers_Panel.Controls.Add(Me.enableAccess)
        Me.manageUsers_Panel.Controls.Add(Me.newPosition)
        Me.manageUsers_Panel.Controls.Add(Me.Label12)
        Me.manageUsers_Panel.Controls.Add(Me.usersDataGrid)
        Me.manageUsers_Panel.Controls.Add(Me.Label10)
        Me.manageUsers_Panel.Controls.Add(Me.retypeNewPassword)
        Me.manageUsers_Panel.Controls.Add(Me.Label7)
        Me.manageUsers_Panel.Controls.Add(Me.Label9)
        Me.manageUsers_Panel.Controls.Add(Me.newPassword)
        Me.manageUsers_Panel.Controls.Add(Me.newUsername)
        Me.manageUsers_Panel.Controls.Add(Me.Label8)
        Me.manageUsers_Panel.Location = New System.Drawing.Point(171, 22)
        Me.manageUsers_Panel.Name = "manageUsers_Panel"
        Me.manageUsers_Panel.Size = New System.Drawing.Size(621, 320)
        Me.manageUsers_Panel.TabIndex = 8
        '
        'addUser_Btn
        '
        Me.addUser_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addUser_Btn.Location = New System.Drawing.Point(107, 270)
        Me.addUser_Btn.Name = "addUser_Btn"
        Me.addUser_Btn.Size = New System.Drawing.Size(85, 27)
        Me.addUser_Btn.TabIndex = 11
        Me.addUser_Btn.Text = "Add User"
        Me.addUser_Btn.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(27, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(212, 37)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Manage Users"
        '
        'updateUser
        '
        Me.updateUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateUser.Location = New System.Drawing.Point(375, 270)
        Me.updateUser.Name = "updateUser"
        Me.updateUser.Size = New System.Drawing.Size(149, 27)
        Me.updateUser.TabIndex = 11
        Me.updateUser.Text = "Change Access"
        Me.updateUser.UseVisualStyleBackColor = True
        '
        'enableAccess
        '
        Me.enableAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enableAccess.FormattingEnabled = True
        Me.enableAccess.Items.AddRange(New Object() {"Disabled", "Enabled"})
        Me.enableAccess.Location = New System.Drawing.Point(139, 220)
        Me.enableAccess.Name = "enableAccess"
        Me.enableAccess.Size = New System.Drawing.Size(141, 24)
        Me.enableAccess.TabIndex = 2
        '
        'newPosition
        '
        Me.newPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPosition.FormattingEnabled = True
        Me.newPosition.Items.AddRange(New Object() {"Admin", "Staff"})
        Me.newPosition.Location = New System.Drawing.Point(139, 183)
        Me.newPosition.Name = "newPosition"
        Me.newPosition.Size = New System.Drawing.Size(141, 24)
        Me.newPosition.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(28, 223)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 15)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Enable Access"
        '
        'usersDataGrid
        '
        Me.usersDataGrid.AllowUserToAddRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.usersDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.usersDataGrid.AutoGenerateColumns = False
        Me.usersDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.usersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usersDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkViolet
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.usersDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.usersDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.IsEnabled})
        Me.usersDataGrid.DataSource = Me.TableBindingSource
        Me.usersDataGrid.DoubleBuffered = True
        Me.usersDataGrid.EnableHeadersVisualStyles = False
        Me.usersDataGrid.HeaderBgColor = System.Drawing.Color.DarkViolet
        Me.usersDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.usersDataGrid.Location = New System.Drawing.Point(302, 70)
        Me.usersDataGrid.Name = "usersDataGrid"
        Me.usersDataGrid.ReadOnly = True
        Me.usersDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.usersDataGrid.Size = New System.Drawing.Size(292, 181)
        Me.usersDataGrid.TabIndex = 12
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PositionDataGridViewTextBoxColumn.Width = 75
        '
        'IsEnabled
        '
        Me.IsEnabled.DataPropertyName = "IsEnabled"
        Me.IsEnabled.HeaderText = "Access"
        Me.IsEnabled.Name = "IsEnabled"
        Me.IsEnabled.ReadOnly = True
        Me.IsEnabled.Width = 75
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.EnforceConstraints = False
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Position"
        '
        'retypeNewPassword
        '
        Me.retypeNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retypeNewPassword.Location = New System.Drawing.Point(139, 147)
        Me.retypeNewPassword.Name = "retypeNewPassword"
        Me.retypeNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.retypeNewPassword.Size = New System.Drawing.Size(141, 22)
        Me.retypeNewPassword.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Username"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Retype Password"
        '
        'newPassword
        '
        Me.newPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPassword.Location = New System.Drawing.Point(139, 111)
        Me.newPassword.Name = "newPassword"
        Me.newPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newPassword.Size = New System.Drawing.Size(141, 22)
        Me.newPassword.TabIndex = 0
        '
        'newUsername
        '
        Me.newUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.newUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newUsername.Location = New System.Drawing.Point(139, 76)
        Me.newUsername.Name = "newUsername"
        Me.newUsername.Size = New System.Drawing.Size(141, 22)
        Me.newUsername.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Password"
        '
        'collectionPanel
        '
        Me.collectionPanel.Controls.Add(Me.approvedThesis)
        Me.collectionPanel.Controls.Add(Me.Label6)
        Me.collectionPanel.Location = New System.Drawing.Point(174, 12)
        Me.collectionPanel.Name = "collectionPanel"
        Me.collectionPanel.Size = New System.Drawing.Size(685, 358)
        Me.collectionPanel.TabIndex = 7
        '
        'approvedThesis
        '
        Me.approvedThesis.AllowUserToAddRows = False
        Me.approvedThesis.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.approvedThesis.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.approvedThesis.AutoGenerateColumns = False
        Me.approvedThesis.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.approvedThesis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.approvedThesis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.approvedThesis.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.approvedThesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.approvedThesis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.thesisNumber, Me.TitleDataGridViewTextBoxColumn, Me.description, Me.author, Me.yearLvl, Me.dateReceived})
        Me.approvedThesis.DataSource = Me.ThesisBindingSource
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.approvedThesis.DefaultCellStyle = DataGridViewCellStyle11
        Me.approvedThesis.DoubleBuffered = True
        Me.approvedThesis.EnableHeadersVisualStyles = False
        Me.approvedThesis.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.approvedThesis.HeaderBgColor = System.Drawing.Color.Indigo
        Me.approvedThesis.HeaderForeColor = System.Drawing.Color.White
        Me.approvedThesis.Location = New System.Drawing.Point(28, 55)
        Me.approvedThesis.Name = "approvedThesis"
        Me.approvedThesis.ReadOnly = True
        Me.approvedThesis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.approvedThesis.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.approvedThesis.RowHeadersVisible = False
        Me.approvedThesis.Size = New System.Drawing.Size(587, 265)
        Me.approvedThesis.TabIndex = 2
        '
        'thesisNumber
        '
        Me.thesisNumber.DataPropertyName = "thesisNumber"
        Me.thesisNumber.HeaderText = "ID"
        Me.thesisNumber.Name = "thesisNumber"
        Me.thesisNumber.ReadOnly = True
        Me.thesisNumber.Width = 75
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'description
        '
        Me.description.DataPropertyName = "description"
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        Me.description.Width = 135
        '
        'author
        '
        Me.author.DataPropertyName = "author"
        Me.author.HeaderText = "Author"
        Me.author.Name = "author"
        Me.author.ReadOnly = True
        '
        'yearLvl
        '
        Me.yearLvl.DataPropertyName = "yearLvl"
        Me.yearLvl.HeaderText = "Year"
        Me.yearLvl.Name = "yearLvl"
        Me.yearLvl.ReadOnly = True
        Me.yearLvl.Width = 75
        '
        'dateReceived
        '
        Me.dateReceived.DataPropertyName = "dateReceived"
        Me.dateReceived.HeaderText = "Received"
        Me.dateReceived.Name = "dateReceived"
        Me.dateReceived.ReadOnly = True
        '
        'ThesisBindingSource
        '
        Me.ThesisBindingSource.DataMember = "Thesis"
        Me.ThesisBindingSource.DataSource = Me.Database1DataSet
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(21, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 37)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Approved Thesis"
        '
        'forReviewPanel
        '
        Me.forReviewPanel.Controls.Add(Me.openFile)
        Me.forReviewPanel.Controls.Add(Me.reject)
        Me.forReviewPanel.Controls.Add(Me.approve)
        Me.forReviewPanel.Controls.Add(Me.selectThesis)
        Me.forReviewPanel.Controls.Add(Me.TextBox1)
        Me.forReviewPanel.Controls.Add(Me.viewDescription)
        Me.forReviewPanel.Controls.Add(Me.viewTitle)
        Me.forReviewPanel.Controls.Add(Me.Label5)
        Me.forReviewPanel.Controls.Add(Me.viewAuthor)
        Me.forReviewPanel.Controls.Add(Me.Label4)
        Me.forReviewPanel.Controls.Add(Me.Label3)
        Me.forReviewPanel.Controls.Add(Me.Label2)
        Me.forReviewPanel.Controls.Add(Me.Label1)
        Me.forReviewPanel.Controls.Add(Me.reviewList)
        Me.forReviewPanel.Controls.Add(Me.forRevLabel)
        Me.forReviewPanel.Location = New System.Drawing.Point(174, 3)
        Me.forReviewPanel.Name = "forReviewPanel"
        Me.forReviewPanel.Size = New System.Drawing.Size(630, 375)
        Me.forReviewPanel.TabIndex = 0
        '
        'openFile
        '
        Me.openFile.Location = New System.Drawing.Point(510, 108)
        Me.openFile.Name = "openFile"
        Me.openFile.Size = New System.Drawing.Size(75, 39)
        Me.openFile.TabIndex = 7
        Me.openFile.Text = "Save and View File"
        Me.openFile.UseVisualStyleBackColor = True
        '
        'reject
        '
        Me.reject.Location = New System.Drawing.Point(510, 297)
        Me.reject.Name = "reject"
        Me.reject.Size = New System.Drawing.Size(75, 23)
        Me.reject.TabIndex = 6
        Me.reject.Text = "Reject"
        Me.reject.UseVisualStyleBackColor = True
        '
        'approve
        '
        Me.approve.Location = New System.Drawing.Point(510, 268)
        Me.approve.Name = "approve"
        Me.approve.Size = New System.Drawing.Size(75, 23)
        Me.approve.TabIndex = 6
        Me.approve.Text = "Approve"
        Me.approve.UseVisualStyleBackColor = True
        '
        'selectThesis
        '
        Me.selectThesis.Location = New System.Drawing.Point(510, 75)
        Me.selectThesis.Name = "selectThesis"
        Me.selectThesis.Size = New System.Drawing.Size(75, 23)
        Me.selectThesis.TabIndex = 5
        Me.selectThesis.Text = "Select"
        Me.selectThesis.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(180, 257)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(310, 72)
        Me.TextBox1.TabIndex = 4
        '
        'viewDescription
        '
        Me.viewDescription.Location = New System.Drawing.Point(180, 159)
        Me.viewDescription.Multiline = True
        Me.viewDescription.Name = "viewDescription"
        Me.viewDescription.ReadOnly = True
        Me.viewDescription.Size = New System.Drawing.Size(310, 91)
        Me.viewDescription.TabIndex = 4
        '
        'viewTitle
        '
        Me.viewTitle.Location = New System.Drawing.Point(180, 132)
        Me.viewTitle.Name = "viewTitle"
        Me.viewTitle.ReadOnly = True
        Me.viewTitle.Size = New System.Drawing.Size(310, 20)
        Me.viewTitle.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(101, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Remarks"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'viewAuthor
        '
        Me.viewAuthor.Location = New System.Drawing.Point(180, 103)
        Me.viewAuthor.Name = "viewAuthor"
        Me.viewAuthor.ReadOnly = True
        Me.viewAuthor.Size = New System.Drawing.Size(310, 20)
        Me.viewAuthor.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Description"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Author"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Title"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select thesis to review: "
        '
        'reviewList
        '
        Me.reviewList.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ThesisBindingSource, "title", True))
        Me.reviewList.DataSource = Me.ThesisBindingSource
        Me.reviewList.DisplayMember = "title"
        Me.reviewList.FormattingEnabled = True
        Me.reviewList.Location = New System.Drawing.Point(180, 74)
        Me.reviewList.Name = "reviewList"
        Me.reviewList.Size = New System.Drawing.Size(310, 21)
        Me.reviewList.TabIndex = 2
        Me.reviewList.ValueMember = "title"
        '
        'forRevLabel
        '
        Me.forRevLabel.AutoSize = True
        Me.forRevLabel.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forRevLabel.Location = New System.Drawing.Point(25, 23)
        Me.forRevLabel.Name = "forRevLabel"
        Me.forRevLabel.Size = New System.Drawing.Size(275, 35)
        Me.forRevLabel.TabIndex = 0
        Me.forRevLabel.Text = "Thesis for Review"
        '
        'FeedbackBindingSource
        '
        Me.FeedbackBindingSource.DataMember = "Feedback"
        Me.FeedbackBindingSource.DataSource = Me.Database1DataSet
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(150, 150)
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'ThesisTableAdapter1
        '
        Me.ThesisTableAdapter1.ClearBeforeFill = True
        '
        'FeedbackTableAdapter
        '
        Me.FeedbackTableAdapter.ClearBeforeFill = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Select folder to save copy of thesis"
        '
        'manageUsers_elipse
        '
        Me.manageUsers_elipse.ElipseRadius = 20
        Me.manageUsers_elipse.TargetControl = Me.manageUsers_btn
        '
        'review_Elipse
        '
        Me.review_Elipse.ElipseRadius = 20
        Me.review_Elipse.TargetControl = Me.review_btn
        '
        'collection_Elipse
        '
        Me.collection_Elipse.ElipseRadius = 20
        Me.collection_Elipse.TargetControl = Me.collection_btn
        '
        'backToHome_Elipse
        '
        Me.backToHome_Elipse.ElipseRadius = 20
        Me.backToHome_Elipse.TargetControl = Me.backToHome_btn
        '
        'form_Elipse
        '
        Me.form_Elipse.ElipseRadius = 10
        Me.form_Elipse.TargetControl = Me
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 369)
        Me.Controls.Add(Me.directorMenu)
        Me.Controls.Add(Me.manageUsers_Panel)
        Me.Controls.Add(Me.forReviewPanel)
        Me.Controls.Add(Me.collectionPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kinaadman University Research Office (Director)"
        Me.directorMenu.ResumeLayout(False)
        Me.manageUsers_Panel.ResumeLayout(False)
        Me.manageUsers_Panel.PerformLayout()
        CType(Me.usersDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.collectionPanel.ResumeLayout(False)
        Me.collectionPanel.PerformLayout()
        CType(Me.approvedThesis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThesisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.forReviewPanel.ResumeLayout(False)
        Me.forReviewPanel.PerformLayout()
        CType(Me.FeedbackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents directorMenu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents forReviewPanel As Panel
    Friend WithEvents forRevLabel As Label
    Friend WithEvents viewAuthor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents selectThesis As Button
    Friend WithEvents viewTitle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents viewDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents reject As Button
    Friend WithEvents approve As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents collectionPanel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents manageUsers_Panel As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents retypeNewPassword As TextBox
    Friend WithEvents newPassword As TextBox
    Friend WithEvents newUsername As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents newPosition As ComboBox
    Friend WithEvents addUser_Btn As Button
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents TableTableAdapter As Database1DataSetTableAdapters.TableTableAdapter
    Friend WithEvents Label11 As Label
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents ThesisTableAdapter1 As Database1DataSetTableAdapters.ThesisTableAdapter
    Friend WithEvents ThesisBindingSource As BindingSource
    Friend WithEvents approvedThesis As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents FeedbackTableAdapter As Database1DataSetTableAdapters.FeedbackTableAdapter
    Friend WithEvents reviewList As ComboBox
    Friend WithEvents FeedbackBindingSource As BindingSource
    Friend WithEvents thesisNumber As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents author As DataGridViewTextBoxColumn
    Friend WithEvents yearLvl As DataGridViewTextBoxColumn
    Friend WithEvents dateReceived As DataGridViewTextBoxColumn
    Friend WithEvents openFile As Button
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents usersDataGrid As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents updateUser As Button
    Friend WithEvents enableAccess As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsEnabled As DataGridViewTextBoxColumn
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents manageUsers_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents review_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents manageUsers_elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents collection_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents backToHome_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents review_Elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents collection_Elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents backToHome_Elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents form_Elipse As Bunifu.Framework.UI.BunifuElipse
End Class
