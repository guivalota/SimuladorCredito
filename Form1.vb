Public Class Form1
    Dim contadorRecontagem = 0
    Dim taxaTolerancia As Decimal
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtValorEmprestimo.Text = ""
        txtJuros.Text = ""
        txtPrazo.Text = ""
        lblIofFixo.Text = ""
        lblJuros.Text = ""
        lblValorTotal.Text = ""
        lblIofDiario.Text = ""
        txtValorRealNecessiario.Text = ""
        taxaTolerancia = 0
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            Cursor = Cursors.WaitCursor

            Dim valorEmprestimo As Decimal = Decimal.Parse(txtValorEmprestimo.Text)
            Dim taxaJuros = Decimal.Parse(txtJuros.Text) / 100
            Dim prazo As Integer = Integer.Parse(txtPrazo.Text)

            Dim iofFixo = valorEmprestimo * 0.0038
            Dim iofDiario = valorEmprestimo * 0.000082 * prazo
            Dim juros = valorEmprestimo * taxaJuros

            Dim valorInicialRequisitado = valorEmprestimo
            taxaTolerancia = iofFixo + iofDiario
            Dim NvalorEmprestimo = valorEmprestimo + taxaTolerancia
            Dim valorTotal As Decimal = 0
            If ckbIof.Checked Then
                Recalcular(NvalorEmprestimo)
                valorTotal = Decimal.Parse(txtValorEmprestimo.Text) + iofFixo + iofDiario + juros
            Else
                valorTotal = Decimal.Parse(txtValorRealNecessiario.Text) + iofFixo + iofDiario + juros
                lblIofFixo.Text = "IOF Fixo: " & iofFixo.ToString("N2")
                lblIofDiario.Text = "IOF Diário: " & iofDiario.ToString("N2")
                lblJuros.Text = "Juros: " & juros.ToString("N2")
            End If
            txtValorRealNecessiario.Text = txtValorEmprestimo.Text
            txtValorEmprestimo.Text = valorInicialRequisitado.ToString("N2")
            lblValorTotal.Text = "Valor Total: " & valorTotal.ToString("N2")
        Catch ex As Exception
            MessageBox.Show("Erro:" & ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Recalcular(NvalorEmprestimo As Decimal)
        Try
            contadorRecontagem += 1
            txtValorEmprestimo.Text = NvalorEmprestimo.ToString("N2")
            Application.DoEvents()
            Dim valorEmprestimo As Decimal = Decimal.Parse(txtValorEmprestimo.Text)
            Dim taxaJuros = Decimal.Parse(txtJuros.Text) / 100
            Dim prazo As Integer = Integer.Parse(txtPrazo.Text)

            Dim iofFixo = valorEmprestimo * 0.0038
            Dim iofDiario = valorEmprestimo * 0.000082 * prazo
            Dim juros = valorEmprestimo * taxaJuros
            Dim valorTotal = valorEmprestimo + iofFixo + iofDiario + juros
            lblIofFixo.Text = "IOF Fixo: " & iofFixo.ToString("C2")
            lblIofDiario.Text = "IOF Diário: " & iofDiario.ToString("C2")
            lblJuros.Text = "Juros: " & juros.ToString("C2")
            lblValorTotal.Text = "Valor Total: " & valorTotal.ToString("C2")
            Console.WriteLine("Contagem de loops: " & contadorRecontagem)
            If (valorEmprestimo + iofDiario) < (valorEmprestimo + taxaTolerancia) Then
                Exit Sub
            Else
                Recalcular(valorEmprestimo + iofFixo + iofDiario)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro:" & ex.Message)
        End Try
    End Sub
End Class
