using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_básico
{
    public class Delegados
    {
        public delegate double MeuDelegateOperacoes(double a, double b); //todos os metodos dentro do delegate terão essa saida e essa entrada
        public static double Soma (double a, double b)
        {
            double resultadoSoma = a + b;
            Console.WriteLine("A soma da " + resultadoSoma);
            return resultadoSoma;
        }
        public static double Multiplicacao(double a, double b)
        {
            double resultadoMultiplicacao = a * b;
            Console.WriteLine("A Multiplicacao da " + resultadoMultiplicacao);
            return resultadoMultiplicacao;
        }
        public static double Divisao(double a, double b)
        {
            double resultadoDivisao = a / b;
            Console.WriteLine("A Divisao da " + resultadoDivisao);
            return resultadoDivisao;
        }

        // Passando delegate por parametro
        public static void ExecutaOperacao(MeuDelegateOperacoes minhasOperacoes)
        {
            Console.WriteLine("Executando método de parametro de entrada");
            minhasOperacoes(50, 20);
        }

        public static void Single()
        {
            MeuDelegateOperacoes minhasOperacoes;
            minhasOperacoes = Soma;
            Console.WriteLine("------------------------------------");

            minhasOperacoes += Multiplicacao;
            Console.WriteLine("------------------------------------");

            minhasOperacoes += Divisao;

            double resultadoDelegate = minhasOperacoes(5, 10);

            ExecutaOperacao(Multiplicacao);
            Console.WriteLine("o resultado delegate é: " + resultadoDelegate);
            Console.ReadKey();
        }
    }
}
