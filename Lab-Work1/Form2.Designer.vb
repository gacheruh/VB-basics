<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        loadPic = New Button()
        exit2 = New Button()
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        tahoma = New RadioButton()
        garamond = New RadioButton()
        magneto = New RadioButton()
        GroupBox3 = New GroupBox()
        boldItalic = New CheckBox()
        bold = New CheckBox()
        italic = New CheckBox()
        GroupBox4 = New GroupBox()
        blue = New RadioButton()
        red = New RadioButton()
        green = New RadioButton()
        PictureBox1 = New PictureBox()
        ToolTip1 = New ToolTip(components)
        ToolTip2 = New ToolTip(components)
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' loadPic
        ' 
        loadPic.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        loadPic.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loadPic.ForeColor = Color.White
        loadPic.Location = New Point(37, 318)
        loadPic.Name = "loadPic"
        loadPic.Size = New Size(167, 58)
        loadPic.TabIndex = 0
        loadPic.Text = "Load Picture"
        loadPic.UseVisualStyleBackColor = False
        ' 
        ' exit2
        ' 
        exit2.BackColor = Color.Red
        exit2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        exit2.ForeColor = SystemColors.ButtonFace
        exit2.Location = New Point(586, 318)
        exit2.Name = "exit2"
        exit2.Size = New Size(143, 58)
        exit2.TabIndex = 1
        exit2.Text = "EXIT"
        exit2.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(37, 23)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(199, 82)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Display Text"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(6, 34)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 29)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Sample Text"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(tahoma)
        GroupBox2.Controls.Add(garamond)
        GroupBox2.Controls.Add(magneto)
        GroupBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(294, 23)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(435, 82)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Font"
        ' 
        ' tahoma
        ' 
        tahoma.AutoSize = True
        tahoma.Location = New Point(314, 34)
        tahoma.Name = "tahoma"
        tahoma.Size = New Size(82, 25)
        tahoma.TabIndex = 5
        tahoma.TabStop = True
        tahoma.Text = "Tahoma"
        tahoma.UseVisualStyleBackColor = True
        ' 
        ' garamond
        ' 
        garamond.AutoSize = True
        garamond.Location = New Point(36, 35)
        garamond.Name = "garamond"
        garamond.Size = New Size(102, 25)
        garamond.TabIndex = 3
        garamond.TabStop = True
        garamond.Text = "Garamond"
        garamond.UseVisualStyleBackColor = True
        ' 
        ' magneto
        ' 
        magneto.AutoSize = True
        magneto.Location = New Point(188, 34)
        magneto.Name = "magneto"
        magneto.Size = New Size(90, 25)
        magneto.TabIndex = 4
        magneto.TabStop = True
        magneto.Text = "Magneto"
        magneto.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(boldItalic)
        GroupBox3.Controls.Add(bold)
        GroupBox3.Controls.Add(italic)
        GroupBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(294, 132)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(189, 174)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "Font Style"
        ' 
        ' boldItalic
        ' 
        boldItalic.AutoSize = True
        boldItalic.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        boldItalic.Location = New Point(36, 124)
        boldItalic.Name = "boldItalic"
        boldItalic.Size = New Size(103, 25)
        boldItalic.TabIndex = 2
        boldItalic.Text = "Bold Italic"
        boldItalic.UseVisualStyleBackColor = True
        ' 
        ' bold
        ' 
        bold.AutoSize = True
        bold.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bold.Location = New Point(36, 75)
        bold.Name = "bold"
        bold.Size = New Size(64, 25)
        bold.TabIndex = 1
        bold.Text = "Bold"
        bold.UseVisualStyleBackColor = True
        ' 
        ' italic
        ' 
        italic.AutoSize = True
        italic.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        italic.Location = New Point(36, 34)
        italic.Name = "italic"
        italic.Size = New Size(62, 25)
        italic.TabIndex = 0
        italic.Text = "Italic"
        italic.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(blue)
        GroupBox4.Controls.Add(red)
        GroupBox4.Controls.Add(green)
        GroupBox4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(550, 138)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(179, 168)
        GroupBox4.TabIndex = 5
        GroupBox4.TabStop = False
        GroupBox4.Text = "Font Style"
        ' 
        ' blue
        ' 
        blue.AutoSize = True
        blue.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        blue.Location = New Point(33, 69)
        blue.Name = "blue"
        blue.Size = New Size(58, 25)
        blue.TabIndex = 5
        blue.TabStop = True
        blue.Text = "Blue"
        blue.UseVisualStyleBackColor = True
        ' 
        ' red
        ' 
        red.AutoSize = True
        red.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        red.Location = New Point(34, 117)
        red.Name = "red"
        red.Size = New Size(55, 25)
        red.TabIndex = 4
        red.TabStop = True
        red.Text = "Red"
        red.UseVisualStyleBackColor = True
        ' 
        ' green
        ' 
        green.AutoSize = True
        green.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        green.Location = New Point(34, 28)
        green.Name = "green"
        green.Size = New Size(70, 25)
        green.TabIndex = 3
        green.TabStop = True
        green.Text = "Green"
        green.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(37, 138)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(238, 168)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(exit2)
        Controls.Add(loadPic)
        Name = "Form2"
        Text = "Object Demonstration"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents loadPic As Button
    Friend WithEvents exit2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents boldItalic As CheckBox
    Friend WithEvents bold As CheckBox
    Friend WithEvents italic As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents green As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tahoma As RadioButton
    Friend WithEvents garamond As RadioButton
    Friend WithEvents magneto As RadioButton
    Friend WithEvents blue As RadioButton
    Friend WithEvents red As RadioButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
End Class
