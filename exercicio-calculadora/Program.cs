using System;
using exercicio_calculadora.model;

namespace exercicio_calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            calculadora calc = new calculadora();

            while (true)
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.Write("Escolha uma operação: ");

                int opcao = int.Parse(Console.ReadLine());

                Console.Write("Digite o primeiro número: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double b = double.Parse(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case 1:
                        resultado = calc.Somar(a, b);
                        break;
                    case 2:
                        resultado = calc.Subtrair(a, b);
                        break;
                    case 3:
                        resultado = calc.Multiplicar(a, b);
                        break;
                    case 4:
                        try
                        {
                            resultado = calc.Dividir(a, b);
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Erro: Não é possível dividir por zero.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        continue;
                }

                Console.WriteLine($"Resultado: {resultado}");
                Console.WriteLine();
            }

            Console.WriteLine("Obrigado por usar a calculadora!");
        }
    }
}