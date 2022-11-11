Imports System.Data
Imports System.Data.SqlClient
Imports chingoctatavia.Class1

Public Class Profile
    Dim conn As New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;")
    Dim cmd As New SqlCommand
    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.Open()
        Dim command As New SqlCommand("select * from Register where Username ='" + user_username + "'", conn)



        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("No data found")

        Else

            TextBox1.Text = table.Rows(0)(0).ToString()
            TextBox2.Text = table.Rows(0)(1).ToString()
            TextBox3.Text = table.Rows(0)(2).ToString()
            TextBox4.Text = table.Rows(0)(3).ToString()



        End If

        conn.Close()

    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Fields cannot be empty")

        Else

            Dim updateQuery As String = "UPDATE Register Set Email_Id='" & TextBox3.Text & "',Phone_No='" & TextBox4.Text & "'; WHERE Username='" & TextBox1.Text & "'"
            Dim Command As New SqlCommand(updateQuery, conn)


            ExecuteMyQuery(Command, "Saved")

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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
    End Sub
End Class