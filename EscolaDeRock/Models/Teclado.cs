using EscolaDeRock.Interface;

namespace EscolaDeRock.Models
{
    public class Teclado : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes(){
            Console.Console.WriteLine("Tocando acordes de Teclado");
            return true;
        }
        public bool TocarSolo()
            {
                Console.WriteLine("Tocando o solo do Teclado.");
                return true;
            }
        

    }
}