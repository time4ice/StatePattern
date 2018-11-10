using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar
{
    class Turn : DirectionState
    {
        private static Turn currstatus = new Turn();
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
                throw new Exception("Cant turn from one side to another! Driver should align the car first!");
            }
        }

        public void streight(Сar car)
        {
            if (car.speed == 0) throw new Exception("Car is stoped! Cant right!");
            car.xchange = 0;
            car.fuelper100 -= 0.1;
            car.ChangeDirection(Front.ReturnStatus);
        }
    }
}
