<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calcul1
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
        Label1 = New Label()
        a = New TextBox()
        Label2 = New Label()
        b = New TextBox()
        valider = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(85, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(15, 15)
        Label1.TabIndex = 0
        Label1.Text = "A"
        ' 
        ' a
        ' 
        a.Location = New Point(47, 76)
        a.Name = "a"
        a.Size = New Size(136, 23)
        a.TabIndex = 1
        a.Text = "heyy"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(451, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(14, 15)
        Label2.TabIndex = 0
        Label2.Text = "B"
        ' 
        ' b
        ' 
        b.Location = New Point(420, 76)
        b.Name = "b"
        b.Size = New Size(115, 23)
        b.TabIndex = 1
        ' 
        ' valider
        ' 
        valider.Location = New Point(287, 189)
        valider.Name = "valider"
        valider.Size = New Size(75, 23)
        valider.TabIndex = 2
        valider.Text = "Valider"
        valider.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(120, 254)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 3
        ' 
        ' calcul1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Controls.Add(valider)
        Controls.Add(b)
        Controls.Add(a)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "calcul1"
        Text = "calcul1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents a As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents b As TextBox
    Friend WithEvents valider As Button
    Friend WithEvents TextBox1 As TextBox
End Class
