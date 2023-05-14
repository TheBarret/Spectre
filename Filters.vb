Public Class Filters

    Public Shared Sub LowPass(ByRef buffer() As Single, cutoff As Single, delta As Single)
        If (cutoff = 0) Then Return
        Dim dt As Single = delta
        Dim RC As Single = 1.0F / (2.0F * Math.PI * cutoff)
        Dim alpha As Single = dt / (dt + RC)
        Dim filtered As Single = buffer.First
        For i As Integer = 1 To buffer.Length - 1
            filtered = alpha * buffer(i) + (1 - alpha) * filtered
            buffer(i) = filtered
        Next
    End Sub

    Public Shared Sub HighPass(ByRef buffer() As Single, cutoff As Single, delta As Single)
        If (cutoff = 0) Then Return
        Dim dt As Single = delta
        Dim RC As Single = 1.0F / (2.0F * Math.PI * cutoff)
        Dim alpha As Single = RC / (dt + RC)
        Dim filtered As Single = buffer.First
        For i As Integer = 1 To buffer.Length - 1
            filtered = alpha * (filtered + buffer(i) - buffer(i - 1))
            buffer(i) = filtered
        Next
    End Sub

    Public Shared Sub Smooth(ByRef buffer() As Single, factor As Single, cutoff As Single)
        If factor = 0 Or cutoff = 0 Then Return
        Dim length As Integer = buffer.Length
        ' Apply smoothing to the buffer
        For i As Integer = 1 To length - 2
            buffer(i) = buffer(i - 1) * factor + buffer(i) * (1.0F - factor) + buffer(i + 1) * factor
        Next
        ' Remove sudden high or low peaks
        For i As Integer = 1 To length - 2
            If Math.Abs(buffer(i) - buffer(i - 1)) > cutoff AndAlso Math.Abs(buffer(i) - buffer(i + 1)) > cutoff Then
                buffer(i) = (buffer(i - 1) + buffer(i + 1)) / 2.0F
            End If
        Next
    End Sub


    Public Shared Sub BandPass(ByRef buffer() As Single, f1 As Single, f2 As Single, delta As Single)
        Filters.LowPass(buffer, f1, delta)
        Filters.HighPass(buffer, f2, delta)
    End Sub
End Class
