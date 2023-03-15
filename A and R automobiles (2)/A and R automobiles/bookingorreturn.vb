Public Class bookingorreturn
    Private Sub vehicelrentalsbtn_Click(sender As Object, e As EventArgs) Handles vehicelrentalsbtn.Click
        Me.Hide()
        rentalform.Show()
    End Sub

    Private Sub rentalreturnbtn_Click(sender As Object, e As EventArgs) Handles rentalreturnbtn.Click
        Me.Hide()
        Rentalreturn.Show()
    End Sub
End Class