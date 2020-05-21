using System;

namespace somarImposto
{
    class Program
    {
        
        static void Main(string[] args)
        {

           double  meal_cost = Double.Parse(Console.ReadLine());
            int tip_percent = Int32.Parse(Console.ReadLine());
            int tax_percent = Int32.Parse(Console.ReadLine());
            
            solve(meal_cost, tip_percent, tax_percent);
            
        }

        static void solve(double meal_cost, int tip_percent, int tax_percent){

                double tip =0, tax=0;
                double totalCost;
                tip = (meal_cost * tip_percent)/100;
                tax = (meal_cost*tax_percent)/100;

                totalCost = meal_cost + tip + tax;

                System.Console.WriteLine(Math.Round(totalCost));
        }
    }
}
