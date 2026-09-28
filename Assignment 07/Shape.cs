using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_07
{
    internal class Shape:Imoveabel
    {
        public double width { get; set; }
        public double hight { get; set; }

        public Shape(double Width , double Hight)
        {
            width = Width;
            hight = Hight;
        }

        public double GetArea()
        {
            return (width * hight);
        }

        override public string ToString()
        {
            return $"Width: {width}, Hight: {hight} ";
        }

         void Imoveabel.MoveForword()
        {
            Console.WriteLine("Car Move Forword on the sea ");
        }

        public void MoveBackword()
        {
            Console.WriteLine("Car Move Backword on the sea ");
        }
    }
}
