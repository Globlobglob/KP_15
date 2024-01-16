namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
           
            Point p1 = new Point(25,56);
            p1.Print();
            double length =Point.LenghtPoints(1,2,65,564);

            Console.WriteLine($"{length:F1}");

            Console.ReadKey();
        }
    }
}
