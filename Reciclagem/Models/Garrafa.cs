using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Garrafa :IVidros
    {
        public bool Vidro(){
            
            System.Console.WriteLine("Reciclavel jogar na lixeira Verde(Vidro)");
            
            return true;

        }

    }
}