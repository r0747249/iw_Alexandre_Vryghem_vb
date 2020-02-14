<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Flow_Free
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Flow_Free))
        Me.Start_button = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TextBoxTimer_seconden = New System.Windows.Forms.TextBox()
        Me.TextBoxTimer_minuten = New System.Windows.Forms.TextBox()
        Me.TextBoxTimer_uren = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBoxTimer = New System.Windows.Forms.GroupBox()
        Me.GroupBoxHighscore = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBoxHighscore_uren = New System.Windows.Forms.TextBox()
        Me.TextBoxHighscore_minuten = New System.Windows.Forms.TextBox()
        Me.TextBoxHighscore_seconden = New System.Windows.Forms.TextBox()
        Me.TextBoxAantalKleuren = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDimensie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxTimer.SuspendLayout()
        Me.GroupBoxHighscore.SuspendLayout()
        Me.SuspendLayout()
        '
        'Start_button
        '
        Me.Start_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Start_button.Location = New System.Drawing.Point(32, 24)
        Me.Start_button.Name = "Start_button"
        Me.Start_button.Size = New System.Drawing.Size(130, 40)
        Me.Start_button.TabIndex = 0
        Me.Start_button.Text = "Start"
        Me.Start_button.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'TextBoxTimer_seconden
        '
        Me.TextBoxTimer_seconden.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxTimer_seconden.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxTimer_seconden.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTimer_seconden.Location = New System.Drawing.Point(82, 18)
        Me.TextBoxTimer_seconden.Name = "TextBoxTimer_seconden"
        Me.TextBoxTimer_seconden.Size = New System.Drawing.Size(23, 22)
        Me.TextBoxTimer_seconden.TabIndex = 1
        Me.TextBoxTimer_seconden.Text = "00"
        '
        'TextBoxTimer_minuten
        '
        Me.TextBoxTimer_minuten.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxTimer_minuten.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxTimer_minuten.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTimer_minuten.Location = New System.Drawing.Point(51, 18)
        Me.TextBoxTimer_minuten.Name = "TextBoxTimer_minuten"
        Me.TextBoxTimer_minuten.Size = New System.Drawing.Size(23, 22)
        Me.TextBoxTimer_minuten.TabIndex = 2
        Me.TextBoxTimer_minuten.Text = "00"
        '
        'TextBoxTimer_uren
        '
        Me.TextBoxTimer_uren.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxTimer_uren.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxTimer_uren.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTimer_uren.Location = New System.Drawing.Point(21, 18)
        Me.TextBoxTimer_uren.Name = "TextBoxTimer_uren"
        Me.TextBoxTimer_uren.Size = New System.Drawing.Size(23, 22)
        Me.TextBoxTimer_uren.TabIndex = 3
        Me.TextBoxTimer_uren.Text = "00"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(44, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(5, 22)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = ":"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(74, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(5, 22)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = ":"
        '
        'GroupBoxTimer
        '
        Me.GroupBoxTimer.Controls.Add(Me.TextBox2)
        Me.GroupBoxTimer.Controls.Add(Me.TextBox1)
        Me.GroupBoxTimer.Controls.Add(Me.TextBoxTimer_uren)
        Me.GroupBoxTimer.Controls.Add(Me.TextBoxTimer_minuten)
        Me.GroupBoxTimer.Controls.Add(Me.TextBoxTimer_seconden)
        Me.GroupBoxTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxTimer.Location = New System.Drawing.Point(410, 16)
        Me.GroupBoxTimer.Name = "GroupBoxTimer"
        Me.GroupBoxTimer.Size = New System.Drawing.Size(128, 50)
        Me.GroupBoxTimer.TabIndex = 7
        Me.GroupBoxTimer.TabStop = False
        Me.GroupBoxTimer.Text = "Timer"
        '
        'GroupBoxHighscore
        '
        Me.GroupBoxHighscore.Controls.Add(Me.TextBox3)
        Me.GroupBoxHighscore.Controls.Add(Me.TextBox4)
        Me.GroupBoxHighscore.Controls.Add(Me.TextBoxHighscore_uren)
        Me.GroupBoxHighscore.Controls.Add(Me.TextBoxHighscore_minuten)
        Me.GroupBoxHighscore.Controls.Add(Me.TextBoxHighscore_seconden)
        Me.GroupBoxHighscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxHighscore.Location = New System.Drawing.Point(544, 16)
        Me.GroupBoxHighscore.Name = "GroupBoxHighscore"
        Me.GroupBoxHighscore.Size = New System.Drawing.Size(128, 50)
        Me.GroupBoxHighscore.TabIndex = 8
        Me.GroupBoxHighscore.TabStop = False
        Me.GroupBoxHighscore.Text = "Highscore"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(74, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(5, 22)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.Text = ":"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(44, 16)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(5, 22)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Text = ":"
        '
        'TextBoxHighscore_uren
        '
        Me.TextBoxHighscore_uren.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxHighscore_uren.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxHighscore_uren.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHighscore_uren.Location = New System.Drawing.Point(21, 18)
        Me.TextBoxHighscore_uren.Name = "TextBoxHighscore_uren"
        Me.TextBoxHighscore_uren.Size = New System.Drawing.Size(23, 22)
        Me.TextBoxHighscore_uren.TabIndex = 3
        Me.TextBoxHighscore_uren.Text = "00"
        '
        'TextBoxHighscore_minuten
        '
        Me.TextBoxHighscore_minuten.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxHighscore_minuten.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxHighscore_minuten.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHighscore_minuten.Location = New System.Drawing.Point(51, 18)
        Me.TextBoxHighscore_minuten.Name = "TextBoxHighscore_minuten"
        Me.TextBoxHighscore_minuten.Size = New System.Drawing.Size(23, 22)
        Me.TextBoxHighscore_minuten.TabIndex = 2
        Me.TextBoxHighscore_minuten.Text = "00"
        '
        'TextBoxHighscore_seconden
        '
        Me.TextBoxHighscore_seconden.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxHighscore_seconden.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxHighscore_seconden.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHighscore_seconden.Location = New System.Drawing.Point(82, 18)
        Me.TextBoxHighscore_seconden.Name = "TextBoxHighscore_seconden"
        Me.TextBoxHighscore_seconden.Size = New System.Drawing.Size(23, 22)
        Me.TextBoxHighscore_seconden.TabIndex = 1
        Me.TextBoxHighscore_seconden.Text = "00"
        '
        'TextBoxAantalKleuren
        '
        Me.TextBoxAantalKleuren.Location = New System.Drawing.Point(197, 44)
        Me.TextBoxAantalKleuren.Name = "TextBoxAantalKleuren"
        Me.TextBoxAantalKleuren.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAantalKleuren.TabIndex = 9
        Me.TextBoxAantalKleuren.Text = "5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Aantal kleuren:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 639)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(751, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Voor een 5x5 matrix mag je tot max 6 kleuren gebruiken anders moet je de dimensie" &
    "s aanpassen maar best om maar 5 te gebruiken want anders duurt het lang"
        '
        'TextBoxDimensie
        '
        Me.TextBoxDimensie.Location = New System.Drawing.Point(304, 44)
        Me.TextBoxDimensie.Name = "TextBoxDimensie"
        Me.TextBoxDimensie.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDimensie.TabIndex = 12
        Me.TextBoxDimensie.Text = "5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(301, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Dimensie:"
        '
        'Panel
        '
        Me.Panel.Location = New System.Drawing.Point(5, 72)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(748, 555)
        Me.Panel.TabIndex = 14
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Flow_Free
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(756, 664)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxDimensie)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxAantalKleuren)
        Me.Controls.Add(Me.GroupBoxHighscore)
        Me.Controls.Add(Me.GroupBoxTimer)
        Me.Controls.Add(Me.Start_button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Flow_Free"
        Me.Text = "Flow Free"
        Me.GroupBoxTimer.ResumeLayout(False)
        Me.GroupBoxTimer.PerformLayout()
        Me.GroupBoxHighscore.ResumeLayout(False)
        Me.GroupBoxHighscore.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Start_button As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents TextBoxTimer_seconden As TextBox
    Friend WithEvents TextBoxTimer_minuten As TextBox
    Friend WithEvents TextBoxTimer_uren As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBoxTimer As GroupBox
    Friend WithEvents GroupBoxHighscore As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBoxHighscore_uren As TextBox
    Friend WithEvents TextBoxHighscore_minuten As TextBox
    Friend WithEvents TextBoxHighscore_seconden As TextBox
    Friend WithEvents TextBoxAantalKleuren As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxDimensie As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel As Panel
    Friend WithEvents Timer1 As Timer
End Class
