using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_básico
{
    public class FilaPilha
    {
        public static void Fila()
        {
            Queue<string> FilaDeNomes = new Queue<string>();
            // adicionar elementos
            FilaDeNomes.Enqueue("Emmaunuel");
            FilaDeNomes.Enqueue("Wagnet");
            FilaDeNomes.Enqueue("Bianca");

            //Remover elementos
            string nomeremovido = FilaDeNomes.Dequeue();
            Console.WriteLine(nomeremovido);
            Console.ReadKey();

            //Espiar
            string nomeEspiado = FilaDeNomes.Peek();

        }

        public static void Pilha()
        {
            Stack<string> PilhaDeNomes = new Stack<string>();

            //ADD
            PilhaDeNomes.Push("Emmanuel");
            PilhaDeNomes.Push("Joaquin");
            PilhaDeNomes.Push("Alice");

            //Removendo elementos
            string nomeRemovido2 = PilhaDeNomes.Pop();
            Console.WriteLine(nomeRemovido2);

            //Espirar 
            string nomeEspiado = PilhaDeNomes.Peek();
        }
    }
}
