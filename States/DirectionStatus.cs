using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar
{
    interface DirectionState
    {
        void turn(Сar car, int x);
        void streight(Сar car);
    }


}