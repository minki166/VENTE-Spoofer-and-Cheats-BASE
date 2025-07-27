<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RustImgui
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RustImgui))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.TopBar = New System.Windows.Forms.Panel()
        Me.uSER = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Mother = New System.Windows.Forms.Panel()
        Me.Miscbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.VisaualsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.AimTabBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ec = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Shadow = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.TopBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.TopBar
        '
        'TopBar
        '
        Me.TopBar.BackgroundImage = CType(resources.GetObject("TopBar.BackgroundImage"), System.Drawing.Image)
        Me.TopBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TopBar.Controls.Add(Me.uSER)
        Me.TopBar.Controls.Add(Me.Label1)
        Me.TopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopBar.Location = New System.Drawing.Point(0, 0)
        Me.TopBar.Name = "TopBar"
        Me.TopBar.Size = New System.Drawing.Size(877, 53)
        Me.TopBar.TabIndex = 13
        '
        'uSER
        '
        Me.uSER.BackColor = System.Drawing.Color.Transparent
        Me.uSER.Font = New System.Drawing.Font("Bahnschrift SemiBold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.uSER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.uSER.Location = New System.Drawing.Point(664, 3)
        Me.uSER.Name = "uSER"
        Me.uSER.Size = New System.Drawing.Size(210, 17)
        Me.uSER.TabIndex = 2
        Me.uSER.Text = "VENTE"
        Me.uSER.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(413, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "VENTE"
        '
        'Mother
        '
        Me.Mother.Location = New System.Drawing.Point(12, 77)
        Me.Mother.Name = "Mother"
        Me.Mother.Size = New System.Drawing.Size(853, 510)
        Me.Mother.TabIndex = 17
        '
        'Miscbtn
        '
        Me.Miscbtn.Animated = True
        Me.Miscbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Miscbtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Miscbtn.BorderRadius = 6
        Me.Miscbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Miscbtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Miscbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Miscbtn.CheckedState.Image = Global.vente.My.Resources.Resources.Settings
        Me.Miscbtn.CheckedState.Parent = Me.Miscbtn
        Me.Miscbtn.CustomImages.Parent = Me.Miscbtn
        Me.Miscbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Miscbtn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Miscbtn.ForeColor = System.Drawing.Color.Silver
        Me.Miscbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Miscbtn.HoverState.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Miscbtn.HoverState.Image = Global.vente.My.Resources.Resources.Settings
        Me.Miscbtn.HoverState.Parent = Me.Miscbtn
        Me.Miscbtn.Image = Global.vente.My.Resources.Resources.see
        Me.Miscbtn.ImageSize = New System.Drawing.Size(24, 24)
        Me.Miscbtn.Location = New System.Drawing.Point(565, 36)
        Me.Miscbtn.Name = "Miscbtn"
        Me.Miscbtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Miscbtn.ShadowDecoration.BorderRadius = 20
        Me.Miscbtn.ShadowDecoration.Depth = 10
        Me.Miscbtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Miscbtn.ShadowDecoration.Parent = Me.Miscbtn
        Me.Miscbtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.Miscbtn.Size = New System.Drawing.Size(266, 35)
        Me.Miscbtn.TabIndex = 16
        Me.Miscbtn.Text = "MISC"
        Me.Miscbtn.TextOffset = New System.Drawing.Point(1, 1)
        '
        'VisaualsBtn
        '
        Me.VisaualsBtn.Animated = True
        Me.VisaualsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.VisaualsBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.VisaualsBtn.BorderRadius = 6
        Me.VisaualsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.VisaualsBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.VisaualsBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.VisaualsBtn.CheckedState.Image = Global.vente.My.Resources.Resources.ClrdM
        Me.VisaualsBtn.CheckedState.Parent = Me.VisaualsBtn
        Me.VisaualsBtn.CustomImages.Parent = Me.VisaualsBtn
        Me.VisaualsBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.VisaualsBtn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.VisaualsBtn.ForeColor = System.Drawing.Color.Silver
        Me.VisaualsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.VisaualsBtn.HoverState.ForeColor = System.Drawing.Color.RoyalBlue
        Me.VisaualsBtn.HoverState.Image = Global.vente.My.Resources.Resources.ClrdM
        Me.VisaualsBtn.HoverState.Parent = Me.VisaualsBtn
        Me.VisaualsBtn.Image = Global.vente.My.Resources.Resources.Fill_Color
        Me.VisaualsBtn.ImageSize = New System.Drawing.Size(24, 24)
        Me.VisaualsBtn.Location = New System.Drawing.Point(304, 40)
        Me.VisaualsBtn.Name = "VisaualsBtn"
        Me.VisaualsBtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.VisaualsBtn.ShadowDecoration.BorderRadius = 20
        Me.VisaualsBtn.ShadowDecoration.Depth = 10
        Me.VisaualsBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.VisaualsBtn.ShadowDecoration.Parent = Me.VisaualsBtn
        Me.VisaualsBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.VisaualsBtn.Size = New System.Drawing.Size(255, 35)
        Me.VisaualsBtn.TabIndex = 15
        Me.VisaualsBtn.Text = "ESP/VISUALS"
        Me.VisaualsBtn.TextOffset = New System.Drawing.Point(1, 1)
        '
        'AimTabBtn
        '
        Me.AimTabBtn.Animated = True
        Me.AimTabBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.AimTabBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.AimTabBtn.BorderRadius = 6
        Me.AimTabBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.AimTabBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.AimTabBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.AimTabBtn.CheckedState.Image = Global.vente.My.Resources.Resources.Clrd
        Me.AimTabBtn.CheckedState.Parent = Me.AimTabBtn
        Me.AimTabBtn.CustomImages.Parent = Me.AimTabBtn
        Me.AimTabBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.AimTabBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.AimTabBtn.ForeColor = System.Drawing.Color.Silver
        Me.AimTabBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.AimTabBtn.HoverState.ForeColor = System.Drawing.Color.RoyalBlue
        Me.AimTabBtn.HoverState.Image = Global.vente.My.Resources.Resources.Clrd
        Me.AimTabBtn.HoverState.Parent = Me.AimTabBtn
        Me.AimTabBtn.Image = Global.vente.My.Resources.Resources.Center_of_Gravity
        Me.AimTabBtn.ImageSize = New System.Drawing.Size(24, 24)
        Me.AimTabBtn.Location = New System.Drawing.Point(31, 36)
        Me.AimTabBtn.Name = "AimTabBtn"
        Me.AimTabBtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.AimTabBtn.ShadowDecoration.BorderRadius = 20
        Me.AimTabBtn.ShadowDecoration.Depth = 10
        Me.AimTabBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.AimTabBtn.ShadowDecoration.Parent = Me.AimTabBtn
        Me.AimTabBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.AimTabBtn.Size = New System.Drawing.Size(268, 35)
        Me.AimTabBtn.TabIndex = 14
        Me.AimTabBtn.Text = "AIMBOT"
        Me.AimTabBtn.TextOffset = New System.Drawing.Point(1, 1)
        '
        'ec
        '
        Me.ec.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ec.BorderRadius = 3
        Me.ec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ec.DefaultText = ""
        Me.ec.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ec.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ec.DisabledState.Parent = Me.ec
        Me.ec.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ec.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ec.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ec.FocusedState.Parent = Me.ec
        Me.ec.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ec.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ec.HoverState.Parent = Me.ec
        Me.ec.IconLeftSize = New System.Drawing.Size(0, 0)
        Me.ec.IconRightSize = New System.Drawing.Size(0, 0)
        Me.ec.Location = New System.Drawing.Point(871, 592)
        Me.ec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ec.Name = "ec"
        Me.ec.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ec.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ec.PlaceholderText = ""
        Me.ec.SelectedText = ""
        Me.ec.ShadowDecoration.Parent = Me.ec
        Me.ec.Size = New System.Drawing.Size(48, 42)
        Me.ec.TabIndex = 29
        Me.ec.Visible = False
        '
        'RustImgui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(877, 599)
        Me.Controls.Add(Me.ec)
        Me.Controls.Add(Me.Mother)
        Me.Controls.Add(Me.Miscbtn)
        Me.Controls.Add(Me.VisaualsBtn)
        Me.Controls.Add(Me.AimTabBtn)
        Me.Controls.Add(Me.TopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RustImgui"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RustImgui"
        Me.TopBar.ResumeLayout(False)
        Me.TopBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopBar As Panel
    Friend WithEvents uSER As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Miscbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents VisaualsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AimTabBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Mother As Panel
    Friend WithEvents ec As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Shadow As Guna.UI2.WinForms.Guna2ShadowForm
End Class
