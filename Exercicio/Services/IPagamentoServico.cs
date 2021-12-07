namespace Exercicio.Services
{
    public interface IPagamentoServico
    {

        public double TaxaPagamento(double valorTotal);

        public double Juros(double valorTotal, int meses);
    }
}
