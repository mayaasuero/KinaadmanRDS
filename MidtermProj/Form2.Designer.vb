<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.feedback_btn = New System.Windows.Forms.Button()
        Me.receive_btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.FilterLabel = New System.Windows.Forms.Label()
        Me.filterComboBox = New System.Windows.Forms.ComboBox()
        Me.refresh = New System.Windows.Forms.Button()
        Me.search_Btn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.feedbackDataGrid = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.ThesisNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.message = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeedbackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New MidtermProj.Database1DataSet()
        Me.HasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FeedbackTableAdapter = New MidtermProj.Database1DataSetTableAdapters.FeedbackTableAdapter()
        Me.ThesisTableAdapter = New MidtermProj.Database1DataSetTableAdapters.ThesisTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.feedbackDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeedbackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.feedback_btn)
        Me.Panel1.Controls.Add(Me.receive_btn)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(-4, -18)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(153, 472)
        Me.Panel1.TabIndex = 0
        '
        'feedback_btn
        '
        Me.feedback_btn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.feedback_btn.BackgroundImage = CType(resources.GetObject("feedback_btn.BackgroundImage"), System.Drawing.Image)
        Me.feedback_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.feedback_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.feedback_btn.Location = New System.Drawing.Point(22, 191)
        Me.feedback_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.feedback_btn.Name = "feedback_btn"
        Me.feedback_btn.Size = New System.Drawing.Size(112, 38)
        Me.feedback_btn.TabIndex = 0
        Me.feedback_btn.UseVisualStyleBackColor = False
        '
        'receive_btn
        '
        Me.receive_btn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.receive_btn.BackgroundImage = CType(resources.GetObject("receive_btn.BackgroundImage"), System.Drawing.Image)
        Me.receive_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.receive_btn.Location = New System.Drawing.Point(22, 146)
        Me.receive_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.receive_btn.Name = "receive_btn"
        Me.receive_btn.Size = New System.Drawing.Size(112, 38)
        Me.receive_btn.TabIndex = 0
        Me.receive_btn.Text = " "
        Me.receive_btn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(22, 236)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = " "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.AxAcroPDF1)
        Me.Panel2.Location = New System.Drawing.Point(153, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(854, 450)
        Me.Panel2.TabIndex = 1
        Me.Panel2.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightBlue
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Location = New System.Drawing.Point(19, 229)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 41)
        Me.Button5.TabIndex = 0
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightBlue
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(19, 160)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 64)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = " "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Me.TextBox5)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(136, -1)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(694, 440)
        Me.Panel3.TabIndex = 4
        Me.Panel3.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(494, 47)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 179)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(289, 370)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(151, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(40, 223)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(372, 116)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(40, 174)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(372, 24)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(40, 124)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(67, 24)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(40, 76)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(177, 24)
        Me.TextBox2.TabIndex = 4
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightBlue
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Location = New System.Drawing.Point(579, 354)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 47)
        Me.Button4.TabIndex = 0
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(453, 369)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(113, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 204)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Short Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 158)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Title of the Study"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(286, 354)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Date Received"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Year Level"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(549, 31)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Time now"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Full Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(454, 350)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Received by:"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(163, -1)
        Me.AxAcroPDF1.Margin = New System.Windows.Forms.Padding(2)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(619, 437)
        Me.AxAcroPDF1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Snow
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.FilterLabel)
        Me.Panel4.Controls.Add(Me.filterComboBox)
        Me.Panel4.Controls.Add(Me.refresh)
        Me.Panel4.Controls.Add(Me.search_Btn)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.searchBox)
        Me.Panel4.Controls.Add(Me.feedbackDataGrid)
        Me.Panel4.Location = New System.Drawing.Point(156, 2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(884, 446)
        Me.Panel4.TabIndex = 5
        Me.Panel4.Visible = False
        '
        'FilterLabel
        '
        Me.FilterLabel.AutoSize = True
        Me.FilterLabel.BackColor = System.Drawing.Color.Transparent
        Me.FilterLabel.Location = New System.Drawing.Point(274, 26)
        Me.FilterLabel.Name = "FilterLabel"
        Me.FilterLabel.Size = New System.Drawing.Size(29, 13)
        Me.FilterLabel.TabIndex = 9
        Me.FilterLabel.Text = "Filter"
        '
        'filterComboBox
        '
        Me.filterComboBox.FormattingEnabled = True
        Me.filterComboBox.Items.AddRange(New Object() {"Thesis ID", "Title", "Author", "Status"})
        Me.filterComboBox.Location = New System.Drawing.Point(274, 42)
        Me.filterComboBox.Name = "filterComboBox"
        Me.filterComboBox.Size = New System.Drawing.Size(144, 21)
        Me.filterComboBox.TabIndex = 8
        '
        'refresh
        '
        Me.refresh.Location = New System.Drawing.Point(741, 39)
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(75, 23)
        Me.refresh.TabIndex = 7
        Me.refresh.Text = "Refresh"
        Me.refresh.UseVisualStyleBackColor = True
        '
        'search_Btn
        '
        Me.search_Btn.Location = New System.Drawing.Point(424, 41)
        Me.search_Btn.Name = "search_Btn"
        Me.search_Btn.Size = New System.Drawing.Size(75, 23)
        Me.search_Btn.TabIndex = 7
        Me.search_Btn.Text = "Search"
        Me.search_Btn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(29, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Search"
        '
        'searchBox
        '
        Me.searchBox.Location = New System.Drawing.Point(28, 42)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(238, 20)
        Me.searchBox.TabIndex = 5
        '
        'feedbackDataGrid
        '
        Me.feedbackDataGrid.AllowUserToAddRows = False
        Me.feedbackDataGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.feedbackDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.feedbackDataGrid.AutoGenerateColumns = False
        Me.feedbackDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.feedbackDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.feedbackDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.feedbackDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.feedbackDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.feedbackDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.feedbackDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ThesisNumberDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorsDataGridViewTextBoxColumn, Me.status, Me.message})
        Me.feedbackDataGrid.DataSource = Me.FeedbackBindingSource
        Me.feedbackDataGrid.DoubleBuffered = True
        Me.feedbackDataGrid.EnableHeadersVisualStyles = False
        Me.feedbackDataGrid.HeaderBgColor = System.Drawing.Color.Indigo
        Me.feedbackDataGrid.HeaderForeColor = System.Drawing.Color.SeaShell
        Me.feedbackDataGrid.Location = New System.Drawing.Point(28, 76)
        Me.feedbackDataGrid.Name = "feedbackDataGrid"
        Me.feedbackDataGrid.ReadOnly = True
        Me.feedbackDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.feedbackDataGrid.Size = New System.Drawing.Size(797, 327)
        Me.feedbackDataGrid.TabIndex = 4
        '
        'ThesisNumberDataGridViewTextBoxColumn
        '
        Me.ThesisNumberDataGridViewTextBoxColumn.DataPropertyName = "thesisNumber"
        Me.ThesisNumberDataGridViewTextBoxColumn.HeaderText = "Thesis ID"
        Me.ThesisNumberDataGridViewTextBoxColumn.Name = "ThesisNumberDataGridViewTextBoxColumn"
        Me.ThesisNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.ThesisNumberDataGridViewTextBoxColumn.Width = 90
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn.Width = 280
        '
        'AuthorsDataGridViewTextBoxColumn
        '
        Me.AuthorsDataGridViewTextBoxColumn.DataPropertyName = "authors"
        Me.AuthorsDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorsDataGridViewTextBoxColumn.Name = "AuthorsDataGridViewTextBoxColumn"
        Me.AuthorsDataGridViewTextBoxColumn.ReadOnly = True
        Me.AuthorsDataGridViewTextBoxColumn.Width = 175
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'message
        '
        Me.message.DataPropertyName = "message"
        Me.message.HeaderText = "Remarks"
        Me.message.Name = "message"
        Me.message.ReadOnly = True
        Me.message.Width = 105
        '
        'FeedbackBindingSource
        '
        Me.FeedbackBindingSource.DataMember = "Feedback"
        Me.FeedbackBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.EnforceConstraints = False
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FeedbackTableAdapter
        '
        Me.FeedbackTableAdapter.ClearBeforeFill = True
        '
        'ThesisTableAdapter
        '
        Me.ThesisTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 453)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.Text = "Kinaadaman Univerisity Research Office"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.feedbackDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeedbackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents receive_btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents feedback_btn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents feedbackDataGrid As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents HasBindingSource As BindingSource
    Friend WithEvents FeedbackTableAdapter As Database1DataSetTableAdapters.FeedbackTableAdapter
    Friend WithEvents ThesisTableAdapter As Database1DataSetTableAdapters.ThesisTableAdapter
    Friend WithEvents FeedbackBindingSource As BindingSource
    Friend WithEvents search_Btn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents searchBox As TextBox
    Friend WithEvents refresh As Button
    Friend WithEvents FilterLabel As Label
    Friend WithEvents filterComboBox As ComboBox
    Friend WithEvents ThesisNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents message As DataGridViewTextBoxColumn
End Class
