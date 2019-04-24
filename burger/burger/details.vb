Public Class details
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        invoice.Show()
        Me.Close()

    End Sub

    Private Sub details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        order.Show()
        Me.Close()

    End Sub
End Class