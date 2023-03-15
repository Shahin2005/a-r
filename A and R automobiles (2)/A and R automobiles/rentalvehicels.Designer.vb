<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rentalvehicels
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
        Me.GBfueltype = New System.Windows.Forms.GroupBox()
        Me.RBauto = New System.Windows.Forms.RadioButton()
        Me.RBmanual = New System.Windows.Forms.RadioButton()
        Me.txtfueltype = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtcolour = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtmodel = New System.Windows.Forms.TextBox()
        Me.txtmake = New System.Windows.Forms.TextBox()
        Me.txtmileage = New System.Windows.Forms.TextBox()
        Me.txtregnumber = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.GBfueltype.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBfueltype
        '
        Me.GBfueltype.Controls.Add(Me.RBauto)
        Me.GBfueltype.Controls.Add(Me.RBmanual)
        Me.GBfueltype.Location = New System.Drawing.Point(100, 290)
        Me.GBfueltype.Margin = New System.Windows.Forms.Padding(4)
        Me.GBfueltype.Name = "GBfueltype"
        Me.GBfueltype.Padding = New System.Windows.Forms.Padding(4)
        Me.GBfueltype.Size = New System.Drawing.Size(113, 74)
        Me.GBfueltype.TabIndex = 71
        Me.GBfueltype.TabStop = False
        Me.GBfueltype.Text = "transmission"
        '
        'RBauto
        '
        Me.RBauto.AutoSize = True
        Me.RBauto.Location = New System.Drawing.Point(8, 23)
        Me.RBauto.Margin = New System.Windows.Forms.Padding(4)
        Me.RBauto.Name = "RBauto"
        Me.RBauto.Size = New System.Drawing.Size(90, 21)
        Me.RBauto.TabIndex = 49
        Me.RBauto.TabStop = True
        Me.RBauto.Text = "automatic"
        Me.RBauto.UseVisualStyleBackColor = True
        '
        'RBmanual
        '
        Me.RBmanual.AutoSize = True
        Me.RBmanual.Location = New System.Drawing.Point(8, 49)
        Me.RBmanual.Margin = New System.Windows.Forms.Padding(4)
        Me.RBmanual.Name = "RBmanual"
        Me.RBmanual.Size = New System.Drawing.Size(75, 21)
        Me.RBmanual.TabIndex = 50
        Me.RBmanual.TabStop = True
        Me.RBmanual.Text = "manual"
        Me.RBmanual.UseVisualStyleBackColor = True
        '
        'txtfueltype
        '
        Me.txtfueltype.Location = New System.Drawing.Point(112, 255)
        Me.txtfueltype.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtfueltype.Name = "txtfueltype"
        Me.txtfueltype.Size = New System.Drawing.Size(100, 22)
        Me.txtfueltype.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Fuel type"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.A_and_R_automobiles.My.Resources.Resources.Untitled1
        Me.PictureBox1.Location = New System.Drawing.Point(3, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'txtcolour
        '
        Me.txtcolour.Location = New System.Drawing.Point(112, 370)
        Me.txtcolour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcolour.Name = "txtcolour"
        Me.txtcolour.Size = New System.Drawing.Size(100, 22)
        Me.txtcolour.TabIndex = 65
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 370)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 17)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "colour"
        '
        'txtmodel
        '
        Me.txtmodel.Location = New System.Drawing.Point(112, 194)
        Me.txtmodel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtmodel.Size = New System.Drawing.Size(100, 22)
        Me.txtmodel.TabIndex = 63
        '
        'txtmake
        '
        Me.txtmake.Location = New System.Drawing.Point(112, 162)
        Me.txtmake.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmake.Name = "txtmake"
        Me.txtmake.Size = New System.Drawing.Size(100, 22)
        Me.txtmake.TabIndex = 62
        '
        'txtmileage
        '
        Me.txtmileage.Location = New System.Drawing.Point(112, 222)
        Me.txtmileage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmileage.Name = "txtmileage"
        Me.txtmileage.Size = New System.Drawing.Size(100, 22)
        Me.txtmileage.TabIndex = 58
        '
        'txtregnumber
        '
        Me.txtregnumber.Location = New System.Drawing.Point(112, 126)
        Me.txtregnumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtregnumber.Name = "txtregnumber"
        Me.txtregnumber.Size = New System.Drawing.Size(100, 22)
        Me.txtregnumber.TabIndex = 57
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 231)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 17)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Mileage"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 197)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 17)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "Model"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(19, 162)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 17)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Make"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(19, 119)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 34)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "Registration " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "number"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(149, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(254, 76)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "Rental vehicels" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "form"
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.backbtn.Location = New System.Drawing.Point(179, 433)
        Me.backbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(137, 73)
        Me.backbtn.TabIndex = 73
        Me.backbtn.Text = "Previous menu"
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.savebtn.Location = New System.Drawing.Point(22, 433)
        Me.savebtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(137, 73)
        Me.savebtn.TabIndex = 72
        Me.savebtn.Text = "save vehicle details"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'rentalvehicels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(441, 562)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.GBfueltype)
        Me.Controls.Add(Me.txtfueltype)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtcolour)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtmodel)
        Me.Controls.Add(Me.txtmake)
        Me.Controls.Add(Me.txtmileage)
        Me.Controls.Add(Me.txtregnumber)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "rentalvehicels"
        Me.Text = "rentalvehicels"
        Me.GBfueltype.ResumeLayout(False)
        Me.GBfueltype.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBfueltype As GroupBox
    Friend WithEvents RBauto As RadioButton
    Friend WithEvents RBmanual As RadioButton
    Friend WithEvents txtfueltype As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtcolour As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtmodel As TextBox
    Friend WithEvents txtmake As TextBox
    Friend WithEvents txtmileage As TextBox
    Friend WithEvents txtregnumber As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents backbtn As Button
    Friend WithEvents savebtn As Button
End Class
