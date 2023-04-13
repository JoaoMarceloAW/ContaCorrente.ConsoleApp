using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        public double saldo;
        public int numero;
        public double limite;
        public bool ehsepecial;

        public Movimentacao[] movimentacoes;
        

        public void Sacar (double quantia)
        {

            if (quantia < saldo + limite)
            {
                double novosaldo = saldo - quantia;
                 saldo = novosaldo;

                Movimentacao movimentacao = new Movimentacao();
                movimentacao.valor = quantia;
                movimentacao.tipo = "Debito";
                movimentacao.descricao = "Débito de R$" + quantia + "Reais";

                int posicaoVazia = PegaPosicaoVazia();

                movimentacoes[posicaoVazia] = movimentacao;




            }



        }

        public void Depositar(double quantia)
        {

            double novosaldo = saldo + quantia;

            saldo = novosaldo;

            Movimentacao.movimentacao = new Movimentacao();
            movimentacao.valor = quantia;
            movimentacao.tipo = "Crédito";
            movimentacao.descricao = "Crédito de R$" + quantia + "Reais";


            int pocisaoVazia = PegaPocisaoVazia();

            movimentacoes[posicaoVazia] = PegaPosicaoVazia();



        }

        public void TransferirPara (ContaCorrente contaDestino,double quantia)
        {

            this.Sacar(quantia);
            contaDestino.Depositar(quantia);
        }

        public void ExibirExtrato()
        {

            Console.WriteLine("Numero da conta {0}", numero);
            Console.WriteLine("Movimentações :");

            foreach (Movimentacao  movimentacao in movimentacoes)
            {

                Console.WriteLine(movimentacao.);

            }


        }


        public void PegaPosicaoVazia()
        {

        }
    }


}
