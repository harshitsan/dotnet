Public Class order
    Dim total As Integer = 0
    Dim conn As New OleDb.OleDbConnection
    Dim orderId As String = ""

    Private Sub updateTotal()
        Me.TextBox6.Text = total

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TextBox1.Text += 1
        total += Me.Label9.Tag
        Me.updateTotal()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.TextBox2.Text += 1
        total += Me.Label10.Tag
        Me.updateTotal()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.TextBox3.Text += 1
        total += Me.Label11.Tag
        Me.updateTotal()


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.TextBox4.Text += 1
        total += Me.Label12.Tag
        Me.updateTotal()



    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.TextBox5.Text += 1
        total += Me.Label13.Tag
        Me.updateTotal()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.TextBox1.Text > 0) Then
            Me.TextBox1.Text -= 1
            total -= Me.Label9.Tag
            Me.updateTotal()

        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (Me.TextBox4.Text > 0) Then
            Me.TextBox4.Text -= 1
            total -= Me.Label12.Tag
            Me.updateTotal()

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (Me.TextBox3.Text > 0) Then
            Me.TextBox3.Text -= 1
            total -= Me.Label11.Tag
            Me.updateTotal()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (Me.TextBox2.Text > 0) Then
            Me.TextBox2.Text -= 1
            total -= Me.Label10.Tag
            Me.updateTotal()

        End If
    End Sub

    Private Sub order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0 ; Data Source=" & Application.StartupPath & "\customer.accdb"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (Me.TextBox5.Text > 0) Then
            Me.TextBox5.Text -= 1
            total -= Me.Label13.Tag
            Me.updateTotal()

        End If
    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'insert into table order
        If (total > 0) Then
            Dim dateAndTime As Date
            dateAndTime = Now
            orderId = Format(dateAndTime, "yyyyMMddHHmmss").ToString
            Dim cmd As New OleDb.OleDbCommand
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO order_details(order_id, burger1, burger2, burger3, burger4, burger5, total) " &
                        " VALUES('" & orderId & "', '" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & "','" & Me.TextBox4.Text & "','" & Me.TextBox5.Text & "','" & total & "')"
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("order successful")
            customer.lblOrderId.Text = orderId
            customer.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.TextBox1.Text = 0
        Me.TextBox2.Text = 0
        Me.TextBox3.Text = 0
        Me.TextBox4.Text = 0
        Me.TextBox5.Text = 0
        Me.TextBox6.Text = 0
        total = 0
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Close()
        login.Show()
    End Sub
End Class