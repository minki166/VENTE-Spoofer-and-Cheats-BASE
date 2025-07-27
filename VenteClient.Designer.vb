<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Group = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.MotherPages = New Guna.UI2.WinForms.Guna2Panel()
        Me.Mother = New System.Windows.Forms.Panel()
        Me.TopBar = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Animacja_Powiększania = New System.Windows.Forms.Timer(Me.components)
        Me.Animacja_Zmniejszania = New System.Windows.Forms.Timer(Me.components)
        Me.SprawdzanieAnimacji = New System.Windows.Forms.Timer(Me.components)
        Me.Movable = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Movable2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.AppRestart = New System.Windows.Forms.Timer(Me.components)
        Me.AntiCrackTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Group.SuspendLayout()
        Me.Mother.SuspendLayout()
        Me.TopBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Group
        '
        Me.Group.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Group.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Group.BorderRadius = 4
        Me.Group.Controls.Add(Me.MotherPages)
        Me.Group.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Group.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.Group.FillColor = System.Drawing.Color.Transparent
        Me.Group.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Group.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Group.Location = New System.Drawing.Point(275, 249)
        Me.Group.Name = "Group"
        Me.Group.ShadowDecoration.Parent = Me.Group
        Me.Group.Size = New System.Drawing.Size(344, 10)
        Me.Group.TabIndex = 5
        '
        'MotherPages
        '
        Me.MotherPages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MotherPages.Location = New System.Drawing.Point(3, 3)
        Me.MotherPages.Name = "MotherPages"
        Me.MotherPages.ShadowDecoration.Parent = Me.MotherPages
        Me.MotherPages.Size = New System.Drawing.Size(338, 4)
        Me.MotherPages.TabIndex = 0
        '
        'Mother
        '
        Me.Mother.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Mother.Controls.Add(Me.TopBar)
        Me.Mother.Controls.Add(Me.PictureBox1)
        Me.Mother.Controls.Add(Me.Button2)
        Me.Mother.Controls.Add(Me.Button1)
        Me.Mother.Controls.Add(Me.Group)
        Me.Mother.Location = New System.Drawing.Point(1, 1)
        Me.Mother.Name = "Mother"
        Me.Mother.Size = New System.Drawing.Size(895, 609)
        Me.Mother.TabIndex = 6
        '
        'TopBar
        '
        Me.TopBar.BackgroundImage = CType(resources.GetObject("TopBar.BackgroundImage"), System.Drawing.Image)
        Me.TopBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TopBar.Controls.Add(Me.Guna2ControlBox1)
        Me.TopBar.Controls.Add(Me.Label1)
        Me.TopBar.Location = New System.Drawing.Point(0, -1)
        Me.TopBar.Name = "TopBar"
        Me.TopBar.Size = New System.Drawing.Size(895, 59)
        Me.TopBar.TabIndex = 10
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
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(422, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "VENTE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.vente.My.Resources.Resources.MediumLogoBlue
        Me.PictureBox1.Location = New System.Drawing.Point(370, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(953, 609)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(872, 609)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.TargetControl = Me.Mother
        '
        'Animacja_Powiększania
        '
        Me.Animacja_Powiększania.Interval = 1
        '
        'Animacja_Zmniejszania
        '
        Me.Animacja_Zmniejszania.Interval = 1
        '
        'SprawdzanieAnimacji
        '
        Me.SprawdzanieAnimacji.Interval = 800
        '
        'Movable
        '
        Me.Movable.TargetControl = Me.Mother
        '
        'Movable2
        '
        Me.Movable2.TargetControl = Me.TopBar
        '
        'AppRestart
        '
        Me.AppRestart.Interval = 2000
        '
        'AntiCrackTimer
        '
        Me.AntiCrackTimer.Enabled = True
        Me.AntiCrackTimer.Interval = 2200
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(897, 611)
        Me.Controls.Add(Me.Mother)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTE | LOGIN"
        Me.Group.ResumeLayout(False)
        Me.Mother.ResumeLayout(False)
        Me.TopBar.ResumeLayout(False)
        Me.TopBar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Group As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Mother As Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Animacja_Powiększania As Timer
    Friend WithEvents Animacja_Zmniejszania As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MotherPages As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SprawdzanieAnimacji As Timer
    Friend WithEvents Movable As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents TopBar As Panel
    Friend WithEvents Movable2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents AppRestart As Timer
    Friend WithEvents AntiCrackTimer As Timer
End Class
