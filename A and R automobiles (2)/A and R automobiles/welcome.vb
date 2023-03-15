Imports System.IO
Public Class welcome
    Private Sub staffbtn_Click(sender As Object, e As EventArgs) Handles staffbtn.Click
        Me.Hide()
        Staffportal.Show()
    End Sub

    Private Sub managerbtn_Click(sender As Object, e As EventArgs) Handles managerbtn.Click

        Dim pass As String
        pass = InputBox("Enter manager password")
        If pass = "master123" Then
            Me.Hide()
            managerportal.Show()
            MsgBox("Access granted")
        Else
            MsgBox("Access denied, manager password is incorrect", vbExclamation)
        End If
    End Sub
End Class
