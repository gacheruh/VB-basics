<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        loadButton = New Button()
        exit1 = New Button()
        ToolTip1 = New ToolTip(components)
        ToolTip2 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' loadButton
        ' 
        loadButton.BackColor = Color.Green
        loadButton.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loadButton.ForeColor = SystemColors.ButtonFace
        loadButton.Location = New Point(38, 196)
        loadButton.Name = "loadButton"
        loadButton.Size = New Size(266, 81)
        loadButton.TabIndex = 0
        loadButton.Text = "Load Object Demo"
        loadButton.UseVisualStyleBackColor = False
        ' 
        ' exit1
        ' 
        exit1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        exit1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        exit1.ForeColor = SystemColors.ButtonHighlight
        exit1.Location = New Point(500, 196)
        exit1.Name = "exit1"
        exit1.Size = New Size(182, 81)
        exit1.TabIndex = 1
        exit1.Text = "EXIT"
        exit1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(exit1)
        Controls.Add(loadButton)
        Name = "Form1"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents loadButton As Button
    Friend WithEvents exit1 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip

End Class
