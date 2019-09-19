using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            double  num1, num2, num3, num4 = 0;
            double media = 0;

            Console.WriteLine("Digite a primeira nota");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota");
            num4 = double.Parse(Console.ReadLine());

            media = (num1 + num2 + num3 + num4) /4;

            Console.WriteLine("Resultado =" + media);


            if (media >= 7.0){
                Console.WriteLine("Good");
            }

            else if (media < 7.0){
                Console.WriteLine("HAHAHAHAHA até ano que vem");
            }
        }

        
    }
}
