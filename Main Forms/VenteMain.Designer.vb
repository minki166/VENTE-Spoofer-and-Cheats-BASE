<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VenteMain
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VenteMain))
        Me.Mother = New System.Windows.Forms.Panel()
        Me.MotherBox = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.MotherPanel = New System.Windows.Forms.Panel()
        Me.LeftBar = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.CheatsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SpooferBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.HomeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TopBar = New System.Windows.Forms.Panel()
        Me.UsernameLbl = New System.Windows.Forms.Label()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BottomBar = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.ColorAnim = New Guna.UI2.WinForms.Guna2ColorTransition(Me.components)
        Me.AnimColorEngine = New System.Windows.Forms.Timer(Me.components)
        Me.MotherAnim = New Guna.UI2.WinForms.Guna2Transition()
        Me.Movable = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Movable2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.LicenseRefresher = New System.Windows.Forms.Timer(Me.components)
        Me.Mother.SuspendLayout()
        Me.MotherBox.SuspendLayout()
        Me.LeftBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopBar.SuspendLayout()
        Me.BottomBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Mother
        '
        Me.Mother.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Mother.Controls.Add(Me.MotherBox)
        Me.Mother.Controls.Add(Me.LeftBar)
        Me.Mother.Controls.Add(Me.TopBar)
        Me.Mother.Controls.Add(Me.Button2)
        Me.Mother.Controls.Add(Me.Button1)
        Me.Mother.Controls.Add(Me.BottomBar)
        Me.MotherAnim.SetDecoration(Me.Mother, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Mother.Location = New System.Drawing.Point(0, 0)
        Me.Mother.Name = "Mother"
        Me.Mother.Size = New System.Drawing.Size(895, 609)
        Me.Mother.TabIndex = 7
        '
        'MotherBox
        '
        Me.MotherBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.MotherBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.MotherBox.BorderRadius = 9
        Me.MotherBox.Controls.Add(Me.MotherPanel)
        Me.MotherBox.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.MotherBox.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.MotherAnim.SetDecoration(Me.MotherBox, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.MotherBox.FillColor = System.Drawing.Color.Transparent
        Me.MotherBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MotherBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.MotherBox.Location = New System.Drawing.Point(94, 39)
        Me.MotherBox.Name = "MotherBox"
        Me.MotherBox.ShadowDecoration.Parent = Me.MotherBox
        Me.MotherBox.Size = New System.Drawing.Size(789, 542)
        Me.MotherBox.TabIndex = 12
        Me.MotherBox.Visible = False
        '
        'MotherPanel
        '
        Me.MotherPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MotherAnim.SetDecoration(Me.MotherPanel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.MotherPanel.Location = New System.Drawing.Point(11, 9)
        Me.MotherPanel.Name = "MotherPanel"
        Me.MotherPanel.Size = New System.Drawing.Size(767, 524)
        Me.MotherPanel.TabIndex = 8
        '
        'LeftBar
        '
        Me.LeftBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.LeftBar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.LeftBar.BorderRadius = 9
        Me.LeftBar.Controls.Add(Me.Guna2Separator2)
        Me.LeftBar.Controls.Add(Me.CheatsBtn)
        Me.LeftBar.Controls.Add(Me.SpooferBtn)
        Me.LeftBar.Controls.Add(Me.HomeBtn)
        Me.LeftBar.Controls.Add(Me.Guna2Separator1)
        Me.LeftBar.Controls.Add(Me.PictureBox1)
        Me.LeftBar.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.LeftBar.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.MotherAnim.SetDecoration(Me.LeftBar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LeftBar.FillColor = System.Drawing.Color.Transparent
        Me.LeftBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LeftBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LeftBar.Location = New System.Drawing.Point(11, 39)
        Me.LeftBar.Name = "LeftBar"
        Me.LeftBar.ShadowDecoration.Parent = Me.LeftBar
        Me.LeftBar.Size = New System.Drawing.Size(74, 542)
        Me.LeftBar.TabIndex = 11
        Me.LeftBar.Visible = False
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.MotherAnim.SetDecoration(Me.Guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Separator2.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Guna2Separator2.Location = New System.Drawing.Point(28, 140)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(19, 10)
        Me.Guna2Separator2.TabIndex = 15
        '
        'CheatsBtn
        '
        Me.CheatsBtn.Animated = True
        Me.CheatsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.CheatsBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.CheatsBtn.BorderRadius = 6
        Me.CheatsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.CheatsBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.CheatsBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.CheatsBtn.CheckedState.Image = Global.vente.My.Resources.Resources.Target
        Me.CheatsBtn.CheckedState.Parent = Me.CheatsBtn
        Me.CheatsBtn.CustomImages.Parent = Me.CheatsBtn
        Me.MotherAnim.SetDecoration(Me.CheatsBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CheatsBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.CheatsBtn.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheatsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.CheatsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.CheatsBtn.HoverState.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheatsBtn.HoverState.Image = Global.vente.My.Resources.Resources.Target
        Me.CheatsBtn.HoverState.Parent = Me.CheatsBtn
        Me.CheatsBtn.Image = Global.vente.My.Resources.Resources.Target_2
        Me.CheatsBtn.ImageOffset = New System.Drawing.Point(0, -5)
        Me.CheatsBtn.Location = New System.Drawing.Point(12, 165)
        Me.CheatsBtn.Name = "CheatsBtn"
        Me.CheatsBtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.CheatsBtn.ShadowDecoration.BorderRadius = 20
        Me.CheatsBtn.ShadowDecoration.Depth = 10
        Me.CheatsBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CheatsBtn.ShadowDecoration.Parent = Me.CheatsBtn
        Me.CheatsBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.CheatsBtn.Size = New System.Drawing.Size(50, 48)
        Me.CheatsBtn.TabIndex = 14
        Me.CheatsBtn.Text = "Cheats"
        Me.CheatsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.CheatsBtn.TextOffset = New System.Drawing.Point(-3, 13)
        '
        'SpooferBtn
        '
        Me.SpooferBtn.Animated = True
        Me.SpooferBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.SpooferBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.SpooferBtn.BorderRadius = 6
        Me.SpooferBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.SpooferBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.SpooferBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.SpooferBtn.CheckedState.Image = Global.vente.My.Resources.Resources.Processor_1
        Me.SpooferBtn.CheckedState.Parent = Me.SpooferBtn
        Me.SpooferBtn.CustomImages.Parent = Me.SpooferBtn
        Me.MotherAnim.SetDecoration(Me.SpooferBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SpooferBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.SpooferBtn.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpooferBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.SpooferBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.SpooferBtn.HoverState.ForeColor = System.Drawing.Color.RoyalBlue
        Me.SpooferBtn.HoverState.Image = Global.vente.My.Resources.Resources.Processor_11
        Me.SpooferBtn.HoverState.Parent = Me.SpooferBtn
        Me.SpooferBtn.Image = Global.vente.My.Resources.Resources.Processor2
        Me.SpooferBtn.ImageOffset = New System.Drawing.Point(0, -5)
        Me.SpooferBtn.Location = New System.Drawing.Point(12, 219)
        Me.SpooferBtn.Name = "SpooferBtn"
        Me.SpooferBtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.SpooferBtn.ShadowDecoration.BorderRadius = 20
        Me.SpooferBtn.ShadowDecoration.Depth = 10
        Me.SpooferBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.SpooferBtn.ShadowDecoration.Parent = Me.SpooferBtn
        Me.SpooferBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.SpooferBtn.Size = New System.Drawing.Size(50, 48)
        Me.SpooferBtn.TabIndex = 13
        Me.SpooferBtn.Text = "Spoofer"
        Me.SpooferBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SpooferBtn.TextOffset = New System.Drawing.Point(-4, 13)
        '
        'HomeBtn
        '
        Me.HomeBtn.Animated = True
        Me.HomeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.HomeBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.HomeBtn.BorderRadius = 6
        Me.HomeBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.HomeBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.HomeBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.HomeBtn.CheckedState.Image = Global.vente.My.Resources.Resources.HomeColored
        Me.HomeBtn.CheckedState.Parent = Me.HomeBtn
        Me.HomeBtn.CustomImages.Parent = Me.HomeBtn
        Me.MotherAnim.SetDecoration(Me.HomeBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.HomeBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.HomeBtn.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.HomeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.HomeBtn.HoverState.ForeColor = System.Drawing.Color.RoyalBlue
        Me.HomeBtn.HoverState.Image = Global.vente.My.Resources.Resources.HomeColored
        Me.HomeBtn.HoverState.Parent = Me.HomeBtn
        Me.HomeBtn.Image = Global.vente.My.Resources.Resources.HomeUncolored
        Me.HomeBtn.ImageOffset = New System.Drawing.Point(0, -5)
        Me.HomeBtn.Location = New System.Drawing.Point(12, 90)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.HomeBtn.ShadowDecoration.BorderRadius = 20
        Me.HomeBtn.ShadowDecoration.Depth = 10
        Me.HomeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.HomeBtn.ShadowDecoration.Parent = Me.HomeBtn
        Me.HomeBtn.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.HomeBtn.Size = New System.Drawing.Size(50, 48)
        Me.HomeBtn.TabIndex = 8
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.HomeBtn.TextOffset = New System.Drawing.Point(0, 13)
        '
        'Guna2Separator1
        '
        Me.MotherAnim.SetDecoration(Me.Guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2Separator1.Location = New System.Drawing.Point(22, 68)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(31, 10)
        Me.Guna2Separator1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.MotherAnim.SetDecoration(Me.PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.vente.My.Resources.Resources.SmallLogoBlue
        Me.PictureBox1.Location = New System.Drawing.Point(13, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'TopBar
        '
        Me.TopBar.BackgroundImage = CType(resources.GetObject("TopBar.BackgroundImage"), System.Drawing.Image)
        Me.TopBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TopBar.Controls.Add(Me.UsernameLbl)
        Me.TopBar.Controls.Add(Me.Guna2ControlBox1)
        Me.TopBar.Controls.Add(Me.Label1)
        Me.MotherAnim.SetDecoration(Me.TopBar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TopBar.Location = New System.Drawing.Point(0, 0)
        Me.TopBar.Name = "TopBar"
        Me.TopBar.Size = New System.Drawing.Size(895, 59)
        Me.TopBar.TabIndex = 10
        '
        'UsernameLbl
        '
        Me.UsernameLbl.BackColor = System.Drawing.Color.Transparent
        Me.MotherAnim.SetDecoration(Me.UsernameLbl, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.UsernameLbl.Font = New System.Drawing.Font("Bahnschrift SemiLight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.UsernameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.UsernameLbl.Location = New System.Drawing.Point(618, 21)
        Me.UsernameLbl.Name = "UsernameLbl"
        Me.UsernameLbl.Size = New System.Drawing.Size(265, 17)
        Me.UsernameLbl.TabIndex = 7
        Me.UsernameLbl.Text = "N/A"
        Me.UsernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Guna2ControlBox1.BorderRadius = 6
        Me.MotherAnim.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(866, 1)
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
        Me.MotherAnim.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(422, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "VENTE"
        '
        'Button2
        '
        Me.MotherAnim.SetDecoration(Me.Button2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Button2.Location = New System.Drawing.Point(953, 609)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.MotherAnim.SetDecoration(Me.Button1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Button1.Location = New System.Drawing.Point(872, 609)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BottomBar
        '
        Me.BottomBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BottomBar.Controls.Add(Me.Label2)
        Me.MotherAnim.SetDecoration(Me.BottomBar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BottomBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomBar.Location = New System.Drawing.Point(0, 591)
        Me.BottomBar.Name = "BottomBar"
        Me.BottomBar.Size = New System.Drawing.Size(895, 18)
        Me.BottomBar.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.MotherAnim.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(4, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "&VENTE | 2022-2023 All rights reserved."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.TargetControl = Me.Mother
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'ColorAnim
        '
        Me.ColorAnim.AutoTransition = True
        Me.ColorAnim.ColorArray = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer)), System.Drawing.Color.CornflowerBlue, System.Drawing.Color.RoyalBlue}
        Me.ColorAnim.EndColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.ColorAnim.Interval = 10
        Me.ColorAnim.StartColor = System.Drawing.Color.RoyalBlue
        '
        'AnimColorEngine
        '
        Me.AnimColorEngine.Enabled = True
        Me.AnimColorEngine.Interval = 1
        '
        'MotherAnim
        '
        Me.MotherAnim.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.MotherAnim.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.MotherAnim.DefaultAnimation = Animation1
        '
        'Movable
        '
        Me.Movable.TargetControl = Me.TopBar
        '
        'Movable2
        '
        Me.Movable2.TargetControl = Me.Label1
        '
        'LicenseRefresher
        '
        Me.LicenseRefresher.Enabled = True
        Me.LicenseRefresher.Interval = 25000
        '
        'VenteMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(895, 609)
        Me.Controls.Add(Me.Mother)
        Me.MotherAnim.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VenteMain"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTE"
        Me.TopMost = True
        Me.Mother.ResumeLayout(False)
        Me.MotherBox.ResumeLayout(False)
        Me.LeftBar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopBar.ResumeLayout(False)
        Me.TopBar.PerformLayout()
        Me.BottomBar.ResumeLayout(False)
        Me.BottomBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Mother As Panel
    Friend WithEvents TopBar As Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents LeftBar As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UsernameLbl As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents ColorAnim As Guna.UI2.WinForms.Guna2ColorTransition
    Friend WithEvents AnimColorEngine As Timer
    Friend WithEvents MotherBox As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents MotherAnim As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents BottomBar As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents HomeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CheatsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SpooferBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents MotherPanel As Panel
    Friend WithEvents Movable As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Movable2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents LicenseRefresher As Timer
End Class
