using System.Drawing;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine("Area: " + rectangle.Area());
            Console.WriteLine("Perimeter: " + rectangle.Perimeter());
        }

        
    }
    class Rectangle
    {
        public int length;
        public int width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int Area()
        {
            return length * width;
        }

        public int Perimeter()
        {
            return 2 * (length + width);
        }
    }
}