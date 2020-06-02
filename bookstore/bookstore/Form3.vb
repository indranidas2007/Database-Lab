Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookstoreDataSet.Book_store' table. You can move, or remove it, as needed.
        Me.Book_storeTableAdapter.Fill(Me.BookstoreDataSet.Book_store)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim query As String = String.Empty
        Try

            Module1.connecto()
            mycon.Open()

            'Dim ranking As Integer
            mycmd = New SqlClient.SqlCommand("insert into Book_store (store_no, city, state, zip ) values('" & store_no.Text & "', '" & city.Text & "', '" & state.Text & "', '" & zip.Text & "')", mycon)
            'cmd.Connection.ExecuteNonQuery()
            mydatareader = mycmd.ExecuteReader()
            mydatareader.Close()

        Catch ex As Exception
            MessageBox.Show("My error:" & ex.Message)
        Finally
            mycon.Close()

        End Try

    End Sub
End Class