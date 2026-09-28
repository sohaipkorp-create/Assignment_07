using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_07
{
    internal class Airplan:Imoveabel, Iflyable
    {
        public void MoveForword()
        {
            Console.WriteLine("Airplan Move Forword on the air ");
        }

        public void MoveBackword()
        {
            Console.WriteLine("Airplan Move Backword on the air ");
        }

        public void MoveUp()
        {
            Console.WriteLine("Airplan Move Forword on the air ");
        }

        public void MoveDown()
        {
            Console.WriteLine("Airplan Move Backword on the air ");
        }
    }

}
