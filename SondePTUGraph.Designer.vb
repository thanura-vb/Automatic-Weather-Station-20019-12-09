<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SondePTUGraph
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
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series19 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series20 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series21 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelSondeTemperature = New System.Windows.Forms.Label()
        Me.LabelSondeAirPressure = New System.Windows.Forms.Label()
        Me.LabelSondeHumidity = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 61)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start Plotting"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(24, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(201, 61)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Stop Plotting"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Black
        ChartArea7.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Lime
        ChartArea7.AxisX.LineColor = System.Drawing.Color.Lime
        ChartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.Lime
        ChartArea7.AxisX.MinorGrid.LineColor = System.Drawing.Color.Lime
        ChartArea7.AxisX.MinorTickMark.Enabled = True
        ChartArea7.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Lime
        ChartArea7.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis
        ChartArea7.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Lime
        ChartArea7.AxisY.LineColor = System.Drawing.Color.Lime
        ChartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.Lime
        ChartArea7.AxisY.MinorTickMark.Enabled = True
        ChartArea7.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Lime
        ChartArea7.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis
        ChartArea7.BackColor = System.Drawing.Color.Black
        ChartArea7.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea7)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Right
        Legend7.Alignment = System.Drawing.StringAlignment.Center
        Legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend7.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend7)
        Me.Chart1.Location = New System.Drawing.Point(293, 0)
        Me.Chart1.Name = "Chart1"
        Series19.BorderWidth = 2
        Series19.ChartArea = "ChartArea1"
        Series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series19.Color = System.Drawing.Color.Red
        Series19.LabelForeColor = System.Drawing.Color.Transparent
        Series19.Legend = "Legend1"
        Series19.Name = "Temperature"
        Series20.BorderWidth = 2
        Series20.ChartArea = "ChartArea1"
        Series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series20.Color = System.Drawing.Color.Fuchsia
        Series20.Legend = "Legend1"
        Series20.Name = "Air Pressure"
        Series21.BorderWidth = 2
        Series21.ChartArea = "ChartArea1"
        Series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series21.Color = System.Drawing.Color.Blue
        Series21.Legend = "Legend1"
        Series21.Name = "Humidity"
        Me.Chart1.Series.Add(Series19)
        Me.Chart1.Series.Add(Series20)
        Me.Chart1.Series.Add(Series21)
        Me.Chart1.Size = New System.Drawing.Size(914, 624)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 340)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Temperature:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 378)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Air Pressure:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 416)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Humidity:"
        '
        'LabelSondeTemperature
        '
        Me.LabelSondeTemperature.AutoSize = True
        Me.LabelSondeTemperature.Location = New System.Drawing.Point(166, 340)
        Me.LabelSondeTemperature.Name = "LabelSondeTemperature"
        Me.LabelSondeTemperature.Size = New System.Drawing.Size(75, 17)
        Me.LabelSondeTemperature.TabIndex = 6
        Me.LabelSondeTemperature.Text = "Waiting....."
        '
        'LabelSondeAirPressure
        '
        Me.LabelSondeAirPressure.AutoSize = True
        Me.LabelSondeAirPressure.Location = New System.Drawing.Point(166, 378)
        Me.LabelSondeAirPressure.Name = "LabelSondeAirPressure"
        Me.LabelSondeAirPressure.Size = New System.Drawing.Size(75, 17)
        Me.LabelSondeAirPressure.TabIndex = 7
        Me.LabelSondeAirPressure.Text = "Waiting....."
        '
        'LabelSondeHumidity
        '
        Me.LabelSondeHumidity.AutoSize = True
        Me.LabelSondeHumidity.Location = New System.Drawing.Point(166, 416)
        Me.LabelSondeHumidity.Name = "LabelSondeHumidity"
        Me.LabelSondeHumidity.Size = New System.Drawing.Size(75, 17)
        Me.LabelSondeHumidity.TabIndex = 8
        Me.LabelSondeHumidity.Text = "Waiting....."
        '
        'SondePTUGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 624)
        Me.Controls.Add(Me.LabelSondeHumidity)
        Me.Controls.Add(Me.LabelSondeAirPressure)
        Me.Controls.Add(Me.LabelSondeTemperature)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "SondePTUGraph"
        Me.Text = "Sonde PTU Graph"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelSondeTemperature As Label
    Friend WithEvents LabelSondeAirPressure As Label
    Friend WithEvents LabelSondeHumidity As Label
End Class
