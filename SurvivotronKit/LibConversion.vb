''' <summary>
''' Conversion functions library
''' </summary>
Module LibConversion

    ''' <summary>
    ''' Converts from DMS to DD
    ''' </summary>
    ''' <param name="dms">DMS location</param>
    ''' <returns>DD location</returns>
    Public Function ConvertDMS2DD(ByVal dms As DMSLocation) As DDLocation
        If dms Is Nothing Then
            Return Nothing
        End If

        Return New DDLocation(ConvertDMSPnt2Dbl(dms.Lat), ConvertDMSPnt2Dbl(dms.Lon))
    End Function

    ''' <summary>
    ''' Converts from DD to DMS
    ''' </summary>
    ''' <param name="dd">DD location</param>
    ''' <returns>DMS location</returns>
    Public Function ConvertDD2DMS(ByVal dd As DDLocation) As DMSLocation
        If dd Is Nothing Then
            Return Nothing
        End If

        Dim submin As Double = 0.0

        ' latitude
        submin = Math.Abs((dd.Lat - Int(dd.Lat)) * 60)
        Dim dmsLat As New PointDMS(Int(dd.Lat), Int(submin), Math.Abs((submin - Int(submin)) * 60), PointType.LAT)

        ' longitude
        submin = Math.Abs((dd.Lon - Int(dd.Lon)) * 60)
        Dim dmsLon As New PointDMS(Int(dd.Lon), Int(submin), Math.Abs((submin - Int(submin)) * 60), PointType.LON)

        Return New DMSLocation(dmsLat, dmsLon)
    End Function

    ''' <summary>
    ''' Converts from DD to XYPoint
    ''' </summary>
    ''' <param name="dd">DD location</param>
    ''' <returns>XY location</returns>
    Public Function ConvertDD2XY(ByVal dd As DDLocation) As PointXY
        If dd Is Nothing Then
            Return Nothing
        End If

        Return New PointXY(CInt((_MAP_SIZE / _MAP_WIDTH_DD) * (dd.Lon - _MAP_LON_LEFT_DD)), CInt((_MAP_SIZE / _MAP_HEIGHT_DD) * (dd.Lat - _MAP_LAT_BOTTOM_DD)))
    End Function

    ''' <summary>
    ''' Converts from XYPoint to DD
    ''' </summary>
    ''' <param name="xy">XY location</param>
    ''' <returns>DD location</returns>
    Public Function ConvertXY2DD(ByVal xy As PointXY) As DDLocation
        If xy Is Nothing Then
            Return Nothing
        End If

        Return New DDLocation(_MAP_LAT_BOTTOM_DD + xy.X * (_MAP_HEIGHT_DD / _MAP_SIZE), _MAP_LON_LEFT_DD + xy.Y * (_MAP_WIDTH_DD / _MAP_SIZE))
    End Function

    Private Function ConvertDMSPnt2Dbl(ByVal dmsPnt As PointDMS) As Double
        If dmsPnt Is Nothing Then
            Return Nothing
        End If

        Return IIf(dmsPnt.Deg < 0, (dmsPnt.Deg) - (dmsPnt.Min) / 60 - dmsPnt.Sec / 3600, (dmsPnt.Deg) + (dmsPnt.Min) / 60 + dmsPnt.Sec / 3600)
    End Function

End Module
