<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staffportal
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
        Me.purchasebtn = New System.Windows.Forms.Button()
        Me.salebtn = New System.Windows.Forms.Button()
        Me.txtstaffpass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.customerdetailsbtn = New System.Windows.Forms.Button()
        Me.staffgroupbox = New System.Windows.Forms.GroupBox()
        Me.Rentalvehicelsbtn = New System.Windows.Forms.Button()
        Me.inventorybtn = New System.Windows.Forms.Button()
        Me.vehicelrentalsbtn = New System.Windows.Forms.Button()
        Me.enterbtn = New System.Windows.Forms.Button()
        Me.txtstaffID = New System.Windows.Forms.TextBox()
        Me.staffgroupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 52)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Staff portal"
        '
        'purchasebtn
        '
        Me.purchasebtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.purchasebtn.Location = New System.Drawing.Point(39, 17)
        Me.purchasebtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.purchasebtn.Name = "purchasebtn"
        Me.purchasebtn.Size = New System.Drawing.Size(136, 81)
        Me.purchasebtn.TabIndex = 2
        Me.purchasebtn.Text = "Vehicle purchase"
        Me.purchasebtn.UseVisualStyleBackColor = False
        '
        'salebtn
        '
        Me.salebtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.salebtn.Location = New System.Drawing.Point(341, 17)
        Me.salebtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.salebtn.Name = "salebtn"
        Me.salebtn.Size = New System.Drawing.Size(136, 81)
        Me.salebtn.TabIndex = 3
        Me.salebtn.Text = "Vehicle sale"
        Me.salebtn.UseVisualStyleBackColor = False
        '
        'txtstaffpass
        '
        Me.txtstaffpass.Location = New System.Drawing.Point(199, 128)
        Me.txtstaffpass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtstaffpass.Name = "txtstaffpass"
        Me.txtstaffpass.Size = New System.Drawing.Size(145, 22)
        Me.txtstaffpass.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 130)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Staff ID"
        '
        'customerdetailsbtn
        '
        Me.customerdetailsbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.customerdetailsbtn.Location = New System.Drawing.Point(39, 117)
        Me.customerdetailsbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.customerdetailsbtn.Name = "customerdetailsbtn"
        Me.customerdetailsbtn.Size = New System.Drawing.Size(136, 81)
        Me.customerdetailsbtn.TabIndex = 8
        Me.customerdetailsbtn.Text = "Customer details"
        Me.customerdetailsbtn.UseVisualStyleBackColor = False
        '
        'staffgroupbox
        '
        Me.staffgroupbox.AutoSize = True
        Me.staffgroupbox.Controls.Add(Me.Rentalvehicelsbtn)
        Me.staffgroupbox.Controls.Add(Me.inventorybtn)
        Me.staffgroupbox.Controls.Add(Me.vehicelrentalsbtn)
        Me.staffgroupbox.Controls.Add(Me.customerdetailsbtn)
        Me.staffgroupbox.Controls.Add(Me.purchasebtn)
        Me.staffgroupbox.Controls.Add(Me.salebtn)
        Me.staffgroupbox.Location = New System.Drawing.Point(12, 199)
        Me.staffgroupbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.staffgroupbox.Name = "staffgroupbox"
        Me.staffgroupbox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.staffgroupbox.Size = New System.Drawing.Size(519, 220)
        Me.staffgroupbox.TabIndex = 9
        Me.staffgroupbox.TabStop = False
        Me.staffgroupbox.Text = "Staff"
        '
        'Rentalvehicelsbtn
        '
        Me.Rentalvehicelsbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.Rentalvehicelsbtn.Location = New System.Drawing.Point(187, 117)
        Me.Rentalvehicelsbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Rentalvehicelsbtn.Name = "Rentalvehicelsbtn"
        Me.Rentalvehicelsbtn.Size = New System.Drawing.Size(136, 81)
        Me.Rentalvehicelsbtn.TabIndex = 11
        Me.Rentalvehicelsbtn.Text = "Rental vehicles"
        Me.Rentalvehicelsbtn.UseVisualStyleBackColor = False
        '
        'inventorybtn
        '
        Me.inventorybtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.inventorybtn.Location = New System.Drawing.Point(187, 17)
        Me.inventorybtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.inventorybtn.Name = "inventorybtn"
        Me.inventorybtn.Size = New System.Drawing.Size(136, 81)
        Me.inventorybtn.TabIndex = 10
        Me.inventorybtn.Text = "Inventory"
        Me.inventorybtn.UseVisualStyleBackColor = False
        '
        'vehicelrentalsbtn
        '
        Me.vehicelrentalsbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.vehicelrentalsbtn.Location = New System.Drawing.Point(341, 117)
        Me.vehicelrentalsbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.vehicelrentalsbtn.Name = "vehicelrentalsbtn"
        Me.vehicelrentalsbtn.Size = New System.Drawing.Size(136, 81)
        Me.vehicelrentalsbtn.TabIndex = 9
        Me.vehicelrentalsbtn.Text = "Rental form"
        Me.vehicelrentalsbtn.UseVisualStyleBackColor = False
        '
        'enterbtn
        '
        Me.enterbtn.Location = New System.Drawing.Point(225, 158)
        Me.enterbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.enterbtn.Name = "enterbtn"
        Me.enterbtn.Size = New System.Drawing.Size(75, 32)
        Me.enterbtn.TabIndex = 10
        Me.enterbtn.Text = "enter"
        Me.enterbtn.UseVisualStyleBackColor = True
        '
        'txtstaffID
        '
        Me.txtstaffID.Location = New System.Drawing.Point(199, 96)
        Me.txtstaffID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtstaffID.Name = "txtstaffID"
        Me.txtstaffID.Size = New System.Drawing.Size(145, 22)
        Me.txtstaffID.TabIndex = 11
        '
        'Staffportal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(547, 452)
        Me.Controls.Add(Me.txtstaffID)
        Me.Controls.Add(Me.enterbtn)
        Me.Controls.Add(Me.staffgroupbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtstaffpass)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Staffportal"
        Me.Text = "Staff"
        Me.staffgroupbox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents purchasebtn As Button
    Friend WithEvents salebtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents customerdetailsbtn As Button
    Friend WithEvents staffgroupbox As GroupBox
    Friend WithEvents enterbtn As Button
    Friend WithEvents vehicelrentalsbtn As Button
    Friend WithEvents txtstaffID As TextBox
    Private WithEvents txtstaffpass As TextBox
    Friend WithEvents inventorybtn As Button
    Friend WithEvents Rentalvehicelsbtn As Button
End Class
