Imports System.Data.SqlClient

Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim flag As Integer
        flag = 0
        If UseridTextBox.Text = "" Then
            flag = 1
            MsgBox("Please enter the user_id")
        ElseIf PasswordTextBox.Text = "" Then
            flag = 1
            MsgBox("Please enter the Password")


        End If

        If flag = 0 Then
            Try
                myModule.connecto()
                mycon.Open()

                mycmd = New SqlCommand("select *from admin where ad_id= @ad_id and ad_password= @ad_password", mycon)

                mycmd.Parameters.Add("@ad_id", SqlDbType.VarChar).Value = UseridTextBox.Text
                mycmd.Parameters.Add("@ad_password", SqlDbType.VarChar).Value = PasswordTextBox.Text


                Dim adapter As New SqlDataAdapter(mycmd)

                Dim table As New DataTable()

                adapter.Fill(table)

                If table.Rows.Count() <= 0 Then

                    MessageBox.Show("Username Or Password Are Invalid")

                Else

                    MessageBox.Show("Login Successfully")



                    Me.Hide()
                    Form1.Show()




                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                mycon.Close()
            End Try

        End If
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.Show()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


End Class
