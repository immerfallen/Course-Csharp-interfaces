using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Entities
{
    public class Contrato
    {
        public Contrato(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            Prestacoes = new List<Prestacao>();
        }

        public int Numero { get; set; }

        public DateTime Data { get; set; }

        public double ValorTotal { get; set; }

        public List<Prestacao> Prestacoes { get; set; }

        public void AdicionarPrestacao(Prestacao prestacao)
        {
            Prestacoes.Add(prestacao);
        }

    }

}
