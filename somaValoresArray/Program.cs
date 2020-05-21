using System;
using System.IO;

namespace somaValoresArray
{
    class Program
    {
        static void Main(string[] args){

            // string helloWorld = "Ola Mundo";
            // string teste;

            // string a="A", b="a";

            // Console.WriteLine("Verificação tamanho de String");
            // teste = Console.ReadLine();

            // //Verifico o tamanho da String
            // Console.WriteLine(helloWorld.Length);
            // Console.WriteLine(teste.Length);

            // //CompareTo()
            // Console.WriteLine("CompareTo()");
            // Console.WriteLine(a.CompareTo(b));
            
            // if(a.CompareTo(b) == 1){
            //     Console.WriteLine("Maior");
            // }else if(a.CompareTo(b)== -1){
            //     Console.WriteLine("Menor");
            // }else{
            //     Console.WriteLine("Igual");
            // }
            // Console.ReadKey();

            // //Equals()
            // Console.WriteLine("Equals()");
            // Console.WriteLine(a.Equals(b));
            // if(a.Equals(b)){
            //     System.Console.WriteLine("Verdadeiro");
            // }else{
            //     System.Console.WriteLine("Falso");
            // }
            // Console.ReadKey(true);

            // //Contains()
            // Console.WriteLine("Contains()");
            // Console.WriteLine(a.Contains(b));
            // if(a.Contains(b)){
            //     System.Console.WriteLine("Contem {0} dentro de {1}",a,b);
            // }else{
            //     System.Console.WriteLine("Não contem {0} dentro {1}",a,b);
            // }
            // Console.ReadKey(true);
            // System.Console.WriteLine();
            // System.Console.WriteLine();
            // //==
            // Console.WriteLine("==");
            // Console.WriteLine(a == b);
            // Console.ReadKey(true);


            int n, i=12;
            double o = 0.0,d=4.0;
            string s = "HackerRank",t;

            n = Convert.ToInt32(Console.ReadLine());       
        
            o = Convert.ToDouble(Console.ReadLine());

            t = Console.ReadLine();

            Console.WriteLine(n + i);
            Console.WriteLine((o+d).ToString("0.0"));
            Console.WriteLine(s + ""+ t);

        }
    }     
}
