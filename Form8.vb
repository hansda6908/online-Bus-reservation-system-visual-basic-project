Public Class Form8
    Private Sub MasterEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterEntryToolStripMenuItem.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub AddBusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddBusToolStripMenuItem.Click
        Add_Bus.Show()
    End Sub

    Private Sub ViewBusDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBusDetailsToolStripMenuItem.Click
        View_Bus_Details.Show()

    End Sub

    Private Sub AddBusToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddBusToolStripMenuItem1.Click
        Edit_Rental_Buses.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub AddPasengersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPasengersToolStripMenuItem.Click
        Admin_Userview.Show()
    End Sub

    Private Sub ViewCancelBookingTicketsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RentalBusDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RentalBusDetailsToolStripMenuItem.Click

    End Sub

    Private Sub ViewRentalBusBookingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRentalBusBookingsToolStripMenuItem.Click
        Admin_View_UserRentalBookings.Show()
    End Sub

    Private Sub ViewFeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFeedbackToolStripMenuItem.Click
        Admin_FeedbackReply.Show()
    End Sub

    Private Sub ViewBookingDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBookingDetailsToolStripMenuItem.Click
        Admin_UserBusTickets.Show()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class