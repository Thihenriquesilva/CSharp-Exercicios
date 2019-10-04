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
            // System.Console.Write("Titular:");
            // string titular = Console.ReadLine();

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

            ContaCorrente contaCorrente = new ContaCorrente(agencia, conta, cliente1);
            contaCorrente.Saldo = saldo;


            /****** DEPOSITOS, SAQUES E TRANSFERENCIAS ******/

            
            System.Console.WriteLine("ByteBank - Deposito");
            Cliente usuario = contaCorrente.Titular;
            Console.WriteLine($"Bem vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agência: {contaCorrente.Agencia}      Conta:{contaCorrente.Numero}");
            System.Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
            Console.Write("Digite o valor do Deposito: ");
            double valor = double.Parse(Console.ReadLine());
            contaCorrente.Deposito(valor);
            System.Console.WriteLine();

            System.Console.WriteLine("ByteBank - Saque");
            System.Console.WriteLine($"Bem vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agência: {contaCorrente.Agencia}      Conta:{contaCorrente.Numero}");
            System.Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
            System.Console.WriteLine("Qual o valor do Saque ?");
            valor = double.Parse(Console.ReadLine());
            if(contaCorrente.Saque(valor)){
                System.Console.WriteLine("Saque realizado com sucesso. Retire sua nota.");
            }else{
                System.Console.WriteLine("Não foi possivel realizar a operação.");
            }
            System.Console.WriteLine($"Saldo atual: {contaCorrente.Saldo}");
            System.Console.WriteLine();

            Cliente cliente2 = new Cliente("Alexandre","123.321.123 -12","a@a.com");
            ContaCorrente contacorrente2 = new ContaCorrente(123,123, cliente2);
            System.Console.WriteLine("ByteBank - Transferência");
            System.Console.WriteLine($"Bem vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agência: {contaCorrente.Agencia}     Conta:{contaCorrente.Numero}");
            System.Console.WriteLine($"Saldo origem: {contaCorrente.Saldo}");
            System.Console.WriteLine($"Saldo destino: {contacorrente2.Saldo}");
            System.Console.Write("Digite o valor da transferência: ");
            valor = double.Parse(Console.ReadLine());

            if(contaCorrente.Transferencia(contacorrente2,valor)){
                System.Console.WriteLine("Transferência efetuada com sucesso.");
            }else{
                System.Console.WriteLine("Operação não pode ser realizada.");
            }

            System.Console.WriteLine($"Saldo origem: {contaCorrente.Saldo}");
            System.Console.WriteLine($"Saldo destino {contacorrente2.Saldo}");
            

        }
    }
}