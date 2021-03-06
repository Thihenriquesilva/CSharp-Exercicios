﻿using System;
using MateODragao.Models;

namespace MateODragao {
    class Program {
        static void Main (string[] args) {
            bool jogadorNaoDesistiu = true;
            do {

                System.Console.WriteLine ("****************************");
                System.Console.WriteLine ("        Mate o Dragão!");
                System.Console.WriteLine ("****************************");

                System.Console.WriteLine (" 1 - Iniciar jogo");
                System.Console.WriteLine (" 0 - Sair do  jogo");

                string opcaoJogador = Console.ReadLine ();

                switch (opcaoJogador) {
                    case "1":
                        Console.Clear ();

                        Guerreiro guerreiro = CriarGuerreiro(); /** Personagens Guerreiro **/

                        Dragao dragao = new Dragao ();
                        dragao.Nome = "Grigori";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /*** INCIO - Primeiro Diálogo ***/
                        CriarDialogo (guerreiro.Nome, $"{dragao.Nome}, vim a sua procura !!");
                        CriarDialogo (dragao.Nome, "...");

                        FinalizarDialogo ();
                        /*** FIM - Primeiro Diálogo ***/

                        /*** INICIO - Segundo Diálogo ***/
                        CriarDialogo (guerreiro.Nome, $"Meu nome é {guerreiro.Nome} {guerreiro.Sobrenome}, vim de {guerreiro.CidadeNatal}, para acabar com seu reinado.");
                        CriarDialogo (dragao.Nome, "Hmm!!....");

                        FinalizarDialogo ();
                        /*** FIM - Segundo Diálogo ***/
                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        bool jogadorNaoCorreu = true;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        /** INICIO DA TRETA **/

                        if (jogadorAtacaPrimeiro) {
                            Console.Clear ();

                            System.Console.WriteLine ("***** Turno do Jogador *****");
                            System.Console.WriteLine ("Escolha sua ação:");
                            System.Console.WriteLine (" 1 - ATACAR");
                            System.Console.WriteLine (" 2 - FUGIR");

                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random ();
                                    int numeroAleatoriojogador = geradorNumeroAleatorio.Next (0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatoriojogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Sinta minha fúria !");
                                        //menos igual//
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ();
                                        System.Console.WriteLine ($"HP Dragâo: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Achas que pode me ferir?!");
                                    }
                                    break;
                                case "2":
                                    jogadorNaoCorreu = false;
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Ainda não sou pareo para seu poder. voltarei em breve");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Você não é digno");
                                    break;
                            }
                            FinalizarDialogo ();

                            while (dragao.Vida > 0 && guerreiro.Vida > 0 && jogadorNaoCorreu) {
                                System.Console.WriteLine ("***** Turno do Dragão *****");
                                Random geradorNumeroAleatorio = new Random ();
                                int numeroAleatoriojogador = geradorNumeroAleatorio.Next (0, 5);
                                int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatoriojogador;
                                int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                if (dragaoDestrezaTotal > guerreiroDestrezaTotal) {
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Humano insolente!");
                                    //menos igual//
                                    guerreiro.Vida -= dragao.Forca;
                                    System.Console.WriteLine ();
                                    System.Console.WriteLine ($"HP Dragâo: {dragao.Vida}");
                                    System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                } else {
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Posso fazer isso o dia todo.");
                                }
                                FinalizarDialogo ();
                                /** INICIO - TURNO JOGADOR **/
                                System.Console.WriteLine ("***** Turno do Jogador *****");
                                System.Console.WriteLine ("Escolha sua ação:");
                                System.Console.WriteLine (" 1 - ATACAR");
                                System.Console.WriteLine (" 2 - FUGIR");

                                opcaoBatalhaJogador = Console.ReadLine ();

                                switch (opcaoBatalhaJogador) {
                                    case "1":
                                        geradorNumeroAleatorio = new Random ();
                                        numeroAleatoriojogador = geradorNumeroAleatorio.Next (0, 5);
                                        numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                        guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatoriojogador;
                                        dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                        if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                            System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Sinta minha fúria !");
                                            //menos igual//
                                            dragao.Vida -= poderAtaqueGuerreiro + 5;
                                            System.Console.WriteLine ();
                                            System.Console.WriteLine ($"HP Dragâo: {dragao.Vida}");
                                            System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                        } else {
                                            System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Achas que pode me ferir?!");
                                        }

                                        if (guerreiro.Vida <= 0) {
                                            System.Console.WriteLine ("Você morreu");
                                        }
                                        if (dragao.Vida <= 0) {
                                            System.Console.WriteLine ("Vitória");
                                        }
                                        FinalizarDialogo ();

                                        break;
                                    case "2":
                                        jogadorNaoCorreu = false;
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Ainda não sou pareo para seu poder. voltarei em breve");
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Você não é digno");
                                        break;
                                }
                                FinalizarDialogo ();

                                /** FIM - TURNO JOGADOR **/

                            }

                        }

                        /** FIM DA TRETA **/

                        break;
                    case "0":
                        break;
                    default:
                        System.Console.WriteLine ("Comando desconhecido");
                        break;

                }
            } while (jogadorNaoDesistiu);

        }

        private static void CriarDialogo (string nome, string frase)
        /** 
         * !Terceirizando o dialogo do JOGO
         * TODO 'criar dialogo + nome da variavel + ctrlC/ctrlV frase do jogo' 
         */
        {
            System.Console.WriteLine ($"{nome.ToUpper()}: {frase}");
        }

        private static void FinalizarDialogo ()
        /**
         * !Terceirizando a ação de prosseguir dialogo  do JOGO
         * TODO copie a informação repetida aqui !!! Não esqueça de declarar no codigo principal o metodo
         */
        {
            System.Console.WriteLine ();
            System.Console.WriteLine ("Aperte Enter para continuar");
            Console.ReadLine ();
            Console.Clear ();

        }

        private static Guerreiro CriarGuerreiro () { /** <= Assinatura do método OU Declaração do Metodos **/
            Console.ReadLine();
            
            Guerreiro guerreiro = new Guerreiro ();
            guerreiro.Nome = "Vaelin";
            guerreiro.Sobrenome = "Galahad";
            guerreiro.CidadeNatal = "Asrael";
            guerreiro.DataNascimento = DateTime.Parse ("03/02/1350");
            guerreiro.FerramentaAtaque = "Machados duplos de Guerra";
            guerreiro.FerramentaProtecao = "Armadura do Sol ausente";
            guerreiro.Forca = 3;
            guerreiro.Destreza = 3;
            guerreiro.Inteligencia = 2;
            guerreiro.Vida = 20;

            return guerreiro; 
        }
    }
}