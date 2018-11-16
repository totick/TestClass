using System;
using TestClass.Math;

namespace TestClass
{

    class MainClass
    {
        public static void Main(string[] args)
        {

            var john = new Person
            {
                firstName = "John",
                lastName = "Lundgren"
            };

            john.Introduce();

            int a = 5;
            int b = 10;
            Console.WriteLine("Sum of {0} and {1} is {2}", a, b, Calculator.Add(a, b));
        }
    }
}
