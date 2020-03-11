<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.home_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.feedback_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.receive_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.addInfo_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.attach_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sendToDirector_Btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.receive_Elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.feedback_elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.home_elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.window_Elipse = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.Panel1.Controls.Add(Me.home_btn)
        Me.Panel1.Controls.Add(Me.feedback_btn)
        Me.Panel1.Controls.Add(Me.receive_btn)
        Me.Panel1.Location = New System.Drawing.Point(-4, -18)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(153, 472)
        Me.Panel1.TabIndex = 0
        '
        'home_btn
        '
        Me.home_btn.ActiveBorderThickness = 1
        Me.home_btn.ActiveCornerRadius = 20
        Me.home_btn.ActiveFillColor = System.Drawing.Color.Indigo
        Me.home_btn.ActiveForecolor = System.Drawing.Color.White
        Me.home_btn.ActiveLineColor = System.Drawing.Color.Indigo
        Me.home_btn.BackColor = System.Drawing.Color.Transparent
        Me.home_btn.BackgroundImage = CType(resources.GetObject("home_btn.BackgroundImage"), System.Drawing.Image)
        Me.home_btn.ButtonText = "Home"
        Me.home_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.home_btn.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home_btn.ForeColor = System.Drawing.Color.Indigo
        Me.home_btn.IdleBorderThickness = 1
        Me.home_btn.IdleCornerRadius = 20
        Me.home_btn.IdleFillColor = System.Drawing.Color.White
        Me.home_btn.IdleForecolor = System.Drawing.Color.Indigo
        Me.home_btn.IdleLineColor = System.Drawing.Color.Indigo
        Me.home_btn.Location = New System.Drawing.Point(14, 229)
        Me.home_btn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.Size = New System.Drawing.Size(133, 45)
        Me.home_btn.TabIndex = 5
        Me.home_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'feedback_btn
        '
        Me.feedback_btn.ActiveBorderThickness = 1
        Me.feedback_btn.ActiveCornerRadius = 20
        Me.feedback_btn.ActiveFillColor = System.Drawing.Color.Indigo
        Me.feedback_btn.ActiveForecolor = System.Drawing.Color.White
        Me.feedback_btn.ActiveLineColor = System.Drawing.Color.Indigo
        Me.feedback_btn.BackColor = System.Drawing.Color.Transparent
        Me.feedback_btn.BackgroundImage = CType(resources.GetObject("feedback_btn.BackgroundImage"), System.Drawing.Image)
        Me.feedback_btn.ButtonText = "Feedback"
        Me.feedback_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.feedback_btn.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.feedback_btn.ForeColor = System.Drawing.Color.Indigo
        Me.feedback_btn.IdleBorderThickness = 1
        Me.feedback_btn.IdleCornerRadius = 20
        Me.feedback_btn.IdleFillColor = System.Drawing.Color.White
        Me.feedback_btn.IdleForecolor = System.Drawing.Color.Indigo
        Me.feedback_btn.IdleLineColor = System.Drawing.Color.Indigo
        Me.feedback_btn.Location = New System.Drawing.Point(14, 189)
        Me.feedback_btn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.feedback_btn.Name = "feedback_btn"
        Me.feedback_btn.Size = New System.Drawing.Size(133, 45)
        Me.feedback_btn.TabIndex = 5
        Me.feedback_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'receive_btn
        '
        Me.receive_btn.ActiveBorderThickness = 1
        Me.receive_btn.ActiveCornerRadius = 20
        Me.receive_btn.ActiveFillColor = System.Drawing.Color.Indigo
        Me.receive_btn.ActiveForecolor = System.Drawing.Color.White
        Me.receive_btn.ActiveLineColor = System.Drawing.Color.Indigo
        Me.receive_btn.BackColor = System.Drawing.Color.Transparent
        Me.receive_btn.BackgroundImage = CType(resources.GetObject("receive_btn.BackgroundImage"), System.Drawing.Image)
        Me.receive_btn.ButtonText = "Receive"
        Me.receive_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.receive_btn.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receive_btn.ForeColor = System.Drawing.Color.Indigo
        Me.receive_btn.IdleBorderThickness = 1
        Me.receive_btn.IdleCornerRadius = 20
        Me.receive_btn.IdleFillColor = System.Drawing.Color.White
        Me.receive_btn.IdleForecolor = System.Drawing.Color.Indigo
        Me.receive_btn.IdleLineColor = System.Drawing.Color.Indigo
        Me.receive_btn.Location = New System.Drawing.Point(14, 149)
        Me.receive_btn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.receive_btn.Name = "receive_btn"
        Me.receive_btn.Size = New System.Drawing.Size(133, 45)
        Me.receive_btn.TabIndex = 5
        Me.receive_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.addInfo_btn)
        Me.Panel2.Controls.Add(Me.attach_btn)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.AxAcroPDF1)
        Me.Panel2.Location = New System.Drawing.Point(153, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(854, 450)
        Me.Panel2.TabIndex = 1
        Me.Panel2.Visible = False
        '
        'addInfo_btn
        '
        Me.addInfo_btn.ActiveBorderThickness = 1
        Me.addInfo_btn.ActiveCornerRadius = 20
        Me.addInfo_btn.ActiveFillColor = System.Drawing.Color.White
        Me.addInfo_btn.ActiveForecolor = System.Drawing.Color.Indigo
        Me.addInfo_btn.ActiveLineColor = System.Drawing.Color.White
        Me.addInfo_btn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.addInfo_btn.BackgroundImage = CType(resources.GetObject("addInfo_btn.BackgroundImage"), System.Drawing.Image)
        Me.addInfo_btn.ButtonText = "Add Info"
        Me.addInfo_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addInfo_btn.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addInfo_btn.ForeColor = System.Drawing.Color.Indigo
        Me.addInfo_btn.IdleBorderThickness = 1
        Me.addInfo_btn.IdleCornerRadius = 20
        Me.addInfo_btn.IdleFillColor = System.Drawing.Color.Indigo
        Me.addInfo_btn.IdleForecolor = System.Drawing.Color.White
        Me.addInfo_btn.IdleLineColor = System.Drawing.Color.Indigo
        Me.addInfo_btn.Location = New System.Drawing.Point(17, 202)
        Me.addInfo_btn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.addInfo_btn.Name = "addInfo_btn"
        Me.addInfo_btn.Size = New System.Drawing.Size(103, 40)
        Me.addInfo_btn.TabIndex = 5
        Me.addInfo_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'attach_btn
        '
        Me.attach_btn.ActiveBorderThickness = 1
        Me.attach_btn.ActiveCornerRadius = 20
        Me.attach_btn.ActiveFillColor = System.Drawing.Color.White
        Me.attach_btn.ActiveForecolor = System.Drawing.Color.Indigo
        Me.attach_btn.ActiveLineColor = System.Drawing.Color.White
        Me.attach_btn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.attach_btn.BackgroundImage = CType(resources.GetObject("attach_btn.BackgroundImage"), System.Drawing.Image)
        Me.attach_btn.ButtonText = "Attach file"
        Me.attach_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.attach_btn.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attach_btn.ForeColor = System.Drawing.Color.Indigo
        Me.attach_btn.IdleBorderThickness = 1
        Me.attach_btn.IdleCornerRadius = 20
        Me.attach_btn.IdleFillColor = System.Drawing.Color.Indigo
        Me.attach_btn.IdleForecolor = System.Drawing.Color.White
        Me.attach_btn.IdleLineColor = System.Drawing.Color.Indigo
        Me.attach_btn.Location = New System.Drawing.Point(18, 157)
        Me.attach_btn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.attach_btn.Name = "attach_btn"
        Me.attach_btn.Size = New System.Drawing.Size(103, 40)
        Me.attach_btn.TabIndex = 5
        Me.attach_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.CheckBox1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.sendToDirector_Btn)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Me.TextBox5)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(136, -1)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(679, 440)
        Me.Panel3.TabIndex = 4
        Me.Panel3.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(41, 334)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(410, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "I hereby certify that all information is true and correct to the best of my knowl" &
    "edge."
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(442, 87)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 149)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'sendToDirector_Btn
        '
        Me.sendToDirector_Btn.ActiveBorderThickness = 1
        Me.sendToDirector_Btn.ActiveCornerRadius = 20
        Me.sendToDirector_Btn.ActiveFillColor = System.Drawing.Color.White
        Me.sendToDirector_Btn.ActiveForecolor = System.Drawing.Color.Indigo
        Me.sendToDirector_Btn.ActiveLineColor = System.Drawing.Color.White
        Me.sendToDirector_Btn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sendToDirector_Btn.BackgroundImage = CType(resources.GetObject("sendToDirector_Btn.BackgroundImage"), System.Drawing.Image)
        Me.sendToDirector_Btn.ButtonText = "Send to Director"
        Me.sendToDirector_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sendToDirector_Btn.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendToDirector_Btn.ForeColor = System.Drawing.Color.Indigo
        Me.sendToDirector_Btn.IdleBorderThickness = 1
        Me.sendToDirector_Btn.IdleCornerRadius = 20
        Me.sendToDirector_Btn.IdleFillColor = System.Drawing.Color.Indigo
        Me.sendToDirector_Btn.IdleForecolor = System.Drawing.Color.White
        Me.sendToDirector_Btn.IdleLineColor = System.Drawing.Color.Indigo
        Me.sendToDirector_Btn.Location = New System.Drawing.Point(269, 364)
        Me.sendToDirector_Btn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.sendToDirector_Btn.Name = "sendToDirector_Btn"
        Me.sendToDirector_Btn.Size = New System.Drawing.Size(144, 40)
        Me.sendToDirector_Btn.TabIndex = 5
        Me.sendToDirector_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(442, 257)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(151, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(41, 196)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(372, 130)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(41, 147)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(372, 24)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(346, 104)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(67, 24)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(41, 104)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(281, 24)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(442, 306)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(151, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 181)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Short Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Title of the Study"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(439, 241)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Date Received"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(343, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Year Level"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(490, 75)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Time now"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(35, 45)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(299, 31)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Information of the Paper"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Full Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(439, 291)
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
        Me.Panel4.Location = New System.Drawing.Point(155, -5)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(859, 452)
        Me.Panel4.TabIndex = 5
        Me.Panel4.Visible = False
        '
        'FilterLabel
        '
        Me.FilterLabel.AutoSize = True
        Me.FilterLabel.BackColor = System.Drawing.Color.Transparent
        Me.FilterLabel.Location = New System.Drawing.Point(259, 25)
        Me.FilterLabel.Name = "FilterLabel"
        Me.FilterLabel.Size = New System.Drawing.Size(29, 13)
        Me.FilterLabel.TabIndex = 9
        Me.FilterLabel.Text = "Filter"
        '
        'filterComboBox
        '
        Me.filterComboBox.FormattingEnabled = True
        Me.filterComboBox.Items.AddRange(New Object() {"Thesis ID", "Title", "Author", "Status"})
        Me.filterComboBox.Location = New System.Drawing.Point(259, 41)
        Me.filterComboBox.Name = "filterComboBox"
        Me.filterComboBox.Size = New System.Drawing.Size(144, 21)
        Me.filterComboBox.TabIndex = 8
        '
        'refresh
        '
        Me.refresh.Location = New System.Drawing.Point(726, 38)
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(75, 23)
        Me.refresh.TabIndex = 7
        Me.refresh.Text = "Refresh"
        Me.refresh.UseVisualStyleBackColor = True
        '
        'search_Btn
        '
        Me.search_Btn.Location = New System.Drawing.Point(409, 40)
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
        Me.Label9.Location = New System.Drawing.Point(14, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Search"
        '
        'searchBox
        '
        Me.searchBox.Location = New System.Drawing.Point(13, 41)
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
        Me.feedbackDataGrid.Location = New System.Drawing.Point(13, 75)
        Me.feedbackDataGrid.Name = "feedbackDataGrid"
        Me.feedbackDataGrid.ReadOnly = True
        Me.feedbackDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.feedbackDataGrid.Size = New System.Drawing.Size(793, 327)
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
        'receive_Elipse
        '
        Me.receive_Elipse.ElipseRadius = 20
        Me.receive_Elipse.TargetControl = Me.receive_btn
        '
        'feedback_elipse
        '
        Me.feedback_elipse.ElipseRadius = 20
        Me.feedback_elipse.TargetControl = Me.feedback_btn
        '
        'home_elipse
        '
        Me.home_elipse.ElipseRadius = 20
        Me.home_elipse.TargetControl = Me.home_btn
        '
        'window_Elipse
        '
        Me.window_Elipse.ElipseRadius = 10
        Me.window_Elipse.TargetControl = Me
        '
        'Timer1
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 453)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "e"
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
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
    Friend WithEvents receive_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents receive_Elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents feedback_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents feedback_elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents home_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents home_elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents attach_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents addInfo_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents sendToDirector_Btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents window_Elipse As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
