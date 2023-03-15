<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class managestaff
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSfirstname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSsurname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSphonenum = New System.Windows.Forms.TextBox()
        Me.txtSDOB = New System.Windows.Forms.TextBox()
        Me.cbstaffID = New System.Windows.Forms.ComboBox()
        Me.submitbtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.editbtn = New System.Windows.Forms.Button()
        Me.pass = New System.Windows.Forms.Label()
        Me.txtSpassword = New System.Windows.Forms.TextBox()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.help1 = New System.Windows.Forms.Button()
        Me.ToolTiphelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.help2 = New System.Windows.Forms.Button()
        Me.help3 = New System.Windows.Forms.Button()
        Me.help5 = New System.Windows.Forms.Button()
        Me.help4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 52)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Staff details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Staff ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "First name"
        '
        'txtSfirstname
        '
        Me.txtSfirstname.Location = New System.Drawing.Point(115, 130)
        Me.txtSfirstname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSfirstname.Name = "txtSfirstname"
        Me.txtSfirstname.Size = New System.Drawing.Size(149, 22)
        Me.txtSfirstname.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Surname"
        '
        'txtSsurname
        '
        Me.txtSsurname.Location = New System.Drawing.Point(115, 167)
        Me.txtSsurname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSsurname.Name = "txtSsurname"
        Me.txtSsurname.Size = New System.Drawing.Size(149, 22)
        Me.txtSsurname.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Phone number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "D.O.B"
        '
        'txtSphonenum
        '
        Me.txtSphonenum.Location = New System.Drawing.Point(115, 204)
        Me.txtSphonenum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSphonenum.Name = "txtSphonenum"
        Me.txtSphonenum.Size = New System.Drawing.Size(149, 22)
        Me.txtSphonenum.TabIndex = 9
        '
        'txtSDOB
        '
        Me.txtSDOB.Location = New System.Drawing.Point(115, 241)
        Me.txtSDOB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSDOB.Name = "txtSDOB"
        Me.txtSDOB.Size = New System.Drawing.Size(89, 22)
        Me.txtSDOB.TabIndex = 12
        '
        'cbstaffID
        '
        Me.cbstaffID.FormattingEnabled = True
        Me.cbstaffID.Location = New System.Drawing.Point(115, 89)
        Me.cbstaffID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbstaffID.Name = "cbstaffID"
        Me.cbstaffID.Size = New System.Drawing.Size(105, 24)
        Me.cbstaffID.TabIndex = 13
        '
        'submitbtn
        '
        Me.submitbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.submitbtn.Location = New System.Drawing.Point(21, 329)
        Me.submitbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.submitbtn.Name = "submitbtn"
        Me.submitbtn.Size = New System.Drawing.Size(125, 75)
        Me.submitbtn.TabIndex = 14
        Me.submitbtn.Text = "save details"
        Me.submitbtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.deletebtn.Location = New System.Drawing.Point(212, 329)
        Me.deletebtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(125, 75)
        Me.deletebtn.TabIndex = 15
        Me.deletebtn.Text = "delete details"
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'editbtn
        '
        Me.editbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.editbtn.Location = New System.Drawing.Point(21, 430)
        Me.editbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(125, 75)
        Me.editbtn.TabIndex = 16
        Me.editbtn.Text = "edit details"
        Me.editbtn.UseVisualStyleBackColor = False
        '
        'pass
        '
        Me.pass.AutoSize = True
        Me.pass.Location = New System.Drawing.Point(7, 281)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(69, 17)
        Me.pass.TabIndex = 18
        Me.pass.Text = "Password"
        '
        'txtSpassword
        '
        Me.txtSpassword.Location = New System.Drawing.Point(115, 281)
        Me.txtSpassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSpassword.Name = "txtSpassword"
        Me.txtSpassword.Size = New System.Drawing.Size(149, 22)
        Me.txtSpassword.TabIndex = 19
        Me.txtSpassword.TabStop = False
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.backbtn.Location = New System.Drawing.Point(212, 430)
        Me.backbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(125, 75)
        Me.backbtn.TabIndex = 20
        Me.backbtn.Text = "Previous menu"
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.A_and_R_automobiles.My.Resources.Resources.Untitled1
        Me.PictureBox1.Location = New System.Drawing.Point(5, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'help1
        '
        Me.help1.BackColor = System.Drawing.Color.IndianRed
        Me.help1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.help1.Location = New System.Drawing.Point(272, 242)
        Me.help1.Margin = New System.Windows.Forms.Padding(4)
        Me.help1.Name = "help1"
        Me.help1.Size = New System.Drawing.Size(27, 23)
        Me.help1.TabIndex = 43
        Me.help1.Text = "?"
        Me.help1.UseVisualStyleBackColor = False
        '
        'help2
        '
        Me.help2.BackColor = System.Drawing.Color.IndianRed
        Me.help2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.help2.Location = New System.Drawing.Point(272, 204)
        Me.help2.Margin = New System.Windows.Forms.Padding(4)
        Me.help2.Name = "help2"
        Me.help2.Size = New System.Drawing.Size(27, 23)
        Me.help2.TabIndex = 44
        Me.help2.Text = "?"
        Me.help2.UseVisualStyleBackColor = False
        '
        'help3
        '
        Me.help3.BackColor = System.Drawing.Color.IndianRed
        Me.help3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.help3.Location = New System.Drawing.Point(272, 280)
        Me.help3.Margin = New System.Windows.Forms.Padding(4)
        Me.help3.Name = "help3"
        Me.help3.Size = New System.Drawing.Size(27, 23)
        Me.help3.TabIndex = 45
        Me.help3.Text = "?"
        Me.help3.UseVisualStyleBackColor = False
        '
        'help5
        '
        Me.help5.BackColor = System.Drawing.Color.IndianRed
        Me.help5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.help5.Location = New System.Drawing.Point(272, 167)
        Me.help5.Margin = New System.Windows.Forms.Padding(4)
        Me.help5.Name = "help5"
        Me.help5.Size = New System.Drawing.Size(27, 23)
        Me.help5.TabIndex = 46
        Me.help5.Text = "?"
        Me.help5.UseVisualStyleBackColor = False
        '
        'help4
        '
        Me.help4.BackColor = System.Drawing.Color.IndianRed
        Me.help4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.help4.Location = New System.Drawing.Point(272, 129)
        Me.help4.Margin = New System.Windows.Forms.Padding(4)
        Me.help4.Name = "help4"
        Me.help4.Size = New System.Drawing.Size(27, 23)
        Me.help4.TabIndex = 47
        Me.help4.Text = "?"
        Me.help4.UseVisualStyleBackColor = False
        '
        'managestaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(448, 516)
        Me.Controls.Add(Me.help4)
        Me.Controls.Add(Me.help5)
        Me.Controls.Add(Me.help3)
        Me.Controls.Add(Me.help2)
        Me.Controls.Add(Me.help1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.txtSpassword)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.editbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.submitbtn)
        Me.Controls.Add(Me.cbstaffID)
        Me.Controls.Add(Me.txtSDOB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSphonenum)
        Me.Controls.Add(Me.txtSsurname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSfirstname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "managestaff"
        Me.Text = "managestaff"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSfirstname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSsurname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSphonenum As TextBox
    Friend WithEvents txtSDOB As TextBox
    Friend WithEvents cbstaffID As ComboBox
    Friend WithEvents submitbtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents editbtn As Button
    Friend WithEvents pass As Label
    Friend WithEvents txtSpassword As TextBox
    Friend WithEvents backbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents help1 As Button
    Friend WithEvents ToolTiphelp As ToolTip
    Friend WithEvents help2 As Button
    Friend WithEvents help3 As Button
    Friend WithEvents help5 As Button
    Friend WithEvents help4 As Button
End Class
