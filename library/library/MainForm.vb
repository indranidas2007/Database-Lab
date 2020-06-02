Imports System.Data.SqlClient
Public Class MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        member.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        borrow.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim con As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim sda As SqlDataAdapter
        Dim dt As DataTable

        Dim query As String = String.Empty
        Try

            Module1.connecto()
            mycon.Open()

            'Dim ranking As Integer
            mycmd = New SqlClient.SqlCommand("select member.name, member.member_id, borrow.book_id, borrow.due_date from [dbo].member inner join [dbo].borrow on member.member_id= borrow.member_id", mycon)
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim con As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim qda As SqlDataAdapter
        Dim dtt As DataTable

        Dim query As String = String.Empty
        Try

            Module1.connecto()
            mycon.Open()

            'Dim ranking As Integer
            mycmd = New SqlClient.SqlCommand("select member.name, member.member_id, borrow.book_id, borrow.due_date from [dbo].member left join [dbo].borrow on member.member_id= borrow.member_id", mycon)
            'cmd.Connection.ExecuteNonQuery()

            ' mydatareader = mycmd.ExecuteReader()
            qda = New SqlDataAdapter(mycmd)
            dtt = New DataTable()
            qda.Fill(dtt)
            DataGridView1.DataSource = dtt
            ' mydatareader.Close()

        Catch ex As Exception
            MessageBox.Show("My error:" & ex.Message)
        Finally
            mycon.Close()

        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim con As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim qda As SqlDataAdapter
        Dim dtt As DataTable

        Dim query As String = String.Empty
        Try

            Module1.connecto()
            mycon.Open()

            'Dim ranking As Integer
            mycmd = New SqlClient.SqlCommand("SELECT borrow.member_id, borrow.book_id, borrow.due_date, member.name, member.exp_date FROM borrow, member WHERE borrow.member_id = member.member_id ORDER BY due_date, exp_date ASC", mycon)
            'cmd.Connection.ExecuteNonQuery()

            ' mydatareader = mycmd.ExecuteReader()
            qda = New SqlDataAdapter(mycmd)
            dtt = New DataTable()
            qda.Fill(dtt)
            DataGridView1.DataSource = dtt
            ' mydatareader.Close()

        Catch ex As Exception
            MessageBox.Show("My error:" & ex.Message)
        Finally
            mycon.Close()

        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim con As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim qda As SqlDataAdapter
        Dim dtt As DataTable

        Dim query As String = String.Empty
        Try

            Module1.connecto()
            mycon.Open()

            'Dim ranking As Integer
            mycmd = New SqlClient.SqlCommand("SELECT borrow.member_id, borrow.due_date, member.exp_date FROM borrow, member WHERE borrow.member_id = member.member_id ORDER BY due_date, exp_date DESC ", mycon)
            'cmd.Connection.ExecuteNonQuery()

            ' mydatareader = mycmd.ExecuteReader()
            qda = New SqlDataAdapter(mycmd)
            dtt = New DataTable()
            qda.Fill(dtt)
            DataGridView1.DataSource = dtt
            ' mydatareader.Close()

        Catch ex As Exception
            MessageBox.Show("My error:" & ex.Message)
        Finally
            mycon.Close()

        End Try
    End Sub
End Class