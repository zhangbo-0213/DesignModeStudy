using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_原型模式
{
    public class ConcretePrototypeA : Prototype
    {
        public ConcretePrototypeA(string id) : base(id) {

        }
        public override Prototype Clone()
        {
            Console.WriteLine("Made copy of ConcretePrototypeA");
            return this.MemberwiseClone() as Prototype;
        }
    }
}
