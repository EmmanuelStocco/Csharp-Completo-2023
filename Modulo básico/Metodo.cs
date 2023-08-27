using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_básico
{
    public class Metodo
    {
        public static double Soma(double a, double b)
        {
            //tipo de acesso || modificado de instancia || tipo de retorno || nome do metodo (parametros de entrada)
            double resultadoDaSoma = a + b;
            return resultadoDaSoma;
        }

        // ref sinaliza que o parametro de entrada PODE ser modificado pelo metodo
        public static void MultiplicaRef (double a, double b, ref double resultadoOperacao)
        {
            double resultadoDaMultplicacao = a *b;
            resultadoOperacao = resultadoDaMultplicacao;
        }

        // ref sinaliza que o parametro de entrada DEVE ser modificado pelo metodo
        public static void MultiplicaOut(double a, double b, out double resultadoOperacao)
        {
            double resultadoDaMultplicacao = a * b;
            resultadoOperacao = resultadoDaMultplicacao;
        }

        static void Single(string[] args)
        {
            double resultado = Soma(10, 20);
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
