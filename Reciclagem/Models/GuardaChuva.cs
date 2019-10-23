using  Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GuardaChuva : INReciclaveis
    {
        public bool Nreciclaveis (){
            System.Console.WriteLine("Este item não pode ser reciclado.");
            return true;
        }
    }
}