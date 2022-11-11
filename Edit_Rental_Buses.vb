Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class Edit_Rental_Buses
    Dim conn As New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)

        End If
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

    End Sub

    Private Sub Edit_Rental_Buses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cmd As New SqlCommand("select * from Rental_Buses", conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False


        DataGridView1.RowTemplate.Height = 200
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table

        imgc = DataGridView1.Columns(5)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)

        End If
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim img As Byte()
        img = DataGridView1.CurrentRow.Cells(5).Value
        Dim ms As New MemoryStream(img)
        PictureBox1.Image = Image.FromStream(ms)

        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(4).Value
        Button2.Enabled = False
        Button3.Enabled = True
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then

            MessageBox.Show("Fields cannot be empty")


        Else
            Dim command As New SqlCommand("select * from Rental_Buses WHERE Bus_Id = @Bus_Id", conn)

            command.Parameters.Add("@Bus_Id", SqlDbType.Int).Value = TextBox1.Text

            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)

            If table.Rows.Count() >= 0 Then
                MessageBox.Show("Bus Id already exist")
            Else
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                conn.Open()
                Dim ms As New MemoryStream
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                Dim img() As Byte
                img = ms.ToArray()
                Dim insertQuery As String = "INSERT INTO Rental_Buses(Bus_Id,Bus_Name,Bus_Type,Price_Per_Day,Pick_From,the_Image) Values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.SelectedItem.ToString() & "', @img)"

                Dim Command1 As New SqlCommand(insertQuery, conn)
                Command1.Parameters.Add("@img", SqlDbType.Image).Value = img

                ExecuteMyQuery(Command1, "Image inserted")

                display()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                ComboBox1.Text = ""
                PictureBox1.Image = Nothing
                conn.Close()
            End If
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("Fields cannot be empty")


        Else

            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim img() As Byte
            img = ms.ToArray()
            Dim updateQuery As String = "UPDATE Rental_Buses SET Bus_Name='" & TextBox2.Text & "',Bus_Type='" & TextBox3.Text & "',Price_Per_Day='" & TextBox4.Text & "',Pick_From='" & ComboBox1.SelectedItem & "',the_Image= @img WHERE Bus_Id='" & TextBox1.Text & "'"
            Dim Command As New SqlCommand(updateQuery, conn)
            Command.Parameters.Add("@img", SqlDbType.Image).Value = img

            ExecuteMyQuery(Command, "Data Updated")
            display()

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            ComboBox1.Text = ""
            PictureBox1.Image = Nothing

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("Fields cannot be empty")

        Else

            Dim deleteQuery As String = "DELETE FROM Rental_Buses WHERE Bus_Id='" & TextBox1.Text & "'"

            Dim Command As New SqlCommand(deleteQuery, conn)


            ExecuteMyQuery(Command, "Data Deleted")
            display()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            ComboBox1.Text = ""
            PictureBox1.Image = Nothing
        End If
    End Sub

    Public Sub populateDatagridview(valueToSearch As String)

        Dim searchQuery As String = "SELECT * From Rental_Buses WHERE CONCAT(Bus_Id,Bus_Name,Bus_Type,Price_Per_Day,Pick_From) like '%" & valueToSearch & "%'"

        Dim cmd As New SqlCommand(searchQuery, conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False


        DataGridView1.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table

        imgc = DataGridView1.Columns(5)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        populateDatagridview(TextBox5.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Bus Id required")
        Else

            Dim command As New SqlCommand("select * from Rental_Buses WHERE Bus_Id = @Bus_Id", conn)

            command.Parameters.Add("@Bus_Id", SqlDbType.Int).Value = TextBox1.Text

            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then
                MessageBox.Show("No data found")
                TextBox1.Text = ""
                Button3.Enabled = False
                Button2.Enabled = True
            Else

                TextBox1.Text = table.Rows(0)(0).ToString()
                TextBox2.Text = table.Rows(0)(1).ToString()
                TextBox3.Text = table.Rows(0)(2).ToString()
                TextBox4.Text = table.Rows(0)(3).ToString()
                ComboBox1.Text = table.Rows(0)(4).ToString()

                Dim img() As Byte

                img = table.Rows(0)(5)

                Dim ms As New MemoryStream(img)
                PictureBox1.Image = Image.FromStream(ms)
                Button2.Enabled = False
                Button3.Enabled = True
            End If
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        PictureBox1.Image = Nothing
        Button2.Enabled = True

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub display()
        Dim cmd As New SqlCommand("select * from Rental_Buses", conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False


        DataGridView1.RowTemplate.Height = 200
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table

        imgc = DataGridView1.Columns(5)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
End Class