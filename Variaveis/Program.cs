using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
         //*Conversões implicita */   	
        // int numero = 1234;
        // decimal numero2 = numero;
        // System.Console.WriteLine($"{numero}");
        // System.Console.WriteLine($"{numero2}");

        // //*Conversões explicitas */
        // double num = 123.4;
        // int num2;
        // num2 = (int)num;
        
        //*Conversão teste */

        int num;
        num = Int32.Parse("123");
 
        System.Console.WriteLine(num.ToString());


        }
    }
}
