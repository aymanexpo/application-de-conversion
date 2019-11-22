Public Class Form1
    'declaration des variables globales 
    'enregistrement de mot de passe dans une variable de type string ou 'char'
    Dim y As String
    Dim mdp As String = "aymanexpo"
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'reception de mot de passe au clavier de l utilisateur
        'le mot de passe peut contenir meme si des chiffres numériques
        y = TextBox1.Text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'enregistrement de phrase qui indique que le mot de passe est n est pas exacte et demmande la saisie d un mot de passe exacte 
        Dim P As String = "entrez le mot de passe exacte!!"
        'enregistremment de laphrase de l obligation de choix d une opperration par l'utilisateur
        Dim T As String = "veuillez choisir une opperation!!"
        'le titre de message box à afficher
        Dim tit As String = "at.app"
        'le message de reception d un nouvel mot de passe
        Dim msg_changer As String = "veuimllez entrer le nouveau mot de passe"
        If y <> mdp Then
            'si le mot de passe n est pas exacte:
            MessageBox.Show(P, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'selon le choix de l utilisateur on va afficher le formulaire de l application choisie
            If RadioButton1.Checked() = False And RadioButton2.Checked() = False Then
                MessageBox.Show(T, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf RadioButton1.Checked() = True Then
                'une petite salutation pour l'utilisateur et après l ouvrission de l'application de convertissage de la monnaie
                MessageBox.Show("bonjour:)", "alexpo_app", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Form2.Show()
            ElseIf RadioButton2.Checked() = True Then
                'affichage d une petite salutaion pour l'etulisateur:
                MessageBox.Show("bonjour:)", "alexpo_app", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'ouvrition de l application calculatrice dirrectement sans ouvrission de convertisseur de la monaie
                Form3.Show()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ouvrission de champ ou formulaire qui permet a l'utilisateur de s'inscrire 
        enregistrement_des_données.Show()
    End Sub
End Class