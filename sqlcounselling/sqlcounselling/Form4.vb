Imports System.Data.SqlClient

Public Class Form4
    Dim flag, s_id As Integer
    'Dim gen, image_pathname As String

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            pid()

            myModule.connecto()
            mycon.Open()
            '
            Dim tb As New DataTable
            tb.Columns.Add("Text", GetType(String))
            tb.Columns.Add("Value", GetType(Integer))

            mycmd = New SqlCommand("select * from payment_details ", mycon)
            mydatareader = mycmd.ExecuteReader


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mycon.Close()

        End Try
    End Sub
    Sub pid()
        myModule.connecto()
        mycon.Open()
        mycmd = New SqlCommand("select * from payment_details", mycon)
        mydatareader = mycmd.ExecuteReader()
        If mydatareader.HasRows() = True Then
            While mydatareader.Read()
                s_id = Convert.ToInt32(mydatareader(0).ToString())
            End While
            s_id = s_id + 1
        Else
            s_id = 1001
        End If
        student_id.Text = Convert.ToString(s_id)
        mydatareader.Close()
        mycon.Close()
    End Sub
    Sub verify()
        If mop.Text = "" Then
            flag = 1
            MsgBox("Please enter the month of payment")

        ElseIf t_id.Text = "" Then
            flag = 1
            MsgBox("Please enter the transaction ID")
        ElseIf d_date.Text = "" Then
            flag = 1
            MsgBox("Please Enter the date")
        ElseIf amount.Text = "" Then
            flag = 1
            MsgBox("Please Enter the amount")
        ElseIf mop.Text = "" Then
            flag = 1
            MsgBox("Please Enter the month of payment")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        flag = 0
        verify()
        Try

            myModule.connecto()
            mycon.Open()

            mycmd = New SqlCommand("insert into payment_details(s_id,t_id,Date, Month_of_payment) values('" & student_id.Text & "', '" & t_id.Text & "', '" & d_date.Text & "','" & mop.Text & "')", mycon)
            mydatareader = mycmd.ExecuteReader()
            mydatareader.Close()
            MsgBox("Information saved successfully!")
            cancel()
            pid()
        Catch ex As Exception
            MessageBox.Show("My error:" & ex.Message)
        Finally
            mycon.Close()

        End Try

        MsgBox("Information saved successfully!")
        cancel()
        pid()


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        cancel()
    End Sub

    Sub cancel()
        mop.Text = ""
        d_date.Text = ""
        t_id.Text = ""
        student_id.Text = ""

    End Sub

End Class