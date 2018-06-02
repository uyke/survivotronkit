''' <summary>
''' XY point: X,Y cartesian coordinates - X,Y range 0..8196 
''' Example: (6534; 2378)
''' </summary>
Class PointXY
    Public Property X As Integer
    Public Property Y As Integer

    Public Sub New()

    End Sub

    Public Sub New(xcoord As Integer, ycoord As Integer)
        X = xcoord
        Y = ycoord
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("({0}; {1})", X, Y)
    End Function
End Class

