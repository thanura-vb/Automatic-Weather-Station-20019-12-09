Public Class BearingF
    Public Function Bearing(ByVal StartLat As Double, ByVal StartLng As Double, ByVal DestinationLat As Double,
                              ByVal DestinationLng As Double, ByVal StartEle As Double, ByVal DestinationEle As Double) As Double


        '' Variables for Starting and Destination Coordinates
        'Dim StartLat As Double
        'Dim StartLng As Double
        'Dim DestinationLat As Double
        'Dim DestinationLng As Double

        ' Variables for Converted Coordinates to Radians
        Dim Lat1InRad As Double
        Dim Lng1InRad As Double
        Dim Lat2InRad As Double
        Dim Lng2InRad As Double

        ' convert latitude and longitude to radians
        Lat1InRad = DegreesToRadians(StartLat)
        Lng1InRad = DegreesToRadians(StartLng)
        Lat2InRad = DegreesToRadians(DestinationLat)
        Lng2InRad = DegreesToRadians(DestinationLng)

        ' compute latitude and longitude differences

        Dim dlat As Double = Lat2InRad - Lat1InRad
        Dim dlon As Double = Lng2InRad - Lng1InRad

        Dim distanceNorth As Double = dlat
        Dim distanceEast As Double = dlon * Math.Cos(Lat1InRad)
        Dim distanceBtwCoords As Double
        Dim distanceInMeters As Double

        ' compute the distance in radians
        distanceBtwCoords = Math.Sqrt(distanceNorth * distanceNorth + distanceEast * distanceEast)

        'and convert the radians to meters
        distanceInMeters = RadiansToMeters(distanceBtwCoords)

        'add the elevation difference to the calculation
        Dim dEle As Double = (DestinationEle - StartEle)
        Dim adjustedDistance As Double = Math.Sqrt(distanceInMeters * distanceInMeters + dEle * dEle)

        ' compute the course
        Dim course As Double
        Dim courseInDeg As Double
        course = Math.Atan2(distanceEast, distanceNorth) Mod (2 * Math.PI)
        courseInDeg = RadiansToDegrees(course)
        If courseInDeg < 0 Then
            courseInDeg += 360
        End If
        Return courseInDeg
    End Function
    Function DegreesToRadians(ByVal degrees As Double) As Double
        Return degrees * Math.PI / 180.0
    End Function

    Function RadiansToDegrees(ByVal radians As Double) As Double
        Return radians * 180.0 / Math.PI
    End Function

    Function RadiansToNauticalMiles(ByVal radians As Double) As Double
        ' There are 60 nautical miles for each degree
        Return radians * 60 * 180 / Math.PI
    End Function

    Function RadiansToMeters(ByVal radians As Double) As Double
        ' there are 1852 meters in a nautical mile
        Return 1852 * RadiansToNauticalMiles(radians)
    End Function
End Class
