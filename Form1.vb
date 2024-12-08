Public Class Form1
    Dim contadorRecontagem = 2000
    Dim taxaTolerancia As Decimal = 0.001 '10%
    Dim valorInicialRequisitado As Decimal
    Dim valorNecessario As Decimal
    Dim taxaJuros As Decimal = 1
    Dim prazo As Integer
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtValorEmprestimo.Text = ""
        txtJuros.Text = ""
        txtPrazo.Text = ""
        lblIofFixo.Text = ""
        lblJuros.Text = ""
        lblIofDiario.Text = ""
        txtValorRealNecessiario.Text = ""
        taxaTolerancia = 0
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            Cursor = Cursors.WaitCursor

            Dim valorEmprestimo As Decimal = Decimal.Parse(txtValorEmprestimo.Text)
            taxaJuros = Decimal.Parse(txtJuros.Text) / 100
            prazo = Integer.Parse(txtPrazo.Text)

            Dim iofFixo = valorEmprestimo * 0.0038
            Dim iofDiario = valorEmprestimo * 0.000082 * prazo
            Dim juros = valorEmprestimo * taxaJuros
            valorInicialRequisitado = valorEmprestimo
            Dim valorTotal As Decimal = 0
            If ckbIof.Checked Then
                Dim NvalorEmprestimo = valorEmprestimo + iofFixo + iofDiario
                valorNecessario = NvalorEmprestimo
                Recalcular(NvalorEmprestimo)
                NvalorEmprestimo = Decimal.Parse(txtValorRealNecessiario.Text)
                Dim iofFixoReal = NvalorEmprestimo * 0.0038
                Dim iofDiarioReal = NvalorEmprestimo * 0.000082 * prazo
                Dim jurosReal = NvalorEmprestimo * taxaJuros
                lblIofFixoReal.Text = "IOF Fixo Real: " & iofFixoReal.ToString("N2")
                lblIofDiarioReal.Text = "IOF Diário Real: " & iofDiarioReal.ToString("N2")
                lblJurosReal.Text = "Juros Real: " & jurosReal.ToString("N2")
            Else
                valorTotal = Decimal.Parse(txtValorRealNecessiario.Text) + iofFixo + iofDiario + juros
            End If
            lblIofFixo.Text = "IOF Fixo: " & iofFixo.ToString("N2")
            lblIofDiario.Text = "IOF Diário: " & iofDiario.ToString("N2")
            lblJuros.Text = "Juros: " & juros.ToString("N2")
            txtValorEmprestimo.Text = valorInicialRequisitado.ToString("N2")

        Catch ex As Exception
            MessageBox.Show("Erro:" & ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Recalcular(NvalorEmprestimo As Decimal)
        Try
            contadorRecontagem -= 1
            Dim valorTotal = NvalorEmprestimo + (NvalorEmprestimo * 0.0038) + (NvalorEmprestimo * 0.000082 * prazo)
            Console.WriteLine("Contagem de loops: " & contadorRecontagem)
            Console.WriteLine("Valor simulado:" & NvalorEmprestimo)
            If contadorRecontagem > 0 Then
                If Math.Round(NvalorEmprestimo, 2) > Math.Round(valorInicialRequisitado, 2) Then
                    Recalcular(NvalorEmprestimo - 1)
                ElseIf Math.Round(NvalorEmprestimo, 2) < Math.Round(valorInicialRequisitado, 2) Then
                    Recalcular(NvalorEmprestimo + 1)
                Else
                    txtValorRealNecessiario.Text = NvalorEmprestimo.ToString("N2")
                    Exit Sub
                End If
            Else
                txtValorRealNecessiario.Text = NvalorEmprestimo.ToString("N2")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Erro:" & ex.Message)
        End Try
    End Sub
End Class
