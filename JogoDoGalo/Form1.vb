Public Class Form1

    Dim turno As String
    Dim ultimoJogada As String
    Dim casasRestantes As Integer
    Dim fimDoJogo As Boolean
    Dim pontuacaoX As Integer
    Dim pontuacaoO As Integer

    Sub IniciarJogo()
        pontuacaoX = 0
        pontuacaoO = 0
        InserirDados()
        ReiniciarJogo("X")

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IniciarJogo()
    End Sub

    Sub InserirDados()

        ToolStripTextBox2.Text = "X: " & Jogadores.jogadorX & "- " & pontuacaoX
        ToolStripTextBox3.Text = "O: " & Jogadores.jogadorO & "- " & pontuacaoO
    End Sub
    Sub ReiniciarJogo(inicio As String)
        InserirDados()
        turno = inicio
        Select Case turno
            Case "X"
                ToolStripComboBox1.SelectedItem = ToolStripComboBox1.Items.Item(1)
            Case "O"
                ToolStripComboBox1.SelectedItem = ToolStripComboBox1.Items.Item(0)

        End Select
        fimDoJogo = False
        ultimoJogada = ""
        casasRestantes = 9
        btn1.Tag = "a"
        btn2.Tag = "b"
        btn3.Tag = "c"
        btn4.Tag = "d"
        btn5.Tag = "e"
        btn6.Tag = "f"
        btn7.Tag = "g"
        btn8.Tag = "h"
        btn9.Tag = "i"

        btn1.BackgroundImage = Nothing
        btn2.BackgroundImage = Nothing
        btn3.BackgroundImage = Nothing
        btn4.BackgroundImage = Nothing
        btn5.BackgroundImage = Nothing
        btn6.BackgroundImage = Nothing
        btn7.BackgroundImage = Nothing
        btn8.BackgroundImage = Nothing
        btn9.BackgroundImage = Nothing



        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True

    End Sub

    Sub Vencedor()
        Dim vencedor As String = ""
        If CType(btn1.Tag, String) = CType(btn2.Tag, String) And CType(btn2.Tag, String) = CType(btn3.Tag, String) And CType(btn1.Tag, String) = CType(btn3.Tag, String) Then
            vencedor = CType(btn1.Tag, String)
        ElseIf CType(btn4.Tag, String) = CType(btn5.Tag, String) And CType(btn5.Tag, String) = CType(btn6.Tag, String) And CType(btn4.Tag, String) = CType(btn6.Tag, String) Then
            vencedor = CType(btn4.Tag, String)
        ElseIf CType(btn7.Tag, String) = CType(btn8.Tag, String) And CType(btn8.Tag, String) = CType(btn9.Tag, String) And CType(btn7.Tag, String) = CType(btn9.Tag, String) Then
            vencedor = CType(btn7.Tag, String)
        ElseIf CType(btn1.Tag, String) = CType(btn4.Tag, String) And CType(btn4.Tag, String) = CType(btn7.Tag, String) And CType(btn1.Tag, String) = CType(btn7.Tag, String) Then
            vencedor = CType(btn1.Tag, String)
        ElseIf CType(btn2.Tag, String) = CType(btn5.Tag, String) And CType(btn5.Tag, String) = CType(btn8.Tag, String) And CType(btn2.Tag, String) = CType(btn8.Tag, String) Then
            vencedor = CType(btn2.Tag, String)
        ElseIf CType(btn3.Tag, String) = CType(btn6.Tag, String) And CType(btn6.Tag, String) = CType(btn9.Tag, String) And CType(btn3.Tag, String) = CType(btn9.Tag, String) Then
            vencedor = CType(btn3.Tag, String)
        ElseIf CType(btn1.Tag, String) = CType(btn5.Tag, String) And CType(btn5.Tag, String) = CType(btn9.Tag, String) And CType(btn1.Tag, String) = CType(btn9.Tag, String) Then
            vencedor = CType(btn1.Tag, String)
        ElseIf CType(btn3.Tag, String) = CType(btn5.Tag, String) And CType(btn5.Tag, String) = CType(btn7.Tag, String) And CType(btn3.Tag, String) = CType(btn7.Tag, String) Then
            vencedor = CType(btn3.Tag, String)
        End If

        Select Case vencedor
            Case "X"
                MsgBox("O vencedor e o " & Jogadores.jogadorX)
                pontuacaoX = pontuacaoX + 1
                fimDoJogo = True
            Case "O"
                MsgBox("O vencedor e o " & Jogadores.jogadorO)
                pontuacaoO = pontuacaoO + 1
                fimDoJogo = True
        End Select
        If casasRestantes = 0 And vencedor = "" Then
            MsgBox("Empate")
            fimDoJogo = True
        End If

        If fimDoJogo Then

            If MsgBox("Desejam jogar novamente ?", MsgBoxStyle.YesNo, "Reiniciar Jogo") = MsgBoxResult.Yes Then
                If vencedor <> "" Then
                    ReiniciarJogo(vencedor)
                Else : ReiniciarJogo("X")
                End If

            End If
            ToolStripTextBox2.Text = "X: " & Jogadores.jogadorX & "- " & pontuacaoX
            ToolStripTextBox3.Text = "O: " & Jogadores.jogadorO & "- " & pontuacaoO
        End If
    End Sub
    Private Sub Jogada(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn1.Click, btn2.Click
        Dim botao_clicado As Button = CType(sender, Button)

        botao_clicado.Enabled = False
        casasRestantes = casasRestantes - 1
        ultimoJogada = turno
        Select Case turno
            Case "X"
                botao_clicado.BackgroundImage = My.Resources.Cruz
                turno = "O"
                ToolStripComboBox1.SelectedItem = ToolStripComboBox1.Items.Item(0)
                botao_clicado.Tag = ultimoJogada
                Vencedor()
            Case "O"
                botao_clicado.BackgroundImage = My.Resources.Circulo
                turno = "X"
                ToolStripComboBox1.SelectedItem = ToolStripComboBox1.Items.Item(1)
                botao_clicado.Tag = ultimoJogada
                Vencedor()
        End Select

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub

    Private Sub IniciarNovoJogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarNovoJogoToolStripMenuItem.Click

        Me.Close()
        IniciarJogo()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Sobre.ShowDialog()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Dim main As New MainMenu
        main.TextBox1.Text = Jogadores.jogadorX
        main.TextBox2.Text = Jogadores.jogadorO
        main.ShowDialog()
    End Sub
End Class
