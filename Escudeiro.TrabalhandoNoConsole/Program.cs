using Escudeiro.TrabalhandoNoConsole.Questoes;
using System;

namespace Escudeiro.TrabalhandoNoConsole
{
    public class Program
    {
        private static Primeira _primeira;
        private static Segunda _segunda;

        public static void Main()
        {
            _primeira = new Primeira();
            _segunda = new Segunda();
            SoliciarAoUsuarioQualQuestaoDeveSerExecutada();
        }

        private static void SoliciarAoUsuarioQualQuestaoDeveSerExecutada(string mensagemDeErroParaUsuario = null)
        {
            var numeroDaQuestao = ObterQualQuestaoDeveSerExecutadaDoUsuario(mensagemDeErroParaUsuario ?? $"Informe um número correspondente a questão que você deseja testar:");

            switch (numeroDaQuestao)
            {
                case 1:
                    _primeira.Processar();
                    break;
                case 2:
                    _segunda.Processar();
                    break;
                case 3:
                    Console.WriteLine($"Questão ainda não implementada. Fechando aplicação.");
                    break;
                case 4:
                    Console.WriteLine($"Questão ainda não implementada. Fechando aplicação.");
                    break;
                case 5:
                    Console.WriteLine($"Questão ainda não implementada. Fechando aplicação.");
                    break;
                case 6:
                    Console.WriteLine($"Questão ainda não implementada. Fechando aplicação.");
                    break;
                case 7:
                    Console.WriteLine($"Questão ainda não implementada. Fechando aplicação.");
                    break;
                case 8:
                    Console.WriteLine($"Questão ainda não implementada. Fechando aplicação.");
                    break;
                case 9:
                    Console.WriteLine($"Questão ainda não implementada. Fechando aplicação.");
                    break;
                case 0:
                    Console.WriteLine($"OK. Fechando aplicação.");
                    break;
                default:
                    Console.WriteLine($"número de questão é inválido.");
                    ObterQualQuestaoDeveSerExecutadaDoUsuario($"Por favor, informe um número correspondente a uma das questões:");
                    break;
            }
        }

        private static int ObterQualQuestaoDeveSerExecutadaDoUsuario(string mensagemDeErroParaUsuario)
        {
            Console.WriteLine(mensagemDeErroParaUsuario);
            Console.WriteLine();
            Console.WriteLine("1 - Crie uma aplicação, que receba os valores A e B. Mostre de forma simples, como utilizar variáveis e manipular dados.");
            Console.WriteLine("2 - Crie uma aplicação que receba nome e salário de N funcionários. Utilize a repetição 'for' e 'while'.");
            Console.WriteLine("3 - Faça uma aplicação que imprima todos os múltiplos de 3, entre 1 e 100. Utilize a repetição 'while'.");
            Console.WriteLine("4 - Faça uma aplicação que receba N alunos com suas respectivas notas. Use 'foreach' para a estrutura de repetição.");
            Console.WriteLine("5 - Crie uma aplicação que calcule a fórmula de Bhaskara.");
            Console.WriteLine("6 - Crie uma aplicação, que demonstre a diferença entre 'REF' e 'OUT'.");
            Console.WriteLine("7 - Faça uma aplicação ler 4 números inteiros e calcular a soma dos que forem pares.");
            Console.WriteLine("8 - Faça uma aplicação ler N valores decimais, imprima os valores em ordem crescente e decrescente.");
            Console.WriteLine("9 - Utilizando a biblioteca 'LINQ' crie no console e execute...");
            Console.WriteLine("0 - Sair da aplicação.");

            var numeroInformado = Console.ReadLine();

            if (!int.TryParse(numeroInformado, out int numeroInformadoValidado))
            {
                Console.WriteLine($"O número informado para é inválido.");
                numeroInformadoValidado = ObterQualQuestaoDeveSerExecutadaDoUsuario($"Por favor, informe um número válido correspondente a uma das questões que você deseja testar:");
            }

            Console.WriteLine();
            return numeroInformadoValidado;
        }
    }
}
