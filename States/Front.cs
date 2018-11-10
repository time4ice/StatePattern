using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar
{
    class Front : DirectionState
    {
        private static Front currstatus = new Front();
        public static DirectionState ReturnStatus
        {
            get { return currstatus; }
        }

        public void turn(Сar car, int x)
        {

            if (car.speed == 0) throw new Exception("Car is stoped! Cant turn!");
            if (car.xchange == x) throw new Exception("Car's direction is already this!");
            else
            {
                car.xchange = x;
                car.ChangeDirection(Turn.ReturnStatus);
                car.fuelper100 += 0.1;
            }
        }

        public void streight(Сar car)
        {
            if (car.speed == 0) throw new Exception("Car is stoped! Can't ride!");
            throw new Exception("Car is allready riding stright!");
        }
    }
}
