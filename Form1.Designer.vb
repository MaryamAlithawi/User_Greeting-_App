<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtName = New TextBox()
        rbMr = New RadioButton()
        rbMa = New RadioButton()
        btnGreet = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(491, 179)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 27)
        txtName.TabIndex = 0
        ' 
        ' rbMr
        ' 
        rbMr.AutoSize = True
        rbMr.Location = New Point(228, 209)
        rbMr.Name = "rbMr"
        rbMr.Size = New Size(121, 24)
        rbMr.TabIndex = 1
        rbMr.TabStop = True
        rbMr.Text = "RadioButton1"
        rbMr.UseVisualStyleBackColor = True
        ' 
        ' rbMa
        ' 
        rbMa.AutoSize = True
        rbMa.Location = New Point(472, 252)
        rbMa.Name = "rbMa"
        rbMa.Size = New Size(121, 24)
        rbMa.TabIndex = 2
        rbMa.TabStop = True
        rbMa.Text = "RadioButton2"
        rbMa.UseVisualStyleBackColor = True
        ' 
        ' btnGreet
        ' 
        btnGreet.Location = New Point(357, 278)
        btnGreet.Name = "btnGreet"
        btnGreet.Size = New Size(94, 29)
        btnGreet.TabIndex = 3
        btnGreet.Text = "Button1"
        btnGreet.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnGreet)
        Controls.Add(rbMa)
        Controls.Add(rbMr)
        Controls.Add(txtName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents rbMr As RadioButton
    Friend WithEvents rbMa As RadioButton
    Friend WithEvents btnGreet As Button

End Class
