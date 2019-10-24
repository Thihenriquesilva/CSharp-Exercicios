using System;

namespace TrocaValores
{
    class Program
    {
        static void Main(string[] args)
        { 
            bool sair = false;
            do {

                Console.WriteLine("HEHEHEH");
                System.Console.WriteLine("Digite um valor qualquer para A");
                double a = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Digite um outro valor qualquer para B");
                double b = double.Parse(Console.ReadLine());

                System.Console.WriteLine("O valor de A é: " + b);
                System.Console.WriteLine("O valor de B é: " + a);

                System.Console.WriteLine("Deseja fazer novamente S/N");
                string opcao = Console.ReadLine();
                
                
                if(opcao == "n"){
                    sair = true;
                }
            
            }while(!sair);
        }
    }
}
