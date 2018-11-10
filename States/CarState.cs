using System;
using System.Collections.Generic;
using System.Text;


namespace MyCar
{
    interface CarState
    {
        void Start(Сar сar);
        void Stop(Сar сar);
        void Speed(Сar сar, double speed);
    }
}
