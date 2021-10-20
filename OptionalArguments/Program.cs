using System;

namespace OptionalArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Optional Arguments!");
            DisplayPlayerInformation(7, "C. Ronaldo", 60, "Portugal", "Real Madrid");
            Console.WriteLine("------------------");
            DisplayPlayerInformation(10, "L. Messi", 55);
        }

        public static void DisplayPlayerInformation(int num, string name, int goals, string country, string club)
        {
            Console.WriteLine("Hi From the first method");
            Console.WriteLine("Number = " + num);
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Goals = " + goals);
            Console.WriteLine("Country = " + country);
            Console.WriteLine("Club = " + club);
        }

        public static void DisplayPlayerInformation(int num, string name, int goals)
        {
            Console.WriteLine("Hi From the second method");
            Console.WriteLine("Number = " + num);
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Goals = " + goals);
        }
    }
}
