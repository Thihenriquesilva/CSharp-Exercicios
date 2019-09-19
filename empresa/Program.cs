using System;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario =0;
            double reajuste = 0;
            
            Console.WriteLine("Qual o seu salário");
            salario = double.Parse(Console.ReadLine());

            if (salario < 500) {
                reajuste = salario * 0.3;

                salario += reajuste;

                Console.WriteLine("Você ganhou um aumento!");
                Console.WriteLine("R$" + salario);
            }
            else {
                Console.WriteLine("Desculpe, sem aumento salarial para você!");
             }
        
        }
    }
}
