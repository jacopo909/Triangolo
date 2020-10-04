using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Triangolo
{
    class Triangolo
    {
        private double x, y, z;

        public Triangolo(double Lato_1, double Lato_2, double base_)
        {
            x = Lato_1;
            y = Lato_2;
            z = base_;

            if (Lato_1 == Lato_2 && Lato_2 == base_ && base_ == Lato_1 )
            {
                Equilatero();
            }
            else if (Lato_1 == Lato_2 || Lato_2 == Lato_1)
            {
                Isoscele();
            }
            else
            {
                Scaleno();
            }
        }
        private double Perimetro()
        {
            double perimetro = x + y + z;
            return perimetro;
        }
        
        private void Isoscele()
        {
             
            Console.WriteLine($"\nIl perimetro è {Perimetro()} e il triangolo è isoscele");
        }
        private void Scaleno()
        {
            Console.WriteLine($"\nIl perimetro è {Perimetro()} e il triangolo è scaleno");
        }
        private void Equilatero()
        {
            Console.WriteLine($"\nIl perimetro è {Perimetro()} e il triangolo è equilatero");
        }
    }
}
