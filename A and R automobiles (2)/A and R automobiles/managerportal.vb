Imports System.IO
Public Class managerportal
    Private Sub staffdetails_Click(sender As Object, e As EventArgs) Handles staffdetails.Click
        Me.Hide()
        managestaff.Show()

    End Sub

    Private Sub receiptsbtn_Click(sender As Object, e As EventArgs) Handles receiptsbtn.Click
        Me.Hide()
        receipt.Show()
    End Sub
End Class