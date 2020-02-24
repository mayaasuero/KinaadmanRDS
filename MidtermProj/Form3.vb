Imports System.IO
Public Class Form3
    Dim nameToUpdate As String = ""
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

        Dim newFeedbackAdapter As New Database1DataSetTableAdapters.ThesisTableAdapter
        Dim newFeedbackDataset As New Database1DataSet.ThesisDataTable
        newFeedbackDataset = newFeedbackAdapter.getThesisTitleBasedOnStatus("Pending")
        reviewList.DataSource = newFeedbackDataset
        reviewList.Update()
    End Sub

    Private Sub collection_Click(sender As Object, e As EventArgs) Handles collection.Click
        welcomePanel.Visible = False
        collectionPanel.Visible = True
        forReviewPanel.Visible = False

        Dim newFeedbackAdapter As New Database1DataSetTableAdapters.ThesisTableAdapter
        Dim newFeedbackDataset As New Database1DataSet.ThesisDataTable
        newFeedbackDataset = newFeedbackAdapter.getThesisTitleBasedOnStatus("Approved")
        approvedThesis.DataSource = newFeedbackDataset
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
        viewAuthor.Text = ThesisTableAdapter1.getAuthor(key)
        viewTitle.Text = ThesisTableAdapter1.getThesisTitle(key)
        viewDescription.Text = ThesisTableAdapter1.getDescription(key)
    End Sub


    'TO FIX: key not refering to SeletedValue
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles approve.Click

        Dim key As String = reviewList.SelectedValue
        Dim feedbackID As Integer = Me.ThesisTableAdapter1.selectThesisID(key) & Int(Date.Today.Month)
        Me.ThesisTableAdapter1.UpdateStatus("Approved", key)
        Me.ThesisTableAdapter1.Fill(Me.Database1DataSet.Thesis)
        Me.FeedbackTableAdapter.insertFeedback(feedbackID, Me.ThesisTableAdapter1.selectThesisID(key), Me.ThesisTableAdapter1.getThesisTitle(key), Me.ThesisTableAdapter1.getAuthor(key), TextBox1.Text, Me.ThesisTableAdapter1.getStatus(key))
        MsgBox(ThesisTableAdapter1.getThesisTitle(key) & " has been approved.")
        viewAuthor.Text = ""
        viewDescription.Text = ""
        viewAuthor.Text = ""
        TextBox1.Text = ""
        viewTitle.ResetText()
        Dim newFeedbackAdapter As New Database1DataSetTableAdapters.ThesisTableAdapter
        Dim newDataset As New Database1DataSet.ThesisDataTable
        newDataset = newFeedbackAdapter.getThesisTitleBasedOnStatus("Pending")
        reviewList.DataSource = newDataset
        reviewList.Update()
    End Sub

    Private Sub reject_Click(sender As Object, e As EventArgs) Handles reject.Click
        Dim key As String = reviewList.SelectedValue
        Dim feedbackID As Integer = Me.ThesisTableAdapter1.selectThesisID(key) & Int(Date.Today.Month)
        Me.ThesisTableAdapter1.UpdateStatus("Rejected", key)
        Me.ThesisTableAdapter1.Fill(Me.Database1DataSet.Thesis)
        Me.FeedbackTableAdapter.insertFeedback(feedbackID, Me.ThesisTableAdapter1.selectThesisID(key), Me.ThesisTableAdapter1.getThesisTitle(key), Me.ThesisTableAdapter1.getAuthor(key), TextBox1.Text, Me.ThesisTableAdapter1.getStatus(key))
        MsgBox(ThesisTableAdapter1.getThesisTitle(key) & " has been rejected.")
        viewAuthor.Text = ""
        viewDescription.Text = ""
        viewAuthor.Text = ""
        TextBox1.Text = ""
        viewTitle.ResetText()
        Dim newFeedbackAdapter As New Database1DataSetTableAdapters.ThesisTableAdapter
        Dim newDataset As New Database1DataSet.ThesisDataTable
        newDataset = newFeedbackAdapter.getThesisTitleBasedOnStatus("Pending")
        reviewList.DataSource = newDataset
        reviewList.Update()
    End Sub

    Private Sub addStaff_btn_Click(sender As Object, e As EventArgs) Handles manageUsers.Click
        manageUsers_Panel.Visible = True
        welcomePanel.Visible = False
        collectionPanel.Visible = False
        forReviewPanel.Visible = False

        Dim newTableAdapter As New Database1DataSetTableAdapters.TableTableAdapter
        Dim newDataset As New Database1DataSet.TableDataTable
        newDataset = newTableAdapter.getStaffList("Staff")
        usersDataGrid.DataSource = newDataset
        usersDataGrid.Update()
    End Sub

    Private Sub addUser_Btn_Click(sender As Object, e As EventArgs) Handles addUser_Btn.Click
        If newPassword.Text = retypeNewPassword.Text And Me.TableTableAdapter.findUsername(newUsername.Text) = 0 Then
            Me.TableTableAdapter.insertNewUser(newUsername.Text, newPassword.Text, newPosition.Text, enableAccess.Text)
            MsgBox("User successfully added.")
            newUsername.Text = ""
            newPassword.Text = ""
            retypeNewPassword.Text = ""
            newPosition.ResetText()
            enableAccess.ResetText()
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
            enableAccess.ResetText()
            usersDataGrid.Update()
        End If

    End Sub

    'wala pa ni nahuman
    Private Sub updateUser_btn_Click(sender As Object, e As EventArgs) Handles updateUser.Click
        If usersDataGrid.SelectedRows.Count > 0 Then
            If TableTableAdapter.checkEnabled(nameToUpdate) = "Enabled" Then
                Me.TableTableAdapter.changedIsEnabled("Disabled", nameToUpdate)
                MsgBox("User " & nameToUpdate & " has been enabled access.")
            Else
                Me.TableTableAdapter.changedIsEnabled("Enabled", nameToUpdate)
                MsgBox("User " & nameToUpdate & " has been disabled access.")
            End If

            Dim newTableAdapter As New Database1DataSetTableAdapters.TableTableAdapter
            Dim newDataset As New Database1DataSet.TableDataTable
            newDataset = newTableAdapter.getStaffList("Staff")
            usersDataGrid.DataSource = newDataset
            usersDataGrid.Update()
        Else
            MessageBox.Show("No selected user to delete.")
        End If
        nameToUpdate = ""
    End Sub

    Private Sub openFile_Click(sender As Object, e As EventArgs) Handles openFile.Click
        Dim openThisPath As String = ThesisTableAdapter1.getFilePath(ThesisTableAdapter1.selectThesisID(reviewList.SelectedValue))
        If File.Exists(openThisPath) Then
            Process.Start(openThisPath)
        End If
    End Sub

    Private Sub usersDataGrid_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles usersDataGrid.RowHeaderMouseDoubleClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow = usersDataGrid.Rows(index)
        nameToUpdate = selectedRow.Cells(0).Value.ToString
    End Sub
End Class