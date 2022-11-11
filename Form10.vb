Imports chingoctatavia.Class1
Imports System.Data.SqlClient


Public Class Form10
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            CheckBox11.BackColor = Color.Red

        Else
            CheckBox11.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Form10_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim frm As New Form2

        Txtdate.Text = frm.DateTimePicker1.Value.Date
    End Sub
    Private Sub CheckBox_Clk()






        Dim count As Integer
        Dim myList As New List(Of String)


        count = 0
        For Each cb As CheckBox In Panel1.Controls.OfType(Of CheckBox)
            If cb.Checked Then
                count += 1
                myList.Add(cb.Text)
            End If
        Next
        MessageBox.Show(count.ToString, "Number of Seats")
        MessageBox.Show(String.Join(", ", myList), "Seat Number")

        Txtseats.Text = count
        txtseatno.Text = String.Join(", ", myList).ToString





        ' Dim c As Control

        'For Each c In Me.Controls
        ' TypeOf (c) Is CheckBox Then
        'CType(c, CheckBox).Image = My.Resources.Sleeper
        'End If
        ' Next
    End Sub
    Private Sub txtdate_TextChanged(sender As Object, e As EventArgs) Handles Txtdate.TextChanged

    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then
            CheckBox2.BackColor = Color.Red
        Else
            CheckBox2.BackColor = Color.GreenYellow



        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.BackColor = Color.Red

        Else
            CheckBox1.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = True Then
            CheckBox12.BackColor = Color.Red


        Else
            CheckBox12.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox4.BackColor = Color.Red

        Else
            CheckBox4.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox3.BackColor = Color.Red

        Else
            CheckBox3.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            CheckBox13.BackColor = Color.Red

        Else
            CheckBox13.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            CheckBox6.BackColor = Color.Red

        Else
            CheckBox6.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox5.BackColor = Color.Red

        Else
            CheckBox5.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            CheckBox14.BackColor = Color.Red

        Else
            CheckBox14.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            CheckBox8.BackColor = Color.Red

        Else
            CheckBox8.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            CheckBox7.BackColor = Color.Red

        Else
            CheckBox7.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked = True Then
            CheckBox15.BackColor = Color.Red

        Else
            CheckBox15.BackColor = Color.GreenYellow
            'txtseatno.Text = ""
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            CheckBox10.BackColor = Color.Red

        Else
            CheckBox10.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            CheckBox9.BackColor = Color.Red

        Else
            CheckBox9.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox26_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox26.CheckedChanged
        If CheckBox26.Checked = True Then
            CheckBox26.BackColor = Color.Red

        Else
            CheckBox26.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked = True Then
            CheckBox17.BackColor = Color.Red

        Else
            CheckBox17.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked = True Then
            CheckBox16.BackColor = Color.Red

        Else
            CheckBox16.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked = True Then
            CheckBox18.BackColor = Color.Red

        Else
            CheckBox18.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.Checked = True Then
            CheckBox19.BackColor = Color.Red

        Else
            CheckBox19.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
        If CheckBox20.Checked = True Then
            CheckBox20.BackColor = Color.Red

        Else
            CheckBox20.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.Checked = True Then
            CheckBox21.BackColor = Color.Red


        Else
            CheckBox21.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox22_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.Checked = True Then
            CheckBox22.BackColor = Color.Red

        Else
            CheckBox22.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked = True Then
            CheckBox23.BackColor = Color.Red

        Else
            CheckBox23.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox24_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.Checked = True Then
            CheckBox24.BackColor = Color.Red

        Else
            CheckBox24.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox25_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox25.CheckedChanged
        If CheckBox25.Checked = True Then
            CheckBox25.BackColor = Color.Red

        Else
            CheckBox25.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox27_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox27.CheckedChanged
        If CheckBox27.Checked = True Then
            CheckBox27.BackColor = Color.Red

        Else
            CheckBox27.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox28_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox28.CheckedChanged
        If CheckBox28.Checked = True Then
            CheckBox28.BackColor = Color.Red

        Else
            CheckBox28.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox29_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox29.CheckedChanged
        If CheckBox29.Checked = True Then
            CheckBox29.BackColor = Color.Red

        Else
            CheckBox29.BackColor = Color.GreenYellow

        End If
    End Sub

    Private Sub CheckBox30_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox30.CheckedChanged
        If CheckBox30.Checked = True Then
            CheckBox30.BackColor = Color.Red

        Else
            CheckBox30.BackColor = Color.GreenYellow

        End If
    End Sub



    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click

    End Sub

    Private Sub txtamt_TextChanged(sender As Object, e As EventArgs) Handles txtamt.TextChanged

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtseatno.Text = "" Or Txtseats.Text = "" Or txtamt.Text = "" Or txtamt.Text = "0" Or txtseatno.Text = "0" Then
            MessageBox.Show("Please select the seats")

        Else

            Bus_Id = txtbusid.Text
            Bus_Name = txtbusname.Text
            Bus_Type = txtbustype.Text
            Departure_Time = txtdeptime.Text
            Arrival_Time = txtarrtime.Text
            Boarding_From = txtboardfrom.Text
            Departing_To = txtdepto.Text
            Bus_Date = Txtdate.Text
            Bus_Price = txtprice.Text
            Seats_Number = txtseatno.Text
            No_Of_Seats = Txtseats.Text
            Total_Amount = txtamt.Text

            MessageBox.Show(" Booking Succesfull", "Booked")

            Me.Hide()
            Preview_Booking.Show()





        End If


    End Sub

    Private Sub Txtseats_TextChanged_1(sender As Object, e As EventArgs) Handles Txtseats.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
    '   Private Sub disp_Data()
    '   Dim fmn As New Preview_Booking
    '
    '       fmn.Label25.Text = txtbusid.Text
    '       fmn.Label26.Text = txtbusname.Text
    '       fmn.Label27.Text = txtbustype.Text
    '       fmn.Label28.Text = txtdeptime.Text
    '       fmn.Label29.Text = txtarrtime.Text
    '       fmn.Label36.Text = txtboardfrom.Text
    '       fmn.Label35.Text = txtdepto.Text
    '       fmn.Label32.Text = txtprice.Text
    '       fmn.Label34.Text = Txtdate.Text
    '       fmn.Label33.Text = txtseatno.Text
    '       fmn.Label31.Text = Txtseats.Text
    '      fmn.Label30.Text = txtamt.Text
    '      MessageBox.Show("Booking Successful")
    '   Me.Hide()
    '       Preview_Booking.Show()
    '   End Sub

    Private Sub txtamt_Click(sender As Object, e As EventArgs) Handles txtamt.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox_Clk()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim result As Integer

        num1 = txtprice.Text
        num2 = Txtseats.Text
        result = num1 * num2
        txtamt.Text = result

    End Sub


End Class