Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class frmResumoCad
    Dim dtAssociado As DataTable = New DataTable("EUN003")
    Dim nCodUnidade As Double = 0

    Private Sub frmResumoCad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Call btnAtualizar_Click(Nothing, New System.EventArgs())

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        'cria um novo documento para impressão
        Dim pd As PrintDocument = New PrintDocument()

        'relaciona o objeto pd ao procedimento rptProdutos
        AddHandler pd.PrintPage, AddressOf Me.rptFormulario

        'cria uma nova instância do objeto PrintPreviewDialog()
        Dim objPrintPreview = New PrintPreviewDialog()

        'define algumas propriedades do obejto
        With objPrintPreview
            'indica qual o documento vai ser visualizado
            .Document = pd
            .WindowState = FormWindowState.Maximized
            .PrintPreviewControl.Zoom = 1   'maxima a visualização
            .Text = Me.Text
            'exibe a janela de visualização para o usuário
            .ShowDialog()
        End With

    End Sub

    Private Sub rptFormulario(ByVal sender As Object, ByVal Relatorio As System.Drawing.Printing.PrintPageEventArgs)
        Dim FormControl As Control
        Dim FormListBox As ListBox
        Dim pLinhaList As String

        Dim LinhasPorPagina As Integer
        Dim LinhaAdic As Integer
        Dim posicaoDaLinha As Integer
        Dim y As Integer
        Dim nGapEsq As Integer

        Dim margemEsq As Single = Relatorio.MarginBounds.Left
        Dim margemSup As Single = Relatorio.MarginBounds.Top
        Dim margemDir As Single = Relatorio.MarginBounds.Right
        Dim margemInf As Single = Relatorio.MarginBounds.Bottom

        Dim fonteTitulo As Font
        Dim fonteRodape As Font
        Dim fonteNormal As Font

        fonteTitulo = New Font("Verdana", 15, FontStyle.Bold)
        fonteRodape = New Font("Verdana", 8)
        fonteNormal = New Font("Verdana", 10)

        LinhasPorPagina = Relatorio.MarginBounds.Height / fonteNormal.GetHeight(Relatorio.Graphics) - 10

        margemEsq = 5
        'Imprimir o Cabeçalho
        Relatorio.Graphics.DrawLine(Pens.Black, margemEsq, 40, margemDir, 40)
        Relatorio.Graphics.DrawImage(Image.FromFile("logo.png"), 10, 48)
        Relatorio.Graphics.DrawString(Me.Text, fonteTitulo, Brushes.Blue, margemEsq + 275, 80, New StringFormat())
        Relatorio.Graphics.DrawLine(Pens.Black, margemEsq, 155, margemDir, 155)
        LinhaAdic = 2
        nGapEsq = 250

        For Each FormControl In Me.Controls
            If (TypeOf FormControl Is Label) Then
                posicaoDaLinha = margemSup + (((FormControl.TabIndex * 2) + LinhaAdic) * fonteNormal.GetHeight(Relatorio.Graphics))
                Relatorio.Graphics.DrawString(FormControl.Text, fonteNormal, Brushes.Black, margemEsq, posicaoDaLinha, New StringFormat())
                'nGapEsq = FormControl.Size.Width
            ElseIf (TypeOf FormControl Is TextBox) Or (TypeOf FormControl Is ComboBox) Then
                posicaoDaLinha = margemSup + (((FormControl.TabIndex * 2) + LinhaAdic) * fonteNormal.GetHeight(Relatorio.Graphics))
                Relatorio.Graphics.DrawString(FormControl.Text, fonteNormal, Brushes.Black, margemEsq + nGapEsq, posicaoDaLinha, New StringFormat())
            ElseIf (TypeOf FormControl Is DateTimePicker) Then
                posicaoDaLinha = margemSup + (((FormControl.TabIndex * 2) + LinhaAdic) * fonteNormal.GetHeight(Relatorio.Graphics))
                Relatorio.Graphics.DrawString(FormControl.Text, fonteNormal, Brushes.Black, margemEsq + nGapEsq, posicaoDaLinha, New StringFormat())
            ElseIf (TypeOf FormControl Is ListBox) Then
                FormListBox = FormControl
                posicaoDaLinha = margemSup + (((FormListBox.TabIndex * 2) + LinhaAdic) * fonteNormal.GetHeight(Relatorio.Graphics))
                pLinhaList = ""
                For y = 0 To FormListBox.Items.Count - 1
                    If Trim(FormListBox.Items(y).ToString) = "" Then Exit For
                    pLinhaList += "(" & FormListBox.Items(y).ToString & ") "
                Next
                Relatorio.Graphics.DrawString(pLinhaList, fonteNormal, Brushes.Black, margemEsq + nGapEsq, posicaoDaLinha, New StringFormat())
            End If
        Next

        'imprime o rodape no relatorio
        Relatorio.Graphics.DrawLine(Pens.Black, margemEsq, margemInf, margemDir, margemInf)
        Relatorio.Graphics.DrawString(System.DateTime.Now, fonteRodape, Brushes.Black, margemEsq, margemInf, New StringFormat())
        Relatorio.Graphics.DrawString("Formulário", fonteRodape, Brushes.Black, margemDir - 50, margemInf, New StringFormat())

        Relatorio.HasMorePages = False

    End Sub

    Private Sub btnLocUnidade_Click(sender As Object, e As EventArgs) Handles btnLocUnidade.Click
        'txtColaborador.Text = dlgColaborador.ShowDialog()
        Dim options = New dlgConferencia
        Dim sClasseUnidade, sNomeUnidade As String

        sClasseUnidade = ""
        sNomeUnidade = ""
        ' Did the user click Save?
        If options.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ' Yes, so grab the values you want from the dialog here
            nCodUnidade = CDbl(Microsoft.VisualBasic.Left(options.txtPesquisa.Text, 6))
            sClasseUnidade = LerClasse_Unidade(Microsoft.VisualBasic.Left(options.txtPesquisa.Text, 6), sNomeUnidade)
            txtUnidade.Text = sClasseUnidade & " - " & sNomeUnidade
        End If
    End Sub


    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Dim cQuery, sWhere_CodUnidade As String
        Dim nIdade As Integer

        txtTotalCad.Text = "0"
        txtTotalAtivo.Text = "0"
        txtTotalAssociados.Text = "0"
        txtTotalVincentino.Text = "0"
        txtTotalAspirante.Text = "0"

        txt20anos.Text = "0"
        txtSemData.Text = "0"
        txt2140anos.Text = "0"
        txt4160anos.Text = "0"
        txtMais60anos.Text = "0"

        If Trim(txtUnidade.Text) = "" Then
            nCodUnidade = 0
            sWhere_CodUnidade = ""
        Else
            sWhere_CodUnidade = " and UN003_CODUNI=" & nCodUnidade.ToString
        End If

        'Calcular o total do Cadastro
        cQuery = "SELECT UN003_SITCOL, count(*) as TotalReg FROM EUN003 WHERE UN003_SITCOL<>'E'" & sWhere_CodUnidade
        cQuery += " group by UN003_SITCOL"
        Using da As New OleDbDataAdapter()
            da.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)

            ' Preencher o DataTable 
            da.Fill(dtAssociado)
            If dtAssociado.Rows.Count() > 0 Then
                For x = 0 To dtAssociado.Rows.Count() - 1
                    txtTotalCad.Text = Format(CDbl(txtTotalCad.Text) + dtAssociado.Rows(x).Item("TotalReg"), "###,##0")
                    If dtAssociado.Rows(x).Item("UN003_SITCOL") = "A" Then
                        txtTotalAtivo.Text = Format(CDbl(txtTotalAtivo.Text) + dtAssociado.Rows(x).Item("TotalReg"), "###,##0")
                        txtTotalAssociados.Text = Format(CDbl(txtTotalAssociados.Text) + dtAssociado.Rows(x).Item("TotalReg"), "###,##0")
                    ElseIf dtAssociado.Rows(x).Item("UN003_SITCOL") = "N" Then
                        txtTotalAtivo.Text = Format(CDbl(txtTotalAtivo.Text) + dtAssociado.Rows(x).Item("TotalReg"), "###,##0")
                        txtTotalAspirante.Text = Format(CDbl(txtTotalAspirante.Text) + dtAssociado.Rows(x).Item("TotalReg"), "###,##0")
                    ElseIf dtAssociado.Rows(x).Item("UN003_SITCOL") = "V" Then
                        txtTotalAtivo.Text = Format(CDbl(txtTotalAtivo.Text) + dtAssociado.Rows(x).Item("TotalReg"), "###,##0")
                        txtTotalVincentino.Text = Format(CDbl(txtTotalVincentino.Text) + dtAssociado.Rows(x).Item("TotalReg"), "###,##0")
                    End If
                    Me.Refresh()
                Next
            End If
        End Using
        dtAssociado.Clear()
        '**************

        'Calcular o total por Faixa Etária
        cQuery = "SELECT UN003_DTNASC, count(*) as TotalReg FROM EUN003 WHERE UN003_SITCOL<>'E'" & sWhere_CodUnidade
        cQuery += " group by UN003_DTNASC"
        Using da As New OleDbDataAdapter()
            da.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)

            ' Preencher o DataTable 
            da.Fill(dtAssociado)
            If dtAssociado.Rows.Count() > 0 Then
                For x = 0 To dtAssociado.Rows.Count() - 1
                    If IsDBNull(dtAssociado.Rows(x).Item("UN003_DTNASC")) Then
                        txtSemData.Text = Format(CDbl(txtSemData.Text) + dtAssociado.Rows(x).Item("TotalReg"), "###,##0")
                    ElseIf Not IsDate(dtAssociado.Rows(x).Item("UN003_DTNASC")) Then
                        txtSemData.Text = Format(CDbl(txtSemData.Text) + dtAssociado.Rows(x).Item("TotalReg"), "###,##0")
                    Else
                        'Calcular a IDADE
                        nIdade = DateDiff(DateInterval.Year, dtAssociado.Rows(x).Item("UN003_DTNASC"), Date.Today(), FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1)
                        If nIdade <= 20 Then
                            txt20anos.Text = Format(CDbl(txt20anos.Text) + dtAssociado.Rows(x).Item("TotalReg"), "###,##0")
                        ElseIf nIdade <= 40 Then
                            txt2140anos.Text = Format(CDbl(txt2140anos.Text) + dtAssociado.Rows(x).Item("TotalReg"), "###,##0")
                        ElseIf nIdade <= 60 Then
                            txt4160anos.Text = Format(CDbl(txt4160anos.Text) + dtAssociado.Rows(x).Item("TotalReg"), "###,##0")
                        Else
                            txtMais60anos.Text = Format(CDbl(txtMais60anos.Text) + dtAssociado.Rows(x).Item("TotalReg"), "###,##0")
                        End If

                    End If

                    Me.Refresh()
                Next
            End If
        End Using
        dtAssociado.Clear()
        '**************

    End Sub

End Class