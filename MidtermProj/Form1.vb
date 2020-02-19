Public Class Login


    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(8)
        If ProgressBar1.Value = 8 Then
            Label4.Visible = True
        End If
        If ProgressBar1.Value = 40 Then
            Label4.Visible = False
            Label5.Visible = True
        End If
        If ProgressBar1.Value = 80 Then
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = True
        End If
        If ProgressBar1.Value = 100 Then
            If Me.TableTableAdapter.getPosition1(TextBox1.Text, TextBox2.Text).ToString() = "staff" Then
                Timer1.Stop()
                Me.Hide()
                Form2.Show()
                Label6.Visible = False
                ProgressBar1.Visible = False
                TextBox1.Text = ""
                TextBox2.Text = ""

            ElseIf Me.TableTableAdapter.getPosition1(TextBox1.Text, TextBox2.Text).ToString() = "director" Then
                Timer1.Stop()
                Me.Hide()
                Form3.Show()
                Label6.Visible = False
                ProgressBar1.Visible = False
                TextBox1.Text = ""
                TextBox2.Text = ""
            Else
                MsgBox("Can't run")
            End If
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.Database1DataSet.Table)
        Me.Show()
        ProgressBar1.Visible = False

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.TableTableAdapter.login(TextBox1.Text, TextBox2.Text) = 1 Then
            Dim res As Object = Me.TableTableAdapter.getPosition1(TextBox1.Text, TextBox2.Text)
            If res.ToString() = "Staff" Then
                ProgressBar1.Visible = False
                ProgressBar1.Visible = True
                Timer1.Start()
                SendMessage(ProgressBar1.Handle, 1040, 3, 100)



            ElseIf res.ToString() = "Director" Then
                ProgressBar1.Visible = False
                ProgressBar1.Visible = True
                Timer1.Start()
                SendMessage(ProgressBar1.Handle, 1040, 3, 100)



            Else
                MsgBox("Select a Position")
            End If
        End If
    End Sub
End Class
