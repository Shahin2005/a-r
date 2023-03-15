<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vehiclepurchase
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtregistrationnum = New System.Windows.Forms.TextBox()
        Me.txtmileage = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtnumofowners = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.txtmake = New System.Windows.Forms.TextBox()
        Me.txtmodel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtvehiclecolour = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtvehicleproblems = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtfueltype = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rbauto = New System.Windows.Forms.RadioButton()
        Me.Rbmanual = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vehicle purchase" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registration " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Make"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Model"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mileage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 460)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Price"
        '
        'txtregistrationnum
        '
        Me.txtregistrationnum.Location = New System.Drawing.Point(109, 112)
        Me.txtregistrationnum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtregistrationnum.Name = "txtregistrationnum"
        Me.txtregistrationnum.Size = New System.Drawing.Size(100, 22)
        Me.txtregistrationnum.TabIndex = 6
        '
        'txtmileage
        '
        Me.txtmileage.Location = New System.Drawing.Point(109, 208)
        Me.txtmileage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmileage.Name = "txtmileage"
        Me.txtmileage.Size = New System.Drawing.Size(100, 22)
        Me.txtmileage.TabIndex = 9
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(109, 452)
        Me.txtprice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(100, 22)
        Me.txtprice.TabIndex = 10
        '
        'txtnumofowners
        '
        Me.txtnumofowners.Location = New System.Drawing.Point(133, 393)
        Me.txtnumofowners.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnumofowners.Name = "txtnumofowners"
        Me.txtnumofowners.Size = New System.Drawing.Size(73, 22)
        Me.txtnumofowners.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 385)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 34)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Number of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "previous owners"
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.savebtn.Location = New System.Drawing.Point(73, 511)
        Me.savebtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(137, 73)
        Me.savebtn.TabIndex = 16
        Me.savebtn.Text = "save vehicle details"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'txtmake
        '
        Me.txtmake.Location = New System.Drawing.Point(109, 149)
        Me.txtmake.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmake.Name = "txtmake"
        Me.txtmake.Size = New System.Drawing.Size(100, 22)
        Me.txtmake.TabIndex = 17
        '
        'txtmodel
        '
        Me.txtmodel.Location = New System.Drawing.Point(109, 180)
        Me.txtmodel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.Size = New System.Drawing.Size(100, 22)
        Me.txtmodel.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 356)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "colour"
        '
        'txtvehiclecolour
        '
        Me.txtvehiclecolour.Location = New System.Drawing.Point(109, 356)
        Me.txtvehiclecolour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtvehiclecolour.Name = "txtvehiclecolour"
        Me.txtvehiclecolour.Size = New System.Drawing.Size(100, 22)
        Me.txtvehiclecolour.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.A_and_R_automobiles.My.Resources.Resources.Untitled1
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'txtvehicleproblems
        '
        Me.txtvehicleproblems.Location = New System.Drawing.Point(109, 422)
        Me.txtvehicleproblems.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtvehicleproblems.Name = "txtvehicleproblems"
        Me.txtvehicleproblems.Size = New System.Drawing.Size(100, 22)
        Me.txtvehicleproblems.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 422)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 34)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "existing" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "problems"
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.backbtn.Location = New System.Drawing.Point(252, 511)
        Me.backbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(137, 73)
        Me.backbtn.TabIndex = 44
        Me.backbtn.Text = "Previous menu"
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 250)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 17)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Fuel type"
        '
        'txtfueltype
        '
        Me.txtfueltype.Location = New System.Drawing.Point(109, 241)
        Me.txtfueltype.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtfueltype.Name = "txtfueltype"
        Me.txtfueltype.Size = New System.Drawing.Size(100, 22)
        Me.txtfueltype.TabIndex = 46
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rbauto)
        Me.GroupBox1.Controls.Add(Me.Rbmanual)
        Me.GroupBox1.Location = New System.Drawing.Point(97, 276)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(113, 74)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "transmission"
        '
        'Rbauto
        '
        Me.Rbauto.AutoSize = True
        Me.Rbauto.Location = New System.Drawing.Point(8, 23)
        Me.Rbauto.Margin = New System.Windows.Forms.Padding(4)
        Me.Rbauto.Name = "Rbauto"
        Me.Rbauto.Size = New System.Drawing.Size(90, 21)
        Me.Rbauto.TabIndex = 49
        Me.Rbauto.TabStop = True
        Me.Rbauto.Text = "automatic"
        Me.Rbauto.UseVisualStyleBackColor = True
        '
        'Rbmanual
        '
        Me.Rbmanual.AutoSize = True
        Me.Rbmanual.Location = New System.Drawing.Point(8, 49)
        Me.Rbmanual.Margin = New System.Windows.Forms.Padding(4)
        Me.Rbmanual.Name = "Rbmanual"
        Me.Rbmanual.Size = New System.Drawing.Size(75, 21)
        Me.Rbmanual.TabIndex = 50
        Me.Rbmanual.TabStop = True
        Me.Rbmanual.Text = "manual"
        Me.Rbmanual.UseVisualStyleBackColor = True
        '
        'vehiclepurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(474, 597)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtfueltype)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtvehicleproblems)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtvehiclecolour)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtmodel)
        Me.Controls.Add(Me.txtmake)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtnumofowners)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtmileage)
        Me.Controls.Add(Me.txtregistrationnum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "vehiclepurchase"
        Me.Text = "vehicleform"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtregistrationnum As TextBox
    Friend WithEvents txtmileage As TextBox
    Friend WithEvents txtprice As TextBox
    Friend WithEvents txtnumofowners As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents savebtn As Button
    Friend WithEvents txtmake As TextBox
    Friend WithEvents txtmodel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtvehiclecolour As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtvehicleproblems As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents backbtn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtfueltype As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Rbmanual As RadioButton
    Friend WithEvents Rbauto As RadioButton
End Class
