Public Class Form1
    Dim tarifaIofFixa As Decimal = 0.0038
    Dim tarifaIofDiaria As Decimal = 0.000082
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtValorEmprestimo.Text = ""
        txtTaxaJuros.Text = ""
        txtTarifaIoFFixa.Text = 0.0038
        txtTarifaIofDiaria.Text = 0.000082
        txtIof.Text = ""
        gb12.Visible = False
        gb24.Visible = False
        gb36.Visible = False
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            Cursor = Cursors.WaitCursor
            If Not IsNumeric(txtValorEmprestimo.Text) Or Not IsNumeric(txtTaxaJuros.Text) Or
                Not IsNumeric(txtTarifaIoFFixa.Text) Or Not IsNumeric(txtTarifaIofDiaria.Text) Then
                MessageBox.Show("Informe apenas números")
                Exit Sub
            End If
            tarifaIofFixa = txtTarifaIoFFixa.Text.Replace(".", ",")
            tarifaIofDiaria = txtTarifaIofDiaria.Text.Replace(".", ",")
            Dim valorEmprestimo As Decimal = Decimal.Parse(txtValorEmprestimo.Text)
            Dim taxaJuros = Decimal.Parse(txtTaxaJuros.Text) / 100
            txtIof.Text = (valorEmprestimo * tarifaIofFixa).ToString("C")

            lblBruto12.Text = CalcularValorBrutoComIof(valorEmprestimo, tarifaIofFixa, tarifaIofDiaria, 365, taxaJuros)
            lblIoFDiario12.Text = "IoF Diário:" & (valorEmprestimo * tarifaIofDiaria * 365).ToString("C")
            lblValorParcela12.Text = "Parcela:" & (CalcularValorBrutoComIof(valorEmprestimo, tarifaIofFixa, tarifaIofDiaria, 365, taxaJuros) / 12).ToString("C")
            lblJuros12.Text = "Juros:" & (Decimal.Parse(valorEmprestimo) * taxaJuros).ToString("C")
            lblBruto12.Text = "Valor Bruto:" & Decimal.Parse(lblBruto12.Text).ToString("C")
            gb12.Visible = True
            lblBruto24.Text = CalcularValorBrutoComIof(valorEmprestimo, tarifaIofFixa, tarifaIofDiaria, 730, taxaJuros)
            lblIoFDiario24.Text = "IoF Diário:" & (valorEmprestimo * tarifaIofDiaria * 730).ToString("C")
            lblValorParcela24.Text = "Parcela:" & (CalcularValorBrutoComIof(valorEmprestimo, tarifaIofFixa, tarifaIofDiaria, 730, taxaJuros) / 24).ToString("C")
            lblJuros24.Text = "Juros:" & (Decimal.Parse(valorEmprestimo) * taxaJuros).ToString("C")
            lblBruto24.Text = "Valor Bruto:" & Decimal.Parse(lblBruto24.Text).ToString("C")
            gb24.Visible = True
            lblBruto36.Text = CalcularValorBrutoComIof(valorEmprestimo, tarifaIofFixa, tarifaIofDiaria, 1095, taxaJuros)
            lblIoFDiario36.Text = "IoF Diário:" & (valorEmprestimo * tarifaIofDiaria * 1095).ToString("C")
            lblValorParcela36.Text = "Parcela:" & (CalcularValorBrutoComIof(valorEmprestimo, tarifaIofFixa, tarifaIofDiaria, 168, taxaJuros) / 36).ToString("C")
            lblJuros36.Text = "Juros:" & (Decimal.Parse(valorEmprestimo) * taxaJuros).ToString("C")
            lblBruto36.Text = "Valor Bruto:" & Decimal.Parse(lblBruto36.Text).ToString("C")
            gb36.Visible = True
        Catch ex As Exception
            MessageBox.Show("Erro:" & ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub


    Private Function CalcularValorBrutoComIof(valorLiquido As Decimal, taxaIoFFixo As Decimal, taxaIoFDiaria As Decimal, dias As Integer, taxaJuros As Decimal) As Decimal
        Dim taxaTotal As Decimal = taxaIoFFixo + (taxaIoFDiaria * dias) + taxaJuros
        If taxaTotal >= 1 Then
            Throw New ArgumentException("A soma das taxas de IOF não pode ser maior que 1.")
        End If
        Dim valorBruto As Decimal = valorLiquido / (1 - taxaTotal)
        Return valorBruto
    End Function

End Class
