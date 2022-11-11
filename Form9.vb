Imports System.Data
Imports System.Data.SqlClient
Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        Dim conn As New SqlConnection
        Dim ds As New DataSet
        conn = New SqlConnection("Data Source=DESKTOP-27GMAH0\SQLEXPRESS;Initial Catalog=myself;Integrated Security=True;")
        Dim user As String = "Select * from Bus_Lists"
        Dim adapter As New SqlDataAdapter(user, conn)
        conn.Open()
        adapter.Fill(ds, "Bus_Lists")
        DataGridView1.DataSource = ds.Tables("Bus_Lists")


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label52_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
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
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub
End Class