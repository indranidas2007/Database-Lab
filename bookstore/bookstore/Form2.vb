Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StoreDataSet.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.StoreDataSet.stock)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim query As String = String.Empty
        Try

            Module1.connecto()
            mycon.Open()

            'Dim ranking As Integer
            mycmd = New SqlClient.SqlCommand("insert into stock(store_no, B_ID, quantity) values('" & storeno.Text & "', '" & book_id.Text & "', '" & qty.Text & "')", mycon)
            'cmd.Connection.ExecuteNonQuery()
            mydatareader = mycmd.ExecuteReader()
            mydatareader.Close()

        Catch ex As Exception
            MessageBox.Show("My error:" & ex.Message)
        Finally
            mycon.Close()

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        book_id.Text = ""
        qty.Text = ""
        storeno.Text = ""
    End Sub
End Class