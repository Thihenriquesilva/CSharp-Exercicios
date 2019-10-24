using System;

namespace ParmIpar
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            do{

            Console.WriteLine("Par ou Impar");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Digite um número: ");
            double p = double.Parse(Console.ReadLine());
            
            p %=2;
            
            if(p == 0 ){
                System.Console.WriteLine("Par");
            }else{
                System.Console.WriteLine("Impar");
            }

            System.Console.WriteLine("Deseja fazer novamente S/N");
            string opcao = Console.ReadLine();

            if (opcao == "n"){
                sair = true;
            }
            
            }while(!sair);

        }
    }
}
