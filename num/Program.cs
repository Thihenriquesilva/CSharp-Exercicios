using System;

namespace num
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 0;

        
        do{
            Console.WriteLine("Digite um numero");
            p = int.Parse(Console.ReadLine());

            if(p != 0)
            {
                if(p % 2 == 0){
                    Console.WriteLine("Este número é par!");

                }
                else{
                    Console.WriteLine("Este número é impar!");
                }
            }
        }while(p != 0);
        }
    }
}
