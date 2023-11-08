<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.JogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarNovoJogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JogoToolStripMenuItem, Me.ToolStripComboBox1, Me.ToolStripTextBox2, Me.ToolStripTextBox3, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'JogoToolStripMenuItem
        '
        Me.JogoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarNovoJogoToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.JogoToolStripMenuItem.Name = "JogoToolStripMenuItem"
        Me.JogoToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.JogoToolStripMenuItem.Text = "Jogo"
        '
        'IniciarNovoJogoToolStripMenuItem
        '
        Me.IniciarNovoJogoToolStripMenuItem.Name = "IniciarNovoJogoToolStripMenuItem"
        Me.IniciarNovoJogoToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.IniciarNovoJogoToolStripMenuItem.Text = "Iniciar Novo Jogo"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Enabled = False
        Me.ToolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Turno:O", "Turno:X"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ToolStripComboBox1.Text = "Turno:X"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox2.Text = "X"
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox3.Text = "O"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(49, 23)
        Me.ToolStripMenuItem1.Text = "Sobre"
        '
        'btn9
        '
        Me.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn9.Location = New System.Drawing.Point(314, 314)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(135, 135)
        Me.btn9.TabIndex = 10
        Me.btn9.Tag = "i"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn8.Location = New System.Drawing.Point(173, 314)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(135, 135)
        Me.btn8.TabIndex = 9
        Me.btn8.Tag = "h"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn7.Location = New System.Drawing.Point(32, 314)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(135, 135)
        Me.btn7.TabIndex = 8
        Me.btn7.Tag = "g"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn6.Location = New System.Drawing.Point(314, 173)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(135, 135)
        Me.btn6.TabIndex = 7
        Me.btn6.Tag = "f"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn5.Location = New System.Drawing.Point(173, 173)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(135, 135)
        Me.btn5.TabIndex = 6
        Me.btn5.Tag = "e"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn4.Location = New System.Drawing.Point(32, 173)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(135, 135)
        Me.btn4.TabIndex = 5
        Me.btn4.Tag = "d"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn3.Location = New System.Drawing.Point(314, 32)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(135, 135)
        Me.btn3.TabIndex = 4
        Me.btn3.Tag = "c"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn2.Location = New System.Drawing.Point(173, 32)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(135, 135)
        Me.btn2.TabIndex = 3
        Me.btn2.Tag = "b"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn1.Location = New System.Drawing.Point(32, 32)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(135, 135)
        Me.btn1.TabIndex = 2
        Me.btn1.Tag = "a"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Jogo do Galo"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents JogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IniciarNovoJogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents ToolStripTextBox3 As ToolStripTextBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
