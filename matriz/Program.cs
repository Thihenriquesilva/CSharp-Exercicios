using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lista;

            lista = new string[4];

            lista[0] = "Thiago";
            lista[1] = "Henrique";
            lista[2] = "da";
            lista[3] = "Silva";

            for (int i=0; i<5; i++){
                Console.Write(lista[i]);
                Console.Write("");
            }
            Console.ReadKey();
        }
    }
}
