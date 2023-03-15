<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customerform
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCfname = New System.Windows.Forms.TextBox()
        Me.txtCsurname = New System.Windows.Forms.TextBox()
        Me.txtCphonenum = New System.Windows.Forms.TextBox()
        Me.txtpostcode = New System.Windows.Forms.TextBox()
        Me.label43 = New System.Windows.Forms.Label()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.editbtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.submitbtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBcustomerID = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.help4 = New System.Windows.Forms.Button()
        Me.help5 = New System.Windows.Forms.Button()
        Me.help2 = New System.Windows.Forms.Button()
        Me.help1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolTiphelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(326, 52)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer form"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Phone Number"
        '
        'txtCfname
        '
        Me.txtCfname.Location = New System.Drawing.Point(129, 98)
        Me.txtCfname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCfname.Name = "txtCfname"
        Me.txtCfname.Size = New System.Drawing.Size(137, 22)
        Me.txtCfname.TabIndex = 8
        '
        'txtCsurname
        '
        Me.txtCsurname.Location = New System.Drawing.Point(129, 129)
        Me.txtCsurname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCsurname.Name = "txtCsurname"
        Me.txtCsurname.Size = New System.Drawing.Size(137, 22)
        Me.txtCsurname.TabIndex = 9
        '
        'txtCphonenum
        '
        Me.txtCphonenum.Location = New System.Drawing.Point(129, 161)
        Me.txtCphonenum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCphonenum.Name = "txtCphonenum"
        Me.txtCphonenum.Size = New System.Drawing.Size(137, 22)
        Me.txtCphonenum.TabIndex = 10
        '
        'txtpostcode
        '
        Me.txtpostcode.Location = New System.Drawing.Point(129, 193)
        Me.txtpostcode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtpostcode.Name = "txtpostcode"
        Me.txtpostcode.Size = New System.Drawing.Size(137, 22)
        Me.txtpostcode.TabIndex = 16
        '
        'label43
        '
        Me.label43.AutoSize = True
        Me.label43.Location = New System.Drawing.Point(17, 198)
        Me.label43.Name = "label43"
        Me.label43.Size = New System.Drawing.Size(71, 17)
        Me.label43.TabIndex = 15
        Me.label43.Text = "Post code"
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.backbtn.Location = New System.Drawing.Point(203, 453)
        Me.backbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(125, 75)
        Me.backbtn.TabIndex = 24
        Me.backbtn.Text = "Previous menu"
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'editbtn
        '
        Me.editbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.editbtn.Location = New System.Drawing.Point(12, 453)
        Me.editbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(125, 75)
        Me.editbtn.TabIndex = 23
        Me.editbtn.Text = "save changes"
        Me.editbtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.deletebtn.Location = New System.Drawing.Point(203, 352)
        Me.deletebtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(125, 75)
        Me.deletebtn.TabIndex = 22
        Me.deletebtn.Text = "delete details"
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'submitbtn
        '
        Me.submitbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.submitbtn.Location = New System.Drawing.Point(12, 352)
        Me.submitbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.submitbtn.Name = "submitbtn"
        Me.submitbtn.Size = New System.Drawing.Size(125, 75)
        Me.submitbtn.TabIndex = 21
        Me.submitbtn.Text = "save details"
        Me.submitbtn.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Customer ID"
        '
        'CBcustomerID
        '
        Me.CBcustomerID.FormattingEnabled = True
        Me.CBcustomerID.Location = New System.Drawing.Point(129, 63)
        Me.CBcustomerID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBcustomerID.Name = "CBcustomerID"
        Me.CBcustomerID.Size = New System.Drawing.Size(75, 24)
        Me.CBcustomerID.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Date of birth"
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(129, 254)
        Me.txtDOB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(137, 22)
        Me.txtDOB.TabIndex = 27
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(129, 224)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(137, 22)
        Me.txtaddress.TabIndex = 29
        '
        'help4
        '
        Me.help4.BackColor = System.Drawing.Color.IndianRed
        Me.help4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.help4.Location = New System.Drawing.Point(282, 129)
        Me.help4.Margin = New System.Windows.Forms.Padding(4)
        Me.help4.Name = "help4"
        Me.help4.Size = New System.Drawing.Size(27, 23)
        Me.help4.TabIndex = 52
        Me.help4.Text = "?"
        Me.help4.UseVisualStyleBackColor = False
        '
        'help5
        '
        Me.help5.BackColor = System.Drawing.Color.IndianRed
        Me.help5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.help5.Location = New System.Drawing.Point(282, 98)
        Me.help5.Margin = New System.Windows.Forms.Padding(4)
        Me.help5.Name = "help5"
        Me.help5.Size = New System.Drawing.Size(27, 23)
        Me.help5.TabIndex = 51
        Me.help5.Text = "?"
        Me.help5.UseVisualStyleBackColor = False
        '
        'help2
        '
        Me.help2.BackColor = System.Drawing.Color.IndianRed
        Me.help2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.help2.Location = New System.Drawing.Point(282, 160)
        Me.help2.Margin = New System.Windows.Forms.Padding(4)
        Me.help2.Name = "help2"
        Me.help2.Size = New System.Drawing.Size(27, 23)
        Me.help2.TabIndex = 49
        Me.help2.Text = "?"
        Me.help2.UseVisualStyleBackColor = False
        '
        'help1
        '
        Me.help1.BackColor = System.Drawing.Color.IndianRed
        Me.help1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.help1.Location = New System.Drawing.Point(282, 253)
        Me.help1.Margin = New System.Windows.Forms.Padding(4)
        Me.help1.Name = "help1"
        Me.help1.Size = New System.Drawing.Size(27, 23)
        Me.help1.TabIndex = 48
        Me.help1.Text = "?"
        Me.help1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Address"
        '
        'customerform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(379, 567)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.help4)
        Me.Controls.Add(Me.help5)
        Me.Controls.Add(Me.help2)
        Me.Controls.Add(Me.help1)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.CBcustomerID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.editbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.submitbtn)
        Me.Controls.Add(Me.txtpostcode)
        Me.Controls.Add(Me.label43)
        Me.Controls.Add(Me.txtCphonenum)
        Me.Controls.Add(Me.txtCsurname)
        Me.Controls.Add(Me.txtCfname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "customerform"
        Me.Text = "customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCfname As TextBox
    Friend WithEvents txtCsurname As TextBox
    Friend WithEvents txtCphonenum As TextBox
    Friend WithEvents txtpostcode As TextBox
    Friend WithEvents label43 As Label
    Friend WithEvents backbtn As Button
    Friend WithEvents editbtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents submitbtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents CBcustomerID As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents help4 As Button
    Friend WithEvents help5 As Button
    Friend WithEvents help2 As Button
    Friend WithEvents help1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolTiphelp As ToolTip
End Class
