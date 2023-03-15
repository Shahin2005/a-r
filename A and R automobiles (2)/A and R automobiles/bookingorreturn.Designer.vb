<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bookingorreturn
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
        Me.vehicelrentalsbtn = New System.Windows.Forms.Button()
        Me.rentalreturnbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 52)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rental portal"
        '
        'vehicelrentalsbtn
        '
        Me.vehicelrentalsbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.vehicelrentalsbtn.Location = New System.Drawing.Point(106, 217)
        Me.vehicelrentalsbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.vehicelrentalsbtn.Name = "vehicelrentalsbtn"
        Me.vehicelrentalsbtn.Size = New System.Drawing.Size(161, 101)
        Me.vehicelrentalsbtn.TabIndex = 68
        Me.vehicelrentalsbtn.Text = "Rental booking"
        Me.vehicelrentalsbtn.UseVisualStyleBackColor = False
        '
        'rentalreturnbtn
        '
        Me.rentalreturnbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.rentalreturnbtn.Location = New System.Drawing.Point(315, 217)
        Me.rentalreturnbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.rentalreturnbtn.Name = "rentalreturnbtn"
        Me.rentalreturnbtn.Size = New System.Drawing.Size(161, 101)
        Me.rentalreturnbtn.TabIndex = 69
        Me.rentalreturnbtn.Text = "Rental return"
        Me.rentalreturnbtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.A_and_R_automobiles.My.Resources.Resources.Untitled1
        Me.PictureBox1.Location = New System.Drawing.Point(222, 65)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'bookingorreturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(611, 356)
        Me.Controls.Add(Me.rentalreturnbtn)
        Me.Controls.Add(Me.vehicelrentalsbtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "bookingorreturn"
        Me.Text = "bookingorreturn"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents vehicelrentalsbtn As Button
    Friend WithEvents rentalreturnbtn As Button
End Class
