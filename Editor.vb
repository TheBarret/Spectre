Public Class Editor
    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cbDemod.Items.Add("Frequency Shift Keying")
        Me.cbDemod.Items.Add("Amplitude Shift Keying")
        Me.cbDemod.Items.Add("Phase Shift Keying")
        Me.cbDemod.Items.Add("Quadrature Amplitude Modulation")
        Me.cbDemod.SelectedIndex = 0
        Me.tbMessage.Text = Environment.UserName
    End Sub

    Private Sub bGenerate_Click(sender As Object, e As EventArgs) Handles bGenerate.Click
        Dim d As Single = CSng(Me.numTime.Value)
        Dim a As Single = CSng(Me.numAmp.Value)
        Dim f As Single = CSng(Me.numHz.Value)
        Dim p As Single = CSng(Me.numPhase.Value)
        Dim s As Single = CSng(Me.numSam.Value)
        Dim crc() As Boolean = {True, True, False, True, False, False, True}
        Select Case Me.cbDemod.SelectedIndex
            Case 0 : Me.Generate(New FSK(d, s, f, a, p), d, crc)
            Case 1 : Me.Generate(New ASK(d, s, f, a, p), d, crc)
            Case 2 : Me.Generate(New PSK(d, s, f, a, p), d, crc)
            Case 3 : Me.Generate(New Qam(d, s, f, a, p), d, crc)
        End Select
    End Sub

    Public Sub Generate(demod As Modulator, delta As Single, crcbits() As Boolean)
        Dim message() As Boolean = demod.Encode(Me.tbMessage.Text)
        Dim signal() As Single = demod.Modulate(message)
        Dim lp As Single = Me.numLP.Value
        Dim hp As Single = Me.numHP.Value
        Filters.BandPass(signal, lp, hp, delta)
        Me.tbResult.Text = String.Format("{0} [{1} bytes]", demod.Decode(demod.Demodulate(signal)), signal.Length)
        Me.Viewport1.BackgroundImage = CType(New Visualizer(Me.Viewport1.ClientRectangle).Render(signal), Image)
    End Sub

End Class
