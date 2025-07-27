<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPage
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusLbl = New System.Windows.Forms.Label()
        Me.DirToReg = New System.Windows.Forms.LinkLabel()
        Me.RmBtn = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.LoginBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordTextbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LoginTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Panel1.Controls.Add(Me.StatusLbl)
        Me.Panel1.Controls.Add(Me.DirToReg)
        Me.Panel1.Controls.Add(Me.RmBtn)
        Me.Panel1.Controls.Add(Me.LoginBtn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PasswordTextbox)
        Me.Panel1.Controls.Add(Me.LoginTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(321, 219)
        Me.Panel1.TabIndex = 2
        '
        'StatusLbl
        '
        Me.StatusLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.StatusLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.StatusLbl.ForeColor = System.Drawing.Color.Red
        Me.StatusLbl.Location = New System.Drawing.Point(38, 56)
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(245, 18)
        Me.StatusLbl.TabIndex = 32
        Me.StatusLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DirToReg
        '
        Me.DirToReg.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.DirToReg.AutoSize = True
        Me.DirToReg.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DirToReg.LinkColor = System.Drawing.Color.DarkGray
        Me.DirToReg.Location = New System.Drawing.Point(82, 192)
        Me.DirToReg.Name = "DirToReg"
        Me.DirToReg.Size = New System.Drawing.Size(156, 15)
        Me.DirToReg.TabIndex = 29
        Me.DirToReg.TabStop = True
        Me.DirToReg.Text = "You don't have account yet?"
        '
        'RmBtn
        '
        Me.RmBtn.AutoSize = True
        Me.RmBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RmBtn.CheckedState.BorderRadius = 5
        Me.RmBtn.CheckedState.BorderThickness = 0
        Me.RmBtn.CheckedState.FillColor = System.Drawing.Color.RoyalBlue
        Me.RmBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RmBtn.ForeColor = System.Drawing.Color.Gray
        Me.RmBtn.Location = New System.Drawing.Point(50, 143)
        Me.RmBtn.Name = "RmBtn"
        Me.RmBtn.Size = New System.Drawing.Size(104, 19)
        Me.RmBtn.TabIndex = 28
        Me.RmBtn.Text = "Remember me"
        Me.RmBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RmBtn.UncheckedState.BorderRadius = 5
        Me.RmBtn.UncheckedState.BorderThickness = 0
        Me.RmBtn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RmBtn.UseVisualStyleBackColor = True
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
        Me.LoginBtn.Location = New System.Drawing.Point(184, 143)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.ShadowDecoration.BorderRadius = 12
        Me.LoginBtn.ShadowDecoration.Depth = 10
        Me.LoginBtn.ShadowDecoration.Enabled = True
        Me.LoginBtn.ShadowDecoration.Parent = Me.LoginBtn
        Me.LoginBtn.Size = New System.Drawing.Size(86, 26)
        Me.LoginBtn.TabIndex = 27
        Me.LoginBtn.Text = "Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(101, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 18)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "MEMBER LOGIN"
        '
        'PasswordTextbox
        '
        Me.PasswordTextbox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.PasswordTextbox.BorderRadius = 3
        Me.PasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTextbox.DefaultText = ""
        Me.PasswordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTextbox.DisabledState.Parent = Me.PasswordTextbox
        Me.PasswordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTextbox.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.PasswordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.PasswordTextbox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.PasswordTextbox.FocusedState.Parent = Me.PasswordTextbox
        Me.PasswordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTextbox.HoverState.Parent = Me.PasswordTextbox
        Me.PasswordTextbox.IconLeftSize = New System.Drawing.Size(0, 0)
        Me.PasswordTextbox.IconRightSize = New System.Drawing.Size(0, 0)
        Me.PasswordTextbox.Location = New System.Drawing.Point(50, 110)
        Me.PasswordTextbox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PasswordTextbox.Name = "PasswordTextbox"
        Me.PasswordTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTextbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.PasswordTextbox.PlaceholderText = "Password"
        Me.PasswordTextbox.SelectedText = ""
        Me.PasswordTextbox.ShadowDecoration.Parent = Me.PasswordTextbox
        Me.PasswordTextbox.Size = New System.Drawing.Size(220, 27)
        Me.PasswordTextbox.TabIndex = 25
        Me.PasswordTextbox.UseSystemPasswordChar = True
        '
        'LoginTextBox
        '
        Me.LoginTextBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.LoginTextBox.BorderRadius = 3
        Me.LoginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LoginTextBox.DefaultText = ""
        Me.LoginTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.LoginTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LoginTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LoginTextBox.DisabledState.Parent = Me.LoginTextBox
        Me.LoginTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LoginTextBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.LoginTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.LoginTextBox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.LoginTextBox.FocusedState.Parent = Me.LoginTextBox
        Me.LoginTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginTextBox.HoverState.Parent = Me.LoginTextBox
        Me.LoginTextBox.IconLeftSize = New System.Drawing.Size(0, 0)
        Me.LoginTextBox.IconRightSize = New System.Drawing.Size(0, 0)
        Me.LoginTextBox.Location = New System.Drawing.Point(50, 77)
        Me.LoginTextBox.Name = "LoginTextBox"
        Me.LoginTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LoginTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LoginTextBox.PlaceholderText = "Username"
        Me.LoginTextBox.SelectedText = ""
        Me.LoginTextBox.ShadowDecoration.Parent = Me.LoginTextBox
        Me.LoginTextBox.Size = New System.Drawing.Size(220, 27)
        Me.LoginTextBox.TabIndex = 24
        '
        'LoginPage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(321, 219)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginPage"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "LoginPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RmBtn As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents LoginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordTextbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LoginTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DirToReg As LinkLabel
    Friend WithEvents StatusLbl As Label
End Class
