<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.miniToolStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchBusesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetTicketDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelTicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RescheduleTicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HireBusesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(11, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1883, 132)
        Me.Panel1.TabIndex = 1
        '
        'miniToolStrip
        '
        Me.miniToolStrip.AccessibleName = "New item selection"
        Me.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
        Me.miniToolStrip.AutoSize = False
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.miniToolStrip.Location = New System.Drawing.Point(1004, 9)
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.Size = New System.Drawing.Size(1883, 46)
        Me.miniToolStrip.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HireBusesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 15, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1887, 59)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MyAccountToolStripMenuItem, Me.SearchBusesToolStripMenuItem, Me.GetTicketDetailsToolStripMenuItem, Me.CancelTicketToolStripMenuItem, Me.RescheduleTicketToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutUsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MenuToolStripMenuItem.Image = CType(resources.GetObject("MenuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MenuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(137, 42)
        Me.MenuToolStripMenuItem.Text = "Menu"
        Me.MenuToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MyAccountToolStripMenuItem
        '
        Me.MyAccountToolStripMenuItem.Image = CType(resources.GetObject("MyAccountToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MyAccountToolStripMenuItem.Name = "MyAccountToolStripMenuItem"
        Me.MyAccountToolStripMenuItem.Size = New System.Drawing.Size(503, 46)
        Me.MyAccountToolStripMenuItem.Text = "Profile"
        '
        'SearchBusesToolStripMenuItem
        '
        Me.SearchBusesToolStripMenuItem.Image = CType(resources.GetObject("SearchBusesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchBusesToolStripMenuItem.Name = "SearchBusesToolStripMenuItem"
        Me.SearchBusesToolStripMenuItem.Size = New System.Drawing.Size(503, 46)
        Me.SearchBusesToolStripMenuItem.Text = "Search Buses"
        '
        'GetTicketDetailsToolStripMenuItem
        '
        Me.GetTicketDetailsToolStripMenuItem.Image = CType(resources.GetObject("GetTicketDetailsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GetTicketDetailsToolStripMenuItem.Name = "GetTicketDetailsToolStripMenuItem"
        Me.GetTicketDetailsToolStripMenuItem.Size = New System.Drawing.Size(503, 46)
        Me.GetTicketDetailsToolStripMenuItem.Text = "Get Ticket Details"
        '
        'CancelTicketToolStripMenuItem
        '
        Me.CancelTicketToolStripMenuItem.Image = CType(resources.GetObject("CancelTicketToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CancelTicketToolStripMenuItem.Name = "CancelTicketToolStripMenuItem"
        Me.CancelTicketToolStripMenuItem.Size = New System.Drawing.Size(503, 46)
        Me.CancelTicketToolStripMenuItem.Text = "Cancel Bus Ticket"
        '
        'RescheduleTicketToolStripMenuItem
        '
        Me.RescheduleTicketToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.CancelBookingToolStripMenuItem})
        Me.RescheduleTicketToolStripMenuItem.Image = Global.chingoctatavia.My.Resources.Resources.lo
        Me.RescheduleTicketToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Red
        Me.RescheduleTicketToolStripMenuItem.Name = "RescheduleTicketToolStripMenuItem"
        Me.RescheduleTicketToolStripMenuItem.Size = New System.Drawing.Size(503, 46)
        Me.RescheduleTicketToolStripMenuItem.Text = "Rental Bus Booking Details"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(423, 46)
        Me.ViewToolStripMenuItem.Text = "View Booking Details"
        '
        'CancelBookingToolStripMenuItem
        '
        Me.CancelBookingToolStripMenuItem.Name = "CancelBookingToolStripMenuItem"
        Me.CancelBookingToolStripMenuItem.Size = New System.Drawing.Size(423, 46)
        Me.CancelBookingToolStripMenuItem.Text = "Cancel Booking"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Image = CType(resources.GetObject("HelpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(503, 46)
        Me.HelpToolStripMenuItem.Text = "Feedback"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Image = CType(resources.GetObject("AboutUsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(503, 46)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(503, 46)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'HireBusesToolStripMenuItem
        '
        Me.HireBusesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HireBusesToolStripMenuItem.Image = CType(resources.GetObject("HireBusesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HireBusesToolStripMenuItem.Name = "HireBusesToolStripMenuItem"
        Me.HireBusesToolStripMenuItem.Size = New System.Drawing.Size(179, 42)
        Me.HireBusesToolStripMenuItem.Text = "Hire_Bus"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Location = New System.Drawing.Point(9, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1887, 819)
        Me.Panel2.TabIndex = 3
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Image = Global.chingoctatavia.My.Resources.Resources.f1
        Me.PictureBox5.Location = New System.Drawing.Point(1336, -1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(77, 59)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 24
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.chingoctatavia.My.Resources.Resources.feedback11
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = Global.chingoctatavia.My.Resources.Resources.logout
        Me.PictureBox2.Location = New System.Drawing.Point(1647, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.chingoctatavia.My.Resources.Resources.feedback11
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1485, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gold
        Me.Button3.Font = New System.Drawing.Font("Stencil", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(276, 723)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(263, 68)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 62)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(209, 147)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "ddd dd - MM - yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Stencil", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(658, 639)
        Me.DateTimePicker1.MinDate = New Date(2022, 2, 23, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(875, 41)
        Me.DateTimePicker1.TabIndex = 19
        Me.DateTimePicker1.Value = New Date(2022, 2, 24, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Stencil", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(316, 622)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(261, 78)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = " Depart Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Font = New System.Drawing.Font("Stencil", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(646, 723)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(903, 68)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "SEARCH BUSES"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 28.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(534, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(879, 80)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "BOOK YOUR TICKET ONLINE"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Broadway", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(458, 544)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 47)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "TO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(420, 439)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 57)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "FROM"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Tin Factory,Bangalore", "Majestic,Bangalore", "Maniconda,Hyderabad", "Kacheguda,Hyderabad"})
        Me.ComboBox2.Location = New System.Drawing.Point(658, 545)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(875, 44)
        Me.ComboBox2.TabIndex = 12
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Tin Factory,Bangalore", "Majestic,Bangalore", "Maniconda,Hyderabad", "Kacheguda,Hyderabad"})
        Me.ComboBox1.Location = New System.Drawing.Point(658, 428)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(875, 44)
        Me.ComboBox1.TabIndex = 11
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(919, 906)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(175, 107)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.Location = New System.Drawing.Point(9, 833)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1891, 205)
        Me.DataGridView1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(818, 852)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(406, 38)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "YOU CAN ALSO BOOK"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents miniToolStrip As MenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MyAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchBusesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GetTicketDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelTicketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RescheduleTicketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HireBusesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelBookingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox5 As PictureBox
End Class
