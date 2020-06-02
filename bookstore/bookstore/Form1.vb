Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookDataSet.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.BookDataSet.books)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim query As String = String.Empty
        Try

            Module1.connecto()
            mycon.Open()

            'Dim ranking As Integer
            mycmd = New SqlClient.SqlCommand("insert into books(B_ID, Author, Genre, Stock, Book) values('" & bookid.Text & "', '" & author.Text & "', '" & genre.Text & "','" & stock.Text & "',  '" & book.Text & "')", mycon)
            'cmd.Connection.ExecuteNonQuery()
            mydatareader = mycmd.ExecuteReader()
            mydatareader.Close()

        Catch ex As Exception
            MessageBox.Show("My error:" & ex.Message)
        Finally
            mycon.Close()

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bookid.Text = ""
        author.Text = ""
        genre.Text = ""
        stock.Text = ""
        book.Text = ""
    End Sub
End Class
