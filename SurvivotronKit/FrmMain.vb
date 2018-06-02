Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms


''' <summary>
''' Main Application Form.
''' </summary>
Public Class FrmMain

    ''' <summary>
    ''' Sets initial form values.
    ''' Triggered when the form is loaded.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Displays app info in the title bar
        Me.Text = My.Application.Info.AssemblyName + " (" + My.Application.Info.Version.ToString + ")"

    End Sub

    ''' <summary>
    ''' Updates coordinates info and zoomed image.
    ''' Triggered when mouse is moved over the map.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PictureBoxMap_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PicboxMap.MouseMove

        If PicboxMap.Image Is Nothing Then Return

        Dim scaleW As Double = _MAP_SIZE / PicboxMap.Size.Width
        Dim scaleH As Double = _MAP_SIZE / PicboxMap.Size.Height

        ' Mouse position (X,Y)
        Dim coordX, coordY As Integer
        coordX = Int(scaleW * e.X)
        coordY = Int(_MAP_SIZE - (scaleH * e.Y))

        ' Mouse location expressed as (X,Y)
        TxtX.Text = coordX.ToString()
        TxtY.Text = coordY.ToString()

        ' Mouse location expressed as DD (lat,lon)
        Dim ddLocation As New DDLocation
        Dim xyLocation As New PointXY With {
            .X = coordX,
            .Y = coordY
        }
        ddLocation = ConvertXY2DD(xyLocation)
        TxtLatDD.Text = ddLocation.Lat.ToString
        TxtLonDD.Text = ddLocation.Lon.ToString

        ' Mouse location expressed as DMS
        Dim dmsLocation As New DMSLocation
        dmsLocation = ConvertDD2DMS(ddLocation)
        TxtLatDMS.Text = dmsLocation.Lat.ToString
        TxtLonDMS.Text = dmsLocation.Lon.ToString

        ' Refresh the zoomed map
        UpdateZoomedImage(e)
        Return
    End Sub

    ''' <summary>
    ''' Rezises an image and display it in a picturebox.
    ''' </summary>
    ''' <param name="picBox">The picturebox where the image will be displayed</param>
    ''' <param name="img">The image to be displayed</param>
    Private Sub ResizeAndDisplayImage(picBox As PictureBox, img As Image)

        picBox.BackColor = _COLOR_BACK
        picBox.Image = img
        Dim imgW As Integer = img.Width
        Dim imgH As Integer = img.Height
        Dim targetW As Integer
        Dim targetH As Integer
        Dim ratio As Double

        If imgW > imgH Then
            targetW = picBox.Width
            ratio = CDbl(targetW) / imgW
            targetH = CInt((ratio * imgH))
        ElseIf imgW < imgH Then
            targetH = picBox.Height
            ratio = CDbl(targetH) / imgH
            targetW = CInt((ratio * imgW))
        Else
            targetH = picBox.Height
            targetW = picBox.Width
        End If

        Dim targetTop As Integer = (picBox.Height - targetH) / 2
        Dim targetLeft As Integer = (picBox.Width - targetW) / 2
        Dim tmpBitmap As Bitmap = New Bitmap(picBox.Width, picBox.Height, PixelFormat.Format24bppRgb)
        tmpBitmap.SetResolution(img.HorizontalResolution, img.VerticalResolution)

        Dim bmGraphics As Graphics = Graphics.FromImage(tmpBitmap)
        With bmGraphics
            .Clear(_COLOR_BACK)
            .InterpolationMode = InterpolationMode.HighQualityBicubic
            .DrawImage(img, New Rectangle(targetLeft, targetTop, targetW, targetH), New Rectangle(0, 0, imgW, imgH), GraphicsUnit.Pixel)
            .Dispose()
        End With

        picBox.Image = tmpBitmap
        Return
    End Sub

    ''' <summary>
    ''' Draws a ellipse/circle on the map.
    ''' </summary>
    ''' <param name="pb">Map image</param>
    ''' <param name="x">Position X of the ellipse</param>
    ''' <param name="y">Position Y of the ellipse</param>
    ''' <param name="w">Width of the ellipse</param>
    ''' <param name="h">Height of the ellipse</param>
    ''' <param name="Bwidth">Brush width</param>
    ''' <param name="col">Color of the ellipse</param>
    Private Sub GeoMark(ByVal pb As PictureBox, ByVal x As Double, ByVal y As Double, ByVal w As Integer, ByVal h As Integer, ByVal Bwidth As Single, ByVal col As Color)

        Dim g As Graphics = pb.CreateGraphics()
        Dim p As Pen = New Pen(col, Bwidth)
        g.DrawEllipse(p, CInt(x), CInt(y), w, h)
        p.Dispose()
        g.Dispose()
        Return
    End Sub

    ''' <summary>
    ''' Shows a (x, y) location on the map.
    ''' Triggered when the Show On Map XY button is clicked.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonShowOnMap_Click(sender As Object, e As EventArgs) Handles BtnShowOnMapXY.Click

        Try
            Dim scale As Double = _MAP_SIZE / PicboxMap.Size.Width
            Dim x As Integer = Int32.Parse(TxtX.Text)
            Dim y As Integer = Int32.Parse(TxtY.Text)
            GeoMark(PicboxMap, x / scale, (_MAP_SIZE - y) / scale - 10, 10, 10, 3, _COLOR_PEN)
            UpdateZoomedImage(e)
        Catch ex As Exception
            MessageBox.Show("An error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
        Return
    End Sub

    ''' <summary>
    ''' Puts a geomark on the map.
    ''' Triggered when mouse clicked on map.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PictureBoxMap_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PicboxMap.MouseDoubleClick
        If PicboxMap.Image Is Nothing Then
            MessageBox.Show("The map image is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        Try
            Dim scale As Integer = _MAP_SIZE / PicboxMap.Size.Width
            TxtX.Text = (scale * (e.X)).ToString()
            TxtY.Text = (scale * (e.Y)).ToString()
            Dim x As Integer = Int32.Parse(TxtX.Text)
            Dim y As Integer = Int32.Parse(TxtY.Text)
            GeoMark(PicboxMap, x / scale - 10, y / scale - 10, 10, 10, 3, _COLOR_PEN)
            UpdateZoomedImage(e)
        Catch ex As Exception
            MessageBox.Show("An error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
        Return
    End Sub

    ''' <summary>
    ''' Updates the zoom factor.
    ''' Triggered when the zoom trackbar changed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TrackBarZoom_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TrbZoom.ValueChanged

        _MAP_ZOOM = TrbZoom.Value
        LabelZoomFactor.Text = String.Format("zoom: x{0}", _MAP_ZOOM)
        Return
    End Sub

    ''' <summary>
    ''' Updates the zoomed map to show the portion of the main map the mouse is currently over.
    ''' </summary>
    ''' <param name="e"></param>
    Private Sub UpdateZoomedImage(ByVal e As MouseEventArgs)

        Try
            ' Width and height of the zoomed image 
            Dim zoomW As Integer = PicboxZoom.Width / _MAP_ZOOM
            Dim zoomH As Integer = PicboxZoom.Height / _MAP_ZOOM

            ' Midpoints of the crosshair
            Dim halfW As Integer = zoomW / 2
            Dim halfH As Integer = zoomH / 2

            ' Temporary bitmap to fit inside the zoomed picturebox
            Dim tmpBitmap As Bitmap = New Bitmap(zoomW, zoomH, PixelFormat.Format24bppRgb)

            ' Temporary graphics object to work on the bitmap
            ' The current mouse position cuts out a portion of the image
            Dim bmGraphics As Graphics = Graphics.FromImage(tmpBitmap)
            With bmGraphics
                .Clear(_COLOR_BACK)
                .InterpolationMode = InterpolationMode.HighQualityBicubic
                .DrawImage(PicboxMap.Image, New Rectangle(0, 0, zoomW, zoomH), New Rectangle(e.X - halfW, e.Y - halfH, zoomW, zoomH), GraphicsUnit.Pixel)
            End With

            ' Draw the zoomed image
            PicboxZoom.Image = tmpBitmap
            ResizeAndDisplayImage(PicboxZoom, tmpBitmap)

            ' Dispose temporary objects
            bmGraphics.Dispose()
            tmpBitmap.Dispose()

            ' Refresh the zoomed image to reflect the changes
            PicboxZoom.Refresh()
        Catch ex As Exception
            MessageBox.Show("An error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
        Return
    End Sub

    ''' <summary>
    ''' Shows a (lat, long) location on the map.
    ''' Triggered when the Show On Map GPS button is clicked.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnShowOnMapGPS_Click(sender As Object, e As EventArgs)

        Dim dblLat, dblLon As Double
        If Not Double.TryParse(TxtLatDD.Text, dblLat) Then
            Return
        End If
        If Not Double.TryParse(TxtLonDD.Text, dblLon) Then
            Return
        End If

        Try

            Dim xypoint As New PointXY
            Dim ddLoc As New DDLocation(dblLat, dblLon)

            xypoint = ConvertDD2XY(ddLoc)

            Dim scale As Double = _MAP_SIZE / PicboxMap.Size.Width
            GeoMark(PicboxMap, xypoint.Y / scale, (_MAP_SIZE - xypoint.X) / scale - 10, 10, 10, 3, _COLOR_PEN)
            UpdateZoomedImage(e)
        Catch ex As Exception
            MessageBox.Show("An error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
        Return
    End Sub

    ''' <summary>
    ''' Sets the current pen color.
    ''' Triggered when the Select Color button is clicked.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnSelectPenColor_Click(sender As Object, e As EventArgs) Handles BtnSelectPenColor.Click
        Dim colorDialog As ColorDialog = New ColorDialog With {
            .AllowFullOpen = True,
            .AnyColor = True,
            .Color = _COLOR_BACK,
            .FullOpen = True,
            .ShowHelp = True,
            .SolidColorOnly = False
        }

        If colorDialog.ShowDialog() = DialogResult.OK Then
            _COLOR_PEN = colorDialog.Color
            TxtPenColor.BackColor = _COLOR_PEN
        End If

        colorDialog.Dispose()
        Return
    End Sub

    ''' <summary>
    ''' Loads the map image.
    ''' Triggered when the Browse Map Image button is clicked.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnBrowseMapImage_Click(sender As Object, e As EventArgs) Handles BtnBrowseMapImage.Click

        ' Open file dialog so user can select a map image to load
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
        With openFileDialog
            .AddExtension = False
            .CheckFileExists = True
            .CheckPathExists = True
            .Filter = "Supported Image Files|*.jpg;*.jpeg;*.bmp;*.png;*.dib;*.gif"
            .InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            .Multiselect = False
            .ReadOnlyChecked = False
            .ShowHelp = True
            .ShowReadOnly = False
            .SupportMultiDottedExtensions = True
            .Title = "Browse map image..."
            .ValidateNames = True
        End With

        ' Load the map image and display it
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                _MAP_IMAGE = Image.FromFile(openFileDialog.FileName)
                If _MAP_IMAGE Is Nothing Then
                    MessageBox.Show("The loaded map image is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    Return
                End If
                ResizeAndDisplayImage(PicboxMap, _MAP_IMAGE)
                _MAP_FILENAME = openFileDialog.FileName
                TxtMapImgFilename.Text = _MAP_FILENAME
                TxtMapW.Text = _MAP_IMAGE.Size.Width.ToString()
                TxtMapH.Text = _MAP_IMAGE.Size.Height.ToString()
            Catch ex As Exception
                MessageBox.Show("An error occured when loading the map: " & openFileDialog.FileName & vbCrLf + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try
        End If

        openFileDialog.Dispose()
        Return
    End Sub

    ''' <summary>
    ''' Converts the GPS input data.
    ''' Triggered when the Convert GPS Input is clicked.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnCovertGPSInput_Click(sender As Object, e As EventArgs) Handles BtnConvertGPSInput.Click
        Dim dblLatSec, dblLonSec As Double
        If Not Double.TryParse(TxtMaskGPSInputLatSec.Text, dblLatSec) Then
            Return
        End If
        If Not Double.TryParse(TxtMaskGPSInputLonSec.Text, dblLonSec) Then
            Return
        End If

        Dim dmsLoc As New DMSLocation
        With dmsLoc
            .Lat.Deg = CInt(TxtGPSInputLatDeg.Text)
            .Lat.Min = CInt(TxtGPSInputLatMin.Text)
            .Lat.Sec = dblLatSec
            .Lat.Type = PointType.LAT
            .Lon.Deg = CInt(TxtGPSInputLonDeg.Text)
            .Lon.Min = CInt(TxtGPSInputLonMin.Text)
            .Lon.Sec = dblLonSec
            .Lon.Type = PointType.LON
        End With

        If CmbGPSInputNS.Text = "S" Then dmsLoc.Lat.Deg = -dmsLoc.Lat.Deg
        If CmbGPSInputWE.Text = "W" Then dmsLoc.Lon.Deg = -dmsLoc.Lon.Deg

        ' Output DMS 
        TxtGPSOutDMS.Text = dmsLoc.ToString
        TxtLatDMS.Text = dmsLoc.Lat.ToString
        TxtLonDMS.Text = dmsLoc.Lon.ToString

        ' Output DD 
        Dim ddLoc As DDLocation = ConvertDMS2DD(dmsLoc)
        TxtGPSOutDD.Text = ddLoc.ToString
        TxtLatDD.Text = ddLoc.Lat.ToString
        TxtLonDD.Text = ddLoc.Lon.ToString

        ' Output XY 
        Dim xyLoc As PointXY = ConvertDD2XY(ddLoc)
        TxtGPSOutXY.Text = xyLoc.ToString
        TxtX.Text = xyLoc.X.ToString
        TxtY.Text = xyLoc.Y.ToString

    End Sub

End Class
