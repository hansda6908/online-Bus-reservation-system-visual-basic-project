Imports System.Data.SqlClient
Public Class Admin_UserBusTickets
    Dim conn As New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True")
    Private Sub Admin_UserBusTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection
        Dim ds As New DataSet
        conn = New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;")
        Dim user As String = "Select * from User_BusTicketBooking"
        Dim adapter As New SqlDataAdapter(user, conn)
        conn.Open()
        adapter.Fill(ds, "User_BusTicketBooking")
        DataGridView1.DataSource = ds.Tables("User_BusTicketBooking")
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()

        End If

        conn.Open()



        Code1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        Label4.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        Label7.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        Label9.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        Label11.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        Label25.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        Label26.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        Label27.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        Label28.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        Label29.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()
        Label34.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
        Label36.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString()
        Label35.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString()
        Label33.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString()
        Label32.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString()
        Label31.Text = DataGridView1.CurrentRow.Cells(15).Value.ToString()
        Label30.Text = DataGridView1.CurrentRow.Cells(16).Value.ToString()

        conn.Close()
    End Sub
End Class