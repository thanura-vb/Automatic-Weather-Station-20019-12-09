Public Class TemperatureGraph
    Public SurfaceTemperature As Double
    Public SondeTemperature As Double
    Private Sub TemperatureAndHumidityGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Chart1.Series("TEMP").IsValueShownAsLabel = True
        'Chart1.Series("TEMP").SmartLabelStyle.Enabled = True
        'Chart1.Series("TEMP").Label = ""
        'Chart1.Series("STEMP").IsValueShownAsLabel = True
        'Chart1.Series("STEMP").SmartLabelStyle.Enabled = True
        'Chart1.Series("STEMP").Label = ""

        For i = 0 To 30 Step 1
            Chart1.Series("TEMP").Points.AddXY(DateTime.Now.ToLongTimeString, 0)

            If Chart1.Series(0).Points.Count = Limit Then
                Chart1.Series(0).Points.RemoveAt(0)
            End If


            Chart1.Series("STEMP").Points.AddY(SondeTemperature)
            If Chart1.Series(1).Points.Count = Limit Then
                Chart1.Series(1).Points.RemoveAt(0)
            End If

        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim GetSurfaceTemperatureFromMainW As String
        Dim GetSondeTemperatureFromMainW As String

        Try
            GetSurfaceTemperatureFromMainW = MainWindow.TextBox8.Text
            GetSondeTemperatureFromMainW = MainWindow.TextBox1.Text

            SurfaceTemperature = Convert.ToDouble(GetSurfaceTemperatureFromMainW)
            SondeTemperature = Convert.ToDouble(GetSondeTemperatureFromMainW)

            Me.Label2.Text = SurfaceTemperature

            Chart1.Series("TEMP").Points.AddXY(DateTime.Now.ToLongTimeString, SurfaceTemperature)

            If Chart1.Series(0).Points.Count = Limit Then
                Chart1.Series(0).Points.RemoveAt(0)
            End If

            Chart1.Series("STEMP").Points.AddY(SondeTemperature)
            If Chart1.Series(1).Points.Count = Limit Then
                Chart1.Series(1).Points.RemoveAt(0)
            End If

        Catch ex As Exception
            GetSurfaceTemperatureFromMainW = "0"

            GetSondeTemperatureFromMainW = "0"
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Me.Label2.Text = ""

    End Sub
End Class