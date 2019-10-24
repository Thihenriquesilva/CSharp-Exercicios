using System;

namespace ConversaoC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão de Celsius (°C)");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Digite a temperatura para conversã:");
            double c = double.Parse(Console.ReadLine());

            double f;

            f = (c * 9)/5 + 32;
            Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine("Conversão para Fahrenheit é " + f);
            System.Console.WriteLine();

        }
    }
}
