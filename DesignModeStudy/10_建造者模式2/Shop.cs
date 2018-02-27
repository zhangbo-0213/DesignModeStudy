using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_建造者模式2
{
    public class Shop
    {
        public void Construct(VehicleBuild vehicleBuild) {
            vehicleBuild.BuildFrame();
            vehicleBuild.BuildEngine();
            vehicleBuild.BuildWheels();
            vehicleBuild.BuildDoors();
        }
    }
}
