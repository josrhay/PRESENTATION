<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CALCULATRICE
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        moins = New Button()
        a = New TextBox()
        b = New TextBox()
        r = New TextBox()
        plus = New Button()
        div = New Button()
        fois = New Button()
        label3 = New Label()
        label2 = New Label()
        label1 = New Label()
        SuspendLayout()
        ' 
        ' moins
        ' 
        moins.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        moins.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        moins.Location = New Point(323, 123)
        moins.Name = "moins"
        moins.Size = New Size(58, 44)
        moins.TabIndex = 1
        moins.Text = "-"
        moins.UseVisualStyleBackColor = False
        ' 
        ' a
        ' 
        a.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        a.Location = New Point(143, 57)
        a.Name = "a"
        a.Size = New Size(100, 23)
        a.TabIndex = 4
        ' 
        ' b
        ' 
        b.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        b.Location = New Point(143, 158)
        b.Name = "b"
        b.Size = New Size(100, 23)
        b.TabIndex = 4
        ' 
        ' r
        ' 
        r.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        r.Location = New Point(143, 265)
        r.Name = "r"
        r.Size = New Size(100, 23)
        r.TabIndex = 4
        ' 
        ' plus
        ' 
        plus.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        plus.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        plus.Location = New Point(323, 57)
        plus.Name = "plus"
        plus.Size = New Size(58, 44)
        plus.TabIndex = 1
        plus.Text = "+"
        plus.UseVisualStyleBackColor = False
        ' 
        ' div
        ' 
        div.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        div.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        div.Location = New Point(323, 244)
        div.Name = "div"
        div.Size = New Size(58, 44)
        div.TabIndex = 1
        div.Text = "/"
        div.UseVisualStyleBackColor = False
        ' 
        ' fois
        ' 
        fois.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        fois.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        fois.Location = New Point(323, 183)
        fois.Name = "fois"
        fois.Size = New Size(58, 44)
        fois.TabIndex = 1
        fois.Text = "x"
        fois.UseVisualStyleBackColor = False
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        label3.Location = New Point(91, 251)
        label3.Name = "label3"
        label3.Size = New Size(35, 37)
        label3.TabIndex = 3
        label3.Text = "R"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        label2.Location = New Point(90, 144)
        label2.Name = "label2"
        label2.Size = New Size(34, 37)
        label2.TabIndex = 3
        label2.Text = "B"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        label1.Location = New Point(90, 57)
        label1.Name = "label1"
        label1.Size = New Size(36, 37)
        label1.TabIndex = 3
        label1.Text = "A"
        ' 
        ' CALCULATRICE
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(455, 300)
        Controls.Add(r)
        Controls.Add(b)
        Controls.Add(a)
        Controls.Add(label1)
        Controls.Add(label3)
        Controls.Add(label2)
        Controls.Add(plus)
        Controls.Add(fois)
        Controls.Add(div)
        Controls.Add(moins)
        Name = "CALCULATRICE"
        Text = "CALCULATRICE"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents moins As Button
    Friend WithEvents a As TextBox
    Friend WithEvents b As TextBox
    Friend WithEvents r As TextBox
    Friend WithEvents plus As Button
    Friend WithEvents div As Button
    Friend WithEvents fois As Button
    Friend WithEvents label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label1 As Label
End Class
