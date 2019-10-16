using System;
using EscolaDeRock.Models;
using System.Collection.Generic;


namespace EscolaDeRock
    {
        enum FormacaoEnum : int
        {
            TRIO = 3, QUARTETO 
        };

        enum InstrumentosEnum : int{ 
            BAIXO, BATERIA, CONTRABAIXO, GUITARRA, TECLADO, TAMBORES, VIOLAO 
        };
        enum CategoriaEnum : int { 
            HARMONIA, PERCUSSAO, MELODIA
        };    
    class Program
        {
        static void Main(string[] args)
        {
            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] itensMenuPrincipal = Enum.GetNames(typeof(CategoriaEnum));
            string[] itensMenuPrincipal = Enum.GetNames(typeof(InstrumentosEnum));

            var opcoesFormacao =  new List<string>(){
                "    -0     ", 
                "    -1     "
            };

            int opcaoFormacao = 0;
            string menubar = "=======================================";

            do{
                bool formacaoEscolhida = false;
                do {
                    Console.Clear();
                    Console.WriteLine(menubar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(" Seja bem-vindo meu consagrado !");
                    Console.WriteLine(" Escolha uma formação");
                    Console.ResetColor();
                    Console.WriteLine(menubar);

                    for(int i=0;i<opcoesFormacao.Count;i++){
                        string titulo = TratarTituloMenu(itensMenuPrincipal[i]);

                        if(opcaoFormacao == i){
                            DestacarOpcao(opcoesFormacao[opcaoFormacao].Replace(".",">",).Replace(i.ToString(), titulo));
                        }
                        else{
                            Console.WriteLine(opcaoFormacao[i].Replace(i.ToString(),titulo));
                    }

                    var key = Console.ReadKey(true).Key;

                    switch(key)
                    {
                        case ConsoleKey.UpArrow:
                        opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada : -- opcaoFormacaoSelecionada;
                        break;
                        case ConsoleKey.DownArrow:                        
                        opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcaoFormacao.Count - 1 ? opcaoFormacaoSelecionada : ++opcaoFormacaoSelecionada;
                        break;
                        case ConsoleKey.Enter:
                        formacaoEscolhida = true;
                        break;
                    }

                    }

                    bool bandacompleta = false;
                    int vagas = 0;

                    switch(opcaoFormacaoEscolhida){
                        case 0:
                        vagas = 2;
                        do{
                            ExibirMenuInstrumento();
                            Console.WriteLine($"Digite o código do instrumento de harmonia :");
                            var instrumento = Deposito.Instrumento[codigo];
                            vagas--;
                            Type interfaceEncontrada = instrumento.GetType().GetInterface("Harmonia");
                            if(interfaceEncontrada != null){
                                ColocarNaBanda((IPercussao)Instrumento);

                            }else{
                                continue;
                            }
                            Console.WriteLine($"Digite o código do instrumento da música: ");
                            instrumento = Deposito.Instrumento[codigo];
                            vagas--;
                            if(vagas == 0){
                                bandacompleta = true;
                            }
                            }while (! bandacompleta);
                            Console.WriteLine("Banda completa");
                        }
                }while();//TERMINAR AINDA
            }while();//TERMINAR AINDA

        }
    }
}
