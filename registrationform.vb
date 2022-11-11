Imports System.Data
Imports System.Data.SqlClient
Public Class registrationform
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True")

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub combogender_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdregister_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtemail_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtconpas_TextChanged(sender As Object, e As EventArgs)
        If Equals(txtconpas.Text, txtpas.Text) Then
            MessageBox.Show("Password matching")
        Else
            MessageBox.Show("Password not matching")


        End If


    End Sub

    Private Sub txtphone_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdback_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If (txtusername.Text = Text Or combogender.SelectedItem = Text Or txtemail.Text = Text Or txtphone.Text = Text Or txtpas.Text = Text Or txtconpas.Text = Text) Then
            txtusername.Text = "" And combogender.SelectedItem = "" And txtemail.Text = "" And txtphone.Text = "" And txtpas.Text = "" And txtconpas.Text = ""
        End If
    End Sub

    Private Sub cmdback_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdback_Click_2(sender As Object, e As EventArgs) Handles cmdback.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub cmdregister_Click_1(sender As Object, e As EventArgs) Handles cmdregister.Click
        If cmdregister.Enabled = False Then
            MessageBox.Show("Some requirements are incorrect")
        ElseIf txtusername.Text = "" Then
            MessageBox.Show("*Username required")
        ElseIf combogender.Text = "" Then
            MessageBox.Show("*select gender")
        ElseIf txtemail.Text = "" Then
            MessageBox.Show(" *Email Id required ")
        ElseIf txtphone.Text = "" Then
            MessageBox.Show(" *Phone Number required ")
        ElseIf txtpas.Text = "" Then
            MessageBox.Show(" *password required ")
        ElseIf txtconpas.Text = "" Then
            MessageBox.Show(" *Confirm the password  ")



        Else


            Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[Register]
           ([Username]
           ,[Gender]
           ,[Email_Id]
           ,[Phone_No]
           ,[Password]
           ,[Confirm_Password])
     VALUES
           ('" + txtusername.Text + "','" + combogender.SelectedItem.ToString() + "','" + txtemail.Text + "','" + txtphone.Text + "','" + txtpas.Text + "','" + txtconpas.Text + "')", con)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("You have successfully registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            Me.Hide()
            Form3.Show()

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        txtusername.Text = ""
        combogender.Text = ""
        txtemail.Text = ""
        txtphone.Text = ""
        txtpas.Text = ""
        txtconpas.Text = ""

    End Sub

    Private Sub txtphone_TextChanged_1(sender As Object, e As EventArgs) Handles txtphone.TextChanged


        If Not IsNumeric(Me.txtphone.Text) Then
            Me.ErrorProvider1.SetError(Me.txtphone, " Enter Numbers only .")
            cmdregister.Enabled = False
            Return
        Else
            Me.ErrorProvider1.SetError(Me.txtphone, "")
            cmdregister.Enabled = True
        End If

        If txtphone.Text.Length <> 10 Then
            Me.ErrorProvider1.SetError(Me.txtphone, "Please enter 10 digit number")
            cmdregister.Enabled = False
        Else
            Me.ErrorProvider1.SetError(Me.txtphone, "")
            cmdregister.Enabled = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpas.UseSystemPasswordChar = False
        Else
            txtpas.UseSystemPasswordChar = True


        End If
    End Sub

    Private Sub txtconpas_TextChanged_1(sender As Object, e As EventArgs) Handles txtconpas.TextChanged
        If txtpas.Text <> "" And txtpas.Text = txtconpas.Text Then
            ErrorProvider1.SetError(txtconpas, "")
            cmdregister.Enabled = True
        Else
            ErrorProvider1.SetError(txtconpas, "Password and confirm password not matching")
            cmdregister.Enabled = False
        End If
    End Sub

    Private Sub registrationform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class