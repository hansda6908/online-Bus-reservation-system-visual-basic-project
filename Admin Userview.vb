Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class Admin_Userview
    Dim conn As New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True")
    Private Sub Admin_Userview_Load(sender As Object, e As EventArgs) Handles MyBase.Load





        Dim conn As New SqlConnection
        Dim ds As New DataSet
        conn = New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;")
        Dim user As String = "Select * from Register"
        Dim adapter As New SqlDataAdapter(user, conn)
        conn.Open()
        adapter.Fill(ds, "Register")
        DataGridView1.DataSource = ds.Tables("Register")
        conn.Close()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click


        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value

    End Sub
End Class