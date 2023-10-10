<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.WDigitalButton = New System.Windows.Forms.Button()
        Me.RDigitalButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QyDisplayLabel = New System.Windows.Forms.Label()
        Me.QyRecLabel = New System.Windows.Forms.Label()
        Me.WriteAnalogButton = New System.Windows.Forms.Button()
        Me.AnalogReadButton = New System.Windows.Forms.Button()
        Me.PortDataListBox = New System.Windows.Forms.ListBox()
        Me.PortOpenButton = New System.Windows.Forms.Button()
        Me.ComPortListBox = New System.Windows.Forms.ListBox()
        Me.BaudRateListBox = New System.Windows.Forms.ListBox()
        Me.ComPortButton = New System.Windows.Forms.Button()
        Me.BaudRateButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.DataRXListBox = New System.Windows.Forms.ListBox()
        Me.TXDataListBox = New System.Windows.Forms.ListBox()
        Me.RXDecListBox = New System.Windows.Forms.ListBox()
        Me.Clear1Button = New System.Windows.Forms.Button()
        Me.Clear2Button = New System.Windows.Forms.Button()
        Me.Clear3Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WDigitalButton
        '
        Me.WDigitalButton.Location = New System.Drawing.Point(451, 401)
        Me.WDigitalButton.Name = "WDigitalButton"
        Me.WDigitalButton.Size = New System.Drawing.Size(116, 62)
        Me.WDigitalButton.TabIndex = 86
        Me.WDigitalButton.Text = "Wrtie Digital"
        Me.WDigitalButton.UseVisualStyleBackColor = True
        '
        'RDigitalButton
        '
        Me.RDigitalButton.Location = New System.Drawing.Point(318, 394)
        Me.RDigitalButton.Name = "RDigitalButton"
        Me.RDigitalButton.Size = New System.Drawing.Size(111, 77)
        Me.RDigitalButton.TabIndex = 85
        Me.RDigitalButton.Text = "Read Digital"
        Me.RDigitalButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(399, 549)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 549)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "0"
        '
        'QyDisplayLabel
        '
        Me.QyDisplayLabel.AutoSize = True
        Me.QyDisplayLabel.Location = New System.Drawing.Point(170, 495)
        Me.QyDisplayLabel.Name = "QyDisplayLabel"
        Me.QyDisplayLabel.Size = New System.Drawing.Size(153, 20)
        Me.QyDisplayLabel.TabIndex = 82
        Me.QyDisplayLabel.Text = "Qy@ Received Data"
        '
        'QyRecLabel
        '
        Me.QyRecLabel.AutoSize = True
        Me.QyRecLabel.Location = New System.Drawing.Point(235, 515)
        Me.QyRecLabel.Name = "QyRecLabel"
        Me.QyRecLabel.Size = New System.Drawing.Size(18, 20)
        Me.QyRecLabel.TabIndex = 81
        Me.QyRecLabel.Text = "0"
        '
        'WriteAnalogButton
        '
        Me.WriteAnalogButton.Location = New System.Drawing.Point(174, 394)
        Me.WriteAnalogButton.Name = "WriteAnalogButton"
        Me.WriteAnalogButton.Size = New System.Drawing.Size(104, 87)
        Me.WriteAnalogButton.TabIndex = 80
        Me.WriteAnalogButton.Text = "Write Analog"
        Me.WriteAnalogButton.UseVisualStyleBackColor = True
        '
        'AnalogReadButton
        '
        Me.AnalogReadButton.Location = New System.Drawing.Point(12, 394)
        Me.AnalogReadButton.Name = "AnalogReadButton"
        Me.AnalogReadButton.Size = New System.Drawing.Size(109, 96)
        Me.AnalogReadButton.TabIndex = 79
        Me.AnalogReadButton.Text = "ReadAnalog"
        Me.AnalogReadButton.UseVisualStyleBackColor = True
        '
        'PortDataListBox
        '
        Me.PortDataListBox.FormattingEnabled = True
        Me.PortDataListBox.ItemHeight = 20
        Me.PortDataListBox.Location = New System.Drawing.Point(334, 7)
        Me.PortDataListBox.Name = "PortDataListBox"
        Me.PortDataListBox.Size = New System.Drawing.Size(173, 204)
        Me.PortDataListBox.TabIndex = 78
        '
        'PortOpenButton
        '
        Me.PortOpenButton.Location = New System.Drawing.Point(334, 243)
        Me.PortOpenButton.Name = "PortOpenButton"
        Me.PortOpenButton.Size = New System.Drawing.Size(154, 104)
        Me.PortOpenButton.TabIndex = 77
        Me.PortOpenButton.Text = "Connect"
        Me.PortOpenButton.UseVisualStyleBackColor = True
        '
        'ComPortListBox
        '
        Me.ComPortListBox.FormattingEnabled = True
        Me.ComPortListBox.ItemHeight = 20
        Me.ComPortListBox.Location = New System.Drawing.Point(197, 12)
        Me.ComPortListBox.Name = "ComPortListBox"
        Me.ComPortListBox.Size = New System.Drawing.Size(110, 184)
        Me.ComPortListBox.TabIndex = 76
        '
        'BaudRateListBox
        '
        Me.BaudRateListBox.FormattingEnabled = True
        Me.BaudRateListBox.ItemHeight = 20
        Me.BaudRateListBox.Location = New System.Drawing.Point(12, 12)
        Me.BaudRateListBox.Name = "BaudRateListBox"
        Me.BaudRateListBox.Size = New System.Drawing.Size(165, 204)
        Me.BaudRateListBox.TabIndex = 75
        '
        'ComPortButton
        '
        Me.ComPortButton.Location = New System.Drawing.Point(174, 238)
        Me.ComPortButton.Name = "ComPortButton"
        Me.ComPortButton.Size = New System.Drawing.Size(154, 104)
        Me.ComPortButton.TabIndex = 74
        Me.ComPortButton.Text = "Com Port"
        Me.ComPortButton.UseVisualStyleBackColor = True
        '
        'BaudRateButton
        '
        Me.BaudRateButton.Location = New System.Drawing.Point(28, 243)
        Me.BaudRateButton.Name = "BaudRateButton"
        Me.BaudRateButton.Size = New System.Drawing.Size(127, 95)
        Me.BaudRateButton.TabIndex = 73
        Me.BaudRateButton.Text = "Baud Rate"
        Me.BaudRateButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitButton.Location = New System.Drawing.Point(900, 562)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(82, 76)
        Me.QuitButton.TabIndex = 87
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SerialPort1
        '
        '
        'DataRXListBox
        '
        Me.DataRXListBox.FormattingEnabled = True
        Me.DataRXListBox.ItemHeight = 20
        Me.DataRXListBox.Location = New System.Drawing.Point(759, 12)
        Me.DataRXListBox.Name = "DataRXListBox"
        Me.DataRXListBox.Size = New System.Drawing.Size(131, 284)
        Me.DataRXListBox.TabIndex = 88
        '
        'TXDataListBox
        '
        Me.TXDataListBox.FormattingEnabled = True
        Me.TXDataListBox.ItemHeight = 20
        Me.TXDataListBox.Location = New System.Drawing.Point(553, 12)
        Me.TXDataListBox.Name = "TXDataListBox"
        Me.TXDataListBox.Size = New System.Drawing.Size(154, 284)
        Me.TXDataListBox.TabIndex = 89
        '
        'RXDecListBox
        '
        Me.RXDecListBox.FormattingEnabled = True
        Me.RXDecListBox.ItemHeight = 20
        Me.RXDecListBox.Location = New System.Drawing.Point(900, 12)
        Me.RXDecListBox.Name = "RXDecListBox"
        Me.RXDecListBox.Size = New System.Drawing.Size(131, 284)
        Me.RXDecListBox.TabIndex = 90
        '
        'Clear1Button
        '
        Me.Clear1Button.Location = New System.Drawing.Point(565, 314)
        Me.Clear1Button.Name = "Clear1Button"
        Me.Clear1Button.Size = New System.Drawing.Size(116, 62)
        Me.Clear1Button.TabIndex = 91
        Me.Clear1Button.Text = "Clear TX"
        Me.Clear1Button.UseVisualStyleBackColor = True
        '
        'Clear2Button
        '
        Me.Clear2Button.Location = New System.Drawing.Point(759, 314)
        Me.Clear2Button.Name = "Clear2Button"
        Me.Clear2Button.Size = New System.Drawing.Size(116, 62)
        Me.Clear2Button.TabIndex = 92
        Me.Clear2Button.Text = "Clear RX Character"
        Me.Clear2Button.UseVisualStyleBackColor = True
        '
        'Clear3Button
        '
        Me.Clear3Button.Location = New System.Drawing.Point(928, 314)
        Me.Clear3Button.Name = "Clear3Button"
        Me.Clear3Button.Size = New System.Drawing.Size(116, 62)
        Me.Clear3Button.TabIndex = 93
        Me.Clear3Button.Text = "Clear RX Decimal"
        Me.Clear3Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 666)
        Me.Controls.Add(Me.Clear3Button)
        Me.Controls.Add(Me.Clear2Button)
        Me.Controls.Add(Me.Clear1Button)
        Me.Controls.Add(Me.RXDecListBox)
        Me.Controls.Add(Me.TXDataListBox)
        Me.Controls.Add(Me.DataRXListBox)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.WDigitalButton)
        Me.Controls.Add(Me.RDigitalButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QyDisplayLabel)
        Me.Controls.Add(Me.QyRecLabel)
        Me.Controls.Add(Me.WriteAnalogButton)
        Me.Controls.Add(Me.AnalogReadButton)
        Me.Controls.Add(Me.PortDataListBox)
        Me.Controls.Add(Me.PortOpenButton)
        Me.Controls.Add(Me.ComPortListBox)
        Me.Controls.Add(Me.BaudRateListBox)
        Me.Controls.Add(Me.ComPortButton)
        Me.Controls.Add(Me.BaudRateButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WDigitalButton As Button
    Friend WithEvents RDigitalButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents QyDisplayLabel As Label
    Friend WithEvents QyRecLabel As Label
    Friend WithEvents WriteAnalogButton As Button
    Friend WithEvents AnalogReadButton As Button
    Friend WithEvents PortDataListBox As ListBox
    Friend WithEvents PortOpenButton As Button
    Friend WithEvents ComPortListBox As ListBox
    Friend WithEvents BaudRateListBox As ListBox
    Friend WithEvents ComPortButton As Button
    Friend WithEvents BaudRateButton As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents DataRXListBox As ListBox
    Friend WithEvents TXDataListBox As ListBox
    Friend WithEvents RXDecListBox As ListBox
    Friend WithEvents Clear1Button As Button
    Friend WithEvents Clear2Button As Button
    Friend WithEvents Clear3Button As Button
End Class
