using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Assignment_07
{
    internal class Engineer : Person
    {
        public string Field { get; set; }
        public int YearsOfExperience { get; set; }

        public new void Greet()
        {
            Console.WriteLine("I am an Engineer.");
        }

        public override void Display()
        {
            Console.WriteLine(
                $"ID: {id}, Name: {name}, Age: {age}, " +
                $"Field: {Field}, Years of Experience: {YearsOfExperience}"
            );
        }
    }
}
