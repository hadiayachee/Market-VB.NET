<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderDetails
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
        Me.ODGV = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Button3 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Button1 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.searcho = New RJCodeAdvance.RJControls.RJTextBox()
        Me.totalall = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logout = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ODGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ODGV
        '
        Me.ODGV.AllowUserToAddRows = False
        Me.ODGV.AllowUserToDeleteRows = False
        Me.ODGV.BackgroundColor = System.Drawing.Color.White
        Me.ODGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ODGV.GridColor = System.Drawing.Color.Black
        Me.ODGV.Location = New System.Drawing.Point(12, 384)
        Me.ODGV.Name = "ODGV"
        Me.ODGV.ReadOnly = True
        Me.ODGV.RowHeadersWidth = 51
        Me.ODGV.RowTemplate.Height = 29
        Me.ODGV.Size = New System.Drawing.Size(1026, 397)
        Me.ODGV.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1074, 455)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "YYYY-0M-0D / رقم المشتري"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(509, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button2.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FillColor2 = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.HoverState.FillColor = System.Drawing.Color.Black
        Me.Button2.HoverState.FillColor2 = System.Drawing.Color.DarkGray
        Me.Button2.Location = New System.Drawing.Point(1106, 498)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 27)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "حذف"
        '
        'Button3
        '
        Me.Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button3.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.FillColor2 = System.Drawing.SystemColors.MenuHighlight
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.HoverState.FillColor = System.Drawing.Color.Black
        Me.Button3.HoverState.FillColor2 = System.Drawing.Color.DarkGray
        Me.Button3.Location = New System.Drawing.Point(1106, 548)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 27)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "يوميا"
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
        Me.Button1.Location = New System.Drawing.Point(1106, 599)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 27)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "شهريا"
        '
        'searcho
        '
        Me.searcho.BackColor = System.Drawing.SystemColors.Window
        Me.searcho.BorderColor = System.Drawing.Color.Black
        Me.searcho.BorderFocusColor = System.Drawing.Color.Gray
        Me.searcho.BorderRadius = 0
        Me.searcho.BorderSize = 2
        Me.searcho.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.searcho.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.searcho.Location = New System.Drawing.Point(1074, 416)
        Me.searcho.Margin = New System.Windows.Forms.Padding(4)
        Me.searcho.Multiline = False
        Me.searcho.Name = "searcho"
        Me.searcho.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.searcho.PasswordChar = False
        Me.searcho.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.searcho.PlaceholderText = "بحث"
        Me.searcho.Size = New System.Drawing.Size(172, 35)
        Me.searcho.TabIndex = 40
        Me.searcho.Texts = ""
        Me.searcho.UnderlinedStyle = True
        '
        'totalall
        '
        Me.totalall.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.totalall.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.totalall.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.totalall.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.totalall.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.totalall.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.totalall.FillColor2 = System.Drawing.Color.Silver
        Me.totalall.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.totalall.ForeColor = System.Drawing.Color.Black
        Me.totalall.Location = New System.Drawing.Point(1063, 686)
        Me.totalall.Name = "totalall"
        Me.totalall.Size = New System.Drawing.Size(203, 85)
        Me.totalall.TabIndex = 41
        Me.totalall.Text = "المجموع"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 39)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "تفاصيل المبيعات"
        '
        'logout
        '
        Me.logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.logout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.logout.FillColor = System.Drawing.Color.Red
        Me.logout.FillColor2 = System.Drawing.Color.Red
        Me.logout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.logout.ForeColor = System.Drawing.Color.White
        Me.logout.HoverState.BorderColor = System.Drawing.Color.Red
        Me.logout.HoverState.CustomBorderColor = System.Drawing.Color.Blue
        Me.logout.HoverState.FillColor = System.Drawing.Color.Blue
        Me.logout.HoverState.FillColor2 = System.Drawing.Color.Blue
        Me.logout.Location = New System.Drawing.Point(1226, 21)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(40, 32)
        Me.logout.TabIndex = 51
        Me.logout.Text = "X"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.WinFormsApp1.My.Resources.Resources.How_to_Dress_Sharp_Fashion_Tips_for_Men_Creatyourbloghere_com
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1284, 307)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'OrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1286, 793)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.totalall)
        Me.Controls.Add(Me.searcho)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ODGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OrderDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order-Details"
        CType(Me.ODGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ODGV As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Button3 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Button1 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents searcho As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents totalall As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Label1 As Label
    Friend WithEvents logout As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
