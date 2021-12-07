using Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Services
{
    public class ServicoContrato
    {
        private IPagamentoServico _pagamentoServico;

        public ServicoContrato(IPagamentoServico pagamentoServico)
        {
            _pagamentoServico = pagamentoServico;
        }

        public void ProcessarContrato(Contrato contrato, int meses)
        {
            double valorBase = contrato.ValorTotal / meses;
            for(int i = 1; i < meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double atualizarValorBase = valorBase + _pagamentoServico.Juros(valorBase, i);
                double valorBaseTotal = atualizarValorBase + _pagamentoServico.TaxaPagamento(atualizarValorBase);
                contrato.AdicionarPrestacao(new Prestacao(data, valorBaseTotal));
            }
        }
    }
}
