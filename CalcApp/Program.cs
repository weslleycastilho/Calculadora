namespace CalcApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Simples");
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Adição"); //  git checkout -b feature/adicao
            Console.WriteLine("2 - Subtração"); // git checkout -b feature/subtracao
            Console.WriteLine("3 - Multiplicação"); // git checkout -b feature/multiplicacao
            Console.WriteLine("4 - Divisão"); // git checkout -b feature/divisao

            if (int.TryParse(Console.ReadLine(), out int opcao) && opcao >= 1 && opcao <= 4)
            {
                Console.Write("Digite o primeiro número: ");
                if (double.TryParse(Console.ReadLine(), out double numero1))
                {
                    Console.Write("Digite o segundo número: ");
                    if (double.TryParse(Console.ReadLine(), out double numero2))
                    {
                        Calculadora calculadora = new Calculadora
                        {
                            Numero1 = numero1,
                            Numero2 = numero2
                        };

                        double resultado = 0;

                        switch (opcao)
                        {
                            case 1:
                                resultado = calculadora.Adicao;
                                break;
                            case 2:
                                resultado = calculadora.Subtracao;
                                break;
                            case 3:
                                resultado = calculadora.Multiplicacao;
                                break;
                            case 4:
                                resultado = calculadora.Divisao;
                                break;
                        }

                        Console.WriteLine($"Resultado: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido. Certifique-se de inserir um número válido.");
                    }
                }
                else
                {
                    Console.WriteLine("Número inválido. Certifique-se de inserir um número válido.");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Escolha uma operação válida (1 a 4).");
            }
        }
    }
}