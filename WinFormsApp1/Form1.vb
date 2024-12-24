Public Class Form1
    Private firstNumber As Double
    Private operation As String
    Private newNumber As Boolean = True

    Private Sub NumberButton_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim button As Button = DirectCast(sender, Button)
        
        If newNumber Then
            txtDisplay.Text = button.Text
            newNumber = False
        Else
            txtDisplay.Text &= button.Text
        End If
    End Sub

    Private Sub OperatorButton_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSubtract.Click, btnMultiply.Click, btnDivide.Click
        Dim button As Button = DirectCast(sender, Button)
        
        If Not newNumber Then
            firstNumber = Double.Parse(txtDisplay.Text)
            operation = button.Text
            newNumber = True
        End If
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        If Not newNumber Then
            Dim secondNumber As Double = Double.Parse(txtDisplay.Text)
            Dim result As Double

            Select Case operation
                Case "+"
                    result = firstNumber + secondNumber
                Case "-"
                    result = firstNumber - secondNumber
                Case "×"
                    result = firstNumber * secondNumber
                Case "÷"
                    If secondNumber <> 0 Then
                        result = firstNumber / secondNumber
                    Else
                        MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        btnClear_Click(Nothing, Nothing)
                        Return
                    End If
            End Select

            txtDisplay.Text = result.ToString()
            newNumber = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = "0"
        firstNumber = 0
        operation = ""
        newNumber = True
    End Sub
End Class
