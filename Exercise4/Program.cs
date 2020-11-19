using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first altitude in feet: ");
            float firstAlt = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second altitude in feet: ");
            float secondAlt = float.Parse(Console.ReadLine());
            Console.WriteLine($"The difference in altitude is: {firstAlt - secondAlt} feet");

        }
    }
}
