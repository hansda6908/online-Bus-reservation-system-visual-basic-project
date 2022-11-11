Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class User_Rent_Buses

    Dim conn As New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;")
    Dim cmd As New SqlCommand
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "" Or TextBox6.Text = "" Then
            MessageBox.Show("Fields cannot be empty")

        Else
            DataGridView1.Visible = True
            conn.Open()
            Dim query As String
            query = "SELECT * from Rental_Buses where Pick_From='" + ComboBox1.SelectedItem.ToString + "' "
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            cmd = New SqlCommand(query, conn)


            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.AllowUserToAddRows = False


            DataGridView1.RowTemplate.Height = 200
            Dim imgc As New DataGridViewImageColumn


            imgc = DataGridView1.Columns(5)
            imgc.ImageLayout = DataGridViewImageCellLayout.Stretch




            conn.Close()

            TextBox8.Text = TextBox6.Text

        End If
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Panel1.Visible = True
        Dim img As Byte()
        img = DataGridView1.CurrentRow.Cells(5).Value
        Dim ms As New MemoryStream(img)
        PictureBox1.Image = Image.FromStream(ms)


        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value

        Dim num1 As Integer
        Dim num2 As Integer
        Dim result As Integer

        num1 = TextBox4.Text
        num2 = TextBox8.Text
        result = num1 * num2
        TextBox7.Text = result

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        TextBox8.Text = TextBox6.Text
    End Sub

    Private Sub User_Rent_Buses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gen As New Random
        Code1.Text = gen.Next(10000000)

        DataGridView1.Visible = False
        Panel1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Dim img() As Byte
        img = ms.ToArray()
        Dim insertQuery As String = "INSERT INTO DumyUser_RentalBus_Booking (Booking_Id,Bus_Id,Bus_Name,Bus_Type,Pick_From,Date,Price_Per_Day,No_Of_Days,Total_Amount,the_Image) Values('" & Code1.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "','" & DateTimePicker1.Text & "','" & TextBox4.Text & "','" & TextBox8.Text & "','" & TextBox7.Text & "', @img)"

        Dim Command As New SqlCommand(insertQuery, conn)
        Command.Parameters.Add("@img", SqlDbType.Image).Value = img

        ExecuteMyQuery(Command, "Booked")

        RentalBooking_Preview.Show()


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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If Not IsNumeric(Me.TextBox6.Text) Then
            MessageBox.Show("Enter positive numbers only")
            TextBox6.Text = ""

        End If
    End Sub
End Class