using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio.Entities
{
    public class Prestacao
    {
        public Prestacao(DateTime dataPagamento, double valorTotal)
        {
            DataPagamento = dataPagamento;
            ValorTotal = valorTotal;
        }

        public DateTime DataPagamento { get; set; }
        public double ValorTotal { get; set; }

        public override string ToString()
        {
            return DataPagamento.ToString("dd/MM/yyyy")
                + " - "
                + ValorTotal.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
