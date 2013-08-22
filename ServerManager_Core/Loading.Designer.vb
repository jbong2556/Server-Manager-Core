<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading))
        Me.LoadingBar = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Loading_Console = New System.Windows.Forms.ListBox()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.Closebutton = New System.Windows.Forms.Button()
        Me.Section_Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadingBar
        '
        Me.LoadingBar.Location = New System.Drawing.Point(0, 288)
        Me.LoadingBar.Name = "LoadingBar"
        Me.LoadingBar.Size = New System.Drawing.Size(785, 24)
        Me.LoadingBar.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(785, 204)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Loading_Console
        '
        Me.Loading_Console.FormattingEnabled = True
        Me.Loading_Console.Location = New System.Drawing.Point(0, 206)
        Me.Loading_Console.Name = "Loading_Console"
        Me.Loading_Console.Size = New System.Drawing.Size(785, 82)
        Me.Loading_Console.TabIndex = 3
        '
        'Closebutton
        '
        Me.Closebutton.Location = New System.Drawing.Point(0, 288)
        Me.Closebutton.Name = "Closebutton"
        Me.Closebutton.Size = New System.Drawing.Size(785, 24)
        Me.Closebutton.TabIndex = 4
        Me.Closebutton.Text = "Close me!"
        Me.Closebutton.UseVisualStyleBackColor = True
        Me.Closebutton.Visible = False
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 312)
        Me.Controls.Add(Me.Closebutton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LoadingBar)
        Me.Controls.Add(Me.Loading_Console)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Loading"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoadingBar As System.Windows.Forms.ProgressBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Loading_Console As System.Windows.Forms.ListBox
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Closebutton As System.Windows.Forms.Button
    Friend WithEvents Section_Timer As System.Windows.Forms.Timer

End Class
