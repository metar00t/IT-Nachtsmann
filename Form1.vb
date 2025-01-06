Public Class Form1
    Dim StrCommand As String
    Private Sub BtnUp_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnUp.MouseDown
        ' TODO: Bugfixing zur Ausführung
        StrCommand = "sh up_start.sh " + NumUpDownPTZSpeed.Value
        Shell("cmd.exe /c " & StrCommand)
    End Sub
    Private Sub BtnUp_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnUp.MouseUp
        StrCommand = "sh up_stop.sh " + NumUpDownPTZSpeed.Value
        Shell("cmd.exe /c " & StrCommand)
    End Sub
End Class
