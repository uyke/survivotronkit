''' <summary>
''' DMS point: Degrees Minutes Seconds PointType
''' Example: -38 53 55.46 LAT --> 38 53 55.46 N
''' </summary>
Class PointDMS
    Public Property Deg As Integer
    Public Property Min As Integer
    Public Property Sec As Double
    Public Property Type As PointType

    Public Sub New()
    End Sub

    Public Sub New(degrees As Integer, minutes As Integer, seconds As Double, typePoint As PointType)
        Deg = degrees
        Min = minutes
        Sec = seconds
        Type = typePoint
    End Sub

    Public Overrides Function ToString() As String
        Dim c As String = ""
        If (Type = PointType.LAT) Then c = IIf(Deg < 0, "S", "N")
        If (Type = PointType.LON) Then c = IIf(Deg < 0, "W", "E")
        Return String.Format("{0}°{1}'{2:f2}''{3}", Math.Abs(Deg), Min, Sec, c.ToUpper)
    End Function
End Class

''' <summary>
''' A point is a LATitude or a LONgitude
''' </summary>
Enum PointType
    LAT
    LON
End Enum