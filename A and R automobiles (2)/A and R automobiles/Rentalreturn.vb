Imports System.IO
Public Class Rentalreturn

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

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

        If Dir$("Temp.txt") = "" Then 'check current project directory for movies.txt
            Dim st As New StreamWriter(Application.StartupPath & "\Temp.txt", True)    'This makes sure there is actually a database to enter/read data. If not, it creates a new blank one.
            st.Close()
        End If

        Dim sr As New System.IO.StreamReader(Dir$("rentalvehicledetails.txt"), True)
        Dim sw As New System.IO.StreamWriter(Dir$("Temp.txt"), True)
        'these lines replace the old fields with the updated ones.
        stringline = sr.ReadLine()
        While (stringline <> Nothing)
            rentalvehiclerecords = stringline.Split(",") 'split comma delimted fields into array
            If (rentalvehiclerecords(0) = CBregnumber.Text) Then 'if match found display record

                rentalvehicles.mileage = rentalvehiclerecords(4) + txtmilesdriven.Text

                rentalvehicles.regnumber = CBregnumber.Text
                rentalvehicles.make = txtmake.Text
                rentalvehicles.model = txtmodel.Text
                rentalvehicles.colour = txtvehiclecolour.Text
                rentalvehicles.transmission = rentalvehiclerecords(5)
                rentalvehicles.fueltype = rentalvehiclerecords(6)


                sw.WriteLine(rentalvehicles.regnumber & "," & rentalvehicles.make & "," & rentalvehicles.model & "," & rentalvehicles.colour & "," & Val(txtmileage.Text) + Val(txtmilesdriven.Text) & "," & rentalvehicles.fueltype & "," & rentalvehicles.transmission) 'write to the file.
                stringline = sr.ReadLine()
            Else
                sw.WriteLine(stringline)
                stringline = sr.ReadLine()
            End If

        End While
        sr.Close()
        sw.Close()

        File.Delete("rentalvehicledetails.txt") 'delete Staff file
        File.Move("Temp.txt", "rentalvehicledetails.txt") 're-create new Stafffile with edited record






    End Sub
    'these lines delete the rental records when the vehicle is returned 
    Private Sub savebtn_Click_1(sender As Object, e As EventArgs) Handles savebtn.Click
        If Dir$("Temp.txt") = "" Then 'check current project directory for movies.txt
            Dim st As New StreamWriter(Application.StartupPath & "\Temp.txt", True)    'This makes sure there is actually a database to enter/read data. If not, it creates a new blank one.
            st.Close()
        End If

        Dim sr As New System.IO.StreamReader(Dir$("rentaldetails.txt"), True)
        Dim sw As New System.IO.StreamWriter(Dir$("Temp.txt"), True)

        stringline = sr.ReadLine()
        While (stringline <> Nothing)
            rentalrecords = stringline.Split(",") 'split comma delimted fields into array
            If (rentalrecords(0) <> CBrentalID.Text) Then 'if match found display record
                sw.WriteLine(stringline)
                stringline = sr.ReadLine()
            Else
                stringline = sr.ReadLine()
            End If

        End While
        sr.Close()
        sw.Close()

        File.Delete("rentaldetails.txt") 'deletes rental details
        File.Move("Temp.txt", "rentaldetails.txt")
        MsgBox("Vehicel returned!")



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

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        bookingorreturn.Show()
    End Sub

    Private Sub Rentalreturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class