﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_gerenciar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(445, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome do Usuário"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(445, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Senha"
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(450, 74)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(331, 34)
        Me.txt_usuario.TabIndex = 3
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(451, 177)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(331, 34)
        Me.txt_senha.TabIndex = 4
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(653, 267)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(129, 51)
        Me.btn_login.TabIndex = 5
        Me.btn_login.Text = "Log in"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 54)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "BELLA PIZZA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nome: ADMIN   Senha: ADMIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Administrador:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Usuário:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Nome: TESTE  Senha: TESTE"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_gerenciar
        '
        Me.btn_gerenciar.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gerenciar.Location = New System.Drawing.Point(352, 254)
        Me.btn_gerenciar.Name = "btn_gerenciar"
        Me.btn_gerenciar.Size = New System.Drawing.Size(259, 82)
        Me.btn_gerenciar.TabIndex = 12
        Me.btn_gerenciar.Text = "Gerenciar/Criar Conta"
        Me.btn_gerenciar.UseVisualStyleBackColor = True
        Me.btn_gerenciar.Visible = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 348)
        Me.Controls.Add(Me.btn_gerenciar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "main"
        Me.Text = "BELLA PIZZA "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog

    Private Sub btn_criar_conta_Click(sender As Object, e As EventArgs)
        criar_contas.Show()
    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        ativar = "ativa"
        sql = " select * from tb_usuario where nome = '" & txt_usuario.Text & "'
                                            and senha = '" & txt_senha.Text & "'
                                            and status = '" & ativar & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            tela_main.Show()
        Else
            MsgBox("Nome ou senha inválido(s)!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso!")
        End If
    End Sub

    Friend WithEvents btn_gerenciar As Button

    Private Sub btn_gerenciar_Click(sender As Object, e As EventArgs) Handles btn_gerenciar.Click
        painel.Show()
    End Sub

    Private Sub txt_senha_TextChanged(sender As Object, e As EventArgs) Handles txt_senha.TextChanged
        ' BOTÃO DE [CRIAR/GERENCIAR CONTAS] SÓ APARECE SE FOR "ATIVA" E "ADMINISTRADOR"
        ativar = "ativa"
        Status = "administrador"
        sql = " select * from tb_usuario where nome = '" & txt_usuario.Text & "'
                                            and senha = '" & txt_senha.Text & "'
                                            and status = '" & ativar & "'
                                            and perfil = '" & Status & "' "
        rs = db.Execute(sql)
        If rs.EOF = False Then
            btn_gerenciar.Show()
        Else
            btn_gerenciar.Visible = False
        End If
    End Sub
End Class
