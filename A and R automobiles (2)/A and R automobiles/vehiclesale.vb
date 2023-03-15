Imports System.IO
Public Class vehiclesale
    ' vehcile sale form where all the details about the vehicle sale is stored and 
    Private Sub vehiclesale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sale As New A_and_R_automobiles.saledetails
        If Dir$("Saledetails.txt") = "" Then
            Dim sw As New StreamWriter(Application.StartupPath & "\Saledetails.txt", True)
        End If
    End Sub

    'if a registration number is clicked it would output all the vehicle details to the assigned text boxes.
    Private Sub CBregistrationnum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBregistrationnum.SelectedIndexChanged
        Dim sr As New System.IO.StreamReader(Dir$("vehicledetails.txt"), True)
        stringline = sr.ReadLine()
        While (stringline <> Nothing) '
            vehiclerecords = stringline.Split(",")
            If (vehiclerecords(0) = CBregistrationnum.Text) Then ' 
                txtmake.Text = vehiclerecords(1)
                txtmodel.Text = vehiclerecords(2)
                txtcolour.Text = vehiclerecords(3)
                txtmileage.Text = vehiclerecords(4)
                txtvehicleproblems.Text = vehiclerecords(6)
                txtnumofowners.Text = vehiclerecords(7)
                txtfueltype.Text = vehiclerecords(8)
                txttransmission.Text = vehiclerecords(9)
                sale.priceboughtfor = vehiclerecords(5) ' the price the vehicle was bought for is also stored in the sale details to calculate profits
            End If
            stringline = sr.ReadLine()
        End While
        sr.Close()
    End Sub
    Private Sub CBregistrationnum_Enter(sender As Object, e As EventArgs) Handles CBregistrationnum.Enter 'the combo box shows all the registration number and the staff choses the registration number of the vehicle the customer wants 
        Dim sr As New System.IO.StreamReader(Dir$("Vehicledetails.txt"), True)
        CBregistrationnum.Items.Clear()
        stringline = sr.ReadLine()
        While (stringline <> Nothing) '
            vehiclerecords = stringline.Split(",")
            CBregistrationnum.Items.Add(vehiclerecords(0)) 'add first field to combo box
            stringline = sr.ReadLine()
        End While
        sr.Close()
    End Sub
    Private Sub savebtn_Click_1(sender As Object, e As EventArgs) Handles savebtn.Click
        Dim sw As New System.IO.StreamWriter(Dir$("Saledetails.txt"), True) 'this button would save all the details about the vehicle sale to the sale details file.
        If RBmonthlypayments.Checked = True Then
            sale.paymenttype = "monthly payments"
        Else
            sale.paymenttype = "full payment"
        End If

        If CBcustomerID.Text = "" Then
            MsgBox("Please enter a customer ID")
            CBcustomerID.BackColor = Color.Red
        Else
            sale.customerID = CBcustomerID.Text
            CBcustomerID.BackColor = Color.Green
        End If

        If CBregistrationnum.Text = "" Then
            MsgBox("Please enter a registration number")
            CBregistrationnum.BackColor = Color.Red
        Else
            sale.regnumber = CBregistrationnum.Text
            CBregistrationnum.BackColor = Color.Green
        End If

        If txtprice.Text = "" Then ' checks if the price is a integer, if not it isn't saved to the file.
            MsgBox("Please enter vehicle price")
            txtprice.BackColor = Color.Red
        ElseIf txtprice.Text <> "" Then
            If intcheck(txtprice.Text) Then
                txtprice.BackColor = Color.Green
                sale.vehicleprice = txtprice.Text
            Else
                txtprice.BackColor = Color.Red
                MsgBox("ERROR!" & vbCrLf & "The vehicle price cannot contain a non-number value")
            End If
        End If

        If CBpaymentmethod.Text = "" Then ' if the payment method is empty the fields won't save to the file.,
            MsgBox("Please enter payment method")
            CBpaymentmethod.BackColor = Color.Red
        Else
            sale.paymentmethod = CBpaymentmethod.Text
            CBpaymentmethod.BackColor = Color.Green
        End If


        sale.datebooked = DTPbookeddate.Text

        If CBpaymentmethod.BackColor = Color.Green And txtprice.BackColor = Color.Green And CBregistrationnum.BackColor = Color.Green And CBcustomerID.BackColor = Color.Green Then ' the fields are only saved to the file when all the fields are green.

            sw.WriteLine(sale.staffID & "," & sale.customerID & "," & sale.regnumber & "," & sale.vehicleprice & "," & sale.datebooked & "," & sale.paymentmethod & "," & sale.paymenttype & "," & sale.priceboughtfor)
            MsgBox("order saved")

            sw.Close()
        End If


    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        If Dir$("Temp.txt") = "" Then 'check current project directory for movies.txt
            Dim st As New StreamWriter(Application.StartupPath & "\Temp.txt", True)    'This makes sure there is actually a database to enter/read data. If not, it creates a new blank one.
            st.Close()
        End If

        Dim sr As New System.IO.StreamReader(Dir$("Vehicledetails.txt"), True)
        Dim sw As New System.IO.StreamWriter(Dir$("Temp.txt"), True)
        If CBpaymentmethod.BackColor = Color.Green And txtprice.BackColor = Color.Green And CBregistrationnum.BackColor = Color.Green And CBcustomerID.BackColor = Color.Green Then
            stringline = sr.ReadLine()
            While (stringline <> Nothing)

                vehiclerecords = stringline.Split(",") 'split comma delimted fields into array
                If (vehiclerecords(0) <> CBregistrationnum.Text) Then 'if match found display record
                    sw.WriteLine(stringline)
                    stringline = sr.ReadLine()
                Else
                    stringline = sr.ReadLine()
                End If

            End While

            sr.Close()
            sw.Close()

            File.Delete("Vehicledetails.txt") 'deletes vehicle file
            File.Move("Temp.txt", "Vehicledetails.txt") 're-create new vehicle file with edited record
            MsgBox("22")
        End If
    End Sub
    Private Sub calcbtn_Click(sender As Object, e As EventArgs) Handles calcbtn.Click 'this button calculates monthly cost of the veyhicle if the customer has chosen to pay it back monthly
        txtmonthlyfees.Text = CInt((txtprice.Text - txtupront.Text) / txtpaymnetduration.Text)
    End Sub

    Private Sub CBcustomerID_Enter(sender As Object, e As EventArgs) Handles CBcustomerID.Enter
        Dim sr As New System.IO.StreamReader(Dir$("Customerdetails.txt"), True)
        CBcustomerID.Items.Clear()
        stringline = sr.ReadLine()
        While (stringline <> Nothing) '
            customerrecords = stringline.Split(",")
            CBcustomerID.Items.Add(customerrecords(0)) 'add first field to combo box
            stringline = sr.ReadLine()
        End While
        sr.Close()
    End Sub

    Private Sub CBcat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBpaymentmethod.SelectedIndexChanged 'the staff chooses which payment method the customer has used, if they select card the payment scheme would be displayed
        If CBpaymentmethod.Text = "credit card" Then
            GBpaymenttype.Visible = True
        Else
            GBpaymenttype.Visible = False

        End If
    End Sub

    Private Sub RBfull_CheckedChanged(sender As Object, e As EventArgs) Handles RBfull.CheckedChanged 'if the customer wants to pay the for the vehicle in full they can.
        If RBmonthlypayments.Checked = True Then
            paymentscheme.Visible = True
        Else paymentscheme.Visible = False
        End If
    End Sub

    Private Sub RBmonthlypayments_CheckedChanged(sender As Object, e As EventArgs) Handles RBmonthlypayments.CheckedChanged 'if the customer wants to pay the vehicle in monthly instalments , the system would calculate the monthly payments by the custoemrs first payment.
        If RBmonthlypayments.Checked = True Then
            paymentscheme.Visible = True
        Else paymentscheme.Visible = False
        End If
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click 'this is takes the staff to the previous menu
        Me.Hide()
        Staffportal.Show()
    End Sub



End Class