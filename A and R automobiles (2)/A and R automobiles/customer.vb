Imports System.IO
Public Class customerform
    Private Sub customerform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim customer As New A_and_R_automobiles.Customerdetails                                          ' this creates a new customerdetails file if the file is empty
        If Dir$("Customerdetails.txt") = "" Then
            Dim sw As New StreamWriter(Application.StartupPath & "\Customerdetails.txt", True)
        End If
    End Sub
    Private Sub CBcustomerID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBcustomerID.SelectedIndexChanged
        Dim sr As New System.IO.StreamReader(Dir$("Customerdetails.txt"), True) 'when the combo box is clicked it will show all the customers details in the assigned text boxes
        stringline = sr.ReadLine()
        While (stringline <> Nothing) '
            customerrecords = stringline.Split(",") 'split comma delimted fields into array
            If (customerrecords(0) = CBcustomerID.Text) Then
                txtCfname.Text = customerrecords(1)
                txtCsurname.Text = customerrecords(2)
                txtCphonenum.Text = customerrecords(3)
                txtaddress.Text = customerrecords(4)
                txtpostcode.Text = customerrecords(5)
                txtDOB.Text = customerrecords(6)
            End If
            stringline = sr.ReadLine()
        End While
        sr.Close()
    End Sub

    Private Sub submitbtn_Click(sender As Object, e As EventArgs) Handles submitbtn.Click
        Dim sw As New System.IO.StreamWriter(Dir$("Customerdetails.txt"), True)
        ' applies checks to each field , if a check is failed it will not save to the file until the check has been passed

        If Len(txtCphonenum.Text) = 11 Then
            txtCphonenum.BackColor = Color.Green
            customer.phonenum = txtCphonenum.Text
        ElseIf Len(txtCphonenum.Text) <> 11 Then
            txtCphonenum.BackColor = Color.Red
            MsgBox("Please enter a valid  phone number") ' length check on the phone number as the phone number has to be 11 digits long
        End If


        If txtCfname.Text = "" Then 'checks if all the characters in the first name field are letters
            txtCfname.BackColor = Color.Red
            MsgBox("Please enter a firstname")
        ElseIf txtCfname.Text <> "" Then
            For i = 0 To Len(txtCfname.Text) - 1
                If (Asc(txtCfname.Text(i)) < 65 Or Asc(txtCfname.Text(i)) > 122) Or (Asc(txtCfname.Text(i)) > 91 And Asc(txtCfname.Text(i)) < 96) Then
                    MsgBox("ERROR!" & vbCrLf & "There is a non-letter value in the first name field")
                    txtCfname.BackColor = Color.Red
                Else
                    txtCfname.BackColor = Color.Green
                    customer.FirstName = txtCfname.Text
                End If
            Next i

        End If

        If txtCsurname.Text = "" Then 'checks if all the characters in the surname field are letters
            txtCsurname.BackColor = Color.Red
            MsgBox("Please enter a surname")
        ElseIf txtCsurname.Text <> "" Then
            For i = 0 To Len(txtCsurname.Text) - 1
                If (Asc(txtCsurname.Text(i)) < 65 Or Asc(txtCsurname.Text(i)) > 122) Or (Asc(txtCsurname.Text(i)) > 91 And Asc(txtCsurname.Text(i)) < 96) Then
                    MsgBox("ERROR!" & vbCrLf & "There is a non-letter value in the surname field")
                    txtCsurname.BackColor = Color.Red
                Else
                    txtCsurname.BackColor = Color.Green
                    customer.Surname = txtCsurname.Text

                End If
            Next i

        End If

        If txtDOB.Text = "" Then
            txtDOB.BackColor = Color.Red
            MsgBox("Please enter a date of birth name")
        ElseIf txtDOB.Text <> "" Then
            txtDOB.BackColor = Color.Green ' presence check on the date of birth
            customer.DOB = txtDOB.Text
        End If
        If txtpostcode.Text = "" Then
            txtpostcode.BackColor = Color.Red
            MsgBox("please enter a postcode")
        Else
            txtpostcode.BackColor = Color.Green 'presence check on the address
            customer.postcode = txtpostcode.Text
        End If

        If txtaddress.Text = "" Then
            txtaddress.BackColor = Color.Red
            MsgBox("please enter a address")
        Else
            txtaddress.BackColor = Color.Green 'presence check on the address
            customer.address = txtaddress.Text
        End If


        customer.DOB = txtDOB.Text
        customernum = customernum + 1 ' this is generates a customer number on a first come first basis


        customer.ID = Mid(customer.FirstName, 1, 1) & Mid(customer.Surname, 1, 4) & customernum ' generates a custoemr ID for the customer 

        If txtpostcode.BackColor = Color.Green And txtCfname.BackColor = Color.Green And txtDOB.BackColor = Color.Green And Len(txtCphonenum.Text) = 11 And txtCsurname.BackColor = Color.Green Then  ' saves all the customer details to the file only if the checks have been passed
            sw.WriteLine(customer.ID & "," & customer.FirstName & "," & customer.Surname & "," & customer.phonenum & "," & customer.postcode & "," & customer.address & "," & customer.DOB)
            MsgBox("details saved")
        End If

        sw.Close()
    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        If Dir$("Temp.txt") = "" Then 'check current project directory for movies.txt
            Dim st As New StreamWriter(Application.StartupPath & "\Temp.txt", True)    'This makes sure there is actually a database to enter/read data. If not, it creates a new blank one.
            st.Close()
        End If

        Dim sr As New System.IO.StreamReader(Dir$("Customerdetails.txt"), True)
        Dim sw As New System.IO.StreamWriter(Dir$("Temp.txt"), True)
        ' these lines replace the old fields with the updated fields
        stringline = sr.ReadLine()
        While (stringline <> Nothing)
            customerrecords = stringline.Split(",") 'split comma delimted fields into array
            If (customerrecords(0) = CBcustomerID.Text) Then 'if match found display record

                customer.phonenum = txtCphonenum.Text
                customer.FirstName = txtCfname.Text
                customer.Surname = txtCsurname.Text
                customer.DOB = txtDOB.Text
                customer.address = txtaddress.Text
                customer.postcode = txtpostcode.Text
                customer.ID = Mid(customer.FirstName, 1, 1) & Mid(customer.Surname, 1, 4) & customernum
                sw.WriteLine(customer.ID + "," & customer.FirstName + "," & customer.Surname + "," & customer.phonenum + "," & customer.postcode + "," + customer.address + "," + customer.DOB) ' saves to the file
                stringline = sr.ReadLine()
            Else
                sw.WriteLine(stringline)
                stringline = sr.ReadLine()
            End If

        End While
        sr.Close()
        sw.Close()

        File.Delete("Customerdetails.txt") 'delete customer file
        File.Move("Temp.txt", "Customerdetails.txt") 're-create new customer file with edited record
        MsgBox("details edited!")
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

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        If Dir$("Temp.txt") = "" Then 'check current project directory for customerstxt
            Dim st As New StreamWriter(Application.StartupPath & "\Temp.txt", True)    'This makes sure there is actually a database to enter/read data. If not, it creates a new blank one.
            st.Close()
        End If

        Dim sr As New System.IO.StreamReader(Dir$("Customerdetails.txt"), True)
        Dim sw As New System.IO.StreamWriter(Dir$("Temp.txt"), True)

        stringline = sr.ReadLine()
        While (stringline <> Nothing)
            customerrecords = stringline.Split(",") 'split comma delimted fields into array
            If (customerrecords(0) <> CBcustomerID.Text) Then 'if match found display record
                sw.WriteLine(stringline)
                stringline = sr.ReadLine()
            Else
                stringline = sr.ReadLine()
            End If

        End While
        sr.Close()
        sw.Close()

        File.Delete("Customerdetails.txt") 'delete customer file
        File.Move("Temp.txt", "Customerdetails.txt") 're-create new customer file with edited record
        MsgBox("details deleted!")
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click ' this clears all the textboxes when the staff visits the previous menu
        Me.Hide()
        Staffportal.Show()
        txtCfname.Text = ""
        txtCsurname.Text = ""
        txtpostcode.Text = ""
        txtCphonenum.Text = ""
        txtpostcode.Text = ""
        txtDOB.Text = ""
        CBcustomerID.Text = ""
        txtaddress.Text = ""
    End Sub
    Private Sub help1_MouseHover(sender As Object, e As EventArgs) Handles help1.MouseHover
        ToolTiphelp.Show("The D.O.B has to be in the form dd/mm/yyyy", help1)
    End Sub

    Private Sub help2_MouseHover(sender As Object, e As EventArgs) Handles help2.MouseHover
        ToolTiphelp.Show("The phone number has to contain 11 digits", help2)
    End Sub

    Private Sub help4_MouseHover(sender As Object, e As EventArgs) Handles help4.MouseHover
        ToolTiphelp.Show("The surname can only contain letters", help4)
    End Sub

    Private Sub help5_MouseHover(sender As Object, e As EventArgs) Handles help5.MouseHover
        ToolTiphelp.Show("The firstname can only contain letters", help5)
    End Sub

End Class