Public Class Item
    Public Code As String 'A1, B2, C2, C3    made with 2 char
    Public Title As String
    Public Price As Single
    Public Sub New(ByVal code As String, ByVal title As String, ByVal price As Single)
        Me.Code = code
        Me.Title = title
        Me.Price = price
    End Sub
End Class
