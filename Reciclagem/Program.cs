using System;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {   Garrafa garrafa = new Garrafa();
            GarrafaPet garrafapet = new GarrafaPet();
            
            
            string menualt = "................................";

            System.Console.WriteLine(menualt);
            System.Console.WriteLine("   RECICLAGEM   ");
            System.Console.WriteLine("Lista da minha lixeira");
            System.Console.WriteLine("1 - Garrafa");
            System.Console.WriteLine("2 - GarrafaPET");
            System.Console.WriteLine("3 - GuardaChuva");
            System.Console.WriteLine("4 - Latinha");
            System.Console.WriteLine("5 - Papelão");
            System.Console.WriteLine("6 - Pote de Manteiga");
            System.Console.WriteLine();
            System.Console.WriteLine();

            int opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1:
                Teste((IVidros) garrafa);
                break;
                case 2:
                Teste1((IPlastico)garrafapet);
                break;
            }
            



        }

        static bool Teste(IVidros garrafa){
            Console.ForegroundColor = ConsoleColor.Green;
            garrafa.Vidro();
            Console.ResetColor();
            return true;
        }


        static bool Teste1(IPlastico garrafapet){
            Console.ForegroundColor = ConsoleColor.Red;
            garrafapet.Plastico();
            Console.ResetColor();
            return true;
        }
    }
}
