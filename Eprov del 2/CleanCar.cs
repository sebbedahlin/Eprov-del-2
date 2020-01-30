using System;
using System.Collections.Generic;
using System.Text;

namespace Eprov_del_2
{
    class CleanCar : Car
    {
        public CleanCar()
        {
            passengers = 1 - 3;
            contrabandAmount = 0;
        }
    }
}
