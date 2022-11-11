Imports System.Data
Imports System.Data.SqlClient
Public Class View_Bus_Details
    Private Sub View_Bus_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection
        Dim ds As New DataSet
        conn = New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;")
        Dim user As String = "Select * from Bus_Lists"
        Dim adapter As New SqlDataAdapter(user, conn)
        conn.Open()
        adapter.Fill(ds, "Bus_Lists")
        DataGridView1.DataSource = ds.Tables("Bus_Lists")
    End Sub
End Class