<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.plusLeftLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.plusRightLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sum = New System.Windows.Forms.NumericUpDown()
        Me.minusLeftLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.minusRightLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.difference = New System.Windows.Forms.NumericUpDown()
        Me.startButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.sum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.difference, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timeLabel
        '
        Me.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.timeLabel.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.timeLabel.Location = New System.Drawing.Point(588, 9)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(200, 30)
        Me.timeLabel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(469, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Time Left"
        '
        'plusLeftLabel
        '
        Me.plusLeftLabel.AutoSize = True
        Me.plusLeftLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.plusLeftLabel.Location = New System.Drawing.Point(50, 75)
        Me.plusLeftLabel.Name = "plusLeftLabel"
        Me.plusLeftLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.plusLeftLabel.Size = New System.Drawing.Size(25, 32)
        Me.plusLeftLabel.TabIndex = 2
        Me.plusLeftLabel.Text = "?"
        Me.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(469, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(30, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "="
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'plusRightLabel
        '
        Me.plusRightLabel.AutoSize = True
        Me.plusRightLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.plusRightLabel.Location = New System.Drawing.Point(337, 75)
        Me.plusRightLabel.Name = "plusRightLabel"
        Me.plusRightLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.plusRightLabel.Size = New System.Drawing.Size(25, 32)
        Me.plusRightLabel.TabIndex = 4
        Me.plusRightLabel.Text = "?"
        Me.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(195, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(30, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "+"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sum
        '
        Me.sum.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.sum.Location = New System.Drawing.Point(602, 73)
        Me.sum.Name = "sum"
        Me.sum.Size = New System.Drawing.Size(120, 39)
        Me.sum.TabIndex = 1
        '
        'minusLeftLabel
        '
        Me.minusLeftLabel.AutoSize = True
        Me.minusLeftLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.minusLeftLabel.Location = New System.Drawing.Point(50, 151)
        Me.minusLeftLabel.Name = "minusLeftLabel"
        Me.minusLeftLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.minusLeftLabel.Size = New System.Drawing.Size(25, 32)
        Me.minusLeftLabel.TabIndex = 7
        Me.minusLeftLabel.Text = "?"
        Me.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(195, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(24, 32)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "-"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minusRightLabel
        '
        Me.minusRightLabel.AutoSize = True
        Me.minusRightLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.minusRightLabel.Location = New System.Drawing.Point(337, 151)
        Me.minusRightLabel.Name = "minusRightLabel"
        Me.minusRightLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.minusRightLabel.Size = New System.Drawing.Size(25, 32)
        Me.minusRightLabel.TabIndex = 9
        Me.minusRightLabel.Text = "?"
        Me.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(469, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(30, 32)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "="
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'difference
        '
        Me.difference.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.difference.Location = New System.Drawing.Point(602, 149)
        Me.difference.Name = "difference"
        Me.difference.Size = New System.Drawing.Size(120, 39)
        Me.difference.TabIndex = 2
        '
        'startButton
        '
        Me.startButton.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.startButton.Location = New System.Drawing.Point(337, 242)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(162, 37)
        Me.startButton.TabIndex = 0
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 328)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.difference)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.minusRightLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.minusLeftLabel)
        Me.Controls.Add(Me.sum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.plusRightLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.plusLeftLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.timeLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Math Quiz"
        CType(Me.sum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.difference, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timeLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents plusLeftLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents plusRightLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sum As NumericUpDown
    Friend WithEvents minusLeftLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents minusRightLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents difference As NumericUpDown
    Friend WithEvents startButton As Button
    Friend WithEvents Timer1 As Timer
End Class
