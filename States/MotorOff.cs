using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar
{
    class MotorOff : CarState
    {
        private static MotorOff currstatus = new MotorOff();
        public static CarState ReturnStatus
        {
            get { return currstatus; }
        }
        public void Start(Сar car)
        {
            car.isMotorOn = true;
            car.ChangeState(MotorOn.ReturnStatus);
        }
        public void Stop(Сar c)
        {
            throw new Exception("Car is already stoped!");
        }
        public void Speed(Сar c, double speed)
        {
            throw new Exception("Car is not riding at the moment, speed can't be changed!");
        }
    }
}
