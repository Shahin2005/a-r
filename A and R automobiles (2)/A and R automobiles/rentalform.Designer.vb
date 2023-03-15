<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rentalform
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
        Me.txtvehiclecolour = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtmodel = New System.Windows.Forms.TextBox()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdailyprice = New System.Windows.Forms.TextBox()
        Me.txtmileage = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBregnumber = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DTPdatebooked = New System.Windows.Forms.DateTimePicker()
        Me.txtdaysrented = New System.Windows.Forms.TextBox()
        Me.CBcustomerID = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.editbtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.CBrentalID = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtmake = New System.Windows.Forms.TextBox()
        Me.lstrental = New System.Windows.Forms.ListView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtvehiclecolour
        '
        Me.txtvehiclecolour.Location = New System.Drawing.Point(99, 329)
        Me.txtvehiclecolour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtvehiclecolour.Name = "txtvehiclecolour"
        Me.txtvehiclecolour.Size = New System.Drawing.Size(100, 22)
        Me.txtvehiclecolour.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "colour"
        '
        'txtmodel
        '
        Me.txtmodel.Location = New System.Drawing.Point(97, 259)
        Me.txtmodel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.Size = New System.Drawing.Size(112, 22)
        Me.txtmodel.TabIndex = 55
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.savebtn.Location = New System.Drawing.Point(175, 503)
        Me.savebtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(131, 62)
        Me.savebtn.TabIndex = 53
        Me.savebtn.Text = "save rental details"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 395)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 17)
        Me.Label7.TabIndex = 52
        '
        'txtdailyprice
        '
        Me.txtdailyprice.Location = New System.Drawing.Point(99, 431)
        Me.txtdailyprice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdailyprice.Name = "txtdailyprice"
        Me.txtdailyprice.Size = New System.Drawing.Size(100, 22)
        Me.txtdailyprice.TabIndex = 50
        '
        'txtmileage
        '
        Me.txtmileage.Location = New System.Drawing.Point(99, 296)
        Me.txtmileage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmileage.Name = "txtmileage"
        Me.txtmileage.Size = New System.Drawing.Size(100, 22)
        Me.txtmileage.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 431)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "daily Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Mileage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Make"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 34)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Registration " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 76)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Vehicle rental " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "form"
        '
        'CBregnumber
        '
        Me.CBregnumber.FormattingEnabled = True
        Me.CBregnumber.Location = New System.Drawing.Point(97, 184)
        Me.CBregnumber.Margin = New System.Windows.Forms.Padding(4)
        Me.CBregnumber.Name = "CBregnumber"
        Me.CBregnumber.Size = New System.Drawing.Size(112, 24)
        Me.CBregnumber.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 34)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Rental start " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1, 402)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Days rented"
        '
        'DTPdatebooked
        '
        Me.DTPdatebooked.Location = New System.Drawing.Point(99, 360)
        Me.DTPdatebooked.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPdatebooked.Name = "DTPdatebooked"
        Me.DTPdatebooked.Size = New System.Drawing.Size(148, 22)
        Me.DTPdatebooked.TabIndex = 60
        '
        'txtdaysrented
        '
        Me.txtdaysrented.Location = New System.Drawing.Point(99, 395)
        Me.txtdaysrented.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdaysrented.Name = "txtdaysrented"
        Me.txtdaysrented.Size = New System.Drawing.Size(60, 22)
        Me.txtdaysrented.TabIndex = 64
        '
        'CBcustomerID
        '
        Me.CBcustomerID.FormattingEnabled = True
        Me.CBcustomerID.Location = New System.Drawing.Point(97, 152)
        Me.CBcustomerID.Margin = New System.Windows.Forms.Padding(4)
        Me.CBcustomerID.Name = "CBcustomerID"
        Me.CBcustomerID.Size = New System.Drawing.Size(112, 24)
        Me.CBcustomerID.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 17)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Customer ID"
        '
        'editbtn
        '
        Me.editbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.editbtn.Location = New System.Drawing.Point(347, 503)
        Me.editbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(131, 62)
        Me.editbtn.TabIndex = 68
        Me.editbtn.Text = "Save changes"
        Me.editbtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.deletebtn.Location = New System.Drawing.Point(173, 582)
        Me.deletebtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(131, 59)
        Me.deletebtn.TabIndex = 69
        Me.deletebtn.Text = "delete details"
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.backbtn.Location = New System.Drawing.Point(347, 582)
        Me.backbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(131, 59)
        Me.backbtn.TabIndex = 70
        Me.backbtn.Text = "Previous menu"
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'CBrentalID
        '
        Me.CBrentalID.FormattingEnabled = True
        Me.CBrentalID.Location = New System.Drawing.Point(97, 120)
        Me.CBrentalID.Margin = New System.Windows.Forms.Padding(4)
        Me.CBrentalID.Name = "CBrentalID"
        Me.CBrentalID.Size = New System.Drawing.Size(112, 24)
        Me.CBrentalID.TabIndex = 71
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 17)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Rental ID"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(307, 123)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(76, 22)
        Me.txttotal.TabIndex = 74
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(220, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 34)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Total price " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of rental"
        '
        'txtmake
        '
        Me.txtmake.Location = New System.Drawing.Point(97, 223)
        Me.txtmake.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmake.Name = "txtmake"
        Me.txtmake.Size = New System.Drawing.Size(112, 22)
        Me.txtmake.TabIndex = 78
        '
        'lstrental
        '
        Me.lstrental.HideSelection = False
        Me.lstrental.Location = New System.Drawing.Point(412, 86)
        Me.lstrental.Name = "lstrental"
        Me.lstrental.Size = New System.Drawing.Size(297, 324)
        Me.lstrental.TabIndex = 79
        Me.lstrental.UseCompatibleStateImageBehavior = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(407, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 58)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "Vehicles out " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for rental"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.A_and_R_automobiles.My.Resources.Resources.Untitled1
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'rentalform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(712, 670)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lstrental)
        Me.Controls.Add(Me.txtmake)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CBrentalID)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.editbtn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CBcustomerID)
        Me.Controls.Add(Me.txtdaysrented)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DTPdatebooked)
        Me.Controls.Add(Me.CBregnumber)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtvehiclecolour)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtmodel)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtdailyprice)
        Me.Controls.Add(Me.txtmileage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "rentalform"
        Me.Text = "lstrental"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtvehiclecolour As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtmodel As TextBox
    Friend WithEvents savebtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdailyprice As TextBox
    Friend WithEvents txtmileage As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBregnumber As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DTPdatebooked As DateTimePicker
    Friend WithEvents txtdaysrented As TextBox
    Friend WithEvents CBcustomerID As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents editbtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents backbtn As Button
    Friend WithEvents CBrentalID As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtmake As TextBox
    Friend WithEvents lstrental As ListView
    Friend WithEvents Label14 As Label
End Class
