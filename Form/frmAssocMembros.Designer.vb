﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssocMembros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssocMembros))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnIncluir = New System.Windows.Forms.ToolStripButton()
        Me.btnAlterar = New System.Windows.Forms.ToolStripButton()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGravar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAnterior = New System.Windows.Forms.ToolStripButton()
        Me.btnProximo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLocalizar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.txtEstruturaUnidade = New System.Windows.Forms.TextBox()
        Me.lblEstruturaUnidade = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.cbTipoCF = New System.Windows.Forms.ComboBox()
        Me.lblTipoCF = New System.Windows.Forms.Label()
        Me.btnPesqMembro = New System.Windows.Forms.Button()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.lstPesqMembro = New System.Windows.Forms.ListBox()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblPesqMembro = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.txtPesqMembro = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblContadorMembro = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.dtgMembroAtivo = New System.Windows.Forms.DataGridView()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssContReg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dtgMembroAtivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnIncluir, Me.btnAlterar, Me.btnExcluir, Me.ToolStripSeparator1, Me.btnGravar, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnAnterior, Me.btnProximo, Me.ToolStripSeparator2, Me.btnLocalizar, Me.btnImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1007, 39)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnIncluir
        '
        Me.btnIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnIncluir.Image = CType(resources.GetObject("btnIncluir.Image"), System.Drawing.Image)
        Me.btnIncluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(36, 36)
        Me.btnIncluir.Text = "Incluir"
        '
        'btnAlterar
        '
        Me.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(36, 36)
        Me.btnAlterar.Text = "Alterar"
        '
        'btnExcluir
        '
        Me.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(36, 36)
        Me.btnExcluir.Text = "Excluir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnGravar
        '
        Me.btnGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(36, 36)
        Me.btnGravar.Text = "Gravar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(36, 36)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'btnAnterior
        '
        Me.btnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(36, 36)
        Me.btnAnterior.Text = "Anterior"
        '
        'btnProximo
        '
        Me.btnProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnProximo.Image = CType(resources.GetObject("btnProximo.Image"), System.Drawing.Image)
        Me.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(36, 36)
        Me.btnProximo.Text = "Próximo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnLocalizar
        '
        Me.btnLocalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLocalizar.Image = CType(resources.GetObject("btnLocalizar.Image"), System.Drawing.Image)
        Me.btnLocalizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(36, 36)
        Me.btnLocalizar.Text = "Localizar"
        '
        'btnImprimir
        '
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(36, 36)
        Me.btnImprimir.Text = "Imprimir"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(-78, 126)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.MaxLength = 11
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(61, 22)
        Me.txtCodigo.TabIndex = 60
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.ForeColor = System.Drawing.Color.Black
        Me.lblCodigo.Location = New System.Drawing.Point(-81, 105)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblCodigo.TabIndex = 59
        Me.lblCodigo.Text = "Código"
        '
        'txtEndereco
        '
        Me.txtEndereco.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEndereco.Location = New System.Drawing.Point(499, 75)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEndereco.MaxLength = 100
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(404, 22)
        Me.txtEndereco.TabIndex = 57
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.ForeColor = System.Drawing.Color.Black
        Me.lblEndereco.Location = New System.Drawing.Point(496, 54)
        Me.lblEndereco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(73, 17)
        Me.lblEndereco.TabIndex = 58
        Me.lblEndereco.Text = "Endereço:"
        '
        'txtEstruturaUnidade
        '
        Me.txtEstruturaUnidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEstruturaUnidade.Location = New System.Drawing.Point(347, 75)
        Me.txtEstruturaUnidade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstruturaUnidade.MaxLength = 11
        Me.txtEstruturaUnidade.Name = "txtEstruturaUnidade"
        Me.txtEstruturaUnidade.Size = New System.Drawing.Size(144, 22)
        Me.txtEstruturaUnidade.TabIndex = 55
        '
        'lblEstruturaUnidade
        '
        Me.lblEstruturaUnidade.AutoSize = True
        Me.lblEstruturaUnidade.Location = New System.Drawing.Point(344, 54)
        Me.lblEstruturaUnidade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstruturaUnidade.Name = "lblEstruturaUnidade"
        Me.lblEstruturaUnidade.Size = New System.Drawing.Size(70, 17)
        Me.lblEstruturaUnidade.TabIndex = 56
        Me.lblEstruturaUnidade.Text = "Estrutura:"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNome.Location = New System.Drawing.Point(16, 75)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(323, 22)
        Me.txtNome.TabIndex = 53
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.ForeColor = System.Drawing.Color.Black
        Me.lblNome.Location = New System.Drawing.Point(13, 54)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(49, 17)
        Me.lblNome.TabIndex = 54
        Me.lblNome.Text = "Nome:"
        '
        'cbTipoCF
        '
        Me.cbTipoCF.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbTipoCF.FormattingEnabled = True
        Me.cbTipoCF.Items.AddRange(New Object() {"Padrão", "CCA", "Rural"})
        Me.cbTipoCF.Location = New System.Drawing.Point(868, 127)
        Me.cbTipoCF.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTipoCF.Name = "cbTipoCF"
        Me.cbTipoCF.Size = New System.Drawing.Size(103, 24)
        Me.cbTipoCF.TabIndex = 75
        '
        'lblTipoCF
        '
        Me.lblTipoCF.AutoSize = True
        Me.lblTipoCF.Location = New System.Drawing.Point(865, 105)
        Me.lblTipoCF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoCF.Name = "lblTipoCF"
        Me.lblTipoCF.Size = New System.Drawing.Size(40, 17)
        Me.lblTipoCF.TabIndex = 76
        Me.lblTipoCF.Text = "Tipo:"
        '
        'btnPesqMembro
        '
        Me.btnPesqMembro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPesqMembro.BackgroundImage = CType(resources.GetObject("btnPesqMembro.BackgroundImage"), System.Drawing.Image)
        Me.btnPesqMembro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPesqMembro.Enabled = False
        Me.btnPesqMembro.Location = New System.Drawing.Point(370, 185)
        Me.btnPesqMembro.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPesqMembro.Name = "btnPesqMembro"
        Me.btnPesqMembro.Size = New System.Drawing.Size(26, 24)
        Me.btnPesqMembro.TabIndex = 74
        Me.btnPesqMembro.UseVisualStyleBackColor = True
        '
        'txtPais
        '
        Me.txtPais.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPais.Location = New System.Drawing.Point(731, 127)
        Me.txtPais.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPais.MaxLength = 40
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(129, 22)
        Me.txtPais.TabIndex = 72
        '
        'lstPesqMembro
        '
        Me.lstPesqMembro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPesqMembro.FormattingEnabled = True
        Me.lstPesqMembro.ItemHeight = 16
        Me.lstPesqMembro.Location = New System.Drawing.Point(17, 216)
        Me.lstPesqMembro.Name = "lstPesqMembro"
        Me.lstPesqMembro.Size = New System.Drawing.Size(373, 244)
        Me.lstPesqMembro.TabIndex = 67
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(728, 105)
        Me.lblPais.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(39, 17)
        Me.lblPais.TabIndex = 73
        Me.lblPais.Text = "País:"
        '
        'lblPesqMembro
        '
        Me.lblPesqMembro.AutoSize = True
        Me.lblPesqMembro.Location = New System.Drawing.Point(16, 165)
        Me.lblPesqMembro.Name = "lblPesqMembro"
        Me.lblPesqMembro.Size = New System.Drawing.Size(236, 17)
        Me.lblPesqMembro.TabIndex = 65
        Me.lblPesqMembro.Text = "Pesquisa do Associado no Cadastro"
        '
        'cbEstado
        '
        Me.cbEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO", "EX"})
        Me.cbEstado.Location = New System.Drawing.Point(644, 127)
        Me.cbEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(75, 24)
        Me.cbEstado.TabIndex = 70
        '
        'txtPesqMembro
        '
        Me.txtPesqMembro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPesqMembro.Enabled = False
        Me.txtPesqMembro.Location = New System.Drawing.Point(17, 186)
        Me.txtPesqMembro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPesqMembro.MaxLength = 80
        Me.txtPesqMembro.Name = "txtPesqMembro"
        Me.txtPesqMembro.Size = New System.Drawing.Size(351, 22)
        Me.txtPesqMembro.TabIndex = 66
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(638, 105)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(56, 17)
        Me.lblEstado.TabIndex = 71
        Me.lblEstado.Text = "Estado:"
        '
        'lblContadorMembro
        '
        Me.lblContadorMembro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblContadorMembro.AutoSize = True
        Me.lblContadorMembro.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContadorMembro.Location = New System.Drawing.Point(404, 165)
        Me.lblContadorMembro.Name = "lblContadorMembro"
        Me.lblContadorMembro.Size = New System.Drawing.Size(211, 17)
        Me.lblContadorMembro.TabIndex = 64
        Me.lblContadorMembro.Text = "Número de Membros Ativos:"
        '
        'txtBairro
        '
        Me.txtBairro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBairro.Location = New System.Drawing.Point(15, 126)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBairro.MaxLength = 60
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(291, 22)
        Me.txtBairro.TabIndex = 68
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.ForeColor = System.Drawing.Color.Black
        Me.lblCidade.Location = New System.Drawing.Point(311, 105)
        Me.lblCidade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(56, 17)
        Me.lblCidade.TabIndex = 69
        Me.lblCidade.Text = "Cidade:"
        '
        'dtgMembroAtivo
        '
        Me.dtgMembroAtivo.AllowUserToAddRows = False
        Me.dtgMembroAtivo.AllowUserToDeleteRows = False
        Me.dtgMembroAtivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgMembroAtivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMembroAtivo.Location = New System.Drawing.Point(407, 186)
        Me.dtgMembroAtivo.Name = "dtgMembroAtivo"
        Me.dtgMembroAtivo.ReadOnly = True
        Me.dtgMembroAtivo.RowTemplate.Height = 24
        Me.dtgMembroAtivo.Size = New System.Drawing.Size(564, 274)
        Me.dtgMembroAtivo.TabIndex = 63
        '
        'txtCidade
        '
        Me.txtCidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCidade.Location = New System.Drawing.Point(314, 127)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCidade.MaxLength = 60
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(322, 22)
        Me.txtCidade.TabIndex = 61
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.ForeColor = System.Drawing.Color.Black
        Me.lblBairro.Location = New System.Drawing.Point(14, 105)
        Me.lblBairro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(50, 17)
        Me.lblBairro.TabIndex = 62
        Me.lblBairro.Text = "Bairro:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssContReg})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 475)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1007, 25)
        Me.StatusStrip1.TabIndex = 77
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssContReg
        '
        Me.tssContReg.Name = "tssContReg"
        Me.tssContReg.Size = New System.Drawing.Size(98, 20)
        Me.tssContReg.Text = "Registro n / n"
        '
        'frmAssocMembros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 500)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cbTipoCF)
        Me.Controls.Add(Me.lblTipoCF)
        Me.Controls.Add(Me.btnPesqMembro)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.lstPesqMembro)
        Me.Controls.Add(Me.lblPais)
        Me.Controls.Add(Me.lblPesqMembro)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.txtPesqMembro)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblContadorMembro)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.lblCidade)
        Me.Controls.Add(Me.dtgMembroAtivo)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.txtEstruturaUnidade)
        Me.Controls.Add(Me.lblEstruturaUnidade)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmAssocMembros"
        Me.Text = "frmAssocMembros"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dtgMembroAtivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnIncluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAlterar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGravar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAnterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnProximo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnLocalizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents txtEstruturaUnidade As System.Windows.Forms.TextBox
    Friend WithEvents lblEstruturaUnidade As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents cbTipoCF As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoCF As System.Windows.Forms.Label
    Friend WithEvents btnPesqMembro As System.Windows.Forms.Button
    Friend WithEvents txtPais As System.Windows.Forms.TextBox
    Friend WithEvents lstPesqMembro As System.Windows.Forms.ListBox
    Friend WithEvents lblPais As System.Windows.Forms.Label
    Friend WithEvents lblPesqMembro As System.Windows.Forms.Label
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents txtPesqMembro As System.Windows.Forms.TextBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblContadorMembro As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents dtgMembroAtivo As System.Windows.Forms.DataGridView
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssContReg As System.Windows.Forms.ToolStripStatusLabel
End Class
