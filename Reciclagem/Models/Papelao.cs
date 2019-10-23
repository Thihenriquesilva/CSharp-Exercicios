using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Papelao : IPapeis
    {
        public bool Papel(){
            System.Console.WriteLine("Este item é reciclavel jogar na Lixeira Azul(Papeis).");
            return true;
        }
    }
}