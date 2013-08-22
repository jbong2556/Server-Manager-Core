<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.test = New System.Windows.Forms.Label()
        Me.Namebox = New System.Windows.Forms.TextBox()
        Me.DataMessage = New System.Windows.Forms.RichTextBox()
        Me.ReportSender = New System.Windows.Forms.WebBrowser()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.test)
        Me.GroupBox1.Controls.Add(Me.Namebox)
        Me.GroupBox1.Controls.Add(Me.DataMessage)
        Me.GroupBox1.Controls.Add(Me.ReportSender)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 338)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report A Bug"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(548, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Message"
        '
        'test
        '
        Me.test.AutoSize = True
        Me.test.Location = New System.Drawing.Point(6, 18)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(45, 16)
        Me.test.TabIndex = 2
        Me.test.Text = "Name"
        '
        'Namebox
        '
        Me.Namebox.Location = New System.Drawing.Point(6, 35)
        Me.Namebox.Name = "Namebox"
        Me.Namebox.Size = New System.Drawing.Size(548, 22)
        Me.Namebox.TabIndex = 1
        '
        'DataMessage
        '
        Me.DataMessage.Location = New System.Drawing.Point(6, 79)
        Me.DataMessage.Name = "DataMessage"
        Me.DataMessage.Size = New System.Drawing.Size(548, 224)
        Me.DataMessage.TabIndex = 0
        Me.DataMessage.Text = ""
        '
        'ReportSender
        '
        Me.ReportSender.Location = New System.Drawing.Point(310, 88)
        Me.ReportSender.MinimumSize = New System.Drawing.Size(20, 20)
        Me.ReportSender.Name = "ReportSender"
        Me.ReportSender.Size = New System.Drawing.Size(154, 131)
        Me.ReportSender.TabIndex = 5
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Reports"
        Me.Text = "Report Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents test As System.Windows.Forms.Label
    Friend WithEvents Namebox As System.Windows.Forms.TextBox
    Friend WithEvents DataMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents ReportSender As System.Windows.Forms.WebBrowser
End Class
