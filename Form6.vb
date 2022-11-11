Imports System.Data
Imports System.Data.SqlClient
Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" AndAlso TextBox2.Text = "admin" Then
            MessageBox.Show("Login Successful")
            TextBox1.Text = ""
            TextBox2.Text = ""
            Me.Hide()
            Form8.Show()
        ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("Fields cannot be empty")


        Else
            MessageBox.Show("Error")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        UserAdminSelect.Show()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
End Class

