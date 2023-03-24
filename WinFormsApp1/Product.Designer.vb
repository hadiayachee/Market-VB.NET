
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProductDGV = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.code = New RJCodeAdvance.RJControls.RJTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Price = New System.Windows.Forms.Label()
        Me.Button3 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.ProdQty = New RJCodeAdvance.RJControls.RJTextBox()
        Me.logout = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.ProdPrice = New RJCodeAdvance.RJControls.RJTextBox()
        Me.TextBox2 = New RJCodeAdvance.RJControls.RJTextBox()
        Me.ProdName = New RJCodeAdvance.RJControls.RJTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProdId = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ProductDGV)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.code)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Price)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.ProdQty)
        Me.Panel1.Controls.Add(Me.logout)
        Me.Panel1.Controls.Add(Me.ProdPrice)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.ProdName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ProdId)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1241, 794)
        Me.Panel1.TabIndex = 0
        '
        'ProductDGV
        '
        Me.ProductDGV.BackgroundColor = System.Drawing.Color.White
        Me.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDGV.GridColor = System.Drawing.Color.Black
        Me.ProductDGV.Location = New System.Drawing.Point(513, 286)
        Me.ProductDGV.Name = "ProductDGV"
        Me.ProductDGV.ReadOnly = True
        Me.ProductDGV.RowHeadersWidth = 51
        Me.ProductDGV.RowTemplate.Height = 29
        Me.ProductDGV.Size = New System.Drawing.Size(673, 505)
        Me.ProductDGV.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 445)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "الكود "
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
        Me.Button2.Location = New System.Drawing.Point(369, 692)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 27)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "إلغاء"
        '
        'code
        '
        Me.code.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.code.BackColor = System.Drawing.SystemColors.Window
        Me.code.BorderColor = System.Drawing.Color.Black
        Me.code.BorderFocusColor = System.Drawing.Color.Gray
        Me.code.BorderRadius = 0
        Me.code.BorderSize = 2
        Me.code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.code.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.code.Location = New System.Drawing.Point(29, 406)
        Me.code.Margin = New System.Windows.Forms.Padding(4)
        Me.code.Multiline = False
        Me.code.Name = "code"
        Me.code.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.code.PasswordChar = False
        Me.code.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.code.PlaceholderText = ""
        Me.code.Size = New System.Drawing.Size(172, 35)
        Me.code.TabIndex = 34
        Me.code.Texts = ""
        Me.code.UnderlinedStyle = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 508)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "الإسم "
        '
        'Button4
        '
        Me.Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button4.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.FillColor2 = System.Drawing.SystemColors.MenuHighlight
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.HoverState.FillColor = System.Drawing.Color.Black
        Me.Button4.HoverState.FillColor2 = System.Drawing.Color.DarkGray
        Me.Button4.Location = New System.Drawing.Point(130, 692)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 27)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "تعديل"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 634)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "الكمية"
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
        Me.Button1.Location = New System.Drawing.Point(19, 692)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 27)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "إضافة"
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.Location = New System.Drawing.Point(90, 571)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(46, 20)
        Me.Price.TabIndex = 48
        Me.Price.Text = "السعر"
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
        Me.Button3.Location = New System.Drawing.Point(252, 692)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 27)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "حذف"
        '
        'ProdQty
        '
        Me.ProdQty.BackColor = System.Drawing.SystemColors.Window
        Me.ProdQty.BorderColor = System.Drawing.Color.Black
        Me.ProdQty.BorderFocusColor = System.Drawing.Color.Gray
        Me.ProdQty.BorderRadius = 0
        Me.ProdQty.BorderSize = 2
        Me.ProdQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProdQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProdQty.Location = New System.Drawing.Point(29, 595)
        Me.ProdQty.Margin = New System.Windows.Forms.Padding(4)
        Me.ProdQty.Multiline = False
        Me.ProdQty.Name = "ProdQty"
        Me.ProdQty.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.ProdQty.PasswordChar = False
        Me.ProdQty.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.ProdQty.PlaceholderText = ""
        Me.ProdQty.Size = New System.Drawing.Size(172, 35)
        Me.ProdQty.TabIndex = 37
        Me.ProdQty.Texts = ""
        Me.ProdQty.UnderlinedStyle = True
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
        Me.logout.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.logout.HoverState.CustomBorderColor = System.Drawing.Color.Blue
        Me.logout.HoverState.FillColor = System.Drawing.Color.Blue
        Me.logout.HoverState.FillColor2 = System.Drawing.Color.Blue
        Me.logout.Location = New System.Drawing.Point(1175, 21)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(40, 33)
        Me.logout.TabIndex = 50
        Me.logout.Text = "X"
        '
        'ProdPrice
        '
        Me.ProdPrice.BackColor = System.Drawing.SystemColors.Window
        Me.ProdPrice.BorderColor = System.Drawing.Color.Black
        Me.ProdPrice.BorderFocusColor = System.Drawing.Color.Gray
        Me.ProdPrice.BorderRadius = 0
        Me.ProdPrice.BorderSize = 2
        Me.ProdPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProdPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProdPrice.Location = New System.Drawing.Point(29, 532)
        Me.ProdPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.ProdPrice.Multiline = False
        Me.ProdPrice.Name = "ProdPrice"
        Me.ProdPrice.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.ProdPrice.PasswordChar = False
        Me.ProdPrice.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.ProdPrice.PlaceholderText = ""
        Me.ProdPrice.Size = New System.Drawing.Size(172, 35)
        Me.ProdPrice.TabIndex = 36
        Me.ProdPrice.Texts = ""
        Me.ProdPrice.UnderlinedStyle = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.BorderColor = System.Drawing.Color.Black
        Me.TextBox2.BorderFocusColor = System.Drawing.Color.Gray
        Me.TextBox2.BorderRadius = 0
        Me.TextBox2.BorderSize = 2
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(275, 302)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = False
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TextBox2.PasswordChar = False
        Me.TextBox2.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.TextBox2.PlaceholderText = "بحث"
        Me.TextBox2.Size = New System.Drawing.Size(172, 35)
        Me.TextBox2.TabIndex = 47
        Me.TextBox2.Texts = ""
        Me.TextBox2.UnderlinedStyle = True
        '
        'ProdName
        '
        Me.ProdName.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ProdName.BackColor = System.Drawing.SystemColors.Window
        Me.ProdName.BorderColor = System.Drawing.Color.Black
        Me.ProdName.BorderFocusColor = System.Drawing.Color.Gray
        Me.ProdName.BorderRadius = 0
        Me.ProdName.BorderSize = 2
        Me.ProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProdName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProdName.Location = New System.Drawing.Point(29, 469)
        Me.ProdName.Margin = New System.Windows.Forms.Padding(4)
        Me.ProdName.Multiline = False
        Me.ProdName.Name = "ProdName"
        Me.ProdName.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.ProdName.PasswordChar = False
        Me.ProdName.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.ProdName.PlaceholderText = ""
        Me.ProdName.Size = New System.Drawing.Size(172, 35)
        Me.ProdName.TabIndex = 35
        Me.ProdName.Texts = ""
        Me.ProdName.UnderlinedStyle = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Simplified Arabic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(29, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 39)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "البضاعة"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WinFormsApp1.My.Resources.Resources._3e1122164e16d33557021add548fd75d
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.WinFormsApp1.My.Resources.Resources.How_to_Dress_Sharp_Fashion_Tips_for_Men_Creatyourbloghere_com
        Me.PictureBox1.Location = New System.Drawing.Point(-22, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1260, 277)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'ProdId
        '
        Me.ProdId.Location = New System.Drawing.Point(300, 357)
        Me.ProdId.Name = "ProdId"
        Me.ProdId.Size = New System.Drawing.Size(125, 27)
        Me.ProdId.TabIndex = 7
        Me.ProdId.Visible = False
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumBlue
        Me.ClientSize = New System.Drawing.Size(1239, 793)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProductDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProdId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents logout As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Button2 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Button4 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Button1 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Button3 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Label4 As Label
    Friend WithEvents code As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Price As Label
    Friend WithEvents ProdQty As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents ProdPrice As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents ProdName As RJCodeAdvance.RJControls.RJTextBox
    Friend WithEvents ProductDGV As DataGridView
End Class