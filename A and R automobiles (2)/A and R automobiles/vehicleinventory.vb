Imports System.IO
Public Class vehicleinventory

    ' this shows the staff all the vehicle the dealership has.
    Private Sub vehicleinventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sr As New System.IO.StreamReader(Dir$("vehicledetails.txt"), True)

        lststock.View = View.Details
        lststock.GridLines = True
        lststock.FullRowSelect = True
        lststock.Scrollable = True
        lststock.Columns.Add("Registrtion number", 100)
        lststock.Columns.Add("Make", 100)
        lststock.Columns.Add("Model", 100)
        lststock.Columns.Add("Colour ", 100)
        lststock.Columns.Add("Mileage", 100)
        lststock.Columns.Add("Fuel type", 100)
        lststock.Columns.Add("Transmission type", 100)
        lststock.Columns.Add("Number of owners", 100)
        lststock.Columns.Add("Existing problems", 100)
        lststock.Columns.Add("Price bought for", 100)




        stringline = sr.ReadLine()
            While (stringline <> Nothing) '
                vehiclerecords = stringline.Split(",") 'split comma delimted fields into array
            line(0) = vehiclerecords(0) ' all these lines are assigned to each vehicle detail.
            line(1) = vehiclerecords(1)
            line(2) = vehiclerecords(2)
            line(3) = vehiclerecords(3)
            line(4) = vehiclerecords(4)
            line(5) = vehiclerecords(8)
            line(6) = vehiclerecords(9)
            line(7) = vehiclerecords(7)
            line(8) = vehiclerecords(6)
            line(9) = vehiclerecords(5)


            stringline = sr.ReadLine() 'this adds all the vehicle details to the list view 
            stock = New ListViewItem(line)
                lststock.Items.Add(stock)
            End While
            sr.Close()



    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click ' this button takes the user to the previous 
        Me.Hide()
        Staffportal.Show()

    End Sub

    'this procedure outputs the makes of the vehicles in alphabetical order
    Private Sub sortbtn_Click(sender As Object, e As EventArgs) Handles sortbtn.Click
        Dim Index As Integer
        Dim vehicles(0 To 20) As vehicledetails
        Dim Temp As vehicledetails
        Dim Swapped As Boolean
        Dim itm As New ListViewItem
        Index = 0
        lststock.Items.Clear()

        lststock.View = View.Details
        lststock.GridLines = True
        lststock.FullRowSelect = True
        lststock.Scrollable = True
        lststock.Columns.Add("Registrtion number", 100)
        lststock.Columns.Add("Make", 100)
        lststock.Columns.Add("Model", 100)
        lststock.Columns.Add("Colour ", 100)
        lststock.Columns.Add("Mileage", 100)
        lststock.Columns.Add("Fuel type", 100)
        lststock.Columns.Add("Transmission type", 100)
        lststock.Columns.Add("Number of owners", 100)
        lststock.Columns.Add("Existing problems", 100)
        lststock.Columns.Add("Price bought for", 100)


        'populate array of records with unsorted customers
        Dim sr As New System.IO.StreamReader(Dir$("vehicledetails.txt"), True)
        stringline = sr.ReadLine()

        Do
            vehiclerecords = stringline.Split(",")
            vehicles(Index).regnumber = vehiclerecords(0)
            vehicles(Index).make = vehiclerecords(1)
            vehicles(Index).model = vehiclerecords(2)
            vehicles(Index).colour = vehiclerecords(3)
            vehicles(Index).mileage = vehiclerecords(4)
            vehicles(Index).price = vehiclerecords(5)
            vehicles(Index).problems = vehiclerecords(6)
            vehicles(Index).owners = vehiclerecords(7)
            vehicles(Index).fueltype = vehiclerecords(8)
            vehicles(Index).transmission = vehiclerecords(9)





            Index = Index + 1
            stringline = sr.ReadLine()
        Loop While (stringline <> Nothing) '
        Index = Index - 1
        sr.Close()

        'perform bubble sort on vehicle make outputing the vehicles in ascending order
        Do
            Swapped = False
            For I = 0 To (Index - 1)
                If (System.String.Compare(vehicles(I).make, vehicles(I + 1).make) > 0) Then 'If current is more than the next item in the array perform a swap operation
                    'method 1
                    Temp = vehicles(I) 'put next item in temp
                    vehicles(I) = vehicles(I + 1) 'put current item in next item
                    vehicles(I + 1) = Temp 'put next item in current item 
                    Swapped = True 'set swap flag to true to test another cycle
                End If
            Next

        Loop Until (Swapped = False) 'drop out of loop when no items are swapped

        'OUTPUT all records inorder your task

        For i = 0 To Index
            itm = New ListViewItem()
            itm.SubItems.AddRange({vehicles(i).regnumber, vehicles(i).make, vehicles(i).model, vehicles(i).colour, vehicles(i).mileage, vehicles(i).price, vehicles(i).problems, vehicles(i).owners, vehicles(i).fueltype, vehicles(i).transmission})
            lststock.Items.Add(itm)
        Next i
    End Sub




    '   Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click

    'Dim i = 0
    ' Dim sr As New System.IO.StreamReader(Dir$("vehicledetails.txt"), True)
    '   stringline = sr.ReadLine()
    '

    '    vehiclerecords = stringline.Split(",")
    'Do
    'For i = 0 To 20
    'If (UCase(txtsearch.Text) = vehiclerecords(i)) Then ' 
    '               line(0) = vehiclerecords(0)
    '               line(1) = vehiclerecords(1)
    '               line(2) = vehiclerecords(2)
    '               line(3) = vehiclerecords(3)
    '               line(4) = vehiclerecords(4)
    '              line(5) = vehiclerecords(8)
    '             line(6) = vehiclerecords(9)
    '             line(7) = vehiclerecords(7)
    '            line(8) = vehiclerecords(6)
    '            line(9) = vehiclerecords(5)


    '            stringline = sr.ReadLine()
    '            stock = New ListViewItem(line)
    '           lststock.Items.Add(stock)
    ' End If
    ' Next i
    '   Loop Until (ucase(txtsearch.Text) = vehiclerecords(i)) = True



    ' End Sub




End Class