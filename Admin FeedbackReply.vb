Imports System.Data.SqlClient
Public Class Admin_FeedbackReply
    Dim conn As New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;")
    Dim cmd As New SqlCommand
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        DateTimePicker2.Value.TimeOfDay.ToString("hh:mm:ss")
        DateTimePicker1.Value.Date.ToString("dd-MM-yyyy")
    End Sub

    Private Sub Admin_FeedbackReply_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conn As New SqlConnection
        Dim ds As New DataSet
        conn = New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;")
        Dim user As String = "Select * from User_Feedback"
        Dim adapter As New SqlDataAdapter(user, conn)
        conn.Open()
        adapter.Fill(ds, "User_Feedback")
        DataGridView1.DataSource = ds.Tables("User_Feedback")

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()

        End If

        conn.Open()



        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        Label4.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString() + System.Environment.NewLine + DataGridView1.CurrentRow.Cells(3).Value.ToString()

        DateTimePicker1.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        DateTimePicker2.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("Username or reply box is empty", "Error")

        Else
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Admin_Feedback(Username,Email_Id,Date,Time,reply)
     VALUES
           ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + DateTimePicker1.Text + "','" + DateTimePicker2.Text + "','" + TextBox3.Text + "') "
            cmd.ExecuteNonQuery()



            MessageBox.Show("Reply sent")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            Label4.Text = ""



        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Label11.Text = DateTimePicker2.Text
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Label10.Text = DateTimePicker1.Text
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub display()
        Dim conn As New SqlConnection
        Dim ds As New DataSet
        conn = New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;")
        Dim user As String = "Select * from Admin_Feedback"
        Dim adapter As New SqlDataAdapter(user, conn)
        conn.Open()
        adapter.Fill(ds, "Admin_Feedback")
        DataGridView1.DataSource = ds.Tables("Admin_Feedback")
    End Sub

    Private Sub DataGridView2_DoubleClick(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("Username or reply box is empty", "Error")

        Else
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from Admin_Feedback where Username='" + TextBox1.Text + "'and reply='" + TextBox3.Text + "'"
            display()
            TextBox1.Text = ""
            TextBox2.Text = ""
            DateTimePicker1.Text = DateTimePicker1.Value.Date.ToString("dd-MM-yyyy")
            DateTimePicker2.Text = TimeOfDay.ToString("hh:mm:ss")
        End If

    End Sub
End Class