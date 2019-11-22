Public Class Form2
    Dim v As Double
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        'vonversion de contenu de textbox a une valeur numerique de type double
        v = Val(TextBox2.Text)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'traitement de conversion selon le choix de l utilisateur 
        If RadioButton1.Checked() = True Then
            TextBox1.Text = v
            TextBox3.Text = v / 9.2
            TextBox4.Text = v / 10
        ElseIf RadioButton2.Checked() = True Then
            TextBox1.Text = v * 9.2
            TextBox3.Text = v
            TextBox4.Text = v / 1.12
        ElseIf RadioButton3.Checked() = True Then
            TextBox1.Text = v * 10
            TextBox3.Text = v * 0.89
            TextBox4.Text = v
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'configuration de quitter l application 
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'configuration pour se deconnecter de la sesion 
        Me.Close()
        'clear le textbox de 1er formulaire
        Form1.TextBox1.Clear()
        'clear les radio_bouttans de 1er formulaire
        Form1.RadioButton1.Checked() = False
        Form1.RadioButton2.Checked() = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'traitement de choix de faire une nouvelle conversation
        'vider les textboxs du 2eme formulaire
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        'uncheck tous les bouttons radio du 2eme formulaire
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'ouvrission de formulaire 3
        Form3.Show()
    End Sub
End Class