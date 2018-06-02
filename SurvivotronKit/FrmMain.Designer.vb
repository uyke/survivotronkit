<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.TabPageMap = New System.Windows.Forms.TabPage()
        Me.GrpGPSInput = New System.Windows.Forms.GroupBox()
        Me.TxtGPSOutXY = New System.Windows.Forms.TextBox()
        Me.TxtGPSOutDMS = New System.Windows.Forms.TextBox()
        Me.TxtGPSOutDD = New System.Windows.Forms.TextBox()
        Me.TxtMaskGPSInputLonSec = New System.Windows.Forms.MaskedTextBox()
        Me.BtnConvertGPSInput = New System.Windows.Forms.Button()
        Me.TxtMaskGPSInputLatSec = New System.Windows.Forms.MaskedTextBox()
        Me.CmbGPSInputWE = New System.Windows.Forms.ComboBox()
        Me.CmbGPSInputNS = New System.Windows.Forms.ComboBox()
        Me.TxtGPSInputLatMin = New System.Windows.Forms.TextBox()
        Me.TxtGPSInputLonDeg = New System.Windows.Forms.TextBox()
        Me.TxtGPSInputLonMin = New System.Windows.Forms.TextBox()
        Me.TxtGPSInputLatDeg = New System.Windows.Forms.TextBox()
        Me.GrpLocateLatLon = New System.Windows.Forms.GroupBox()
        Me.BtnShowOnMapXY = New System.Windows.Forms.Button()
        Me.LblY = New System.Windows.Forms.Label()
        Me.LblLonDMS = New System.Windows.Forms.Label()
        Me.LblLatDMS = New System.Windows.Forms.Label()
        Me.LblX = New System.Windows.Forms.Label()
        Me.TxtY = New System.Windows.Forms.TextBox()
        Me.TxtLonDMS = New System.Windows.Forms.TextBox()
        Me.TxtLatDMS = New System.Windows.Forms.TextBox()
        Me.TxtX = New System.Windows.Forms.TextBox()
        Me.LblLonDD = New System.Windows.Forms.Label()
        Me.LblLatDD = New System.Windows.Forms.Label()
        Me.TxtLonDD = New System.Windows.Forms.TextBox()
        Me.TxtLatDD = New System.Windows.Forms.TextBox()
        Me.GrpZoom = New System.Windows.Forms.GroupBox()
        Me.LabelZoomFactor = New System.Windows.Forms.Label()
        Me.TrbZoom = New System.Windows.Forms.TrackBar()
        Me.PicboxZoom = New System.Windows.Forms.PictureBox()
        Me.PicboxMap = New System.Windows.Forms.PictureBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageSettings = New System.Windows.Forms.TabPage()
        Me.GrpPenColor = New System.Windows.Forms.GroupBox()
        Me.TxtPenColor = New System.Windows.Forms.TextBox()
        Me.BtnSelectPenColor = New System.Windows.Forms.Button()
        Me.GrpMapSettings = New System.Windows.Forms.GroupBox()
        Me.LblMapImgFilename = New System.Windows.Forms.Label()
        Me.TxtMapImgFilename = New System.Windows.Forms.TextBox()
        Me.TxtMapH = New System.Windows.Forms.TextBox()
        Me.TxtMapW = New System.Windows.Forms.TextBox()
        Me.LblMapHpx = New System.Windows.Forms.Label()
        Me.BtnBrowseMapImage = New System.Windows.Forms.Button()
        Me.LblMapWpx = New System.Windows.Forms.Label()
        Me.FrmMainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPageMap.SuspendLayout()
        Me.GrpGPSInput.SuspendLayout()
        Me.GrpLocateLatLon.SuspendLayout()
        Me.GrpZoom.SuspendLayout()
        CType(Me.TrbZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicboxZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicboxMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabPageSettings.SuspendLayout()
        Me.GrpPenColor.SuspendLayout()
        Me.GrpMapSettings.SuspendLayout()
        CType(Me.FrmMainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPageMap
        '
        Me.TabPageMap.Controls.Add(Me.GrpGPSInput)
        Me.TabPageMap.Controls.Add(Me.GrpLocateLatLon)
        Me.TabPageMap.Controls.Add(Me.GrpZoom)
        Me.TabPageMap.Controls.Add(Me.PicboxMap)
        Me.TabPageMap.Location = New System.Drawing.Point(4, 22)
        Me.TabPageMap.Name = "TabPageMap"
        Me.TabPageMap.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMap.Size = New System.Drawing.Size(881, 716)
        Me.TabPageMap.TabIndex = 0
        Me.TabPageMap.Text = "Map"
        Me.TabPageMap.UseVisualStyleBackColor = True
        '
        'GrpGPSInput
        '
        Me.GrpGPSInput.Controls.Add(Me.TxtGPSOutXY)
        Me.GrpGPSInput.Controls.Add(Me.TxtGPSOutDMS)
        Me.GrpGPSInput.Controls.Add(Me.TxtGPSOutDD)
        Me.GrpGPSInput.Controls.Add(Me.TxtMaskGPSInputLonSec)
        Me.GrpGPSInput.Controls.Add(Me.BtnConvertGPSInput)
        Me.GrpGPSInput.Controls.Add(Me.TxtMaskGPSInputLatSec)
        Me.GrpGPSInput.Controls.Add(Me.CmbGPSInputWE)
        Me.GrpGPSInput.Controls.Add(Me.CmbGPSInputNS)
        Me.GrpGPSInput.Controls.Add(Me.TxtGPSInputLatMin)
        Me.GrpGPSInput.Controls.Add(Me.TxtGPSInputLonDeg)
        Me.GrpGPSInput.Controls.Add(Me.TxtGPSInputLonMin)
        Me.GrpGPSInput.Controls.Add(Me.TxtGPSInputLatDeg)
        Me.GrpGPSInput.Location = New System.Drawing.Point(712, 473)
        Me.GrpGPSInput.Name = "GrpGPSInput"
        Me.GrpGPSInput.Size = New System.Drawing.Size(158, 233)
        Me.GrpGPSInput.TabIndex = 9
        Me.GrpGPSInput.TabStop = False
        Me.GrpGPSInput.Text = "GPS INPUT"
        '
        'TxtGPSOutXY
        '
        Me.TxtGPSOutXY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGPSOutXY.Location = New System.Drawing.Point(7, 153)
        Me.TxtGPSOutXY.Name = "TxtGPSOutXY"
        Me.TxtGPSOutXY.ReadOnly = True
        Me.TxtGPSOutXY.Size = New System.Drawing.Size(145, 20)
        Me.TxtGPSOutXY.TabIndex = 3
        '
        'TxtGPSOutDMS
        '
        Me.TxtGPSOutDMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGPSOutDMS.Location = New System.Drawing.Point(7, 101)
        Me.TxtGPSOutDMS.Name = "TxtGPSOutDMS"
        Me.TxtGPSOutDMS.ReadOnly = True
        Me.TxtGPSOutDMS.Size = New System.Drawing.Size(145, 20)
        Me.TxtGPSOutDMS.TabIndex = 1
        '
        'TxtGPSOutDD
        '
        Me.TxtGPSOutDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGPSOutDD.Location = New System.Drawing.Point(7, 127)
        Me.TxtGPSOutDD.Name = "TxtGPSOutDD"
        Me.TxtGPSOutDD.ReadOnly = True
        Me.TxtGPSOutDD.Size = New System.Drawing.Size(145, 20)
        Me.TxtGPSOutDD.TabIndex = 2
        '
        'TxtMaskGPSInputLonSec
        '
        Me.TxtMaskGPSInputLonSec.Culture = New System.Globalization.CultureInfo("en-US")
        Me.TxtMaskGPSInputLonSec.Location = New System.Drawing.Point(114, 44)
        Me.TxtMaskGPSInputLonSec.Mask = "##,0"
        Me.TxtMaskGPSInputLonSec.Name = "TxtMaskGPSInputLonSec"
        Me.TxtMaskGPSInputLonSec.Size = New System.Drawing.Size(38, 20)
        Me.TxtMaskGPSInputLonSec.TabIndex = 5
        Me.TxtMaskGPSInputLonSec.Text = "406"
        '
        'BtnConvertGPSInput
        '
        Me.BtnConvertGPSInput.Location = New System.Drawing.Point(7, 72)
        Me.BtnConvertGPSInput.Name = "BtnConvertGPSInput"
        Me.BtnConvertGPSInput.Size = New System.Drawing.Size(148, 23)
        Me.BtnConvertGPSInput.TabIndex = 10
        Me.BtnConvertGPSInput.Text = "Convert GPS data"
        Me.BtnConvertGPSInput.UseVisualStyleBackColor = True
        '
        'TxtMaskGPSInputLatSec
        '
        Me.TxtMaskGPSInputLatSec.Culture = New System.Globalization.CultureInfo("en-US")
        Me.TxtMaskGPSInputLatSec.Location = New System.Drawing.Point(114, 17)
        Me.TxtMaskGPSInputLatSec.Mask = "##,0"
        Me.TxtMaskGPSInputLatSec.Name = "TxtMaskGPSInputLatSec"
        Me.TxtMaskGPSInputLatSec.Size = New System.Drawing.Size(38, 20)
        Me.TxtMaskGPSInputLatSec.TabIndex = 4
        Me.TxtMaskGPSInputLatSec.Text = "425"
        '
        'CmbGPSInputWE
        '
        Me.CmbGPSInputWE.FormattingEnabled = True
        Me.CmbGPSInputWE.Items.AddRange(New Object() {"W", "E"})
        Me.CmbGPSInputWE.Location = New System.Drawing.Point(7, 44)
        Me.CmbGPSInputWE.Name = "CmbGPSInputWE"
        Me.CmbGPSInputWE.Size = New System.Drawing.Size(34, 21)
        Me.CmbGPSInputWE.TabIndex = 9
        Me.CmbGPSInputWE.Text = "W"
        '
        'CmbGPSInputNS
        '
        Me.CmbGPSInputNS.FormattingEnabled = True
        Me.CmbGPSInputNS.Items.AddRange(New Object() {"N", "S"})
        Me.CmbGPSInputNS.Location = New System.Drawing.Point(7, 17)
        Me.CmbGPSInputNS.Name = "CmbGPSInputNS"
        Me.CmbGPSInputNS.Size = New System.Drawing.Size(34, 21)
        Me.CmbGPSInputNS.TabIndex = 8
        Me.CmbGPSInputNS.Text = "N"
        '
        'TxtGPSInputLatMin
        '
        Me.TxtGPSInputLatMin.Location = New System.Drawing.Point(81, 17)
        Me.TxtGPSInputLatMin.Name = "TxtGPSInputLatMin"
        Me.TxtGPSInputLatMin.Size = New System.Drawing.Size(27, 20)
        Me.TxtGPSInputLatMin.TabIndex = 5
        Me.TxtGPSInputLatMin.Text = "36"
        '
        'TxtGPSInputLonDeg
        '
        Me.TxtGPSInputLonDeg.Location = New System.Drawing.Point(47, 44)
        Me.TxtGPSInputLonDeg.Name = "TxtGPSInputLonDeg"
        Me.TxtGPSInputLonDeg.Size = New System.Drawing.Size(28, 20)
        Me.TxtGPSInputLonDeg.TabIndex = 3
        Me.TxtGPSInputLonDeg.Text = "122"
        '
        'TxtGPSInputLonMin
        '
        Me.TxtGPSInputLonMin.Location = New System.Drawing.Point(81, 44)
        Me.TxtGPSInputLonMin.Name = "TxtGPSInputLonMin"
        Me.TxtGPSInputLonMin.Size = New System.Drawing.Size(27, 20)
        Me.TxtGPSInputLonMin.TabIndex = 2
        Me.TxtGPSInputLonMin.Text = "57"
        '
        'TxtGPSInputLatDeg
        '
        Me.TxtGPSInputLatDeg.Location = New System.Drawing.Point(47, 17)
        Me.TxtGPSInputLatDeg.Name = "TxtGPSInputLatDeg"
        Me.TxtGPSInputLatDeg.Size = New System.Drawing.Size(28, 20)
        Me.TxtGPSInputLatDeg.TabIndex = 1
        Me.TxtGPSInputLatDeg.Text = "48"
        '
        'GrpLocateLatLon
        '
        Me.GrpLocateLatLon.Controls.Add(Me.BtnShowOnMapXY)
        Me.GrpLocateLatLon.Controls.Add(Me.LblY)
        Me.GrpLocateLatLon.Controls.Add(Me.LblLonDMS)
        Me.GrpLocateLatLon.Controls.Add(Me.LblLatDMS)
        Me.GrpLocateLatLon.Controls.Add(Me.LblX)
        Me.GrpLocateLatLon.Controls.Add(Me.TxtY)
        Me.GrpLocateLatLon.Controls.Add(Me.TxtLonDMS)
        Me.GrpLocateLatLon.Controls.Add(Me.TxtLatDMS)
        Me.GrpLocateLatLon.Controls.Add(Me.TxtX)
        Me.GrpLocateLatLon.Controls.Add(Me.LblLonDD)
        Me.GrpLocateLatLon.Controls.Add(Me.LblLatDD)
        Me.GrpLocateLatLon.Controls.Add(Me.TxtLonDD)
        Me.GrpLocateLatLon.Controls.Add(Me.TxtLatDD)
        Me.GrpLocateLatLon.Location = New System.Drawing.Point(712, 260)
        Me.GrpLocateLatLon.Name = "GrpLocateLatLon"
        Me.GrpLocateLatLon.Size = New System.Drawing.Size(158, 207)
        Me.GrpLocateLatLon.TabIndex = 5
        Me.GrpLocateLatLon.TabStop = False
        Me.GrpLocateLatLon.Text = "LOCATION"
        '
        'BtnShowOnMapXY
        '
        Me.BtnShowOnMapXY.Location = New System.Drawing.Point(7, 175)
        Me.BtnShowOnMapXY.Name = "BtnShowOnMapXY"
        Me.BtnShowOnMapXY.Size = New System.Drawing.Size(145, 23)
        Me.BtnShowOnMapXY.TabIndex = 2
        Me.BtnShowOnMapXY.Text = "Show on map"
        Me.BtnShowOnMapXY.UseVisualStyleBackColor = True
        '
        'LblY
        '
        Me.LblY.AutoSize = True
        Me.LblY.Location = New System.Drawing.Point(10, 150)
        Me.LblY.Name = "LblY"
        Me.LblY.Size = New System.Drawing.Size(12, 13)
        Me.LblY.TabIndex = 4
        Me.LblY.Text = "y"
        '
        'LblLonDMS
        '
        Me.LblLonDMS.AutoSize = True
        Me.LblLonDMS.Location = New System.Drawing.Point(10, 100)
        Me.LblLonDMS.Name = "LblLonDMS"
        Me.LblLonDMS.Size = New System.Drawing.Size(21, 13)
        Me.LblLonDMS.TabIndex = 8
        Me.LblLonDMS.Text = "lon"
        '
        'LblLatDMS
        '
        Me.LblLatDMS.AutoSize = True
        Me.LblLatDMS.Location = New System.Drawing.Point(10, 75)
        Me.LblLatDMS.Name = "LblLatDMS"
        Me.LblLatDMS.Size = New System.Drawing.Size(18, 13)
        Me.LblLatDMS.TabIndex = 7
        Me.LblLatDMS.Text = "lat"
        '
        'LblX
        '
        Me.LblX.AutoSize = True
        Me.LblX.Location = New System.Drawing.Point(10, 125)
        Me.LblX.Name = "LblX"
        Me.LblX.Size = New System.Drawing.Size(12, 13)
        Me.LblX.TabIndex = 3
        Me.LblX.Text = "x"
        '
        'TxtY
        '
        Me.TxtY.Location = New System.Drawing.Point(37, 149)
        Me.TxtY.Name = "TxtY"
        Me.TxtY.Size = New System.Drawing.Size(115, 20)
        Me.TxtY.TabIndex = 1
        '
        'TxtLonDMS
        '
        Me.TxtLonDMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLonDMS.Location = New System.Drawing.Point(37, 97)
        Me.TxtLonDMS.Name = "TxtLonDMS"
        Me.TxtLonDMS.ReadOnly = True
        Me.TxtLonDMS.Size = New System.Drawing.Size(115, 20)
        Me.TxtLonDMS.TabIndex = 6
        '
        'TxtLatDMS
        '
        Me.TxtLatDMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLatDMS.Location = New System.Drawing.Point(37, 71)
        Me.TxtLatDMS.Name = "TxtLatDMS"
        Me.TxtLatDMS.ReadOnly = True
        Me.TxtLatDMS.Size = New System.Drawing.Size(115, 20)
        Me.TxtLatDMS.TabIndex = 5
        '
        'TxtX
        '
        Me.TxtX.Location = New System.Drawing.Point(37, 123)
        Me.TxtX.Name = "TxtX"
        Me.TxtX.Size = New System.Drawing.Size(115, 20)
        Me.TxtX.TabIndex = 0
        '
        'LblLonDD
        '
        Me.LblLonDD.AutoSize = True
        Me.LblLonDD.Location = New System.Drawing.Point(10, 50)
        Me.LblLonDD.Name = "LblLonDD"
        Me.LblLonDD.Size = New System.Drawing.Size(21, 13)
        Me.LblLonDD.TabIndex = 3
        Me.LblLonDD.Text = "lon"
        '
        'LblLatDD
        '
        Me.LblLatDD.AutoSize = True
        Me.LblLatDD.Location = New System.Drawing.Point(10, 25)
        Me.LblLatDD.Name = "LblLatDD"
        Me.LblLatDD.Size = New System.Drawing.Size(18, 13)
        Me.LblLatDD.TabIndex = 2
        Me.LblLatDD.Text = "lat"
        '
        'TxtLonDD
        '
        Me.TxtLonDD.Location = New System.Drawing.Point(37, 45)
        Me.TxtLonDD.Name = "TxtLonDD"
        Me.TxtLonDD.Size = New System.Drawing.Size(115, 20)
        Me.TxtLonDD.TabIndex = 1
        '
        'TxtLatDD
        '
        Me.TxtLatDD.Location = New System.Drawing.Point(37, 19)
        Me.TxtLatDD.Name = "TxtLatDD"
        Me.TxtLatDD.Size = New System.Drawing.Size(115, 20)
        Me.TxtLatDD.TabIndex = 0
        '
        'GrpZoom
        '
        Me.GrpZoom.Controls.Add(Me.LabelZoomFactor)
        Me.GrpZoom.Controls.Add(Me.TrbZoom)
        Me.GrpZoom.Controls.Add(Me.PicboxZoom)
        Me.GrpZoom.Location = New System.Drawing.Point(712, 6)
        Me.GrpZoom.Name = "GrpZoom"
        Me.GrpZoom.Size = New System.Drawing.Size(158, 248)
        Me.GrpZoom.TabIndex = 1
        Me.GrpZoom.TabStop = False
        Me.GrpZoom.Text = "ZOOM"
        '
        'LabelZoomFactor
        '
        Me.LabelZoomFactor.AutoSize = True
        Me.LabelZoomFactor.Location = New System.Drawing.Point(7, 223)
        Me.LabelZoomFactor.Name = "LabelZoomFactor"
        Me.LabelZoomFactor.Size = New System.Drawing.Size(49, 13)
        Me.LabelZoomFactor.TabIndex = 2
        Me.LabelZoomFactor.Text = "zoom: x3"
        '
        'TrbZoom
        '
        Me.TrbZoom.LargeChange = 1
        Me.TrbZoom.Location = New System.Drawing.Point(7, 171)
        Me.TrbZoom.Maximum = 6
        Me.TrbZoom.Minimum = 2
        Me.TrbZoom.Name = "TrbZoom"
        Me.TrbZoom.Size = New System.Drawing.Size(145, 45)
        Me.TrbZoom.TabIndex = 1
        Me.TrbZoom.Value = 3
        '
        'PicboxZoom
        '
        Me.PicboxZoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicboxZoom.Location = New System.Drawing.Point(6, 19)
        Me.PicboxZoom.Name = "PicboxZoom"
        Me.PicboxZoom.Size = New System.Drawing.Size(146, 146)
        Me.PicboxZoom.TabIndex = 0
        Me.PicboxZoom.TabStop = False
        '
        'PicboxMap
        '
        Me.PicboxMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicboxMap.InitialImage = Nothing
        Me.PicboxMap.Location = New System.Drawing.Point(6, 6)
        Me.PicboxMap.Name = "PicboxMap"
        Me.PicboxMap.Size = New System.Drawing.Size(700, 700)
        Me.PicboxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicboxMap.TabIndex = 0
        Me.PicboxMap.TabStop = False
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPageSettings)
        Me.TabControl.Controls.Add(Me.TabPageMap)
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(889, 742)
        Me.TabControl.TabIndex = 0
        '
        'TabPageSettings
        '
        Me.TabPageSettings.Controls.Add(Me.GrpPenColor)
        Me.TabPageSettings.Controls.Add(Me.GrpMapSettings)
        Me.TabPageSettings.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSettings.Name = "TabPageSettings"
        Me.TabPageSettings.Size = New System.Drawing.Size(881, 716)
        Me.TabPageSettings.TabIndex = 2
        Me.TabPageSettings.Text = "Settings"
        Me.TabPageSettings.UseVisualStyleBackColor = True
        '
        'GrpPenColor
        '
        Me.GrpPenColor.Controls.Add(Me.TxtPenColor)
        Me.GrpPenColor.Controls.Add(Me.BtnSelectPenColor)
        Me.GrpPenColor.Location = New System.Drawing.Point(14, 172)
        Me.GrpPenColor.Name = "GrpPenColor"
        Me.GrpPenColor.Size = New System.Drawing.Size(158, 56)
        Me.GrpPenColor.TabIndex = 5
        Me.GrpPenColor.TabStop = False
        Me.GrpPenColor.Text = "PEN COLOR"
        '
        'TxtPenColor
        '
        Me.TxtPenColor.Location = New System.Drawing.Point(132, 22)
        Me.TxtPenColor.Name = "TxtPenColor"
        Me.TxtPenColor.Size = New System.Drawing.Size(20, 20)
        Me.TxtPenColor.TabIndex = 1
        '
        'BtnSelectPenColor
        '
        Me.BtnSelectPenColor.Location = New System.Drawing.Point(7, 20)
        Me.BtnSelectPenColor.Name = "BtnSelectPenColor"
        Me.BtnSelectPenColor.Size = New System.Drawing.Size(119, 23)
        Me.BtnSelectPenColor.TabIndex = 0
        Me.BtnSelectPenColor.Text = "Select color"
        Me.BtnSelectPenColor.UseVisualStyleBackColor = True
        '
        'GrpMapSettings
        '
        Me.GrpMapSettings.Controls.Add(Me.LblMapImgFilename)
        Me.GrpMapSettings.Controls.Add(Me.TxtMapImgFilename)
        Me.GrpMapSettings.Controls.Add(Me.TxtMapH)
        Me.GrpMapSettings.Controls.Add(Me.TxtMapW)
        Me.GrpMapSettings.Controls.Add(Me.LblMapHpx)
        Me.GrpMapSettings.Controls.Add(Me.BtnBrowseMapImage)
        Me.GrpMapSettings.Controls.Add(Me.LblMapWpx)
        Me.GrpMapSettings.Location = New System.Drawing.Point(14, 18)
        Me.GrpMapSettings.Name = "GrpMapSettings"
        Me.GrpMapSettings.Size = New System.Drawing.Size(432, 137)
        Me.GrpMapSettings.TabIndex = 3
        Me.GrpMapSettings.TabStop = False
        Me.GrpMapSettings.Text = "MAP INFO"
        '
        'LblMapImgFilename
        '
        Me.LblMapImgFilename.AutoSize = True
        Me.LblMapImgFilename.Location = New System.Drawing.Point(6, 110)
        Me.LblMapImgFilename.Name = "LblMapImgFilename"
        Me.LblMapImgFilename.Size = New System.Drawing.Size(46, 13)
        Me.LblMapImgFilename.TabIndex = 6
        Me.LblMapImgFilename.Text = "filename"
        '
        'TxtMapImgFilename
        '
        Me.TxtMapImgFilename.Location = New System.Drawing.Point(58, 103)
        Me.TxtMapImgFilename.Name = "TxtMapImgFilename"
        Me.TxtMapImgFilename.ReadOnly = True
        Me.TxtMapImgFilename.Size = New System.Drawing.Size(363, 20)
        Me.TxtMapImgFilename.TabIndex = 5
        '
        'TxtMapH
        '
        Me.TxtMapH.Location = New System.Drawing.Point(58, 77)
        Me.TxtMapH.Name = "TxtMapH"
        Me.TxtMapH.ReadOnly = True
        Me.TxtMapH.Size = New System.Drawing.Size(94, 20)
        Me.TxtMapH.TabIndex = 2
        '
        'TxtMapW
        '
        Me.TxtMapW.Location = New System.Drawing.Point(58, 51)
        Me.TxtMapW.Name = "TxtMapW"
        Me.TxtMapW.ReadOnly = True
        Me.TxtMapW.Size = New System.Drawing.Size(94, 20)
        Me.TxtMapW.TabIndex = 1
        '
        'LblMapHpx
        '
        Me.LblMapHpx.AutoSize = True
        Me.LblMapHpx.Location = New System.Drawing.Point(6, 80)
        Me.LblMapHpx.Name = "LblMapHpx"
        Me.LblMapHpx.Size = New System.Drawing.Size(50, 13)
        Me.LblMapHpx.TabIndex = 4
        Me.LblMapHpx.Text = "px heigth"
        '
        'BtnBrowseMapImage
        '
        Me.BtnBrowseMapImage.Location = New System.Drawing.Point(7, 20)
        Me.BtnBrowseMapImage.Name = "BtnBrowseMapImage"
        Me.BtnBrowseMapImage.Size = New System.Drawing.Size(145, 23)
        Me.BtnBrowseMapImage.TabIndex = 0
        Me.BtnBrowseMapImage.Text = "Browse map image"
        Me.BtnBrowseMapImage.UseVisualStyleBackColor = True
        '
        'LblMapWpx
        '
        Me.LblMapWpx.AutoSize = True
        Me.LblMapWpx.Location = New System.Drawing.Point(6, 54)
        Me.LblMapWpx.Name = "LblMapWpx"
        Me.LblMapWpx.Size = New System.Drawing.Size(46, 13)
        Me.LblMapWpx.TabIndex = 3
        Me.LblMapWpx.Text = "px width"
        '
        'FrmMainBindingSource
        '
        Me.FrmMainBindingSource.DataSource = GetType(MiscreatedGeolocationKit.FrmMain)
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 774)
        Me.Controls.Add(Me.TabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.Text = "Miscreated GPS Kit"
        Me.TabPageMap.ResumeLayout(False)
        Me.GrpGPSInput.ResumeLayout(False)
        Me.GrpGPSInput.PerformLayout()
        Me.GrpLocateLatLon.ResumeLayout(False)
        Me.GrpLocateLatLon.PerformLayout()
        Me.GrpZoom.ResumeLayout(False)
        Me.GrpZoom.PerformLayout()
        CType(Me.TrbZoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicboxZoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicboxMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabPageSettings.ResumeLayout(False)
        Me.GrpPenColor.ResumeLayout(False)
        Me.GrpPenColor.PerformLayout()
        Me.GrpMapSettings.ResumeLayout(False)
        Me.GrpMapSettings.PerformLayout()
        CType(Me.FrmMainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FrmMainBindingSource As BindingSource
    Friend WithEvents TabPageMap As TabPage
    Friend WithEvents GrpLocateLatLon As GroupBox
    Friend WithEvents LblLonDD As Label
    Friend WithEvents LblLatDD As Label
    Friend WithEvents TxtLonDD As TextBox
    Friend WithEvents TxtLatDD As TextBox
    Friend WithEvents LblY As Label
    Friend WithEvents BtnShowOnMapXY As Button
    Friend WithEvents TxtY As TextBox
    Friend WithEvents LblX As Label
    Friend WithEvents TxtX As TextBox
    Friend WithEvents GrpZoom As GroupBox
    Friend WithEvents LabelZoomFactor As Label
    Friend WithEvents TrbZoom As TrackBar
    Friend WithEvents PicboxZoom As PictureBox
    Friend WithEvents PicboxMap As PictureBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents LblLonDMS As Label
    Friend WithEvents LblLatDMS As Label
    Friend WithEvents TxtLonDMS As TextBox
    Friend WithEvents TxtLatDMS As TextBox
    Friend WithEvents TabPageSettings As TabPage
    Friend WithEvents GrpPenColor As GroupBox
    Friend WithEvents TxtPenColor As TextBox
    Friend WithEvents BtnSelectPenColor As Button
    Friend WithEvents GrpMapSettings As GroupBox
    Friend WithEvents LblMapImgFilename As Label
    Friend WithEvents TxtMapImgFilename As TextBox
    Friend WithEvents TxtMapH As TextBox
    Friend WithEvents TxtMapW As TextBox
    Friend WithEvents LblMapHpx As Label
    Friend WithEvents BtnBrowseMapImage As Button
    Friend WithEvents LblMapWpx As Label
    Friend WithEvents TxtGPSOutDMS As TextBox
    Friend WithEvents TxtGPSOutXY As TextBox
    Friend WithEvents TxtGPSOutDD As TextBox
    Friend WithEvents GrpGPSInput As GroupBox
    Friend WithEvents TxtMaskGPSInputLonSec As MaskedTextBox
    Friend WithEvents BtnConvertGPSInput As Button
    Friend WithEvents TxtMaskGPSInputLatSec As MaskedTextBox
    Friend WithEvents CmbGPSInputWE As ComboBox
    Friend WithEvents CmbGPSInputNS As ComboBox
    Friend WithEvents TxtGPSInputLatMin As TextBox
    Friend WithEvents TxtGPSInputLonDeg As TextBox
    Friend WithEvents TxtGPSInputLonMin As TextBox
    Friend WithEvents TxtGPSInputLatDeg As TextBox
End Class
