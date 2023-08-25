using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_básico
{
    public class Excecao
    {
        public static void Main()
        {
            Console.WriteLine("Digite um numero");
            int i = Convert.ToInt32(Console.ReadLine());

            try
            {
                int resultado = 10 / i;
                Console.WriteLine("resultado");
            }
            catch (DivideByZeroException e) //voce tipa o possivel error
            {
                Console.WriteLine("Exceção: " + e.Message);
            }
            catch (Exception e) // para o caso de exceções genéricas e desconhecidas
            {
                Console.WriteLine("Exceção Genérica: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Pressione qualquer tecla pra sair");
                Console.ReadKey();
            }

            //Criando / forçando uma exceção
            //throw new Exception("Minha primeira exceção");
        }
    }
}
