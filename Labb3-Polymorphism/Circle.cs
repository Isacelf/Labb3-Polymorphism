using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Labb3_Polymorphism
{
    internal class Circle : Geometry // Cirkel klass som ärver från Geometry
    {
        public double radius {  get; set; } // Specifika egenskaper för Circle
        public double Pi {  get; set; }
        public Circle() // Konstruktor som sätter standardvärde för radien och pi
        {
            radius = 4;
            Pi = Math.PI;
        }

        public override double Area() // Överskrivden metod för att berärkna cirkelns area
        {
            double area = radius * radius * Pi;
            Console.WriteLine($"Area cirkel: {area}");
            return area;
        }
    }
}
