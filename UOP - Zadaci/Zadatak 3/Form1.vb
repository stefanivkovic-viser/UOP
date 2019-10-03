Public Class Form1
    Dim zelena As New Zelena() 'pravimo primerak forme Zelena
    Dim plava As New Plava() 'pravimo primerak forme Plava
    'ovo radimo da bi mogli da im menjamo svojstva
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        zelena.MdiParent = Me 'roditelj zelene forme postaje prva forma
        plava.MdiParent = Me 'roditelj plave forme postaje prva forma

        zelena.Size = New Size(Me.Width / 2, Me.Height) 'postavljamo velicinu zelene forme tako da bude duplo uza od glavne (prve forme), a iste visine kao prva forma
        zelena.ControlBox = False
        zelena.FormBorderStyle = FormBorderStyle.None 'skidamo okvir sa forme
        zelena.Show() 'prikazujemo formu na ekranu

        plava.Size = New Size(Me.Width / 2, Me.Height) 'postavljamo velicinu plave forme tako da bude duplo uza od glavne (prve forme), a iste visine kao prva forma
        plava.ControlBox = False
        plava.FormBorderStyle = FormBorderStyle.None 'skidamo okvir
        plava.Show() 'prikazujemo formu na ekranu
        plava.Left = zelena.Width 'postavljamo lokaciju plave forme na pola tako sto je pomeramo u levo za sirinu zelene forme

    End Sub
End Class
