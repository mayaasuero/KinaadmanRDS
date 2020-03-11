<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SubmissionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubmissionForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.submit_Btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.status_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.attach_Btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.submit_Panel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.submitToOffice_Btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.exit_Btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.viewStatus_Panel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ThesisTableAdapter1 = New MidtermProj.Database1DataSetTableAdapters.ThesisTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.submit_Panel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.viewStatus_Panel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 88)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(239, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contributor's Corner"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'submit_Btn
        '
        Me.submit_Btn.ActiveBorderThickness = 1
        Me.submit_Btn.ActiveCornerRadius = 20
        Me.submit_Btn.ActiveFillColor = System.Drawing.SystemColors.ButtonFace
        Me.submit_Btn.ActiveForecolor = System.Drawing.Color.DarkViolet
        Me.submit_Btn.ActiveLineColor = System.Drawing.Color.DarkViolet
        Me.submit_Btn.BackColor = System.Drawing.SystemColors.Control
        Me.submit_Btn.BackgroundImage = CType(resources.GetObject("submit_Btn.BackgroundImage"), System.Drawing.Image)
        Me.submit_Btn.ButtonText = "Submit Paper"
        Me.submit_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submit_Btn.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit_Btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.submit_Btn.IdleBorderThickness = 1
        Me.submit_Btn.IdleCornerRadius = 20
        Me.submit_Btn.IdleFillColor = System.Drawing.Color.DarkViolet
        Me.submit_Btn.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight
        Me.submit_Btn.IdleLineColor = System.Drawing.Color.DarkViolet
        Me.submit_Btn.Location = New System.Drawing.Point(13, 103)
        Me.submit_Btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.submit_Btn.Name = "submit_Btn"
        Me.submit_Btn.Size = New System.Drawing.Size(109, 43)
        Me.submit_Btn.TabIndex = 3
        Me.submit_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me.submit_Btn
        '
        'status_btn
        '
        Me.status_btn.ActiveBorderThickness = 1
        Me.status_btn.ActiveCornerRadius = 20
        Me.status_btn.ActiveFillColor = System.Drawing.SystemColors.ButtonFace
        Me.status_btn.ActiveForecolor = System.Drawing.Color.DarkViolet
        Me.status_btn.ActiveLineColor = System.Drawing.Color.MediumPurple
        Me.status_btn.BackColor = System.Drawing.SystemColors.Control
        Me.status_btn.BackgroundImage = CType(resources.GetObject("status_btn.BackgroundImage"), System.Drawing.Image)
        Me.status_btn.ButtonText = "View Status"
        Me.status_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.status_btn.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.status_btn.IdleBorderThickness = 1
        Me.status_btn.IdleCornerRadius = 20
        Me.status_btn.IdleFillColor = System.Drawing.Color.DarkViolet
        Me.status_btn.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight
        Me.status_btn.IdleLineColor = System.Drawing.Color.DarkViolet
        Me.status_btn.Location = New System.Drawing.Point(13, 143)
        Me.status_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.status_btn.Name = "status_btn"
        Me.status_btn.Size = New System.Drawing.Size(109, 43)
        Me.status_btn.TabIndex = 3
        Me.status_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me.status_btn
        '
        'attach_Btn
        '
        Me.attach_Btn.ActiveBorderThickness = 1
        Me.attach_Btn.ActiveCornerRadius = 20
        Me.attach_Btn.ActiveFillColor = System.Drawing.SystemColors.ButtonFace
        Me.attach_Btn.ActiveForecolor = System.Drawing.Color.MediumPurple
        Me.attach_Btn.ActiveLineColor = System.Drawing.Color.MediumPurple
        Me.attach_Btn.BackColor = System.Drawing.SystemColors.Control
        Me.attach_Btn.BackgroundImage = CType(resources.GetObject("attach_Btn.BackgroundImage"), System.Drawing.Image)
        Me.attach_Btn.ButtonText = "Attach File"
        Me.attach_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.attach_Btn.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attach_Btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.attach_Btn.IdleBorderThickness = 1
        Me.attach_Btn.IdleCornerRadius = 20
        Me.attach_Btn.IdleFillColor = System.Drawing.Color.DarkViolet
        Me.attach_Btn.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight
        Me.attach_Btn.IdleLineColor = System.Drawing.Color.DarkViolet
        Me.attach_Btn.Location = New System.Drawing.Point(20, 295)
        Me.attach_Btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.attach_Btn.Name = "attach_Btn"
        Me.attach_Btn.Size = New System.Drawing.Size(85, 43)
        Me.attach_Btn.TabIndex = 3
        Me.attach_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'submit_Panel
        '
        Me.submit_Panel.Controls.Add(Me.Label6)
        Me.submit_Panel.Controls.Add(Me.Label2)
        Me.submit_Panel.Controls.Add(Me.attach_Btn)
        Me.submit_Panel.Controls.Add(Me.PictureBox2)
        Me.submit_Panel.Controls.Add(Me.Label11)
        Me.submit_Panel.Controls.Add(Me.Label8)
        Me.submit_Panel.Controls.Add(Me.DateTimePicker2)
        Me.submit_Panel.Controls.Add(Me.TextBox4)
        Me.submit_Panel.Controls.Add(Me.Label9)
        Me.submit_Panel.Controls.Add(Me.TextBox5)
        Me.submit_Panel.Controls.Add(Me.Label3)
        Me.submit_Panel.Controls.Add(Me.TextBox3)
        Me.submit_Panel.Controls.Add(Me.Label4)
        Me.submit_Panel.Controls.Add(Me.submitToOffice_Btn)
        Me.submit_Panel.Controls.Add(Me.TextBox2)
        Me.submit_Panel.Controls.Add(Me.Label5)
        Me.submit_Panel.Location = New System.Drawing.Point(129, 91)
        Me.submit_Panel.Name = "submit_Panel"
        Me.submit_Panel.Size = New System.Drawing.Size(580, 350)
        Me.submit_Panel.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(114, 310)
        Me.Label6.MaximumSize = New System.Drawing.Size(300, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Label6"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(401, 253)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Date Received"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(404, 79)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(177, 163)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(458, 64)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Time now"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 16)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(258, 27)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Information of the Paper" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(404, 268)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(151, 20)
        Me.DateTimePicker2.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(21, 172)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(372, 116)
        Me.TextBox4.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 61)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Full Name"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(21, 123)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(372, 24)
        Me.TextBox5.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 61)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Year Level"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(307, 79)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(86, 24)
        Me.TextBox3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 105)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Title of the Study"
        '
        'submitToOffice_Btn
        '
        Me.submitToOffice_Btn.ActiveBorderThickness = 1
        Me.submitToOffice_Btn.ActiveCornerRadius = 20
        Me.submitToOffice_Btn.ActiveFillColor = System.Drawing.SystemColors.ButtonFace
        Me.submitToOffice_Btn.ActiveForecolor = System.Drawing.Color.MediumPurple
        Me.submitToOffice_Btn.ActiveLineColor = System.Drawing.Color.MediumPurple
        Me.submitToOffice_Btn.BackColor = System.Drawing.SystemColors.Control
        Me.submitToOffice_Btn.BackgroundImage = CType(resources.GetObject("submitToOffice_Btn.BackgroundImage"), System.Drawing.Image)
        Me.submitToOffice_Btn.ButtonText = "Submit"
        Me.submitToOffice_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submitToOffice_Btn.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitToOffice_Btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.submitToOffice_Btn.IdleBorderThickness = 1
        Me.submitToOffice_Btn.IdleCornerRadius = 20
        Me.submitToOffice_Btn.IdleFillColor = System.Drawing.Color.DarkViolet
        Me.submitToOffice_Btn.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight
        Me.submitToOffice_Btn.IdleLineColor = System.Drawing.Color.DarkViolet
        Me.submitToOffice_Btn.Location = New System.Drawing.Point(447, 295)
        Me.submitToOffice_Btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.submitToOffice_Btn.Name = "submitToOffice_Btn"
        Me.submitToOffice_Btn.Size = New System.Drawing.Size(91, 43)
        Me.submitToOffice_Btn.TabIndex = 3
        Me.submitToOffice_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(21, 79)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(259, 24)
        Me.TextBox2.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 154)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Short Description"
        '
        'exit_Btn
        '
        Me.exit_Btn.ActiveBorderThickness = 1
        Me.exit_Btn.ActiveCornerRadius = 20
        Me.exit_Btn.ActiveFillColor = System.Drawing.SystemColors.ButtonFace
        Me.exit_Btn.ActiveForecolor = System.Drawing.Color.DarkViolet
        Me.exit_Btn.ActiveLineColor = System.Drawing.Color.MediumPurple
        Me.exit_Btn.BackColor = System.Drawing.SystemColors.Control
        Me.exit_Btn.BackgroundImage = CType(resources.GetObject("exit_Btn.BackgroundImage"), System.Drawing.Image)
        Me.exit_Btn.ButtonText = "Back to Home"
        Me.exit_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exit_Btn.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_Btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.exit_Btn.IdleBorderThickness = 1
        Me.exit_Btn.IdleCornerRadius = 20
        Me.exit_Btn.IdleFillColor = System.Drawing.Color.DarkViolet
        Me.exit_Btn.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight
        Me.exit_Btn.IdleLineColor = System.Drawing.Color.DarkViolet
        Me.exit_Btn.Location = New System.Drawing.Point(13, 183)
        Me.exit_Btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.exit_Btn.Name = "exit_Btn"
        Me.exit_Btn.Size = New System.Drawing.Size(109, 43)
        Me.exit_Btn.TabIndex = 3
        Me.exit_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'viewStatus_Panel
        '
        Me.viewStatus_Panel.Controls.Add(Me.Panel2)
        Me.viewStatus_Panel.Controls.Add(Me.BunifuThinButton21)
        Me.viewStatus_Panel.Controls.Add(Me.TextBox9)
        Me.viewStatus_Panel.Controls.Add(Me.Label17)
        Me.viewStatus_Panel.Controls.Add(Me.Label18)
        Me.viewStatus_Panel.Location = New System.Drawing.Point(132, 95)
        Me.viewStatus_Panel.Name = "viewStatus_Panel"
        Me.viewStatus_Panel.Size = New System.Drawing.Size(608, 378)
        Me.viewStatus_Panel.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.BunifuThinButton22)
        Me.Panel2.Controls.Add(Me.TextBox7)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.TextBox6)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.TextBox8)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Location = New System.Drawing.Point(72, 87)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(502, 196)
        Me.Panel2.TabIndex = 9
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "See Status"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.DarkViolet
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.DarkViolet
        Me.BunifuThinButton22.Location = New System.Drawing.Point(405, 13)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(85, 42)
        Me.BunifuThinButton22.TabIndex = 8
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(70, 35)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(310, 20)
        Me.TextBox7.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(32, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 16)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Title"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(70, 97)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(310, 85)
        Me.TextBox1.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 16)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Author"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(70, 65)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(310, 19)
        Me.TextBox6.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(23, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 16)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Status"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(70, 6)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(310, 20)
        Me.TextBox8.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 16)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Remarks"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.MediumPurple
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Enter"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.DarkViolet
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.SystemColors.ButtonHighlight
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkViolet
        Me.BunifuThinButton21.Location = New System.Drawing.Point(477, 50)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(85, 42)
        Me.BunifuThinButton21.TabIndex = 7
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(144, 61)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(310, 20)
        Me.TextBox9.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(32, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 16)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Tracking number"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(13, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(273, 27)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "View Status of Submission"
        '
        'ThesisTableAdapter1
        '
        Me.ThesisTableAdapter1.ClearBeforeFill = True
        '
        'SubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 463)
        Me.Controls.Add(Me.exit_Btn)
        Me.Controls.Add(Me.status_btn)
        Me.Controls.Add(Me.submit_Btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.submit_Panel)
        Me.Controls.Add(Me.viewStatus_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SubmissionForm"
        Me.Text = "SubmissionForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.submit_Panel.ResumeLayout(False)
        Me.submit_Panel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.viewStatus_Panel.ResumeLayout(False)
        Me.viewStatus_Panel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents submit_Btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents status_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents attach_Btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents submit_Panel As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents submitToOffice_Btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents exit_Btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents viewStatus_Panel As Panel
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ThesisTableAdapter1 As Database1DataSetTableAdapters.ThesisTableAdapter
End Class
