using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_建造者模式2
{
    public class MotorVehicle : VehicleBuild
    {
        public MotorVehicle() {
            vehicle = new Vehicle("Motor");
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "none";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "Motor Engine";
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "Motor Frame";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }
    }
}
