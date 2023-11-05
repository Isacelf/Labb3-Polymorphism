using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Polymorphism
{
    internal class Square : Geometry    
    {
        public double Lenght { get; set; }

        public Square()
        {
            Lenght = 5.8;
        }

        public override double Area()
        {
            double area = Lenght * Lenght;
            Console.WriteLine($"Area fyrkant: {area}");
            return area;
        }

    }
}
