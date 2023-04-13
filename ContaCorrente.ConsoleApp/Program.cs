namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.saldo = 1000;
            conta.numero = 12;
            conta.limite = 0;
            conta.ehespecial = true;
            conta.movimentacoes = new Movimentacao[10];


            conta.sacar(200);

            conta.depositar(300);

            conta.depositar(500);

            ContaCorrente conta2 = new ContaCorrente();
            conta2.saldo = 1000;
            conta2.numero = 12;
            conta2.limite = 0;
            conta2.ehespecial = true;
            conta2.movimentacoes = new Movimentacao[10];

            conta.TransferirPara(conta2, 400);

            conta.ExibirExtrato();


            Console.ReadKey();




        }
    }
}