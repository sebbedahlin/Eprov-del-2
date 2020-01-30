using System;
using System.Collections.Generic;
using System.Text;

namespace Eprov_del_2
{
    class ContrabandCar : Car
    {
        public ContrabandCar()
        {
            passengers = 1 - 4;
            contrabandAmount = 1 - 4;
        }
    }
}
