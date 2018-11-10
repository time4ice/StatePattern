using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar
{
    public class Сar
    {
        private CarState state;
        private DirectionState direction;
        internal double speed;
        internal bool isMotorOn;
        internal int xchange;
        internal double fuelper100;
        public Сar()
        {

            speed = 0;
            xchange = 0;
            fuelper100 = 0;
            isMotorOn = false;
            ChangeState(MotorOff.ReturnStatus);
            ChangeDirection(Front.ReturnStatus);

        }
        public double Speed
        {
            get { return speed; }
        }
        public void OnMotor()
        {
            state.Start(this);
        }
        public void OffMotor()
        {
            state.Stop(this);
        }

        public void TurnRight()
        {
            direction.turn(this, 1);
        }

        public void TurnLeft()
        {
            direction.turn(this, -1);
        }

        public void RideStreight()
        {
            direction.streight(this);
        }

        public void ChangeSpeed(double speed)
        {
            state.Speed(this, speed);
        }
        internal void ChangeState(CarState newState)
        {
            state = newState;
        }

        internal void ChangeDirection(DirectionState newDirection)
        {
            direction = newDirection;
        }

        public String CarInfo()
        {
            String turn="" ;
            String ison="" ;
            if (isMotorOn == false) ison = "Motor is off. ";
            else
                ison = "Motor is On. ";
            if (speed != 0)
            {
                if (xchange == 0) turn = "Car rides streight. ";
                if (xchange == -1) turn = "Car turns left. ";
                if (xchange == 1) turn = "Car turns right. ";
            }
            return ison + "Speed is " + speed + ". Fuel for 100 km: " + fuelper100 + ". " + turn;

        }

        public bool Exit()
        {
            return !isMotorOn;
        }
    }
}


