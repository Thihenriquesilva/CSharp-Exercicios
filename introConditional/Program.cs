using System;

namespace introConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            //contagem até 1000 com for 
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
            
            //contagem até 100 com while
            int ina = 0;
            while(ina < 100){
                ina +=1;
                Console.Write(" " + ina + ";");
            }


            System.Console.WriteLine();
            System.Console.WriteLine();
            int numero;
            for (numero = 0; numero < 100; numero++)
            {
                if(numero % 3 == 0)
                {
                    System.Console.Write(" " + numero + ";");
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine();
            int numero2 =0;
            while(numero2 <=30)
            {
                    numero2++;
                    if(numero2 % 3 ==0 || numero2 % 4 ==0)
                    {
                        System.Console.Write("" + numero2 + ";");
                    }
            }

            System.Console.WriteLine();
            System.Console.WriteLine();

            for (int v = 1; v < 10; v++)
            {
                for (int c = 1; c < 5; c++)                {
                {
                    System.Console.WriteLine(v + "*" +c+"="+(v * c));
                }    
            }
        }
    }
    }
}
