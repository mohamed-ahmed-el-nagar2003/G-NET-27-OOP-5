using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05_OOP_Interface
{
    internal class Projector
    {

        public bool ison { get; private set; } = false;

        public void turnOn()
        {
            ison = true;
            Console.WriteLine("Projector Started");
        }

        public void turnOff()
        {
            ison = false;
            Console.WriteLine("Projector is Turn Off");
        }


    }
}
