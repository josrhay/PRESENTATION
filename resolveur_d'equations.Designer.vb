<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resolveur_d_equations
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        GroupBox1 = New GroupBox()
        c = New TextBox()
        b = New TextBox()
        a = New TextBox()
        calculer = New Button()
        quitter = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        GroupBox2 = New GroupBox()
        result = New TextBox()
        Label10 = New Label()
        discriminat = New Label()
        Label9 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("SimSun-ExtB", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(12, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(620, 24)
        Label1.TabIndex = 0
        Label1.Text = "Résolution d’une équation de second degré dans R"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Viner Hand ITC", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(125, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(24, 27)
        Label2.TabIndex = 1
        Label2.Text = "X"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(145, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(13, 15)
        Label3.TabIndex = 2
        Label3.Text = "2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Viner Hand ITC", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(249, 43)
        Label4.Name = "Label4"
        Label4.Size = New Size(24, 27)
        Label4.TabIndex = 3
        Label4.Text = "X"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Viner Hand ITC", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(164, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(27, 27)
        Label5.TabIndex = 4
        Label5.Text = "+"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Viner Hand ITC", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(279, 41)
        Label6.Name = "Label6"
        Label6.Size = New Size(27, 27)
        Label6.TabIndex = 5
        Label6.Text = "+"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Viner Hand ITC", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(377, 43)
        Label7.Name = "Label7"
        Label7.Size = New Size(27, 27)
        Label7.TabIndex = 6
        Label7.Text = "="
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(428, 45)
        Label8.Name = "Label8"
        Label8.Size = New Size(18, 19)
        Label8.TabIndex = 7
        Label8.Text = "0"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Blue
        GroupBox1.Controls.Add(c)
        GroupBox1.Controls.Add(b)
        GroupBox1.Controls.Add(a)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Location = New Point(51, 86)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(543, 97)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "equation de depart (sous la forme reduite):"
        ' 
        ' c
        ' 
        c.Location = New Point(326, 43)
        c.Name = "c"
        c.Size = New Size(31, 23)
        c.TabIndex = 8
        ' 
        ' b
        ' 
        b.Location = New Point(212, 45)
        b.Name = "b"
        b.Size = New Size(31, 23)
        b.TabIndex = 8
        ' 
        ' a
        ' 
        a.Location = New Point(88, 47)
        a.Name = "a"
        a.Size = New Size(31, 23)
        a.TabIndex = 8
        ' 
        ' calculer
        ' 
        calculer.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        calculer.Font = New Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        calculer.Location = New Point(89, 204)
        calculer.Name = "calculer"
        calculer.Size = New Size(140, 35)
        calculer.TabIndex = 9
        calculer.Text = "Calculer"
        calculer.UseVisualStyleBackColor = False
        ' 
        ' quitter
        ' 
        quitter.BackColor = Color.Red
        quitter.Font = New Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        quitter.Location = New Point(410, 204)
        quitter.Name = "quitter"
        quitter.Size = New Size(140, 35)
        quitter.TabIndex = 10
        quitter.Text = "Quitter"
        quitter.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Blue
        GroupBox2.Controls.Add(result)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(discriminat)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Location = New Point(51, 263)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(543, 129)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Iformations sur le discriminant"
        ' 
        ' result
        ' 
        result.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        result.Location = New Point(279, 81)
        result.Name = "result"
        result.Size = New Size(258, 23)
        result.TabIndex = 3
        result.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Symbol", 14.25F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(38, 76)
        Label10.Name = "Label10"
        Label10.Size = New Size(235, 25)
        Label10.TabIndex = 2
        Label10.Text = "ensemble des solutions:"
        ' 
        ' discriminat
        ' 
        discriminat.AutoSize = True
        discriminat.Font = New Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        discriminat.ForeColor = Color.Red
        discriminat.Location = New Point(326, 42)
        discriminat.Name = "discriminat"
        discriminat.Size = New Size(31, 23)
        discriminat.TabIndex = 1
        discriminat.Text = "..."
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(38, 42)
        Label9.Name = "Label9"
        Label9.Size = New Size(236, 26)
        Label9.TabIndex = 0
        Label9.Text = "Valeur du discriminant :"
        ' 
        ' resolveur_d_equations
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = My.Resources.Resources.banner_982162_640
        ClientSize = New Size(644, 440)
        Controls.Add(GroupBox2)
        Controls.Add(quitter)
        Controls.Add(calculer)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        ForeColor = Color.Black
        Name = "resolveur_d_equations"
        Text = "Résolveur d’équations de second dégré"
        TransparencyKey = Color.Navy
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents c As TextBox
    Friend WithEvents b As TextBox
    Friend WithEvents a As TextBox
    Friend WithEvents calculer As Button
    Friend WithEvents quitter As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents discriminat As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents result As TextBox
End Class
