using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_07
{
    internal class Cube : Shape
    {
        public double depth { get; set; }
        public Cube(double Width, double Hight,double Depth) : base(Width, Hight)
        {
            depth = Depth;
        }

        public new double GetArea() //word "new" is used to hide the base class method with the same name
        {
            return base.GetArea() * depth;
        }


    }
}
