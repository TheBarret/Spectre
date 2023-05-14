Public Class Labeler
    Public Property Font As Font
    Public Property Sample As Single()

    Sub New(sample As Single())
        Me.Sample = sample
        Me.Font = New Font("Consolans", 7)
    End Sub

    Public Sub Analyse(bm As Bitmap, g As Graphics)
        Dim analysis As String = Me.GetAnalysis()
        Dim labels As SizeF = g.MeasureString(analysis, Me.Font)
        Dim background As New RectangleF(5, bm.Height - (labels.Height + 100), labels.Width + 1, labels.Height)
        g.FillRectangle(Brushes.White, background)
        g.DrawString(analysis, Me.Font, Brushes.Black, background)
    End Sub

    Private Function GetAnalysis() As String
        Dim mean As Single = Me.CalculateMean()
        Dim stdDev As Single = Me.CalculateStandardDeviation()
        Dim entrp As Single = Me.CalculateEntropy
        Dim samples As Integer = Me.Sample.Length
        Return $"Samples: {samples} Mean: {mean:F2}, Standard Deviation: {stdDev:F2} Entropy: {entrp:F2}"
    End Function

    Private Function CalculateMean() As Single
        Dim sum As Single = 0
        For Each value As Single In Sample
            sum += value
        Next
        Return sum / Sample.Length
    End Function

    Private Function CalculateStandardDeviation() As Single
        Dim mean As Single = CalculateMean()
        Dim sumOfSquares As Single = 0
        For Each value As Single In Sample
            sumOfSquares += (value - mean) * (value - mean)
        Next
        Return Math.Sqrt(sumOfSquares / Sample.Length)
    End Function

    Public Function CalculateEntropy() As Double
        Dim counts As New Dictionary(Of Single, Integer)()
        For Each value As Single In Me.Sample
            If counts.ContainsKey(value) Then
                counts(value) += 1
            Else
                counts(value) = 1
            End If
        Next
        Dim totalSamples As Integer = Me.Sample.Length
        Dim probabilities As New Dictionary(Of Single, Double)()
        For Each kvp As KeyValuePair(Of Single, Integer) In counts
            Dim probability As Double = kvp.Value / totalSamples
            probabilities(kvp.Key) = probability
        Next
        Dim entropy As Double = 0.0
        For Each probability As Double In probabilities.Values
            entropy -= probability * Math.Log(probability, 2)
        Next
        Return entropy
    End Function


End Class
