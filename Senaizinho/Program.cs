using System;
using System.Collections.Generic;

namespace Senaizinho {
    class Program {
        static void Main (string[] args) {
            Aluno alunos = new Aluno()
            do {

                int opcao = 0;
                System.Console.WriteLine ("*******************");
                System.Console.WriteLine ();
                System.Console.WriteLine ("CADASTRO SENAIZINHO");
                System.Console.WriteLine ();
                System.Console.WriteLine ("*******************");

                Console.Clear ();
                System.Console.WriteLine ("Bem-vindo, escolha uma Opção:");
                System.Console.WriteLine ("1 - Cadastrar de Alunos");
                System.Console.WriteLine ("2 - Cadastrar de Sala");
                System.Console.WriteLine ("3 - Alocar Aluno"); //*Definir para qual sala o aluno possa ir */
                System.Console.WriteLine ("4 - Remover Aluno");
                System.Console.WriteLine ("5 - Verificar Salas");
                System.Console.WriteLine ("6 - Verificar Alunos");
                System.Console.WriteLine ("7 - Sair ");
                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        System.Console.WriteLine("NOME: ");
                        Console.ReadLine();
                        System.Console.WriteLine("DATA DE NASCIMENTO: ");
                        Console.ReadLine();
                        System.Console.WriteLine("CURSO: ");
                        Console.ReadLine();
                        System.Console.WriteLine("Nº DA SALA: ");
                        break;

                    case 2:
                        AddSala (sala);
                        break;

                    case 3:
                        AlocarAluno (alunos);
                        break;

                    case 4:
                        RemoveAluno (alunos);
                        break;

                    case 5:
                        VerificarSalas (sala);
                        break;

                    case 6:
                        VerificarAlunos (alunos);
                        break;

                    case 7:
                        System.Console.WriteLine ("Até a próxima !!");
                        break;
                    default:
                        System.Console.WriteLine ("Opção invalida");
                        Console.ReadLine ();
                        break;

                }

            } while (opcao != 7);
            return 0;
        }
        
    }
}