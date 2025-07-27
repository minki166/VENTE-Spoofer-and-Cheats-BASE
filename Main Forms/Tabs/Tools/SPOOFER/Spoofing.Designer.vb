<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Spoofing
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Spoofing))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Separator4 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Logs = New System.Windows.Forms.Label()
        Me.Bypass = New System.Windows.Forms.Label()
        Me.SpoofindID = New System.Windows.Forms.Label()
        Me.Action = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.Label()
        Me.bar = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TopBar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.StartAnimColour = New System.Windows.Forms.Timer(Me.components)
        Me.AnimColor = New Guna.UI2.WinForms.Guna2ColorTransition(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Starting = New System.Windows.Forms.Timer(Me.components)
        Me.Second = New System.Windows.Forms.Timer(Me.components)
        Me.CloseBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.TopBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CloseBtn)
        Me.Panel1.Controls.Add(Me.Guna2GroupBox1)
        Me.Panel1.Controls.Add(Me.TopBar)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(658, 421)
        Me.Panel1.TabIndex = 0
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2GroupBox1.BorderRadius = 4
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Separator4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Separator3)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Separator2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2GroupBox1.Controls.Add(Me.Logs)
        Me.Guna2GroupBox1.Controls.Add(Me.Bypass)
        Me.Guna2GroupBox1.Controls.Add(Me.SpoofindID)
        Me.Guna2GroupBox1.Controls.Add(Me.Action)
        Me.Guna2GroupBox1.Controls.Add(Me.Status)
        Me.Guna2GroupBox1.Controls.Add(Me.bar)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(107, 80)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(444, 261)
        Me.Guna2GroupBox1.TabIndex = 12
        '
        'Guna2Separator4
        '
        Me.Guna2Separator4.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2Separator4.Location = New System.Drawing.Point(33, 192)
        Me.Guna2Separator4.Name = "Guna2Separator4"
        Me.Guna2Separator4.Size = New System.Drawing.Size(394, 10)
        Me.Guna2Separator4.TabIndex = 16
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2Separator3.Location = New System.Drawing.Point(33, 164)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(394, 10)
        Me.Guna2Separator3.TabIndex = 15
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2Separator2.Location = New System.Drawing.Point(33, 135)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(394, 10)
        Me.Guna2Separator2.TabIndex = 14
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Guna2Separator1.Location = New System.Drawing.Point(33, 104)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(394, 10)
        Me.Guna2Separator1.TabIndex = 13
        '
        'Logs
        '
        Me.Logs.BackColor = System.Drawing.Color.Transparent
        Me.Logs.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Logs.ForeColor = System.Drawing.Color.Silver
        Me.Logs.Location = New System.Drawing.Point(124, 204)
        Me.Logs.Name = "Logs"
        Me.Logs.Size = New System.Drawing.Size(303, 19)
        Me.Logs.TabIndex = 12
        Me.Logs.Text = "Status:"
        Me.Logs.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Bypass
        '
        Me.Bypass.BackColor = System.Drawing.Color.Transparent
        Me.Bypass.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Bypass.ForeColor = System.Drawing.Color.Silver
        Me.Bypass.Location = New System.Drawing.Point(124, 172)
        Me.Bypass.Name = "Bypass"
        Me.Bypass.Size = New System.Drawing.Size(303, 19)
        Me.Bypass.TabIndex = 11
        Me.Bypass.Text = "Status:"
        Me.Bypass.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SpoofindID
        '
        Me.SpoofindID.BackColor = System.Drawing.Color.Transparent
        Me.SpoofindID.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SpoofindID.ForeColor = System.Drawing.Color.Silver
        Me.SpoofindID.Location = New System.Drawing.Point(124, 144)
        Me.SpoofindID.Name = "SpoofindID"
        Me.SpoofindID.Size = New System.Drawing.Size(303, 19)
        Me.SpoofindID.TabIndex = 10
        Me.SpoofindID.Text = "Status:"
        Me.SpoofindID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Action
        '
        Me.Action.BackColor = System.Drawing.Color.Transparent
        Me.Action.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Action.ForeColor = System.Drawing.Color.Silver
        Me.Action.Location = New System.Drawing.Point(124, 115)
        Me.Action.Name = "Action"
        Me.Action.Size = New System.Drawing.Size(303, 19)
        Me.Action.TabIndex = 9
        Me.Action.Text = "Status:"
        Me.Action.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Status
        '
        Me.Status.BackColor = System.Drawing.Color.Transparent
        Me.Status.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Status.ForeColor = System.Drawing.Color.Silver
        Me.Status.Location = New System.Drawing.Point(124, 84)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(303, 19)
        Me.Status.TabIndex = 8
        Me.Status.Text = "Status:"
        Me.Status.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'bar
        '
        Me.bar.AnimationSpeed = 53
        Me.bar.AutoStart = True
        Me.bar.CircleSize = 0.3!
        Me.bar.Location = New System.Drawing.Point(408, 226)
        Me.bar.Name = "bar"
        Me.bar.NumberOfCircles = 6
        Me.bar.ProgressColor = System.Drawing.Color.RoyalBlue
        Me.bar.Size = New System.Drawing.Size(29, 29)
        Me.bar.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label7.Location = New System.Drawing.Point(29, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Logs:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label6.Location = New System.Drawing.Point(29, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Bypass:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label4.Location = New System.Drawing.Point(29, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Spoofing ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label3.Location = New System.Drawing.Point(29, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Action:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label2.Location = New System.Drawing.Point(29, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Status:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label5.Location = New System.Drawing.Point(177, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "SPOOFING"
        '
        'TopBar
        '
        Me.TopBar.BackgroundImage = CType(resources.GetObject("TopBar.BackgroundImage"), System.Drawing.Image)
        Me.TopBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TopBar.Controls.Add(Me.Label1)
        Me.TopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopBar.Location = New System.Drawing.Point(0, 0)
        Me.TopBar.Name = "TopBar"
        Me.TopBar.Size = New System.Drawing.Size(658, 53)
        Me.TopBar.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(304, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "VENTE"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.TargetControl = Me.Panel1
        '
        'StartAnimColour
        '
        Me.StartAnimColour.Enabled = True
        Me.StartAnimColour.Interval = 3
        '
        'AnimColor
        '
        Me.AnimColor.AutoTransition = True
        Me.AnimColor.ColorArray = New System.Drawing.Color() {System.Drawing.Color.RoyalBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Gray}
        Me.AnimColor.EndColor = System.Drawing.Color.DodgerBlue
        Me.AnimColor.ProgressValue = 3
        Me.AnimColor.StartColor = System.Drawing.Color.RoyalBlue
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.TopBar
        '
        'Starting
        '
        Me.Starting.Enabled = True
        Me.Starting.Interval = 3000
        '
        'Second
        '
        Me.Second.Interval = 1000
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Transparent
        Me.CloseBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.CloseBtn.BorderRadius = 3
        Me.CloseBtn.BorderThickness = 1
        Me.CloseBtn.CheckedState.Parent = Me.CloseBtn
        Me.CloseBtn.CustomImages.Parent = Me.CloseBtn
        Me.CloseBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.CloseBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CloseBtn.ForeColor = System.Drawing.Color.LightSlateGray
        Me.CloseBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.CloseBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.CloseBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.CloseBtn.HoverState.Parent = Me.CloseBtn
        Me.CloseBtn.Location = New System.Drawing.Point(252, 359)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.ShadowDecoration.BorderRadius = 12
        Me.CloseBtn.ShadowDecoration.Depth = 10
        Me.CloseBtn.ShadowDecoration.Enabled = True
        Me.CloseBtn.ShadowDecoration.Parent = Me.CloseBtn
        Me.CloseBtn.Size = New System.Drawing.Size(154, 28)
        Me.CloseBtn.TabIndex = 23
        Me.CloseBtn.Text = "CLOSE"
        Me.CloseBtn.Visible = False
        '
        'Spoofing
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(660, 423)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Spoofing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spoofing"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.TopBar.ResumeLayout(False)
        Me.TopBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TopBar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents StartAnimColour As Timer
    Friend WithEvents AnimColor As Guna.UI2.WinForms.Guna2ColorTransition
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents bar As Guna.UI2.WinForms.Guna2WinProgressIndicator
    Friend WithEvents Logs As Label
    Friend WithEvents Bypass As Label
    Friend WithEvents SpoofindID As Label
    Friend WithEvents Action As Label
    Friend WithEvents Status As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Starting As Timer
    Friend WithEvents Second As Timer
    Friend WithEvents Guna2Separator4 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents CloseBtn As Guna.UI2.WinForms.Guna2Button
End Class
