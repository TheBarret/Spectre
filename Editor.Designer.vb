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
        Me.Viewport1 = New Spectre.Canvas()
        Me.cbDemod = New System.Windows.Forms.ComboBox()
        Me.numAmp = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numTime = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.numHz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPhase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numHz
        '
        Me.numHz.DecimalPlaces = 5
        Me.numHz.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.numHz.Location = New System.Drawing.Point(530, 114)
        Me.numHz.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numHz.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.numHz.Name = "numHz"
        Me.numHz.Size = New System.Drawing.Size(165, 20)
        Me.numHz.TabIndex = 5
        Me.numHz.ThousandsSeparator = True
        Me.numHz.Value = New Decimal(New Integer() {500000, 0, 0, 327680})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(699, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Carrier"
        '
        'numSam
        '
        Me.numSam.Location = New System.Drawing.Point(530, 251)
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
        Me.Label3.Location = New System.Drawing.Point(596, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "SR"
        '
        'bGenerate
        '
        Me.bGenerate.Location = New System.Drawing.Point(530, 393)
        Me.bGenerate.Name = "bGenerate"
        Me.bGenerate.Size = New System.Drawing.Size(226, 33)
        Me.bGenerate.TabIndex = 7
        Me.bGenerate.Text = "Generate"
        Me.bGenerate.UseVisualStyleBackColor = True
        '
        'numLP
        '
        Me.numLP.DecimalPlaces = 5
        Me.numLP.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numLP.Location = New System.Drawing.Point(530, 199)
        Me.numLP.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numLP.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.numLP.Name = "numLP"
        Me.numLP.Size = New System.Drawing.Size(165, 20)
        Me.numLP.TabIndex = 8
        Me.numLP.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(699, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Low Pass"
        '
        'numHP
        '
        Me.numHP.DecimalPlaces = 5
        Me.numHP.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numHP.Location = New System.Drawing.Point(530, 225)
        Me.numHP.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numHP.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.numHP.Name = "numHP"
        Me.numHP.Size = New System.Drawing.Size(165, 20)
        Me.numHP.TabIndex = 10
        Me.numHP.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(699, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "High Pass"
        '
        'tbMessage
        '
        Me.tbMessage.Location = New System.Drawing.Point(530, 12)
        Me.tbMessage.Multiline = True
        Me.tbMessage.Name = "tbMessage"
        Me.tbMessage.Size = New System.Drawing.Size(224, 69)
        Me.tbMessage.TabIndex = 12
        Me.tbMessage.Text = "Hello, World!"
        '
        'tbResult
        '
        Me.tbResult.Location = New System.Drawing.Point(12, 401)
        Me.tbResult.Multiline = True
        Me.tbResult.Name = "tbResult"
        Me.tbResult.ReadOnly = True
        Me.tbResult.Size = New System.Drawing.Size(512, 25)
        Me.tbResult.TabIndex = 13
        '
        'numPhase
        '
        Me.numPhase.DecimalPlaces = 5
        Me.numPhase.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.numPhase.Location = New System.Drawing.Point(530, 166)
        Me.numPhase.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numPhase.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.numPhase.Name = "numPhase"
        Me.numPhase.Size = New System.Drawing.Size(165, 20)
        Me.numPhase.TabIndex = 15
        Me.numPhase.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(699, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Phase"
        '
        'Viewport1
        '
        Me.Viewport1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Viewport1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Viewport1.Location = New System.Drawing.Point(12, 12)
        Me.Viewport1.Name = "Viewport1"
        Me.Viewport1.Size = New System.Drawing.Size(512, 383)
        Me.Viewport1.TabIndex = 0
        '
        'cbDemod
        '
        Me.cbDemod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDemod.FormattingEnabled = True
        Me.cbDemod.Location = New System.Drawing.Point(530, 87)
        Me.cbDemod.Name = "cbDemod"
        Me.cbDemod.Size = New System.Drawing.Size(224, 21)
        Me.cbDemod.TabIndex = 17
        '
        'numAmp
        '
        Me.numAmp.DecimalPlaces = 5
        Me.numAmp.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.numAmp.Location = New System.Drawing.Point(530, 140)
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
        Me.Label2.Location = New System.Drawing.Point(699, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Amplitude"
        '
        'numTime
        '
        Me.numTime.DecimalPlaces = 1
        Me.numTime.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numTime.Location = New System.Drawing.Point(643, 251)
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
        Me.Label6.Location = New System.Drawing.Point(699, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "T"
        '
        'Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 438)
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
End Class
