using System;

namespace triangulos
{
    class Program
    {
        private const int V = 2;

        static void Main(string[] args)
        {    int qt;
             int at;
            

            Console.WriteLine("Digite o tamanho do triângulos");
            qt = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do triângulos");
            at = int.Parse(Console.ReadLine());
        
            
            for( int g = 0; g < qt; g++){
                string estrelas = "";
                Console.WriteLine();

                for( int h = 0; h< at; h++){
                     estrelas += "*"; 
                    Console.WriteLine(estrelas);
                }
                Console.WriteLine();
                    
                  
                
            }
        }
    }
}
