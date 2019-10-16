using System;
using System.Colletction.Generic;
using System.Text;

namespace EscolaDeRock.Interface
    {
    public interface IMelodia
        {
        bool TocarSolo()
            {
                Console.WriteLine("Tocando o solo.");
                return true;
            }
        }
    }
