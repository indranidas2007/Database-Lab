Imports System.Data.SqlClient
Public Class Form3
    Dim flag, s_id As Integer
    Dim gen, image_pathname As String

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gid()
            's_id.Enabled = False
            myModule.connecto()
            mycon.Open()
            'course_combo.Items.Clear()
            'course_combo.DisplayMember = "Text"
            'course_combo.ValueMember = "Value"
            Dim tb As New DataTable
            tb.Columns.Add("Text", GetType(String))
            tb.Columns.Add("Value", GetType(Integer))

            mycmd = New SqlCommand("select * from address ", mycon)
            mydatareader = mycmd.ExecuteReader
            'If mydatareader.HasRows = True Then
            ' While mydatareader.Read()
            'tb.Rows.Add(mydatareader(0).ToString & "-" & mydatareader(1).ToString, mydatareader(0))

            ' End While
            ' course_combo.DataSource = tb
            'Else
            'course_combo.Text = ""

            'End If
            'mydatareader.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mycon.Close()

        End Try
    End Sub
    Sub gid()
        myModule.connecto()
        mycon.Open()
        mycmd = New SqlCommand("select * from address", mycon)
        mydatareader = mycmd.ExecuteReader()
        If mydatareader.HasRows() = True Then
            While mydatareader.Read()
                s_id = Convert.ToInt32(mydatareader(0).ToString())
            End While
            s_id = s_id + 1
        Else
            s_id = 1001
        End If
        student_id.text = Convert.ToString(s_id)
        mydatareader.Close()
        mycon.Close()
    End Sub
    Sub verify()
        If village.Text = "" Then
            flag = 1
            MsgBox("Please enter the name of town/village")

        ElseIf po.Text = "" Then
            flag = 1
            MsgBox("Please enter the name of post office")
        ElseIf ps.Text = "" Then
            flag = 1
            MsgBox("Please Enter the police station")
        ElseIf zip.Text = "" Then
            flag = 1
            MsgBox("Please Enter the zip code")
        ElseIf state.Text = "" Then
            flag = 1
            MsgBox("Please Enter the State you belong to")
        ElseIf district.Text = "" Then
            flag = 1
            MsgBox("Please Enter the District name")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim x As Integer
        flag = 0
        verify()
        'If flag = 0 Then
        'If male_radio.Checked = True Then
        ' "Male"
        'ElseIf female_radio.Checked = True Then
        'gen = "female"
        'End If
        'If course_combo.Text <> "" Then
        'c_id = course_combo.SelectedValue

        'End If
        Try

            myModule.connecto()
            mycon.Open()

            mycmd = New SqlCommand("insert into address(s_id,village,po,ps,zipcode,state,district) values('" & student_id.Text & "', '" & village.Text & "', '" & po.Text & "','" & ps.Text & "','" & zip.Text & "','" & state.Text & "','" & district.Text & "')", mycon)
            mydatareader = mycmd.ExecuteReader()
            mydatareader.Close()
            MsgBox("Information saved successfully=")
            cancel()
            gid()
        Catch ex As Exception
            MessageBox.Show("My error:" & ex.Message)
        Finally
            mycon.Close()

        End Try
        ' mycmd.Parameters.AddWithValue("@s_id", student_id.Text)
        'mycmd.Parameters.AddWithValue("@c_id", c_id)
        'mycmd.Parameters.AddWithValue("@doa", doa_datetimepicker.Value)
        'mycmd.Parameters.AddWithValue("@status", "Active")
        'mycmd.Parameters.AddWithValue("@user_id", 1002)
        'mycmd.ExecuteNonQuery()


        'mycmd = New SqlCommand("insert into student(s_id, name, gender, phone, email,dob, photo, status) values( @s_id, @name, @gender, @phone, @email, @dob, @photo, @status)", mycon)
        'mycmd.Parameters.AddWithValue("@s_id", student_id.Text)
        'md.Parameters.AddWithValue("@name", name_text.Text)
        'mycmd.Parameters.AddWithValue("@gender", gen)
        'mycmd.Parameters.AddWithValue("@phone", phone_text.Text)
        'md.Parameters.AddWithValue("@email", email_text.Text)
        'mycmd.Parameters.AddWithValue("@dob", dob_datetimepicker.Value)
        'mycmd.Parameters.Add(New SqlParameter("@photo", SqlDbType.Image)).Value = IO.File.ReadAllBytes(image_location.Text)
        'mycmd.Parameters.AddWithValue("@status", "Active")
        'x = mycmd.ExecuteNonQuery()
        MsgBox("Information saved successfully=")
        cancel()
                gid()

        ' Catch ex As Exception
        'eBox.Show(ex.Message)
        'Finally
        '.Close()

        'End Try
        'End If

    End Sub


    'Private Sub botton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    'OpenFileDialog1.ShowDialog()
    'PictureBox1.ImageLocation = OpenFileDialog1.FileName
    'image_location.Text = OpenFileDialog1.FileName
    'cancel()
    ' End Sub
    Sub cancel()
        village.Text = ""

        po.Text = ""
        ps.Text = ""
        student_id.Text = ""
        state.Text = ""
        district.Text = ""
        village.Text = ""
        zip.Text = ""

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cancel()
    End Sub


End Class