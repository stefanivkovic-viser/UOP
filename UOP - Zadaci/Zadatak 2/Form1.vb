Public Class Form1
    Dim radi As Boolean = True 'dodajemo logicku promenljivu koja cuva stanje koje pokazuje da li snimak radi ili je pauziran

    'POGLEDAJ VIDEO U FOLDERU ZA NAMESTANJE MEDIA PLAYER-A!!!
    ' ja sam za primer stavio snimak iz svog kompa, tebi nece raditi, zato samo stavi neki klip iz tvog kompa

    Private Sub BtnPlayPause_Click(sender As Object, e As EventArgs) Handles btnPlayPause.Click
        If radi = True Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause() 'ako snimak radi klikom na dugme zaustavljamo snimak
            radi = False 'nakon sto smo pauzirali snimak, menjamo stanje u promenljivoj u False odnosno ne radi
            btnPlayPause.Text = "NASTAVI" 'menjamo i tekst u nastavi jer sledecim klikom nastavljamo pustanje videa
        Else 'ovde sve suprotno ide
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            radi = True
            btnPlayPause.Text = "PAUZIRAJ"
        End If
    End Sub
End Class
