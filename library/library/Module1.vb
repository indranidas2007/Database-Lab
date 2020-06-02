Imports System.Data.Sql
Imports System.Data.SqlClient
Module Module1

    Public mycon As New SqlConnection
    Public mycmd As SqlCommand
    Public mydatareader As SqlDataReader
    Public mydataadapter As SqlDataAdapter
    Public mydataset As DataSet
    Public mydatatable As DataTable
    Public servername As String



    Sub connecto()
        servername = My.Computer.Name.ToString() + "\SQLEXPRESS"
        'mycon = New SqlConnection("Server=" & servername & "; Database= unicounselling; Integrated Security= TRUE; user ID= indrani; password= 2007 ")
        'Dim builder As SqlConnectionStringBuilder = New SqlConnectionStringBuilder("Integrated Security=SSPI;")
        mycon = New SqlConnection With {.ConnectionString = " Data Source=LAPTOP-1VQKNH51;Initial Catalog=library;Integrated Security=True; database=library; User= indrani; Pwd= 2007;"}
    End Sub

End Module


