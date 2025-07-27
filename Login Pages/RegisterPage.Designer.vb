<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterPage
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LoginBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RegisterDiscord = New Guna.UI2.WinForms.Guna2TextBox()
        Me.RegisterLogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.RegisterPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusLbl = New System.Windows.Forms.Label()
        Me.DirToReg = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.Transparent
        Me.LoginBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.LoginBtn.BorderRadius = 3
        Me.LoginBtn.BorderThickness = 1
        Me.LoginBtn.CheckedState.Parent = Me.LoginBtn
        Me.LoginBtn.CustomImages.Parent = Me.LoginBtn
        Me.LoginBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.LoginBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.LoginBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.LoginBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.LoginBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.LoginBtn.HoverState.Parent = Me.LoginBtn
        Me.LoginBtn.Location = New System.Drawing.Point(96, 166)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.ShadowDecoration.BorderRadius = 12
        Me.LoginBtn.ShadowDecoration.Depth = 10
        Me.LoginBtn.ShadowDecoration.Enabled = True
        Me.LoginBtn.ShadowDecoration.Parent = Me.LoginBtn
        Me.LoginBtn.Size = New System.Drawing.Size(128, 25)
        Me.LoginBtn.TabIndex = 17
        Me.LoginBtn.Text = "Create account"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(73, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "MEMBER REGISTRATION"
        '
        'RegisterDiscord
        '
        Me.RegisterDiscord.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.RegisterDiscord.BorderRadius = 3
        Me.RegisterDiscord.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RegisterDiscord.DefaultText = ""
        Me.RegisterDiscord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.RegisterDiscord.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.RegisterDiscord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RegisterDiscord.DisabledState.Parent = Me.RegisterDiscord
        Me.RegisterDiscord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RegisterDiscord.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.RegisterDiscord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.RegisterDiscord.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.RegisterDiscord.FocusedState.Parent = Me.RegisterDiscord
        Me.RegisterDiscord.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegisterDiscord.HoverState.Parent = Me.RegisterDiscord
        Me.RegisterDiscord.Location = New System.Drawing.Point(50, 101)
        Me.RegisterDiscord.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RegisterDiscord.Name = "RegisterDiscord"
        Me.RegisterDiscord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RegisterDiscord.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RegisterDiscord.PlaceholderText = "Discord Name"
        Me.RegisterDiscord.SelectedText = ""
        Me.RegisterDiscord.ShadowDecoration.Parent = Me.RegisterDiscord
        Me.RegisterDiscord.Size = New System.Drawing.Size(220, 27)
        Me.RegisterDiscord.TabIndex = 15
        '
        'RegisterLogin
        '
        Me.RegisterLogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.RegisterLogin.BorderRadius = 3
        Me.RegisterLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RegisterLogin.DefaultText = ""
        Me.RegisterLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.RegisterLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.RegisterLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RegisterLogin.DisabledState.Parent = Me.RegisterLogin
        Me.RegisterLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RegisterLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.RegisterLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.RegisterLogin.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.RegisterLogin.FocusedState.Parent = Me.RegisterLogin
        Me.RegisterLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegisterLogin.HoverState.Parent = Me.RegisterLogin
        Me.RegisterLogin.IconRightOffset = New System.Drawing.Point(5, 5)
        Me.RegisterLogin.Location = New System.Drawing.Point(50, 67)
        Me.RegisterLogin.Name = "RegisterLogin"
        Me.RegisterLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RegisterLogin.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RegisterLogin.PlaceholderText = "Username"
        Me.RegisterLogin.SelectedText = ""
        Me.RegisterLogin.ShadowDecoration.Parent = Me.RegisterLogin
        Me.RegisterLogin.Size = New System.Drawing.Size(220, 27)
        Me.RegisterLogin.TabIndex = 14
        '
        'RegisterPassword
        '
        Me.RegisterPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.RegisterPassword.BorderRadius = 3
        Me.RegisterPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RegisterPassword.DefaultText = ""
        Me.RegisterPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.RegisterPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.RegisterPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RegisterPassword.DisabledState.Parent = Me.RegisterPassword
        Me.RegisterPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RegisterPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.RegisterPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.RegisterPassword.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.RegisterPassword.FocusedState.Parent = Me.RegisterPassword
        Me.RegisterPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegisterPassword.HoverState.Parent = Me.RegisterPassword
        Me.RegisterPassword.Location = New System.Drawing.Point(50, 134)
        Me.RegisterPassword.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RegisterPassword.Name = "RegisterPassword"
        Me.RegisterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.RegisterPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RegisterPassword.PlaceholderText = "Password"
        Me.RegisterPassword.SelectedText = ""
        Me.RegisterPassword.ShadowDecoration.Parent = Me.RegisterPassword
        Me.RegisterPassword.Size = New System.Drawing.Size(220, 27)
        Me.RegisterPassword.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.StatusLbl)
        Me.Panel1.Controls.Add(Me.DirToReg)
        Me.Panel1.Controls.Add(Me.RegisterPassword)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LoginBtn)
        Me.Panel1.Controls.Add(Me.RegisterLogin)
        Me.Panel1.Controls.Add(Me.RegisterDiscord)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(321, 219)
        Me.Panel1.TabIndex = 19
        '
        'StatusLbl
        '
        Me.StatusLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.StatusLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.StatusLbl.ForeColor = System.Drawing.Color.Red
        Me.StatusLbl.Location = New System.Drawing.Point(38, 49)
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(245, 18)
        Me.StatusLbl.TabIndex = 31
        Me.StatusLbl.Text = "User with this username already exists"
        Me.StatusLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.StatusLbl.Visible = False
        '
        'DirToReg
        '
        Me.DirToReg.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.DirToReg.AutoSize = True
        Me.DirToReg.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DirToReg.LinkColor = System.Drawing.Color.DarkGray
        Me.DirToReg.Location = New System.Drawing.Point(122, 196)
        Me.DirToReg.Name = "DirToReg"
        Me.DirToReg.Size = New System.Drawing.Size(76, 15)
        Me.DirToReg.TabIndex = 30
        Me.DirToReg.TabStop = True
        Me.DirToReg.Text = "Back to login"
        '
        'RegisterPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(321, 219)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RegisterDiscord As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents RegisterLogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents RegisterPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DirToReg As LinkLabel
    Friend WithEvents StatusLbl As Label
End Class
