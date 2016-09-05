<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.WinformsMap1 = New ThinkGeo.MapSuite.DesktopEdition.WinformsMap
        Me.SuspendLayout()
        '
        'WinformsMap1
        '
        Me.WinformsMap1.BackColor = System.Drawing.Color.White
        Me.WinformsMap1.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.[Default]
        Me.WinformsMap1.CurrentScale = 755957491.2
        Me.WinformsMap1.DrawingQuality = ThinkGeo.MapSuite.Core.DrawingQuality.[Default]
        Me.WinformsMap1.Location = New System.Drawing.Point(12, 12)
        Me.WinformsMap1.MapFocusMode = ThinkGeo.MapSuite.DesktopEdition.MapFocusMode.[Default]
        Me.WinformsMap1.MapResizeMode = ThinkGeo.MapSuite.Core.MapResizeMode.PreserveScale
        Me.WinformsMap1.MapUnit = ThinkGeo.MapSuite.Core.GeographyUnit.DecimalDegree
        Me.WinformsMap1.MaximumScale = 80000000000000
        Me.WinformsMap1.MinimumScale = 200
        Me.WinformsMap1.Name = "WinformsMap1"
        Me.WinformsMap1.Size = New System.Drawing.Size(688, 465)
        Me.WinformsMap1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Me.WinformsMap1.TabIndex = 0
        Me.WinformsMap1.Text = "WinformsMap1"
        Me.WinformsMap1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
        Me.WinformsMap1.ThreadingMode = ThinkGeo.MapSuite.DesktopEdition.MapThreadingMode.[Default]
        Me.WinformsMap1.ZoomLevelSnapping = ThinkGeo.MapSuite.DesktopEdition.ZoomLevelSnappingMode.[Default]
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 506)
        Me.Controls.Add(Me.WinformsMap1)
        Me.Name = "TestForm"
        Me.Text = "TestForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WinformsMap1 As ThinkGeo.MapSuite.DesktopEdition.WinformsMap
End Class
