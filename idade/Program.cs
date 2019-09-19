using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {   int num11 = 0;
            


            Console.WriteLine("Digite sua idade");
            num11 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"{2019} - {num11} = {2019 - num11}");
            Console.WriteLine($"{365} * {num11} = {365 * num11}");
            Console.WriteLine($"{48} * {num11} = {48 * num11}");

        }
    }
}
