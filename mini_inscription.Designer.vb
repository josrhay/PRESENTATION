<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mini_inscription
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
        nom = New TextBox()
        prenom = New TextBox()
        desg = New TextBox()
        quartier = New TextBox()
        cmd = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        rendu = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        CType(rendu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' nom
        ' 
        nom.BackColor = Color.CornflowerBlue
        nom.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        nom.ForeColor = Color.Black
        nom.Location = New Point(268, 98)
        nom.Name = "nom"
        nom.Size = New Size(170, 27)
        nom.TabIndex = 4
        ' 
        ' prenom
        ' 
        prenom.BackColor = Color.CornflowerBlue
        prenom.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        prenom.ForeColor = Color.Black
        prenom.Location = New Point(281, 146)
        prenom.Name = "prenom"
        prenom.Size = New Size(170, 27)
        prenom.TabIndex = 5
        ' 
        ' desg
        ' 
        desg.BackColor = Color.CornflowerBlue
        desg.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        desg.ForeColor = Color.Black
        desg.Location = New Point(338, 248)
        desg.Name = "desg"
        desg.Size = New Size(170, 27)
        desg.TabIndex = 6
        ' 
        ' quartier
        ' 
        quartier.BackColor = Color.CornflowerBlue
        quartier.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        quartier.ForeColor = Color.Black
        quartier.Location = New Point(338, 198)
        quartier.Name = "quartier"
        quartier.Size = New Size(170, 27)
        quartier.TabIndex = 7
        ' 
        ' cmd
        ' 
        cmd.BackColor = SystemColors.ActiveCaption
        cmd.Font = New Font("Segoe UI Historic", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        cmd.ForeColor = Color.Navy
        cmd.Location = New Point(75, 318)
        cmd.Name = "cmd"
        cmd.Size = New Size(433, 47)
        cmd.TabIndex = 8
        cmd.Text = "COMMENDER"
        cmd.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.CornflowerBlue
        Label4.Font = New Font("Sitka Small", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label4.Location = New Point(75, 195)
        Label4.Name = "Label4"
        Label4.Size = New Size(237, 28)
        Label4.TabIndex = 3
        Label4.Text = "Quartier de residence:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.CornflowerBlue
        Label3.Font = New Font("Sitka Small", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label3.Location = New Point(75, 245)
        Label3.Name = "Label3"
        Label3.Size = New Size(253, 28)
        Label3.TabIndex = 2
        Label3.Text = "Designation du produit:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.CornflowerBlue
        Label2.Font = New Font("Sitka Small", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label2.Location = New Point(75, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(158, 28)
        Label2.TabIndex = 1
        Label2.Text = "Votre prenom:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.CornflowerBlue
        Label1.Font = New Font("Sitka Small", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label1.Location = New Point(75, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 28)
        Label1.TabIndex = 0
        Label1.Text = "votre nom :"
        ' 
        ' rendu
        ' 
        rendu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        rendu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        rendu.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        rendu.Location = New Point(94, 404)
        rendu.Name = "rendu"
        rendu.RowTemplate.Height = 25
        rendu.Size = New Size(376, 44)
        rendu.TabIndex = 9
        rendu.Visible = False
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "nom"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "prenom"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "quartier"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "desg"
        Column4.Name = "Column4"
        ' 
        ' mini_inscription
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.market_2071976_640
        ClientSize = New Size(561, 468)
        Controls.Add(rendu)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(cmd)
        Controls.Add(Label3)
        Controls.Add(quartier)
        Controls.Add(Label4)
        Controls.Add(desg)
        Controls.Add(nom)
        Controls.Add(prenom)
        Name = "mini_inscription"
        Text = "mini_inscription"
        CType(rendu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents nom As TextBox
    Friend WithEvents prenom As TextBox
    Friend WithEvents desg As TextBox
    Friend WithEvents quartier As TextBox
    Friend WithEvents cmd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rendu As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
