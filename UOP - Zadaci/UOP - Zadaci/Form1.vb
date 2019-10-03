Public Class Form1
    Private Sub BtnIzracunaj_Click(sender As Object, e As EventArgs) Handles btnIzracunaj.Click
        Dim x As Integer 'deklarisemo promenljivu x koju korisnik unosi kroz prvi textbox
        x = Val(txtX.Text) 'posto je vrednost uneta u textboxu tipa string moramo prvo da je konvertujemo u broj i da je smestimo u x
        txtRezultat.Text = izracunaj_formulu(x).ToString() 'zatim u rezultujuci textbox smestamo rezultat koji je dobijen u funkciji, funkcija se nalazi u modulu ModulZ1
    End Sub
End Class
