using System;

namespace MyCSharpMastery
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            Console.WriteLine("Please enter your name and press enter: ");
            name = Console.ReadLine();

            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Trim());
            Console.WriteLine(name.Substring(0, 5));
            Console.Read();

        }
    }
}
