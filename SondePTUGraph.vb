Public Class SondePTUGraph
    Public SondeTemperature As Double
    Public SondeAirPressure As Double
    Public SondeHumidity As Double
    Private Sub SondePTUGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 30 Step 1
            Chart1.Series("Temperature").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart1.Series(0).Points.Count = Limit Then
                Chart1.Series(0).Points.RemoveAt(0)
            End If

            Chart1.ChartAreas(0).AxisY.Maximum = 1100

            Chart1.Series("Air Pressure").Points.AddY(0)
            If Chart1.Series(1).Points.Count = Limit Then
                Chart1.Series(1).Points.RemoveAt(0)
            End If

            Chart1.Series("Humidity").Points.AddY(0)
            If Chart1.Series(2).Points.Count = Limit Then
                Chart1.Series(2).Points.RemoveAt(0)
            End If
        Next
        Chart1.ChartAreas(0).AxisY.Maximum = 1200
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim GetSondeTemperatureFromMainW As String
        Dim GetSondeAirPressureFromMainW As String
        Dim GetSondeHumidityFromMainW As String

        GetSondeTemperatureFromMainW = MainWindow.TextBox1.Text
        GetSondeAirPressureFromMainW = MainWindow.TextBox2.Text
        GetSondeHumidityFromMainW = MainWindow.TextBox3.Text

        SondeTemperature = Convert.ToDouble(GetSondeTemperatureFromMainW)
        SondeAirPressure = Convert.ToDouble(GetSondeAirPressureFromMainW)
        SondeHumidity = Convert.ToDouble(GetSondeHumidityFromMainW)

        Me.LabelSondeTemperature.Text = SondeTemperature
        Me.LabelSondeAirPressure.Text = SondeAirPressure
        Me.LabelSondeHumidity.Text = SondeHumidity


        Chart1.Series("Temperature").Points.AddXY(DateTime.Now.ToLongTimeString, SondeTemperature)
        If Chart1.Series(0).Points.Count = Limit Then
            Chart1.Series(0).Points.RemoveAt(0)
        End If

        Chart1.Series("Air Pressure").Points.AddY(SondeAirPressure)
        If Chart1.Series(1).Points.Count = Limit Then
            Chart1.Series(1).Points.RemoveAt(0)
        End If

        Chart1.Series("Humidity").Points.AddY(SondeHumidity)
        If Chart1.Series(2).Points.Count = Limit Then
            Chart1.Series(2).Points.RemoveAt(0)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Me.LabelSondeTemperature.Text = ""
        Me.LabelSondeAirPressure.Text = ""
        Me.LabelSondeHumidity.Text = ""
    End Sub
End Class