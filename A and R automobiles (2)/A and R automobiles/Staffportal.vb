Imports System.IO
Public Class Staffportal




    Private Sub customerdetailsbtn_Click(sender As Object, e As EventArgs) Handles customerdetailsbtn.Click
        Me.Hide()
        customerform.Show()
    End Sub

    Private Sub salebtn_Click(sender As Object, e As EventArgs) Handles salebtn.Click
        Me.Hide()
        vehiclesale.Show()
    End Sub

    Private Sub purchasebtn_Click(sender As Object, e As EventArgs) Handles purchasebtn.Click
        Me.Hide()
        vehiclepurchase.Show()
    End Sub

    Private Sub Staffportal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sr As New System.IO.StreamReader(Dir$("staffdetails.txt"), True)

    End Sub

    Private Sub vehicelrentalsbtn_Click(sender As Object, e As EventArgs) Handles vehicelrentalsbtn.Click
        Me.Hide()
        bookingorreturn.Show()

    End Sub

    Private Sub enterbtn_Click(sender As Object, e As EventArgs) Handles enterbtn.Click
        Dim sr As New System.IO.StreamReader(Dir$("Staffdetails.txt"), True)
        stringline = sr.ReadLine()


        staffrecords = stringline.Split(",") 'split comma delimted fields into array
        If (staffrecords(5) = txtstaffpass.Text) And (staffrecords(0) = txtstaffID.Text) Then
            staffgroupbox.Visible = True
            MsgBox("Access granted")
            sale.staffID = txtstaffID.Text
        Else
            MsgBox("Access denied,credentials entered are incorrect", vbExclamation)

        End If
            stringline = sr.ReadLine()




        sr.Close()
    End Sub

    Private Sub inventorybtn_Click(sender As Object, e As EventArgs) Handles inventorybtn.Click
        Me.Hide()
        vehicleinventory.Show()
    End Sub

    Private Sub Rentalvehicelsbtn_Click(sender As Object, e As EventArgs) Handles Rentalvehicelsbtn.Click
        Me.Hide()
        rentalvehicels.Show()
    End Sub
End Class