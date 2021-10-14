using System;

namespace calculadora_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double n1;
            double n2;
            double resultado;
            bool validacao = true;
            Program program = new Program();


            do
            {
                Console.WriteLine("Qual a operacao desejada? ");
                Console.WriteLine("(1) Soma");
                Console.WriteLine("(2) Subtração");
                Console.WriteLine("(3) Multiplicação");
                Console.WriteLine("(4) Divisão");
                Console.WriteLine("(5) Sair");

                Console.WriteLine("Digite a sua opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o primeiro numero: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        resultado = program.Soma(n1, n2);
                        Console.WriteLine("Resultado da soma = {0} ", resultado);

                        break;

                    case 2:
                        Console.WriteLine("Digite o primeiro numero: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        resultado = program.Subtracao(n1, n2);
                        Console.WriteLine("Resultado da subtração = {0} ", resultado);

                        break;

                    case 3:
                        Console.WriteLine("Digite o primeiro numero: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        resultado = program.Multiplicacao(n1, n2);
                        Console.WriteLine("Resultado da multiplicação = {0} ", resultado);

                        break;

                    case 4:
                        Console.WriteLine("Digite o primeiro numero: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        resultado = program.Divisao(n1, n2);
                        Console.WriteLine("Resultado da divisao = {0} ", resultado);

                        break;

                    case 5:
                        validacao = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        Console.Clear();
                        break;
                }

                Console.WriteLine("Aperte ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (validacao); 
        }

        public double Soma(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Subtracao(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Divisao(double n1, double n2)
        {
            return n1 / n2;
        }


    }
}
