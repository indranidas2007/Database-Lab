Imports System.Data.SqlClient
Public Class mainform
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim sda As SqlDataAdapter
        Dim dt As DataTable

        Dim query As String = String.Empty
        Try

            Module1.connecto()
            mycon.Open()

            'Dim ranking As Integer
            mycmd = New SqlClient.SqlCommand("select books.book, books.stock, stock.quantity from [dbo].books inner join [dbo].stock on books.B_ID= stock.B_ID", mycon)
            'cmd.Connection.ExecuteNonQuery()

            ' mydatareader = mycmd.ExecuteReader()
            sda = New SqlDataAdapter(mycmd)
            dt = New DataTable()
            sda.Fill(dt)
            DataGridView1.DataSource = dt
            ' mydatareader.Close()

        Catch ex As Exception
            MessageBox.Show("My error:" & ex.Message)
        Finally
            mycon.Close()

        End Try
    End Sub
End Class