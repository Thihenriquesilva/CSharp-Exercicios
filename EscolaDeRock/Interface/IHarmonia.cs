using System;
using System.Colletction.Generic;
using System.Text;

namespace EscolaDeRock.Interface
    {
    public interface IHarmonia  // "I" na frente dos nomes, é apenas um parametro referencial para distinguir que é uma interface
        {
        bool TocarAcordes(){
            Console.WriteLine("Tocando acordes");
            return true;
        }

    }
    
}


    
