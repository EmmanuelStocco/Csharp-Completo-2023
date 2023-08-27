using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_básico
{
    public class ProjetoQuinto
    {

        public struct DadosCadastraisStruct
        {
            public string Nome;
            public DateTime DataDeNascimento;
            public string NomeDaRua;
            public UInt32 NumeroDaCasa;
        }
        public enum Resultado_e
        {
            Sucesso = 0,
            Sair = 1,
            Excessao = 2
        }
        public static void MostraMenssagem (string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("Pressione qualquer tecla pra continuar");
            Console.ReadKey();
            Console.Clear();
        }
        
        public static Resultado_e PegaString(ref string minhaString, string mensagem)
        {
            Resultado_e retorno;
            Console.WriteLine(mensagem);

            string temp = Console.ReadLine();
            if(temp == "s" || temp == "S")
            {
                retorno = Resultado_e.Sair;
            } else
            {
                minhaString = temp;
                retorno = Resultado_e.Sucesso;
            }

            Console.Clear();
            return retorno;
        }

        public static Resultado_e PegaData (ref DateTime data, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                    {
                        retorno = Resultado_e.Sair;
                    } else
                    {
                        data = Convert.ToDateTime(temp);
                        retorno = Resultado_e.Sucesso;
                    }
                } catch(Exception e )
                {
                    Console.WriteLine("Excecao: " + e.Message);
                    Console.WriteLine("Precione qualquer tecla para continuar: " + e.Message);
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excessao;

                }
            } while (retorno == Resultado_e.Excessao);
            Console.Clear();
            return retorno;
        }

        public static Resultado_e PegaUint32(ref UInt32 numeroUint32, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                    {
                        retorno = Resultado_e.Sair;
                    }
                    else
                    {
                        numeroUint32 = Convert.ToUInt32(temp);
                        retorno = Resultado_e.Sucesso;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Excecao: " + e.Message);
                    Console.WriteLine("Precione qualquer tecla para continuar: " + e.Message);
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excessao;

                }
            } while (retorno == Resultado_e.Excessao);
            Console.Clear();
            return retorno;
        }

        public static void CadastraUsuario(ref List<DadosCadastraisStruct> ListaDeUsuarios)
        {
            DadosCadastraisStruct cadastroUsuario;
            cadastroUsuario.Nome = "";
            cadastroUsuario.DataDeNascimento= new DateTime();
            cadastroUsuario.NomeDaRua = "";
            cadastroUsuario.NumeroDaCasa = 0;

            if (PegaString(ref cadastroUsuario.Nome, "Digite o nome completo ou S para sair") != Resultado_e.Sucesso)
                return;
            if (PegaData(ref cadastroUsuario.DataDeNascimento, "Digite a data de nascimento no formato DD/MM/AAAA ou S para sair") != Resultado_e.Sucesso)
                return;
            if (PegaString(ref cadastroUsuario.NomeDaRua, "Digite Nome da rua ou S para sair") != Resultado_e.Sucesso)
                return;
            if (PegaUint32(ref cadastroUsuario.NumeroDaCasa, "Digite o numero da casa ou S para sair") != Resultado_e.Sucesso)
                return;
             
            ListaDeUsuarios.Add(cadastroUsuario);
        }

        public static void Single()
        {
           List<DadosCadastraisStruct> ListaDeUsuarios = new List<DadosCadastraisStruct>();
            string opcao = "";
            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuário ou S para sair: ");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower(); //true para a letra não aparecer na tela;
                if (opcao == "c")
                {
                    CadastraUsuario(ref ListaDeUsuarios);
                }
                else if (opcao == "s")
                {
                    MostraMenssagem("Encerrando o programa");
                }
                else
                {
                    MostraMenssagem("Opção Desconhecida");
                }
            } while (opcao != "s");
        }
    }
}
