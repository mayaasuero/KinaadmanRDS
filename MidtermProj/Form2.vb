Option Strict On
Imports System.IO
Imports System.Data.SqlClient
Public Class Form2

    Dim filelocation As String
    Dim pdffile, pdffilename, fullpath, destination, received As String
    Public feedbacksList As String = ""
    Public nextAvailable As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles home_btn.Click
        Login.Show()
        Me.Close()
        TextBox5.Text = ""
        TextBox2.Text = ""
        pdffilename = ""
        TextBox4.Text = ""
        TextBox3.Text = ""
        Login.user = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles feedback_btn.Click
        Panel4.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FeedbackTableAdapter.Fill(Me.Database1DataSet.Feedback)
        Panel4.Visible = True
        Me.Visible = True
        TextBox1.Text = Login.user
        Timer1.Start()
        Me.Show()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        feedbackDataGrid.DataSource = Me.FeedbackTableAdapter.Fill(Me.Database1DataSet.Feedback)
        feedbackDataGrid.Update()
        searchBox.Text = ""
        filterComboBox.ResetText()
    End Sub

    Private Sub search_Btn_Click(sender As Object, e As EventArgs) Handles search_Btn.Click
        Dim DV As New DataView(Me.Database1DataSet.Feedback)
        Try
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

        Catch ex As Exception
            MsgBox("Search value not valid. Please try again.")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles addInfo_btn.Click
        AxAcroPDF1.Visible = False
        Panel3.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles receive_btn.Click
        Panel4.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles attach_btn.Click
        Try
            Panel3.Visible = False
            AxAcroPDF1.Visible = True
            OpenFileDialog1.Filter = "PDF Files |*.pdf"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                AxAcroPDF1.src = OpenFileDialog1.FileName
            End If

        Catch ex As Exception
            MsgBox("Error detected. Try again.")
        End Try

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles sendToDirector_Btn.Click
        If CheckBox1.CheckState = 1 Then
            Try
                pdffile = Path.GetDirectoryName(OpenFileDialog1.FileName)
                pdffilename = Path.GetFileName(OpenFileDialog1.FileName)
                fullpath = pdffile & "\" & pdffilename

                Dim newname As String = destination & " (" & received & ").pdf"
                Dim id As Integer = CInt(ThesisTableAdapter.countThesis()) + 1
                Dim finalID As String = id & Date.Today.Year

                Dim fs As FileStream
                fs = New FileStream(fullpath, FileMode.Open, FileAccess.Read)
                Dim docByte As Byte() = New Byte(CInt(fs.Length - 1)) {}
                fs.Read(docByte, 0, System.Convert.ToInt32(fs.Length))
                fs.Close()

                If CInt(Me.ThesisTableAdapter.findExistingFile(docByte)) = 0 And ThesisTableAdapter.insertNewThesis(CInt(finalID), TextBox2.Text, CInt(TextBox3.Text), TextBox4.Text, DateTimePicker1.Value.ToShortDateString, TextBox1.Text, TextBox5.Text, "Pending", docByte, pdffilename) = 1 Then
                    MsgBox("File successfully added!")
                    TextBox5.Text = ""
                    TextBox2.Text = ""
                    pdffilename = ""
                    TextBox4.Text = ""
                    TextBox3.Text = ""
                    CheckBox1.CheckState = 0
                Else
                    MsgBox("File not uploaded. Make sure it is not a duplicate submission.")
                End If

                TextBox5.Text = ""
                TextBox2.Text = ""
                pdffilename = ""
                TextBox4.Text = ""
                TextBox3.Text = ""

            Catch ex As Exception
                MsgBox("Error detected. Try again.")
            End Try

            'My.Computer.Network.DownloadFile(fullpath, "C:\Users\admiral\source\repos\MidtermProj\MidtermProj\bin\downloadfiles")
        Else
            MsgBox("Please check the certification.")
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub
End Class