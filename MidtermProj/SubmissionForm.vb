Imports System.IO
Public Class SubmissionForm
    Private Sub attach_Click(sender As Object, e As EventArgs) Handles attach_Btn.Click
        Try
            OpenFileDialog1.Filter = "PDF Files |*.pdf"
            OpenFileDialog1.ShowDialog()
            Label6.Text = OpenFileDialog1.SafeFileName
            Label6.Visible = True
        Catch ex As Exception
            MsgBox("Error detected. Try again.")
        End Try
    End Sub

    Private Sub exit_Btn_Click(sender As Object, e As EventArgs) Handles exit_Btn.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub submit_Btn_Click(sender As Object, e As EventArgs) Handles submit_Btn.Click
        submit_Panel.Visible = True
        viewStatus_Panel.Visible = False
        Label6.Visible = False
    End Sub

    Private Sub SubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        submit_Panel.Visible = False
        viewStatus_Panel.Visible = False
    End Sub

    Private Sub status_btn_Click(sender As Object, e As EventArgs) Handles status_btn.Click
        viewStatus_Panel.Visible = True
        submit_Panel.Visible = False

    End Sub

    Private Sub submitToOffice_Btn_Click(sender As Object, e As EventArgs) Handles submitToOffice_Btn.Click
        Dim filelocation As String
        Dim pdffile, pdffilename, fullpath, destination, received As String
        Try
            pdffile = Path.GetDirectoryName(OpenFileDialog1.FileName)
            pdffilename = Path.GetFileName(OpenFileDialog1.FileName)
            fullpath = pdffile & "\" & pdffilename
            'received = "Received by " & TextBox1.Text
            'destination = "C:\Users\Maya Asuero\source\repos\MidtermProj\MidtermProj\MidtermProj\bin\DirectorFiles\Pending\" & pdffilename 'e change lang ni kung asa nimo e butang
            'forReview = forReview & pdffilename & " submitted by " & TextBox2.Text & "." & vbCrLf & "(fileName: " & pdffilename & ")" & vbCrLf & vbCrLf

            Dim newname As String = destination & " (" & received & ").pdf"
            Dim id As Integer = CInt(ThesisTableAdapter1.countThesis()) + 1
            Dim finalID As String = id & Date.Today.Year

            If File.Exists(fullpath) And Not File.Exists(destination) Then
                '    File.Copy(fullpath, destination)
                '    File.Move(destination, newname)
                '    File.Delete(fullpath)
                'ADD INSERT

                Dim fs As FileStream
                fs = New FileStream(fullpath, FileMode.Open, FileAccess.Read)
                Dim docByte As Byte() = New Byte(fs.Length - 1) {}
                fs.Read(docByte, 0, System.Convert.ToInt32(fs.Length))
                fs.Close()

                If ThesisTableAdapter1.insertNewThesis(CInt(finalID), TextBox2.Text, CInt(TextBox3.Text), TextBox4.Text, DateTimePicker2.Value.ToShortDateString, TextBox1.Text, TextBox5.Text, "Pending", fs, pdffilename) = 1 Then
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
        Catch ex As Exception
            MsgBox("Error detected. Try again.")
        End Try
    End Sub
End Class