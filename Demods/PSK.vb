﻿Public Class PSK
    Inherits Modulator

    Sub New(duration As Single, sampleRate As Single, carrier As Single, amplitude As Single, phase As Single)
        MyBase.New(duration, sampleRate, carrier, amplitude, phase)
    End Sub

    Public Overrides Function Encode(message As String) As Boolean()
        Dim bits(message.Length * 8 - 1) As Boolean
        For i As Integer = 0 To message.Length - 1
            Dim charBits() As Boolean = PSK.ByteToBits(Strings.AscW(message(i)))
            Array.Copy(charBits, 0, bits, i * 8, 8)
        Next
        Return bits
    End Function

    Public Overrides Function Decode(bits() As Boolean) As String
        Dim numChars As Integer = bits.Length \ 8
        Dim message(numChars - 1) As Char
        For i As Integer = 0 To numChars - 1
            Dim charBits(7) As Boolean
            Array.Copy(bits, i * 8, charBits, 0, 8)
            message(i) = Strings.ChrW(PSK.BitsToByte(charBits))
        Next
        Return New String(message)
    End Function

    Public Overrides Function Modulate(bits() As Boolean) As Single()
        Dim samples As Integer = CInt(Me.Duration * Me.Samplerate)
        Dim signal(samples * bits.Length - 1) As Single
        Dim t As Single = Me.Duration
        Dim dt As Single = 1.0F / Me.Samplerate
        For i As Integer = 0 To bits.Length - 1
            Dim phaseOffset As Single = If(bits(i), 0, Me.Phase)
            Dim angularFrequency As Single = 2.0F * Math.PI * Me.Carrier
            For j As Integer = 0 To samples - 1
                signal(i * samples + j) = Math.Sin(angularFrequency * t + phaseOffset)
                t += dt
            Next
        Next
        Return signal
    End Function

    Public Overrides Function Demodulate(signal() As Single) As Boolean()
        Dim samples As Integer = CInt(Me.Duration * Me.Samplerate)
        Dim numBits As Integer = signal.Length \ samples
        Dim bits(numBits - 1) As Boolean
        Dim threshold As Single = Math.Sin(Me.Phase) * Me.Carrier
        Dim t As Single = Me.Duration
        Dim dt As Single = 1.0F / Me.Samplerate
        For i As Integer = 0 To numBits - 1
            Dim sum As Single = 0.0F
            For j As Integer = 0 To samples - 1
                sum += signal(i * samples + j) * Math.Sin(2.0F * Math.PI * Me.Carrier * t)
                t += dt
            Next
            bits(i) = sum >= threshold
        Next
        Return bits
    End Function

    ' Helper method to convert a byte to an array of bits
    Private Shared Function ByteToBits(value As Byte) As Boolean()
        Dim bits(7) As Boolean
        For i As Integer = 0 To 7
            bits(7 - i) = (value And (1 << i)) <> 0
        Next
        Return bits
    End Function

    ' Helper method to convert an array of bits to a byte
    Private Shared Function BitsToByte(bits() As Boolean) As Byte
        Dim value As Byte = 0
        For i As Integer = 0 To 7
            If bits(i) Then
                value = value Or (1 << (7 - i))
            End If
        Next
        Return value
    End Function

    Public Overrides ReadOnly Property Name As String
        Get
            Return "Binary Phase Shift Keying"
        End Get
    End Property
End Class
