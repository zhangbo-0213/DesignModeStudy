using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_建造者模式2
{
    public class Vehicle
    {
        private string vehicleType;
        private Dictionary<string, string> vehicleInfo = new Dictionary<string, string>();

        public Vehicle(string vehicleType) {
            this.vehicleType = vehicleType;
        }

        public string this[string key] {
            get { return vehicleInfo[key]; }
            set { vehicleInfo[key] = value; }
        }

        public void Show() {
            Console.WriteLine("VehicleType:{0}",vehicleType);
            Console.WriteLine("Frame:{0}",vehicleInfo["frame"]);
            Console.WriteLine("Engine:{0}", vehicleInfo["engine"]);
            Console.WriteLine("Wheels:{0}",vehicleInfo["wheels"]);
            Console.WriteLine("Doors:{0}",vehicleInfo["doors"]);
        }
    }
}
