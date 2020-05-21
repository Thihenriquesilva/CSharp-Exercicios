using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {   double a =0, b =0;
            double total = 0;
            string sinal = "";
            System.Console.WriteLine("Calculadora");
            a = double.Parse(Console.ReadLine());
            sinal = Console.ReadLine();
            b = double.Parse(Console.ReadLine());
            

            switch (sinal)
            {
                case "+":
                    total = Soma(a,b);
                break;
                case "-":
                    total = Subtracao(a,b);
                break;
                case "*":
                    total = Multiplicacao(a,b);
                break;
                case "/":
                    total = Divisao(a,b);
                break;
                case "%":
                    total = Resto(a,b);
                break;
                default:
                    System.Console.WriteLine("';'");
                break;

            }

            System.Console.WriteLine(total);
        
        }

        static double Soma(double num,double num2)
        {
            double total = num + num2;

            return total;
        }

        static double Subtracao(double num, double num2)
        {
            double total = num - num2;

            return total;
        }

        static double Divisao(double num, double num2)
        {
            double total = num / num2;

            return total;
        }

        static double Multiplicacao(double num, double num2)
        {
            double total = num * num2;

            return total;
        }

        static double Resto(double num, double num2)
        {
            double total = num % num2;

            return total;
        }
    }
}
