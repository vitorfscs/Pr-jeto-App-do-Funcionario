using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prójeto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Autenticacao_Usuario a = new Autenticacao_Usuario();
            {
                a.usuario = "TESTE";
                a.senha = "TESTE";

                int tentativas = 0;
                while (tentativas < 3)
                {
                    Console.Write("Digite Seu Usuário para começarmos ");
                    string usuarioDigitado = Console.ReadLine();

                    if (usuarioDigitado == a.usuario)
                    {
                        Console.WriteLine("Usuário Correto, Redirecionando para senha...");
                    }

                    else { Console.WriteLine("Usuário Errado, Tente novamente"); }
                    break;
                }

                while (tentativas < 3)
                {
                    

                    Console.Write("Digite Sua Senha agora ");
                    string senhaDigitada = Console.ReadLine();
                    if (a.senha == Console.ReadLine()) { Console.WriteLine("Senha Corretá, Redirecionando para o menu principal..."); }
                    else { Console.WriteLine("Senha incorreta, tente novamente!"); }
                    break;
                }
            }

            opcoes_paraentrar o = new opcoes_paraentrar();
            {
                o.opcao1 = 1;
                o.opcao3 = 2;
                o.opcao3 = 3;

                string opcoes;
                opcoes = ("1") + ("2") + ("3");

                Console.WriteLine("Escolha As Opções abaixo:");
                Console.Write("O1: Matricula "); Console.Write("O2: Função "); Console.WriteLine("O3: Lotação");

                opcoes = Console.ReadLine();


                if (opcoes == Console.ReadLine())
                {
                    
                    if (opcoes == "1") { Console.WriteLine("Sua matricula é " + a.matricula); }
                    if (opcoes == "2") { Console.WriteLine("Sua Função na empresa é " + a.matricula); }
                    if (opcoes == "3") { Console.WriteLine("Sua Lotação atual é " + a.matricula); }

                }
            }


            Console.ReadLine();
            Console.ReadKey();
        }
        
        }
    }
