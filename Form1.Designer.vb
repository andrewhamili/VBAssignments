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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.LessonA = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.exercise5 = New System.Windows.Forms.TabPage()
        Me.lblWord1 = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblWord2 = New System.Windows.Forms.Label()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.LessonA.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.exercise5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.LessonA)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(528, 390)
        Me.TabControl1.TabIndex = 0
        '
        'LessonA
        '
        Me.LessonA.Controls.Add(Me.TabControl2)
        Me.LessonA.Location = New System.Drawing.Point(4, 27)
        Me.LessonA.Name = "LessonA"
        Me.LessonA.Padding = New System.Windows.Forms.Padding(3)
        Me.LessonA.Size = New System.Drawing.Size(520, 359)
        Me.LessonA.TabIndex = 0
        Me.LessonA.Text = "Lesson A"
        Me.LessonA.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.exercise5)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(514, 353)
        Me.TabControl2.TabIndex = 0
        '
        'exercise5
        '
        Me.exercise5.Controls.Add(Me.lblPay)
        Me.exercise5.Controls.Add(Me.lblWord2)
        Me.exercise5.Controls.Add(Me.lblWord1)
        Me.exercise5.Controls.Add(Me.lblCity)
        Me.exercise5.Controls.Add(Me.lblSize)
        Me.exercise5.Location = New System.Drawing.Point(4, 27)
        Me.exercise5.Name = "exercise5"
        Me.exercise5.Padding = New System.Windows.Forms.Padding(3)
        Me.exercise5.Size = New System.Drawing.Size(506, 322)
        Me.exercise5.TabIndex = 0
        Me.exercise5.Text = "Exercise 5"
        Me.exercise5.UseVisualStyleBackColor = True
        '
        'lblWord1
        '
        Me.lblWord1.AutoSize = True
        Me.lblWord1.Location = New System.Drawing.Point(60, 191)
        Me.lblWord1.Name = "lblWord1"
        Me.lblWord1.Size = New System.Drawing.Size(56, 18)
        Me.lblWord1.TabIndex = 2
        Me.lblWord1.Text = "Label1"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(60, 153)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(56, 18)
        Me.lblCity.TabIndex = 1
        Me.lblCity.Text = "Label1"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(60, 124)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(56, 18)
        Me.lblSize.TabIndex = 0
        Me.lblSize.Text = "Label1"
        '
        'lblWord2
        '
        Me.lblWord2.AutoSize = True
        Me.lblWord2.Location = New System.Drawing.Point(60, 232)
        Me.lblWord2.Name = "lblWord2"
        Me.lblWord2.Size = New System.Drawing.Size(56, 18)
        Me.lblWord2.TabIndex = 3
        Me.lblWord2.Text = "Label1"
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Location = New System.Drawing.Point(63, 271)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(56, 18)
        Me.lblPay.TabIndex = 4
        Me.lblPay.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 390)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.LessonA.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.exercise5.ResumeLayout(False)
        Me.exercise5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents LessonA As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents exercise5 As System.Windows.Forms.TabPage
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblWord1 As System.Windows.Forms.Label
    Friend WithEvents lblWord2 As System.Windows.Forms.Label
    Friend WithEvents lblPay As System.Windows.Forms.Label

End Class
