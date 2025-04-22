Imports System.IO
Imports System.Media

Public Class frmMarcador
    Private puntosLocal As Integer = 0
    Private puntosVisitante As Integer = 0
    Private sonidoPunto As SoundPlayer = New SoundPlayer("Recursos/punto.wav")
    Private sonidoFin As SoundPlayer = New SoundPlayer("Recursos/fin_juego.wav")

    Private Sub btn1Local_Click(sender As Object, e As EventArgs) Handles btn1Local.Click
        puntosLocal += 1
        sonidoPunto.Play()
    End Sub

    Private Sub FinDelPartido()
        sonidoFin.Play()
        MessageBox.Show("Fin del juego")
    End Sub
End Class
