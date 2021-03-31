Public Class Item
    Public Code As String 'A1, B2, C2, C3    made with 2 char
    Public Title As String
    Public Price As Single
    Public Amount As Int16
    Public Sub New(ByVal _code As String, ByVal _title As String, ByVal _price As Single)
        Me.Code = _code
        Me.Title = _title
        Me.Price = _price
        Me.Amount = 5
    End Sub
    Public Sub Reset(ByVal _price As Single, ByVal _amount As Int16)
        Me.Price = _price
        Me.Amount = _amount
    End Sub
End Class
