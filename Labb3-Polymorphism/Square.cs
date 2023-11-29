using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Polymorphism
{
    internal class Square : Geometry // Fyrkant klass som ärver från Geometry
    {
        public double Lenght { get; set; } // Specifika egenskaper för Square

        public Square() // Konstruktor som sätter standardvärde för Lenght
        {
            Lenght = 5.8;
        }

        public override double Area() // Överskrivden metod för att berärkna fyrkantens area
        {
            double area = Lenght * Lenght;
            Console.WriteLine($"Area fyrkant: {area}");
            return area;
        }

    }
}
