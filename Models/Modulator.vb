Imports System.Text

Public MustInherit Class Modulator
    Public ReadOnly Property Phase As Single
    Public ReadOnly Property Carrier As Single
    Public ReadOnly Property Amplitude As Single
    Public ReadOnly Property Duration As Single
    Public ReadOnly Property Samplerate As Single
    Public MustOverride ReadOnly Property Name As String
    Public MustOverride Function Encode(message As String) As Boolean()
    Public MustOverride Function Decode(bits As Boolean()) As String
    Public MustOverride Function Modulate(bits() As Boolean) As Single()
    Public MustOverride Function Demodulate(signal() As Single) As Boolean()

    Sub New()
        Me.Amplitude = 1.0F
        Me.Duration = 1.0F
        Me.Carrier = 1.0F
        Me.Samplerate = 8.0F
    End Sub

    Sub New(duration As Single, sampleRate As Single, carrier As Single, amplitude As Single, phase As Single)
        Me.Duration = duration
        Me.Samplerate = sampleRate
        Me.Carrier = carrier
        Me.Phase = phase
        Me.Amplitude = amplitude
    End Sub

End Class
