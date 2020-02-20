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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.directorMenu = New System.Windows.Forms.Panel()
        Me.manageUsers = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.collection = New System.Windows.Forms.Button()
        Me.toReview = New System.Windows.Forms.Button()
        Me.welcomePanel = New System.Windows.Forms.Panel()
        Me.forReviewPanel = New System.Windows.Forms.Panel()
        Me.reject = New System.Windows.Forms.Button()
        Me.pending = New System.Windows.Forms.Button()
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
        Me.ThesisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New MidtermProj.Database1DataSet()
        Me.forRevLabel = New System.Windows.Forms.Label()
        Me.collectionPanel = New System.Windows.Forms.Panel()
        Me.approvedThesis = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.ThesisNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearLvlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReceivedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.manageUsers_Panel = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.deleteUser_GroupBox = New System.Windows.Forms.GroupBox()
        Me.usersDataGrid = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.UsernameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.deleteUser_btn = New System.Windows.Forms.Button()
        Me.addUser_GroupBox = New System.Windows.Forms.GroupBox()
        Me.addUser_Btn = New System.Windows.Forms.Button()
        Me.newPosition = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.retypeNewPassword = New System.Windows.Forms.TextBox()
        Me.newPassword = New System.Windows.Forms.TextBox()
        Me.newUsername = New System.Windows.Forms.TextBox()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.TableTableAdapter = New MidtermProj.Database1DataSetTableAdapters.TableTableAdapter()
        Me.ThesisTableAdapter1 = New MidtermProj.Database1DataSetTableAdapters.ThesisTableAdapter()
        Me.HasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FeedbackTableAdapter = New MidtermProj.Database1DataSetTableAdapters.FeedbackTableAdapter()
        Me.directorMenu.SuspendLayout()
        Me.forReviewPanel.SuspendLayout()
        CType(Me.ThesisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.collectionPanel.SuspendLayout()
        CType(Me.approvedThesis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.manageUsers_Panel.SuspendLayout()
        Me.deleteUser_GroupBox.SuspendLayout()
        CType(Me.usersDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addUser_GroupBox.SuspendLayout()
        CType(Me.HasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'directorMenu
        '
        Me.directorMenu.BackColor = System.Drawing.SystemColors.Control
        Me.directorMenu.BackgroundImage = CType(resources.GetObject("directorMenu.BackgroundImage"), System.Drawing.Image)
        Me.directorMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.directorMenu.Controls.Add(Me.manageUsers)
        Me.directorMenu.Controls.Add(Me.Button1)
        Me.directorMenu.Controls.Add(Me.Panel2)
        Me.directorMenu.Controls.Add(Me.collection)
        Me.directorMenu.Controls.Add(Me.toReview)
        Me.directorMenu.Location = New System.Drawing.Point(0, 0)
        Me.directorMenu.Name = "directorMenu"
        Me.directorMenu.Size = New System.Drawing.Size(168, 369)
        Me.directorMenu.TabIndex = 0
        '
        'manageUsers
        '
        Me.manageUsers.Location = New System.Drawing.Point(28, 119)
        Me.manageUsers.Name = "manageUsers"
        Me.manageUsers.Size = New System.Drawing.Size(101, 23)
        Me.manageUsers.TabIndex = 8
        Me.manageUsers.Text = "Manage Users"
        Me.manageUsers.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(12, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel2.Location = New System.Drawing.Point(174, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(630, 369)
        Me.Panel2.TabIndex = 1
        '
        'collection
        '
        Me.collection.Location = New System.Drawing.Point(28, 178)
        Me.collection.Name = "collection"
        Me.collection.Size = New System.Drawing.Size(101, 23)
        Me.collection.TabIndex = 1
        Me.collection.Text = "Collection"
        Me.collection.UseVisualStyleBackColor = True
        '
        'toReview
        '
        Me.toReview.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.toReview.Location = New System.Drawing.Point(28, 149)
        Me.toReview.Name = "toReview"
        Me.toReview.Size = New System.Drawing.Size(101, 23)
        Me.toReview.TabIndex = 1
        Me.toReview.Text = "For Review"
        Me.toReview.UseVisualStyleBackColor = True
        '
        'welcomePanel
        '
        Me.welcomePanel.BackgroundImage = CType(resources.GetObject("welcomePanel.BackgroundImage"), System.Drawing.Image)
        Me.welcomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.welcomePanel.Location = New System.Drawing.Point(174, 0)
        Me.welcomePanel.Name = "welcomePanel"
        Me.welcomePanel.Size = New System.Drawing.Size(627, 366)
        Me.welcomePanel.TabIndex = 1
        '
        'forReviewPanel
        '
        Me.forReviewPanel.Controls.Add(Me.reject)
        Me.forReviewPanel.Controls.Add(Me.pending)
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
        Me.forReviewPanel.Location = New System.Drawing.Point(174, 0)
        Me.forReviewPanel.Name = "forReviewPanel"
        Me.forReviewPanel.Size = New System.Drawing.Size(627, 369)
        Me.forReviewPanel.TabIndex = 0
        '
        'reject
        '
        Me.reject.Location = New System.Drawing.Point(514, 288)
        Me.reject.Name = "reject"
        Me.reject.Size = New System.Drawing.Size(75, 23)
        Me.reject.TabIndex = 6
        Me.reject.Text = "Reject"
        Me.reject.UseVisualStyleBackColor = True
        '
        'pending
        '
        Me.pending.Location = New System.Drawing.Point(514, 317)
        Me.pending.Name = "pending"
        Me.pending.Size = New System.Drawing.Size(75, 23)
        Me.pending.TabIndex = 6
        Me.pending.Text = "Pending"
        Me.pending.UseVisualStyleBackColor = True
        '
        'approve
        '
        Me.approve.Location = New System.Drawing.Point(514, 259)
        Me.approve.Name = "approve"
        Me.approve.Size = New System.Drawing.Size(75, 23)
        Me.approve.TabIndex = 6
        Me.approve.Text = "Approve"
        Me.approve.UseVisualStyleBackColor = True
        '
        'selectThesis
        '
        Me.selectThesis.Location = New System.Drawing.Point(514, 91)
        Me.selectThesis.Name = "selectThesis"
        Me.selectThesis.Size = New System.Drawing.Size(75, 23)
        Me.selectThesis.TabIndex = 5
        Me.selectThesis.Text = "Select"
        Me.selectThesis.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(184, 268)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 72)
        Me.TextBox1.TabIndex = 4
        '
        'viewDescription
        '
        Me.viewDescription.Location = New System.Drawing.Point(184, 174)
        Me.viewDescription.Multiline = True
        Me.viewDescription.Name = "viewDescription"
        Me.viewDescription.ReadOnly = True
        Me.viewDescription.Size = New System.Drawing.Size(260, 91)
        Me.viewDescription.TabIndex = 4
        '
        'viewTitle
        '
        Me.viewTitle.Location = New System.Drawing.Point(184, 148)
        Me.viewTitle.Name = "viewTitle"
        Me.viewTitle.ReadOnly = True
        Me.viewTitle.Size = New System.Drawing.Size(260, 20)
        Me.viewTitle.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(105, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Remarks"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'viewAuthor
        '
        Me.viewAuthor.Location = New System.Drawing.Point(184, 119)
        Me.viewAuthor.Name = "viewAuthor"
        Me.viewAuthor.ReadOnly = True
        Me.viewAuthor.Size = New System.Drawing.Size(260, 20)
        Me.viewAuthor.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 175)
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
        Me.Label3.Location = New System.Drawing.Point(122, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Author"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(122, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Title"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 91)
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
        Me.reviewList.Location = New System.Drawing.Point(184, 90)
        Me.reviewList.Name = "reviewList"
        Me.reviewList.Size = New System.Drawing.Size(310, 21)
        Me.reviewList.TabIndex = 2
        Me.reviewList.ValueMember = "title"
        '
        'ThesisBindingSource
        '
        Me.ThesisBindingSource.DataMember = "Thesis"
        Me.ThesisBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.EnforceConstraints = False
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'forRevLabel
        '
        Me.forRevLabel.AutoSize = True
        Me.forRevLabel.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forRevLabel.Location = New System.Drawing.Point(19, 32)
        Me.forRevLabel.Name = "forRevLabel"
        Me.forRevLabel.Size = New System.Drawing.Size(275, 35)
        Me.forRevLabel.TabIndex = 0
        Me.forRevLabel.Text = "Thesis for Review"
        '
        'collectionPanel
        '
        Me.collectionPanel.Controls.Add(Me.approvedThesis)
        Me.collectionPanel.Controls.Add(Me.Label6)
        Me.collectionPanel.Location = New System.Drawing.Point(174, 3)
        Me.collectionPanel.Name = "collectionPanel"
        Me.collectionPanel.Size = New System.Drawing.Size(624, 363)
        Me.collectionPanel.TabIndex = 7
        '
        'approvedThesis
        '
        Me.approvedThesis.AllowUserToAddRows = False
        Me.approvedThesis.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.approvedThesis.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.approvedThesis.AutoGenerateColumns = False
        Me.approvedThesis.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.approvedThesis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.approvedThesis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.approvedThesis.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.approvedThesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.approvedThesis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ThesisNumberDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.YearLvlDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.DateReceivedDataGridViewTextBoxColumn})
        Me.approvedThesis.DataSource = Me.ThesisBindingSource
        Me.approvedThesis.DoubleBuffered = True
        Me.approvedThesis.EnableHeadersVisualStyles = False
        Me.approvedThesis.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.approvedThesis.HeaderBgColor = System.Drawing.Color.Indigo
        Me.approvedThesis.HeaderForeColor = System.Drawing.Color.White
        Me.approvedThesis.Location = New System.Drawing.Point(13, 87)
        Me.approvedThesis.Name = "approvedThesis"
        Me.approvedThesis.ReadOnly = True
        Me.approvedThesis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.approvedThesis.Size = New System.Drawing.Size(593, 234)
        Me.approvedThesis.TabIndex = 2
        '
        'ThesisNumberDataGridViewTextBoxColumn
        '
        Me.ThesisNumberDataGridViewTextBoxColumn.DataPropertyName = "thesisNumber"
        Me.ThesisNumberDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.ThesisNumberDataGridViewTextBoxColumn.Name = "ThesisNumberDataGridViewTextBoxColumn"
        Me.ThesisNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.ThesisNumberDataGridViewTextBoxColumn.Width = 50
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YearLvlDataGridViewTextBoxColumn
        '
        Me.YearLvlDataGridViewTextBoxColumn.DataPropertyName = "yearLvl"
        Me.YearLvlDataGridViewTextBoxColumn.HeaderText = "Year Level"
        Me.YearLvlDataGridViewTextBoxColumn.Name = "YearLvlDataGridViewTextBoxColumn"
        Me.YearLvlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateReceivedDataGridViewTextBoxColumn
        '
        Me.DateReceivedDataGridViewTextBoxColumn.DataPropertyName = "dateReceived"
        Me.DateReceivedDataGridViewTextBoxColumn.HeaderText = "Date Received"
        Me.DateReceivedDataGridViewTextBoxColumn.Name = "DateReceivedDataGridViewTextBoxColumn"
        Me.DateReceivedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft New Tai Lue", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(177, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(270, 43)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Approved Thesis"
        '
        'manageUsers_Panel
        '
        Me.manageUsers_Panel.Controls.Add(Me.Label11)
        Me.manageUsers_Panel.Controls.Add(Me.deleteUser_GroupBox)
        Me.manageUsers_Panel.Controls.Add(Me.addUser_GroupBox)
        Me.manageUsers_Panel.Location = New System.Drawing.Point(174, 0)
        Me.manageUsers_Panel.Name = "manageUsers_Panel"
        Me.manageUsers_Panel.Size = New System.Drawing.Size(627, 369)
        Me.manageUsers_Panel.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(237, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(169, 29)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Manage Users"
        '
        'deleteUser_GroupBox
        '
        Me.deleteUser_GroupBox.Controls.Add(Me.usersDataGrid)
        Me.deleteUser_GroupBox.Controls.Add(Me.deleteUser_btn)
        Me.deleteUser_GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteUser_GroupBox.Location = New System.Drawing.Point(332, 73)
        Me.deleteUser_GroupBox.Name = "deleteUser_GroupBox"
        Me.deleteUser_GroupBox.Size = New System.Drawing.Size(277, 270)
        Me.deleteUser_GroupBox.TabIndex = 10
        Me.deleteUser_GroupBox.TabStop = False
        Me.deleteUser_GroupBox.Text = "Delete User"
        '
        'usersDataGrid
        '
        Me.usersDataGrid.AllowUserToAddRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.usersDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.usersDataGrid.AutoGenerateColumns = False
        Me.usersDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.usersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usersDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkViolet
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.usersDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.usersDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn1, Me.PositionDataGridViewTextBoxColumn})
        Me.usersDataGrid.DataSource = Me.TableBindingSource
        Me.usersDataGrid.DoubleBuffered = True
        Me.usersDataGrid.EnableHeadersVisualStyles = False
        Me.usersDataGrid.HeaderBgColor = System.Drawing.Color.DarkViolet
        Me.usersDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.usersDataGrid.Location = New System.Drawing.Point(17, 32)
        Me.usersDataGrid.Name = "usersDataGrid"
        Me.usersDataGrid.ReadOnly = True
        Me.usersDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.usersDataGrid.Size = New System.Drawing.Size(240, 177)
        Me.usersDataGrid.TabIndex = 12
        '
        'UsernameDataGridViewTextBoxColumn1
        '
        Me.UsernameDataGridViewTextBoxColumn1.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn1.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn1.Name = "UsernameDataGridViewTextBoxColumn1"
        Me.UsernameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.Database1DataSet
        '
        'deleteUser_btn
        '
        Me.deleteUser_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteUser_btn.Location = New System.Drawing.Point(101, 230)
        Me.deleteUser_btn.Name = "deleteUser_btn"
        Me.deleteUser_btn.Size = New System.Drawing.Size(92, 27)
        Me.deleteUser_btn.TabIndex = 11
        Me.deleteUser_btn.Text = "Delete User"
        Me.deleteUser_btn.UseVisualStyleBackColor = True
        '
        'addUser_GroupBox
        '
        Me.addUser_GroupBox.Controls.Add(Me.addUser_Btn)
        Me.addUser_GroupBox.Controls.Add(Me.newPosition)
        Me.addUser_GroupBox.Controls.Add(Me.Label10)
        Me.addUser_GroupBox.Controls.Add(Me.Label9)
        Me.addUser_GroupBox.Controls.Add(Me.Label8)
        Me.addUser_GroupBox.Controls.Add(Me.Label7)
        Me.addUser_GroupBox.Controls.Add(Me.retypeNewPassword)
        Me.addUser_GroupBox.Controls.Add(Me.newPassword)
        Me.addUser_GroupBox.Controls.Add(Me.newUsername)
        Me.addUser_GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addUser_GroupBox.Location = New System.Drawing.Point(13, 70)
        Me.addUser_GroupBox.Name = "addUser_GroupBox"
        Me.addUser_GroupBox.Size = New System.Drawing.Size(282, 270)
        Me.addUser_GroupBox.TabIndex = 9
        Me.addUser_GroupBox.TabStop = False
        Me.addUser_GroupBox.Text = "Add User"
        '
        'addUser_Btn
        '
        Me.addUser_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addUser_Btn.Location = New System.Drawing.Point(95, 233)
        Me.addUser_Btn.Name = "addUser_Btn"
        Me.addUser_Btn.Size = New System.Drawing.Size(85, 27)
        Me.addUser_Btn.TabIndex = 11
        Me.addUser_Btn.Text = "Add User"
        Me.addUser_Btn.UseVisualStyleBackColor = True
        '
        'newPosition
        '
        Me.newPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPosition.FormattingEnabled = True
        Me.newPosition.Items.AddRange(New Object() {"Admin", "Staff"})
        Me.newPosition.Location = New System.Drawing.Point(128, 161)
        Me.newPosition.Name = "newPosition"
        Me.newPosition.Size = New System.Drawing.Size(141, 24)
        Me.newPosition.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Position"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Retype Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Username"
        '
        'retypeNewPassword
        '
        Me.retypeNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retypeNewPassword.Location = New System.Drawing.Point(128, 125)
        Me.retypeNewPassword.Name = "retypeNewPassword"
        Me.retypeNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.retypeNewPassword.Size = New System.Drawing.Size(141, 22)
        Me.retypeNewPassword.TabIndex = 0
        '
        'newPassword
        '
        Me.newPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPassword.Location = New System.Drawing.Point(128, 89)
        Me.newPassword.Name = "newPassword"
        Me.newPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newPassword.Size = New System.Drawing.Size(141, 22)
        Me.newPassword.TabIndex = 0
        '
        'newUsername
        '
        Me.newUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.newUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newUsername.Location = New System.Drawing.Point(128, 54)
        Me.newUsername.Name = "newUsername"
        Me.newUsername.Size = New System.Drawing.Size(141, 22)
        Me.newUsername.TabIndex = 0
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
        'HasBindingSource
        '
        Me.HasBindingSource.DataMember = "has"
        Me.HasBindingSource.DataSource = Me.ThesisBindingSource
        '
        'FeedbackTableAdapter
        '
        Me.FeedbackTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 369)
        Me.Controls.Add(Me.directorMenu)
        Me.Controls.Add(Me.forReviewPanel)
        Me.Controls.Add(Me.welcomePanel)
        Me.Controls.Add(Me.collectionPanel)
        Me.Controls.Add(Me.manageUsers_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.Text = "Kinaadman University Research Office (Director)"
        Me.directorMenu.ResumeLayout(False)
        Me.forReviewPanel.ResumeLayout(False)
        Me.forReviewPanel.PerformLayout()
        CType(Me.ThesisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.collectionPanel.ResumeLayout(False)
        Me.collectionPanel.PerformLayout()
        CType(Me.approvedThesis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.manageUsers_Panel.ResumeLayout(False)
        Me.manageUsers_Panel.PerformLayout()
        Me.deleteUser_GroupBox.ResumeLayout(False)
        CType(Me.usersDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addUser_GroupBox.ResumeLayout(False)
        Me.addUser_GroupBox.PerformLayout()
        CType(Me.HasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents directorMenu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents collection As Button
    Friend WithEvents toReview As Button
    Friend WithEvents welcomePanel As Panel
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
    Friend WithEvents pending As Button
    Friend WithEvents approve As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents collectionPanel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents manageUsers_Panel As Panel
    Friend WithEvents deleteUser_GroupBox As GroupBox
    Friend WithEvents addUser_GroupBox As GroupBox
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
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As Database1DataSetTableAdapters.TableTableAdapter
    Friend WithEvents Label11 As Label
    Friend WithEvents deleteUser_btn As Button
    Friend WithEvents usersDataGrid As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents UsernameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents manageUsers As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents ThesisTableAdapter1 As Database1DataSetTableAdapters.ThesisTableAdapter
    Friend WithEvents ThesisBindingSource As BindingSource
    Friend WithEvents approvedThesis As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ThesisNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HasBindingSource As BindingSource
    Friend WithEvents FeedbackTableAdapter As Database1DataSetTableAdapters.FeedbackTableAdapter
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearLvlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateReceivedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents reviewList As ComboBox
End Class
