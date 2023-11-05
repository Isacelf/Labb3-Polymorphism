namespace Labb3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry circle = new Circle();
            circle.Area();

            Geometry square = new Square();
            square.Area();

            Geometry rectangle = new Rectangle();
            rectangle.Area();

            Console.ReadKey();
        }
    }
}