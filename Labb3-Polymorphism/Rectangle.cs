using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Polymorphism
{
    internal class Rectangle : Geometry
    {
        public double Lenght { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Lenght = 13.7;
            Width = 4.3;
        }
        public override double Area()
        {
            double area = Lenght * Width;
            Console.WriteLine($"Area rektangel: {area}");
            return area;
        }

    }
}
