''' <summary>
''' Global configuration settings
''' </summary>
Module GlobalVars

    Public Const _MAP_SIZE As Integer = 8192
    Public _MAP_IMAGE As Image ' The map loaded from an external image file
    Public _MAP_FILENAME As String ' The filename of the map image loaded
    Public _MAP_ZOOM As Integer ' Zoom factor used by the lens
    Public _COLOR_BACK As Color = Color.White ' Background color of the map
    Public _COLOR_PEN As Color = Color.White ' Pen color used when drawing on the map

    ' Some magic numbers obtained from the in-game grid map
    Public Const _MAP_LON_RIGHT_DD As Double = -122.9425
    Public Const _MAP_LON_LEFT_DD As Double = -123.051
    Public Const _MAP_LAT_TOP_DD As Double = 48.6504
    Public Const _MAP_LAT_BOTTOM_DD As Double = 48.5784
    Public Const _MAP_WIDTH_DD As Double = _MAP_LON_RIGHT_DD - _MAP_LON_LEFT_DD
    Public Const _MAP_HEIGHT_DD As Double = _MAP_LAT_TOP_DD - _MAP_LAT_BOTTOM_DD

End Module
