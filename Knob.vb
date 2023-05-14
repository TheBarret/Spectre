Public Class Knob
    Inherits Panel
    Public Property Label As String
    Public Property Position As Single
    Public Property MinValue As Single
    Public Property MaxValue As Single
    Public Property CenterX As Single
    Public Property CenterY As Single
    Public Property Radius As Single
    Public Property RadiusM As Single
    Public Property LabelFont As Font
    Public Property LabelOffset As Single
    Sub New()

    End Sub

    Public Sub Setup(label As String, position As Single, minValue As Single, maxValue As Single, radius As Single, radiusM As Single, labelOffset As Single)
        Me.LabelFont = New Font("Consolas", 8)
        Me.Label = label
        Me.Position = position
        Me.MinValue = minValue
        Me.MaxValue = maxValue
        Me.CenterX = Me.Bounds.Width / 2
        Me.CenterY = Me.Bounds.Height / 2
        Me.Radius = radius
        Me.RadiusM = radiusM
        Me.LabelFont = LabelFont
        Me.LabelOffset = labelOffset
        Me.Draw()
    End Sub

    Public Sub UpdateKnob(value As Single)
        Me.Position = value
        Me.Draw()
    End Sub

    Public Sub Draw()
        Using bm As New Bitmap(Me.ClientRectangle.Width, Me.ClientRectangle.Height)
            Using g As Graphics = Graphics.FromImage(bm)
                ' Calculate the angle based on the position
                Dim angle As Single = (Position - MinValue) / (MaxValue - MinValue) * 270.0F + 135.0F
                ' Draw the knob
                g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                g.FillEllipse(Brushes.LightGray, CenterX - Me.Radius, CenterY - Me.Radius, 2 * Me.Radius, 2 * Me.Radius)
                g.DrawEllipse(Pens.Black, CenterX - Me.Radius, CenterY - Me.Radius, 2 * Me.Radius, 2 * Me.Radius)
                ' Draw the marker
                Dim markerX As Single = CenterX + Me.RadiusM * Math.Cos(angle * Math.PI / 180.0)
                Dim markerY As Single = CenterY + Me.RadiusM * Math.Sin(angle * Math.PI / 180.0)
                g.DrawLine(Pens.Red, CenterX, CenterY, markerX, markerY)
                g.FillEllipse(Brushes.Red, markerX - Me.RadiusM / 2.0F, markerY - Me.RadiusM / 2.0F, Me.RadiusM, Me.RadiusM)
                ' Draw the label
                Using sf As New StringFormat(StringFormatFlags.NoWrap)
                    Dim label As String = String.Format("{0}", Position.ToString("F2"))
                    Dim labelSize As SizeF = g.MeasureString(label, LabelFont)
                    Dim labelX As Single = CenterX - labelSize.Width / 2.0F
                    Dim labelY As Single = CenterY + Me.Radius + LabelOffset
                    g.DrawString(label, LabelFont, Brushes.Black, labelX, labelY)
                End Using
            End Using
            Me.BackgroundImage = CType(bm.Clone, Image)
        End Using
    End Sub

    Private Sub Knob_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If (e.Button = MouseButtons.Left) Then
            Me.Position += 10
        ElseIf (e.Button = MouseButtons.Right) Then
            Me.Position -= 10
        ElseIf (e.Button = MouseButtons.Middle) Then
            Me.Position -= 1.0
        End If
        Me.Draw()
    End Sub
End Class
