Public Class SplashScreen


    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub CarregarJogo(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()

        Timer1.Stop()
        Dim menuPrincipal As New MainMenu
        menuPrincipal.Show()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If terminarJogo Then
            End
        End If
    End Sub
End Class