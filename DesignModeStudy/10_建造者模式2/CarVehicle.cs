using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_建造者模式2
{
    public class CarVehicle : VehicleBuild
    {
        public CarVehicle() {
            vehicle = new Vehicle("Car");
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "4";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "Car Engine";
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "Car Engine";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }
    }
}
