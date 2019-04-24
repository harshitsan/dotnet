Public Class customer
    Dim conn As New OleDb.OleDbConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0 ; Data Source=" & Application.StartupPath & "\customer.accdb"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New OleDb.OleDbCommand
        conn.Open()
        cmd.Connection = conn
        Try
            cmd.CommandText = "INSERT INTO customer(c_name, c_num) " &
                                " VALUES('" & Me.txtname.Text & "','" & Me.txtnum.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Your order Completed '" & Me.txtname.Text & "'")
        Catch x As Exception
            'MsgBox(x.Message)
        End Try
        cmd.CommandText = "Select c_id from customer where c_num = '" & Me.txtnum.Text & "'"
        Dim c_id = 0
        Using oRDR As OleDb.OleDbDataReader = cmd.ExecuteReader
            If (oRDR.Read) Then
                c_id = oRDR.GetValue(0)
            End If
        End Using

        If (c_id) Then
            cmd.CommandText = "UPDATE order_details set c_id ='" & c_id & "' where order_id = '" & lblOrderId.Text & "'"
            'MsgBox("UPDATE order_details set c_id ='" & c_id & "' where order_id = '" & lblOrderId.Text & "'")

            cmd.ExecuteNonQuery()
            'MsgBox("Updated")

            'Dim da As New OleDb.OleDbDataAdapter("Select c_id from customer")
            'cmd.ExecuteNonQuery()
            conn.Close()
            invoice.lblName.Text = txtname.Text
            invoice.lblNumber.Text = txtnum.Text
            invoice.lblOrderId.Text = lblOrderId.Text
            details.Show()
            Me.Hide()

        Else
            MsgBox("try later")
        End If






    End Sub
End Class
