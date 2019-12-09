Public Class SondeFlightPath
    Public SondeCourse As Double
    Public SondeLat As Double
    Public SondeLng As Double
    Dim lat1 As Double
    Dim lon1 As Double
    Dim lat2 As Double
    Dim lon2 As Double
    Dim dist As Double
    Dim crs As Double
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True

    End Sub

    Private Sub SondeFlightPath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart1.Series("SondeCoords").Points.AddXY("", "")
        Chart1.ChartAreas(0).AxisY.Maximum = 100
        Chart1.ChartAreas(0).AxisY.Minimum = 0
        Chart1.ChartAreas(0).AxisY.Interval = 10
        Chart1.ChartAreas(0).AxisY.MajorGrid.Interval = 10
        Chart1.ChartAreas(0).AxisY.LabelStyle.Interval = 10
        Chart1.ChartAreas(0).AxisX.Maximum = 360
        Chart1.ChartAreas(0).AxisY.Minimum = 0
        Chart1.Series("SondeCoords").LabelForeColor = Color.Transparent
        Chart1.Series("SondeCoords").MarkerColor = Color.Transparent
        Chart1.Series("SondeCoords").LabelBorderColor = Color.Transparent

        lat1 = MainWindow.TextBox13.Text
        lon1 = MainWindow.TextBox14.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Dim GetSondeCourseFromMainW As String
        Dim GetSondeLatFromMainW As String
        Dim GetSondeLngFromMainW As String


        Try

            GetSondeLatFromMainW = MainWindow.TextBox16.Text
            'GetSondeCourseFromMainW = MainWindow.TextBox6.Text
            GetSondeLngFromMainW = MainWindow.TextBox17.Text
            Dim Dist1 As New DistanceF
            Dim Bearing1 As New BearingF
            Dim K As Char = "K"
            Dim resultdist As Double
            Dim resultcrs As Double
            'Dim distance As Double
            'lat1 = TextBox1.Text
            'lon1 = TextBox2.Text

            lat2 = Convert.ToDouble(GetSondeLatFromMainW)
            lon2 = Convert.ToDouble(GetSondeLngFromMainW)

            dist = Dist1.distance(lat1, lon1, lat2, lon2, K)
            crs = Bearing1.Bearing(lat1, lon1, lat2, lon2, 0, 0)
            resultdist = Math.Round(dist * 1000, 0)
            resultcrs = Math.Round(crs, 0)
            'TextBox5.Text = Convert.ToString(resultdist)
            'TextBox6.Text = Convert.ToString(resultcrs)
            'SondeLat = Convert.ToDouble(GetSondeLatFromMainW)
            'SondeLng = Convert.ToDouble(GetSondeLngFromMainW)
            'SondeCourse = Convert.ToDouble(GetSondeCourseFromMainW)


            Me.Label4.Text = resultdist
            Me.Label5.Text = resultcrs

            Chart1.Series("SondeCoords").LabelForeColor = Color.Yellow
            Chart1.Series("SondeCoords").MarkerColor = Color.Red
            Chart1.Series("SondeCoords").LabelBackColor = Color.Transparent
            Chart1.Series("SondeCoords").LabelBorderColor = Color.Red
            Chart1.Series("SondeCoords").SmartLabelStyle.IsOverlappedHidden = True
            Chart1.Series("SondeCoords").Points(0).IsValueShownAsLabel = False

            'Chart1.Series("SondeCoords").Points.RemoveAt(0)
            Chart1.Series("SondeCoords").Points.AddXY(resultcrs, resultdist)
            Chart1.Series("SondeCoords").Points(0).IsValueShownAsLabel = False
            My.Computer.Audio.Play("C:\Users\MR.DINESH\Documents\Visual Studio 2015\Beep.wav")
            'Chart1.Series("SondeCoords").Points.RemoveAt(0)

        Catch ex As Exception
            GetSondeLatFromMainW = "0"
            'GetSondeCourseFromMainW = "0"
            GetSondeLngFromMainW = "0"
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Chart1.Series("SondeCoords").Points.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Chart1.Series("SondeCoords").Points.Clear()
        Chart1.Series("SondeCoords").Points.AddXY("", "")
        'Timer2.Enabled = True
    End Sub
End Class