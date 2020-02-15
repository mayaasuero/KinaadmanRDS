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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.menu = New System.Windows.Forms.Panel()
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
        Me.forRevLabel = New System.Windows.Forms.Label()
        Me.collectionPanel = New System.Windows.Forms.Panel()
        Me.approvedlist = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.menu.SuspendLayout()
        Me.forReviewPanel.SuspendLayout()
        Me.collectionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu
        '
        Me.menu.BackColor = System.Drawing.SystemColors.Control
        Me.menu.BackgroundImage = CType(resources.GetObject("menu.BackgroundImage"), System.Drawing.Image)
        Me.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menu.Controls.Add(Me.Button1)
        Me.menu.Controls.Add(Me.Panel2)
        Me.menu.Controls.Add(Me.collection)
        Me.menu.Controls.Add(Me.toReview)
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(168, 369)
        Me.menu.TabIndex = 0
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
        Me.collection.Location = New System.Drawing.Point(37, 175)
        Me.collection.Name = "collection"
        Me.collection.Size = New System.Drawing.Size(75, 23)
        Me.collection.TabIndex = 1
        Me.collection.Text = "Collection"
        Me.collection.UseVisualStyleBackColor = True
        '
        'toReview
        '
        Me.toReview.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.toReview.Location = New System.Drawing.Point(37, 146)
        Me.toReview.Name = "toReview"
        Me.toReview.Size = New System.Drawing.Size(75, 23)
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
        Me.reviewList.FormattingEnabled = True
        Me.reviewList.Location = New System.Drawing.Point(184, 90)
        Me.reviewList.Name = "reviewList"
        Me.reviewList.Size = New System.Drawing.Size(310, 21)
        Me.reviewList.TabIndex = 2
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
        Me.collectionPanel.Controls.Add(Me.approvedlist)
        Me.collectionPanel.Controls.Add(Me.Label6)
        Me.collectionPanel.Location = New System.Drawing.Point(174, 3)
        Me.collectionPanel.Name = "collectionPanel"
        Me.collectionPanel.Size = New System.Drawing.Size(624, 363)
        Me.collectionPanel.TabIndex = 7
        '
        'approvedlist
        '
        Me.approvedlist.Location = New System.Drawing.Point(35, 87)
        Me.approvedlist.Multiline = True
        Me.approvedlist.Name = "approvedlist"
        Me.approvedlist.Size = New System.Drawing.Size(554, 240)
        Me.approvedlist.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(281, 39)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Approved Thesis"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 366)
        Me.Controls.Add(Me.forReviewPanel)
        Me.Controls.Add(Me.welcomePanel)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.collectionPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.Text = "Kinaadman University Research Office (Director)"
        Me.menu.ResumeLayout(False)
        Me.forReviewPanel.ResumeLayout(False)
        Me.forReviewPanel.PerformLayout()
        Me.collectionPanel.ResumeLayout(False)
        Me.collectionPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents menu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents collection As Button
    Friend WithEvents toReview As Button
    Friend WithEvents welcomePanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents forReviewPanel As Panel
    Friend WithEvents forRevLabel As Label
    Friend WithEvents viewAuthor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents reviewList As ComboBox
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
    Friend WithEvents approvedlist As TextBox
    Friend WithEvents Label6 As Label
End Class
