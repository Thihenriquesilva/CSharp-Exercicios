using System;

namespace menumat
{
    class Program
    {
        static void Main(string[] args)
        {
            double quad, tribase, trialt, ciraio, bam, ban, balt, lm, ln, dm, dn  = 0;
            String op = "s";
    
            
            while(op == "s"){

            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Triângulo");
            Console.WriteLine("3 - Círculo");
            Console.WriteLine("4 - Trapézio");
            Console.WriteLine("5 - Retângulo");
            Console.WriteLine("6 - Losango");
            Console.WriteLine("Escolha uma fórmula");

            switch (Console.ReadLine())
            {

            case "1":
            Console.WriteLine("Digite o 1º valor");
            quad = double.Parse(Console.ReadLine());
            Console.WriteLine($" {quad} * {quad} = " + (quad * quad));
            break;

            case "2":
            Console.WriteLine("Digite o 1º valor");
            tribase = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º valor");
            trialt = double.Parse(Console.ReadLine());

            Console.WriteLine($"{tribase} * {trialt} / {2} = " + (tribase*trialt/2));
            break;

            case "3":
            Console.WriteLine("Digite o valor do raio");
            ciraio = double.Parse(Console.ReadLine());
            Console.WriteLine($"{3,14} * {ciraio} = " + (ciraio * ciraio * 3.14));
            break;

            case "4":
            Console.WriteLine("Digite o 1º valor");
            bam = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º valor");
            ban = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3º valor");
            balt = double.Parse(Console.ReadLine());

            Console.WriteLine($"({bam} + {ban})/ 2 * {balt} = " + ((bam + ban) /2*balt));
            break;

            case "5":
            Console.WriteLine("Digite o 1º valor");
            lm = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º valor");
            ln= double.Parse(Console.ReadLine());

            Console.WriteLine($"{lm} * {ln} = " + (lm * ln));
            break;

            case "6":
            Console.WriteLine("Digite o 1º valor");
            dm = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º valor");
            dn = double.Parse(Console.ReadLine());

            Console.WriteLine($"({dm} * {dn}) / 2 = " + ((dm * dn) /2));
            break;
            }
            

            Console.WriteLine("Deseja refazer o calculo ?");
            op = Console.ReadLine();
            }
            

        }
    }
}
