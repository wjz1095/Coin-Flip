<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.FlipButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Option1TextBox = New System.Windows.Forms.TextBox()
        Me.Option2TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FlipButton
        '
        Me.FlipButton.Location = New System.Drawing.Point(87, 150)
        Me.FlipButton.Name = "FlipButton"
        Me.FlipButton.Size = New System.Drawing.Size(113, 39)
        Me.FlipButton.TabIndex = 0
        Me.FlipButton.Text = "Flip"
        Me.FlipButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Option 1"
        '
        'Option1TextBox
        '
        Me.Option1TextBox.Location = New System.Drawing.Point(12, 29)
        Me.Option1TextBox.Name = "Option1TextBox"
        Me.Option1TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Option1TextBox.TabIndex = 2
        '
        'Option2TextBox
        '
        Me.Option2TextBox.Location = New System.Drawing.Point(168, 29)
        Me.Option2TextBox.Name = "Option2TextBox"
        Me.Option2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Option2TextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Option 2"
        '
        'ResultLabel
        '
        Me.ResultLabel.AutoSize = True
        Me.ResultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultLabel.Location = New System.Drawing.Point(79, 80)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(133, 46)
        Me.ResultLabel.TabIndex = 5
        Me.ResultLabel.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 201)
        Me.Controls.Add(Me.ResultLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Option2TextBox)
        Me.Controls.Add(Me.Option1TextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlipButton)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Coin Flipper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlipButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Option1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Option2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ResultLabel As System.Windows.Forms.Label

End Class
