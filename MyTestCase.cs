using System;

namespace MyTestCases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TestCase.CallCase call = new TestCase.CallCase();
            call.Call();
            MyHero();
            Method(10);

            Console.WriteLine(MyHero());
            Console.WriteLine(Method(20));


            Console.ReadKey();
        }

       static string MyHero()
        {
            string name = "I am your hero!";
            Console.WriteLine("Am inside MyHero()");
            return name;
        }

        static int Method(int a)
        {
            int b = a;
            Console.WriteLine("Am Inside Method()");
            return b;
        }
    }
}

namespace TestCase
{
    class CallCase
    {
        public void Call()
        {
            Console.WriteLine("Am Called Test Case!");
        }
    }
}