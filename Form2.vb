Imports System.Data
Imports System.Data.SqlClient
Public Class Form2

    Dim conn As New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;")
    Dim cmd As New SqlCommand
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Visible = False






    End Sub
    Public Sub Disp_data()
        Dim reader As SqlDataReader
        Dim query, user As String
        Dim dt As New DataTable()
        query = "select * from Bus_Lists where Boarding_From='" & ComboBox1.SelectedItem & "' and Departing_To='" & ComboBox2.SelectedItem & "'"
        cmd = New SqlCommand(query, conn)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            user = ComboBox1.SelectedItem
        End If
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub BusTicketsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HomeToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub LoginSignUpToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BusTicketsToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label2_Click_2(sender As Object, e As EventArgs)
        Form3.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)














    End Sub

    Private Sub ADMINToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "" Or ComboBox2.SelectedItem = "" Then
            MessageBox.Show("Fields cannot be empty.")
        ElseIf ComboBox2.SelectedItem = ComboBox1.SelectedItem Then
            MessageBox.Show("Source and Destination cannot be same")
        Else
            DataGridView1.Visible = True
            If conn.State = ConnectionState.Open Then
                conn.Close()

            End If
            conn.Open()
            Dim query As String
            query = "SELECT * from Bus_Lists where Boarding_From='" + ComboBox1.SelectedItem + "' and Departing_To='" + ComboBox2.SelectedItem + "'"
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            cmd = New SqlCommand(query, conn)


            da.Fill(dt)
            DataGridView1.DataSource = dt

            conn.Close()


        End If

    End Sub

    Private Sub MyAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyAccountToolStripMenuItem.Click
        Profile.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        registrationform.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)








    End Sub

    Private Sub SignInToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form6.Show()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button3.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to close the app", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.Yes Then
            End
        End If



    End Sub

    Private Sub AdminLoginToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form6.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        User_Rent_Buses.Show()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        If ComboBox1.SelectedText = Text And ComboBox2.SelectedText = Text Then
            ComboBox1.SelectedText = "" AndAlso ComboBox2.SelectedText = ""

        End If
    End Sub

    Private Sub SearchBusesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchBusesToolStripMenuItem.Click

        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub HireBusesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HireBusesToolStripMenuItem.Click
        Me.Hide()
        User_Rent_Buses.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.CustomFormat = "ddd dd MMM yyyy"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim frm As New Form10


        frm.txtbusid.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        frm.txtbusname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        frm.txtbustype.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        frm.txtdeptime.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        frm.txtarrtime.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        frm.txtboardfrom.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        frm.txtdepto.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        frm.txtprice.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()



        frm.Show()

        DataGridView1.Visible = False

    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to close the app", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()

        End If

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Profile.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        About_us.Show()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        UserFeedback.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        UserFeedback.Show()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click

    End Sub

    Private Sub GetTicketDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetTicketDetailsToolStripMenuItem.Click
        Get_Ticket_Details.Show()
    End Sub

    Private Sub CancelTicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelTicketToolStripMenuItem.Click
        Cancel_Bus_Ticket.Show()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        View_Rental_Bus_Booking_Details.Show()
    End Sub

    Private Sub CancelBookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelBookingToolStripMenuItem.Click
        Cancel_RentalBusBooking.Show()
    End Sub
End Class