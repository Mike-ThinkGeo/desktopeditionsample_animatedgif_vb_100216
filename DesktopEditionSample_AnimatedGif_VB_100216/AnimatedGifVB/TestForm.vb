Imports System
Imports System.Windows.Forms
Imports ThinkGeo.MapSuite.Core
Imports ThinkGeo.MapSuite.DesktopEdition

Public Class TestForm
    Private gifFrameTimer As Timer

    Private Sub TestForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gifFrameTimer = New Timer()
        gifFrameTimer.Interval = 200
        AddHandler gifFrameTimer.Tick, AddressOf gifFrameTimer_Tick

        WinformsMap1.MapUnit = GeographyUnit.DecimalDegree
        WinformsMap1.BackgroundOverlay.BackgroundBrush = New GeoSolidBrush(GeoColor.GeographicColors.ShallowOcean)

        Dim worldMapKitDesktopOverlay As New WorldMapKitWmsDesktopOverlay()
        WinformsMap1.Overlays.Add(worldMapKitDesktopOverlay)

        Dim canadaLayer As New AnimatedGifInMemoryFeatureLayer("..\..\Data\canadaC.gif")
        canadaLayer.InternalFeatures.Add(New Feature(New PointShape(-103.28, 57.25)))

        Dim usaLayer As New AnimatedGifInMemoryFeatureLayer("..\..\Data\usaCa.gif")
        usaLayer.InternalFeatures.Add(New Feature(New PointShape(-97.48, 38.44)))

        Dim mexicoLayer As New AnimatedGifInMemoryFeatureLayer("..\..\Data\mexicof3b.gif")
        mexicoLayer.InternalFeatures.Add(New Feature(New PointShape(-100.64, 17.88)))

        Dim animatedGifOverlay As New LayerOverlay()
        animatedGifOverlay.Layers.Add("Canada", canadaLayer)
        animatedGifOverlay.Layers.Add("USA", usaLayer)
        animatedGifOverlay.Layers.Add("Mexico", mexicoLayer)

        WinformsMap1.Overlays.Add("AnimatedGif", animatedGifOverlay)

        WinformsMap1.CurrentExtent = New RectangleShape(-136.32, 65.03, -39.29, -0.88)
        WinformsMap1.Refresh()


        gifFrameTimer.Start()
    End Sub

    Private Sub gifFrameTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        'Updates the animated gif with the next frame of each AnimatedGifInMemoryFeaturelayer at each timer click event
        Dim layerOverlay As LayerOverlay = DirectCast(winformsMap1.Overlays("AnimatedGif"), LayerOverlay)
        For Each inMemoryFeatureLayer As AnimatedGifInMemoryFeatureLayer In layerOverlay.Layers
            inMemoryFeatureLayer.UpdateAnimatedGif()
            winformsMap1.Refresh(winformsMap1.Overlays("AnimatedGif"))
        Next
    End Sub

End Class