using EscolaDeRock.Interface;

namespace EscolaDeRock.Models
    {
    public class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia
        {
        public bool ManterRitmo(){
            Console.WriteLine("Mantendo o Ritmo do ContraBaixo.");
            return true;
        }

        public bool TocarAcordes(){
            Console.WriteLine("Tocando acordes do ContraBaixo.");
            return true;
        }

    }
}