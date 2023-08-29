using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // input and output
namespace Modulo_básico
{
    public class ManipulacaoDeArquivos
    {
        public static void Single()
        {
            // Criando caminhos de arquiv
            //Primeiro método
            string caminho1 = "c:\\teste\\teste.txt";
            //Segundo método
            string caminho2 = @"c:\teste\teste.txt";


            //Criando um arquivo
            FileStream meuArquivo = File.Create(caminho2);
            meuArquivo.Close(); //Tem de fechar após criar para editar o arqv

            //Verificando se um arv existe
            bool arquivoExist = File.Exists(caminho2);
            if(arquivoExist)            
                Console.WriteLine("O arquivo já existe");
             else
                Console.WriteLine("O arquivo ainda não existe");

            // Deletando arquivos 
            File.Delete(caminho2);

            // Renomeando ou movendo arquivos
            string caminho3 = @"c:\teste\teste2.txt";
            string caminho4 = @"c:\teste\teste2update.txt";

            FileStream meuArquivo2 = File.Create(caminho3);
            meuArquivo2.Close();
            File.Move(caminho3, caminho4);


            // Escrevendo em um arquivo de texto
            string caminho5 = @"c:\teste\nomes.txt";
            FileStream meuArquivo3 = File.Create(caminho5);
            meuArquivo3.Close();
            string conteudo = "Emmanuel é bacana \r\n Pedro é um cara maneiro";
            File.WriteAllText(caminho5, conteudo);

            // Escrevendo array de string no arquiv
            string caminho9 = @"c:\teste\nomes2.txt";

            string[] conteudoArray = { "Emmanuel", "Marcos", "Maria", "Julia" };
            File.WriteAllLines(caminho9, conteudoArray);


            //Lendo todo o conteúdo de um arqv
            string conteudoLido = File.ReadAllText(caminho9);
            Console.WriteLine(conteudoLido);

            //Lendo o conteudo de um arqv e gravando em um array de strings
            Console.WriteLine("//////");
            string[] conteudoLidoArray = File.ReadAllLines(caminho9);
            foreach(string nome in conteudoLidoArray)
            {
                Console.WriteLine(nome);
            }
            Console.ReadKey();
        }
    }
}
