using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Assignment_07
{
    internal class doctor: Person
    {
        public string Specialty { get; set; }

        public new void Greet()
        {
            Console.WriteLine("I am a Doctor.");
        }

        public override void Display()
        {
            Console.WriteLine(
                $"ID: {id}, Name: {name}, Age: {age}, Specialty: {Specialty}"
            );
        }
    }
}
