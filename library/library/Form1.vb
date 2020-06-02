Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim query As String = String.Empty
        Try

            Module1.connecto()
            mycon.Open()

            'Dim bookid As Integer
            mycmd = New SqlClient.SqlCommand("insert into books(book_id ,title,author, price, available) values('" & bookid.text & "', '" & title.Text & "', '" & author.Text & "', '" & price.Text & "', '" & av.Text & "')", mycon)
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        bookid.Text = ""
        title.Text = ""
        author.Text = ""
        price.Text = ""
        av.Text = ""

    End Sub
End Class
