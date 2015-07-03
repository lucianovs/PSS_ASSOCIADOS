Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class frmMembros
    '?? Alterar para a Entidade Principal ??
    Dim dtCadastro As DataTable = New DataTable("EUN000")

    Dim i As Integer
    Dim bAlterar As Boolean = False
    Dim bIncluir As Boolean = False
    Dim cQueryCadastro As String
    Dim nCodUsuario As Integer
    Dim nPermissao As Integer

    Private Sub frmUnidades_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        g_Param(1) = txtCodigo.Text 'Voltar com a Chave do registro do formulário
        g_AtuBrowse = True
    End Sub

    Private Sub frmUnidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nCodUsuario = getCodUsuario(ClassCrypt.Decrypt(g_Login))

        'Carregar a permissão do usuário
        cQueryCadastro = "Select UN013_PERACE FROM EUN013 where EUN013.UN013_CODUSU=" & _
            getCodUsuario(ClassCrypt.Decrypt(g_Login)).ToString & " AND UN013_CODUNI = " & g_Param(1)

        Using da As New OleDbDataAdapter()
            da.SelectCommand = New OleDbCommand(cQueryCadastro, g_ConnectBanco)

            ' Preencher o DataTable 
            da.Fill(dtCadastro)
        End Using
        If dtCadastro.Rows.Count() > 0 Then
            nPermissao = dtCadastro.Rows(0).Item("UN013_PERACE")
        Else
            If UCase(ClassCrypt.Decrypt(g_Login)) = "ADMIN" Then
                nPermissao = 3
            Else
                nPermissao = 0
            End If
        End If
        dtCadastro.Clear()

        'Criar um adaptador que vai fazer o download de dados da base de dados
        cQueryCadastro = "SELECT * FROM EUN000 where "
        cQueryCadastro += " UN000_CODRED = " & g_Param(1)
        MsgBox(cQueryCadastro)

        Using da As New OleDbDataAdapter()
            da.SelectCommand = New OleDbCommand(cQueryCadastro, g_ConnectBanco)

            ' Preencher o DataTable 
            da.Fill(dtCadastro)
        End Using
        i = 0

        'Iniciar com o comando passado
        If g_Comando = "alterar" Or g_Comando = "incluir" Then
            bIncluir = False
            bAlterar = True
        Else
            bIncluir = False
            bAlterar = False
        End If

        TratarObjetos()

    End Sub

    Private Sub TratarObjetos()
        tssContReg.Text = "Registro " & (i + 1).ToString & "/" & dtCadastro.Rows.Count().ToString

        MsgBox("TrataObjetos")
        'Botoes da Barra de comandos
        btnIncluir.Enabled = False 'Not bAlterar And Me.Tag = 4 'And Me.Tag > 1
        btnAlterar.Enabled = Not bAlterar And nPermissao > 1 'Me.Tag > 1
        btnExcluir.Enabled = False
        btnGravar.Enabled = bAlterar
        btnCancelar.Enabled = bAlterar
        btnAnterior.Enabled = False 'Not bAlterar
        btnProximo.Enabled = False 'Not bAlterar
        btnLocalizar.Enabled = Not bAlterar
        btnImprimir.Enabled = Not bAlterar

        'Campos
        '?? Alterar para os seus objetos da Tela ??
        lblCodigo.Enabled = False
        lblBairro.Enabled = False
        lblCidade.Enabled = False
        lblEndereco.Enabled = False
        lblEstado.Enabled = False
        lblEstruturaUnidade.Enabled = False
        lblNome.Enabled = False
        lblPais.Enabled = False
        lblTipoCF.Enabled = False
        txtBairro.Enabled = False
        txtCidade.Enabled = False
        txtCodigo.Enabled = False
        txtEndereco.Enabled = False
        txtEstruturaUnidade.Enabled = False
        txtNome.Enabled = False
        txtPais.Enabled = False
        cbEstado.Enabled = False
        cbTipoCF.Enabled = False

        'Membros Ativos
        txtPesqMembro.Enabled = bAlterar And nPermissao > 1
        lstPesqMembro.Enabled = bAlterar And nPermissao > 1
        dtgMembroAtivo.Enabled = bAlterar And nPermissao > 1
        btnPesqMembro.Enabled = bAlterar And nPermissao > 1

        'Preencher Campos e Armazenar os dados do formulário para gravar o log
        If i > -1 And Not bIncluir Then
            txtCodigo.Text = IIf(IsDBNull(dtCadastro.Rows(i).Item("UN000_CODRED")), "", dtCadastro.Rows(i).Item("UN000_CODRED").ToString())
            txtEstruturaUnidade.Text = IIf(IsDBNull(dtCadastro.Rows(i).Item("UN000_CLAUNI")), "", dtCadastro.Rows(i).Item("UN000_CLAUNI"))
            txtNome.Text = IIf(IsDBNull(dtCadastro.Rows(i).Item("UN000_NOMUNI")), "", dtCadastro.Rows(i).Item("UN000_NOMUNI"))

            txtEndereco.Text = IIf(IsDBNull(dtCadastro.Rows(i).Item("UN000_ENDUNI")), "", dtCadastro.Rows(i).Item("UN000_ENDUNI"))
            txtBairro.Text = IIf(IsDBNull(dtCadastro.Rows(i).Item("UN000_BAIUNI")), "", dtCadastro.Rows(i).Item("UN000_BAIUNI"))
            txtCidade.Text = IIf(IsDBNull(dtCadastro.Rows(i).Item("UN000_CIDUNI")), "", dtCadastro.Rows(i).Item("UN000_CIDUNI"))
            cbEstado.Text = IIf(IsDBNull(dtCadastro.Rows(i).Item("UN000_ESTUNI")), "", dtCadastro.Rows(i).Item("UN000_ESTUNI"))
            txtPais.Text = IIf(IsDBNull(dtCadastro.Rows(i).Item("UN000_NACUNI")), "", dtCadastro.Rows(i).Item("UN000_NACUNI"))

            If Not IsDBNull(dtCadastro.Rows(i).Item("UN000_TIPOCF")) Then
                If dtCadastro.Rows(i).Item("UN000_TIPOCF") = "C" Then
                    cbTipoCF.Text = "CCA"
                ElseIf dtCadastro.Rows(i).Item("UN000_TIPOCF") = "R" Then
                    cbTipoCF.Text = "Rural"
                Else
                    cbTipoCF.Text = "Padrão"
                End If
            Else
                cbTipoCF.Text = "Padrão"
            End If

            'Carregar os Membros Ativos
            txtPesqMembro.Enabled = bAlterar And Not bIncluir And nPermissao > 1 And Microsoft.VisualBasic.Right(Trim(txtEstruturaUnidade.Text), 2) <> "00"
            lstPesqMembro.Enabled = bAlterar And Not bIncluir And nPermissao > 1 And Microsoft.VisualBasic.Right(Trim(txtEstruturaUnidade.Text), 2) <> "00"
            dtgMembroAtivo.Enabled = bAlterar And Not bIncluir And nPermissao > 1 And Microsoft.VisualBasic.Right(Trim(txtEstruturaUnidade.Text), 2) <> "00"
            btnPesqMembro.Enabled = bAlterar And Not bIncluir And nPermissao > 1 And Microsoft.VisualBasic.Right(Trim(txtEstruturaUnidade.Text), 2) <> "00"

            If Microsoft.VisualBasic.Right(Trim(txtEstruturaUnidade.Text), 2) <> "00" Then
                CarregarGridMembro()
            End If

        End If

    End Sub

    Private Sub btnProximo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProximo.Click

        i += 1
        If Not i = dtCadastro.Rows.Count() Then
            Call TratarObjetos()
        Else
            i = dtCadastro.Rows.Count() - 1
        End If

    End Sub

    Private Sub btnAnterior_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnterior.Click

        i -= 1
        If Not i < 0 Then
            Call TratarObjetos()
        Else
            i = 0
        End If

    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click

        bAlterar = True
        Call TratarObjetos()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        dtCadastro.Clear()
        Me.Close()
    End Sub

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        bAlterar = True
        bIncluir = True
    End Sub

    Private Sub btnGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravar.Click
        dtCadastro.Clear()
        Me.Close()
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        Me.Cursor = Cursors.WaitCursor

        Dim RptPath As String
        Dim rptSelection As String = ""

        rptSelection = "{EUN000.UN000_CODRED} = " & txtCodigo.Text
        rptSelection += " and {EUN003.UN003_SITCOL} <> 'E'"

        RptPath = Application.StartupPath & LerDadosINI(nomeArquivoINI(), "PATH", "Reports", "\Reports\")
        'RptPath = "C:\Fontes\SSVP_Projeto\Report\"
        frmReportViewer.ShowReport("Unidades_RelColaborador.rpt", RptPath, rptSelection)
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub rptFormulario(ByVal sender As Object, ByVal Relatorio As System.Drawing.Printing.PrintPageEventArgs)
        
    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        dtCadastro.Clear() 'Limpar o DataTable

        Me.Close()
    End Sub

    Private Sub btnPesqMembro_Click(sender As Object, e As EventArgs) Handles btnPesqMembro.Click
        Dim nPos As Integer = 99
        Dim nSeq As Integer = 0
        Dim nStart As Integer = 1
        Dim sNome(10) As String
        Dim sItemLista As String
        Dim dtPesquisar As DataTable = New DataTable("EUN003")
        Dim sQuery As String

        If Not Trim(txtPesqMembro.Text) = "" Then
            sQuery = "Select EUN003.UN003_CODCOL, EUN003.UN003_NOMCOL, EUN003.UN003_BAIRRO, " & _
                "EUN003.UN003_CIDADE, EUN003.UN003_SIGEST, EUN003.UN003_DTNASC from EUN003 " & _
                "where EUN003.UN003_SITCOL<>'I' AND EUN003.UN003_CODUNI=0"
            nStart = 1

            lstPesqMembro.Items.Clear()

            Do Until nPos = 0
                nPos = InStr(nStart, txtPesqMembro.Text, " ")
                If nPos > 0 Then
                    sNome(nSeq) = Mid(txtPesqMembro.Text, nStart, nPos - nStart)
                    nStart = nPos + 1
                    nSeq += 1
                Else
                    sNome(nSeq) = Mid(txtPesqMembro.Text, nStart, Len(txtPesqMembro.Text) - nStart + 1)
                End If
            Loop
            'Montar a Condição
            For nPos = 0 To nSeq
                sQuery += " and EUN003.UN003_NOMCOL LIKE '%" & sNome(nPos) & "%'"
            Next nPos
            sQuery += " order by EUN003.UN003_NOMCOL"

            Using da As New OleDbDataAdapter()
                da.SelectCommand = New OleDbCommand(sQuery, g_ConnectBanco)

                ' Preencher o DataTable 
                da.Fill(dtPesquisar)
            End Using

            For nSeq = 0 To dtPesquisar.Rows.Count - 1
                sItemLista = Format(dtPesquisar.Rows(nSeq).Item("UN003_CODCOL"), "000000") & " | "
                sItemLista += IIf(IsDBNull(dtPesquisar.Rows(nSeq).Item("UN003_NOMCOL")), "", dtPesquisar.Rows(nSeq).Item("UN003_NOMCOL"))
                If Not IsDBNull(dtPesquisar.Rows(nSeq).Item("UN003_DTNASC")) Then
                    sItemLista += " | " & Format(dtPesquisar.Rows(nSeq).Item("UN003_DTNASC"), "dd/MM/yy")
                End If
                If Not IsDBNull(dtPesquisar.Rows(nSeq).Item("UN003_SIGEST")) Then
                    sItemLista += " | " & dtPesquisar.Rows(nSeq).Item("UN003_SIGEST")
                End If
                If Not IsDBNull(dtPesquisar.Rows(nSeq).Item("UN003_CIDADE")) Then
                    sItemLista += " | " & dtPesquisar.Rows(nSeq).Item("UN003_CIDADE")
                End If
                If Not IsDBNull(dtPesquisar.Rows(nSeq).Item("UN003_BAIRRO")) Then
                    sItemLista += " | " & dtPesquisar.Rows(nSeq).Item("UN003_BAIRRO")
                End If

                lstPesqMembro.Items.Add(sItemLista)
            Next nSeq

            dtPesquisar.Clear()
        Else
            MsgBox("Digite um nome para pesquisar. Para melhor performance, digitar nome e sobrenome.'")
        End If

    End Sub

    Private Sub lstPesqMembro_DoubleClick(sender As Object, e As EventArgs) Handles lstPesqMembro.DoubleClick

        If lstPesqMembro.SelectedItem.ToString <> "" Then
            'Incluir o Colaborador na Conferência
            Dim cmdMandato As OleDbCommand
            Dim sQuery As String

            sQuery = "UPDATE EUN003 SET UN003_CODUNI=" & txtCodigo.Text
            sQuery += " WHERE UN003_CODCOL=" & Microsoft.VisualBasic.Left(lstPesqMembro.SelectedItem, 6)
            cmdMandato = New OleDbCommand(sQuery, g_ConnectBanco)

            Try
                cmdMandato.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                CarregarGridMembro()
            End Try

            'MsgBox(ListaPesquisa.SelectedItem & " grid: " & dtgMandato.SelectedRows.Item(0).Cells(0).Value)
        End If

    End Sub

    Private Sub CarregarGridMembro()
        Dim dtGridMembro As DataTable = New DataTable("EUN003")
        Dim sQuery As String

        dtgMembroAtivo.DataSource = Nothing

        sQuery = "Select EUN003.UN003_CODCOL, EUN003.UN003_NOMCOL, EUN003.UN003_DTNASC " & _
            "from EUN003 WHERE EUN003.UN003_SITCOL='A' AND EUN003.UN003_CODUNI=" & txtCodigo.Text & _
            " ORDER BY EUN003.UN003_NOMCOL"

        Using da As New OleDbDataAdapter()
            da.SelectCommand = New OleDbCommand(sQuery, g_ConnectBanco)

            ' Preencher o DataTable  
            da.Fill(dtGridMembro)
        End Using

        lblContadorMembro.Text = "Número de Membros Ativos: " & Format(dtGridMembro.Rows.Count, "###0")
        dtgMembroAtivo.DataSource = dtGridMembro
        dtgMembroAtivo.Columns(0).HeaderText = "Cod."
        dtgMembroAtivo.Columns(0).Width = 50
        dtgMembroAtivo.Columns(1).HeaderText = "Nome"
        dtgMembroAtivo.Columns(1).Width = 300
        dtgMembroAtivo.Columns(2).HeaderText = "Dt.Nasc."
        dtgMembroAtivo.Columns(2).Width = 100

    End Sub

    Private Sub dtgMembroAtivo_DoubleClick(sender As Object, e As EventArgs) Handles dtgMembroAtivo.DoubleClick
        Dim sQuery As String

        If dtgMembroAtivo.SelectedRows.Count > 0 Then
            'Preparar o comando para Exluir o Colaborador
            'txtPesqMembro.Text = dtgMembroAtivo.SelectedRows.Item(0).Cells(2).Value
            If IsDBNull(dtgMembroAtivo.SelectedRows.Item(0).Cells(1).Value) Then
                txtPesqMembro.Text = ""
            Else
                txtPesqMembro.Text = dtgMembroAtivo.SelectedRows.Item(0).Cells(1).Value
            End If

            'Comando para retirar o associado
            Dim cmdRetirarMembro As OleDbCommand

            sQuery = "UPDATE EUN003 SET UN003_CODUNI=0"
            sQuery += " WHERE UN003_CODCOL=" & dtgMembroAtivo.SelectedRows.Item(0).Cells(0).Value
            cmdRetirarMembro = New OleDbCommand(sQuery, g_ConnectBanco)

            Try
                cmdRetirarMembro.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                CarregarGridMembro()
            End Try

            txtPesqMembro.Text = ""

        End If

    End Sub

    Private Sub txtNome_LostFocus(sender As Object, e As EventArgs)
        txtNome.Text = UCase(txtNome.Text)
    End Sub

End Class