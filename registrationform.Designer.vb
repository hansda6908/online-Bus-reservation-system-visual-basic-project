<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registrationform
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registrationform))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.gender = New System.Windows.Forms.Label()
        Me.combogender = New System.Windows.Forms.ComboBox()
        Me.cmdback = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpas = New System.Windows.Forms.TextBox()
        Me.txtconpas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdregister = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Stencil", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(409, -247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(993, 148)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ONLINE BUS TICKET RESERVATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-69, -247)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtusername)
        Me.Panel1.Controls.Add(Me.gender)
        Me.Panel1.Controls.Add(Me.combogender)
        Me.Panel1.Controls.Add(Me.cmdback)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtemail)
        Me.Panel1.Controls.Add(Me.txtphone)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtpas)
        Me.Panel1.Controls.Add(Me.txtconpas)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmdregister)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(2, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1922, 904)
        Me.Panel1.TabIndex = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.White
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(1344, 566)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(137, 45)
        Me.CheckBox1.TabIndex = 64
        Me.CheckBox1.Text = "Show"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(510, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 50)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Username"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtusername.Location = New System.Drawing.Point(832, 216)
        Me.txtusername.MaxLength = 25
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PlaceholderText = "Enter your name"
        Me.txtusername.Size = New System.Drawing.Size(494, 45)
        Me.txtusername.TabIndex = 50
        '
        'gender
        '
        Me.gender.BackColor = System.Drawing.Color.White
        Me.gender.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gender.Location = New System.Drawing.Point(510, 294)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(171, 61)
        Me.gender.TabIndex = 59
        Me.gender.Text = "Gender"
        Me.gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'combogender
        '
        Me.combogender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combogender.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.combogender.FormattingEnabled = True
        Me.combogender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.combogender.Location = New System.Drawing.Point(832, 309)
        Me.combogender.Name = "combogender"
        Me.combogender.Size = New System.Drawing.Size(494, 46)
        Me.combogender.TabIndex = 60
        '
        'cmdback
        '
        Me.cmdback.BackColor = System.Drawing.Color.Lime
        Me.cmdback.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cmdback.Location = New System.Drawing.Point(273, 767)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(320, 71)
        Me.cmdback.TabIndex = 61
        Me.cmdback.Text = "BACK"
        Me.cmdback.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(1395, 767)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(254, 71)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(510, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 52)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Email Id"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtemail.Location = New System.Drawing.Point(832, 391)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PlaceholderText = "Enter your email id"
        Me.txtemail.Size = New System.Drawing.Size(494, 45)
        Me.txtemail.TabIndex = 55
        '
        'txtphone
        '
        Me.txtphone.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtphone.Location = New System.Drawing.Point(832, 476)
        Me.txtphone.MaxLength = 10
        Me.txtphone.Name = "txtphone"
        Me.txtphone.PlaceholderText = "Enter your phone No."
        Me.txtphone.Size = New System.Drawing.Size(494, 45)
        Me.txtphone.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(510, 469)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 52)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Phone No."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtpas
        '
        Me.txtpas.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtpas.Location = New System.Drawing.Point(823, 566)
        Me.txtpas.Name = "txtpas"
        Me.txtpas.PlaceholderText = "Create your password"
        Me.txtpas.Size = New System.Drawing.Size(494, 45)
        Me.txtpas.TabIndex = 57
        Me.txtpas.UseSystemPasswordChar = True
        '
        'txtconpas
        '
        Me.txtconpas.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtconpas.Location = New System.Drawing.Point(832, 665)
        Me.txtconpas.Name = "txtconpas"
        Me.txtconpas.PlaceholderText = "Re-enter your Password"
        Me.txtconpas.Size = New System.Drawing.Size(494, 45)
        Me.txtconpas.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(501, 563)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 48)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Password"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdregister
        '
        Me.cmdregister.BackColor = System.Drawing.Color.Lime
        Me.cmdregister.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cmdregister.Location = New System.Drawing.Point(652, 767)
        Me.cmdregister.Name = "cmdregister"
        Me.cmdregister.Size = New System.Drawing.Size(694, 71)
        Me.cmdregister.TabIndex = 62
        Me.cmdregister.Text = "REGISTER"
        Me.cmdregister.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(474, 653)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(231, 57)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Confirm Password"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Stencil", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(558, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(801, 60)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "REGISTER YOURSELF TO GET AMAZING OFFERS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(285, 143)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(485, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1086, 105)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ONLINE BUS RESERVATION"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'registrationform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "registrationform"
        Me.Text = "registrationform"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents gender As Label
    Friend WithEvents combogender As ComboBox
    Friend WithEvents cmdback As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpas As TextBox
    Friend WithEvents txtconpas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdregister As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents CheckBox1 As CheckBox
End Class
