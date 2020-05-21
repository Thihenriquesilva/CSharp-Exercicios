using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            //Casting: coversao perigosa
            int valor = 1;
            long valorGrande = valor;
            short valorPequeno = (short)valor;

            double pi = 3.14;
            int piQuebrado = (int) pi;

            System.Console.WriteLine("piQuebrado =" + piQuebrado);
        }
    }
}
