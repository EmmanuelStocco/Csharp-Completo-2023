using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Modulo_básico
{
    public class ManipulacaoDeArquivo2
    {
        public static void Single()
        {
            //Add Novos textos a um arqv com texto incicial
            string caminhoArquivo = "c:\\test\\test.txt";
            string caminhoArquivo2 = "c:\\test\\test2.txt";

            string texto1 = "João subiu no telhado. \r\n";
            string texto2 = "Luana brigou com ele. \r\n";

            //forma1 => não ideal
            string conteudoInicial = File.ReadAllText(caminhoArquivo);
            string conteudoFinal = conteudoInicial + texto1 + texto2;
            File.WriteAllText(caminhoArquivo, conteudoFinal);

            //forma2 => ideal
            File.AppendAllText(caminhoArquivo2, texto1+texto2);
        }


    }
}
