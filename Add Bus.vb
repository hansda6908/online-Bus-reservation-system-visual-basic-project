Imports System.Data
Imports System.Data.SqlClient
Public Class Add_Bus

    Dim conn As New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim i As Integer

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Add_Bus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;"
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        conn.Open()

        ' disp_Data()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Bus_Lists"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox1.SelectedItem = ""
        ComboBox2.SelectedItem = ""
        Button1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then

            MessageBox.Show("Fields cannot be empty")

        ElseIf DateTimePicker2.Text = DateTimePicker1.Text Then
            MessageBox.Show("Departure Time and Arrival Time cannot be same")

        Else

            Dim id As Integer = TextBox1.Text
            Dim query As String = "Select * from Bus_Lists where Bus_Id = '" + TextBox1.Text + "'"
            Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;")
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter()
            da.SelectCommand = cmd
            Dim dt As New DataTable()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MessageBox.Show("Bus Id already exist", "Error")
            Else

                cmd = conn.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO [dbo].[Bus_Lists]
           ([Bus_Id]
           ,[Bus_Name]
           ,[Bus_Type]
           ,[Departure_Time]
           ,[Arrival_Time]
           ,[Boarding_From]
           ,[Departing_To]
           ,[Price])
     VALUES
           ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + DateTimePicker1.Text + "','" + DateTimePicker2.Text + "','" + ComboBox1.Text.ToString() + "','" + ComboBox2.Text.ToString() + "','" + TextBox4.Text + "') "
                cmd.ExecuteNonQuery()

                MessageBox.Show("Data inserted succesfully")
                disp_Data()
                ' Me.DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, DateTimePicker1.Text, DateTimePicker2.Text, ComboBox1.Text, ComboBox2.Text, TextBox4.Text)



                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                ComboBox1.Text = ""
                ComboBox2.Text = ""
                ComboBox1.SelectedItem = ""
                ComboBox2.SelectedItem = ""
            End If
        End If
    End Sub


    Public Sub disp_Data()

        cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Bus_Lists"
        cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt


    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If conn.State = ConnectionState.Open Then
            conn.Close()

        End If

        conn.Open()



        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        DateTimePicker1.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        DateTimePicker2.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        ComboBox2.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        TextBox4.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        Button1.Enabled = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        conn.Open()

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.SelectedItem = "" Or ComboBox2.SelectedItem = "" Then
            MessageBox.Show("Fields cannot be empty")
        Else
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Update Bus_Lists Set  Bus_Name='" + TextBox2.Text + "' , Bus_Type='" + TextBox3.Text + "', Departure_Time ='" + DateTimePicker1.Text + "' , Arrival_Time='" + DateTimePicker2.Text + "' , Boarding_From='" + ComboBox1.SelectedItem.ToString() + "' , Departing_To='" + ComboBox2.SelectedItem.ToString() + "' , Price='" + TextBox4.Text + "' where Bus_Id = '" + TextBox1.Text + "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Updated")
            disp_Data()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox1.SelectedItem = ""
            ComboBox2.SelectedItem = ""

        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As Integer = TextBox1.Text
        Dim query As String = "Select * from Bus_Lists where Bus_Id = '" + TextBox1.Text + "'"
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;")
        Dim cmd As SqlCommand = New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter()
        da.SelectCommand = cmd
        Dim dt As New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            TextBox2.Text = dt.Rows(0)(1).ToString()
            TextBox3.Text = dt.Rows(0)(2).ToString()
            DateTimePicker1.Text = dt.Rows(0)(3).ToString()
            DateTimePicker2.Text = dt.Rows(0)(4).ToString()
            ComboBox1.Text = dt.Rows(0)(5).ToString()
            ComboBox2.Text = dt.Rows(0)(6).ToString()
            TextBox4.Text = dt.Rows(0)(7).ToString()
            Button1.Enabled = False
        Else
            MessageBox.Show("Bus_Id doesn't exist")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox1.SelectedItem = ""
            ComboBox2.SelectedItem = ""
            Button1.Enabled = True

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Or TextBox2.Text = " " Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.SelectedItem = "" Or ComboBox2.SelectedItem = "" Then
            MessageBox.Show("Fields are empty")
        Else
            disp_Data()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '  For Each row As DataGridViewRow In DataGridView1.SelectedRows
        'DataGridView1.Rows.Remove(row)
        ' Next
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()

        ElseIf TextBox1.Text = "" Or TextBox2.Text = " " Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.SelectedItem = "" Or ComboBox2.SelectedItem = "" Then
            MessageBox.Show("Fields are empty")

        Else

            Try
                cmd = conn.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Delete from Bus_Lists where Bus_Id ='" + TextBox1.Text + "'"
                cmd.ExecuteNonQuery()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                ComboBox1.Text = ""
                ComboBox2.Text = ""
                ComboBox1.SelectedItem = ""
                ComboBox2.SelectedItem = ""

                disp_Data()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Bus Id cannot be empty")
        Else
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Bus_Lists where Bus_Id = '" + TextBox1.Text + "'"
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If Not IsNumeric(Me.TextBox4.Text) Then
            Me.ErrorProvider1.SetError(Me.TextBox4, " Enter Numbers only .")
            Button1.Enabled = False
            Button4.Enabled = False
            Button6.Enabled = False
            Return
        Else
            Me.ErrorProvider1.SetError(Me.TextBox4, "")
            Button1.Enabled = True
            Button4.Enabled = True
            Button6.Enabled = True
        End If
    End Sub
End Class