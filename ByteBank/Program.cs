using System;

namespace ByteBank {
    class Program {
        static void Main (string[] args) {
            /* Aréa Cadastro */
            System.Console.WriteLine ("****CASDASTRO****");
            System.Console.WriteLine ();
            System.Console.WriteLine ("Seu Nome:");
            string nome = Console.ReadLine ();
            System.Console.WriteLine ("Seu CPF:");
            string cpf = Console.ReadLine ();
            System.Console.WriteLine ("Seu E-mail:");
            string email = Console.ReadLine ();
            
            Cliente cliente1 = new Cliente(nome, cpf, email);

            bool senhaOk = false;
            do{
                System.Console.WriteLine("Sua Senha:");
                string senha = Console.ReadLine();
                senhaOk = cliente1.TrocaSenha(senha);

                if (!senhaOk){
                    System.Console.WriteLine("Senha não atende aos requisitos");

                }
                else{
                    System.Console.WriteLine("Senha Trocada com sucesso");
                }
                
            }while(!senhaOk);


        }
    }
}