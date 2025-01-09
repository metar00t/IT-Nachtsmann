Imports System.IO
Imports System.Net

Public Module Connection
    Public Sub CamControl(URL, CMD)
        Try
            Dim myReq As HttpWebRequest
            Dim myResp As HttpWebResponse
            Dim myReader As StreamReader
            myReq = HttpWebRequest.Create(URL)
            myReq.Method = "POST"
            myReq.ContentType = "application/x-www-form-urlencoded"
            myReq.Accept = "application/json"
            Dim myData As String = "szCmd=%7B%22SysCtrl%22%3A%7B%22PtzCtrl%22%3A%7B%22nChanel%22%3A0%2C%22szPtzCmd%22%3A%22" & CMD & "%22%2C%22byValue%22%3A" & GUI.NumUpDownPTZSpeed.Value & "%7D%7D%7D"
            myReq.GetRequestStream.Write(System.Text.Encoding.UTF8.GetBytes(myData), 0, System.Text.Encoding.UTF8.GetBytes(myData).Count)
            myResp = myReq.GetResponse
            myReader = New System.IO.StreamReader(myResp.GetResponseStream)
            MessageBox.Show(myReader.ReadToEnd, "Success")
        Catch ex As Exception
            MessageBox.Show("Invalid URL: Application will restart now", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Sub
    Public Sub PresetControl(URL, CMD)
        Try
            Dim myReq As HttpWebRequest
            Dim myResp As HttpWebResponse
            Dim myReader As StreamReader
            myReq = HttpWebRequest.Create(URL)
            myReq.Method = "POST"
            myReq.ContentType = "application/x-www-form-urlencoded"
            myReq.Accept = "application/json"
            Dim myData As String = "szCmd=%7B%22SysCtrl%22%3A%7B%22PtzCtrl%22%3A%7B%22nChanel%22%3A0%2C%22szPtzCmd%22%3A%22" & CMD & "%22%2C%22byValue%22%3A" & GUI.NumUpDownPreset.Value & "%7D%7D%7D"
            myReq.GetRequestStream.Write(System.Text.Encoding.UTF8.GetBytes(myData), 0, System.Text.Encoding.UTF8.GetBytes(myData).Count)
            myResp = myReq.GetResponse
            myReader = New System.IO.StreamReader(myResp.GetResponseStream)
            MessageBox.Show(myReader.ReadToEnd, "Success")
        Catch ex As Exception
            MessageBox.Show("Invalid URL: Application will restart now", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Sub
End Module
