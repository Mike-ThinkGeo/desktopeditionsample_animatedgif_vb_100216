Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports ThinkGeo.MapSuite.Core

'Namespace AnimatedGifVB

Class AnimatedGifInMemoryFeatureLayer
    Inherits InMemoryFeatureLayer
    Private path As String
    Private bitmap As Bitmap
    Private frameCount As Integer
    Private currentFrameIndex As Integer
    Private dimension As FrameDimension

    Public Sub New(ByVal AnimatedGifPath As String)
        'Gets the characteristics of the animated gif such as the path, dimension, frame count etc.
        path = AnimatedGifPath
        currentFrameIndex = 0
        bitmap = New Bitmap(path)
        dimension = New FrameDimension(bitmap.FrameDimensionsList(0))
        frameCount = bitmap.GetFrameCount(dimension)

        'Sets the animated gif for all the zoom levels.
        'This class can be extended to have more zoom levels controls in the future.
        Me.ZoomLevelSet.ZoomLevel01.DefaultPointStyle.PointType = PointType.Bitmap
        Me.ZoomLevelSet.ZoomLevel01.DefaultPointStyle.Image = New GeoImage(AnimatedGifPath)
        Me.ZoomLevelSet.ZoomLevel01.ApplyUntilZoomLevel = ApplyUntilZoomLevel.Level20
    End Sub

    Public Sub UpdateAnimatedGif()
        'Updates the animated gif to show the next frame.
        currentFrameIndex += 1
        If currentFrameIndex >= frameCount Then
            currentFrameIndex = 0
        End If
        bitmap.SelectActiveFrame(dimension, currentFrameIndex)
        Dim stream As New MemoryStream()
        bitmap.Save(stream, ImageFormat.Png)

        Me.ZoomLevelSet.ZoomLevel01.DefaultPointStyle.Image = New GeoImage(stream)
    End Sub
End Class
'End Namespace
