Public Class Form3

    Public thesislist(5) As Object
    Public approved As String = ""
    Public notApproved As String = ""
    Private pointer As Integer

    Private Sub toReview_Click(sender As Object, e As EventArgs) Handles toReview.Click
        welcomePanel.Visible = False
        forReviewPanel.Visible = True
        collectionPanel.Visible = False
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        welcomePanel.Visible = True
        forReviewPanel.Visible = False
        collectionPanel.Visible = False

    End Sub

    Private Sub collection_Click(sender As Object, e As EventArgs) Handles collection.Click
        approvedlist.Text = approved
        welcomePanel.Visible = False
        collectionPanel.Visible = True
        forReviewPanel.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Hide()
        welcomePanel.Visible = True
        forReviewPanel.Visible = False
        collectionPanel.Visible = False
    End Sub


    Private Sub selectThesis_Click(sender As Object, e As EventArgs) Handles selectThesis.Click
        For i = 0 To 5
            If reviewList.SelectedItem = thesislist(i).title Then
                viewAuthor.Text = thesislist(i).author
                viewTitle.Text = thesislist(i).title
                viewDescription.Text = thesislist(i).description
                pointer = i
                Exit For
            End If
        Next i

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles approve.Click
        approved = approved & "Title: " & thesislist(pointer).title & vbCrLf & "Author: " & thesislist(pointer).author & vbCrLf & "Description: " & thesislist(pointer).description & vbCrLf & "File name: " & thesislist(pointer).file & vbCrLf & vbCrLf
        MessageBox.Show(thesislist(pointer).Title & " has been approved.")
        viewAuthor.Text = ""
        viewTitle.Text = ""
        viewDescription.Text = ""
        thesislist(pointer) = Nothing
        reviewList.Items.RemoveAt(pointer)
        fillIn()
        reviewList.Text = ""
    End Sub

    Private Sub fillIn()
        For i = pointer To 4
            thesislist(i) = thesislist(i + 1)
        Next
        thesislist(5) = Nothing
    End Sub

    Private Sub reject_Click(sender As Object, e As EventArgs) Handles reject.Click
        notApproved = notApproved & "Status: Rejected" & vbCrLf & "Title: " & thesislist(pointer).title & vbCrLf & "Author: " & thesislist(pointer).author & vbCrLf & "Description: " & thesislist(pointer).description & vbCrLf & "File name: " & thesislist(pointer).file & vbCrLf & vbCrLf
        MessageBox.Show(thesislist(pointer).Title & " has been rejected.")
        viewAuthor.Text = ""
        viewTitle.Text = ""
        viewDescription.Text = ""
        thesislist(pointer) = Nothing
        reviewList.Items.RemoveAt(pointer)
        fillIn()
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
        fillIn()
        reviewList.Text = ""
    End Sub
End Class