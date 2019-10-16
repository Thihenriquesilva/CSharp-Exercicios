using System;
using System.Colletction.Generic;
using System.Text;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models
{
    public class Violao : InstrumentoMusical, IHarmonia, IMelodia, IPercussao  //Classe violao vai herdar as caracteristicas da classe InstrumentoMusical
    {
        public bool TocarAcordes(){
            Console.WriteLine("Tocando acordes do Violão.");
            return true;
        }

        public bool TocarSolo(){
            Console.WriteLine("Tocando solo de Violão");
            return true;
        }
        

        public bool ManterRitmo(){
            Console.WriteLine("Mantendo o ritmo do Violão.");
            return true;
        }

    }
}