using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Services
{
    class PaypalServico : IPagamentoServico
    {

        private const double PercentagemPagamento = 0.02;
        private const double JurosMensais = 0.01;
        public double Juros(double valorTotal, int meses)
        {
            return valorTotal*JurosMensais*meses;
        }

        public double TaxaPagamento(double valorTotal)
        {
            return valorTotal*PercentagemPagamento;
        }
    }
}
