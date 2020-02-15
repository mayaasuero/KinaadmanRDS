Friend Class Thesis
    Public title As String
    Public author As String
    Public file As String
    Public year As Integer
    Public description As String

    Public Sub createThesis(t As String, a As String, f As String, d As String, y As Integer)
        title = t
        author = a
        file = f
        year = y
        description = d
    End Sub
End Class
