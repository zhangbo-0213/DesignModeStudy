using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_建造者模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarVehicle carVehicle = new CarVehicle();
            MotorVehicle motorVehicle = new MotorVehicle();
            Shop shop = new Shop();

            shop.Construct(carVehicle);
            carVehicle.Vehicle.Show();

            shop.Construct(motorVehicle);
            motorVehicle.Vehicle.Show();

            Console.ReadKey();
        }
    }
}
