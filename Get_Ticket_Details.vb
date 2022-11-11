Imports System.Data.SqlClient
Public Class Get_Ticket_Details
    Dim conn As New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True")
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Booking Id required", "Error")

        Else
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            conn.Open()
            Dim command As New SqlCommand("select * from User_BusTicketBooking WHERE Booking_Id = @Booking_Id", conn)

            command.Parameters.Add("@Booking_Id", SqlDbType.VarChar).Value = TextBox1.Text

            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then
                MessageBox.Show("No data found")

            Else

                Label4.Text = table.Rows(0)(1).ToString()
                Label7.Text = table.Rows(0)(2).ToString()
                Label9.Text = table.Rows(0)(3).ToString()
                Label11.Text = table.Rows(0)(4).ToString()
                Label25.Text = table.Rows(0)(5).ToString()
                Label26.Text = table.Rows(0)(6).ToString()
                Label27.Text = table.Rows(0)(7).ToString()
                Label28.Text = table.Rows(0)(8).ToString()
                Label29.Text = table.Rows(0)(9).ToString()
                Label34.Text = table.Rows(0)(10).ToString()
                Label36.Text = table.Rows(0)(11).ToString()
                Label35.Text = table.Rows(0)(12).ToString()
                Label33.Text = table.Rows(0)(13).ToString()
                Label32.Text = table.Rows(0)(14).ToString()
                Label31.Text = table.Rows(0)(15).ToString()
                Label30.Text = table.Rows(0)(16).ToString()

                conn.Close()

            End If

        End If
    End Sub

    Private Sub Get_Ticket_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        Label4.Text = ""
        Label7.Text = ""
        Label9.Text = ""
        Label11.Text = ""
        Label25.Text = ""
        Label26.Text = ""
        Label27.Text = ""
        Label28.Text = ""
        Label29.Text = ""
        Label34.Text = ""
        Label36.Text = ""
        Label35.Text = ""
        Label33.Text = ""
        Label32.Text = ""
        Label31.Text = ""
        Label30.Text = ""
    End Sub
End Class