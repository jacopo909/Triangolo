using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Triangolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nQuanto vale il 1° lato? ");
            double lato_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nQuanto vale il 2° lato? ");
            double lato_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nQuanto vale la bese? ");
            double base_ = double.Parse(Console.ReadLine());
            Triangolo calcola = new Triangolo(lato_1,lato_2,base_);

            Console.ReadKey();
        }
        
    }
}
