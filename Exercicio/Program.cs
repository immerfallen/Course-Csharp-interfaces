using Exercicio.Entities;
using Exercicio.Services;
using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int meses = int.Parse(Console.ReadLine());

            Contrato meuContrato = new Contrato(contractNumber, contractDate, contractValue);

            ServicoContrato contractService = new ServicoContrato(new PaypalServico());
            contractService.ProcessarContrato(meuContrato, meses);

            Console.WriteLine("Installments:");
            foreach (Prestacao prestacao in meuContrato.Prestacoes)
            {
                Console.WriteLine(prestacao);
            }
        }
    }
}
