using System;
using System.Collections.Generic;
using System.Text;

namespace Escudeiro.TrabalhandoNoConsole.Questoes
{
    public class Primeira
    {
        private int a;
        private int b;
        private int valorDaOperacao;

        public void Processar()
        {
            SolicitarAoUsuarioParaInformarOsValoresDeAeDeB();
            SoliciarAoUsuarioQualOperacaoDesejaFazer();
        }

        protected void SolicitarAoUsuarioParaInformarOsValoresDeAeDeB()
        {
            a = 0;
            ObterValorDoUsuario("A", out a);
            ValorDeEntradaEhPar(a);

            b = 0;
            ObterValorDoUsuario("B", out b);
            ValorDeEntradaEhPar(b);
        }

        protected void SoliciarAoUsuarioQualOperacaoDesejaFazer(string mensagemDeRequisicaoParaUsuario = null)
        {
            Console.WriteLine(mensagemDeRequisicaoParaUsuario ?? "Informe um número correspondente a operação desejada:");
            Console.WriteLine();
            Console.WriteLine("1 - Somar esses 2 valores");
            Console.WriteLine("2 - Fazer uma subtração do valor A - B");
            Console.WriteLine("3 - Dividir o valor de B por A");
            Console.WriteLine("4 - Multiplicar o valor de A por B");
            Console.WriteLine("5 - Informar novos valores para A e B");
            Console.WriteLine("6 - Sair da aplicação");

            var valor = Console.ReadLine();
            valorDaOperacao = 0;

            if (!int.TryParse(valor, out valorDaOperacao))
            {
                Console.WriteLine($"número de operação é inválido.");
                SoliciarAoUsuarioQualOperacaoDesejaFazer($"Por favor, informe um número correspondente a uma operação válida:");
            }
            else
            {
                switch (valorDaOperacao)
                {
                    case 1:
                        SoliciarAoUsuarioQualOperacaoDesejaFazer(Somar());
                        break;
                    case 2:
                        SoliciarAoUsuarioQualOperacaoDesejaFazer(Subtrair());
                        break;
                    case 3:
                        SoliciarAoUsuarioQualOperacaoDesejaFazer(Dividir());
                        break;
                    case 4:
                        SoliciarAoUsuarioQualOperacaoDesejaFazer(Multiplicar());
                        break;
                    case 5:
                        Processar();
                        break;
                    case 6:
                        Console.WriteLine("OK. Tchau");
                        break;
                    default:
                        Console.WriteLine("número de operação é inválido.");
                        SoliciarAoUsuarioQualOperacaoDesejaFazer($"Por favor, informe um número correspondente a uma operação válida:");
                        break;
                }
            }
        }

        private void ObterValorDoUsuario(string nomeDoCampoDeEntrada, out int valorDeEntrada, string mensagemDeErroParaUsuario = null)
        {
            Console.WriteLine(mensagemDeErroParaUsuario ?? $"Informe o valor de {nomeDoCampoDeEntrada}:");
            var valor = Console.ReadLine();

            if (!int.TryParse(valor, out valorDeEntrada))
            {
                Console.WriteLine($"O valor informado para {nomeDoCampoDeEntrada} é inválido.");
                ObterValorDoUsuario(nomeDoCampoDeEntrada, out valorDeEntrada, $"Por favor, informe um valor válido para {nomeDoCampoDeEntrada}:");
            }
        }

        private void ValorDeEntradaEhPar(int valorDeEntrada)
        {
            var ehPar = (valorDeEntrada % 2) == 0;
            var mensagemImparPar = ehPar ? "par" : "impar";

            Console.WriteLine();
            Console.WriteLine($"O valor {valorDeEntrada} é {mensagemImparPar}");
            Console.WriteLine();
        }

        private string Somar()
        {
            var resultado = a + b;
            return $"Resultado da operação: A + B = {resultado}. Caso deseja, informe um novo número correspondente a operação desejada:";

        }

        private string Subtrair()
        {
            var resultado = a - b;
            return $"Resultado da operação: A - B = {resultado}. Caso deseja, informe um novo número correspondente a operação desejada:";
        }

        private string Dividir()
        {
            try
            {
                var resultado = b / a;
                return $"Resultado da operação: B / A = {resultado}. Caso deseja, informe um novo número correspondente a operação desejada:";
            }
            catch
            {
                return "Valores informados para esta operação são inválidos. Por favor, informe novos valores para A e B para realizar esta operação:";
            }
        }

        private string Multiplicar()
        {
            var resultado = a * b;
            return $"Resultado da operação: A * B = {resultado}. Caso deseja, informe um novo número correspondente a operação desejada:";
        }
    }
}
