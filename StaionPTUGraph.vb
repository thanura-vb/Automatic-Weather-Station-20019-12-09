Public Class StationPTUGraph
    Public SurfaceTemperature As Double
    Public SurfaceAirPressure As Double
    Public MeanSeaLevelAirPressure As Double
    Public SurfaceHumidity As Double


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim GetSurfaceTemperatureFromMainW As String
        Dim GetSurfaceAirPressureFromMainW As String
        Dim GetMeanSeaLevelPressureFromMainW As String
        Dim GetSurfaceHumidityFromMainW As String
        Try
            GetSurfaceTemperatureFromMainW = MainWindow.TextBox8.Text
            GetSurfaceAirPressureFromMainW = MainWindow.TextBox9.Text
            GetMeanSeaLevelPressureFromMainW = MainWindow.TextBox10.Text
            GetSurfaceHumidityFromMainW = MainWindow.TextBox11.Text

            SurfaceTemperature = Convert.ToDouble(GetSurfaceTemperatureFromMainW)
            SurfaceAirPressure = Convert.ToDouble(GetSurfaceAirPressureFromMainW)
            MeanSeaLevelAirPressure = Convert.ToDouble(GetMeanSeaLevelPressureFromMainW)
            SurfaceHumidity = Convert.ToDouble(GetSurfaceHumidityFromMainW)

            Me.Label1.Text = SurfaceTemperature
            Me.Label2.Text = SurfaceAirPressure
            Me.Label3.Text = MeanSeaLevelAirPressure
            Me.Label4.Text = SurfaceHumidity

            Chart1.Series("TEMP").Points.AddXY(DateTime.Now.ToLongTimeString, SurfaceTemperature)
            If Chart1.Series(0).Points.Count = Limit Then
                Chart1.Series(0).Points.RemoveAt(0)
            End If

            Chart1.Series("AP").Points.AddY(SurfaceAirPressure)
            If Chart1.Series(1).Points.Count = Limit Then
                Chart1.Series(1).Points.RemoveAt(0)
            End If

            Chart1.Series("MSLAP").Points.AddY(MeanSeaLevelAirPressure)
            If Chart1.Series(2).Points.Count = Limit Then
                Chart1.Series(2).Points.RemoveAt(0)
            End If

            Chart1.Series("HUM").Points.AddY(SurfaceHumidity)
            If Chart1.Series(3).Points.Count = Limit Then
                Chart1.Series(3).Points.RemoveAt(0)
            End If
        Catch ex As Exception
            GetSurfaceTemperatureFromMainW = "0"
            GetSurfaceAirPressureFromMainW = "0"
            GetMeanSeaLevelPressureFromMainW = "0"
            GetSurfaceHumidityFromMainW = "0"
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 30 Step 1
            Chart1.Series("TEMP").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart1.Series(0).Points.Count = Limit Then
                Chart1.Series(0).Points.RemoveAt(0)
            End If

            Chart1.ChartAreas(0).AxisY.Maximum = 1100

            Chart1.Series("AP").Points.AddY(0)
            If Chart1.Series(1).Points.Count = Limit Then
                Chart1.Series(1).Points.RemoveAt(0)
            End If

            Chart1.Series("MSLAP").Points.AddY(0)
            If Chart1.Series(2).Points.Count = Limit Then
                Chart1.Series(2).Points.RemoveAt(0)
            End If

            Chart1.Series("HUM").Points.AddY(0)
            If Chart1.Series(3).Points.Count = Limit Then
                Chart1.Series(3).Points.RemoveAt(0)
            End If
        Next
        'Chart1.ChartAreas(0).AxisY.Maximum = 1200
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Me.Label1.Text = ""
        Me.Label2.Text = ""
        Me.Label3.Text = ""
        Me.Label4.Text = ""
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class