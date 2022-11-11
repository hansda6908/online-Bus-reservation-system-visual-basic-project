Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class Cancel_RentalBusBooking
    Dim conn As New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True")
    Private Sub Cancel_RentalBusBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
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
                MessageBox.Show("No Data found")

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show(" Booking Id required")

        Else
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Do you really want to cancel the Bus Ticket", " Cancel?", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then

                Dim deleteQuery As String = "DELETE FROM User_RentalBus_Booking WHERE Booking_Id = '" & TextBox1.Text & "'"

                Dim Command As New SqlCommand(deleteQuery, conn)


                ExecuteMyQuery(Command, "Cancelled Bus Ticket")



                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox6.Text = ""
                TextBox3.Text = ""
                TextBox5.Text = ""
                TextBox9.Text = ""
                TextBox4.Text = ""
                TextBox8.Text = ""
                TextBox7.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                PictureBox1.Image = Nothing

            Else
                MessageBox.Show(" Not Cancelled")

            End If

        End If
    End Sub
    Public Sub ExecuteMyQuery(MyCommand As SqlCommand, MyMessage As String)

        conn.Open()

        If MyCommand.ExecuteNonQuery = 1 Then

            MessageBox.Show(MyMessage)
        Else
            MessageBox.Show("Query Not Executed")

        End If
        conn.Close()

    End Sub
End Class