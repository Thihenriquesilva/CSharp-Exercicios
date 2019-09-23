using System;

namespace datanascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = 0;
            int cal;
            String op = "s";

            while(op == "s" ){

            Console.WriteLine("Diga qual seu ano de nascimento");
            ano =int.Parse(Console.ReadLine());

            cal = (2019 - ano);

            Console.WriteLine("Sua idade é de " + cal + " anos.");

            if(cal <= 2){
            Console.Write("Recém-Nascido");
            Console.WriteLine();
            }
             
            else if( cal <= 11){
            Console.Write("Fraudinha");
            Console.WriteLine();
            }

            else if( cal <= 19){
            Console.Write("Jovem Dinâmico");
            Console.WriteLine();
            }

            else if( cal <= 65){
            Console.Write("Meus pesâmes");
            Console.WriteLine();
            }

            else if( cal >= 65){
            Console.Write("Museu");
            Console.WriteLine();
            }

            Console.WriteLine("    Deseja refazer");
            op = Console.ReadLine();

            }

        }
    }
}
