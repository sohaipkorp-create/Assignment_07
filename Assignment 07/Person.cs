using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_07
{
    internal class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public void greet()
        {
            Console.WriteLine("I'm a person");
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
        }
    }
}
