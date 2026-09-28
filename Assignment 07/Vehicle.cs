using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_07
{
    internal class Vehicle : Ivehicle
    {

        void Imoveabel.MoveForword()
        {
            Console.WriteLine("Vehicle Move Forword on the road ");
        }

        void Imoveabel.MoveBackword()
        {
            Console.WriteLine("Vehicle Move Backword on the road ");
        }

        void Iflyable.MoveUp()
        {
            throw new NotImplementedException();
        }

        void Iflyable.MoveDown()
        {
            throw new NotImplementedException();
        }
    }
}
