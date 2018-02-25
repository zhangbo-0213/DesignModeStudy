using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_原型模式
{
    public class ConcretePrototypeB : Prototype
    {
        public ConcretePrototypeB(string id) : base(id) {

        }
        public override Prototype Clone()
        {
            Console.WriteLine("Made copy of ConcretePrototypeB");
            return this.MemberwiseClone() as Prototype;
        }
    }
}
