<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.numHz = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numSam = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bGenerate = New System.Windows.Forms.Button()
        Me.numLP = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numHP = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbMessage = New System.Windows.Forms.TextBox()
        Me.tbResult = New System.Windows.Forms.TextBox()
        Me.numPhase = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbDemod = New System.Windows.Forms.ComboBox()
        Me.numAmp = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numTime = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ColDialog = New System.Windows.Forms.ColorDialog()
        Me.SCol = New System.Windows.Forms.PictureBox()
        Me.GCol = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.numSm = New System.Windows.Forms.NumericUpDown()
        Me.numCo = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.KnTi = New Spectre.Knob()
        Me.KnSr = New Spectre.Knob()
        Me.KnPh = New Spectre.Knob()
        Me.KnAmp = New Spectre.Knob()
        Me.knFreq = New Spectre.Knob()
        Me.Viewport1 = New Spectre.Canvas()
        CType(Me.numHz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPhase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numHz
        '
        Me.numHz.DecimalPlaces = 5
        Me.numHz.Increment = New Decimal(New Integer() {5, 0, 0, 196608})
        Me.numHz.Location = New System.Drawing.Point(442, 39)
        Me.numHz.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numHz.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.numHz.Name = "numHz"
        Me.numHz.Size = New System.Drawing.Size(165, 20)
        Me.numHz.TabIndex = 5
        Me.numHz.ThousandsSeparator = True
        Me.numHz.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(613, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Carrier"
        '
        'numSam
        '
        Me.numSam.Location = New System.Drawing.Point(442, 226)
        Me.numSam.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numSam.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numSam.Name = "numSam"
        Me.numSam.Size = New System.Drawing.Size(64, 20)
        Me.numSam.TabIndex = 5
        Me.numSam.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(508, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "SR"
        '
        'bGenerate
        '
        Me.bGenerate.Location = New System.Drawing.Point(442, 375)
        Me.bGenerate.Name = "bGenerate"
        Me.bGenerate.Size = New System.Drawing.Size(226, 43)
        Me.bGenerate.TabIndex = 7
        Me.bGenerate.Text = "Generate"
        Me.bGenerate.UseVisualStyleBackColor = True
        '
        'numLP
        '
        Me.numLP.DecimalPlaces = 5
        Me.numLP.Increment = New Decimal(New Integer() {5, 0, 0, 196608})
        Me.numLP.Location = New System.Drawing.Point(442, 124)
        Me.numLP.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numLP.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.numLP.Name = "numLP"
        Me.numLP.Size = New System.Drawing.Size(165, 20)
        Me.numLP.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(611, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Low Pass"
        '
        'numHP
        '
        Me.numHP.DecimalPlaces = 5
        Me.numHP.Increment = New Decimal(New Integer() {5, 0, 0, 196608})
        Me.numHP.Location = New System.Drawing.Point(442, 150)
        Me.numHP.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numHP.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.numHP.Name = "numHP"
        Me.numHP.Size = New System.Drawing.Size(165, 20)
        Me.numHP.TabIndex = 10
        Me.numHP.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(611, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "High Pass"
        '
        'tbMessage
        '
        Me.tbMessage.Location = New System.Drawing.Point(12, 300)
        Me.tbMessage.Multiline = True
        Me.tbMessage.Name = "tbMessage"
        Me.tbMessage.Size = New System.Drawing.Size(424, 69)
        Me.tbMessage.TabIndex = 12
        Me.tbMessage.Text = "Hello, World!"
        '
        'tbResult
        '
        Me.tbResult.Location = New System.Drawing.Point(12, 375)
        Me.tbResult.Multiline = True
        Me.tbResult.Name = "tbResult"
        Me.tbResult.ReadOnly = True
        Me.tbResult.Size = New System.Drawing.Size(424, 43)
        Me.tbResult.TabIndex = 13
        '
        'numPhase
        '
        Me.numPhase.DecimalPlaces = 5
        Me.numPhase.Increment = New Decimal(New Integer() {5, 0, 0, 196608})
        Me.numPhase.Location = New System.Drawing.Point(442, 91)
        Me.numPhase.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numPhase.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.numPhase.Name = "numPhase"
        Me.numPhase.Size = New System.Drawing.Size(165, 20)
        Me.numPhase.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(611, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Phase"
        '
        'cbDemod
        '
        Me.cbDemod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDemod.FormattingEnabled = True
        Me.cbDemod.Location = New System.Drawing.Point(442, 12)
        Me.cbDemod.Name = "cbDemod"
        Me.cbDemod.Size = New System.Drawing.Size(224, 21)
        Me.cbDemod.TabIndex = 17
        '
        'numAmp
        '
        Me.numAmp.DecimalPlaces = 5
        Me.numAmp.Increment = New Decimal(New Integer() {5, 0, 0, 196608})
        Me.numAmp.Location = New System.Drawing.Point(442, 65)
        Me.numAmp.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numAmp.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.numAmp.Name = "numAmp"
        Me.numAmp.Size = New System.Drawing.Size(165, 20)
        Me.numAmp.TabIndex = 18
        Me.numAmp.ThousandsSeparator = True
        Me.numAmp.Value = New Decimal(New Integer() {100000, 0, 0, 327680})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(611, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Amplitude"
        '
        'numTime
        '
        Me.numTime.DecimalPlaces = 1
        Me.numTime.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numTime.Location = New System.Drawing.Point(555, 226)
        Me.numTime.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numTime.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numTime.Name = "numTime"
        Me.numTime.Size = New System.Drawing.Size(52, 20)
        Me.numTime.TabIndex = 20
        Me.numTime.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(611, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "T"
        '
        'SCol
        '
        Me.SCol.Location = New System.Drawing.Point(442, 249)
        Me.SCol.Name = "SCol"
        Me.SCol.Size = New System.Drawing.Size(23, 23)
        Me.SCol.TabIndex = 22
        Me.SCol.TabStop = False
        '
        'GCol
        '
        Me.GCol.Location = New System.Drawing.Point(442, 278)
        Me.GCol.Name = "GCol"
        Me.GCol.Size = New System.Drawing.Size(23, 23)
        Me.GCol.TabIndex = 23
        Me.GCol.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(470, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Signal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(470, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Grid"
        '
        'numSm
        '
        Me.numSm.DecimalPlaces = 2
        Me.numSm.Increment = New Decimal(New Integer() {5, 0, 0, 196608})
        Me.numSm.Location = New System.Drawing.Point(442, 176)
        Me.numSm.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numSm.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.numSm.Name = "numSm"
        Me.numSm.Size = New System.Drawing.Size(165, 20)
        Me.numSm.TabIndex = 26
        Me.numSm.Value = New Decimal(New Integer() {10, 0, 0, 131072})
        '
        'numCo
        '
        Me.numCo.DecimalPlaces = 2
        Me.numCo.Increment = New Decimal(New Integer() {5, 0, 0, 196608})
        Me.numCo.Location = New System.Drawing.Point(442, 200)
        Me.numCo.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numCo.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.numCo.Name = "numCo"
        Me.numCo.Size = New System.Drawing.Size(165, 20)
        Me.numCo.TabIndex = 27
        Me.numCo.Value = New Decimal(New Integer() {1, 0, 0, 131072})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(611, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Smooth"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(611, 207)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Cut Off"
        '
        'KnTi
        '
        Me.KnTi.CenterX = 0!
        Me.KnTi.CenterY = 0!
        Me.KnTi.Label = Nothing
        Me.KnTi.LabelFont = Nothing
        Me.KnTi.LabelOffset = 0!
        Me.KnTi.Location = New System.Drawing.Point(356, 12)
        Me.KnTi.MaxValue = 0!
        Me.KnTi.MinValue = 0!
        Me.KnTi.Name = "KnTi"
        Me.KnTi.Position = 0!
        Me.KnTi.Radius = 0!
        Me.KnTi.RadiusM = 0!
        Me.KnTi.Size = New System.Drawing.Size(80, 80)
        Me.KnTi.TabIndex = 34
        '
        'KnSr
        '
        Me.KnSr.CenterX = 0!
        Me.KnSr.CenterY = 0!
        Me.KnSr.Label = Nothing
        Me.KnSr.LabelFont = Nothing
        Me.KnSr.LabelOffset = 0!
        Me.KnSr.Location = New System.Drawing.Point(270, 12)
        Me.KnSr.MaxValue = 0!
        Me.KnSr.MinValue = 0!
        Me.KnSr.Name = "KnSr"
        Me.KnSr.Position = 0!
        Me.KnSr.Radius = 0!
        Me.KnSr.RadiusM = 0!
        Me.KnSr.Size = New System.Drawing.Size(80, 80)
        Me.KnSr.TabIndex = 33
        '
        'KnPh
        '
        Me.KnPh.CenterX = 0!
        Me.KnPh.CenterY = 0!
        Me.KnPh.Label = Nothing
        Me.KnPh.LabelFont = Nothing
        Me.KnPh.LabelOffset = 0!
        Me.KnPh.Location = New System.Drawing.Point(184, 12)
        Me.KnPh.MaxValue = 0!
        Me.KnPh.MinValue = 0!
        Me.KnPh.Name = "KnPh"
        Me.KnPh.Position = 0!
        Me.KnPh.Radius = 0!
        Me.KnPh.RadiusM = 0!
        Me.KnPh.Size = New System.Drawing.Size(80, 80)
        Me.KnPh.TabIndex = 32
        '
        'KnAmp
        '
        Me.KnAmp.CenterX = 0!
        Me.KnAmp.CenterY = 0!
        Me.KnAmp.Label = Nothing
        Me.KnAmp.LabelFont = Nothing
        Me.KnAmp.LabelOffset = 0!
        Me.KnAmp.Location = New System.Drawing.Point(98, 12)
        Me.KnAmp.MaxValue = 0!
        Me.KnAmp.MinValue = 0!
        Me.KnAmp.Name = "KnAmp"
        Me.KnAmp.Position = 0!
        Me.KnAmp.Radius = 0!
        Me.KnAmp.RadiusM = 0!
        Me.KnAmp.Size = New System.Drawing.Size(80, 80)
        Me.KnAmp.TabIndex = 31
        '
        'knFreq
        '
        Me.knFreq.CenterX = 0!
        Me.knFreq.CenterY = 0!
        Me.knFreq.Label = Nothing
        Me.knFreq.LabelFont = Nothing
        Me.knFreq.LabelOffset = 0!
        Me.knFreq.Location = New System.Drawing.Point(12, 12)
        Me.knFreq.MaxValue = 0!
        Me.knFreq.MinValue = 0!
        Me.knFreq.Name = "knFreq"
        Me.knFreq.Position = 0!
        Me.knFreq.Radius = 0!
        Me.knFreq.RadiusM = 0!
        Me.knFreq.Size = New System.Drawing.Size(80, 80)
        Me.knFreq.TabIndex = 30
        '
        'Viewport1
        '
        Me.Viewport1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Viewport1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Viewport1.Location = New System.Drawing.Point(12, 98)
        Me.Viewport1.Name = "Viewport1"
        Me.Viewport1.Size = New System.Drawing.Size(424, 196)
        Me.Viewport1.TabIndex = 0
        '
        'Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 429)
        Me.Controls.Add(Me.KnAmp)
        Me.Controls.Add(Me.KnTi)
        Me.Controls.Add(Me.KnSr)
        Me.Controls.Add(Me.KnPh)
        Me.Controls.Add(Me.knFreq)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.numCo)
        Me.Controls.Add(Me.numSm)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GCol)
        Me.Controls.Add(Me.SCol)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.numTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numAmp)
        Me.Controls.Add(Me.cbDemod)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.numPhase)
        Me.Controls.Add(Me.tbResult)
        Me.Controls.Add(Me.tbMessage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.numHP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.numLP)
        Me.Controls.Add(Me.bGenerate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numSam)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numHz)
        Me.Controls.Add(Me.Viewport1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Editor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spectre"
        CType(Me.numHz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPhase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Viewport1 As Canvas
    Friend WithEvents numHz As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents numSam As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents bGenerate As Button
    Friend WithEvents numLP As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents numHP As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents tbMessage As TextBox
    Friend WithEvents tbResult As TextBox
    Friend WithEvents numPhase As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents cbDemod As ComboBox
    Friend WithEvents numAmp As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents numTime As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents ColDialog As ColorDialog
    Friend WithEvents SCol As PictureBox
    Friend WithEvents GCol As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents numSm As NumericUpDown
    Friend WithEvents numCo As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents knFreq As Knob
    Friend WithEvents KnAmp As Knob
    Friend WithEvents KnPh As Knob
    Friend WithEvents KnSr As Knob
    Friend WithEvents KnTi As Knob
End Class
