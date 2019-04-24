Public Class invoice
    Dim conn As New OleDb.OleDbConnection
    Private Sub invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0 ; Data Source=" & Application.StartupPath & "\customer.accdb"

        Dim cmd As New OleDb.OleDbCommand
        conn.Open()
        cmd.Connection = conn
        cmd.CommandText = "SELECT * from order_details where order_Id = '" & lblOrderId.Text & "'"
        'MsgBox("SELECT * from order_details where orderId = '" & lblOrderId.Text & "'")

        Using oRDR As OleDb.OleDbDataReader = cmd.ExecuteReader
            While (oRDR.Read)
                'MsgBox(oRDR.GetValue(0), oRDR.GetValue(1), oRDR.GetValue(2))

                Label24.Text = If(oRDR.GetValue(1) = 0, "", oRDR.GetValue(1))
                Label23.Text = If(oRDR.GetValue(2) = 0, "", oRDR.GetValue(2))
                Label22.Text = If(oRDR.GetValue(3) = 0, "", oRDR.GetValue(3))
                Label21.Text = If(oRDR.GetValue(4) = 0, "", oRDR.GetValue(4))
                Label20.Text = If(oRDR.GetValue(5) = 0, "", oRDR.GetValue(5))

                Label10.Text = If(Label24.Text = "", "", Label10.Text)
                Label11.Text = If(Label23.Text = "", "", Label11.Text)
                Label12.Text = If(Label22.Text = "", "", Label12.Text)
                Label13.Text = If(Label21.Text = "", "", Label13.Text)
                Label14.Text = If(Label20.Text = "", "", Label14.Text)
                Label16.Text = oRDR.GetValue(6)


            End While
        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        order.Show()
        Me.Close()

    End Sub
End Class