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

            bool Trocousenha = false;
            do{
                System.Console.WriteLine("Sua Senha:");
                string senha = Console.ReadLine();
                Trocousenha = cliente1.TrocaSenha(senha);

                if (!Trocousenha){
                    System.Console.WriteLine("Senha não atende aos requisitos");

                }
                else{
                    System.Console.WriteLine("Senha Trocada com sucesso");
                }
                
            }while(!Trocousenha);

            /*********
            *TODO Aula de hoje implementar  com a adição de conta bancanria.
            *TODO Usado o mesmo método da aula anterior 
            *********/
            System.Console.WriteLine("******CONTA BANCARIA*******");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.Write("Diga sua Agencia:");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.Write("Diga sua Conta:");
            int conta = int.Parse(Console.ReadLine());
            System.Console.Write("Titular:");
            string titular = Console.ReadLine();

            bool saldoValido = false;
            double saldo;

            do{
                Console.Write("Digite o saldo:");
                saldo = double.Parse(System.Console.ReadLine());
                if(saldo >= 0){
                    saldoValido = true;
                }
                else {
                    System.Console.WriteLine("O saldo não pode ser negativo");
                }
            }while(!saldoValido);

            ContaCorrente contaCorrente = new ContaCorrente(agencia, conta, titular);
            contaCorrente.Saldo = saldo;
            
            
            


        }
    }
}