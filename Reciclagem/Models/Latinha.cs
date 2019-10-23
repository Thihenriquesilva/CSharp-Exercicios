using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Latinha : IMetais
    {
        public bool Metal(){
            System.Console.WriteLine("Este item é reciclavem, jogar na Lixeira Amarela(Metal).");
            return true;
        }
    }

}