Module ModulZ1
    Function izracunaj_formulu(ByVal x As Integer) 'x je ByVal zato sto ga koristimo da bi dobili rezultat, a ne da bi ga menjali
        Dim rezultat As Double 'rezultat deklarisemo kao promenljivu realnog tipa jer moze da ima zarez zbog korena u formuli
        rezultat = Math.Pow(x, 1 / 3) * 3 + 5 * x + 10 'racunamo formulu
        Return rezultat 'vracamo rezultat funkcije
    End Function
End Module
