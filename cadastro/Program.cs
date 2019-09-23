using System;

namespace cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            String login = "Teste";
            String senha = "teste";

            Console.WriteLine("Login:");
            login = Console.ReadLine();

            Console.WriteLine("Senha:");
            senha = Console.ReadLine();


            if((login == "Teste") && (senha == "teste")){

                Console.WriteLine("Olá Administrador");

            }

            else {
                Console.WriteLine("Olá estranho");
            }




        }
    }
}
