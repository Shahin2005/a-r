Imports System.IO

Public Class receipt
    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        managerportal.Show()
    End Sub
    'Reads the sale details and outputs the fields on to the list view for the manager to see the details of the vehicle sale.
    Private Sub receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sr As New System.IO.StreamReader(Dir$("Saledetails.txt"), True)
        lstsales.View = View.Details
        lstsales.GridLines = True
        lstsales.FullRowSelect = True
        lstsales.Scrollable = True
        lstsales.Columns.Add("Staff ID", 100)
        lstsales.Columns.Add("Customer ID", 100)
        lstsales.Columns.Add("Registration", 100)
        lstsales.Columns.Add("Price sold for", 100)
        lstsales.Columns.Add("Date sold", 100)
        lstsales.Columns.Add("Payment method", 100)
        lstsales.Columns.Add("Monthly or full payment", 100)
        lstsales.Columns.Add("Price bought for", 100)
        lstsales.Columns.Add("Profit made on sale", 140)




        stringline = sr.ReadLine()
        While (stringline <> Nothing) '
            salerecords = stringline.Split(",") 'split comma delimted fields into array
            line(0) = salerecords(0) ' all these lines are assigned to each sale detail.
            line(1) = salerecords(1)
            line(2) = salerecords(2)
            line(3) = salerecords(3)
            line(4) = salerecords(4)
            line(5) = salerecords(5)
            line(6) = salerecords(6)
            line(7) = salerecords(7)
            line(8) = salerecords(3) - salerecords(7) ' calculates the profit made by the 

            stringline = sr.ReadLine() 'this adds all the vehicle details to the list view 
            sales = New ListViewItem(line)
            lstsales.Items.Add(sales)
        End While
        sr.Close()
    End Sub


End Class