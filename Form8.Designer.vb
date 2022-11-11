<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBusDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PassengersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPasengersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBookingDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentalBusDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBusToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewRentalBusBookingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(353, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1471, 148)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Bus Reservation System"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterEntryToolStripMenuItem, Me.PassengersToolStripMenuItem, Me.BookingDetailsToolStripMenuItem, Me.RentalBusDetailsToolStripMenuItem, Me.ViewFeedbackToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 10, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1924, 55)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterEntryToolStripMenuItem
        '
        Me.MasterEntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBusToolStripMenuItem, Me.ViewBusDetailsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MasterEntryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MasterEntryToolStripMenuItem.Name = "MasterEntryToolStripMenuItem"
        Me.MasterEntryToolStripMenuItem.Size = New System.Drawing.Size(212, 42)
        Me.MasterEntryToolStripMenuItem.Text = "Master Entry"
        '
        'AddBusToolStripMenuItem
        '
        Me.AddBusToolStripMenuItem.Name = "AddBusToolStripMenuItem"
        Me.AddBusToolStripMenuItem.Size = New System.Drawing.Size(357, 46)
        Me.AddBusToolStripMenuItem.Text = "Add Bus"
        '
        'ViewBusDetailsToolStripMenuItem
        '
        Me.ViewBusDetailsToolStripMenuItem.Name = "ViewBusDetailsToolStripMenuItem"
        Me.ViewBusDetailsToolStripMenuItem.Size = New System.Drawing.Size(357, 46)
        Me.ViewBusDetailsToolStripMenuItem.Text = "View Bus Details"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(357, 46)
        '
        'PassengersToolStripMenuItem
        '
        Me.PassengersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPasengersToolStripMenuItem})
        Me.PassengersToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PassengersToolStripMenuItem.Name = "PassengersToolStripMenuItem"
        Me.PassengersToolStripMenuItem.Size = New System.Drawing.Size(110, 42)
        Me.PassengersToolStripMenuItem.Text = "Users"
        '
        'AddPasengersToolStripMenuItem
        '
        Me.AddPasengersToolStripMenuItem.Name = "AddPasengersToolStripMenuItem"
        Me.AddPasengersToolStripMenuItem.Size = New System.Drawing.Size(306, 46)
        Me.AddPasengersToolStripMenuItem.Text = "Users Details"
        '
        'BookingDetailsToolStripMenuItem
        '
        Me.BookingDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewBookingDetailsToolStripMenuItem})
        Me.BookingDetailsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BookingDetailsToolStripMenuItem.Name = "BookingDetailsToolStripMenuItem"
        Me.BookingDetailsToolStripMenuItem.Size = New System.Drawing.Size(259, 42)
        Me.BookingDetailsToolStripMenuItem.Text = "Booking_Details"
        '
        'ViewBookingDetailsToolStripMenuItem
        '
        Me.ViewBookingDetailsToolStripMenuItem.Name = "ViewBookingDetailsToolStripMenuItem"
        Me.ViewBookingDetailsToolStripMenuItem.Size = New System.Drawing.Size(451, 46)
        Me.ViewBookingDetailsToolStripMenuItem.Text = "View Bus Ticket Details"
        '
        'RentalBusDetailsToolStripMenuItem
        '
        Me.RentalBusDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBusToolStripMenuItem1, Me.ViewRentalBusBookingsToolStripMenuItem})
        Me.RentalBusDetailsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RentalBusDetailsToolStripMenuItem.Name = "RentalBusDetailsToolStripMenuItem"
        Me.RentalBusDetailsToolStripMenuItem.Size = New System.Drawing.Size(291, 42)
        Me.RentalBusDetailsToolStripMenuItem.Text = "Rental_Bus Details"
        '
        'AddBusToolStripMenuItem1
        '
        Me.AddBusToolStripMenuItem1.Name = "AddBusToolStripMenuItem1"
        Me.AddBusToolStripMenuItem1.Size = New System.Drawing.Size(489, 46)
        Me.AddBusToolStripMenuItem1.Text = "Add Rental Buses"
        '
        'ViewRentalBusBookingsToolStripMenuItem
        '
        Me.ViewRentalBusBookingsToolStripMenuItem.Name = "ViewRentalBusBookingsToolStripMenuItem"
        Me.ViewRentalBusBookingsToolStripMenuItem.Size = New System.Drawing.Size(489, 46)
        Me.ViewRentalBusBookingsToolStripMenuItem.Text = "View Rental Bus Bookings"
        '
        'ViewFeedbackToolStripMenuItem
        '
        Me.ViewFeedbackToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ViewFeedbackToolStripMenuItem.Name = "ViewFeedbackToolStripMenuItem"
        Me.ViewFeedbackToolStripMenuItem.Size = New System.Drawing.Size(244, 42)
        Me.ViewFeedbackToolStripMenuItem.Text = "View_Feedback"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.chingoctatavia.My.Resources.Resources.feedback11
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = Global.chingoctatavia.My.Resources.Resources.logout
        Me.PictureBox2.Location = New System.Drawing.Point(1691, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form8"
        Me.Text = "Form8"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PassengersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddBusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewBusDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPasengersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewBookingDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RentalBusDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddBusToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewFeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ViewRentalBusBookingsToolStripMenuItem As ToolStripMenuItem
End Class
