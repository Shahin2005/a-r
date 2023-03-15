Imports System.IO
Public Class vehiclepurchase
    Private Sub vehichleform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vehilce As New A_and_R_automobiles.vehicledetails
        If Dir$("Vehicledetails.txt") = "" Then
            Dim sw As New StreamWriter(Application.StartupPath & "\Vehicledetails.txt", True)
        End If
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        If txtregistrationnum.Text = "" Then
            MsgBox("Please enter a registration number")
            txtregistrationnum.BackColor = Color.Red
        Else
            vehicle.regnumber = UCase(txtregistrationnum.Text)
            txtregistrationnum.BackColor = Color.Green
        End If

        If txtmodel.Text = "" Then
            MsgBox("Please enter vehicle model")
            txtmodel.BackColor = Color.Red
        Else
            vehicle.model = UCase(txtmodel.Text)
            txtmodel.BackColor = Color.Green
        End If

        If txtmake.Text = "" Then
            MsgBox("Please enter vehicle make")
            txtmake.BackColor = Color.Red
        Else
            vehicle.make = txtmake.Text
            txtmake.BackColor = Color.Green
        End If



        If txtmileage.Text = "" Then
            MsgBox("Please enter vehicle mileage")
            txtmileage.BackColor = Color.Red
        ElseIf txtmileage.Text <> "" Then
            If intcheck(txtmileage.Text) Then
                txtmileage.BackColor = Color.Green
                vehicle.mileage = txtmileage.Text
            Else
                txtmileage.BackColor = Color.Red
                MsgBox("ERROR!" & vbCrLf & "The vehicle mileage cannot contain a non-number value")
            End If
        End If

        If txtprice.Text = "" Then
            MsgBox("Please enter vehicle price")
            txtprice.BackColor = Color.Red
        ElseIf txtprice.Text <> "" Then
            If intcheck(txtprice.Text) Then
                txtprice.BackColor = Color.Green
                vehicle.price = txtprice.Text
            Else
                txtprice.BackColor = Color.Red
                MsgBox("ERROR!" & vbCrLf & "The vehicle price cannot contain a non-number value")
            End If
        End If

            If txtvehiclecolour.Text = "" Then
            MsgBox("Please enter vehicle colour")
            txtvehiclecolour.BackColor = Color.Red
        Else
            vehicle.colour = txtvehiclecolour.Text
            txtvehiclecolour.BackColor = Color.Green
        End If

        If txtvehicleproblems.Text = "" Then
            MsgBox("Please enter vehicle problems")
            txtvehicleproblems.BackColor = Color.Red
        Else
            vehicle.problems = txtvehicleproblems.Text
            txtvehicleproblems.BackColor = Color.Green
        End If

        If txtnumofowners.Text = "" Then
            MsgBox("Please enter number of owners")
            txtnumofowners.BackColor = Color.Red
        ElseIf txtnumofowners.Text <> "" Then
            If intcheck(txtnumofowners.Text) Then
                txtnumofowners.BackColor = Color.Green
                vehicle.owners = txtnumofowners.Text
            Else
                txtnumofowners.BackColor = Color.Red
                MsgBox("ERROR!" & vbCrLf & "The number of owners cannot contain a non-number value")
            End If
        End If


        If txtfueltype.Text = "" Then
            MsgBox("Please enter vehicle fuel type")
            txtfueltype.BackColor = Color.Red
        Else
            vehicle.fueltype = txtfueltype.Text
            txtfueltype.BackColor = Color.Green
        End If



        If Rbauto.Checked = True Then
            vehicle.transmission = Rbauto.Text
        Else
            vehicle.transmission = Rbmanual.Text
        End If

        If txtprice.BackColor = Color.Green And txtmileage.BackColor = Color.Green And txtfueltype.BackColor = Color.Green And txtregistrationnum.BackColor = Color.Green And txtnumofowners.BackColor = Color.Green And txtmodel.BackColor = Color.Green And txtmake.BackColor = Color.Green And txtprice.BackColor = Color.Green And txtvehicleproblems.BackColor = Color.Green And vehicle.transmission <> "" Then
            Dim sw As New System.IO.StreamWriter(Dir$("vehicledetails.txt"), True)
            sw.WriteLine(UCase(vehicle.regnumber) & "," & UCase(vehicle.make) & "," & UCase(vehicle.model) & "," & UCase(vehicle.colour) & "," & CInt(vehicle.mileage) & "," & CInt(vehicle.price) & "," & UCase(vehicle.problems) & "," & CInt(vehicle.owners) & "," & UCase(vehicle.fueltype) & "," & UCase(vehicle.transmission))
            MsgBox("details saved")
            sw.Close()
        End If
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        Staffportal.Show()
    End Sub


End Class