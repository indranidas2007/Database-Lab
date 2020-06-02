Imports System.Data.SqlClient

Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim query As String = String.Empty
        Dim sda As SqlDataAdapter
        Dim dt As DataTable
        Try

            Module1.connecto()
            mycon.Open()

            'Dim bookid As Integer
            mycmd = New SqlClient.SqlCommand("insert into class(class_id ,c_name, strength, year_) values('" & classid.Text & "', '" & c_name.Text & "', '" & strength.Text & "', '" & year.Text & "')", mycon)
            'cmd.Connection.ExecuteNonQuery()
            ' mydatareader = mycmd.ExecuteReader()
            'mydatareader.Close()
            sda = New SqlDataAdapter(mycmd)
            dt = New DataTable()
            sda.Fill(dt)
            DataGridView2.DataSource = dt
            MsgBox("Successfully inserted!")

        Catch ex As Exception
            MessageBox.Show("My error:" & ex.Message)
        Finally
            mycon.Close()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        classid.Text = ""
        c_name.Text = ""
        strength.Text = ""
        year.Text = ""
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassDataSet._class' table. You can move, or remove it, as needed.
        Me.ClassTableAdapter.Fill(Me.ClassDataSet._class)

    End Sub
End Class
