Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports chingoctatavia.Class1
Public Class RentalBooking_Preview

    Dim conn As New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True")
    Private Sub RentalBooking_Preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Visible = False
        Dim command As New SqlCommand("select * from DumyUser_RentalBus_Booking WHERE Booking_Id = @Booking_Id", conn)

        command.Parameters.Add("@Booking_Id", SqlDbType.Int).Value = User_Rent_Buses.Code1.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("No data found")

        Else

            Code1.Text = table.Rows(0)(0).ToString()
            Label25.Text = table.Rows(0)(1).ToString()
            Label26.Text = table.Rows(0)(2).ToString()
            Label27.Text = table.Rows(0)(3).ToString()
            Label28.Text = table.Rows(0)(4).ToString()
            Label29.Text = table.Rows(0)(5).ToString()
            Label19.Text = table.Rows(0)(6).ToString()
            Label22.Text = table.Rows(0)(7).ToString()
            Label24.Text = table.Rows(0)(8).ToString()


            Dim img() As Byte

            img = table.Rows(0)(9)

            Dim ms As New MemoryStream(img)
            PictureBox2.Image = Image.FromStream(ms)
        End If

        conn.ConnectionString = "Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;"
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        conn.Open()
        Dim cmd1 As New SqlCommand("Select * from Register where Username='" + user_username + "' ", conn)
        Dim reader1 As SqlDataReader
        reader1 = cmd1.ExecuteReader
        If reader1.Read Then
            Label4.Text = reader1("Username")
            Label7.Text = reader1("Gender")
            Label9.Text = reader1("Email_Id")
            Label11.Text = reader1("Phone_No")


        Else
            MessageBox.Show("Data Not Found", "Error")

        End If
        conn.Close()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

        conn.Open()
        Dim cmd1 As New SqlCommand("Select * from Register  ", conn)
        Dim reader1 As SqlDataReader
        reader1 = cmd1.ExecuteReader
        If reader1.Read Then
            Label4.Text = reader1("Username")
            Label7.Text = reader1("Gender")
            Label9.Text = reader1("Email_Id")
            Label11.Text = reader1("Phone_No")


        Else
            MessageBox.Show("Data Not Found", "Error")
            conn.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label4.Text = "" Or Label7.Text = "" Or Label9.Text = "" Or Label11.Text = "" Then
            MessageBox.Show("Fields cannot be emty", "Error !!")
        Else
            Dim ms As New MemoryStream
            PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)
            Dim img() As Byte
            img = ms.ToArray()
            Dim insertQuery As String = "INSERT INTO User_RentalBus_Booking (Booking_Id,Bus_Id,Bus_Name,Bus_Type,Pick_From,Date,Price_Per_Day,No_Of_Days,Total_Amount,the_Image,Username,Gender,Email_Id,Phone_No) Values('" & Code1.Text & "','" & Label25.Text & "','" & Label26.Text & "','" & Label27.Text & "','" & Label28.Text & "','" & Label29.Text & "','" & Label19.Text & "','" & Label22.Text & "','" & Label24.Text & "', @img,'" & Label4.Text & "','" & Label7.Text & "','" & Label9.Text & "','" & Label11.Text & "')"

            Dim Command As New SqlCommand(insertQuery, conn)
            Command.Parameters.Add("@img", SqlDbType.Image).Value = img

            ExecuteMyQuery(Command, "Print")
            conn.Close()

            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label1.Text + " " + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label2.Text + " " + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label37.Text + ": " + Code1.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label3.Text + ": " + Label4.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label5.Text + ": " + Label7.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label8.Text + ": " + Label9.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label10.Text + ": " + Label11.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label13.Text + ": " + Label25.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label14.Text + ": " + Label26.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label15.Text + ": " + Label27.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label16.Text + ": " + Label28.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label17.Text + " :" + Label29.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label18.Text + ": " + Label19.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label21.Text + ": " + Label22.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label23.Text + ": " + Label24.Text + System.Environment.NewLine)



            Dim isave As New SaveFileDialog
            isave.Filter = "txt files (*.txt) |*.txt"
            isave.FilterIndex = 2
            isave.RestoreDirectory = False

            If isave.ShowDialog() = DialogResult.OK Then
                IO.File.WriteAllText(isave.FileName, TextBox1.Text)
            End If
            Me.Hide()
            Form2.Show()
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

    Private Sub Code1_Click(sender As Object, e As EventArgs) Handles Code1.Click

    End Sub

    Private Sub RentalBooking_Preview_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Form2.Show()
    End Sub
End Class