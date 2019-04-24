Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.TextBox1.Text = "admin" And Me.TextBox2.Text = "admin") Then
            Me.Hide()
            order.Show()
        Else
            MsgBox("error : wrong username or password")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class