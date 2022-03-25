using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IVehicle
    {
        void Drive();
        bool Refuel(int gasQty);
    }

    class car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("I'm driving");
        }

        public bool Refuel(int gasQty)
        {
            if (gasQty > 0)
                Drive();
            else
                Console.WriteLine("Refueling you car");
                gasQty = gasQty + 10;
                Console.WriteLine("Your car has " + gasQty + "litre left");

            return true;
        }
    }
}
