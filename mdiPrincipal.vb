Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class mdiPrincipal
    Dim bUsarVPN As Boolean = IIf(LerDadosINI(nomeArquivoINI(), "VPN", "Ativar", "nao") = "nao", False, True)

    Private Sub mdiPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Argumentos() As String = Environment.GetCommandLineArgs
        Dim sNomeUsuario As String
        Dim bArguments As Boolean = True
        Dim x, y As Integer

        g_Modulo = "ASSOCIADOS"

        'Ativar os Parâmetros iniciais de Segurança
        'Resgatar as Informações da Chamada
        x = 0
        Y = 0
        g_Login = ""

        If Not bUsarVPN Then
            'bArguments = False
            '***** Indicar qual usuário deverá se logado automaticamente
            'g_Login = ClassCrypt.Encrypt("admin")
            'g_Login = ClassCrypt.Encrypt("jose.alves")
            'g_Login = ClassCrypt.Encrypt("luciano.vieira")
            'g_Login = ClassCrypt.Encrypt("teste.3")
            '*****
        End If
        Try
            Do While bArguments
                If Environment.CommandLine(x) = "-" Then
                    If y = 0 Then
                        y = x
                    Else
                        bArguments = False
                    End If
                ElseIf y <> 0 Then
                    g_Login += Environment.CommandLine(x)
                End If
                x += 1
            Loop

            'MsgBox(g_Login)
            If g_Login = "" Then
                'Ativar estas Linhas quando for colocar em produção
                MsgBox("Este programa não tem permissão para ser executado. Contactar o administrador da rede!!", MsgBoxStyle.Critical)
                Application.Exit()
            End If
        Catch ex As Exception
            MsgBox("Este programa não tem permissão para ser executado. Contactar o administrador da rede!!", MsgBoxStyle.Critical)
            Application.Exit()

        Finally
            'Conection String
            g_ConnectString = (LerDadosINI(nomeArquivoINI(), "CONEXAO", "ConnectString", _
                ClassCrypt.Encrypt("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SSVP.accdb;Persist Security Info=False;")))

            'Conectar com o Banco de dados
            If Not ConectarBanco() Then
                Application.Exit()
            End If

            'Ler o Usuário e Validar o Acesso
            sNomeUsuario = LerUsuario(ClassCrypt.Decrypt(g_Login), Nothing)

            If sNomeUsuario <> "" Then
                Me.Text = "Modulo " & g_Modulo & " - Usuário: " & sNomeUsuario
            Else
                Application.Exit()
            End If

            'Verificar o acesso às opções do sistema
            Dim cModulo As Integer = getCodModulo(g_Modulo) 'Pegar o código do Módulo
            Dim nCodUsuario As Integer = getCodUsuario(ClassCrypt.Decrypt(g_Login)) 'pegar o código do usuario
            'Verificar o acesso às opções do sistema
            
            For Each _control As Object In Me.Controls
                If TypeOf (_control) Is MenuStrip Then
                    For Each itm As ToolStripMenuItem In _control.items
                        If itm.Text <> "&Sair" And itm.Name.ToString.StartsWith("menu") Then
                            itm.Tag = NivelAcesso(nCodUsuario, cModulo, itm.Name, "")
                            itm.Enabled = itm.Tag > 0
                            'Função para Verificar os SubItens do menu
                            If itm.DropDownItems.Count > 0 Then LoopMenuItems(itm, nCodUsuario, cModulo, itm.Name)
                        End If
                    Next
                End If
            Next
        End Try

    End Sub

    Private Function LoopMenuItems(ByVal parent As ToolStripMenuItem, nCodUsuario As Integer, cModulo As Integer, fPrincOpcao As String) As Object
        Dim retval As Object = Nothing

        For Each child As Object In parent.DropDownItems

            'MessageBox.Show("Child : " & child.name)

            If TypeOf (child) Is ToolStripMenuItem Then
                If child.Text <> "Sair" And child.Name.ToString.StartsWith("menu") Then
                    child.Tag = NivelAcesso(nCodUsuario, cModulo, child.Name, fPrincOpcao)
                    child.Enabled = child.Tag > 0
                    If child.DropDownItems.Count > 0 Then
                        retval = LoopMenuItems(child, nCodUsuario, cModulo, child.name)
                        If Not retval Is Nothing Then Exit For
                    End If
                End If
            End If
        Next

        Return retval
    End Function

    Private Sub menuConfiguracoes_Click(sender As Object, e As EventArgs) Handles menuSisConfiguracoes.Click
        Dim ChildForm As New Parametros

        ChildForm.MdiParent = Me
        ChildForm.Tag = menuSisConfiguracoes.Tag 'é gravado no tag do menu o nível de acesso
        ChildForm.Show()

    End Sub

    Private Sub menuUsuarios_Click(sender As Object, e As EventArgs) Handles menuSisUsuarios.Click
        '?? Alterar os parâmetros para passar ao Browse (Entidade e Form. do Cadastro) ??
        Dim sWhere As String = "SI000_STAUSU<>'E'"
        Dim nCodigoUsu As Integer = getCodUsuario(ClassCrypt.Decrypt(g_Login))

        If Not UsuarioAdministrador(nCodigoUsu) Then
            sWhere += " and SI000_CODUSU=" & nCodigoUsu.ToString
        End If

        Dim frmBrowse_Usuario As frmBrowse = New frmBrowse("ESI000", "frmUsuario", , sWhere)

        frmBrowse_Usuario.MdiParent = Me
        frmBrowse_Usuario.Tag = menuSisUsuarios.Tag 'é gravado no tag do menu o nível de acesso
        frmBrowse_Usuario.Text = menuSisUsuarios.Text
        frmBrowse_Usuario.Show()

    End Sub

    Private Sub menuRelatorios_Click(sender As Object, e As EventArgs) Handles menuRelatorios.Click

    End Sub

    Private Sub menuCadTipoDeOcupacao_Click(sender As Object, e As EventArgs) Handles menuCadTipoDeOcupacao.Click
        Dim frmBrowse_TipoDeOcupacao As frmBrowse = New frmBrowse("EUN011", "frmTipoDeOcupacao")

        frmBrowse_TipoDeOcupacao.MdiParent = Me
        frmBrowse_TipoDeOcupacao.Tag = menuCadTipoDeOcupacao.Tag 'é gravado no tag do menu o nível de acesso
        frmBrowse_TipoDeOcupacao.Text = menuCadTipoDeOcupacao.Text
        frmBrowse_TipoDeOcupacao.Show()
    End Sub

    Private Sub menuRelUnidades_Click(sender As Object, e As EventArgs) Handles menuRelUnidades.Click
        Dim frmRelUnidades As frmRelUnidades = New frmRelUnidades

        frmRelUnidades.MdiParent = Me
        frmRelUnidades.Tag = menuRelUnidades.Tag 'é gravado no tag do menu o nível de acesso
        frmRelUnidades.Text = menuRelUnidades.Text
        frmRelUnidades.Show()

    End Sub


    Private Sub menuConsAgre_Click(sender As Object, e As EventArgs)
        Dim cQuery As String
        Dim dtQuery As DataTable = New DataTable("EUN015")
        Dim cmd As OleDbCommand
        Dim ix As Double
        Dim CodRed As Integer

        'Atualizar o num. de registro da Agregação na Unidade
        cQuery = "SELECT UN015_NUMAGR, UN015_CLAUNI FROM EUN015"
        Using daTabela As New OleDbDataAdapter()
            daTabela.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)

            ' Preencher o DataTable 
            daTabela.Fill(dtQuery)
            For ix = 0 To dtQuery.Rows.Count - 1
                CodRed = LerCod_Unidade(dtQuery.Rows(ix).Item("UN015_CLAUNI"))
                cQuery = "UPDATE EUN015 set UN015_CODCF=" & CodRed & _
                        " where UN015_NUMAGR = " & dtQuery.Rows(ix).Item("UN015_NUMAGR").ToString

                cmd = New OleDbCommand(cQuery, g_ConnectBanco)

                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString())
                Finally
                End Try
            Next
        End Using

        dtQuery.Clear()

        MsgBox("Termino da Atualizacao !!")

    End Sub

    Private Sub menuCadColaboradores_Click(sender As Object, e As EventArgs) Handles menuCadColaboradores.Click
        Dim frmBrowse_Colaboradores As frmBrowse = New frmBrowse("EUN003", "frmAssociados", , "EUN003.UN003_SITCOL<>'E'")
        'left join EUN013 on EUN013.UN013_CODUNI=EUN003.UN003_CODUNI", _
        '                                            "(EUN013.UN013_CODUSU=" & getCodUsuario(ClassCrypt.Decrypt(g_Login)).ToString & " AND UN013_PERACE > 0) or (EUN003.UN003_CODUNI=0)")

        frmBrowse_Colaboradores.MdiParent = Me
        frmBrowse_Colaboradores.Tag = menuCadColaboradores.Tag 'é gravado no tag do menu o nível de acesso
        frmBrowse_Colaboradores.Text = menuCadColaboradores.Text
        frmBrowse_Colaboradores.Show()
    End Sub

    Private Sub mnuAssociarConferencia_Click(sender As Object, e As EventArgs) Handles mnuAssociarConferencia.Click
        Dim nCodUsuario As Integer = getCodUsuario(ClassCrypt.Decrypt(g_Login))
        Dim frmBrowse_Membros As frmBrowse = New frmBrowse("QUN000", "frmAssocMembros", IIf(nCodUsuario = 1, "", "inner join EUN013 on UN013_CODUNI=UN000_CODRED"), _
            IIf(nCodUsuario = 1, "", "UN013_CODUSU=" & getCodUsuario(ClassCrypt.Decrypt(g_Login)).ToString & " AND UN013_PERACE > 0"))
        frmBrowse_Membros.MdiParent = Me
        frmBrowse_Membros.Tag = mnuAssociarConferencia.Tag 'é gravado no tag do menu o nível de acesso
        frmBrowse_Membros.Text = mnuAssociarConferencia.Text
        frmBrowse_Membros.Show()
    End Sub

    Private Sub menuMembrosPorConferencia_Click(sender As Object, e As EventArgs) Handles menuMembrosPorConferencia.Click
        Dim frmRelColaborador As frmRelColabUnidades = New frmRelColabUnidades

        frmRelColaborador.MdiParent = Me
        frmRelColaborador.Tag = menuMembrosPorConferencia.Tag 'é gravado no tag do menu o nível de acesso
        frmRelColaborador.Text = menuMembrosPorConferencia.Text
        frmRelColaborador.Show()

    End Sub

    Private Sub menuResumoDoCadastro_Click(sender As Object, e As EventArgs) Handles menuResumoDoCadastro.Click
        Dim frmResumoCad As frmResumoCad = New frmResumoCad

        frmResumoCad.MdiParent = Me
        frmResumoCad.Text = menuResumoDoCadastro.Text
        frmResumoCad.Show()

    End Sub

    Private Sub Sobre_Click(sender As Object, e As EventArgs) Handles Sobre.Click
        Dim frmSobre As frmSobre = New frmSobre

        frmSobre.MdiParent = Me
        frmSobre.Text = Sobre.Text
        frmSobre.Show()
    End Sub

    Private Sub Manual_Click(sender As Object, e As EventArgs) Handles Manual.Click

        Process.Start(Application.ProductName & ".pdf")

    End Sub

    Private Sub mnuSair_Click(sender As Object, e As EventArgs) Handles mnuSair.Click
        Me.Close()
    End Sub
End Class
