Public Class DistanceF
    Public Function distance(ByVal lat1 As Double, ByVal lon1 As Double, ByVal lat2 As Double, ByVal lon2 As Double, ByVal unit As Char) As Double
        If lat1 = lat2 And lon1 = lon2 Then
            Return 0
        Else
            Dim theta As Double = lon1 - lon2
            Dim dist As Double = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta))
            dist = Math.Acos(dist)
            dist = rad2deg(dist)
            dist = dist * 60 * 1.1515
            If unit = "K" Then
                dist = dist * 1.609344
            ElseIf unit = "N" Then
                dist = dist * 0.8684
            End If
            Return dist
        End If
    End Function

    Private Function deg2rad(ByVal deg As Double) As Double
        Return (deg * Math.PI / 180.0)
    End Function

    Private Function rad2deg(ByVal rad As Double) As Double
        Return rad / Math.PI * 180.0
    End Function
End Class
