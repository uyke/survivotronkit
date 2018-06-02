''' <summary>
''' Degree/Minute/Second (DMS) notation: (Latitude, Longitude) expressed in Degrees/Minutes/Seconds
''' Example: (38 53 55 N, 77 2 16 W)
''' </summary>
Class DMSLocation
    Public Property Lat As New PointDMS
    Public Property Lon As New PointDMS

    Public Sub New()
    End Sub

    Public Sub New(latitude As PointDMS, longitude As PointDMS)
        Lat = latitude
        Lon = longitude
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("({0}; {1})", Lat, Lon)
    End Function
End Class
