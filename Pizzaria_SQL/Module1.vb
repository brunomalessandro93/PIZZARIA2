Module Module1

    Public db, dx As New ADODB.Connection
    Public rs, rx As New ADODB.Recordset
    Public cont As Integer


    Public sql, sqx, ativar, Status, aux, resp As String

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.connection")
            db.Open("Provider = SQLOLEDB;Data Source= LAPTOP-F9R7ORS0; Initial Catalog = pizzaria; trusted_connection=yes;")
            '  MsgBox("Conexão bem sucedida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro ao conectar com o banco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub carregar_tipo()
        With criar_contas.txt_perfil.Items
            .Add("ADMINISTRADOR")
            .Add("USUARIO")
        End With
        criar_contas.txt_perfil.SelectedIndex = 1

        With criar_contas.txt_status.Items
            .Add("ATIVA")
            .Add("BLOQUEADA")
        End With
        criar_contas.txt_status.SelectedIndex = 0
    End Sub
    Sub carregar_dados()
        With painel.dgv_dados
            sql = "select * from tb_usuario order by nome asc "
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value,
                          rs.Fields(4).Value,
                          rs.Fields(1).Value,
                          rs.Fields(2).Value,
                          rs.Fields(3).Value,
                          Nothing, Nothing, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub
    Sub carregar_parametro()
        With painel.txt_parametro.Items
            .Add("Nome")
            .Add("Email")
        End With
        painel.txt_parametro.SelectedIndex = 0
    End Sub

End Module
