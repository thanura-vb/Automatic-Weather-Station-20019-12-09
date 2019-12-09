Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.MapProviders
Public Class GMapTracking
    Public Lat As Double
    Public Lng As Double
    Public LatSnd As Double
    Public LngSnd As Double
    Private Sub GMapTracking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GMapControl1.MapProvider = GoogleSatelliteMapProvider.Instance
        GMaps.Instance.Mode = AccessMode.ServerAndCache
        Lat = Convert.ToDouble(MainWindow.TextBox13.Text)
        Lng = Convert.ToDouble(MainWindow.TextBox14.Text)
        GMapControl1.Position = New PointLatLng(Lat, Lng)
        'GMapControl1.SetPositionByKeywords("Paris, France")
        GMapControl1.MinZoom = 2
        GMapControl1.MaxZoom = 25
        GMapControl1.Zoom = 8
        GMapControl1.DragButton = MouseButtons.Right
        GMapControl1.Overlays.Add(New GMapOverlay)
        GMapControl1.Overlays(0).Markers.Add(New Markers.GMarkerGoogle(New PointLatLng(8.0387, 80.9064), (Markers.GMarkerGoogleType.blue_small)))
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LatSnd = Convert.ToDouble(MainWindow.TextBox16.Text)
        LngSnd = Convert.ToDouble(MainWindow.TextBox17.Text)
        'GMapControl1.Overlays(0).Clear()
        GMapControl1.Overlays(0).Markers.Add(New Markers.GMarkerGoogle(New PointLatLng(LatSnd, LngSnd), (Markers.GMarkerGoogleType.red_small)))
        My.Computer.Audio.Play("C:\Users\MR.DINESH\Documents\Visual Studio 2015\Beep.wav")
        'GMapControl1.Overlays(0).Markers.Clear(PointLatLng(LatSnd, LngSnd)

    End Sub
End Class