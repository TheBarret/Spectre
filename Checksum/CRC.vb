Public Class CRC

    Public Shared Sub Append(ByRef bits() As Boolean, crcBits() As Boolean)
        Dim calculatedCRC As Boolean() = CRC.Calculate(bits, crcBits)
        Dim extendedBits(bits.Length + calculatedCRC.Length - 1) As Boolean
        ' Copy the original bits and calculated CRC bits to the extended bits array
        Array.Copy(bits, extendedBits, bits.Length)
        Array.Copy(calculatedCRC, 0, extendedBits, bits.Length, calculatedCRC.Length)
        ' Update the input bits array with the extended bits
        bits = extendedBits
    End Sub

    Public Shared Function Validate(packet() As Boolean, crcBits() As Boolean, ByRef cleanedBits() As Boolean) As Boolean
        Dim packetLength As Integer = packet.Length
        Dim crcLength As Integer = crcBits.Length
        ' Check if the packet length is sufficient for CRC verification
        If packetLength < crcLength Then
            cleanedBits = Nothing
            Return False
        End If
        ' Extract the received CRC bits from the packet
        Dim receivedCRC(crcLength - 1) As Boolean
        Array.Copy(packet, packetLength - crcLength, receivedCRC, 0, crcLength)
        ' Verify the CRC and remove the CRC segment
        Dim verifiedCRC As Boolean = CRC.Calculate(packet, crcBits).SequenceEqual(receivedCRC)
        cleanedBits = New Boolean(packetLength - crcLength - 1) {}

        If verifiedCRC Then
            ' Copy the packet without the CRC segment to the cleaned bits array
            Array.Copy(packet, cleanedBits, packetLength - crcLength)
        End If
        Return verifiedCRC
    End Function

    Public Shared Function Calculate(bits() As Boolean, crcBits() As Boolean) As Boolean()
        Dim crcLength As Integer = crcBits.Length

        ' Make a copy of the original bits array to perform CRC calculation
        Dim bitsCopy(bits.Length - 1 + crcLength) As Boolean
        Array.Copy(bits, bitsCopy, bits.Length)

        ' Calculate CRC checksum using the given bits
        For i As Integer = 0 To bits.Length - 1
            If bitsCopy(i) Then
                For j As Integer = 0 To crcLength - 1
                    bitsCopy(i + j) = bitsCopy(i + j) Xor crcBits(j)
                Next
            End If
        Next

        ' Return the calculated CRC bits
        Dim crcBitsCopy(crcLength - 1) As Boolean
        Array.Copy(bitsCopy, bits.Length, crcBitsCopy, 0, crcLength)
        Return crcBitsCopy
    End Function

End Class