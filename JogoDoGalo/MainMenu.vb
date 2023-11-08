Public Class MainMenu
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Preencha os dois campos para iniciar o jogo", MsgBoxStyle.Information, "Campos nao preenchidos")
        Else
            Jogadores.jogadorX = TextBox1.Text
            Jogadores.jogadorO = TextBox2.Text
            Dim novoJogo As New Form1
            Me.Hide()
            novoJogo.ShowDialog()
            Me.Show()
        End If


    End Sub

    Private Sub MainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        terminarJogo = True
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                TextBox2.Focus()
        End Select
    End Sub

    Private Sub MainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, TextBox2.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button1_Click(sender, EventArgs.Empty)

        End Select
    End Sub
End Class