Public Class Form2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'MsgBox("Name:" + student_name.Text + "Course:" + course_name.Text + "Ranking:" + ranking.Text + "Category:" + category.Text)
        Dim con As New SqlClient.SqlConnection
        Dim cmd As New SqlClient.SqlCommand
        Dim query As String = String.Empty
        Try

            myModule.connecto()
            mycon.Open()

            Dim ranking As Integer
            mycmd = New SqlClient.SqlCommand("insert into student(s_name, course_id, s_Rank, category) values('" & student_name.Text & "', '" & course_name.Text & "', '" & ranking & "','" & category.Text & "')", mycon)
            'cmd.Connection.ExecuteNonQuery()
            mydatareader = mycmd.ExecuteReader()
            mydatareader.Close()

        Catch ex As Exception
            MessageBox.Show("My error:" & ex.Message)
        Finally
            mycon.Close()

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        course_name.Text = ""
        ranking.Text = ""
        student_name.Text = ""
        category.Text = ""
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UnicounsellingDataSet3.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.UnicounsellingDataSet3.student)

    End Sub
End Class
