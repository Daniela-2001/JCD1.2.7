namespace JCD1._2._7
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha a operação(+, -, *, /) : ");
            char operador = Console.ReadKey().KeyChar;

            double resultado = Calcular(numero1, numero2, operador);

            Console.WriteLine($"\nO resultado da operação é:{resultado}");
        }

        static double Calcular(double num1, double num2, char operador)
        {
            double resultado = 0;

            switch (operador)
            { 
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    //Verificar divisão por zero
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("\nErro: Divisão por zero.");
                    }
                    break;
                default:
                    Console.WriteLine("\nErro: Operador inválido.");
                    break;
            }
            return resultado;
        }
    }
}

