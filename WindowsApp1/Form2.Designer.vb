<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Spelbord_bepalen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Spelbord_bepalen))
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Start_button = New System.Windows.Forms.Button()
        Me.TextBoxDimensie = New System.Windows.Forms.TextBox()
        Me.TextBoxAantalKleuren = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Start_button
        '
        Me.Start_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Start_button.Location = New System.Drawing.Point(166, 133)
        Me.Start_button.Name = "Start_button"
        Me.Start_button.Size = New System.Drawing.Size(130, 40)
        Me.Start_button.TabIndex = 1
        Me.Start_button.Text = "Start"
        Me.Start_button.UseVisualStyleBackColor = True
        '
        'TextBoxDimensie
        '
        Me.TextBoxDimensie.Location = New System.Drawing.Point(85, 72)
        Me.TextBoxDimensie.Name = "TextBoxDimensie"
        Me.TextBoxDimensie.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDimensie.TabIndex = 2
        '
        'TextBoxAantalKleuren
        '
        Me.TextBoxAantalKleuren.Location = New System.Drawing.Point(281, 72)
        Me.TextBoxAantalKleuren.Name = "TextBoxAantalKleuren"
        Me.TextBoxAantalKleuren.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAantalKleuren.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dimensie:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Aantal kleuren (max 11)"
        '
        'Spelbord_bepalen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 281)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxAantalKleuren)
        Me.Controls.Add(Me.TextBoxDimensie)
        Me.Controls.Add(Me.Start_button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Spelbord_bepalen"
        Me.Text = "Spelbord bepalen"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Start_button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxAantalKleuren As TextBox
    Friend WithEvents TextBoxDimensie As TextBox
End Class
