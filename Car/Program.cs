using System;

namespace MyCar
{

    class Program
    {
        static void Main(string[] args)
        {
            Сar mycar = new Сar();
            String cond;
            bool cicle = true;
            Console.WriteLine("-------------Menu----------------");
            Console.WriteLine("1.On the motor.");
            Console.WriteLine("2.Off the motor.");
            Console.WriteLine("3.Turn.");
            Console.WriteLine("4.Ride streight.");
            Console.WriteLine("5.Change speed.");
            Console.WriteLine("6.Close.");
            Console.Write("Input function num: ");
            cond = Console.ReadLine();
            while (cicle == true)
            {
                if (cond == "1")
                {
                    try
                    {
                        mycar.OnMotor();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                if (cond == "2")
                {
                    try
                    {
                        mycar.OffMotor();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                if (cond == "3")
                {
                    String turncond;
                    Console.Write("Input direction. 1 for left, 2 for right: ");
                    turncond = Console.ReadLine();

                    try
                    {
                        if (turncond == "1") mycar.TurnLeft();
                        else mycar.TurnRight();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                if (cond == "4")
                {
                    try
                    {
                        mycar.RideStreight();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                if (cond == "5")
                {
                    double speed;
                    Console.Write("Input speed: ");
                    speed = double.Parse(Console.ReadLine());
                    try
                    {
                        mycar.ChangeSpeed(speed);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                if (cond == "6")
                {
                    if (mycar.Exit() == true) break;
                    else Console.WriteLine("Before exiting turn off the motor!");
                }
                Console.WriteLine(mycar.CarInfo());
                Console.Write("Input function num: ");
                cond = Console.ReadLine();
            }

              
        }
    }

}
