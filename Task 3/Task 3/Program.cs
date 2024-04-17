namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Shape shape1 = new Rectangle(20, 10);
            Shape shape2 = new Circle(6);

            Console.WriteLine($"Area of Rectangle: {shape1.CalculateArea()}");
            Console.WriteLine($"Area of Circle: {shape2.CalculateArea()}");

        }
    }
}