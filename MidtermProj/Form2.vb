Option Strict On
Imports System.IO
Imports System.Data.SqlClient
Public Class Form2
    Dim filelocation As String
    Dim pdffile, pdffilename, fullpath, destination, received As String
    Public feedbacksList As String = ""
    Public nextAvailable As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Close()
        TextBox5.Text = ""
        TextBox2.Text = ""
        pdffilename = ""
        TextBox4.Text = ""
        TextBox3.Text = ""
        Login.user = ""
    End Sub


    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        Label7.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles feedback_btn.Click
        Panel4.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FeedbackTableAdapter.Fill(Me.Database1DataSet.Feedback)
        Me.Visible = True
        TextBox1.Text = Login.user
        Me.Show()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        feedbackDataGrid.DataSource = Me.FeedbackTableAdapter.Fill(Me.Database1DataSet.Feedback)
        feedbackDataGrid.Update()
        searchBox.Text = ""
        filterComboBox.ResetText()
    End Sub

    Private Sub search_Btn_Click(sender As Object, e As EventArgs) Handles search_Btn.Click
        Dim DV As New DataView(Me.Database1DataSet.Feedback)
        If filterComboBox.Text = "Title" Then
            DV.RowFilter = String.Format("title Like '%{0}%'", searchBox.Text)
            feedbackDataGrid.DataSource = DV
            feedbackDataGrid.Update()
        ElseIf filterComboBox.Text = "Thesis ID" Then
            DV.RowFilter = String.Format("Convert(thesisNumber,'System.String') Like '%{0}%'", searchBox.Text)
            feedbackDataGrid.DataSource = DV
            feedbackDataGrid.Update()
        ElseIf filterComboBox.Text = "Author" Then
            DV.RowFilter = String.Format("authors Like '%{0}%'", searchBox.Text)
            feedbackDataGrid.DataSource = DV
            feedbackDataGrid.Update()
        ElseIf filterComboBox.Text = "Status" Then
            DV.RowFilter = String.Format("status Like '%{0}%'", searchBox.Text)
            feedbackDataGrid.DataSource = DV
            feedbackDataGrid.Update()
        Else
            MsgBox("Please select filter to narrow search.")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AxAcroPDF1.Visible = False
        Panel3.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles receive_btn.Click
        Panel4.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel3.Visible = False
        AxAcroPDF1.Visible = True
        OpenFileDialog1.Filter = "PDF Files |*.pdf"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            AxAcroPDF1.src = OpenFileDialog1.FileName


        End If

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pdffile = Path.GetDirectoryName(OpenFileDialog1.FileName)
        pdffilename = Path.GetFileName(OpenFileDialog1.FileName)
        fullpath = pdffile & "\" & pdffilename
        received = "Received by " & TextBox1.Text
        destination = "C:\Users\Maya Asuero\source\repos\MidtermProj\MidtermProj\MidtermProj\bin\DirectorFiles\Pending\" & pdffilename 'e change lang ni kung asa nimo e butang
        'forReview = forReview & pdffilename & " submitted by " & TextBox2.Text & "." & vbCrLf & "(fileName: " & pdffilename & ")" & vbCrLf & vbCrLf

        Dim newname As String = destination & " (" & received & ").pdf"
        Dim id As Integer = CInt(ThesisTableAdapter.countThesis()) + 1
        Dim finalID As String = id & Date.Today.Year

        If File.Exists(fullpath) And Not File.Exists(destination) Then
            File.Copy(fullpath, destination)
            File.Move(destination, newname)
            File.Delete(fullpath)
            'ADD INSERT
            If ThesisTableAdapter.insertNewThesis(CInt(finalID), TextBox2.Text, CInt(TextBox3.Text), TextBox4.Text, DateTimePicker1.Value.ToShortDateString, TextBox1.Text, TextBox5.Text, "Pending", newname) = 1 Then
                MsgBox("File successfully added!")
            Else
                MsgBox("Not uploaded.")
            End If

            TextBox5.Text = ""
            TextBox2.Text = ""
            pdffilename = ""
            TextBox4.Text = ""
            TextBox3.Text = ""
        Else
            MsgBox("Can't upload file. Duplicate file detected.")

        End If

        'My.Computer.Network.DownloadFile(fullpath, "C:\Users\admiral\source\repos\MidtermProj\MidtermProj\bin\downloadfiles")
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged


    End Sub
End Class