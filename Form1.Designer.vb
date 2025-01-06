<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnUp = New System.Windows.Forms.Button()
        Me.BtnRightUp = New System.Windows.Forms.Button()
        Me.BtnLeftUp = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.BtnRight = New System.Windows.Forms.Button()
        Me.BtnLeft = New System.Windows.Forms.Button()
        Me.BtnDown = New System.Windows.Forms.Button()
        Me.BtnRightDown = New System.Windows.Forms.Button()
        Me.BtnLeftDown = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumUpDownPTZSpeed = New System.Windows.Forms.NumericUpDown()
        Me.BtnZoomIn = New System.Windows.Forms.Button()
        Me.BtnZoomReset = New System.Windows.Forms.Button()
        Me.BtnZoomDecrease = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumUpDownPreset = New System.Windows.Forms.NumericUpDown()
        Me.BtnSetPreset = New System.Windows.Forms.Button()
        Me.BtnRemovePreset = New System.Windows.Forms.Button()
        Me.BtnRunPreset = New System.Windows.Forms.Button()
        CType(Me.NumUpDownPTZSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUpDownPreset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUp
        '
        Me.BtnUp.Location = New System.Drawing.Point(189, 40)
        Me.BtnUp.Name = "BtnUp"
        Me.BtnUp.Size = New System.Drawing.Size(103, 50)
        Me.BtnUp.TabIndex = 0
        Me.BtnUp.Text = "Up"
        Me.BtnUp.UseVisualStyleBackColor = True
        '
        'BtnRightUp
        '
        Me.BtnRightUp.Location = New System.Drawing.Point(330, 40)
        Me.BtnRightUp.Name = "BtnRightUp"
        Me.BtnRightUp.Size = New System.Drawing.Size(103, 50)
        Me.BtnRightUp.TabIndex = 1
        Me.BtnRightUp.Text = "Right Up"
        Me.BtnRightUp.UseVisualStyleBackColor = True
        '
        'BtnLeftUp
        '
        Me.BtnLeftUp.Location = New System.Drawing.Point(53, 40)
        Me.BtnLeftUp.Name = "BtnLeftUp"
        Me.BtnLeftUp.Size = New System.Drawing.Size(103, 50)
        Me.BtnLeftUp.TabIndex = 2
        Me.BtnLeftUp.Text = "Left Up"
        Me.BtnLeftUp.UseVisualStyleBackColor = True
        '
        'BtnHome
        '
        Me.BtnHome.Location = New System.Drawing.Point(189, 101)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(103, 50)
        Me.BtnHome.TabIndex = 3
        Me.BtnHome.Text = "Home"
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'BtnRight
        '
        Me.BtnRight.Location = New System.Drawing.Point(330, 101)
        Me.BtnRight.Name = "BtnRight"
        Me.BtnRight.Size = New System.Drawing.Size(103, 50)
        Me.BtnRight.TabIndex = 4
        Me.BtnRight.Text = "Right"
        Me.BtnRight.UseVisualStyleBackColor = True
        '
        'BtnLeft
        '
        Me.BtnLeft.Location = New System.Drawing.Point(53, 101)
        Me.BtnLeft.Name = "BtnLeft"
        Me.BtnLeft.Size = New System.Drawing.Size(103, 50)
        Me.BtnLeft.TabIndex = 5
        Me.BtnLeft.Text = "Left"
        Me.BtnLeft.UseVisualStyleBackColor = True
        '
        'BtnDown
        '
        Me.BtnDown.Location = New System.Drawing.Point(189, 165)
        Me.BtnDown.Name = "BtnDown"
        Me.BtnDown.Size = New System.Drawing.Size(103, 50)
        Me.BtnDown.TabIndex = 6
        Me.BtnDown.Text = "Down"
        Me.BtnDown.UseVisualStyleBackColor = True
        '
        'BtnRightDown
        '
        Me.BtnRightDown.Location = New System.Drawing.Point(330, 165)
        Me.BtnRightDown.Name = "BtnRightDown"
        Me.BtnRightDown.Size = New System.Drawing.Size(103, 50)
        Me.BtnRightDown.TabIndex = 7
        Me.BtnRightDown.Text = "Right Down"
        Me.BtnRightDown.UseVisualStyleBackColor = True
        '
        'BtnLeftDown
        '
        Me.BtnLeftDown.Location = New System.Drawing.Point(53, 165)
        Me.BtnLeftDown.Name = "BtnLeftDown"
        Me.BtnLeftDown.Size = New System.Drawing.Size(103, 50)
        Me.BtnLeftDown.TabIndex = 8
        Me.BtnLeftDown.Text = "Left Down"
        Me.BtnLeftDown.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "PTZ Speed:"
        '
        'NumUpDownPTZSpeed
        '
        Me.NumUpDownPTZSpeed.Location = New System.Drawing.Point(189, 250)
        Me.NumUpDownPTZSpeed.Name = "NumUpDownPTZSpeed"
        Me.NumUpDownPTZSpeed.Size = New System.Drawing.Size(61, 22)
        Me.NumUpDownPTZSpeed.TabIndex = 1
        '
        'BtnZoomIn
        '
        Me.BtnZoomIn.Location = New System.Drawing.Point(53, 311)
        Me.BtnZoomIn.Name = "BtnZoomIn"
        Me.BtnZoomIn.Size = New System.Drawing.Size(103, 51)
        Me.BtnZoomIn.TabIndex = 10
        Me.BtnZoomIn.Text = "+"
        Me.BtnZoomIn.UseVisualStyleBackColor = True
        '
        'BtnZoomReset
        '
        Me.BtnZoomReset.Location = New System.Drawing.Point(189, 311)
        Me.BtnZoomReset.Name = "BtnZoomReset"
        Me.BtnZoomReset.Size = New System.Drawing.Size(103, 51)
        Me.BtnZoomReset.TabIndex = 11
        Me.BtnZoomReset.Text = "Reset Zoom"
        Me.BtnZoomReset.UseVisualStyleBackColor = True
        '
        'BtnZoomDecrease
        '
        Me.BtnZoomDecrease.Location = New System.Drawing.Point(330, 311)
        Me.BtnZoomDecrease.Name = "BtnZoomDecrease"
        Me.BtnZoomDecrease.Size = New System.Drawing.Size(103, 51)
        Me.BtnZoomDecrease.TabIndex = 12
        Me.BtnZoomDecrease.Text = "-"
        Me.BtnZoomDecrease.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 418)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Preset:"
        '
        'NumUpDownPreset
        '
        Me.NumUpDownPreset.Location = New System.Drawing.Point(135, 419)
        Me.NumUpDownPreset.Maximum = New Decimal(New Integer() {254, 0, 0, 0})
        Me.NumUpDownPreset.Name = "NumUpDownPreset"
        Me.NumUpDownPreset.Size = New System.Drawing.Size(61, 22)
        Me.NumUpDownPreset.TabIndex = 1
        '
        'BtnSetPreset
        '
        Me.BtnSetPreset.Location = New System.Drawing.Point(218, 419)
        Me.BtnSetPreset.Name = "BtnSetPreset"
        Me.BtnSetPreset.Size = New System.Drawing.Size(63, 23)
        Me.BtnSetPreset.TabIndex = 14
        Me.BtnSetPreset.Text = "Set"
        Me.BtnSetPreset.UseVisualStyleBackColor = True
        '
        'BtnRemovePreset
        '
        Me.BtnRemovePreset.Location = New System.Drawing.Point(287, 419)
        Me.BtnRemovePreset.Name = "BtnRemovePreset"
        Me.BtnRemovePreset.Size = New System.Drawing.Size(63, 23)
        Me.BtnRemovePreset.TabIndex = 15
        Me.BtnRemovePreset.Text = "Delete"
        Me.BtnRemovePreset.UseVisualStyleBackColor = True
        '
        'BtnRunPreset
        '
        Me.BtnRunPreset.Location = New System.Drawing.Point(356, 419)
        Me.BtnRunPreset.Name = "BtnRunPreset"
        Me.BtnRunPreset.Size = New System.Drawing.Size(63, 23)
        Me.BtnRunPreset.TabIndex = 16
        Me.BtnRunPreset.Text = "Run"
        Me.BtnRunPreset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(475, 475)
        Me.Controls.Add(Me.BtnRunPreset)
        Me.Controls.Add(Me.BtnRemovePreset)
        Me.Controls.Add(Me.BtnSetPreset)
        Me.Controls.Add(Me.NumUpDownPreset)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnZoomDecrease)
        Me.Controls.Add(Me.BtnZoomReset)
        Me.Controls.Add(Me.BtnZoomIn)
        Me.Controls.Add(Me.NumUpDownPTZSpeed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLeftDown)
        Me.Controls.Add(Me.BtnRightDown)
        Me.Controls.Add(Me.BtnDown)
        Me.Controls.Add(Me.BtnLeft)
        Me.Controls.Add(Me.BtnRight)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.BtnLeftUp)
        Me.Controls.Add(Me.BtnRightUp)
        Me.Controls.Add(Me.BtnUp)
        Me.Name = "Form1"
        Me.Text = "Fernbedienung PTZ"
        CType(Me.NumUpDownPTZSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUpDownPreset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnUp As Button
    Friend WithEvents BtnRightUp As Button
    Friend WithEvents BtnLeftUp As Button
    Friend WithEvents BtnHome As Button
    Friend WithEvents BtnRight As Button
    Friend WithEvents BtnLeft As Button
    Friend WithEvents BtnDown As Button
    Friend WithEvents BtnRightDown As Button
    Friend WithEvents BtnLeftDown As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NumUpDownPTZSpeed As NumericUpDown
    Friend WithEvents BtnZoomIn As Button
    Friend WithEvents BtnZoomReset As Button
    Friend WithEvents BtnZoomDecrease As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents NumUpDownPreset As NumericUpDown
    Friend WithEvents BtnSetPreset As Button
    Friend WithEvents BtnRemovePreset As Button
    Friend WithEvents BtnRunPreset As Button
End Class
