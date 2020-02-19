Option Strict On
Imports System.IO
Public Class Form2
    Dim filelocation As String
    Dim pdffile, pdffilename, fullpath, destination, received As String
    Public feedbacksList As String = ""
    Public nextAvailable As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim oForm As Login
        'oForm = New Login()
        Login.Show()
        'oForm = Nothing
        Me.Close()
        TextBox5.Text = ""
        TextBox2.Text = ""
        pdffilename = ""
        TextBox4.Text = ""
        TextBox3.Text = ""
    End Sub


    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        Label7.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles feedback_btn.Click
        Panel4.Visible = True
        Panel2.Visible = False
        'TextBox6.Text = Form3.notApproved
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FeedbackTableAdapter.Fill(Me.Database1DataSet.Feedback)
        Me.Visible = True
        Me.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel3.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles receive_btn.Click
        Panel4.Visible = False
        Panel2.Visible = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

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
        destination = "D:\downloads\MidtermProj\MidtermProj\MidtermProj\bin\DirectorFiles\Pending" & pdffilename 'e change lang ni kung asa nimo e butang
        'forReview = forReview & pdffilename & " submitted by " & TextBox2.Text & "." & vbCrLf & "(fileName: " & pdffilename & ")" & vbCrLf & vbCrLf

        If received.Length < 15 Then
            MsgBox("add receiver")
            Return
        End If

        Dim newname As String = destination & " (" & received & ") "

        If File.Exists(fullpath) And Not File.Exists(destination) Then
            File.Copy(fullpath, destination)

            If File.Exists(destination) And Not File.Exists(newname) Then
                File.Move(destination, newname)
                'FIX: to add thesis
                Dim idNum As Integer = Convert.ToInt32(Me.ThesisTableAdapter.countThesis()) + 1
                'Form3.thesislist(nextAvailable) = newThesis
                'Form3.reviewList.Items.Add(TextBox5.Text)

                nextAvailable += 1
                MsgBox("File successfully added!")

                TextBox5.Text = ""
                TextBox2.Text = ""
                pdffilename = ""
                TextBox4.Text = ""
                TextBox3.Text = ""
            Else
                MsgBox("File already uploaded")
            End If

        Else
            MsgBox("Can't upload file. Duplicate file detected.")

        End If

        'My.Computer.Network.DownloadFile(fullpath, "C:\Users\admiral\source\repos\MidtermProj\MidtermProj\bin\downloadfiles")
    End Sub
End Class