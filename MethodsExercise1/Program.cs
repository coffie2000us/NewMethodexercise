using System;

namespace MethodsExercise1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Myself();
            Console.WriteLine($"Calling the add method.");
            int sum = Add(4, 2);
            Console.WriteLine(sum);

            Console.WriteLine();

            Console.WriteLine($"Calling the subtract method.");
            int subtraction = Subtract(4, 2);
            Console.WriteLine(subtraction);

            Console.WriteLine();

            Console.WriteLine($"Calling the multiply method");
            int multiplication = Multiply(4, 2);
            Console.WriteLine(multiplication);

            Console.WriteLine();

            Console.WriteLine($"Calling the divide method");
            int division = Divide(4, 2);
            Console.WriteLine(division);
        }
        
        public static void Myself()


        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What's your favorite animal");
            string animal = Console.ReadLine();

            Console.WriteLine("Mention your favorite sports team");
            string sportsTeam = Console.ReadLine();

            Console.WriteLine("What's your favorite band");
            string band = Console.ReadLine();

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"My favorite animal is {animal}");
            Console.WriteLine($"My favorite sports team is {sportsTeam}");
            Console.WriteLine($"Lastly, my favorite band is {band}");


        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
   
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
          
}
