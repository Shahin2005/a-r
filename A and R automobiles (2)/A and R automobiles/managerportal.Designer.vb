<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class managerportal
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
        Me.staffdetails = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.receiptsbtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 52)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Manager portal"
        '
        'staffdetails
        '
        Me.staffdetails.BackColor = System.Drawing.SystemColors.Highlight
        Me.staffdetails.Location = New System.Drawing.Point(220, 175)
        Me.staffdetails.Margin = New System.Windows.Forms.Padding(4)
        Me.staffdetails.Name = "staffdetails"
        Me.staffdetails.Size = New System.Drawing.Size(148, 98)
        Me.staffdetails.TabIndex = 4
        Me.staffdetails.Text = "Manage staff details"
        Me.staffdetails.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.A_and_R_automobiles.My.Resources.Resources.Untitled1
        Me.PictureBox1.Location = New System.Drawing.Point(136, 68)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'receiptsbtn
        '
        Me.receiptsbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.receiptsbtn.Location = New System.Drawing.Point(47, 175)
        Me.receiptsbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.receiptsbtn.Name = "receiptsbtn"
        Me.receiptsbtn.Size = New System.Drawing.Size(148, 98)
        Me.receiptsbtn.TabIndex = 44
        Me.receiptsbtn.Text = "view receipts"
        Me.receiptsbtn.UseVisualStyleBackColor = False
        '
        'managerportal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(439, 308)
        Me.Controls.Add(Me.receiptsbtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.staffdetails)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "managerportal"
        Me.Text = "manager"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents staffdetails As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents receiptsbtn As Button
End Class
