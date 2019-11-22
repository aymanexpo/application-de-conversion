Imports System.IO
Public Class enregistrement_des_données
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'creer un ficier et enreistrer des données dans le 
        ''le clique sur le boutton permet d ouvrir une interface d enregistrement des fichiers 
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'declarration d une variable d ecriture dans le fichier et l'enregistrer
            Dim sw As New StreamWriter(SaveFileDialog1.FileName)
            'l ecriture dans le fichier 
            sw.Write(TextBox1.Text)
            'la fermiture de fichier 
            sw.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ouvrir un fichier s il existe 
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sr As New StreamReader(OpenFileDialog1.FileName)
            TextBox2.Text = sr.ReadToEnd
            'fermer le fichier 
            sr.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'enregistrer des données dans le fichier ouvré
        Dim sw As New StreamWriter(OpenFileDialog1.FileName)
        sw.Write(TextBox2.Text)
        'fermiture de fichier
        sw.Close()
    End Sub
End Class