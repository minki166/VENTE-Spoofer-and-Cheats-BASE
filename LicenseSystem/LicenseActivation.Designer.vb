<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LicenseActivation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LicenseActivation))
        Me.TopBar = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LeftBar = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatusLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ActivateBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LicTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AnimScale = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TopBar.SuspendLayout()
        Me.LeftBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopBar
        '
        Me.TopBar.BackgroundImage = CType(resources.GetObject("TopBar.BackgroundImage"), System.Drawing.Image)
        Me.TopBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TopBar.Controls.Add(Me.Guna2ControlBox1)
        Me.TopBar.Controls.Add(Me.Label1)
        Me.TopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopBar.Location = New System.Drawing.Point(0, 0)
        Me.TopBar.Name = "TopBar"
        Me.TopBar.Size = New System.Drawing.Size(593, 59)
        Me.TopBar.TabIndex = 11
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Guna2ControlBox1.BorderRadius = 6
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(564, 1)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(29, 18)
        Me.Guna2ControlBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(271, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "VENTE"
        '
        'LeftBar
        '
        Me.LeftBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.LeftBar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.LeftBar.BorderRadius = 9
        Me.LeftBar.Controls.Add(Me.Label6)
        Me.LeftBar.Controls.Add(Me.StatusLbl)
        Me.LeftBar.Controls.Add(Me.Label2)
        Me.LeftBar.Controls.Add(Me.ActivateBtn)
        Me.LeftBar.Controls.Add(Me.Label5)
        Me.LeftBar.Controls.Add(Me.LicTextBox)
        Me.LeftBar.Controls.Add(Me.Guna2Separator1)
        Me.LeftBar.Controls.Add(Me.Label4)
        Me.LeftBar.Controls.Add(Me.Label3)
        Me.LeftBar.Controls.Add(Me.PictureBox1)
        Me.LeftBar.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.LeftBar.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.LeftBar.FillColor = System.Drawing.Color.Transparent
        Me.LeftBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LeftBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LeftBar.Location = New System.Drawing.Point(16, 53)
        Me.LeftBar.Name = "LeftBar"
        Me.LeftBar.ShadowDecoration.Parent = Me.LeftBar
        Me.LeftBar.Size = New System.Drawing.Size(560, 290)
        Me.LeftBar.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(245, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Get license"
        '
        'StatusLbl
        '
        Me.StatusLbl.BackColor = System.Drawing.Color.Transparent
        Me.StatusLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.StatusLbl.ForeColor = System.Drawing.Color.Crimson
        Me.StatusLbl.Location = New System.Drawing.Point(97, 212)
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(367, 47)
        Me.StatusLbl.TabIndex = 31
        Me.StatusLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.StatusLbl.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(195, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "https://ventecheat.shop/"
        '
        'ActivateBtn
        '
        Me.ActivateBtn.BackColor = System.Drawing.Color.Transparent
        Me.ActivateBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ActivateBtn.BorderRadius = 3
        Me.ActivateBtn.BorderThickness = 1
        Me.ActivateBtn.CheckedState.Parent = Me.ActivateBtn
        Me.ActivateBtn.CustomImages.Parent = Me.ActivateBtn
        Me.ActivateBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ActivateBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ActivateBtn.ForeColor = System.Drawing.Color.Gray
        Me.ActivateBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ActivateBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ActivateBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.ActivateBtn.HoverState.Parent = Me.ActivateBtn
        Me.ActivateBtn.Location = New System.Drawing.Point(342, 179)
        Me.ActivateBtn.Name = "ActivateBtn"
        Me.ActivateBtn.ShadowDecoration.BorderRadius = 12
        Me.ActivateBtn.ShadowDecoration.Depth = 10
        Me.ActivateBtn.ShadowDecoration.Enabled = True
        Me.ActivateBtn.ShadowDecoration.Parent = Me.ActivateBtn
        Me.ActivateBtn.Size = New System.Drawing.Size(119, 27)
        Me.ActivateBtn.TabIndex = 28
        Me.ActivateBtn.Text = "Activate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(234, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "License key"
        '
        'LicTextBox
        '
        Me.LicTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.LicTextBox.BorderRadius = 3
        Me.LicTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LicTextBox.DefaultText = ""
        Me.LicTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.LicTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LicTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LicTextBox.DisabledState.Parent = Me.LicTextBox
        Me.LicTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LicTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.LicTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.LicTextBox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.LicTextBox.FocusedState.Parent = Me.LicTextBox
        Me.LicTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LicTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LicTextBox.HoverState.Parent = Me.LicTextBox
        Me.LicTextBox.IconLeftSize = New System.Drawing.Size(0, 0)
        Me.LicTextBox.IconRightSize = New System.Drawing.Size(0, 0)
        Me.LicTextBox.Location = New System.Drawing.Point(238, 139)
        Me.LicTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LicTextBox.Name = "LicTextBox"
        Me.LicTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LicTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.LicTextBox.PlaceholderText = "XXXX-aaaa-bbbb-cccc-dddd"
        Me.LicTextBox.SelectedText = ""
        Me.LicTextBox.ShadowDecoration.Parent = Me.LicTextBox
        Me.LicTextBox.Size = New System.Drawing.Size(223, 34)
        Me.LicTextBox.TabIndex = 25
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2Separator1.Location = New System.Drawing.Point(265, 43)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(31, 10)
        Me.Guna2Separator1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 11.75!)
        Me.Label4.ForeColor = System.Drawing.Color.Ivory
        Me.Label4.Location = New System.Drawing.Point(234, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 38)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Upgrade your VENTE account!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "get software and cheats!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(209, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "LICENSE ACTIVATION"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.vente.My.Resources.Resources.MediumLogoBlue
        Me.PictureBox1.Location = New System.Drawing.Point(100, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'AnimScale
        '
        Me.AnimScale.Enabled = True
        Me.AnimScale.Interval = 1
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.TopBar
        '
        'LicenseActivation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(593, 355)
        Me.Controls.Add(Me.LeftBar)
        Me.Controls.Add(Me.TopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(593, 355)
        Me.Name = "LicenseActivation"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTE | LICENSING"
        Me.TopMost = True
        Me.TopBar.ResumeLayout(False)
        Me.TopBar.PerformLayout()
        Me.LeftBar.ResumeLayout(False)
        Me.LeftBar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopBar As Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LeftBar As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LicTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ActivateBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AnimScale As Timer
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents StatusLbl As Label
    Friend WithEvents Timer1 As Timer
End Class
