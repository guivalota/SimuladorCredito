<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValorEmprestimo = New System.Windows.Forms.TextBox()
        Me.txtJuros = New System.Windows.Forms.TextBox()
        Me.txtPrazo = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.lblIofFixo = New System.Windows.Forms.Label()
        Me.lblIofDiario = New System.Windows.Forms.Label()
        Me.lblJuros = New System.Windows.Forms.Label()
        Me.txtValorRealNecessiario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ckbIof = New System.Windows.Forms.CheckBox()
        Me.lblIofFixoReal = New System.Windows.Forms.Label()
        Me.lblIofDiarioReal = New System.Windows.Forms.Label()
        Me.lblJurosReal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor do Emprestimo pedido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Taxa de Juros em %"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prazo em Dias:"
        '
        'txtValorEmprestimo
        '
        Me.txtValorEmprestimo.Location = New System.Drawing.Point(174, 36)
        Me.txtValorEmprestimo.Name = "txtValorEmprestimo"
        Me.txtValorEmprestimo.Size = New System.Drawing.Size(100, 20)
        Me.txtValorEmprestimo.TabIndex = 3
        Me.txtValorEmprestimo.Text = "80000"
        '
        'txtJuros
        '
        Me.txtJuros.Location = New System.Drawing.Point(174, 75)
        Me.txtJuros.Name = "txtJuros"
        Me.txtJuros.Size = New System.Drawing.Size(100, 20)
        Me.txtJuros.TabIndex = 4
        Me.txtJuros.Text = "1,35"
        '
        'txtPrazo
        '
        Me.txtPrazo.Location = New System.Drawing.Point(174, 114)
        Me.txtPrazo.Name = "txtPrazo"
        Me.txtPrazo.Size = New System.Drawing.Size(100, 20)
        Me.txtPrazo.TabIndex = 5
        Me.txtPrazo.Text = "365"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(25, 150)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 7
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(190, 150)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpar.TabIndex = 8
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'lblIofFixo
        '
        Me.lblIofFixo.AutoSize = True
        Me.lblIofFixo.Location = New System.Drawing.Point(22, 187)
        Me.lblIofFixo.Name = "lblIofFixo"
        Me.lblIofFixo.Size = New System.Drawing.Size(10, 13)
        Me.lblIofFixo.TabIndex = 9
        Me.lblIofFixo.Text = "-"
        '
        'lblIofDiario
        '
        Me.lblIofDiario.AutoSize = True
        Me.lblIofDiario.Location = New System.Drawing.Point(22, 212)
        Me.lblIofDiario.Name = "lblIofDiario"
        Me.lblIofDiario.Size = New System.Drawing.Size(10, 13)
        Me.lblIofDiario.TabIndex = 10
        Me.lblIofDiario.Text = "-"
        '
        'lblJuros
        '
        Me.lblJuros.AutoSize = True
        Me.lblJuros.Location = New System.Drawing.Point(22, 236)
        Me.lblJuros.Name = "lblJuros"
        Me.lblJuros.Size = New System.Drawing.Size(10, 13)
        Me.lblJuros.TabIndex = 11
        Me.lblJuros.Text = "-"
        '
        'txtValorRealNecessiario
        '
        Me.txtValorRealNecessiario.Location = New System.Drawing.Point(174, 278)
        Me.txtValorRealNecessiario.Name = "txtValorRealNecessiario"
        Me.txtValorRealNecessiario.Size = New System.Drawing.Size(100, 20)
        Me.txtValorRealNecessiario.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Valor emprestimo Necessário:"
        '
        'ckbIof
        '
        Me.ckbIof.AutoSize = True
        Me.ckbIof.Location = New System.Drawing.Point(25, 12)
        Me.ckbIof.Name = "ckbIof"
        Me.ckbIof.Size = New System.Drawing.Size(119, 17)
        Me.ckbIof.TabIndex = 15
        Me.ckbIof.Text = "IOF no emprestimos"
        Me.ckbIof.UseVisualStyleBackColor = True
        '
        'lblIofFixoReal
        '
        Me.lblIofFixoReal.AutoSize = True
        Me.lblIofFixoReal.Location = New System.Drawing.Point(270, 187)
        Me.lblIofFixoReal.Name = "lblIofFixoReal"
        Me.lblIofFixoReal.Size = New System.Drawing.Size(10, 13)
        Me.lblIofFixoReal.TabIndex = 16
        Me.lblIofFixoReal.Text = "-"
        '
        'lblIofDiarioReal
        '
        Me.lblIofDiarioReal.AutoSize = True
        Me.lblIofDiarioReal.Location = New System.Drawing.Point(270, 212)
        Me.lblIofDiarioReal.Name = "lblIofDiarioReal"
        Me.lblIofDiarioReal.Size = New System.Drawing.Size(10, 13)
        Me.lblIofDiarioReal.TabIndex = 17
        Me.lblIofDiarioReal.Text = "-"
        '
        'lblJurosReal
        '
        Me.lblJurosReal.AutoSize = True
        Me.lblJurosReal.Location = New System.Drawing.Point(270, 236)
        Me.lblJurosReal.Name = "lblJurosReal"
        Me.lblJurosReal.Size = New System.Drawing.Size(10, 13)
        Me.lblJurosReal.TabIndex = 18
        Me.lblJurosReal.Text = "-"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 310)
        Me.Controls.Add(Me.lblJurosReal)
        Me.Controls.Add(Me.lblIofDiarioReal)
        Me.Controls.Add(Me.lblIofFixoReal)
        Me.Controls.Add(Me.ckbIof)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtValorRealNecessiario)
        Me.Controls.Add(Me.lblJuros)
        Me.Controls.Add(Me.lblIofDiario)
        Me.Controls.Add(Me.lblIofFixo)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtPrazo)
        Me.Controls.Add(Me.txtJuros)
        Me.Controls.Add(Me.txtValorEmprestimo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teste de Simulador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValorEmprestimo As TextBox
    Friend WithEvents txtJuros As TextBox
    Friend WithEvents txtPrazo As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents lblIofFixo As Label
    Friend WithEvents lblIofDiario As Label
    Friend WithEvents lblJuros As Label
    Friend WithEvents txtValorRealNecessiario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ckbIof As CheckBox
    Friend WithEvents lblIofFixoReal As Label
    Friend WithEvents lblIofDiarioReal As Label
    Friend WithEvents lblJurosReal As Label
End Class
