Imports System.Data.SqlClient
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssignDataSet.assign' table. You can move, or remove it, as needed.
        Me.AssignTableAdapter.Fill(Me.AssignDataSet.assign)

    End Sub

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
            mycmd = New SqlClient.SqlCommand("insert into assign(staff_id ,class_id, s_name) values('" & sid.Text & "', '" & classid.Text & "', '" & pname.Text & "')", mycon)
            'cmd.Connection.ExecuteNonQuery()
            ' mydatareader = mycmd.ExecuteReader()
            'mydatareader.Close()
            sda = New SqlDataAdapter(mycmd)
                dt = New DataTable()
                sda.Fill(dt)
            DataGridView3.DataSource = dt
            MsgBox("Successfully inserted!")

            Catch ex As Exception
                MessageBox.Show("My error:" & ex.Message)
            Finally
                mycon.Close()

            End Try
        End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        classid.Text = ""
        sid.Text = ""
        pname.Text = ""
    End Sub
End Class
