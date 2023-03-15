<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class receipt
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
        Me.backbtn = New System.Windows.Forms.Button()
        Me.lstsales = New System.Windows.Forms.ListView()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 39)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Sales"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.A_and_R_automobiles.My.Resources.Resources.Untitled1
        Me.PictureBox2.Location = New System.Drawing.Point(-7, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(126, 76)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 124
        Me.PictureBox2.TabStop = False
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.backbtn.Location = New System.Drawing.Point(226, 338)
        Me.backbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(92, 53)
        Me.backbtn.TabIndex = 125
        Me.backbtn.Text = "Return to manager portal"
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'lstsales
        '
        Me.lstsales.GridLines = True
        Me.lstsales.HideSelection = False
        Me.lstsales.Location = New System.Drawing.Point(-1, 79)
        Me.lstsales.Margin = New System.Windows.Forms.Padding(2)
        Me.lstsales.Name = "lstsales"
        Me.lstsales.Size = New System.Drawing.Size(583, 255)
        Me.lstsales.TabIndex = 126
        Me.lstsales.UseCompatibleStateImageBehavior = False
        '
        'receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(585, 402)
        Me.Controls.Add(Me.lstsales)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "receipt"
        Me.Text = "receipt"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents backbtn As Button
    Friend WithEvents lstsales As ListView
End Class
