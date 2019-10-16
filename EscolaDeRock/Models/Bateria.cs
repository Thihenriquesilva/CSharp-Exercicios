using System;
using System.Colletction.Generic;
using System.Text;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models {
        public class Bateria : InstrumentoMusical, IPercussao
        {
            public bool ManterRitmo () {
                Console.WriteLine ("Mantendo o ritmo da Bateria.");
                return true;
            }
        }
}