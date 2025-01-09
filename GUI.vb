'Imports IT_Nachtsmann.Connection
Public Class GUI
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim AskDeviceIP As Object
        Dim Http As String = "http://"
        Dim GetTarget As String = "/ajaxcom"
        Dim Title, Prompt, [Default] As String

        Title = "Preparing Connection"
        Prompt = "Please enter the IP-Address of your PTZ vue 2k Camera"
        [Default] = ""

        AskDeviceIP = InputBox(Prompt, Title, [Default])
        Dim MissingIP = String.IsNullOrEmpty(AskDeviceIP) Or String.IsNullOrWhiteSpace(AskDeviceIP)

        If MissingIP Then
            Dim Debug As DialogResult = MessageBox.Show("Press Ok to restart the Application or Cancel to close the Application", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            If Debug = DialogResult.Cancel Then
                Close()
            Else
                Application.Restart()
            End If
        End If
        DeviceURL = Http & AskDeviceIP & GetTarget
    End Sub
    Dim StrCommand As String
    Dim DeviceURL

    Private Sub BtnUp_Click(sender As Object, e As EventArgs) Handles BtnUp.Click
        StrCommand = "up_start"
        CamControl(DeviceURL, StrCommand)
        BtnUp.Visible = False
        BtnStopUp.Visible = True
    End Sub
    Private Sub BtnStopUp_Click(sender As Object, e As EventArgs) Handles BtnStopUp.Click
        StrCommand = "up_stop"
        CamControl(DeviceURL, StrCommand)
        BtnStopUp.Visible = False
        BtnUp.Visible = True
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        StrCommand = "go_home"
        CamControl(DeviceURL, StrCommand)
    End Sub

    Private Sub BtnLeftUp_Click(sender As Object, e As EventArgs) Handles BtnLeftUp.Click
        StrCommand = "leftup_start"
        CamControl(DeviceURL, StrCommand)
        BtnLeftUp.Visible = False
        BtnStopLU.Visible = True
    End Sub

    Private Sub BtnStopLU_Click(sender As Object, e As EventArgs) Handles BtnStopLU.Click
        StrCommand = "leftup_stop"
        CamControl(DeviceURL, StrCommand)
        BtnStopLU.Visible = False
        BtnLeftUp.Visible = True
    End Sub

    Private Sub BtnLeft_Click(sender As Object, e As EventArgs) Handles BtnLeft.Click
        StrCommand = "left_start"
        CamControl(DeviceURL, StrCommand)
        BtnLeft.Visible = False
        BtnStopLeft.Visible = True
    End Sub

    Private Sub BtnStopLeft_Click(sender As Object, e As EventArgs) Handles BtnStopLeft.Click
        StrCommand = "left_stop"
        CamControl(DeviceURL, StrCommand)
        BtnStopLeft.Visible = False
        BtnLeft.Visible = True
    End Sub

    Private Sub BtnLeftDown_Click(sender As Object, e As EventArgs) Handles BtnLeftDown.Click
        StrCommand = "leftdown_start"
        CamControl(DeviceURL, StrCommand)
        BtnLeftDown.Visible = False
        BtnStopLD.Visible = True
    End Sub

    Private Sub BtnStopLD_Click(sender As Object, e As EventArgs) Handles BtnStopLD.Click
        StrCommand = "leftdown_stop"
        CamControl(DeviceURL, StrCommand)
        BtnStopLD.Visible = False
        BtnLeftDown.Visible = True
    End Sub

    Private Sub BtnDown_Click(sender As Object, e As EventArgs) Handles BtnDown.Click
        StrCommand = "down_start"
        CamControl(DeviceURL, StrCommand)
        BtnDown.Visible = False
        BtnStopDown.Visible = True
    End Sub

    Private Sub BtnStopDown_Click(sender As Object, e As EventArgs) Handles BtnStopDown.Click
        StrCommand = "down_stop"
        CamControl(DeviceURL, StrCommand)
        BtnStopDown.Visible = False
        BtnDown.Visible = True
    End Sub

    Private Sub BtnRightDown_Click(sender As Object, e As EventArgs) Handles BtnRightDown.Click
        StrCommand = "rightdown_start"
        CamControl(DeviceURL, StrCommand)
        BtnRightDown.Visible = False
        BtnStopRD.Visible = True
    End Sub

    Private Sub BtnStopRD_Click(sender As Object, e As EventArgs) Handles BtnStopRD.Click
        StrCommand = "rightdown_stop"
        CamControl(DeviceURL, StrCommand)
        BtnStopRD.Visible = False
        BtnRightDown.Visible = True
    End Sub

    Private Sub BtnRight_Click(sender As Object, e As EventArgs) Handles BtnRight.Click
        StrCommand = "right_start"
        CamControl(DeviceURL, StrCommand)
        BtnRight.Visible = False
        BtnStopRight.Visible = True
    End Sub

    Private Sub BtnStopRight_Click(sender As Object, e As EventArgs) Handles BtnStopRight.Click
        StrCommand = "right_stop"
        CamControl(DeviceURL, StrCommand)
        BtnStopRight.Visible = False
        BtnRight.Visible = True
    End Sub

    Private Sub BtnRightUp_Click(sender As Object, e As EventArgs) Handles BtnRightUp.Click
        StrCommand = "rightup_start"
        CamControl(DeviceURL, StrCommand)
        BtnRightUp.Visible = False
        BtnStopRU.Visible = True
    End Sub

    Private Sub BtnStopRU_Click(sender As Object, e As EventArgs) Handles BtnStopRU.Click
        StrCommand = "rightup_stop"
        CamControl(DeviceURL, StrCommand)
        BtnStopRU.Visible = False
        BtnRightUp.Visible = True
    End Sub

    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click
        MessageBox.Show("You have been successfully disconnected", "Program ends now", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Close()
    End Sub

    Private Sub BtnSetPreset_Click(sender As Object, e As EventArgs) Handles BtnSetPreset.Click
        StrCommand = "preset_set"
        PresetControl(DeviceURL, StrCommand)
        MessageBox.Show("Preset has been successfully saved on Number " & NumUpDownPreset.Value)
    End Sub

    Private Sub BtnRemovePreset_Click(sender As Object, e As EventArgs) Handles BtnRemovePreset.Click
        StrCommand = "preset_clean"
        PresetControl(DeviceURL, StrCommand)
        MessageBox.Show("Preset #" & NumUpDownPreset.Value & " has been successfully removed")
    End Sub

    Private Sub BtnSelectPreset_Click(sender As Object, e As EventArgs) Handles BtnSelectPreset.Click
        StrCommand = "preset_call"
        CamControl(DeviceURL, StrCommand)
        MessageBox.Show("Preset #" & NumUpDownPreset.Value & " successfully loaded!")
    End Sub

    Private Sub BtnZoomIn_Click(sender As Object, e As EventArgs) Handles BtnZoomIn.Click
        StrCommand = "zoomadd_start"
        CamControl(DeviceURL, StrCommand)
        BtnZoomIn.Visible = False
        BtnStopZoomIn.Visible = True
    End Sub

    Private Sub BtnStopZoomIn_Click(sender As Object, e As EventArgs) Handles BtnStopZoomIn.Click
        StrCommand = "zoomadd_stop"
        CamControl(DeviceURL, StrCommand)
        BtnStopZoomIn.Visible = False
        BtnZoomIn.Visible = True
    End Sub

    Private Sub BtnZoomDecrease_Click(sender As Object, e As EventArgs) Handles BtnZoomDecrease.Click
        StrCommand = "zoomdec_start"
        CamControl(DeviceURL, StrCommand)
        BtnZoomDecrease.Visible = False
        BtnStopZoomOut.Visible = True
    End Sub

    Private Sub BtnStopZoomOut_Click(sender As Object, e As EventArgs) Handles BtnStopZoomOut.Click
        StrCommand = "zoomdec_stop"
        CamControl(DeviceURL, StrCommand)
        BtnStopZoomOut.Visible = False
        BtnZoomDecrease.Visible = True
    End Sub
End Class
