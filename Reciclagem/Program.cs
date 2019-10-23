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
            GuardaChuva guardachuva = new GuardaChuva();
            Latinha latinha = new Latinha();
            Papelao papeis = new Papelao();
            PoteManteiga pote = new PoteManteiga();
            
            
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
                Teste((IPlastico)garrafapet);
                break;
                case 3:
                Teste((INReciclaveis)guardachuva);
                break;
                case 4:
                Teste((IMetais)latinha);
                break;
                case 5:
                Teste((IPapeis)papeis);
                break;
                case 6 :
                Teste1((IPlastico)pote);
                break;
                

            }
            



        }

        static bool Teste(IVidros garrafa){
            Console.ForegroundColor = ConsoleColor.Green;
            garrafa.Vidro();
            Console.ResetColor();
            return true;
        }


        static bool Teste(IPlastico garrafapet){
            Console.ForegroundColor = ConsoleColor.Red;
            garrafapet.Plastico();
            Console.ResetColor();
            return true;
        }
        static bool Teste(INReciclaveis guardachuva){
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            guardachuva.Nreciclaveis();
            Console.ResetColor();
            return true;
        }

        static bool Teste(IMetais latinha){
            Console.ForegroundColor = ConsoleColor.Yellow;
            latinha.Metal();
            Console.ResetColor();
            return true;
        }

        static bool Teste(IPapeis papel){
            Console.ForegroundColor = ConsoleColor.Blue;
            papel.Papel();
            Console.ResetColor();
            return true;
        }

        static bool Teste(IPlastico pote){
            Console.ForegroundColor = ConsoleColor.Red;
            pote.Plastico();
            Console.ResetColor();
            return true;
        
    }
}
}


