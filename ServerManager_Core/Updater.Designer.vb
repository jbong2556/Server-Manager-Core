<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Updater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Updater))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WiglegUpdater_Console = New System.Windows.Forms.RichTextBox()
        Me.Download = New System.Windows.Forms.Button()
        Me.Progressbar = New System.Windows.Forms.ProgressBar()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 80)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(15, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wigleg Updater - Beta 1.2"
        '
        'WiglegUpdater_Console
        '
        Me.WiglegUpdater_Console.Location = New System.Drawing.Point(12, 85)
        Me.WiglegUpdater_Console.Name = "WiglegUpdater_Console"
        Me.WiglegUpdater_Console.ReadOnly = True
        Me.WiglegUpdater_Console.Size = New System.Drawing.Size(760, 236)
        Me.WiglegUpdater_Console.TabIndex = 1
        Me.WiglegUpdater_Console.Text = ""
        '
        'Download
        '
        Me.Download.Location = New System.Drawing.Point(697, 327)
        Me.Download.Name = "Download"
        Me.Download.Size = New System.Drawing.Size(75, 23)
        Me.Download.TabIndex = 2
        Me.Download.Text = "Download"
        Me.Download.UseVisualStyleBackColor = True
        '
        'Progressbar
        '
        Me.Progressbar.Location = New System.Drawing.Point(12, 327)
        Me.Progressbar.Name = "Progressbar"
        Me.Progressbar.Size = New System.Drawing.Size(679, 23)
        Me.Progressbar.TabIndex = 3
        '
        'Updater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 362)
        Me.Controls.Add(Me.Progressbar)
        Me.Controls.Add(Me.Download)
        Me.Controls.Add(Me.WiglegUpdater_Console)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Updater"
        Me.Text = "Updater"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WiglegUpdater_Console As System.Windows.Forms.RichTextBox
    Friend WithEvents Download As System.Windows.Forms.Button
    Friend WithEvents Progressbar As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
End Class
