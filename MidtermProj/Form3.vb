Public Class Form3

    Public thesislist(5) As Object
    Public approved As String = ""
    Public notApproved As String = ""
    Private pointer As Integer

    Private Sub toReview_Click(sender As Object, e As EventArgs) Handles toReview.Click
        welcomePanel.Visible = False
        forReviewPanel.Visible = True
        manageUsers_Panel.Visible = False
        collectionPanel.Visible = False
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Feedback' table. You can move, or remove it, as needed.
        Me.FeedbackTableAdapter.Fill(Me.Database1DataSet.Feedback)
        'TODO: This line of code loads data into the 'Database1DataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.Database1DataSet.Table)
        Me.ThesisTableAdapter1.Fill(Me.Database1DataSet.Thesis)
        welcomePanel.Visible = True
        forReviewPanel.Visible = False
        collectionPanel.Visible = False
        manageUsers_Panel.Visible = False
    End Sub

    Private Sub collection_Click(sender As Object, e As EventArgs) Handles collection.Click
        welcomePanel.Visible = False

        collectionPanel.Visible = True
        forReviewPanel.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Hide()
        manageUsers_Panel.Visible = False
        welcomePanel.Visible = True
        forReviewPanel.Visible = False
        collectionPanel.Visible = False
    End Sub


    Private Sub selectThesis_Click(sender As Object, e As EventArgs) Handles selectThesis.Click
        Dim key As String = reviewList.SelectedValue
        MsgBox(key)
        viewAuthor.Text = ThesisTableAdapter1.getAuthor(key)
        viewTitle.Text = ThesisTableAdapter1.getThesisTitle(key)
        viewDescription.Text = ThesisTableAdapter1.getDescription(key)
        Me.ThesisTableAdapter1.Fill(Me.Database1DataSet.Thesis)
    End Sub


    'TO FIX: key not refering to SeletedValue
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles approve.Click
        'Try
        Dim key As String = reviewList.SelectedValue
        Dim feedbackID As Integer = Me.ThesisTableAdapter1.selectThesisID(key) & Int(Date.Today.Year)
        Me.ThesisTableAdapter1.UpdateStatus("Approved", key)
        MsgBox(key & " " & feedbackID)
        Me.ThesisTableAdapter1.Fill(Me.Database1DataSet.Thesis)
        Me.FeedbackTableAdapter.insertFeedback(feedbackID, Me.ThesisTableAdapter1.selectThesisID(key), Me.ThesisTableAdapter1.getThesisTitle(key), Me.ThesisTableAdapter1.getAuthor(key), TextBox1.Text, Me.ThesisTableAdapter1.getStatus(key))
        MsgBox(ThesisTableAdapter1.selectThesisID(key) & " has been approved.")
        'Catch ex As Exception
        'MsgBox("Error found.")
        'End Try

    End Sub

    Private Sub reject_Click(sender As Object, e As EventArgs) Handles reject.Click
        notApproved = notApproved & "Status: Rejected" & vbCrLf & "Title: " & thesislist(pointer).title & vbCrLf & "Author: " & thesislist(pointer).author & vbCrLf & "Description: " & thesislist(pointer).description & vbCrLf & "File name: " & thesislist(pointer).file & vbCrLf & vbCrLf
        MessageBox.Show(thesislist(pointer).Title & " has been rejected.")
        viewAuthor.Text = ""
        viewTitle.Text = ""
        viewDescription.Text = ""
        thesislist(pointer) = Nothing
        reviewList.Items.RemoveAt(pointer)
        'fillIn()
        reviewList.Text = ""
    End Sub

    Private Sub pending_Click(sender As Object, e As EventArgs) Handles pending.Click
        notApproved = notApproved & "Status: Pending" & vbCrLf & "Title: " & thesislist(pointer).title & vbCrLf & "Author: " & thesislist(pointer).author & vbCrLf & "Description: " & thesislist(pointer).description & vbCrLf & "File name: " & thesislist(pointer).file & vbCrLf & vbCrLf
        MessageBox.Show(thesislist(pointer).Title & " has been classified as pending.")
        viewAuthor.Text = ""
        viewTitle.Text = ""
        viewDescription.Text = ""
        thesislist(pointer) = Nothing
        reviewList.Items.RemoveAt(pointer)
        'fillIn()
        reviewList.Text = ""
    End Sub

    Private Sub addStaff_btn_Click(sender As Object, e As EventArgs) Handles manageUsers.Click
        manageUsers_Panel.Visible = True
        welcomePanel.Visible = False
        collectionPanel.Visible = False
        forReviewPanel.Visible = False

    End Sub

    Private Sub addUser_Btn_Click(sender As Object, e As EventArgs) Handles addUser_Btn.Click
        If newPassword.Text = retypeNewPassword.Text And Me.TableTableAdapter.findUsername(newUsername.Text) = 0 Then
            Me.TableTableAdapter.insertNewUser(newUsername.Text, newPassword.Text, newPosition.Text)
            MsgBox("User successfully added.")
            newUsername.Text = ""
            newPassword.Text = ""
            retypeNewPassword.Text = ""
            newPosition.ResetText()
            usersDataGrid.Update()
            Me.TableTableAdapter.Fill(Me.Database1DataSet.Table)

        ElseIf Not newPassword.Text = retypeNewPassword.Text Then
            MsgBox("Passwords do not match. Try again.")
            newPassword.Text = ""
            retypeNewPassword.Text = ""
        Else
            MsgBox("User already exists.")
            newUsername.Text = ""
            newPassword.Text = ""
            retypeNewPassword.Text = ""
            newPosition.ResetText()

        End If

    End Sub

    'wala pa ni nahuman
    Private Sub deleteUser_btn_Click(sender As Object, e As EventArgs) Handles deleteUser_btn.Click
        If usersDataGrid.SelectedRows.Count > 0 Then
            usersDataGrid.Update()
        Else
            MessageBox.Show("No selected user.")
        End If
        'Me.TableTableAdapter.DeleteQuery(usersDataGridView.Select())
    End Sub
End Class