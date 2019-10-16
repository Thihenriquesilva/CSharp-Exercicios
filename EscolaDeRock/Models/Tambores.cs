namespace EscolaDeRock.Models
{
    public class Tambores : InstrumentoMusical, IPercussao
    {
        bool ManterRitmo(){
        Console.WriteLine("Mantendo o ritmo dos Tambores.");
        return true;
        }
    }
}