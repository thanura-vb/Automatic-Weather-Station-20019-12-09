<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemperatureGraph
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(814, 717)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Waiting....."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(704, 717)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Temperature"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Black
        ChartArea1.AxisX.Crossing = -1.7976931348623157E+308R
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Lime
        ChartArea1.AxisX.LineColor = System.Drawing.Color.Lime
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Lime
        ChartArea1.AxisX.Maximum = 10.0R
        ChartArea1.AxisX.Minimum = 0R
        ChartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Lime
        ChartArea1.AxisY.LineColor = System.Drawing.Color.Lime
        ChartArea1.AxisY.MajorGrid.Interval = 10.0R
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Lime
        ChartArea1.AxisY.MajorTickMark.Interval = 10.0R
        ChartArea1.AxisY.Maximum = 50.0R
        ChartArea1.AxisY.MaximumAutoSize = 100.0!
        ChartArea1.AxisY.Minimum = -30.0R
        ChartArea1.BackColor = System.Drawing.Color.Black
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Chart1.Location = New System.Drawing.Point(247, 0)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.Red
        Series1.Label = "#VAL"
        Series1.LabelBorderColor = System.Drawing.Color.Yellow
        Series1.LabelForeColor = System.Drawing.Color.Red
        Series1.MarkerColor = System.Drawing.Color.Red
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "TEMP"
        Series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Color = System.Drawing.Color.Red
        Series2.IsValueShownAsLabel = True
        Series2.LabelBorderColor = System.Drawing.Color.Yellow
        Series2.LabelForeColor = System.Drawing.Color.Red
        Series2.MarkerColor = System.Drawing.Color.Yellow
        Series2.Name = "STEMP"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(1076, 745)
        Me.Chart1.TabIndex = 6
        Me.Chart1.Text = "Chart1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'TemperatureGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1323, 745)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chart1)
        Me.MaximizeBox = False
        Me.Name = "TemperatureGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temperature Graph"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Timer1 As Timer
End Class
