using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Labb3_Polymorphism
{
    internal class Circle : Geometry
    {
        public double radius {  get; set; }
        public double Pi {  get; set; }
        public Circle()
        {
            radius = 4;
            Pi = Math.PI;
        }

        public override double Area()
        {
            double area = radius * radius * Pi;
            Console.WriteLine($"Area cirkel: {area}");
            return area;
        }
    }
}
