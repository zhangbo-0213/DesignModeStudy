using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_建造者模式2
{
    public abstract class VehicleBuild
    {
        protected Vehicle vehicle;
        public Vehicle Vehicle {
            get { return vehicle; }
        }
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
