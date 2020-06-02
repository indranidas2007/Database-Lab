
Imports System.Data.SqlClient

Public Class Form5
    Dim flag, s_id As Integer
    'Dim gen, image_pathname As String

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            qid()

            myModule.connecto()
            mycon.Open()
            '
            Dim tb As New DataTable
            tb.Columns.Add("Text", GetType(String))
            tb.Columns.Add("Value", GetType(Integer))

            mycmd = New SqlCommand("select * from admission_details ", mycon)
            mydatareader = mycmd.ExecuteReader


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mycon.Close()

        End Try
    End Sub
    Sub qid()
        myModule.connecto()
        mycon.Open()
        mycmd = New SqlCommand("select * from admission_details", mycon)
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
        If course_ad.Text = "" Then
            flag = 1
            MsgBox("Please enter the course ID")

        ElseIf center_ad.Text = "" Then
            flag = 1
            MsgBox("Please enter the center ID")
        ElseIf enroll.Text = "" Then
            flag = 1
            MsgBox("Please Enter the enrollment ID")
        ElseIf admission.Text = "" Then
            flag = 1
            MsgBox("Please Enter the admission date")
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

            mycmd = New SqlCommand("insert into admission_details(enroll_ID,s_id, course_id, center_id, DOA, MOP) values('" & enroll.Text & "', '" & student_id.Text & "', '" & course_ad.Text & "','" & center_ad.Text & "''" & admission.Text & "','" & mop.Text & "')", mycon)
            mydatareader = mycmd.ExecuteReader()
            mydatareader.Close()
            MsgBox("Information saved successfully!")
            cancel()
            qid()
        Catch ex As Exception
            MessageBox.Show("My error:" & ex.Message)
        Finally
            mycon.Close()

        End Try

        MsgBox("Information saved successfully!")
        cancel()
        qid()


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        cancel()
    End Sub

    Sub cancel()
        mop.Text = ""
        center_ad.Text = ""
        course_ad.Text = ""
        admission.Text = ""
        student_id.Text = ""
        enroll.Text = ""

    End Sub


End Class