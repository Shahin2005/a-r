' All the strutctures, arrays and variables are declared
Module variables
    Public Structure Staffdetails
        Public ID As String
        Public DOB As String
        Public FirstName As String
        Public Surname As String
        Public phonenum As String
        Public password As String
    End Structure
    Public Structure Customerdetails
        Public NInum As String
        Public DOB As String
        Public FirstName As String
        Public Surname As String
        Public phonenum As String
        Public address As String
        Public postcode As String
        Public ID As String
    End Structure
    Public Structure vehicledetails
        Public regnumber As String
        Public make As String
        Public mileage As String
        Public model As String
        Public price As String
        Public colour As String
        Public problems As String
        Public owners As String
        Public fueltype As String
        Public transmission As String
    End Structure
    Public Structure saledetails
        Public regnumber As String
        Public paymenttype As String
        Public customerID As String
        Public paymentscheme As String
        Public paymentmethod As String
        Public vehicleprice As Integer
        Public datebooked As String
        Public staffID As String
        Public priceboughtfor As Integer
    End Structure
    Public Structure rentalvehicledetails
        Public regnumber As String
        Public make As String
        Public model As String
        Public mileage As Integer
        Public fueltype As String
        Public transmission As String
        Public colour As String
        Public returned As String
    End Structure
    Public Structure rentaldetails
        Public customerID As String
        Public regnumber As String
        Public dailyprice As Integer
        Public daysrented As Integer
        Public datebooked As String
        Public total As Integer
        Public rentalID As String
        Public returned As String
    End Structure

    Public stringline As String
    Public staff As New Staffdetails
    Public customer As New Customerdetails
    Public staffrecords(5) As String
    Public customerrecords(6) As String
    Public sale As New saledetails
    Public salerecords(7)
    Public customernum = 1
    Public vehicle As vehicledetails
    Public vehiclerecords(9) As String
    Public rentalrecords(7) As String
    Public bookingdate As String
    Public rental As rentaldetails
    Public rentalvehicles As rentalvehicledetails
    Public stockline(10) As String
    Public rentalvehiclerecords(5)
    Public line(10) As String
    Public item As String
    Public stock As New ListViewItem
    Public sales As New ListViewItem

    Function intcheck(ByVal input As String) As Boolean ' this functions checks if the field is a integer.
        Try
            Convert.ToInt32(input)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function


End Module



