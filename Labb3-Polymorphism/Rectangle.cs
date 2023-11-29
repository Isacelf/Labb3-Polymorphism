using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Polymorphism
{
    internal class Rectangle : Geometry // Rektangel klass som ärver från Geometry
    {
        public double Lenght { get; set; } // Specifika egenskaper för Rectangle
        public double Width { get; set; }

        public Rectangle() // Konstruktor som sätter standardvärde för Lenght och Width
        {
            Lenght = 13.7;
            Width = 4.3;
        }
        public override double Area() // Överskrivden metod för att berärkna rektangelns area
        {
            double area = Lenght * Width;
            Console.WriteLine($"Area rektangel: {area}");
            return area;
        }

    }
}
