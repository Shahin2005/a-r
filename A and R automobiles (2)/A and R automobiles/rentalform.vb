Imports System.IO
Public Class rentalform

    Private Sub rentalform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim staff As New A_and_R_automobiles.rentaldetails
        If Dir$("rentaldetails.txt") = "" Then
            Dim sw As New StreamWriter(Application.StartupPath & "\rentaldetails.txt", True)
        End If
        Dim sr As New System.IO.StreamReader(Dir$("rentaldetails.txt"), True)

        lstrental.View = View.Details 'i have declared the properties of the listview here a
        lstrental.GridLines = True
        lstrental.FullRowSelect = True
        lstrental.Scrollable = True
        lstrental.Columns.Add("Registrtion number", 100) 'all the headings of the lsitview are declared here
        lstrental.Columns.Add("Date booked", 100)
        lstrental.Columns.Add("Days rented for", 100)

        stringline = sr.ReadLine()

        While (stringline <> Nothing) '
            rentalrecords = stringline.Split(",") 'split comma delimted fields into array
            line(0) = rentalrecords(2) ' all these lines are assigned to each rental detail.
            line(1) = rentalrecords(4)
            line(2) = rentalrecords(5)



            stringline = sr.ReadLine() 'this adds all the rental details to the list view 
            stock = New ListViewItem(line)
            lstrental.Items.Add(stock)
        End While
        sr.Close()

    End Sub

    Private Sub CBregnumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBregnumber.SelectedIndexChanged ' the rental vehicle details are presented in the assigned text boxes.
        Dim sr As New System.IO.StreamReader(Dir$("rentalvehicledetails.txt"), True)
        stringline = sr.ReadLine()
        While (stringline <> Nothing) '
            rentalvehiclerecords = stringline.Split(",") 'split comma delimted fields into array
            If (rentalvehiclerecords(0) = CBregnumber.Text) Then ' this line checks which registration number is chosen and the details associated are presented
                txtmake.Text = rentalvehiclerecords(1)
                txtmodel.Text = rentalvehiclerecords(2)
                txtvehiclecolour.Text = rentalvehiclerecords(3)
                txtmileage.Text = rentalvehiclerecords(4)

            End If
            stringline = sr.ReadLine()
        End While
        sr.Close()
    End Sub


    Private Sub CBregnumber_Enter(sender As Object, e As EventArgs) Handles CBregnumber.Enter ' the combo box allows the
        Dim sr As New System.IO.StreamReader(Dir$("rentalvehicledetails.txt"), True)
        CBregnumber.Items.Clear()
        stringline = sr.ReadLine()
        While (stringline <> Nothing) '
            rentalvehiclerecords = stringline.Split(",")

            CBregnumber.Items.Add(rentalvehiclerecords(0))
            stringline = sr.ReadLine()

        End While
        sr.Close()
    End Sub

    Private Sub CBcustomerID_Enter(sender As Object, e As EventArgs) Handles CBcustomerID.Enter ' this outputs all the customer ID's, the staff member choses which customer is renting the vehicle
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
    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

        Using sw As New StreamWriter(Dir$("rentaldetails.txt"), True)


            If CBcustomerID.Text = "" Then
                    MsgBox("Please enter customer ID")
                    CBcustomerID.BackColor = Color.Red
                Else
                    rental.customerID = CBcustomerID.Text
                    CBcustomerID.BackColor = Color.Green
                End If

                If CBregnumber.Text = "" Then
                    MsgBox("Please enter registration number")
                ElseIf CBregnumber.Text = rentalrecords(2) Then
                    CBregnumber.Text = rentalrecords(2)
                    MsgBox("Vehicle is out for rent, please choose another vehicle")
                    CBregnumber.BackColor = Color.Red

                Else
                    CBregnumber.BackColor = Color.Green
                    rental.regnumber = CBregnumber.Text
                End If

                If txtdailyprice.Text = "" Then
                    MsgBox("Please enter daily price of vehicle")
                    txtdailyprice.BackColor = Color.Red
                Else
                    txtdailyprice.BackColor = Color.Green
                    rental.dailyprice = txtdailyprice.Text
                End If

                If txtdaysrented.Text = "" Then
                    MsgBox("Please enter daily price of vehicle")
                    txtdaysrented.BackColor = Color.Red
                Else
                    txtdaysrented.BackColor = Color.Green
                    rental.daysrented = txtdaysrented.Text
                End If

                rental.datebooked = DTPdatebooked.Text

                txttotal.Text = txtdaysrented.Text * txtdailyprice.Text
                rental.total = txtdaysrented.Text * txtdailyprice.Text


                rental.rentalID = Mid(CBcustomerID.Text, 1, 4) & Mid(DTPdatebooked.Text, 1, 3)

            If CBregnumber.BackColor = Color.Red And CBcustomerID.BackColor = Color.Red And txtdaysrented.BackColor = Color.Green And txtdailyprice.BackColor = Color.Green Then
                sw.WriteLine(rental.rentalID & "," & rental.customerID & "," & rental.regnumber & "," & rental.dailyprice & "," & rental.datebooked & "," & rental.daysrented & "," & rental.total & "," & rental.returned) ' saves all the rental details to the file
                MsgBox("order saved")
            End If
            sw.Close()



        End Using


    End Sub




    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        Staffportal.Show()
        CBcustomerID.Text = ""
        CBregnumber.Text = ""
        txtdailyprice.Text = ""
        txttotal.Text = ""
        txtdailyprice.Text = ""
        txtdaysrented.Text = ""
        txtmake.Text = ""
        txtmodel.Text = ""
        txtvehiclecolour.Text = ""
        txtmileage.Text = ""
        CBrentalID.Text = ""

    End Sub

    Private Sub CBrentalID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBrentalID.SelectedIndexChanged
        Dim sr As New System.IO.StreamReader(Dir$("rentaldetails.txt"), True)

        stringline = sr.ReadLine()
        While (stringline <> Nothing) '
            rentalrecords = stringline.Split(",") 'split comma delimted fields into array
            If (rentalrecords(0) = CBrentalID.Text) Then
                CBcustomerID.Text = rentalrecords(1)
                CBregnumber.Text = rentalrecords(2)
                txtdailyprice.Text = rentalrecords(3)
                DTPdatebooked.Text = rentalrecords(4)
                txtdaysrented.Text = rentalrecords(5)
                txttotal.Text = rentalrecords(6)
            End If
            stringline = sr.ReadLine()
        End While
        sr.Close()
    End Sub


    Private Sub CBrentalID_Enter(sender As Object, e As EventArgs) Handles CBrentalID.Enter
        Dim sr As New System.IO.StreamReader(Dir$("rentaldetails.txt"), True)
        CBrentalID.Items.Clear()
        stringline = sr.ReadLine()
        While (stringline <> Nothing) '
            rentalrecords = stringline.Split(",")
            CBrentalID.Items.Add(rentalrecords(0)) 'add first field to combo box
            stringline = sr.ReadLine()
        End While
        sr.Close()
    End Sub



    Private Sub CBregnumber_TextChanged(sender As Object, e As EventArgs) Handles CBregnumber.TextChanged
        Dim sr As New System.IO.StreamReader(Dir$("rentalvehicledetails.txt"), True)
        stringline = sr.ReadLine()
        While (stringline <> Nothing) '
            rentalvehiclerecords = stringline.Split(",") 'split comma delimted fields into array
            If (rentalvehiclerecords(0) = CBregnumber.Text) Then
                txtmake.Text = rentalvehiclerecords(1)
                txtmodel.Text = rentalvehiclerecords(2)
                txtvehiclecolour.Text = rentalvehiclerecords(3)
                txtmileage.Text = rentalvehiclerecords(4)

            End If
            stringline = sr.ReadLine()
        End While
        sr.Close()
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        If Dir$("Temp.txt") = "" Then 'check current project directory for movies.txt
            Dim st As New StreamWriter(Application.StartupPath & "\Temp.txt", True)    'This makes sure there is actually a database to enter/read data. If not, it creates a new blank one.
            st.Close()
        End If

        Dim sr As New System.IO.StreamReader(Dir$("rentaldetails.txt"), True)
        Dim sw As New System.IO.StreamWriter(Dir$("Temp.txt"), True)

        stringline = sr.ReadLine()
        While (stringline <> Nothing)
            staffrecords = stringline.Split(",") 'split comma delimted fields into array
            If (rentalrecords(0) <> CBrentalID.Text) Then 'if match found display record
                sw.WriteLine(stringline)
                stringline = sr.ReadLine()
            Else
                stringline = sr.ReadLine()
            End If

        End While
        sr.Close()
        sw.Close()

        File.Delete("rentaldetails.txt") 'delete Staff file
        File.Move("Temp.txt", "rentaldetails.txt") 're-create new Staff file with edited record
        MsgBox("details deleted!")
    End Sub



End Class