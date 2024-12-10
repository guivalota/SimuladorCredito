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
        Me.txtValorEmprestimo = New System.Windows.Forms.TextBox()
        Me.txtTaxaJuros = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.lblBruto12 = New System.Windows.Forms.Label()
        Me.gb12 = New System.Windows.Forms.GroupBox()
        Me.lblValorParcela12 = New System.Windows.Forms.Label()
        Me.lblIoFDiario12 = New System.Windows.Forms.Label()
        Me.gb24 = New System.Windows.Forms.GroupBox()
        Me.lblValorParcela24 = New System.Windows.Forms.Label()
        Me.lblIoFDiario24 = New System.Windows.Forms.Label()
        Me.gb36 = New System.Windows.Forms.GroupBox()
        Me.lblValorParcela36 = New System.Windows.Forms.Label()
        Me.lblIoFDiario36 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIof = New System.Windows.Forms.TextBox()
        Me.lblBruto24 = New System.Windows.Forms.Label()
        Me.lblBruto36 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTarifaIoFFixa = New System.Windows.Forms.TextBox()
        Me.txtTarifaIofDiaria = New System.Windows.Forms.TextBox()
        Me.lblJuros12 = New System.Windows.Forms.Label()
        Me.lblJuros24 = New System.Windows.Forms.Label()
        Me.lblJuros36 = New System.Windows.Forms.Label()
        Me.gb12.SuspendLayout()
        Me.gb24.SuspendLayout()
        Me.gb36.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor do Emprestimo liquido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Taxa de Juros em %"
        '
        'txtValorEmprestimo
        '
        Me.txtValorEmprestimo.Location = New System.Drawing.Point(164, 16)
        Me.txtValorEmprestimo.Name = "txtValorEmprestimo"
        Me.txtValorEmprestimo.Size = New System.Drawing.Size(100, 20)
        Me.txtValorEmprestimo.TabIndex = 3
        Me.txtValorEmprestimo.Text = "80000"
        Me.txtValorEmprestimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTaxaJuros
        '
        Me.txtTaxaJuros.Location = New System.Drawing.Point(164, 42)
        Me.txtTaxaJuros.Name = "txtTaxaJuros"
        Me.txtTaxaJuros.Size = New System.Drawing.Size(100, 20)
        Me.txtTaxaJuros.TabIndex = 4
        Me.txtTaxaJuros.Text = "1,35"
        Me.txtTaxaJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'lblBruto12
        '
        Me.lblBruto12.AutoSize = True
        Me.lblBruto12.Location = New System.Drawing.Point(6, 29)
        Me.lblBruto12.Name = "lblBruto12"
        Me.lblBruto12.Size = New System.Drawing.Size(54, 13)
        Me.lblBruto12.TabIndex = 14
        Me.lblBruto12.Text = "lblBruto12"
        '
        'gb12
        '
        Me.gb12.Controls.Add(Me.lblJuros12)
        Me.gb12.Controls.Add(Me.lblValorParcela12)
        Me.gb12.Controls.Add(Me.lblIoFDiario12)
        Me.gb12.Controls.Add(Me.lblBruto12)
        Me.gb12.Location = New System.Drawing.Point(10, 179)
        Me.gb12.Name = "gb12"
        Me.gb12.Size = New System.Drawing.Size(153, 186)
        Me.gb12.TabIndex = 16
        Me.gb12.TabStop = False
        Me.gb12.Text = "12x"
        Me.gb12.Visible = False
        '
        'lblValorParcela12
        '
        Me.lblValorParcela12.AutoSize = True
        Me.lblValorParcela12.Location = New System.Drawing.Point(1, 152)
        Me.lblValorParcela12.Name = "lblValorParcela12"
        Me.lblValorParcela12.Size = New System.Drawing.Size(89, 13)
        Me.lblValorParcela12.TabIndex = 3
        Me.lblValorParcela12.Text = "lblValorParcela12"
        '
        'lblIoFDiario12
        '
        Me.lblIoFDiario12.AutoSize = True
        Me.lblIoFDiario12.Location = New System.Drawing.Point(6, 94)
        Me.lblIoFDiario12.Name = "lblIoFDiario12"
        Me.lblIoFDiario12.Size = New System.Drawing.Size(71, 13)
        Me.lblIoFDiario12.TabIndex = 1
        Me.lblIoFDiario12.Text = "lblIoFDiario12"
        '
        'gb24
        '
        Me.gb24.Controls.Add(Me.lblJuros24)
        Me.gb24.Controls.Add(Me.lblBruto24)
        Me.gb24.Controls.Add(Me.lblValorParcela24)
        Me.gb24.Controls.Add(Me.lblIoFDiario24)
        Me.gb24.Location = New System.Drawing.Point(174, 179)
        Me.gb24.Name = "gb24"
        Me.gb24.Size = New System.Drawing.Size(153, 186)
        Me.gb24.TabIndex = 17
        Me.gb24.TabStop = False
        Me.gb24.Text = "24x"
        Me.gb24.Visible = False
        '
        'lblValorParcela24
        '
        Me.lblValorParcela24.AutoSize = True
        Me.lblValorParcela24.Location = New System.Drawing.Point(13, 152)
        Me.lblValorParcela24.Name = "lblValorParcela24"
        Me.lblValorParcela24.Size = New System.Drawing.Size(89, 13)
        Me.lblValorParcela24.TabIndex = 4
        Me.lblValorParcela24.Text = "lblValorParcela24"
        '
        'lblIoFDiario24
        '
        Me.lblIoFDiario24.AutoSize = True
        Me.lblIoFDiario24.Location = New System.Drawing.Point(13, 94)
        Me.lblIoFDiario24.Name = "lblIoFDiario24"
        Me.lblIoFDiario24.Size = New System.Drawing.Size(71, 13)
        Me.lblIoFDiario24.TabIndex = 2
        Me.lblIoFDiario24.Text = "lblIoFDiario24"
        '
        'gb36
        '
        Me.gb36.Controls.Add(Me.lblJuros36)
        Me.gb36.Controls.Add(Me.lblBruto36)
        Me.gb36.Controls.Add(Me.lblValorParcela36)
        Me.gb36.Controls.Add(Me.lblIoFDiario36)
        Me.gb36.Location = New System.Drawing.Point(333, 179)
        Me.gb36.Name = "gb36"
        Me.gb36.Size = New System.Drawing.Size(153, 186)
        Me.gb36.TabIndex = 17
        Me.gb36.TabStop = False
        Me.gb36.Text = "36x"
        Me.gb36.Visible = False
        '
        'lblValorParcela36
        '
        Me.lblValorParcela36.AutoSize = True
        Me.lblValorParcela36.Location = New System.Drawing.Point(6, 152)
        Me.lblValorParcela36.Name = "lblValorParcela36"
        Me.lblValorParcela36.Size = New System.Drawing.Size(89, 13)
        Me.lblValorParcela36.TabIndex = 5
        Me.lblValorParcela36.Text = "lblValorParcela36"
        '
        'lblIoFDiario36
        '
        Me.lblIoFDiario36.AutoSize = True
        Me.lblIoFDiario36.Location = New System.Drawing.Point(6, 94)
        Me.lblIoFDiario36.Name = "lblIoFDiario36"
        Me.lblIoFDiario36.Size = New System.Drawing.Size(71, 13)
        Me.lblIoFDiario36.TabIndex = 3
        Me.lblIoFDiario36.Text = "lblIoFDiario36"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "IoF:"
        '
        'txtIof
        '
        Me.txtIof.Location = New System.Drawing.Point(164, 68)
        Me.txtIof.Name = "txtIof"
        Me.txtIof.ReadOnly = True
        Me.txtIof.Size = New System.Drawing.Size(99, 20)
        Me.txtIof.TabIndex = 19
        Me.txtIof.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBruto24
        '
        Me.lblBruto24.AutoSize = True
        Me.lblBruto24.Location = New System.Drawing.Point(13, 29)
        Me.lblBruto24.Name = "lblBruto24"
        Me.lblBruto24.Size = New System.Drawing.Size(54, 13)
        Me.lblBruto24.TabIndex = 5
        Me.lblBruto24.Text = "lblBruto24"
        '
        'lblBruto36
        '
        Me.lblBruto36.AutoSize = True
        Me.lblBruto36.Location = New System.Drawing.Point(6, 29)
        Me.lblBruto36.Name = "lblBruto36"
        Me.lblBruto36.Size = New System.Drawing.Size(54, 13)
        Me.lblBruto36.TabIndex = 6
        Me.lblBruto36.Text = "lblBruto36"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Taria IoF Fixa:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Tarifa IoF Diária:"
        '
        'txtTarifaIoFFixa
        '
        Me.txtTarifaIoFFixa.Location = New System.Drawing.Point(386, 16)
        Me.txtTarifaIoFFixa.Name = "txtTarifaIoFFixa"
        Me.txtTarifaIoFFixa.Size = New System.Drawing.Size(100, 20)
        Me.txtTarifaIoFFixa.TabIndex = 22
        Me.txtTarifaIoFFixa.Text = "0.0038"
        Me.txtTarifaIoFFixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTarifaIofDiaria
        '
        Me.txtTarifaIofDiaria.Location = New System.Drawing.Point(386, 45)
        Me.txtTarifaIofDiaria.Name = "txtTarifaIofDiaria"
        Me.txtTarifaIofDiaria.Size = New System.Drawing.Size(100, 20)
        Me.txtTarifaIofDiaria.TabIndex = 23
        Me.txtTarifaIofDiaria.Text = "0.000082"
        Me.txtTarifaIofDiaria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblJuros12
        '
        Me.lblJuros12.AutoSize = True
        Me.lblJuros12.Location = New System.Drawing.Point(6, 61)
        Me.lblJuros12.Name = "lblJuros12"
        Me.lblJuros12.Size = New System.Drawing.Size(54, 13)
        Me.lblJuros12.TabIndex = 15
        Me.lblJuros12.Text = "lblJuros12"
        '
        'lblJuros24
        '
        Me.lblJuros24.AutoSize = True
        Me.lblJuros24.Location = New System.Drawing.Point(13, 61)
        Me.lblJuros24.Name = "lblJuros24"
        Me.lblJuros24.Size = New System.Drawing.Size(54, 13)
        Me.lblJuros24.TabIndex = 6
        Me.lblJuros24.Text = "lblJuros24"
        '
        'lblJuros36
        '
        Me.lblJuros36.AutoSize = True
        Me.lblJuros36.Location = New System.Drawing.Point(6, 61)
        Me.lblJuros36.Name = "lblJuros36"
        Me.lblJuros36.Size = New System.Drawing.Size(54, 13)
        Me.lblJuros36.TabIndex = 7
        Me.lblJuros36.Text = "lblJuros36"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 377)
        Me.Controls.Add(Me.txtTarifaIofDiaria)
        Me.Controls.Add(Me.txtTarifaIoFFixa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIof)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gb36)
        Me.Controls.Add(Me.gb24)
        Me.Controls.Add(Me.gb12)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtTaxaJuros)
        Me.Controls.Add(Me.txtValorEmprestimo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teste de Simulador"
        Me.gb12.ResumeLayout(False)
        Me.gb12.PerformLayout()
        Me.gb24.ResumeLayout(False)
        Me.gb24.PerformLayout()
        Me.gb36.ResumeLayout(False)
        Me.gb36.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValorEmprestimo As TextBox
    Friend WithEvents txtTaxaJuros As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents lblBruto12 As Label
    Friend WithEvents gb12 As GroupBox
    Friend WithEvents lblIoFDiario12 As Label
    Friend WithEvents gb24 As GroupBox
    Friend WithEvents gb36 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblValorParcela12 As Label
    Friend WithEvents lblValorParcela24 As Label
    Friend WithEvents lblIoFDiario24 As Label
    Friend WithEvents lblValorParcela36 As Label
    Friend WithEvents lblIoFDiario36 As Label
    Friend WithEvents txtIof As TextBox
    Friend WithEvents lblBruto24 As Label
    Friend WithEvents lblBruto36 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTarifaIoFFixa As TextBox
    Friend WithEvents txtTarifaIofDiaria As TextBox
    Friend WithEvents lblJuros12 As Label
    Friend WithEvents lblJuros24 As Label
    Friend WithEvents lblJuros36 As Label
End Class
