using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar
{
    class MotorOn : CarState
    {
        private static MotorOn currstatus = new MotorOn();
        public static CarState ReturnStatus
        {
            get { return currstatus; }
        }
        public void Start(Сar car)
        {
            throw new Exception("Motor is already working!");
        }
        public void Stop(Сar car)
        {
            if (car.speed == 0)
            {
                car.isMotorOn = false;
                car.ChangeState(MotorOff.ReturnStatus);
            }
            else
            {
                throw new Exception($"Beffore stopping the car, make its speed being 0! Now speed is {car.speed}.");
            }
        }
        public void Speed(Сar car, double speed)
        {
            if (speed >= 0)
            {
                car.speed = speed;
                if (speed == 0) car.fuelper100 = 0;
                else
                    car.fuelper100 = 6 + (Math.Abs(100 - speed)*0.01);

            }
            else
            {
                throw new Exception("Speed is not changed. It can't be less then 0.");
            }
        }
    }

}