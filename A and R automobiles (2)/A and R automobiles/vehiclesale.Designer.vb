<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vehiclesale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CBcustomerID = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtvehicleproblems = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DTPbookeddate = New System.Windows.Forms.DateTimePicker()
        Me.paymentscheme = New System.Windows.Forms.GroupBox()
        Me.calcbtn = New System.Windows.Forms.Button()
        Me.txtmonthlyfees = New System.Windows.Forms.TextBox()
        Me.txtpaymnetduration = New System.Windows.Forms.TextBox()
        Me.txtupront = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GBpaymenttype = New System.Windows.Forms.GroupBox()
        Me.RBmonthlypayments = New System.Windows.Forms.RadioButton()
        Me.RBfull = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.CBpaymentmethod = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnumofowners = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtmileage = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmake = New System.Windows.Forms.TextBox()
        Me.txtmodel = New System.Windows.Forms.TextBox()
        Me.txtcolour = New System.Windows.Forms.TextBox()
        Me.txttransmission = New System.Windows.Forms.TextBox()
        Me.txtfueltype = New System.Windows.Forms.TextBox()
        Me.CBregistrationnum = New System.Windows.Forms.ComboBox()
        Me.backbtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paymentscheme.SuspendLayout()
        Me.GBpaymenttype.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 38)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Vehicle sale form"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.A_and_R_automobiles.My.Resources.Resources.Untitled1
        Me.PictureBox1.Location = New System.Drawing.Point(0, -4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(27, 331)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 17)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "Fuel type"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 297)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 17)
        Me.Label16.TabIndex = 79
        Me.Label16.Text = "Transmission"
        '
        'CBcustomerID
        '
        Me.CBcustomerID.FormattingEnabled = True
        Me.CBcustomerID.Location = New System.Drawing.Point(117, 114)
        Me.CBcustomerID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBcustomerID.Name = "CBcustomerID"
        Me.CBcustomerID.Size = New System.Drawing.Size(121, 24)
        Me.CBcustomerID.TabIndex = 78
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 114)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 17)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "Customer ID"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 446)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 34)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "Problems with " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vehicle"
        '
        'txtvehicleproblems
        '
        Me.txtvehicleproblems.Location = New System.Drawing.Point(117, 443)
        Me.txtvehicleproblems.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtvehicleproblems.Name = "txtvehicleproblems"
        Me.txtvehicleproblems.Size = New System.Drawing.Size(121, 22)
        Me.txtvehicleproblems.TabIndex = 75
        '
        'Label13
        '
        Me.Label13.AllowDrop = True
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 263)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 17)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "colour"
        '
        'DTPbookeddate
        '
        Me.DTPbookeddate.Location = New System.Drawing.Point(117, 527)
        Me.DTPbookeddate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DTPbookeddate.Name = "DTPbookeddate"
        Me.DTPbookeddate.Size = New System.Drawing.Size(153, 22)
        Me.DTPbookeddate.TabIndex = 70
        '
        'paymentscheme
        '
        Me.paymentscheme.Controls.Add(Me.calcbtn)
        Me.paymentscheme.Controls.Add(Me.txtmonthlyfees)
        Me.paymentscheme.Controls.Add(Me.txtpaymnetduration)
        Me.paymentscheme.Controls.Add(Me.txtupront)
        Me.paymentscheme.Controls.Add(Me.Label12)
        Me.paymentscheme.Controls.Add(Me.Label11)
        Me.paymentscheme.Controls.Add(Me.Label10)
        Me.paymentscheme.Location = New System.Drawing.Point(359, 262)
        Me.paymentscheme.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.paymentscheme.Name = "paymentscheme"
        Me.paymentscheme.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.paymentscheme.Size = New System.Drawing.Size(341, 197)
        Me.paymentscheme.TabIndex = 69
        Me.paymentscheme.TabStop = False
        Me.paymentscheme.Text = "Payment scheme"
        Me.paymentscheme.Visible = False
        '
        'calcbtn
        '
        Me.calcbtn.Location = New System.Drawing.Point(185, 105)
        Me.calcbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.calcbtn.Name = "calcbtn"
        Me.calcbtn.Size = New System.Drawing.Size(92, 32)
        Me.calcbtn.TabIndex = 40
        Me.calcbtn.Text = "Calculate"
        Me.calcbtn.UseVisualStyleBackColor = True
        '
        'txtmonthlyfees
        '
        Me.txtmonthlyfees.Location = New System.Drawing.Point(187, 160)
        Me.txtmonthlyfees.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmonthlyfees.Name = "txtmonthlyfees"
        Me.txtmonthlyfees.Size = New System.Drawing.Size(128, 22)
        Me.txtmonthlyfees.TabIndex = 43
        '
        'txtpaymnetduration
        '
        Me.txtpaymnetduration.Location = New System.Drawing.Point(187, 75)
        Me.txtpaymnetduration.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtpaymnetduration.Name = "txtpaymnetduration"
        Me.txtpaymnetduration.Size = New System.Drawing.Size(73, 22)
        Me.txtpaymnetduration.TabIndex = 42
        '
        'txtupront
        '
        Me.txtupront.Location = New System.Drawing.Point(185, 46)
        Me.txtupront.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtupront.Name = "txtupront"
        Me.txtupront.Size = New System.Drawing.Size(73, 22)
        Me.txtupront.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 164)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 17)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Monthly fees"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 76)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 17)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Payment duration(months)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 49)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 17)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Up front amount"
        '
        'GBpaymenttype
        '
        Me.GBpaymenttype.Controls.Add(Me.RBmonthlypayments)
        Me.GBpaymenttype.Controls.Add(Me.RBfull)
        Me.GBpaymenttype.Location = New System.Drawing.Point(359, 135)
        Me.GBpaymenttype.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GBpaymenttype.Name = "GBpaymenttype"
        Me.GBpaymenttype.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GBpaymenttype.Size = New System.Drawing.Size(184, 105)
        Me.GBpaymenttype.TabIndex = 68
        Me.GBpaymenttype.TabStop = False
        Me.GBpaymenttype.Text = "payment type"
        Me.GBpaymenttype.Visible = False
        '
        'RBmonthlypayments
        '
        Me.RBmonthlypayments.AutoSize = True
        Me.RBmonthlypayments.Location = New System.Drawing.Point(27, 66)
        Me.RBmonthlypayments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RBmonthlypayments.Name = "RBmonthlypayments"
        Me.RBmonthlypayments.Size = New System.Drawing.Size(136, 21)
        Me.RBmonthlypayments.TabIndex = 37
        Me.RBmonthlypayments.TabStop = True
        Me.RBmonthlypayments.Text = "monthly payment"
        Me.RBmonthlypayments.UseVisualStyleBackColor = True
        '
        'RBfull
        '
        Me.RBfull.AutoSize = True
        Me.RBfull.Location = New System.Drawing.Point(27, 37)
        Me.RBfull.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RBfull.Name = "RBfull"
        Me.RBfull.Size = New System.Drawing.Size(105, 21)
        Me.RBfull.TabIndex = 36
        Me.RBfull.TabStop = True
        Me.RBfull.Text = "full payment"
        Me.RBfull.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 527)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 17)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Booking date"
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.savebtn.Location = New System.Drawing.Point(192, 602)
        Me.savebtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(131, 76)
        Me.savebtn.TabIndex = 65
        Me.savebtn.Text = "submit order"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'CBpaymentmethod
        '
        Me.CBpaymentmethod.FormattingEnabled = True
        Me.CBpaymentmethod.Items.AddRange(New Object() {"cash", "credit card"})
        Me.CBpaymentmethod.Location = New System.Drawing.Point(469, 98)
        Me.CBpaymentmethod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBpaymentmethod.Name = "CBpaymentmethod"
        Me.CBpaymentmethod.Size = New System.Drawing.Size(109, 24)
        Me.CBpaymentmethod.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(349, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 17)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "payment method"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 406)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 34)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Number of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "previous owners"
        '
        'txtnumofowners
        '
        Me.txtnumofowners.Location = New System.Drawing.Point(131, 414)
        Me.txtnumofowners.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnumofowners.Name = "txtnumofowners"
        Me.txtnumofowners.Size = New System.Drawing.Size(35, 22)
        Me.txtnumofowners.TabIndex = 61
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(117, 496)
        Me.txtprice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(80, 22)
        Me.txtprice.TabIndex = 60
        '
        'txtmileage
        '
        Me.txtmileage.Location = New System.Drawing.Point(117, 367)
        Me.txtmileage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmileage.Name = "txtmileage"
        Me.txtmileage.Size = New System.Drawing.Size(120, 22)
        Me.txtmileage.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 496)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 367)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Mileage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Make"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 34)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Registration " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "number"
        '
        'txtmake
        '
        Me.txtmake.Location = New System.Drawing.Point(117, 190)
        Me.txtmake.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmake.Name = "txtmake"
        Me.txtmake.Size = New System.Drawing.Size(120, 22)
        Me.txtmake.TabIndex = 84
        '
        'txtmodel
        '
        Me.txtmodel.Location = New System.Drawing.Point(117, 228)
        Me.txtmodel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.Size = New System.Drawing.Size(120, 22)
        Me.txtmodel.TabIndex = 85
        '
        'txtcolour
        '
        Me.txtcolour.Location = New System.Drawing.Point(117, 263)
        Me.txtcolour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcolour.Name = "txtcolour"
        Me.txtcolour.Size = New System.Drawing.Size(120, 22)
        Me.txtcolour.TabIndex = 86
        '
        'txttransmission
        '
        Me.txttransmission.Location = New System.Drawing.Point(117, 297)
        Me.txttransmission.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttransmission.Name = "txttransmission"
        Me.txttransmission.Size = New System.Drawing.Size(120, 22)
        Me.txttransmission.TabIndex = 87
        '
        'txtfueltype
        '
        Me.txtfueltype.Location = New System.Drawing.Point(117, 331)
        Me.txtfueltype.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtfueltype.Name = "txtfueltype"
        Me.txtfueltype.Size = New System.Drawing.Size(120, 22)
        Me.txtfueltype.TabIndex = 88
        '
        'CBregistrationnum
        '
        Me.CBregistrationnum.FormattingEnabled = True
        Me.CBregistrationnum.Location = New System.Drawing.Point(117, 150)
        Me.CBregistrationnum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBregistrationnum.Name = "CBregistrationnum"
        Me.CBregistrationnum.Size = New System.Drawing.Size(121, 24)
        Me.CBregistrationnum.TabIndex = 89
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.backbtn.Location = New System.Drawing.Point(371, 602)
        Me.backbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(131, 76)
        Me.backbtn.TabIndex = 90
        Me.backbtn.Text = "Previous menu"
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'vehiclesale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(757, 705)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.CBregistrationnum)
        Me.Controls.Add(Me.txtfueltype)
        Me.Controls.Add(Me.txttransmission)
        Me.Controls.Add(Me.txtcolour)
        Me.Controls.Add(Me.txtmodel)
        Me.Controls.Add(Me.txtmake)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CBcustomerID)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtvehicleproblems)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DTPbookeddate)
        Me.Controls.Add(Me.paymentscheme)
        Me.Controls.Add(Me.GBpaymenttype)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.CBpaymentmethod)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtnumofowners)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtmileage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "vehiclesale"
        Me.Text = "vehiclesale"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paymentscheme.ResumeLayout(False)
        Me.paymentscheme.PerformLayout()
        Me.GBpaymenttype.ResumeLayout(False)
        Me.GBpaymenttype.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents CBcustomerID As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtvehicleproblems As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DTPbookeddate As DateTimePicker
    Friend WithEvents paymentscheme As GroupBox
    Friend WithEvents calcbtn As Button
    Friend WithEvents txtmonthlyfees As TextBox
    Friend WithEvents txtpaymnetduration As TextBox
    Friend WithEvents txtupront As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GBpaymenttype As GroupBox
    Friend WithEvents RBmonthlypayments As RadioButton
    Friend WithEvents RBfull As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents savebtn As Button
    Friend WithEvents CBpaymentmethod As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnumofowners As TextBox
    Friend WithEvents txtprice As TextBox
    Friend WithEvents txtmileage As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmake As TextBox
    Friend WithEvents txtmodel As TextBox
    Friend WithEvents txtcolour As TextBox
    Friend WithEvents txttransmission As TextBox
    Friend WithEvents txtfueltype As TextBox
    Friend WithEvents CBregistrationnum As ComboBox
    Friend WithEvents backbtn As Button
End Class
