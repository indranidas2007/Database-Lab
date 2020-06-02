Public Class borrow

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim query As String = String.Empty
        Try

            Module1.connecto()
            mycon.Open()

            'Dim bookid As Integer
            mycmd = New SqlClient.SqlCommand("insert into borrow(book_id ,member_id, due_date, ret_date, issue) values('" & book_id.Text & "', '" & mem_id.Text & "', '" & DateTimePicker1.Text & "', '" & DateTimePicker2.Text & "', '" & issue.Text & "')", mycon)
            'cmd.Connection.ExecuteNonQuery()
            mydatareader = mycmd.ExecuteReader()
            mydatareader.Close()

            MsgBox("Successfully inserted!")

        Catch ex As Exception
            MessageBox.Show("My error:" & ex.Message)
        Finally
            mycon.Close()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        book_id.Text = ""
        mem_id.Text = ""

        issue.Text = ""

    End Sub
End Class