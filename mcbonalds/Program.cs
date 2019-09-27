using System;

namespace mcbonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Thiago","55 11 5555-5555","thiago@email.com");

            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Telefone" + cliente1.Telefone);
            Console.WriteLine("Email: " + cliente1.Email);
        }
    }
}
