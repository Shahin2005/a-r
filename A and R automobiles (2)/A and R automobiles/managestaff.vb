Imports System.IO

Public Class managestaff

    Private Sub managestaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim staff As New A_and_R_automobiles.Staffdetails 'this line checks if a staff details file exist if it doesn't then it creates one.
        If Dir$("Staffdetails.txt") = "" Then
            Dim sw As New StreamWriter(Application.StartupPath & "\Staffdetails.txt", True)

        End If

    End Sub

    Private Sub submitbtn_Click(sender As Object, e As EventArgs) Handles submitbtn.Click

        Dim sw As New System.IO.StreamWriter(Dir$("Staffdetails.txt"), True)
        'this checks first name is blank, if not it then checks if all the characters are letters and that they do not contain anything else
        If txtSfirstname.Text = "" Then
            txtSfirstname.BackColor = Color.Red
            MsgBox("Please enter a first name")
        ElseIf txtSfirstname.Text <> "" Then
            For i = 0 To Len(txtSfirstname.Text) - 1
                If (Asc(txtSfirstname.Text(i)) < 65 Or Asc(txtSfirstname.Text(i)) > 122) Or (Asc(txtSfirstname.Text(i)) > 91 And Asc(txtSfirstname.Text(i)) < 96) Then
                    MsgBox("ERROR!" & vbCrLf & "There is a non-letter value in the first name field")
                    txtSfirstname.BackColor = Color.Red
                Else
                    txtSfirstname.BackColor = Color.Green
                    staff.FirstName = txtSfirstname.Text
                End If
            Next i

        End If
        'this checks surname is blank, if not it then checks if all the characters are letters and that they do not contain anything else
        If txtSsurname.Text = "" Then
            txtSsurname.BackColor = Color.Red
            MsgBox("Please enter a surname")
        ElseIf txtSsurname.Text <> "" Then
            For i = 0 To Len(txtSsurname.Text) - 1
                If (Asc(txtSsurname.Text(i)) < 65 Or Asc(txtSsurname.Text(i)) > 122) Or (Asc(txtSsurname.Text(i)) > 91 And Asc(txtSsurname.Text(i)) < 96) Then
                    MsgBox("ERROR!" & vbCrLf & "There is a non-letter value in the surname field")
                    txtSsurname.BackColor = Color.Red
                Else
                    txtSsurname.BackColor = Color.Green
                    staff.Surname = txtSsurname.Text
                End If
            Next i

        End If



        If Len(txtSphonenum.Text) = 11 Then '' length check on the phone number as the phone number has to be 11 digits long
            txtSphonenum.BackColor = Color.Green
            staff.phonenum = txtSphonenum.Text
        Else
            txtSphonenum.BackColor = Color.Red
            MsgBox("Please enter a valid phonenumber")
        End If

        If txtSpassword.Text = "" Then ' these lines check that the password want empty and that it contained atleast 8 digits
            txtSpassword.BackColor = Color.Red
            MsgBox("Please enter a password")
        ElseIf Len(txtSpassword.Text) < 8 Then
            txtSpassword.BackColor = Color.Red
            MsgBox("Please enter a password with atleast 8 characters")
        Else
            txtSpassword.BackColor = Color.Green
            staff.password = txtSpassword.Text
        End If


        If txtSDOB.Text = "" Then
            txtSDOB.BackColor = Color.Red
            MsgBox("Please enter a date of birth")
        Else
            txtSDOB.BackColor = Color.Green
            staff.DOB = txtSDOB.Text
        End If



        staff.ID = Mid(staff.FirstName, 1, 1) & Mid(staff.Surname, 1, 4) & Mid(staff.DOB, 7, 10)
        If txtSDOB.BackColor = Color.Green And txtSpassword.BackColor = Color.Green And txtSphonenum.BackColor = Color.Green And txtSsurname.BackColor = Color.Green And txtSfirstname.BackColor = Color.Green Then 'This line checks if all the text boxes are green , if they are the fields are saved to the file.
            sw.WriteLine(staff.ID & "," & staff.FirstName & "," & staff.Surname & "," & staff.phonenum & "," & staff.DOB & "," & staff.password)
            MsgBox(" details saved") ' a message is outputed when the details are saved
        End If
        sw.Close()
    End Sub
    Private Sub CBstaffID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbstaffID.SelectedIndexChanged
        Dim sr As New System.IO.StreamReader(Dir$("Staffdetails.txt"), True)
        stringline = sr.ReadLine()
        'these lines output the fields asscociated with the staff ID.
        While (stringline <> Nothing) '
            staffrecords = stringline.Split(",") 'split comma delimted fields into array
            If (staffrecords(0) = cbstaffID.Text) Then
                txtSfirstname.Text = staffrecords(1)
                txtSsurname.Text = staffrecords(2)
                txtSphonenum.Text = staffrecords(3)
                txtSDOB.Text = staffrecords(4)
                txtSpassword.Text = staffrecords(5)
            End If
            stringline = sr.ReadLine()
        End While
        sr.Close()
    End Sub
    Private Sub cbstaffID_Enter(sender As Object, e As EventArgs) Handles cbstaffID.Enter
        Dim sr As New System.IO.StreamReader(Dir$("Staffdetails.txt"), True)
        cbstaffID.Items.Clear()
        stringline = sr.ReadLine()
        While (stringline <> Nothing) '
            staffrecords = stringline.Split(",")
            cbstaffID.Items.Add(staffrecords(0)) 'add first field to combo box
            stringline = sr.ReadLine()
        End While
        sr.Close()
    End Sub


 
    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click

        If Dir$("Temp.txt") = "" Then 'check current project directory for movies.txt
            Dim st As New StreamWriter(Application.StartupPath & "\Temp.txt", True)    'This makes sure there is actually a database to enter/read data. If not, it creates a new blank one.
            st.Close()
        End If

        Dim sr As New System.IO.StreamReader(Dir$("Staffdetails.txt"), True)
        Dim sw As New System.IO.StreamWriter(Dir$("Temp.txt"), True)
        'these lines replace the old fields with the updated ones.
        stringline = sr.ReadLine()
        While (stringline <> Nothing)
            staffrecords = stringline.Split(",") 'split comma delimted fields into array
            If (staffrecords(0) = cbstaffID.Text) Then 'if match found display record

                staff.phonenum = txtSphonenum.Text
                staff.password = txtSpassword.Text
                staff.FirstName = txtSfirstname.Text
                staff.Surname = txtSsurname.Text
                staff.DOB = txtSDOB.Text
                staff.ID = Mid(staff.FirstName, 1, 1) & Mid(staff.Surname, 1, 4) & Mid(staff.DOB, 1, 3)
                sw.WriteLine(staff.ID + "," & staff.FirstName + "," & staff.Surname + "," & staff.phonenum + "," & staff.DOB & "," + staff.password) 'write to the file.
                stringline = sr.ReadLine()
            Else
                sw.WriteLine(stringline)
                stringline = sr.ReadLine()
            End If

        End While
        sr.Close()
        sw.Close()

        File.Delete("Staffdetails.txt") 'delete Staff file
        File.Move("Temp.txt", "Staffdetails.txt") 're-create new Stafffile with edited record
        MsgBox("details edited!")
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        If Dir$("Temp.txt") = "" Then 'check current project directory for movies.txt
            Dim st As New StreamWriter(Application.StartupPath & "\Temp.txt", True)    'This makes sure there is actually a database to enter/read data. If not, it creates a new blank one.
            st.Close()
        End If

        Dim sr As New System.IO.StreamReader(Dir$("Staffdetails.txt"), True)
        Dim sw As New System.IO.StreamWriter(Dir$("Temp.txt"), True)

        stringline = sr.ReadLine()
        While (stringline <> Nothing)
            staffrecords = stringline.Split(",") 'split comma delimted fields into array
            If (staffrecords(0) <> cbstaffID.Text) Then 'if match found display record
                sw.WriteLine(stringline)
                stringline = sr.ReadLine()
            Else
                stringline = sr.ReadLine()
            End If

        End While
        sr.Close()
        sw.Close()

        File.Delete("Staffdetails.txt") 'delete Staff file
        File.Move("Temp.txt", "Staffdetails.txt") 're-create new Staff file with edited record
        MsgBox("details deleted!")

    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click ' this button allows the staff to visit staff portal menu and it clears all the text boxes.
        Me.Hide()
        managerportal.Show()
        cbstaffID.Text = ""
        txtSphonenum.Text = ""
        txtSfirstname.Text = ""
        txtSsurname.Text = ""
        txtSDOB.Text = ""
        txtSpassword.Text = ""
    End Sub



    Private Sub help1_MouseHover(sender As Object, e As EventArgs) Handles help1.MouseHover
        ToolTiphelp.Show("The D.O.B has to be in the form dd/mm/yyyy", help1)
    End Sub

    Private Sub help2_MouseHover(sender As Object, e As EventArgs) Handles help2.MouseHover
        ToolTiphelp.Show("The phone number has to contain 11 digits", help2)
    End Sub

    Private Sub help3_MouseHover(sender As Object, e As EventArgs) Handles help3.MouseHover
        ToolTiphelp.Show("The password has to contain atleast 8 digits", help3)
    End Sub
    Private Sub help4_MouseHover(sender As Object, e As EventArgs) Handles help4.MouseHover
        ToolTiphelp.Show("The surname can only contain letters", help4)
    End Sub

    Private Sub help5_MouseHover(sender As Object, e As EventArgs) Handles help5.MouseHover
        ToolTiphelp.Show("The firstname can only contain letters", help5)
    End Sub
End Class


