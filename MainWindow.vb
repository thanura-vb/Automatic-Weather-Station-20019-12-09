Imports System.Linq
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Public Class MainWindow
    'Dim StrParse, TEMP_1, AP_2, MSLAP, HUM, ALT, LAT, LNG, GPS_GRND_ALT, STE, SAP, SHU, SBA, SLT, SLN, SGPSAT, SCS, SSD As String
    'Dim TEMP_1L, AP_2L, MSLAP_3L, HUM_4L, ALT_5L, LAT_6L, LNG_7L, GPS_GRND_ALT_8L, STE_9L, SAP_10L, SHU_11L, SBA_12L, SLT_13L, SLN_14L,
    '    SGPSAT_15L, SCS_16L, SSD_17L As Integer
    'Dim Limit As Integer = 10
    Dim FilePathAndName As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ButtonDisconnect.Enabled = False
        ButtonConnect.Enabled = False
        ButtonStartRecording.Enabled = False
        ButtonStopRecording.Enabled = False
        ComboBoxBaudRate.SelectedIndex = 3
        ButtonSaveToMSExcel.Height = 50
        SaveToMSExcelToolStripMenuItem.Enabled = False
    End Sub
    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i
        Try
            ComboBoxPort.SelectedIndex = i
            ButtonConnect.Enabled = True
        Catch ex As Exception
            MsgBox("Com port not detected", MsgBoxStyle.Critical, "Warning !!!")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            ButtonConnect.Enabled = False
            ButtonStartRecording.Enabled = False
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        SerialPort1.BaudRate = ComboBoxBaudRate.SelectedItem
        SerialPort1.PortName = ComboBoxPort.SelectedItem
        SerialPort1.Open()
        TimerSerial.Start()

        ComboBoxPort.Enabled = False
        Label1.Enabled = False
        ComboBoxBaudRate.Enabled = False
        ButtonScanPort.Enabled = False
        ButtonConnect.Enabled = False
        ButtonDisconnect.Enabled = True
        ButtonStartRecording.Enabled = True

        PictureBoxConnectionInd.Image = My.Resources.Greenflg
        LabelStatus.Text = "Status : Connected"
    End Sub
    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        PictureBoxConnectionInd.Image = My.Resources.Redflg1
        PictureBoxConnectionInd.Visible = True
        LabelStatus.Text = "Status : Disconnected"

        ComboBoxPort.Enabled = True
        Label1.Enabled = True
        ComboBoxBaudRate.Enabled = True
        ButtonScanPort.Enabled = True
        ButtonConnect.Enabled = True
        ButtonDisconnect.Enabled = False

        TimerSerial.Stop()
        TimerDataLogRecord.Stop()

        ButtonSaveToMSExcel.Enabled = True
        ButtonStopRecording.Enabled = False

        SerialPort1.Close()

        '---------------------
        TextBox1.Text = ""    'Temp-----|
        TextBox2.Text = ""    'Ap       |
        TextBox3.Text = ""    'HUM      |
        TextBox4.Text = ""    'BAlt     | 
        TextBox16.Text = ""   'Lat      |
        TextBox17.Text = ""   'Lng      | SPACE SEGMENT
        TextBox5.Text = ""    'GPS Alt  |
        TextBox6.Text = ""    'WD       |
        TextBox7.Text = ""    'WV-------|
        '----------------------

        '---------------------
        TextBox8.Text = ""    'Temp-----|
        TextBox9.Text = ""    'Ap       |
        TextBox10.Text = ""   'MSL      |
        TextBox11.Text = ""   'HUM      | GROUND SEGMENT
        TextBox12.Text = ""   'ALt      |
        TextBox13.Text = ""   'Lat      |
        TextBox14.Text = ""   'Lng      |
        TextBox15.Text = ""   'GPS Alt--|
        '----------------------


    End Sub
    Private Sub ButtonStartRecording_Click(sender As Object, e As EventArgs) Handles ButtonStartRecording.Click
        ButtonStartRecording.Enabled = False
        ButtonStopRecording.Enabled = True
        ButtonSaveToMSExcel.Enabled = False
        TimerDataLogRecord.Start()
        SaveToMSExcelToolStripMenuItem.Enabled = False
    End Sub
    Private Sub ButtonStopRecording_Click(sender As Object, e As EventArgs) Handles ButtonStopRecording.Click
        ButtonStartRecording.Enabled = True
        ButtonStopRecording.Enabled = False
        ButtonSaveToMSExcel.Enabled = True
        TimerDataLogRecord.Stop()
        PictureBoxRecordInd.Visible = True
        SaveToMSExcelToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        DataGridView1.Rows.Clear()
    End Sub
    Private Sub ButtonSaveToExcel_Click(sender As Object, e As EventArgs) Handles ButtonSaveToMSExcel.Click
        ButtonSaveToMSExcel.Height = 37
        ButtonSaveToMSExcel.Text = "Please Wait..."
        ButtonSaveToMSExcel.Enabled = False
        ButtonStartRecording.Enabled = False
        ProgressBarProcess.Visible = True
        ProgressBarProcess.Value = 1

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        ProgressBarProcess.Value = 3

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        ProgressBarProcess.Value = 5

        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next

        ProgressBarProcess.Value = 8

        FilePathAndName = Application.StartupPath & "\" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xlsx"
        If File.Exists(FilePathAndName) Then File.Delete(FilePathAndName)

        xlWorkSheet.SaveAs(FilePathAndName)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        ProgressBarProcess.Value = 10

        MsgBox("Successfully saved" & vbCrLf & "File are saved at : " & FilePathAndName, MsgBoxStyle.Information, "Information")

        ProgressBarProcess.Visible = False

        Process.Start(FilePathAndName)

        ButtonSaveToMSExcel.Height = 50
        ButtonSaveToMSExcel.Text = "Save To MS Excel"
        ButtonSaveToMSExcel.Enabled = True
        ButtonStartRecording.Enabled = True
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub TimerDataLogRecord_Tick(sender As Object, e As EventArgs) Handles TimerDataLogRecord.Tick
        Try
            'Dim TEMP_1Log, AP_2Log, MSLAPLog, ALTLog, HUMLog, LATLog, LNGLog, GPS_GRND_ALT_Log, STE_Log, SAP_Log,
            'SHU_Log, SBA_Log, SLT_Log, SLN_Log, SGPSAT_Log, SCS_Log, SSD_Log As String
            Dim DT As DateTime = Now

            TEMP_1Log = Mid(TEMP_1, 3, TEMP_1L)
            AP_2Log = Mid(AP_2, 3, AP_2L)
            MSLAPLog = Mid(MSLAP, 3, MSLAP_3L)
            HUMLog = Mid(HUM, 3, HUM_4L)
            ALTLog = Mid(ALT, 3, ALT_5L)
            LATLog = Mid(LAT, 3, LAT_6L)
            LNGLog = Mid(LNG, 3, LNG_7L)
            GPS_GRND_ALT_Log = Mid(GPS_GRND_ALT, 3, GPS_GRND_ALT_8L)
            STE_Log = Mid(STE, 3, STE_9L)
            SAP_Log = Mid(SAP, 3, SAP_10L)
            SHU_Log = Mid(SHU, 3, SHU_11L)
            SBA_Log = Mid(SBA, 3, SBA_12L)
            SLT_Log = Mid(SLT, 3, SLT_13L)
            SLN_Log = Mid(SLN, 3, SLN_14L)
            SGPSAT_Log = Mid(SGPSAT, 3, SGPSAT_15L)
            SCS_Log = Mid(SCS, 3, SCS_16L)
            If SCS_Log > 360 Or SCS_Log < 0 Then
                SCS_Log = Convert.ToString(0)
            Else
                SCS_Log = SCS_Log
            End If
            SSD_Log = Mid(SSD, 3, SSD_17L)

            DataGridView1.Rows.Add(New String() {DataGridView1.RowCount, DT.ToLongTimeString, DT.ToString("dd-MM-yyyy"),
            ALTLog, TEMP_1Log, AP_2Log, MSLAPLog, HUMLog, STE_Log, SAP_Log, SHU_Log, SBA_Log, SLT_Log, SLN_Log, SGPSAT_Log, SCS_Log, SSD_Log})
            Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1

        Catch ex As Exception
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub TimerSerial_Tick(sender As Object, e As EventArgs) Handles TimerSerial.Tick
        Try
            Dim StrSerialIn As String = SerialPort1.ReadExisting
            Dim StrSerialInRam As String
            Dim CourseCorrection As String
            Dim TB As New TextBox
            TB.Multiline = True
            TB.Text = StrSerialIn

            StrSerialInRam = TB.Lines(0).Substring(0, 2)
            If StrSerialInRam = "TE" Then
                TEMP_1 = TB.Lines(0)
                TEMP_1L = TEMP_1.Length
            Else
                TEMP_1 = TEMP_1
            End If

            StrSerialInRam = TB.Lines(1).Substring(0, 2)
            If StrSerialInRam = "AP" Then
                AP_2 = TB.Lines(1)
                AP_2L = AP_2.Length
            Else
                AP_2 = AP_2
            End If

            StrSerialInRam = TB.Lines(2).Substring(0, 2)
            If StrSerialInRam = "MS" Then
                MSLAP = TB.Lines(2)
                MSLAP_3L = MSLAP.Length
            Else
                MSLAP = MSLAP
            End If

            StrSerialInRam = TB.Lines(3).Substring(0, 2)
            If StrSerialInRam = "HU" Then
                HUM = TB.Lines(3)
                HUM_4L = HUM.Length
            Else
                HUM = HUM
            End If

            StrSerialInRam = TB.Lines(4).Substring(0, 2)
            If StrSerialInRam = "AL" Then
                ALT = TB.Lines(4)
                ALT_5L = ALT.Length
            Else
                ALT = ALT
            End If

            StrSerialInRam = TB.Lines(5).Substring(0, 2)
            If StrSerialInRam = "LT" Then
                LAT = TB.Lines(5)
                LAT_6L = LAT.Length
            Else
                LAT = LAT
            End If

            StrSerialInRam = TB.Lines(6).Substring(0, 2)
            If StrSerialInRam = "LN" Then
                LNG = TB.Lines(6)
                LNG_7L = LAT.Length
            Else
                LNG = LNG
            End If

            StrSerialInRam = TB.Lines(7).Substring(0, 2)
            If StrSerialInRam = "AT" Then
                GPS_GRND_ALT = TB.Lines(7)
                GPS_GRND_ALT_8L = LAT.Length
            Else
                GPS_GRND_ALT = GPS_GRND_ALT
            End If

            StrSerialInRam = TB.Lines(8).Substring(0, 2)
            If StrSerialInRam = "ST" Then
                STE = TB.Lines(8)
                STE_9L = STE.Length
            Else
                STE = STE
            End If

            StrSerialInRam = TB.Lines(9).Substring(0, 2)
            If StrSerialInRam = "SA" Then
                SAP = TB.Lines(9)
                SAP_10L = SAP.Length
            Else
                SAP = SAP
            End If

            StrSerialInRam = TB.Lines(10).Substring(0, 2)
            If StrSerialInRam = "SH" Then
                SHU = TB.Lines(10)
                SHU_11L = SHU.Length
            Else
                SHU = SHU
            End If

            StrSerialInRam = TB.Lines(11).Substring(0, 2)
            If StrSerialInRam = "SB" Then
                SBA = TB.Lines(11)
                SBA_12L = SBA.Length
            Else
                SBA = SBA
            End If

            StrSerialInRam = TB.Lines(12).Substring(0, 2)
            If StrSerialInRam = "SL" Then
                SLT = TB.Lines(12)
                SLT_13L = SLT.Length
            Else
                SLT = SLT
            End If

            StrSerialInRam = TB.Lines(13).Substring(0, 2)
            If StrSerialInRam = "SG" Then
                SLN = TB.Lines(13)
                SLN_14L = SLT.Length
            Else
                SLN = SLN
            End If

            StrSerialInRam = TB.Lines(14).Substring(0, 2)
            If StrSerialInRam = "SP" Then
                SGPSAT = TB.Lines(14)
                SGPSAT_15L = SGPSAT.Length
            Else
                SGPSAT = SGPSAT
            End If

            StrSerialInRam = TB.Lines(15).Substring(0, 2)
            If StrSerialInRam = "SC" Then
                SCS = TB.Lines(15)
                SCS_16L = SCS.Length
            Else
                SCS = SCS
            End If

            StrSerialInRam = TB.Lines(16).Substring(0, 2)
            If StrSerialInRam = "SD" Then
                SSD = TB.Lines(16)
                SSD_17L = SSD.Length
            Else
                SSD = SSD
            End If



            If PictureBoxConnectionInd.Visible = True Then
                PictureBoxConnectionInd.Visible = False
            ElseIf PictureBoxConnectionInd.Visible = False Then
                PictureBoxConnectionInd.Visible = True
            End If

            LabelTemperature.Text = "Temperature: "
            LabelAirPressure.Text = "Air Pressure: "
            LabelMSLAirPressure.Text = "Mean Sea Level Pressure: "
            LabelHumidity.Text = "Humidity: "
            LabelAltitude.Text = "Altitude: "
            LabelGroundLat.Text = "Latitude: "
            LabelGroundLng.Text = "Longitude: "
            LabelGroundAlt.Text = "GPS Altitude: "





            TextBox1.Text = Mid(STE, 3, STE_9L)
            TextBox2.Text = Mid(SAP, 3, SAP_10L)
            TextBox3.Text = Mid(SHU, 3, SHU_11L)
            TextBox4.Text = Mid(SBA, 3, SBA_12L)
            TextBox16.Text = Mid(SLT, 3, SLT_13L)
            TextBox17.Text = Mid(SLN, 3, SLN_14L)
            TextBox5.Text = Mid(SGPSAT, 3, SGPSAT_15L)
            CourseCorrection = Mid(SCS, 3, SCS_16L)

            If CourseCorrection > 360 Or CourseCorrection < 0 Then
                CourseCorrection = Convert.ToString(0)
            Else
                CourseCorrection = CourseCorrection
                TextBox6.Text = Convert.ToString(CourseCorrection)
            End If

            TextBox7.Text = Mid(SSD, 3, SSD_17L)
            TextBox8.Text = Mid(TEMP_1, 3, TEMP_1L)
            TextBox9.Text = Mid(AP_2, 3, AP_2L)
            TextBox10.Text = Mid(MSLAP, 3, MSLAP_3L)
            TextBox11.Text = Mid(HUM, 3, HUM_4L)
            TextBox12.Text = Mid(ALT, 3, ALT_5L)
            TextBox13.Text = Mid(LAT, 3, LAT_6L)
            TextBox14.Text = Mid(LNG, 3, LNG_7L)
            TextBox15.Text = Mid(GPS_GRND_ALT, 3, GPS_GRND_ALT_8L)

        Catch ex As Exception
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub StationPTUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StationPTUToolStripMenuItem.Click
        StationPTUGraph.Show()
    End Sub

    Private Sub SondePTUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SondePTUToolStripMenuItem.Click
        SondePTUGraph.Show()
    End Sub

    Private Sub SondeTrackingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SondeTrackingToolStripMenuItem.Click
        SondeFlightPath.Show()
    End Sub

    Private Sub TemperatureAndHumidityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemperatureAndHumidityToolStripMenuItem.Click
        TemperatureGraph.Show()
    End Sub

    Private Sub SaveToMSExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToMSExcelToolStripMenuItem.Click
        ButtonSaveToMSExcel.Height = 37
        ButtonSaveToMSExcel.Text = "Please Wait..."
        ButtonSaveToMSExcel.Enabled = False
        ButtonStartRecording.Enabled = False
        ProgressBarProcess.Visible = True
        ProgressBarProcess.Value = 1

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        ProgressBarProcess.Value = 3

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        ProgressBarProcess.Value = 5

        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next

        ProgressBarProcess.Value = 8

        FilePathAndName = Application.StartupPath & "\" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xlsx"
        If File.Exists(FilePathAndName) Then File.Delete(FilePathAndName)

        xlWorkSheet.SaveAs(FilePathAndName)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        ProgressBarProcess.Value = 10

        MsgBox("Successfully saved" & vbCrLf & "File are saved at : " & FilePathAndName, MsgBoxStyle.Information, "Information")

        ProgressBarProcess.Visible = False

        Process.Start(FilePathAndName)

        ButtonSaveToMSExcel.Height = 50
        ButtonSaveToMSExcel.Text = "Save To MS Excel"
        ButtonSaveToMSExcel.Enabled = True
        ButtonStartRecording.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GMapTrackingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GMapTrackingToolStripMenuItem.Click
        GMapTracking.Show()
    End Sub
End Class
