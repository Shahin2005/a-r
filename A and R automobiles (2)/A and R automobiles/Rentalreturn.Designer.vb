<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rentalreturn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtextracharges = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtmilesdriven = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtmake = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CBrentalID = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CBcustomerID = New System.Windows.Forms.ComboBox()
        Me.txtdaysrented = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DTPdatebooked = New System.Windows.Forms.DateTimePicker()
        Me.CBregnumber = New System.Windows.Forms.ComboBox()
        Me.txtvehiclecolour = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtmodel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdailyprice = New System.Windows.Forms.TextBox()
        Me.txtmileage = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 52)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Rental return"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.A_and_R_automobiles.My.Resources.Resources.Untitled1
        Me.PictureBox2.Location = New System.Drawing.Point(1, 3)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(141, 81)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 68
        Me.PictureBox2.TabStop = False
        '
        'txtextracharges
        '
        Me.txtextracharges.Location = New System.Drawing.Point(305, 168)
        Me.txtextracharges.Margin = New System.Windows.Forms.Padding(4)
        Me.txtextracharges.Name = "txtextracharges"
        Me.txtextracharges.Size = New System.Drawing.Size(76, 22)
        Me.txtextracharges.TabIndex = 111
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(218, 171)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 34)
        Me.Label16.TabIndex = 110
        Me.Label16.Text = "Extra " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "charges"
        '
        'txtmilesdriven
        '
        Me.txtmilesdriven.Location = New System.Drawing.Point(305, 136)
        Me.txtmilesdriven.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmilesdriven.Name = "txtmilesdriven"
        Me.txtmilesdriven.Size = New System.Drawing.Size(76, 22)
        Me.txtmilesdriven.TabIndex = 109
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(218, 139)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 17)
        Me.Label15.TabIndex = 108
        Me.Label15.Text = "Miles driven"
        '
        'txtmake
        '
        Me.txtmake.Location = New System.Drawing.Point(95, 195)
        Me.txtmake.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmake.Name = "txtmake"
        Me.txtmake.Size = New System.Drawing.Size(112, 22)
        Me.txtmake.TabIndex = 107
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(305, 95)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(76, 22)
        Me.txttotal.TabIndex = 106
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(218, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 34)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "Total price " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of rental"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 17)
        Me.Label12.TabIndex = 104
        Me.Label12.Text = "Rental ID"
        '
        'CBrentalID
        '
        Me.CBrentalID.FormattingEnabled = True
        Me.CBrentalID.Location = New System.Drawing.Point(95, 92)
        Me.CBrentalID.Margin = New System.Windows.Forms.Padding(4)
        Me.CBrentalID.Name = "CBrentalID"
        Me.CBrentalID.Size = New System.Drawing.Size(112, 24)
        Me.CBrentalID.TabIndex = 103
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 17)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "Customer ID"
        '
        'CBcustomerID
        '
        Me.CBcustomerID.FormattingEnabled = True
        Me.CBcustomerID.Location = New System.Drawing.Point(95, 124)
        Me.CBcustomerID.Margin = New System.Windows.Forms.Padding(4)
        Me.CBcustomerID.Name = "CBcustomerID"
        Me.CBcustomerID.Size = New System.Drawing.Size(112, 24)
        Me.CBcustomerID.TabIndex = 101
        '
        'txtdaysrented
        '
        Me.txtdaysrented.Location = New System.Drawing.Point(97, 367)
        Me.txtdaysrented.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdaysrented.Name = "txtdaysrented"
        Me.txtdaysrented.Size = New System.Drawing.Size(60, 22)
        Me.txtdaysrented.TabIndex = 100
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(-1, 374)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "Days rented"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(-1, 332)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 34)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Rental start " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "date"
        '
        'DTPdatebooked
        '
        Me.DTPdatebooked.Location = New System.Drawing.Point(97, 332)
        Me.DTPdatebooked.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPdatebooked.Name = "DTPdatebooked"
        Me.DTPdatebooked.Size = New System.Drawing.Size(148, 22)
        Me.DTPdatebooked.TabIndex = 97
        '
        'CBregnumber
        '
        Me.CBregnumber.FormattingEnabled = True
        Me.CBregnumber.Location = New System.Drawing.Point(95, 156)
        Me.CBregnumber.Margin = New System.Windows.Forms.Padding(4)
        Me.CBregnumber.Name = "CBregnumber"
        Me.CBregnumber.Size = New System.Drawing.Size(112, 24)
        Me.CBregnumber.TabIndex = 96
        '
        'txtvehiclecolour
        '
        Me.txtvehiclecolour.Location = New System.Drawing.Point(97, 301)
        Me.txtvehiclecolour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtvehiclecolour.Name = "txtvehiclecolour"
        Me.txtvehiclecolour.Size = New System.Drawing.Size(100, 22)
        Me.txtvehiclecolour.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "colour"
        '
        'txtmodel
        '
        Me.txtmodel.Location = New System.Drawing.Point(95, 231)
        Me.txtmodel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.Size = New System.Drawing.Size(112, 22)
        Me.txtmodel.TabIndex = 93
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 17)
        Me.Label7.TabIndex = 92
        '
        'txtdailyprice
        '
        Me.txtdailyprice.Location = New System.Drawing.Point(97, 403)
        Me.txtdailyprice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdailyprice.Name = "txtdailyprice"
        Me.txtdailyprice.Size = New System.Drawing.Size(100, 22)
        Me.txtdailyprice.TabIndex = 91
        '
        'txtmileage
        '
        Me.txtmileage.Location = New System.Drawing.Point(97, 268)
        Me.txtmileage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmileage.Name = "txtmileage"
        Me.txtmileage.Size = New System.Drawing.Size(100, 22)
        Me.txtmileage.TabIndex = 90
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-1, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "daily Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Mileage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Make"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 34)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Registration " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "number"
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.backbtn.Location = New System.Drawing.Point(222, 479)
        Me.backbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(131, 75)
        Me.backbtn.TabIndex = 115
        Me.backbtn.Text = "Previous menu"
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.savebtn.Location = New System.Drawing.Point(56, 479)
        Me.savebtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(131, 75)
        Me.savebtn.TabIndex = 112
        Me.savebtn.Text = "save return details"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'Rentalreturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(432, 604)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.txtextracharges)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtmilesdriven)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtmake)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CBrentalID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CBcustomerID)
        Me.Controls.Add(Me.txtdaysrented)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DTPdatebooked)
        Me.Controls.Add(Me.CBregnumber)
        Me.Controls.Add(Me.txtvehiclecolour)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtmodel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtdailyprice)
        Me.Controls.Add(Me.txtmileage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Rentalreturn"
        Me.Text = "Rentalreturn"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtextracharges As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtmilesdriven As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtmake As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CBrentalID As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CBcustomerID As ComboBox
    Friend WithEvents txtdaysrented As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DTPdatebooked As DateTimePicker
    Friend WithEvents CBregnumber As ComboBox
    Friend WithEvents txtvehiclecolour As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtmodel As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdailyprice As TextBox
    Friend WithEvents txtmileage As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents backbtn As Button
    Friend WithEvents savebtn As Button
End Class
