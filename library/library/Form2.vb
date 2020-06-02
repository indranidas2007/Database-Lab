

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim query As String = String.Empty
        Try

            Module1.connecto()
            mycon.Open()

            'Dim bookid As Integer
            mycmd = New SqlClient.SqlCommand("insert into publisher(pub_id ,name, address) values('" & pubid.text & "', '" & pname.Text & "', '" & padd.Text & "')", mycon)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pubid.Text = ""
        pname.Text = ""
        padd.Text = ""

    End Sub
End Class
