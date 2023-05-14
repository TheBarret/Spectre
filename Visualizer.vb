Public Class Visualizer
    Public Property Bounds As Rectangle
    Public Property SignalColor As Color
    Public Property GridColor As Color
    Sub New(bounds As Rectangle)
        Me.Bounds = bounds
        Me.SignalColor = Color.Navy
        Me.GridColor = Color.Plum
    End Sub

    Public Function Render(samples() As Single) As Bitmap
        Using bm As New Bitmap(Me.Bounds.Width, Me.Bounds.Height)
            Using g As Graphics = Graphics.FromImage(bm)
                g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                Using p As New Pen(Me.SignalColor) With {.DashStyle = Drawing2D.DashStyle.Solid}
                    Using gpen As New Pen(Me.GridColor) With {.DashStyle = Drawing2D.DashStyle.Dot}
                        ' Calculate the scaling factors for the x and y axes
                        Dim scaleX As Single = CSng(Me.Bounds.Width / (samples.Length - 1))
                        Dim scaleY As Single = CSng(Me.Bounds.Height / 2)

                        ' Set the origin to the left base of the drawing area
                        g.TranslateTransform(0, Me.Bounds.Height \ 2)

                        ' Draw the x-axis
                        g.DrawLine(p, 0, 0, Me.Bounds.Width, 0)

                        ' Draw the y-axis
                        g.DrawLine(p, 0, -Me.Bounds.Height \ 2, 0, Me.Bounds.Height \ 2)

                        ' Draw the grid
                        Dim gridStepX As Integer = CInt(Math.Ceiling((samples.Length - 1) / 10))
                        Dim gridStepY As Integer = CInt(Math.Ceiling(Me.Bounds.Height / 20))

                        For i As Integer = 0 To samples.Length - 1 Step gridStepX
                            g.DrawLine(gpen, i * scaleX, -Me.Bounds.Height \ 2, i * scaleX, Me.Bounds.Height \ 2)
                        Next

                        For i As Integer = -Me.Bounds.Height \ 2 To Me.Bounds.Height \ 2 Step gridStepY
                            g.DrawLine(gpen, 0, -i, Me.Bounds.Width, -i)
                        Next

                        ' Draw the sample data
                        For i As Integer = 1 To samples.Length - 1
                            Dim x1 As Single = (i - 1) * scaleX
                            Dim y1 As Single = samples(i - 1) * scaleY
                            Dim x2 As Single = i * scaleX
                            Dim y2 As Single = samples(i) * scaleY
                            g.DrawLine(p, x1, -y1, x2, -y2)
                        Next
                        Call New Labeler(samples).Analyse(bm, g)
                    End Using
                End Using
            End Using
            Return bm.Clone
        End Using
    End Function
End Class
