<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumoCad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResumoCad))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalCad = New System.Windows.Forms.TextBox()
        Me.txtTotalAtivo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalAspirante = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalVincentino = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalAssociados = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSemData = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt20anos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt2140anos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt4160anos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMais60anos = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUnidade = New System.Windows.Forms.TextBox()
        Me.lblUnidades = New System.Windows.Forms.Label()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnLocUnidade = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total de Associados Cadastrados:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CADASTRO"
        '
        'txtTotalCad
        '
        Me.txtTotalCad.Location = New System.Drawing.Point(242, 90)
        Me.txtTotalCad.Name = "txtTotalCad"
        Me.txtTotalCad.Size = New System.Drawing.Size(71, 22)
        Me.txtTotalCad.TabIndex = 2
        Me.txtTotalCad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalAtivo
        '
        Me.txtTotalAtivo.Location = New System.Drawing.Point(242, 121)
        Me.txtTotalAtivo.Name = "txtTotalAtivo"
        Me.txtTotalAtivo.Size = New System.Drawing.Size(71, 22)
        Me.txtTotalAtivo.TabIndex = 3
        Me.txtTotalAtivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total Ativo:"
        '
        'txtTotalAspirante
        '
        Me.txtTotalAspirante.Location = New System.Drawing.Point(242, 151)
        Me.txtTotalAspirante.Name = "txtTotalAspirante"
        Me.txtTotalAspirante.Size = New System.Drawing.Size(71, 22)
        Me.txtTotalAspirante.TabIndex = 4
        Me.txtTotalAspirante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Aspirantes:"
        '
        'txtTotalVincentino
        '
        Me.txtTotalVincentino.Location = New System.Drawing.Point(241, 183)
        Me.txtTotalVincentino.Name = "txtTotalVincentino"
        Me.txtTotalVincentino.Size = New System.Drawing.Size(71, 22)
        Me.txtTotalVincentino.TabIndex = 5
        Me.txtTotalVincentino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Vincentinos:"
        '
        'txtTotalAssociados
        '
        Me.txtTotalAssociados.Location = New System.Drawing.Point(241, 219)
        Me.txtTotalAssociados.Name = "txtTotalAssociados"
        Me.txtTotalAssociados.Size = New System.Drawing.Size(71, 22)
        Me.txtTotalAssociados.TabIndex = 6
        Me.txtTotalAssociados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Associados:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(419, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "FAIXA ETÁRIA"
        '
        'txtSemData
        '
        Me.txtSemData.Location = New System.Drawing.Point(560, 90)
        Me.txtSemData.Name = "txtSemData"
        Me.txtSemData.Size = New System.Drawing.Size(71, 22)
        Me.txtSemData.TabIndex = 8
        Me.txtSemData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(330, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Sem Data Cadastrada:"
        '
        'txt20anos
        '
        Me.txt20anos.Location = New System.Drawing.Point(560, 123)
        Me.txt20anos.Name = "txt20anos"
        Me.txt20anos.Size = New System.Drawing.Size(71, 22)
        Me.txt20anos.TabIndex = 9
        Me.txt20anos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(330, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Até 20 anos"
        '
        'txt2140anos
        '
        Me.txt2140anos.Location = New System.Drawing.Point(560, 153)
        Me.txt2140anos.Name = "txt2140anos"
        Me.txt2140anos.Size = New System.Drawing.Size(71, 22)
        Me.txt2140anos.TabIndex = 10
        Me.txt2140anos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(330, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "De 21 até 40 anos"
        '
        'txt4160anos
        '
        Me.txt4160anos.Location = New System.Drawing.Point(560, 185)
        Me.txt4160anos.Name = "txt4160anos"
        Me.txt4160anos.Size = New System.Drawing.Size(71, 22)
        Me.txt4160anos.TabIndex = 11
        Me.txt4160anos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(330, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "De 41 até 60 anos"
        '
        'txtMais60anos
        '
        Me.txtMais60anos.Location = New System.Drawing.Point(560, 221)
        Me.txtMais60anos.Name = "txtMais60anos"
        Me.txtMais60anos.Size = New System.Drawing.Size(71, 22)
        Me.txtMais60anos.TabIndex = 12
        Me.txtMais60anos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(330, 224)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 17)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Acima de 60"
        '
        'txtUnidade
        '
        Me.txtUnidade.Location = New System.Drawing.Point(100, 16)
        Me.txtUnidade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnidade.MaxLength = 60
        Me.txtUnidade.Name = "txtUnidade"
        Me.txtUnidade.Size = New System.Drawing.Size(504, 22)
        Me.txtUnidade.TabIndex = 0
        '
        'lblUnidades
        '
        Me.lblUnidades.AutoSize = True
        Me.lblUnidades.ForeColor = System.Drawing.Color.Black
        Me.lblUnidades.Location = New System.Drawing.Point(12, 19)
        Me.lblUnidades.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnidades.Name = "lblUnidades"
        Me.lblUnidades.Size = New System.Drawing.Size(88, 17)
        Me.lblUnidades.TabIndex = 0
        Me.lblUnidades.Text = "Conferência:"
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtualizar.Image = Global.ASSOCIADOS.My.Resources.Resources.cmd_Voltar
        Me.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAtualizar.Location = New System.Drawing.Point(259, 250)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(79, 68)
        Me.btnAtualizar.TabIndex = 48
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'btnLocUnidade
        '
        Me.btnLocUnidade.BackgroundImage = Global.ASSOCIADOS.My.Resources.Resources.AllDay_ru_Search
        Me.btnLocUnidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLocUnidade.Location = New System.Drawing.Point(603, 16)
        Me.btnLocUnidade.Name = "btnLocUnidade"
        Me.btnLocUnidade.Size = New System.Drawing.Size(28, 22)
        Me.btnLocUnidade.TabIndex = 46
        Me.btnLocUnidade.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(361, 249)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(79, 69)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'frmResumoCad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 331)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.txtUnidade)
        Me.Controls.Add(Me.btnLocUnidade)
        Me.Controls.Add(Me.lblUnidades)
        Me.Controls.Add(Me.txtMais60anos)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt4160anos)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt2140anos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt20anos)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSemData)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtTotalAssociados)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalVincentino)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotalAspirante)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalAtivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotalCad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmResumoCad"
        Me.Text = "Resumo do Cadastro de Associados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCad As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAtivo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAspirante As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotalVincentino As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAssociados As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSemData As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt20anos As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt2140anos As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt4160anos As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMais60anos As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtUnidade As System.Windows.Forms.TextBox
    Friend WithEvents btnLocUnidade As System.Windows.Forms.Button
    Friend WithEvents lblUnidades As System.Windows.Forms.Label
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
End Class
