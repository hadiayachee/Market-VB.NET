<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UidTb = New RJCodeAdvance.RJControls.RJTextBox()
        Me.UpassTb = New RJCodeAdvance.RJControls.RJTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GradientTileButton1 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Aldhabi", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(180, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 67)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BIG"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WinFormsApp1.My.Resources.Resources.Mens_Fall_Fashion_Wallpapers_High_Quality_Download_Free
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(551, 310)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'UidTb
        '
        Me.UidTb.BackColor = System.Drawing.SystemColors.Window
        Me.UidTb.BorderColor = System.Drawing.Color.Black
        Me.UidTb.BorderFocusColor = System.Drawing.Color.Gray
        Me.UidTb.BorderRadius = 0
        Me.UidTb.BorderSize = 2
        Me.UidTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UidTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UidTb.Location = New System.Drawing.Point(180, 404)
        Me.UidTb.Margin = New System.Windows.Forms.Padding(4)
        Me.UidTb.Multiline = False
        Me.UidTb.Name = "UidTb"
        Me.UidTb.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.UidTb.PasswordChar = False
        Me.UidTb.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.UidTb.PlaceholderText = "إسم المستخدم"
        Me.UidTb.Size = New System.Drawing.Size(193, 35)
        Me.UidTb.TabIndex = 1
        Me.UidTb.Texts = ""
        Me.UidTb.UnderlinedStyle = True
        '
        'UpassTb
        '
        Me.UpassTb.BackColor = System.Drawing.SystemColors.Window
        Me.UpassTb.BorderColor = System.Drawing.Color.Black
        Me.UpassTb.BorderFocusColor = System.Drawing.Color.Gray
        Me.UpassTb.BorderRadius = 0
        Me.UpassTb.BorderSize = 2
        Me.UpassTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UpassTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UpassTb.Location = New System.Drawing.Point(179, 447)
        Me.UpassTb.Margin = New System.Windows.Forms.Padding(4)
        Me.UpassTb.Multiline = False
        Me.UpassTb.Name = "UpassTb"
        Me.UpassTb.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.UpassTb.PasswordChar = False
        Me.UpassTb.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.UpassTb.PlaceholderText = "كلمة المرور"
        Me.UpassTb.Size = New System.Drawing.Size(193, 35)
        Me.UpassTb.TabIndex = 2
        Me.UpassTb.Texts = ""
        Me.UpassTb.UnderlinedStyle = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(497, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 29)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button1.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FillColor2 = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.HoverState.FillColor = System.Drawing.Color.Black
        Me.Button1.HoverState.FillColor2 = System.Drawing.Color.DarkGray
        Me.Button1.Location = New System.Drawing.Point(301, 501)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "تسجيل الدخول"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = Global.WinFormsApp1.My.Resources.Resources.icon_password_2
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(138, 449)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(34, 33)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 14
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.FillColor = System.Drawing.Color.Blue
        Me.Guna2CirclePictureBox2.Image = Global.WinFormsApp1.My.Resources.Resources.user_icon_person_icon_client_symbol_login_head_sign_icon_design_vector
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(138, 404)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(34, 33)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox2.TabIndex = 15
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Aldhabi", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(239, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 67)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "DEAL"
        '
        'Guna2GradientTileButton1
        '
        Me.Guna2GradientTileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientTileButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientTileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientTileButton1.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2GradientTileButton1.FillColor2 = System.Drawing.SystemColors.MenuHighlight
        Me.Guna2GradientTileButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Guna2GradientTileButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientTileButton1.HoverState.FillColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton1.HoverState.FillColor2 = System.Drawing.Color.Black
        Me.Guna2GradientTileButton1.Location = New System.Drawing.Point(24, 549)
        Me.Guna2GradientTileButton1.Name = "Guna2GradientTileButton1"
        Me.Guna2GradientTileButton1.Size = New System.Drawing.Size(89, 29)
        Me.Guna2GradientTileButton1.TabIndex = 4
        Me.Guna2GradientTileButton1.Text = "المبيعات"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(545, 627)
        Me.Controls.Add(Me.Guna2GradientTileButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.UpassTb)
        Me.Controls.Add(Me.UidTb)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UidTb As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents UpassTb As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2GradientTileButton1 As Guna.UI2.WinForms.Guna2GradientTileButton
End Class
