using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class PoteManteiga :  IPlastico
    {
        public bool Plastico(){
        System.Console.WriteLine("Reciclavel jogar na lixeira Vermelha(Plastico)");
            return true;
        }
    }
}