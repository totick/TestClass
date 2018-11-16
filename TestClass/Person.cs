using System;

namespace TestClass
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("My name is {0} {1}", this.firstName, this.lastName);
        }
    }
}
