<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ButtonDisconnect = New System.Windows.Forms.Button()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelMSLAirPressure = New System.Windows.Forms.Label()
        Me.LabelAirPressure = New System.Windows.Forms.Label()
        Me.LabelTemperature = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.LabelGroundAlt = New System.Windows.Forms.Label()
        Me.LabelGroundLng = New System.Windows.Forms.Label()
        Me.LabelGroundLat = New System.Windows.Forms.Label()
        Me.LabelAltitude = New System.Windows.Forms.Label()
        Me.LabelHumidity = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxRecordInd = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonStopRecording = New System.Windows.Forms.Button()
        Me.ButtonStartRecording = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ButtonSaveToMSExcel = New System.Windows.Forms.Button()
        Me.ProgressBarProcess = New System.Windows.Forms.ProgressBar()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Altitude = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Temperature = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AirPressure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MSLAirPressure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Humidity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SONDETE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SONDEAP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SONDEHUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SONDEBAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SONDELAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SONDELNG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SONDEGPSAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SONDECOURSE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SONDESPEED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerDataLogRecord = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.LabelSondeLong = New System.Windows.Forms.Label()
        Me.LabelSondeLat = New System.Windows.Forms.Label()
        Me.LabelSpeed = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.LabelWindDirection = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.LabelGPSAlt = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LableSondeBMAL = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LableSondeHumidity = New System.Windows.Forms.Label()
        Me.LabelSondeTemperature = New System.Windows.Forms.Label()
        Me.LabelSondeAP = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToMSExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraphsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StationPTUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemperatureAndHumidityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SondePTUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SondeTrackingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GPSSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SondeSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiagnosticToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RawDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBoxConnectionInd = New System.Windows.Forms.PictureBox()
        Me.GMapTrackingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBoxRecordInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBoxConnectionInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LabelStatus)
        Me.GroupBox1.Controls.Add(Me.ButtonDisconnect)
        Me.GroupBox1.Controls.Add(Me.ButtonConnect)
        Me.GroupBox1.Controls.Add(Me.ComboBoxBaudRate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPort)
        Me.GroupBox1.Controls.Add(Me.ButtonScanPort)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 37)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(359, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection"
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(171, -1)
        Me.LabelStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(153, 18)
        Me.LabelStatus.TabIndex = 1
        Me.LabelStatus.Text = "Status : Disconnected"
        '
        'ButtonDisconnect
        '
        Me.ButtonDisconnect.Location = New System.Drawing.Point(184, 62)
        Me.ButtonDisconnect.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDisconnect.Name = "ButtonDisconnect"
        Me.ButtonDisconnect.Size = New System.Drawing.Size(168, 34)
        Me.ButtonDisconnect.TabIndex = 1
        Me.ButtonDisconnect.Text = "Disconnect"
        Me.ButtonDisconnect.UseVisualStyleBackColor = True
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(6, 62)
        Me.ButtonConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(159, 34)
        Me.ButtonConnect.TabIndex = 1
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(271, 28)
        Me.ComboBoxBaudRate.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(80, 26)
        Me.ComboBoxBaudRate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Baud Rate"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(102, 26)
        Me.ComboBoxPort.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(64, 26)
        Me.ComboBoxPort.TabIndex = 1
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.Location = New System.Drawing.Point(6, 23)
        Me.ButtonScanPort.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(87, 31)
        Me.ButtonScanPort.TabIndex = 1
        Me.ButtonScanPort.Text = "Scan Port"
        Me.ButtonScanPort.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.LabelMSLAirPressure)
        Me.GroupBox2.Controls.Add(Me.LabelAirPressure)
        Me.GroupBox2.Controls.Add(Me.LabelTemperature)
        Me.GroupBox2.Controls.Add(Me.TextBox15)
        Me.GroupBox2.Controls.Add(Me.TextBox14)
        Me.GroupBox2.Controls.Add(Me.TextBox13)
        Me.GroupBox2.Controls.Add(Me.TextBox12)
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.LabelGroundAlt)
        Me.GroupBox2.Controls.Add(Me.LabelGroundLng)
        Me.GroupBox2.Controls.Add(Me.LabelGroundLat)
        Me.GroupBox2.Controls.Add(Me.LabelAltitude)
        Me.GroupBox2.Controls.Add(Me.LabelHumidity)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(469, 40)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(335, 376)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Incoming Data (Ground Segment)"
        '
        'LabelMSLAirPressure
        '
        Me.LabelMSLAirPressure.AutoSize = True
        Me.LabelMSLAirPressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMSLAirPressure.ForeColor = System.Drawing.Color.Black
        Me.LabelMSLAirPressure.Location = New System.Drawing.Point(18, 112)
        Me.LabelMSLAirPressure.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMSLAirPressure.Name = "LabelMSLAirPressure"
        Me.LabelMSLAirPressure.Size = New System.Drawing.Size(205, 18)
        Me.LabelMSLAirPressure.TabIndex = 3
        Me.LabelMSLAirPressure.Text = "Mean Sea Level Pressure:"
        '
        'LabelAirPressure
        '
        Me.LabelAirPressure.AutoSize = True
        Me.LabelAirPressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAirPressure.ForeColor = System.Drawing.Color.Black
        Me.LabelAirPressure.Location = New System.Drawing.Point(18, 73)
        Me.LabelAirPressure.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAirPressure.Name = "LabelAirPressure"
        Me.LabelAirPressure.Size = New System.Drawing.Size(106, 18)
        Me.LabelAirPressure.TabIndex = 3
        Me.LabelAirPressure.Text = "Air Pressure:"
        '
        'LabelTemperature
        '
        Me.LabelTemperature.AutoSize = True
        Me.LabelTemperature.BackColor = System.Drawing.Color.Transparent
        Me.LabelTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTemperature.ForeColor = System.Drawing.Color.Black
        Me.LabelTemperature.Location = New System.Drawing.Point(18, 34)
        Me.LabelTemperature.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTemperature.Name = "LabelTemperature"
        Me.LabelTemperature.Size = New System.Drawing.Size(108, 18)
        Me.LabelTemperature.TabIndex = 3
        Me.LabelTemperature.Text = "Temperature:"
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.Color.Black
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.ForeColor = System.Drawing.Color.Lime
        Me.TextBox15.Location = New System.Drawing.Point(242, 306)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(73, 24)
        Me.TextBox15.TabIndex = 21
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.Black
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.ForeColor = System.Drawing.Color.Lime
        Me.TextBox14.Location = New System.Drawing.Point(242, 266)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(73, 24)
        Me.TextBox14.TabIndex = 20
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.Black
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.ForeColor = System.Drawing.Color.Lime
        Me.TextBox13.Location = New System.Drawing.Point(242, 226)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(73, 24)
        Me.TextBox13.TabIndex = 19
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.Black
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.ForeColor = System.Drawing.Color.Lime
        Me.TextBox12.Location = New System.Drawing.Point(242, 186)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(73, 24)
        Me.TextBox12.TabIndex = 18
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.Black
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.ForeColor = System.Drawing.Color.Lime
        Me.TextBox11.Location = New System.Drawing.Point(242, 147)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(73, 24)
        Me.TextBox11.TabIndex = 17
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.Black
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.ForeColor = System.Drawing.Color.Lime
        Me.TextBox10.Location = New System.Drawing.Point(242, 108)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(73, 24)
        Me.TextBox10.TabIndex = 16
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.Black
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.ForeColor = System.Drawing.Color.Lime
        Me.TextBox9.Location = New System.Drawing.Point(242, 69)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(73, 24)
        Me.TextBox9.TabIndex = 15
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Black
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.Lime
        Me.TextBox8.Location = New System.Drawing.Point(242, 30)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(73, 24)
        Me.TextBox8.TabIndex = 14
        '
        'LabelGroundAlt
        '
        Me.LabelGroundAlt.AutoSize = True
        Me.LabelGroundAlt.Location = New System.Drawing.Point(18, 309)
        Me.LabelGroundAlt.Name = "LabelGroundAlt"
        Me.LabelGroundAlt.Size = New System.Drawing.Size(108, 18)
        Me.LabelGroundAlt.TabIndex = 11
        Me.LabelGroundAlt.Text = "GPS Altitude:"
        '
        'LabelGroundLng
        '
        Me.LabelGroundLng.AutoSize = True
        Me.LabelGroundLng.Location = New System.Drawing.Point(18, 269)
        Me.LabelGroundLng.Name = "LabelGroundLng"
        Me.LabelGroundLng.Size = New System.Drawing.Size(86, 18)
        Me.LabelGroundLng.TabIndex = 10
        Me.LabelGroundLng.Text = "Longitude:"
        '
        'LabelGroundLat
        '
        Me.LabelGroundLat.AutoSize = True
        Me.LabelGroundLat.Location = New System.Drawing.Point(18, 229)
        Me.LabelGroundLat.Name = "LabelGroundLat"
        Me.LabelGroundLat.Size = New System.Drawing.Size(72, 18)
        Me.LabelGroundLat.TabIndex = 9
        Me.LabelGroundLat.Text = "Latitude:"
        '
        'LabelAltitude
        '
        Me.LabelAltitude.AutoSize = True
        Me.LabelAltitude.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAltitude.ForeColor = System.Drawing.Color.Black
        Me.LabelAltitude.Location = New System.Drawing.Point(18, 190)
        Me.LabelAltitude.Name = "LabelAltitude"
        Me.LabelAltitude.Size = New System.Drawing.Size(68, 18)
        Me.LabelAltitude.TabIndex = 8
        Me.LabelAltitude.Text = "Altitude:"
        '
        'LabelHumidity
        '
        Me.LabelHumidity.AutoSize = True
        Me.LabelHumidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHumidity.ForeColor = System.Drawing.Color.Black
        Me.LabelHumidity.Location = New System.Drawing.Point(18, 151)
        Me.LabelHumidity.Name = "LabelHumidity"
        Me.LabelHumidity.Size = New System.Drawing.Size(78, 18)
        Me.LabelHumidity.TabIndex = 8
        Me.LabelHumidity.Text = "Humidity:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBoxRecordInd)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.ButtonClear)
        Me.GroupBox3.Controls.Add(Me.ButtonStopRecording)
        Me.GroupBox3.Controls.Add(Me.ButtonStartRecording)
        Me.GroupBox3.Location = New System.Drawing.Point(49, 184)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(359, 112)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Logging Controls"
        '
        'PictureBoxRecordInd
        '
        Me.PictureBoxRecordInd.Image = Global.Data_Logger.My.Resources.Resources.Redflg1
        Me.PictureBoxRecordInd.Location = New System.Drawing.Point(290, 1)
        Me.PictureBoxRecordInd.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxRecordInd.Name = "PictureBoxRecordInd"
        Me.PictureBoxRecordInd.Size = New System.Drawing.Size(14, 14)
        Me.PictureBoxRecordInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxRecordInd.TabIndex = 4
        Me.PictureBoxRecordInd.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, -1)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Recording"
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(6, 67)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(345, 34)
        Me.ButtonClear.TabIndex = 4
        Me.ButtonClear.Text = "Clear Data Grid / Graph"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonStopRecording
        '
        Me.ButtonStopRecording.Location = New System.Drawing.Point(192, 23)
        Me.ButtonStopRecording.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonStopRecording.Name = "ButtonStopRecording"
        Me.ButtonStopRecording.Size = New System.Drawing.Size(159, 34)
        Me.ButtonStopRecording.TabIndex = 4
        Me.ButtonStopRecording.Text = "Stop Recording"
        Me.ButtonStopRecording.UseVisualStyleBackColor = True
        '
        'ButtonStartRecording
        '
        Me.ButtonStartRecording.Location = New System.Drawing.Point(6, 23)
        Me.ButtonStartRecording.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonStartRecording.Name = "ButtonStartRecording"
        Me.ButtonStartRecording.Size = New System.Drawing.Size(159, 34)
        Me.ButtonStartRecording.TabIndex = 4
        Me.ButtonStartRecording.Text = "Start Recording"
        Me.ButtonStartRecording.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ButtonSaveToMSExcel)
        Me.GroupBox4.Controls.Add(Me.ProgressBarProcess)
        Me.GroupBox4.Location = New System.Drawing.Point(49, 304)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(294, 112)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Export Controls"
        '
        'ButtonSaveToMSExcel
        '
        Me.ButtonSaveToMSExcel.Location = New System.Drawing.Point(9, 23)
        Me.ButtonSaveToMSExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSaveToMSExcel.Name = "ButtonSaveToMSExcel"
        Me.ButtonSaveToMSExcel.Size = New System.Drawing.Size(278, 44)
        Me.ButtonSaveToMSExcel.TabIndex = 5
        Me.ButtonSaveToMSExcel.Text = "Save to MS Excel"
        Me.ButtonSaveToMSExcel.UseVisualStyleBackColor = True
        '
        'ProgressBarProcess
        '
        Me.ProgressBarProcess.Location = New System.Drawing.Point(10, 75)
        Me.ProgressBarProcess.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBarProcess.Maximum = 10
        Me.ProgressBarProcess.Name = "ProgressBarProcess"
        Me.ProgressBarProcess.Size = New System.Drawing.Size(276, 22)
        Me.ProgressBarProcess.TabIndex = 5
        Me.ProgressBarProcess.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox5.Location = New System.Drawing.Point(0, 424)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(1455, 317)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.TIME, Me.DATE_, Me.Altitude, Me.Temperature, Me.AirPressure, Me.MSLAirPressure, Me.Humidity, Me.SONDETE, Me.SONDEAP, Me.SONDEHUM, Me.SONDEBAL, Me.SONDELAT, Me.SONDELNG, Me.SONDEGPSAT, Me.SONDECOURSE, Me.SONDESPEED})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(4, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1447, 292)
        Me.DataGridView1.TabIndex = 7
        '
        'No
        '
        Me.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.No.FillWeight = 862.9442!
        Me.No.HeaderText = "LINE NO"
        Me.No.Name = "No"
        Me.No.Width = 96
        '
        'TIME
        '
        Me.TIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TIME.FillWeight = 19.18312!
        Me.TIME.HeaderText = "TIME"
        Me.TIME.Name = "TIME"
        Me.TIME.Width = 72
        '
        'DATE_
        '
        Me.DATE_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DATE_.FillWeight = 19.18312!
        Me.DATE_.HeaderText = "DATE"
        Me.DATE_.Name = "DATE_"
        Me.DATE_.Width = 76
        '
        'Altitude
        '
        Me.Altitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Altitude.FillWeight = 55.16895!
        Me.Altitude.HeaderText = "STN ALT"
        Me.Altitude.Name = "Altitude"
        Me.Altitude.Width = 97
        '
        'Temperature
        '
        Me.Temperature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Temperature.FillWeight = 46.03947!
        Me.Temperature.HeaderText = "STN TEMP"
        Me.Temperature.Name = "Temperature"
        Me.Temperature.Width = 113
        '
        'AirPressure
        '
        Me.AirPressure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AirPressure.FillWeight = 126.6086!
        Me.AirPressure.HeaderText = "STN AP"
        Me.AirPressure.Name = "AirPressure"
        Me.AirPressure.Width = 90
        '
        'MSLAirPressure
        '
        Me.MSLAirPressure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MSLAirPressure.FillWeight = 19.18312!
        Me.MSLAirPressure.HeaderText = "MSL AP"
        Me.MSLAirPressure.Name = "MSLAirPressure"
        Me.MSLAirPressure.Width = 91
        '
        'Humidity
        '
        Me.Humidity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Humidity.FillWeight = 55.16895!
        Me.Humidity.HeaderText = "STN HUM"
        Me.Humidity.Name = "Humidity"
        Me.Humidity.Width = 106
        '
        'SONDETE
        '
        Me.SONDETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SONDETE.FillWeight = 55.16895!
        Me.SONDETE.HeaderText = "SND TEMP"
        Me.SONDETE.Name = "SONDETE"
        Me.SONDETE.Width = 115
        '
        'SONDEAP
        '
        Me.SONDEAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SONDEAP.FillWeight = 55.16895!
        Me.SONDEAP.HeaderText = "SND AP"
        Me.SONDEAP.Name = "SONDEAP"
        Me.SONDEAP.Width = 92
        '
        'SONDEHUM
        '
        Me.SONDEHUM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SONDEHUM.FillWeight = 55.16895!
        Me.SONDEHUM.HeaderText = "SND HUM"
        Me.SONDEHUM.Name = "SONDEHUM"
        Me.SONDEHUM.Width = 108
        '
        'SONDEBAL
        '
        Me.SONDEBAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SONDEBAL.FillWeight = 55.16895!
        Me.SONDEBAL.HeaderText = "SND BALT"
        Me.SONDEBAL.Name = "SONDEBAL"
        Me.SONDEBAL.Width = 109
        '
        'SONDELAT
        '
        Me.SONDELAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SONDELAT.FillWeight = 55.16895!
        Me.SONDELAT.HeaderText = "SND LAT"
        Me.SONDELAT.Name = "SONDELAT"
        Me.SONDELAT.Width = 99
        '
        'SONDELNG
        '
        Me.SONDELNG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SONDELNG.FillWeight = 55.16895!
        Me.SONDELNG.HeaderText = "SND LNG"
        Me.SONDELNG.Name = "SONDELNG"
        Me.SONDELNG.Width = 104
        '
        'SONDEGPSAT
        '
        Me.SONDEGPSAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SONDEGPSAT.FillWeight = 55.16895!
        Me.SONDEGPSAT.HeaderText = "SND GPS ALT"
        Me.SONDEGPSAT.Name = "SONDEGPSAT"
        Me.SONDEGPSAT.Width = 135
        '
        'SONDECOURSE
        '
        Me.SONDECOURSE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SONDECOURSE.FillWeight = 55.16895!
        Me.SONDECOURSE.HeaderText = "SND WD"
        Me.SONDECOURSE.Name = "SONDECOURSE"
        Me.SONDECOURSE.Width = 99
        '
        'SONDESPEED
        '
        Me.SONDESPEED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SONDESPEED.FillWeight = 55.16895!
        Me.SONDESPEED.HeaderText = "SND WV"
        Me.SONDESPEED.Name = "SONDESPEED"
        Me.SONDESPEED.Width = 97
        '
        'TimerSerial
        '
        Me.TimerSerial.Interval = 1000
        '
        'TimerDataLogRecord
        '
        Me.TimerDataLogRecord.Interval = 2000
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.TextBox17)
        Me.GroupBox7.Controls.Add(Me.TextBox16)
        Me.GroupBox7.Controls.Add(Me.LabelSondeLong)
        Me.GroupBox7.Controls.Add(Me.LabelSondeLat)
        Me.GroupBox7.Controls.Add(Me.LabelSpeed)
        Me.GroupBox7.Controls.Add(Me.TextBox7)
        Me.GroupBox7.Controls.Add(Me.TextBox6)
        Me.GroupBox7.Controls.Add(Me.LabelWindDirection)
        Me.GroupBox7.Controls.Add(Me.TextBox5)
        Me.GroupBox7.Controls.Add(Me.TextBox4)
        Me.GroupBox7.Controls.Add(Me.LabelGPSAlt)
        Me.GroupBox7.Controls.Add(Me.TextBox3)
        Me.GroupBox7.Controls.Add(Me.TextBox2)
        Me.GroupBox7.Controls.Add(Me.LableSondeBMAL)
        Me.GroupBox7.Controls.Add(Me.TextBox1)
        Me.GroupBox7.Controls.Add(Me.LableSondeHumidity)
        Me.GroupBox7.Controls.Add(Me.LabelSondeTemperature)
        Me.GroupBox7.Controls.Add(Me.LabelSondeAP)
        Me.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(824, 40)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(298, 376)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Incoming Data (Space Segment)"
        '
        'TextBox17
        '
        Me.TextBox17.BackColor = System.Drawing.Color.Black
        Me.TextBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.ForeColor = System.Drawing.Color.Lime
        Me.TextBox17.Location = New System.Drawing.Point(207, 226)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(73, 24)
        Me.TextBox17.TabIndex = 10
        '
        'TextBox16
        '
        Me.TextBox16.BackColor = System.Drawing.Color.Black
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.ForeColor = System.Drawing.Color.Lime
        Me.TextBox16.Location = New System.Drawing.Point(207, 186)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(73, 24)
        Me.TextBox16.TabIndex = 9
        '
        'LabelSondeLong
        '
        Me.LabelSondeLong.AutoSize = True
        Me.LabelSondeLong.Location = New System.Drawing.Point(18, 229)
        Me.LabelSondeLong.Name = "LabelSondeLong"
        Me.LabelSondeLong.Size = New System.Drawing.Size(81, 18)
        Me.LabelSondeLong.TabIndex = 8
        Me.LabelSondeLong.Text = "Longitude"
        '
        'LabelSondeLat
        '
        Me.LabelSondeLat.AutoSize = True
        Me.LabelSondeLat.Location = New System.Drawing.Point(18, 189)
        Me.LabelSondeLat.Name = "LabelSondeLat"
        Me.LabelSondeLat.Size = New System.Drawing.Size(67, 18)
        Me.LabelSondeLat.TabIndex = 7
        Me.LabelSondeLat.Text = "Latitude"
        '
        'LabelSpeed
        '
        Me.LabelSpeed.AutoSize = True
        Me.LabelSpeed.Location = New System.Drawing.Point(18, 340)
        Me.LabelSpeed.Name = "LabelSpeed"
        Me.LabelSpeed.Size = New System.Drawing.Size(115, 18)
        Me.LabelSpeed.TabIndex = 6
        Me.LabelSpeed.Text = "Wind Velocity:"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Black
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.Lime
        Me.TextBox7.Location = New System.Drawing.Point(207, 337)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(73, 24)
        Me.TextBox7.TabIndex = 6
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Black
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.Lime
        Me.TextBox6.Location = New System.Drawing.Point(207, 300)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(73, 24)
        Me.TextBox6.TabIndex = 5
        '
        'LabelWindDirection
        '
        Me.LabelWindDirection.AutoSize = True
        Me.LabelWindDirection.Location = New System.Drawing.Point(18, 303)
        Me.LabelWindDirection.Name = "LabelWindDirection"
        Me.LabelWindDirection.Size = New System.Drawing.Size(124, 18)
        Me.LabelWindDirection.TabIndex = 5
        Me.LabelWindDirection.Text = "Wind Direction:"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Black
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.Lime
        Me.TextBox5.Location = New System.Drawing.Point(207, 263)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(73, 24)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Black
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Lime
        Me.TextBox4.Location = New System.Drawing.Point(207, 147)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(73, 24)
        Me.TextBox4.TabIndex = 3
        '
        'LabelGPSAlt
        '
        Me.LabelGPSAlt.AutoSize = True
        Me.LabelGPSAlt.Location = New System.Drawing.Point(18, 266)
        Me.LabelGPSAlt.Name = "LabelGPSAlt"
        Me.LabelGPSAlt.Size = New System.Drawing.Size(108, 18)
        Me.LabelGPSAlt.TabIndex = 4
        Me.LabelGPSAlt.Text = "GPS Altitued:"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Black
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Lime
        Me.TextBox3.Location = New System.Drawing.Point(207, 108)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(73, 24)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Lime
        Me.TextBox2.Location = New System.Drawing.Point(207, 69)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(73, 24)
        Me.TextBox2.TabIndex = 1
        '
        'LableSondeBMAL
        '
        Me.LableSondeBMAL.AutoSize = True
        Me.LableSondeBMAL.Location = New System.Drawing.Point(18, 150)
        Me.LableSondeBMAL.Name = "LableSondeBMAL"
        Me.LableSondeBMAL.Size = New System.Drawing.Size(156, 18)
        Me.LableSondeBMAL.TabIndex = 3
        Me.LableSondeBMAL.Text = "Barometric Altitued:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(207, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(73, 24)
        Me.TextBox1.TabIndex = 0
        '
        'LableSondeHumidity
        '
        Me.LableSondeHumidity.AutoSize = True
        Me.LableSondeHumidity.Location = New System.Drawing.Point(18, 111)
        Me.LableSondeHumidity.Name = "LableSondeHumidity"
        Me.LableSondeHumidity.Size = New System.Drawing.Size(78, 18)
        Me.LableSondeHumidity.TabIndex = 2
        Me.LableSondeHumidity.Text = "Humidity:"
        '
        'LabelSondeTemperature
        '
        Me.LabelSondeTemperature.AutoSize = True
        Me.LabelSondeTemperature.Location = New System.Drawing.Point(18, 34)
        Me.LabelSondeTemperature.Name = "LabelSondeTemperature"
        Me.LabelSondeTemperature.Size = New System.Drawing.Size(108, 18)
        Me.LabelSondeTemperature.TabIndex = 0
        Me.LabelSondeTemperature.Text = "Temperature:"
        '
        'LabelSondeAP
        '
        Me.LabelSondeAP.AutoSize = True
        Me.LabelSondeAP.Location = New System.Drawing.Point(18, 72)
        Me.LabelSondeAP.Name = "LabelSondeAP"
        Me.LabelSondeAP.Size = New System.Drawing.Size(106, 18)
        Me.LabelSondeAP.TabIndex = 1
        Me.LabelSondeAP.Text = "Air Pressure:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(1, Byte), True)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.GraphsToolStripMenuItem, Me.GPSSystemToolStripMenuItem, Me.SondeSetupToolStripMenuItem, Me.DiagnosticToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1455, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToMSExcelToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(43, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToMSExcelToolStripMenuItem
        '
        Me.SaveToMSExcelToolStripMenuItem.Name = "SaveToMSExcelToolStripMenuItem"
        Me.SaveToMSExcelToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.SaveToMSExcelToolStripMenuItem.Text = "Save to MS Excel"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'GraphsToolStripMenuItem
        '
        Me.GraphsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StationPTUToolStripMenuItem, Me.SondePTUToolStripMenuItem, Me.SondeTrackingToolStripMenuItem})
        Me.GraphsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraphsToolStripMenuItem.Name = "GraphsToolStripMenuItem"
        Me.GraphsToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.GraphsToolStripMenuItem.Text = "Graphs"
        '
        'StationPTUToolStripMenuItem
        '
        Me.StationPTUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TemperatureAndHumidityToolStripMenuItem})
        Me.StationPTUToolStripMenuItem.Name = "StationPTUToolStripMenuItem"
        Me.StationPTUToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.StationPTUToolStripMenuItem.Text = "Station PTU"
        '
        'TemperatureAndHumidityToolStripMenuItem
        '
        Me.TemperatureAndHumidityToolStripMenuItem.Name = "TemperatureAndHumidityToolStripMenuItem"
        Me.TemperatureAndHumidityToolStripMenuItem.Size = New System.Drawing.Size(255, 26)
        Me.TemperatureAndHumidityToolStripMenuItem.Text = "Temperature and Humidity"
        '
        'SondePTUToolStripMenuItem
        '
        Me.SondePTUToolStripMenuItem.Name = "SondePTUToolStripMenuItem"
        Me.SondePTUToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.SondePTUToolStripMenuItem.Text = "Sonde PTU"
        '
        'SondeTrackingToolStripMenuItem
        '
        Me.SondeTrackingToolStripMenuItem.Name = "SondeTrackingToolStripMenuItem"
        Me.SondeTrackingToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.SondeTrackingToolStripMenuItem.Text = "Sonde Tracking"
        '
        'GPSSystemToolStripMenuItem
        '
        Me.GPSSystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GMapTrackingToolStripMenuItem})
        Me.GPSSystemToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPSSystemToolStripMenuItem.Name = "GPSSystemToolStripMenuItem"
        Me.GPSSystemToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.GPSSystemToolStripMenuItem.Text = "GPS System"
        '
        'SondeSetupToolStripMenuItem
        '
        Me.SondeSetupToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SondeSetupToolStripMenuItem.Name = "SondeSetupToolStripMenuItem"
        Me.SondeSetupToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.SondeSetupToolStripMenuItem.Text = "Sonde Setup"
        '
        'DiagnosticToolsToolStripMenuItem
        '
        Me.DiagnosticToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RawDataToolStripMenuItem})
        Me.DiagnosticToolsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiagnosticToolsToolStripMenuItem.Name = "DiagnosticToolsToolStripMenuItem"
        Me.DiagnosticToolsToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.DiagnosticToolsToolStripMenuItem.Text = "Diagnostic Tools"
        '
        'RawDataToolStripMenuItem
        '
        Me.RawDataToolStripMenuItem.Name = "RawDataToolStripMenuItem"
        Me.RawDataToolStripMenuItem.Size = New System.Drawing.Size(147, 26)
        Me.RawDataToolStripMenuItem.Text = "Raw Data"
        '
        'PictureBoxConnectionInd
        '
        Me.PictureBoxConnectionInd.Image = Global.Data_Logger.My.Resources.Resources.Redflg1
        Me.PictureBoxConnectionInd.Location = New System.Drawing.Point(335, 37)
        Me.PictureBoxConnectionInd.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxConnectionInd.Name = "PictureBoxConnectionInd"
        Me.PictureBoxConnectionInd.Size = New System.Drawing.Size(14, 14)
        Me.PictureBoxConnectionInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxConnectionInd.TabIndex = 1
        Me.PictureBoxConnectionInd.TabStop = False
        '
        'GMapTrackingToolStripMenuItem
        '
        Me.GMapTrackingToolStripMenuItem.Name = "GMapTrackingToolStripMenuItem"
        Me.GMapTrackingToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.GMapTrackingToolStripMenuItem.Text = "GMap Tracking"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1455, 741)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBoxConnectionInd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainWindow"
        Me.Text = "Automatic Weather Station"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBoxRecordInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBoxConnectionInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents ButtonDisconnect As Button
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents LabelStatus As Label
    Friend WithEvents PictureBoxConnectionInd As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelMSLAirPressure As Label
    Friend WithEvents LabelAirPressure As Label
    Friend WithEvents LabelTemperature As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ButtonStopRecording As Button
    Friend WithEvents ButtonStartRecording As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents PictureBoxRecordInd As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ButtonSaveToMSExcel As Button
    Friend WithEvents ProgressBarProcess As ProgressBar
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerDataLogRecord As Timer
    Friend WithEvents LabelAltitude As Label
    Friend WithEvents LabelHumidity As Label
    Friend WithEvents LabelGroundAlt As Label
    Friend WithEvents LabelGroundLng As Label
    Friend WithEvents LabelGroundLat As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents LabelSpeed As Label
    Friend WithEvents LabelWindDirection As Label
    Friend WithEvents LabelGPSAlt As Label
    Friend WithEvents LableSondeBMAL As Label
    Friend WithEvents LableSondeHumidity As Label
    Friend WithEvents LabelSondeAP As Label
    Friend WithEvents LabelSondeTemperature As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToMSExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GraphsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GPSSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SondeSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiagnosticToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RawDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StationPTUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SondePTUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SondeTrackingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents TIME As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ As DataGridViewTextBoxColumn
    Friend WithEvents Altitude As DataGridViewTextBoxColumn
    Friend WithEvents Temperature As DataGridViewTextBoxColumn
    Friend WithEvents AirPressure As DataGridViewTextBoxColumn
    Friend WithEvents MSLAirPressure As DataGridViewTextBoxColumn
    Friend WithEvents Humidity As DataGridViewTextBoxColumn
    Friend WithEvents SONDETE As DataGridViewTextBoxColumn
    Friend WithEvents SONDEAP As DataGridViewTextBoxColumn
    Friend WithEvents SONDEHUM As DataGridViewTextBoxColumn
    Friend WithEvents SONDEBAL As DataGridViewTextBoxColumn
    Friend WithEvents SONDELAT As DataGridViewTextBoxColumn
    Friend WithEvents SONDELNG As DataGridViewTextBoxColumn
    Friend WithEvents SONDEGPSAT As DataGridViewTextBoxColumn
    Friend WithEvents SONDECOURSE As DataGridViewTextBoxColumn
    Friend WithEvents SONDESPEED As DataGridViewTextBoxColumn
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents LabelSondeLong As Label
    Friend WithEvents LabelSondeLat As Label
    Friend WithEvents TemperatureAndHumidityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GMapTrackingToolStripMenuItem As ToolStripMenuItem
End Class
