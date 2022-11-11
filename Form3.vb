Imports System.Data
Imports System.Data.SqlClient
Imports chingoctatavia.Class1
Public Class Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Form2.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader
        Dim ds As New DataSet
        Dim adapter As New SqlDataAdapter
        Dim query, user As String

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Username and Password requried")
        Else
            conn = New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;")
            conn.Open()
            query = "select Username,Password from Register where Username='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "'"
            cmd = New SqlCommand(query, conn)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                user = TextBox1.Text
                MessageBox.Show("You have successfully logged in")

                user_username = TextBox1.Text
                Me.Close()
                Form2.Show()
            Else
                MessageBox.Show("Invalid Username or Password")

            End If

        End If
        conn.Close()





    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        registrationform.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form5.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        UserAdminSelect.Show()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True


        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class