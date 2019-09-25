using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for(int c = 1; c<=10; c++){
                for(int d =1; d<=10; d++){
                Console.Write($"{c,2} * {d,2} = {c*d,4}");
                }
                 Console.WriteLine();
            }
            
            

        }
    }
}


