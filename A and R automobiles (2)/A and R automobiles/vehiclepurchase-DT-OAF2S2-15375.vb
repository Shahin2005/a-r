Imports System.IO
Public Class vehiclepurchase
    Private Sub vehichleform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vehilce As New A_and_R_automobiles.vehicledetails
        If Dir$("Vehicledetails.txt") = "" Then
            Dim sw As New StreamWriter(Application.StartupPath & "\Vehicledetails.txt", True)
        End If
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        vehicle.regnumber = txtregistrationnum.Text
        vehicle.model = txtmodel.Text
        vehicle.make = txtmake.Text
        vehicle.mileage = txtmileage.Text
        vehicle.price = txtprice.Text
        vehicle.colour = txtvehiclecolour.Text
        vehicle.problems = txtvehicleproblems.Text
        vehicle.owners = txtnumofowners.Text

        Dim sw As New System.IO.StreamWriter(Dir$("vehicledetails.txt"), True)
        sw.WriteLine(vehicle.regnumber & "," & vehicle.make & "," & vehicle.model & "," & vehicle.mileage & "," & vehicle.price & "," & vehicle.colour & "," & vehicle.problems & "," & vehicle.owners)
        MsgBox(" details saved")
        sw.Close()
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        Staffportal.Show()
    End Sub
End Class