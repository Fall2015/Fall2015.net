Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles number1.TextChanged
        Dim num1, num2 As Integer
        num1 = Val(number1.text)
        num2 = Val(number2.text)

        sum.text = num1 + num2

    End Sub

    Private Sub num2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles number2.TextChanged

    End Sub
End Class
