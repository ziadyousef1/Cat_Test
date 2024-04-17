namespace Task_5
{
   
    internal class Program
    {
        /*
          A delegate is a type definition for functions,
          similar to a class for an object. 
          The class declares the type, and the object is an instance of that type. 
          You can have multiple objects for a single class.

          Delegates are types that describe a set of common functions,
          which have the same signature as the delegate. 
          Instances of the delegate are referred to as delegate instances.
        */
        public delegate int MathOperation(int a, int b);
        static void Main(string[] args)
        {
            MathOperation mathOperation = new MathOperation(Add);
            Console.WriteLine(mathOperation(10, 10));

            mathOperation = Subtract;
            Console.WriteLine(mathOperation(10, 10));

            mathOperation = Multiply;
            Console.WriteLine(mathOperation(10, 10));

            mathOperation = Divide;
            Console.WriteLine(mathOperation(10, 10));
            
        }

        public static int Add(int a, int b)
        => a + b;

        public static int Subtract(int a, int b)
        => a - b;

        public static int Multiply(int a, int b)
        => a * b;

        public static int Divide(int a, int b)
        => a / b;
    }
}