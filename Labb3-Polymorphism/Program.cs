namespace Labb3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar instans av geometry med hjälp av circle klassen
            Geometry circle = new Circle();
            circle.Area(); // Anropar area metoden inom circle klassen


            // Skapar instans av geometry med hjälp av square klassen
            Geometry square = new Square();
            square.Area(); // Anropar area metoden inom square klasse


            // Skapar instans av geometry med hjälp av rectangle klassen
            Geometry rectangle = new Rectangle();
            rectangle.Area(); // Anropar area metoden inom rectangle klasse

            Console.ReadKey();
        }
    }
}