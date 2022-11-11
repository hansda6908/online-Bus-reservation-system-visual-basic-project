Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class View_Rental_Bus_Booking_Details
    Dim conn As New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True")
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Bus Id required")
        Else

            Dim command As New SqlCommand("select * from User_RentalBus_Booking WHERE Booking_Id = @Booking_Id", conn)

            command.Parameters.Add("@Booking_Id", SqlDbType.VarChar).Value = TextBox1.Text

            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then
                MessageBox.Show("No data found")

            Else

                TextBox2.Text = table.Rows(0)(1).ToString()
                TextBox6.Text = table.Rows(0)(2).ToString()
                TextBox3.Text = table.Rows(0)(3).ToString()
                TextBox5.Text = table.Rows(0)(4).ToString()
                TextBox9.Text = table.Rows(0)(5).ToString()
                TextBox4.Text = table.Rows(0)(6).ToString()
                TextBox8.Text = table.Rows(0)(7).ToString()
                TextBox7.Text = table.Rows(0)(8).ToString()
                TextBox10.Text = table.Rows(0)(10).ToString()
                TextBox11.Text = table.Rows(0)(11).ToString()
                TextBox12.Text = table.Rows(0)(12).ToString()
                TextBox13.Text = table.Rows(0)(13).ToString()





                Dim img() As Byte

                img = table.Rows(0)(9)

                Dim ms As New MemoryStream(img)
                PictureBox1.Image = Image.FromStream(ms)

            End If
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub View_Rental_Bus_Booking_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class