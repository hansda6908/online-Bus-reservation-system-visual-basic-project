Imports System.Data.SqlClient
Imports chingoctatavia.Class1
Public Class UserFeedback

    Dim conn As New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True")
    Dim cmd As New SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox1.Text = "" Then
            MessageBox.Show("Username or Text is empty")
        Else
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If


            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO User_Feedback(Username,Email_Id,satisfy,feedback,Date,Time)
     VALUES
           ('" + TextBox2.Text + "','" + TextBox3.Text + "',@satisfy ,'" + TextBox1.Text + "','" + DateTimePicker1.Text + "','" + Label10.Text + "') "
            Dim satisfy_v As String
            If RadioButton1.Checked = True Then
                satisfy_v = RadioButton1.Text
            ElseIf RadioButton2.Checked = True Then
                satisfy_v = RadioButton2.Text
            ElseIf RadioButton3.Checked = True Then
                satisfy_v = RadioButton3.Text
            ElseIf RadioButton4.Checked = True Then
                satisfy_v = RadioButton4.Text
            Else
                satisfy_v = RadioButton5.Text
            End If
            cmd.Parameters.AddWithValue("satisfy", satisfy_v)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Thank you for giving your feedback")

            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub UserFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label10.Text = TimeOfDay.ToString("hh:mm:ss tt")
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If


        conn.Open()
        Dim cmd As New SqlCommand("Select * from Admin_Feedback", conn)
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        If reader.Read Then


            Label8.Text = reader("Date")
            Label9.Text = reader("Time")
            Label4.Text = reader("reply")

        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ' stfy = "Very Satisfied"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ' stfy = "Satisfied"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        ' stfy = "Neutral"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        ' stfy = "Unsatisfied"
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        ' stfy = "Very Unsatisfied"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Label10.Text = TimeOfDay.ToString("hh:mm:ss tt")
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim query As String = "Select * from Register where Username = '" + user_username + "'"
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;")
        Dim cmd As SqlCommand = New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter()
        da.SelectCommand = cmd
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then

            TextBox3.Text = dt.Rows(0)(2).ToString()


        Else
            MessageBox.Show("Incorrect Username")

            TextBox2.Text = ""
            TextBox3.Text = ""


        End If
    End Sub

    Private Sub RadioButton5_Click(sender As Object, e As EventArgs) Handles RadioButton5.Click, RadioButton4.Click, RadioButton3.Click, RadioButton2.Click, RadioButton1.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class