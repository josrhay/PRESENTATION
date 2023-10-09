<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestion_des_etudiants
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
        prenon = New TextBox()
        annee = New TextBox()
        nom = New TextBox()
        matricule = New TextBox()
        spe = New ComboBox()
        sexe = New ComboBox()
        nouveau = New Button()
        save = New Button()
        delate = New Button()
        annuler = New Button()
        precedant = New Button()
        debut = New Button()
        suivant = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        conteneur = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        modifier = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(conteneur, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MV Boli", 21.75F, FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(94, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(390, 39)
        Label1.TabIndex = 0
        Label1.Text = "GESTION DES ETUDIANTS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Viner Hand ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label2.Location = New Point(45, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 31)
        Label2.TabIndex = 1
        Label2.Text = "Matricule :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Viner Hand ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label3.Location = New Point(45, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 31)
        Label3.TabIndex = 2
        Label3.Text = "Nom :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Viner Hand ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label4.Location = New Point(45, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 31)
        Label4.TabIndex = 3
        Label4.Text = "Prenom :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Viner Hand ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label5.Location = New Point(45, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 31)
        Label5.TabIndex = 4
        Label5.Text = "Annee :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Viner Hand ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label6.Location = New Point(45, 316)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 31)
        Label6.TabIndex = 5
        Label6.Text = "Sexe :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Viner Hand ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Label7.Location = New Point(43, 285)
        Label7.Name = "Label7"
        Label7.Size = New Size(125, 31)
        Label7.TabIndex = 6
        Label7.Text = "Specialite :"
        ' 
        ' prenon
        ' 
        prenon.Location = New Point(223, 207)
        prenon.Name = "prenon"
        prenon.Size = New Size(121, 23)
        prenon.TabIndex = 7
        ' 
        ' annee
        ' 
        annee.Location = New Point(223, 245)
        annee.Name = "annee"
        annee.Size = New Size(121, 23)
        annee.TabIndex = 7
        ' 
        ' nom
        ' 
        nom.Location = New Point(223, 174)
        nom.Name = "nom"
        nom.Size = New Size(121, 23)
        nom.TabIndex = 7
        ' 
        ' matricule
        ' 
        matricule.Location = New Point(223, 138)
        matricule.Name = "matricule"
        matricule.Size = New Size(121, 23)
        matricule.TabIndex = 7
        ' 
        ' spe
        ' 
        spe.FormattingEnabled = True
        spe.Items.AddRange(New Object() {"GL", "MCV", "RS", "RH", "GLT"})
        spe.Location = New Point(223, 283)
        spe.Name = "spe"
        spe.Size = New Size(121, 23)
        spe.TabIndex = 8
        ' 
        ' sexe
        ' 
        sexe.FormattingEnabled = True
        sexe.Items.AddRange(New Object() {"FEMME", "HOMME"})
        sexe.Location = New Point(223, 316)
        sexe.Name = "sexe"
        sexe.Size = New Size(121, 23)
        sexe.TabIndex = 9
        ' 
        ' nouveau
        ' 
        nouveau.Location = New Point(59, 22)
        nouveau.Name = "nouveau"
        nouveau.Size = New Size(75, 23)
        nouveau.TabIndex = 10
        nouveau.Text = "Nouveau"
        nouveau.UseVisualStyleBackColor = True
        ' 
        ' save
        ' 
        save.Location = New Point(59, 62)
        save.Name = "save"
        save.Size = New Size(75, 23)
        save.TabIndex = 11
        save.Text = "Enregistre"
        save.UseVisualStyleBackColor = True
        ' 
        ' delate
        ' 
        delate.Location = New Point(59, 96)
        delate.Name = "delate"
        delate.Size = New Size(75, 23)
        delate.TabIndex = 12
        delate.Text = "supprimer"
        delate.UseVisualStyleBackColor = True
        ' 
        ' annuler
        ' 
        annuler.Location = New Point(59, 132)
        annuler.Name = "annuler"
        annuler.Size = New Size(75, 23)
        annuler.TabIndex = 13
        annuler.Text = "Annuler"
        annuler.UseVisualStyleBackColor = True
        ' 
        ' precedant
        ' 
        precedant.Location = New Point(26, 22)
        precedant.Name = "precedant"
        precedant.Size = New Size(75, 36)
        precedant.TabIndex = 14
        precedant.Text = "Pre"
        precedant.UseVisualStyleBackColor = True
        ' 
        ' debut
        ' 
        debut.Location = New Point(187, 22)
        debut.Name = "debut"
        debut.Size = New Size(75, 36)
        debut.TabIndex = 15
        debut.Text = "Debut"
        debut.UseVisualStyleBackColor = True
        ' 
        ' suivant
        ' 
        suivant.Location = New Point(361, 22)
        suivant.Name = "suivant"
        suivant.Size = New Size(75, 36)
        suivant.TabIndex = 16
        suivant.Text = "Suiv"
        suivant.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        GroupBox1.Controls.Add(modifier)
        GroupBox1.Controls.Add(nouveau)
        GroupBox1.Controls.Add(delate)
        GroupBox1.Controls.Add(save)
        GroupBox1.Controls.Add(annuler)
        GroupBox1.Location = New Point(350, 130)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(186, 209)
        GroupBox1.TabIndex = 17
        GroupBox1.TabStop = False
        GroupBox1.Text = "manipulations"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        GroupBox2.Controls.Add(precedant)
        GroupBox2.Controls.Add(debut)
        GroupBox2.Controls.Add(suivant)
        GroupBox2.Location = New Point(48, 359)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(488, 69)
        GroupBox2.TabIndex = 18
        GroupBox2.TabStop = False
        ' 
        ' conteneur
        ' 
        conteneur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        conteneur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        conteneur.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        conteneur.Location = New Point(48, 448)
        conteneur.Name = "conteneur"
        conteneur.RowTemplate.Height = 25
        conteneur.Size = New Size(488, 45)
        conteneur.TabIndex = 19
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "matricule"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "nom"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "prenom"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "annee"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "specialite"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "sexe"
        Column6.Name = "Column6"
        ' 
        ' modifier
        ' 
        modifier.Location = New Point(59, 163)
        modifier.Name = "modifier"
        modifier.Size = New Size(75, 23)
        modifier.TabIndex = 14
        modifier.Text = "modifier"
        modifier.UseVisualStyleBackColor = True
        ' 
        ' gestion_des_etudiants
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        ClientSize = New Size(585, 531)
        Controls.Add(conteneur)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(sexe)
        Controls.Add(spe)
        Controls.Add(matricule)
        Controls.Add(nom)
        Controls.Add(annee)
        Controls.Add(prenon)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "gestion_des_etudiants"
        Text = "gestion_des_etudiants"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        CType(conteneur, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents prenon As TextBox
    Friend WithEvents annee As TextBox
    Friend WithEvents nom As TextBox
    Friend WithEvents matricule As TextBox
    Friend WithEvents spe As ComboBox
    Friend WithEvents sexe As ComboBox
    Friend WithEvents nouveau As Button
    Friend WithEvents save As Button
    Friend WithEvents delate As Button
    Friend WithEvents annuler As Button
    Friend WithEvents precedant As Button
    Friend WithEvents debut As Button
    Friend WithEvents suivant As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents conteneur As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents modifier As Button
End Class
