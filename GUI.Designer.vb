<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI))
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
        Me.BtnZoomDecrease = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumUpDownPreset = New System.Windows.Forms.NumericUpDown()
        Me.BtnSetPreset = New System.Windows.Forms.Button()
        Me.BtnRemovePreset = New System.Windows.Forms.Button()
        Me.BtnSelectPreset = New System.Windows.Forms.Button()
        Me.BtnStopLD = New System.Windows.Forms.Button()
        Me.BtnStopRD = New System.Windows.Forms.Button()
        Me.BtnStopDown = New System.Windows.Forms.Button()
        Me.BtnStopLeft = New System.Windows.Forms.Button()
        Me.BtnStopRight = New System.Windows.Forms.Button()
        Me.BtnStopLU = New System.Windows.Forms.Button()
        Me.BtnStopRU = New System.Windows.Forms.Button()
        Me.BtnStopUp = New System.Windows.Forms.Button()
        Me.BtnEnd = New System.Windows.Forms.Button()
        Me.BtnStopZoomIn = New System.Windows.Forms.Button()
        Me.BtnStopZoomOut = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.BtnZoomIn.Image = CType(resources.GetObject("BtnZoomIn.Image"), System.Drawing.Image)
        Me.BtnZoomIn.Location = New System.Drawing.Point(53, 280)
        Me.BtnZoomIn.Name = "BtnZoomIn"
        Me.BtnZoomIn.Size = New System.Drawing.Size(130, 112)
        Me.BtnZoomIn.TabIndex = 10
        Me.BtnZoomIn.UseVisualStyleBackColor = True
        '
        'BtnZoomDecrease
        '
        Me.BtnZoomDecrease.Image = CType(resources.GetObject("BtnZoomDecrease.Image"), System.Drawing.Image)
        Me.BtnZoomDecrease.Location = New System.Drawing.Point(277, 280)
        Me.BtnZoomDecrease.Name = "BtnZoomDecrease"
        Me.BtnZoomDecrease.Size = New System.Drawing.Size(130, 112)
        Me.BtnZoomDecrease.TabIndex = 12
        Me.BtnZoomDecrease.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 418)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Preset:"
        '
        'NumUpDownPreset
        '
        Me.NumUpDownPreset.Location = New System.Drawing.Point(109, 419)
        Me.NumUpDownPreset.Maximum = New Decimal(New Integer() {254, 0, 0, 0})
        Me.NumUpDownPreset.Name = "NumUpDownPreset"
        Me.NumUpDownPreset.Size = New System.Drawing.Size(61, 22)
        Me.NumUpDownPreset.TabIndex = 1
        '
        'BtnSetPreset
        '
        Me.BtnSetPreset.Location = New System.Drawing.Point(193, 398)
        Me.BtnSetPreset.Name = "BtnSetPreset"
        Me.BtnSetPreset.Size = New System.Drawing.Size(78, 28)
        Me.BtnSetPreset.TabIndex = 14
        Me.BtnSetPreset.Text = "Set Preset"
        Me.BtnSetPreset.UseVisualStyleBackColor = True
        '
        'BtnRemovePreset
        '
        Me.BtnRemovePreset.Location = New System.Drawing.Point(179, 432)
        Me.BtnRemovePreset.Name = "BtnRemovePreset"
        Me.BtnRemovePreset.Size = New System.Drawing.Size(92, 28)
        Me.BtnRemovePreset.TabIndex = 15
        Me.BtnRemovePreset.Text = "Clear Preset"
        Me.BtnRemovePreset.UseVisualStyleBackColor = True
        '
        'BtnSelectPreset
        '
        Me.BtnSelectPreset.Location = New System.Drawing.Point(277, 398)
        Me.BtnSelectPreset.Name = "BtnSelectPreset"
        Me.BtnSelectPreset.Size = New System.Drawing.Size(87, 62)
        Me.BtnSelectPreset.TabIndex = 16
        Me.BtnSelectPreset.Text = "Select Preset"
        Me.BtnSelectPreset.UseVisualStyleBackColor = True
        '
        'BtnStopLD
        '
        Me.BtnStopLD.Location = New System.Drawing.Point(53, 165)
        Me.BtnStopLD.Name = "BtnStopLD"
        Me.BtnStopLD.Size = New System.Drawing.Size(103, 50)
        Me.BtnStopLD.TabIndex = 25
        Me.BtnStopLD.Text = "Stop"
        Me.BtnStopLD.UseVisualStyleBackColor = True
        Me.BtnStopLD.Visible = False
        '
        'BtnStopRD
        '
        Me.BtnStopRD.Location = New System.Drawing.Point(330, 165)
        Me.BtnStopRD.Name = "BtnStopRD"
        Me.BtnStopRD.Size = New System.Drawing.Size(103, 50)
        Me.BtnStopRD.TabIndex = 24
        Me.BtnStopRD.Text = "Stop"
        Me.BtnStopRD.UseVisualStyleBackColor = True
        Me.BtnStopRD.Visible = False
        '
        'BtnStopDown
        '
        Me.BtnStopDown.Location = New System.Drawing.Point(189, 165)
        Me.BtnStopDown.Name = "BtnStopDown"
        Me.BtnStopDown.Size = New System.Drawing.Size(103, 50)
        Me.BtnStopDown.TabIndex = 23
        Me.BtnStopDown.Text = "Stop"
        Me.BtnStopDown.UseVisualStyleBackColor = True
        Me.BtnStopDown.Visible = False
        '
        'BtnStopLeft
        '
        Me.BtnStopLeft.Location = New System.Drawing.Point(53, 101)
        Me.BtnStopLeft.Name = "BtnStopLeft"
        Me.BtnStopLeft.Size = New System.Drawing.Size(103, 50)
        Me.BtnStopLeft.TabIndex = 22
        Me.BtnStopLeft.Text = "Stop"
        Me.BtnStopLeft.UseVisualStyleBackColor = True
        Me.BtnStopLeft.Visible = False
        '
        'BtnStopRight
        '
        Me.BtnStopRight.Location = New System.Drawing.Point(330, 101)
        Me.BtnStopRight.Name = "BtnStopRight"
        Me.BtnStopRight.Size = New System.Drawing.Size(103, 50)
        Me.BtnStopRight.TabIndex = 21
        Me.BtnStopRight.Text = "Stop"
        Me.BtnStopRight.UseVisualStyleBackColor = True
        Me.BtnStopRight.Visible = False
        '
        'BtnStopLU
        '
        Me.BtnStopLU.Location = New System.Drawing.Point(53, 40)
        Me.BtnStopLU.Name = "BtnStopLU"
        Me.BtnStopLU.Size = New System.Drawing.Size(103, 50)
        Me.BtnStopLU.TabIndex = 19
        Me.BtnStopLU.Text = "Stop"
        Me.BtnStopLU.UseVisualStyleBackColor = True
        Me.BtnStopLU.Visible = False
        '
        'BtnStopRU
        '
        Me.BtnStopRU.Location = New System.Drawing.Point(330, 40)
        Me.BtnStopRU.Name = "BtnStopRU"
        Me.BtnStopRU.Size = New System.Drawing.Size(103, 50)
        Me.BtnStopRU.TabIndex = 18
        Me.BtnStopRU.Text = "Stop"
        Me.BtnStopRU.UseVisualStyleBackColor = True
        Me.BtnStopRU.Visible = False
        '
        'BtnStopUp
        '
        Me.BtnStopUp.Location = New System.Drawing.Point(189, 40)
        Me.BtnStopUp.Name = "BtnStopUp"
        Me.BtnStopUp.Size = New System.Drawing.Size(103, 50)
        Me.BtnStopUp.TabIndex = 17
        Me.BtnStopUp.Text = "Stop"
        Me.BtnStopUp.UseVisualStyleBackColor = True
        Me.BtnStopUp.Visible = False
        '
        'BtnEnd
        '
        Me.BtnEnd.Location = New System.Drawing.Point(370, 398)
        Me.BtnEnd.Name = "BtnEnd"
        Me.BtnEnd.Size = New System.Drawing.Size(87, 62)
        Me.BtnEnd.TabIndex = 26
        Me.BtnEnd.Text = "Shutdown"
        Me.BtnEnd.UseVisualStyleBackColor = True
        '
        'BtnStopZoomIn
        '
        Me.BtnStopZoomIn.Location = New System.Drawing.Point(53, 280)
        Me.BtnStopZoomIn.Name = "BtnStopZoomIn"
        Me.BtnStopZoomIn.Size = New System.Drawing.Size(130, 112)
        Me.BtnStopZoomIn.TabIndex = 27
        Me.BtnStopZoomIn.Text = "Stop"
        Me.BtnStopZoomIn.UseVisualStyleBackColor = True
        Me.BtnStopZoomIn.Visible = False
        '
        'BtnStopZoomOut
        '
        Me.BtnStopZoomOut.Location = New System.Drawing.Point(277, 280)
        Me.BtnStopZoomOut.Name = "BtnStopZoomOut"
        Me.BtnStopZoomOut.Size = New System.Drawing.Size(130, 112)
        Me.BtnStopZoomOut.TabIndex = 28
        Me.BtnStopZoomOut.Text = "Stop"
        Me.BtnStopZoomOut.UseVisualStyleBackColor = True
        Me.BtnStopZoomOut.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(186, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "<--- Zoom In"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 355)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Zoom Out --->"
        '
        'GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(475, 475)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnStopZoomOut)
        Me.Controls.Add(Me.BtnStopZoomIn)
        Me.Controls.Add(Me.BtnEnd)
        Me.Controls.Add(Me.BtnStopLD)
        Me.Controls.Add(Me.BtnStopRD)
        Me.Controls.Add(Me.BtnStopDown)
        Me.Controls.Add(Me.BtnStopLeft)
        Me.Controls.Add(Me.BtnStopRight)
        Me.Controls.Add(Me.BtnStopLU)
        Me.Controls.Add(Me.BtnStopRU)
        Me.Controls.Add(Me.BtnStopUp)
        Me.Controls.Add(Me.BtnSelectPreset)
        Me.Controls.Add(Me.BtnRemovePreset)
        Me.Controls.Add(Me.BtnSetPreset)
        Me.Controls.Add(Me.NumUpDownPreset)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnZoomDecrease)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GUI"
        Me.Text = "PTZ Remote Control"
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
    Friend WithEvents BtnZoomDecrease As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents NumUpDownPreset As NumericUpDown
    Friend WithEvents BtnSetPreset As Button
    Friend WithEvents BtnRemovePreset As Button
    Friend WithEvents BtnSelectPreset As Button
    Friend WithEvents BtnStopLD As Button
    Friend WithEvents BtnStopRD As Button
    Friend WithEvents BtnStopDown As Button
    Friend WithEvents BtnStopLeft As Button
    Friend WithEvents BtnStopRight As Button
    Friend WithEvents BtnStopLU As Button
    Friend WithEvents BtnStopRU As Button
    Friend WithEvents BtnStopUp As Button
    Friend WithEvents BtnEnd As Button
    Friend WithEvents BtnStopZoomIn As Button
    Friend WithEvents BtnStopZoomOut As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
