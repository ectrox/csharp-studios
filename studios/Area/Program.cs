using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a radius:");
                string input = Console.ReadLine();
                try
                {
                    double radius = Convert.ToDouble(input);               
                    double area = Math.PI * radius * radius;
                    Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");
                } catch
                {
                    Console.WriteLine("Error: invalid user input");
                }

            }
        }
    }
}
