﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class welcome
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
        Me.staffbtn = New System.Windows.Forms.Button()
        Me.managerbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A and R automobiles"
        '
        'staffbtn
        '
        Me.staffbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.staffbtn.Location = New System.Drawing.Point(31, 190)
        Me.staffbtn.Name = "staffbtn"
        Me.staffbtn.Size = New System.Drawing.Size(122, 80)
        Me.staffbtn.TabIndex = 1
        Me.staffbtn.Text = "Staff form"
        Me.staffbtn.UseVisualStyleBackColor = False
        '
        'managerbtn
        '
        Me.managerbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.managerbtn.Location = New System.Drawing.Point(210, 190)
        Me.managerbtn.Name = "managerbtn"
        Me.managerbtn.Size = New System.Drawing.Size(122, 80)
        Me.managerbtn.TabIndex = 2
        Me.managerbtn.Text = "Manager form"
        Me.managerbtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.A_and_R_automobiles.My.Resources.Resources.Untitled1
        Me.PictureBox1.Location = New System.Drawing.Point(104, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(376, 305)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.managerbtn)
        Me.Controls.Add(Me.staffbtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "welcome"
        Me.Text = "welcome"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents staffbtn As Button
    Friend WithEvents managerbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
