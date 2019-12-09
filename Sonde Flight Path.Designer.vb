<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SondeFlightPath
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Black
        ChartArea1.AxisX.Interval = 30.0R
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Lime
        ChartArea1.AxisX.LabelStyle.Interval = 30.0R
        ChartArea1.AxisX.LineColor = System.Drawing.Color.Lime
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Lime
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Lime
        ChartArea1.AxisX.Maximum = 360.0R
        ChartArea1.AxisX.Minimum = 0R
        ChartArea1.AxisY.Interval = 500.0R
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Lime
        ChartArea1.AxisY.LabelStyle.Interval = 250.0R
        ChartArea1.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.LineColor = System.Drawing.Color.Lime
        ChartArea1.AxisY.MajorGrid.Interval = 250.0R
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Lime
        ChartArea1.AxisY.MajorTickMark.Interval = 250.0R
        ChartArea1.AxisY.MajorTickMark.IntervalOffset = 0R
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Lime
        ChartArea1.AxisY.MajorTickMark.Size = 3.0!
        ChartArea1.AxisY.Maximum = 2000.0R
        ChartArea1.AxisY.Minimum = 0R
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar
        Series1.Color = System.Drawing.Color.Blue
        Series1.IsValueShownAsLabel = True
        Series1.Label = "#VALX\n#VAL"
        Series1.LabelBackColor = System.Drawing.Color.Transparent
        Series1.LabelBorderColor = System.Drawing.Color.Red
        Series1.LabelForeColor = System.Drawing.Color.Lime
        Series1.Legend = "Legend1"
        Series1.MarkerColor = System.Drawing.Color.Red
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square
        Series1.Name = "SondeCoords"
        Series1.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None
        Series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Red
        Series1.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box
        Series1.SmartLabelStyle.MaxMovingDistance = 50.0R
        Series1.SmartLabelStyle.MinMovingDistance = 10.0R
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1423, 844)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(28, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start Tracking"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(24, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 41)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Stop Tracking"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Timer2
        '
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(22, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Bearing"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(112, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Waiting....."
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(22, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Distance"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(22, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Course"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(112, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Waiting....."
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(112, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Waiting....."
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(1192, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 140)
        Me.Panel1.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(24, 145)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 41)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Clear Track"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SondeFlightPath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1423, 844)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "SondeFlightPath"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sonde_Flight_Path"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
End Class
