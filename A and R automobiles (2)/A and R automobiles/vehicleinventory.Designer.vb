<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vehicleinventory
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
        Me.lststock = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sortbtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lststock
        '
        Me.lststock.GridLines = True
        Me.lststock.HideSelection = False
        Me.lststock.Location = New System.Drawing.Point(1, 176)
        Me.lststock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lststock.Name = "lststock"
        Me.lststock.Size = New System.Drawing.Size(776, 278)
        Me.lststock.TabIndex = 0
        Me.lststock.UseCompatibleStateImageBehavior = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 52)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Vehicle stock"
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.backbtn.Location = New System.Drawing.Point(295, 460)
        Me.backbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(125, 75)
        Me.backbtn.TabIndex = 21
        Me.backbtn.Text = "Previous menu"
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.A_and_R_automobiles.My.Resources.Resources.Untitled1
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'sortbtn
        '
        Me.sortbtn.BackColor = System.Drawing.Color.IndianRed
        Me.sortbtn.Location = New System.Drawing.Point(315, 100)
        Me.sortbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.sortbtn.Name = "sortbtn"
        Me.sortbtn.Size = New System.Drawing.Size(115, 70)
        Me.sortbtn.TabIndex = 64
        Me.sortbtn.Text = "Sort in alphabetical" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "order"
        Me.sortbtn.UseVisualStyleBackColor = False
        '
        'vehicleinventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.sortbtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lststock)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "vehicleinventory"
        Me.Text = "vehicleinventory"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lststock As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents backbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents sortbtn As Button
End Class
