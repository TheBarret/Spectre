Public Class Editor
    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cbDemod.Items.Add("Frequency Shift Keying")
        Me.cbDemod.Items.Add("Amplitude Shift Keying")
        Me.cbDemod.Items.Add("Phase Shift Keying")
        Me.cbDemod.Items.Add("Quadrature Amplitude Modulation")
        Me.cbDemod.SelectedIndex = 0
        Me.tbMessage.Text = "Hello, World!"
        Me.SCol.BackColor = Color.Navy
        Me.GCol.BackColor = Color.Plum
        Me.knFreq.Setup("Frequency", 0, -128.0F, 128.0F, 20, 10, 10)
        Me.KnAmp.Setup("Amplitude", 0, -128.0F, 128.0F, 20, 10, 10)
        Me.KnPh.Setup("Phase", 0, -128.0F, 128.0F, 20, 10, 10)
        Me.KnSr.Setup("Samplerate", 0, -128.0F, 128.0F, 20, 10, 10)
        Me.KnTi.Setup("Duration", 0, -128.0F, 128.0F, 20, 10, 10)
    End Sub

    Private Sub bGenerate_Click(sender As Object, e As EventArgs) Handles bGenerate.Click
        Dim result As String = String.Empty
        Dim d As Single = CSng(Me.numTime.Value)
        Dim a As Single = CSng(Me.numAmp.Value)
        Dim f As Single = CSng(Me.numHz.Value)
        Dim p As Single = CSng(Me.numPhase.Value)
        Dim s As Single = CSng(Me.numSam.Value)
        Me.knFreq.UpdateKnob(f)
        Me.KnAmp.UpdateKnob(a)
        Me.KnPh.UpdateKnob(p)
        Me.KnSr.UpdateKnob(s)
        Me.KnTi.UpdateKnob(d)
        Select Case Me.cbDemod.SelectedIndex
            Case 0 : Me.Generate(New FSK(d, s, f, a, p), d, result)
            Case 1 : Me.Generate(New ASK(d, s, f, a, p), d, result)
            Case 2 : Me.Generate(New PSK(d, s, f, a, p), d, result)
            Case 3 : Me.Generate(New Qam(d, s, f, a, p), d, result)
        End Select
    End Sub

    Public Sub Generate(demod As Modulator, delta As Single, ByRef result As String, Optional useOutput As Boolean = True)
        Dim message() As Boolean = demod.Encode(Me.tbMessage.Text)
        Dim signal() As Single = demod.Modulate(message)
        Dim lp As Single = Me.numLP.Value
        Dim hp As Single = Me.numHP.Value
        Dim sm As Single = Me.numSm.Value
        Dim co As Single = Me.numCo.Value
        Filters.BandPass(signal, lp, hp, delta)
        Filters.Smooth(signal, sm, co)
        result = demod.Decode(demod.Demodulate(signal))
        If (useOutput) Then
            Dim vis As New Visualizer(Me.Viewport1.ClientRectangle)
            vis.SignalColor = Me.SCol.BackColor
            vis.GridColor = Me.GCol.BackColor
            Me.tbResult.Text = String.Format("{0} [LCS: {1}]", result, Me.GetLCSScore(Me.tbMessage.Text, result))
            Me.Viewport1.BackgroundImage = CType(vis.Render(signal), Image)
        End If
    End Sub

    Private Sub SCol_Click(sender As Object, e As EventArgs) Handles SCol.Click
        If (Me.ColDialog.ShowDialog(Me) = DialogResult.OK) Then
            Me.SCol.BackColor = Me.ColDialog.Color
        End If
    End Sub

    Private Sub GCol_Click(sender As Object, e As EventArgs) Handles GCol.Click
        If (Me.ColDialog.ShowDialog(Me) = DialogResult.OK) Then
            Me.GCol.BackColor = Me.ColDialog.Color
        End If
    End Sub

    Public Function GetLCSScore(str1 As String, str2 As String) As Integer
        Dim m As Integer = str1.Length
        Dim n As Integer = str2.Length
        ' Create a table to store the lengths of common subsequences
        Dim table(m, n) As Integer
        ' Calculate the lengths of common subsequences
        For i As Integer = 1 To m
            For j As Integer = 1 To n
                If str1(i - 1) = str2(j - 1) Then
                    table(i, j) = table(i - 1, j - 1) + 1
                Else
                    table(i, j) = Math.Max(table(i - 1, j), table(i, j - 1))
                End If
            Next
        Next
        ' Return the length of the longest common subsequence
        Return table(m, n)
    End Function
End Class
