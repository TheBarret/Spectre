
Public Class Generator
    Public Property Frequency As Single
    Public Property Samplerate As Single
    Public Property Amplitude As Single

    Sub New(freq As Single, sr As Single, ampl As Single)
        Me.Frequency = freq
        Me.Samplerate = sr
        Me.Amplitude = ampl
    End Sub

    Public Function Sinus(delta As Single) As Single()
        Dim samples As Integer = CInt(Me.Samplerate * delta)
        Dim result(samples - 1) As Single
        Dim angularFrequency As Single = 2.0F * Math.PI * Me.Frequency / Me.Samplerate
        For i As Integer = 0 To samples - 1
            result(i) = CSng(Amplitude * Math.Sin(angularFrequency * i))
        Next
        Return result
    End Function
End Class
