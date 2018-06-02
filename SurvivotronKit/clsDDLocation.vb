''' <summary>
''' Decimal Degrees (DD) notation: (Latitude, Longitude) expressed in decimals
''' Example: (38.89861, -77.03778)
''' </summary>
Class DDLocation
    Public Property Lat As Double
    Public Property Lon As Double

    Public Sub New()
    End Sub

    Public Sub New(latitude As Double, longitude As Double)
        Lat = latitude
        Lon = longitude
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("({0:f4}; {1:f4})", Lat, Lon)
    End Function
End Class
