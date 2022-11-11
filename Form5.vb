Imports System.Data
Imports System.Data.SqlClient
Public Class Form5
    Dim connection As SqlConnection = New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True")
    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Fields cannot be empty")
        ElseIf TextBox2.Text <> TextBox1.Text Then
            MessageBox.Show("Confirm password and create password not Matching", "Error")
        Else

            Dim id As String = TextBox3.Text
            Dim query As String = "Select * from Register where Username = '" + TextBox3.Text + "'"
            Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;")
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter()
            da.SelectCommand = cmd
            Dim dt As New DataTable()
            da.Fill(dt)
            If dt.Rows.Count < 0 Then
                MessageBox.Show(" **Username incorrect", "Error")
            Else

                Dim updateQuery As String = "Update Register Set password = '" & TextBox1.Text & "' ,Confirm_Password = '" & TextBox2.Text & "' where Username='" & TextBox3.Text & "'"
                ExecuteQuery(updateQuery)
                MessageBox.Show("Password is reset ")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""

                Me.Hide()
                Form3.Show()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        TextBox1.Text = "" And TextBox2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        MessageBox.Equals(TextBox1.Text, TextBox2.Text)

    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True


        End If
    End Sub
End Class