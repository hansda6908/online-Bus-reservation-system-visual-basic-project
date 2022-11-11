Imports chingoctatavia.Class1
Imports System.Data.SqlClient
Public Class Preview_Booking
    Dim conn As New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True")
    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Preview_Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gen As New Random
        Code1.Text = (gen.Next(1000000))

        TextBox1.Visible = False

        Label25.Text = Bus_Id
        Label26.Text = Bus_Name
        Label27.Text = Bus_Type
        Label28.Text = Departure_Time
        Label29.Text = Arrival_Time
        Label34.Text = Bus_Date
        Label36.Text = Boarding_From
        Label35.Text = Departing_To
        Label33.Text = Seats_Number
        Label32.Text = Bus_Price
        Label31.Text = No_Of_Seats
        Label30.Text = Total_Amount




        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If


        conn.Open()
        Dim cmd1 As New SqlCommand("Select * from Register  where Username ='" + user_username + "' ", conn)
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

    Private Sub Label37_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        ' Dim fr As New Form3

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
            Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[User_BusTicketBooking]
           ([Booking_Id]
           ,[Username]
           ,[Gender]
           ,[Email_Id]
           ,[Phone_No]
           ,[Bus_Id]
           ,[Bus_Name]
           ,[Bus_Type]
           ,[Departure_Time]
           ,[Arrival_Time]
           ,[Date]
           ,[Boarding_From]
           ,[Departing_To]
           ,[Seats_Number]
           ,[Price]
           ,[No_Of_Seats]
           ,[Total_Amount])
     VALUES
           ('" + Code1.Text + "','" + Label4.Text + "','" + Label7.Text + "','" + Label9.Text + "','" + Label11.Text + "','" + Label25.Text + "','" + Label26.Text + "','" + Label27.Text + "','" + Label28.Text + "','" + Label29.Text + "','" + Label34.Text + "','" + Label36.Text + "','" + Label35.Text + "','" + Label33.Text + "','" + Label32.Text + "','" + Label31.Text + "','" + Label30.Text + "')", con)
            con.Open()
            cmd.ExecuteNonQuery()
            '  MessageBox.Show("You have successfully registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()


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
            TextBox1.AppendText(vbTab & Label20.Text + ": " + Label34.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label18.Text + ": " + Label36.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label19.Text + ": " + Label35.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label22.Text + " :" + Label33.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label21.Text + ": " + Label32.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label24.Text + ": " + Label31.Text + System.Environment.NewLine)
            TextBox1.AppendText("  " + System.Environment.NewLine)
            TextBox1.AppendText(vbTab & Label23.Text + " :" + Label30.Text + System.Environment.NewLine)


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

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim isave As New SaveFileDialog
        isave.Filter = "txt files (*.txt) |*.pdf"
        isave.FilterIndex = 2
        isave.RestoreDirectory = False

        If isave.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(isave.FileName, TextBox1.Text)
        End If
    End Sub
End Class