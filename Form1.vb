Public Class Form1
    Public sngBalance As Single = 0.0
    Public dOrderAmount As Double = 0.0
    Public sOrderCode As String = ""
    Public OrderHistory As New List(Of Order)
    Public Items As New List(Of Item)
    Public Items2(4, 4) As Item
    Public lbItems(4, 4) As Label


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Items.Add(New Item("A1", "CocaCola 01", 1.25))
        Items.Add(New Item("A2", "CocaCola 02", 1.26))
        Items.Add(New Item("A3", "CocaCola 03", 1.27))
        Items.Add(New Item("A4", "CocaCola 04", 1.28))

        Items.Add(New Item("B1", "Lays 01", 1.35))
        Items.Add(New Item("B2", "Lays 02", 1.36))
        Items.Add(New Item("B3", "Lays 03", 1.37))
        Items.Add(New Item("B4", "Lays 04", 1.38))

        Items.Add(New Item("C1", "Jjangkoo 01", 2.25))
        Items.Add(New Item("C2", "Jjangkoo 02", 2.26))
        Items.Add(New Item("C3", "Jjangkoo 03", 2.27))
        Items.Add(New Item("C4", "Jjangkoo 04", 2.28))

        Items.Add(New Item("D1", "Doritos 01", 1.55))
        Items.Add(New Item("D2", "Doritos 02", 1.56))
        Items.Add(New Item("D3", "Doritos 03", 1.57))
        Items.Add(New Item("D4", "Doritos 04", 1.58))

        Items2(0, 0) = New Item("D4", "Doritos 04", 1.58)
        Items2(0, 0) = New Item("D4", "Doritos 04", 1.58)
        Items2(0, 0) = New Item("D4", "Doritos 04", 1.58)
        Items2(0, 0) = New Item("D4", "Doritos 04", 1.58)
        Items2(0, 0) = New Item("D4", "Doritos 04", 1.58)
        Items2(0, 0) = New Item("D4", "Doritos 04", 1.58)
        Items2(0, 0) = New Item("D4", "Doritos 04", 1.58)
        Items2(0, 0) = New Item("D4", "Doritos 04", 1.58)
        Items2(0, 0) = New Item("D4", "Doritos 04", 1.58)
        Items2(0, 0) = New Item("D4", "Doritos 04", 1.58)
        Items2(0, 0) = New Item("D4", "Doritos 04", 1.58)
        Items2(0, 0) = New Item("D4", "Doritos 04", 1.58)
        Items2(0, 0) = New Item("D4", "Doritos 04", 1.58)
        Items2(0, 0) = New Item("D4", "Doritos 04", 1.58)

        For i As UInt16 = 0 To 4 Step 1
            For j As UInt16 = 0 To 4 Step 1
                lbItems(i, j) = New Label
                lbItems(i, j).Name = "lb" & i & j
                lbItems(i, j).Text = "TEXT" & i & j
                lbItems(i, j).Location = New Point(10 + 30 * i, 10 + 20 * j)
            Next
        Next

        'lbItems(0, 0) = New Label
        'lbItems(0, 0).Name = "lb" & 0 & 0
        'lbItems(0, 1) = New Label
        'lbItems(0, 1).Name = "lb" & 0 & 1
        'lbItems(0, 0).Text = "Label1"

    End Sub

    Private Sub pbLoonie_Click(sender As Object, e As EventArgs) Handles pbLoonie.Click
        Update_Balance(1.0)
    End Sub

    Private Sub pbToonie_Click(sender As Object, e As EventArgs) Handles pbToonie.Click
        Update_Balance(2.0)
    End Sub

    Private Sub pbQuater_Click(sender As Object, e As EventArgs) Handles pbQuater.Click
        Update_Balance(0.25)

    End Sub
    Private Sub pbDime_Click(sender As Object, e As EventArgs) Handles pbDime.Click
        Update_Balance(0.1)

    End Sub
    Private Sub pbNickle_Click(sender As Object, e As EventArgs) Handles pbNickle.Click
        Update_Balance(0.05)

    End Sub

    Private Sub pbPenny_Click(sender As Object, e As EventArgs) Handles pbPenny.Click
        Update_Balance(0.01)

    End Sub
    Private Sub Update_Balance(ByVal _price As Single)
        'to show the balance to Label
        sngBalance += _price
        lbBalance.Text = sngBalance.ToString("n2") 'to change number format 1234.5678 -> 1234.56

    End Sub

    Private Sub OrderButtonClicked(sender As Object, e As EventArgs) Handles btnA.Click,
        btnB.Click, btnC.Click, btnD.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click
        OrderProcessing((CType(sender, Button)).Text)
    End Sub

    'Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
    '    OrderProcessing((CType(sender, Button)).Text)
    'End Sub
    'Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
    '    OrderProcessing((CType(sender, Button)).Text)
    'End Sub
    'Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
    '    OrderProcessing((CType(sender, Button)).Text)
    'End Sub
    'Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
    '    OrderProcessing((CType(sender, Button)).Text)
    'End Sub
    'Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
    '    OrderProcessing((CType(sender, Button)).Text)
    'End Sub
    'Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
    '    OrderProcessing((CType(sender, Button)).Text)
    'End Sub
    'Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
    '    OrderProcessing((CType(sender, Button)).Text)
    'End Sub
    'Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
    '    OrderProcessing((CType(sender, Button)).Text)
    'End Sub
    Private Sub OrderProcessing(ByVal ButtonCode As Char)

        sOrderCode &= ButtonCode

        ' Check if order code has two character or not 
        If sOrderCode.Length <> 2 Then 'not second button pressed
            Return
        End If

        ' Input order code has two character
        Dim OrderedItem As Order = New Order
        Dim isCorrectOrder As Boolean = False

        For Each item In Items
            With item
                'Must find item.code first 
                If Not sOrderCode.Contains(.Code) Then 'If the item code not match 
                    Continue For
                End If

                ' Check the inventory is good enough
                If .Amount <= 0 Then
                    tbMessage.Text = tbMessage.Text & "Not enough inventory! : " & sOrderCode & ControlChars.CrLf
                    Exit For
                End If
                ' Check the balance is good enough
                If sngBalance < .Price Then
                    tbMessage.Text = tbMessage.Text & "Not enough money! : " & sOrderCode & ControlChars.CrLf
                    Exit For
                End If

                ' Now we have correct code and balance ^^
                isCorrectOrder = True

                'tbMessage.Text = tbMessage.Text & .Title & ControlChars.Tab & .Price & ControlChars.Tab
                tbMessage.Text = tbMessage.Text & .Title & ControlChars.Tab & "$" & .Price & ControlChars.Tab
                dOrderAmount += .Price
                OrderedItem.item = item
                OrderedItem.OrderDate = Now()
                OrderHistory.Add(OrderedItem)

                tbMessage.Text = tbMessage.Text & " Purchased!" & ControlChars.CrLf
                'tbMessage.Text = tbMessage.Text & " Purchased!"


                Update_Balance(-(.Price)) 'Because the balance must be changed
                item.Amount -= 1 'The amount of item decreased by one.

                Exit For
            End With
        Next
        If Not isCorrectOrder Then
            tbMessage.Text = tbMessage.Text & "Wrong Selected! : " & sOrderCode & ControlChars.CrLf

        End If
        sOrderCode = ""
        Return
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        tbMessage.Text = tbMessage.Text & " The Balance $" & sngBalance.ToString("n2") & " retunded!" & ControlChars.CrLf

        Dim iReturnTooney As Int16 = 0
        Dim iReturnLooney As Int16 = 0
        Dim iReturnTQuater As Int16 = 0
        Dim iReturnDime As Int16 = 0
        Dim iReturnNickle As Int16 = 0
        Dim iReturnPenny As Int16 = 0
        Dim iCoinAmount As Int16 = 0

        ' need to round the Single value 
        ' because I want the result 2.00 / 2 = 1 instead of 1.999999998 /2.0 = 0
        ' Visual Basic shows some confusing double number.

        ' for example when the balance is $ 5.60
        ' when it does not use round function 
        ' it returns 2 Tow, 1 Loo, 2 Que, 1 Nickle, 4 Penney and the balance is $ 0.01
        ' when it use the round function
        ' it returns 2 Tow, 1 Loo, 2 Que, 1 dime and the balance is $ 0.00

        iReturnTooney = Math.Truncate(sngBalance / 2.0)
        sngBalance = Math.Round(sngBalance Mod 2.0, 2) 'to prcise 1.999999 -> 2.00

        iReturnLooney = Math.Truncate(sngBalance / 1.0)
        sngBalance = Math.Round(sngBalance Mod 1.0, 2)

        iReturnTQuater = Math.Truncate(sngBalance / 0.25)
        sngBalance = Math.Round(sngBalance Mod 0.25, 2)

        iReturnDime = Math.Truncate(sngBalance / 0.1)
        sngBalance = Math.Round(sngBalance Mod 0.1, 2)

        iReturnNickle = Math.Truncate(sngBalance / 0.05)
        sngBalance = Math.Round(sngBalance Mod 0.05, 2)

        iReturnPenny = Math.Truncate(sngBalance / 0.01)
        sngBalance = Math.Round(sngBalance Mod 0.01, 2)
        Update_Balance(0.0)

        tbMessage.Text = tbMessage.Text & "Returned :" & ControlChars.CrLf

        ' If the amount of coin is less than zero, it is not needed to show
        If iReturnTooney > 0 Then
            tbMessage.Text = tbMessage.Text & "Tooney : " & iReturnTooney.ToString() & ControlChars.CrLf
        End If
        If iReturnLooney > 0 Then
            tbMessage.Text = tbMessage.Text & "Looney : " & iReturnLooney.ToString() & ControlChars.CrLf
        End If
        If iReturnTQuater > 0 Then
            tbMessage.Text = tbMessage.Text & "Quater : " & iReturnTQuater.ToString() & ControlChars.CrLf
        End If
        If iReturnDime > 0 Then
            tbMessage.Text = tbMessage.Text & "Dime   : " & iReturnDime.ToString() & ControlChars.CrLf
        End If
        If iReturnNickle > 0 Then
            tbMessage.Text = tbMessage.Text & "Nickle : " & iReturnNickle.ToString() & ControlChars.CrLf
        End If
        If iReturnPenny > 0 Then
            tbMessage.Text = tbMessage.Text & "Penny  : " & iReturnPenny.ToString() & ControlChars.CrLf
        End If

    End Sub
End Class
