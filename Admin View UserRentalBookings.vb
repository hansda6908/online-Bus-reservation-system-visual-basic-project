Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Class Admin_View_UserRentalBookings
    Dim conn As New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True")

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Admin_View_UserRentalBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand("select * from User_RentalBus_Booking", conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False


        DataGridView1.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table

        imgc = DataGridView1.Columns(9)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim img As Byte()
        img = DataGridView1.CurrentRow.Cells(9).Value
        Dim ms As New MemoryStream(img)
        PictureBox2.Image = Image.FromStream(ms)

        Code1.Text = DataGridView1.CurrentRow.Cells(0).Value
        Label25.Text = DataGridView1.CurrentRow.Cells(1).Value
        Label26.Text = DataGridView1.CurrentRow.Cells(2).Value
        Label27.Text = DataGridView1.CurrentRow.Cells(3).Value
        Label28.Text = DataGridView1.CurrentRow.Cells(4).Value
        Label29.Text = DataGridView1.CurrentRow.Cells(5).Value
        Label19.Text = DataGridView1.CurrentRow.Cells(6).Value
        Label22.Text = DataGridView1.CurrentRow.Cells(7).Value
        Label24.Text = DataGridView1.CurrentRow.Cells(8).Value
        Label4.Text = DataGridView1.CurrentRow.Cells(10).Value
        Label7.Text = DataGridView1.CurrentRow.Cells(11).Value
        Label9.Text = DataGridView1.CurrentRow.Cells(12).Value
        Label11.Text = DataGridView1.CurrentRow.Cells(13).Value
    End Sub
End Class