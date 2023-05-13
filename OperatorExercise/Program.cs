using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add();
            Sub();
            Multi();
            Div();
            AreaOfCircle();

        }
        public static void Add()
        {
            //Exercise 1
            int a = 8;
            int b = 4;

            var add = a + b;

            Console.WriteLine(add);
        } 
        public static void Sub()
        {
            int a = 8; 
            int b = 4;

            var sub = a - b;

            Console.WriteLine(sub);
        }
        public static void Multi()
        { int a = 8;
          int b = 4;

            var multi = a * b;

            Console.WriteLine(multi);
        }
        public static void Div()
        {
            int a = 17;
            int b = 4;
            var div = a / b;

            var quotient = b;
            var remainder = a % b;
            Console.WriteLine(div);
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine();
        }
        public static void AreaOfCircle()
        {
            //Exercise 2
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            var area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of a circle with radius of {radius} is {area}.");
            Console.WriteLine();
            //Thought Exercise
            // var is implicit type inferrence (more on this later)
            var i = 3; // i variable is equal to three.
            var j = 4; // j variable is equal to four.
            var k = ++i * j++; // k variable is a pre-increment of i (4) multiplied by a increment of j (4) which equals

            Console.WriteLine($"Look at this cool output: {k}"); //<--- 16 // ouputs ?
        }

    }
}
