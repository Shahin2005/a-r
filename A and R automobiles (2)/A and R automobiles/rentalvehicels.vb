Imports System.IO
Public Class rentalvehicels
    Private Sub rentalvehicels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vehilce As New A_and_R_automobiles.rentalvehicledetails
        If Dir$("rentalvehicledetails.txt") = "" Then
            Dim sw As New StreamWriter(Application.StartupPath & "\rentalvehicledetails.txt", True) ' writes to the rental vehicle details file.
        End If
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

        rentalvehicles.regnumber = txtregnumber.Text
        rentalvehicles.model = txtmodel.Text
        rentalvehicles.make = txtmake.Text
        rentalvehicles.mileage = txtmileage.Text
        rentalvehicles.colour = txtcolour.Text
        rentalvehicles.fueltype = txtfueltype.Text

        If Rbauto.Checked = True Then
            rentalvehicles.transmission = RBauto.Text
        Else
            rentalvehicles.transmission = RBmanual.Text
        End If
        If rentalvehicles.regnumber <> "" And rentalvehicles.model <> "" And rentalvehicles.make <> "" And rentalvehicles.mileage <> "" And rentalvehicles.colour <> "" And rentalvehicles.fueltype <> "" And rentalvehicles.transmission <> "" Then 'this checks if the fields are left blank and doesn't save to the file until the fields aren't blank
            Dim sw As New System.IO.StreamWriter(Dir$("rentalvehicledetails.txt"), True)
            sw.WriteLine(rentalvehicles.regnumber & "," & rentalvehicles.make & "," & rentalvehicles.model & "," & rentalvehicles.colour & "," & CInt(rentalvehicles.mileage) & "," & rentalvehicles.fueltype & "," & rentalvehicles.transmission)
            MsgBox("details saved")
            sw.Close()
        Else
            MsgBox("Fields cannot be left blank", vbExclamation) 'if fields are left blank a message is outputed,and the fields dont save.This is done until fields are not blank
        End If
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click ' allows the staff to go to the previous menu
        Me.Hide()
        Staffportal.Show()
    End Sub
End Class