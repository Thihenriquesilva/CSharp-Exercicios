using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();


            System.Console.WriteLine("****CONTA BANCARIA****");
            System.Console.WriteLine("\n");
            System.Console.WriteLine("Diga o nome do Titular:");
            string titular = Console.ReadLine();
            System.Console.WriteLine("Diga sua agência:");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Diga o numero da conta:");
            int numero = int.Parse(Console.ReadLine());
            

            DadosBancarios dados1 = new DadosBancarios(titular, agencia, numero);

            bool Saldonegativo = false;

            do{
                System.Console.WriteLine("Diga seu saldo:");
                double saldo = double.Parse(Console.ReadLine());
                Saldonegativo = dados1.Saldonegativo(saldo);

                if(!Saldonegativo){
                    System.Console.WriteLine("Não possui saldo, quer um abraço");
                }
                else{
                    System.Console.WriteLine($" Seu saldo é  {saldo}.");
                }
            }while(!Saldonegativo);
        }
    }
}
