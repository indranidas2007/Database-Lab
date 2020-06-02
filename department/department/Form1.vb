Imports System.Data.SqlClient
Public Class Form1

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
            mycmd = New SqlClient.SqlCommand("insert into staff(staff_id ,s_name, desg, salary, phone, entry_date) values('" & staff_id.Text & "', '" & s_name.Text & "', '" & des.Text & "', '" & sal.Text & "', '" & phn.Text & "', '" & DateTimePicker1.Text & "')", mycon)
            'cmd.Connection.ExecuteNonQuery()
            ' mydatareader = mycmd.ExecuteReader()
            'mydatareader.Close()
            sda = New SqlDataAdapter(mycmd)
            dt = New DataTable()
            sda.Fill(dt)
            DataGridView1.DataSource = dt
            MsgBox("Successfully inserted!")

        Catch ex As Exception
            MessageBox.Show("My error:" & ex.Message)
        Finally
            mycon.Close()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        staff_id.Text = ""
        s_name.Text = ""
        des.Text = ""
        sal.Text = ""
        phn.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StaffDataSet.staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.StaffDataSet.staff)

    End Sub
End Class
