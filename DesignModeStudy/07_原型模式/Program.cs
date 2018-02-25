using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototypeA a = new ConcretePrototypeA("I");
            ConcretePrototypeA a2 = a.Clone() as ConcretePrototypeA;

            ConcretePrototypeB b = new ConcretePrototypeB("II");
            ConcretePrototypeB b2 = b.Clone() as ConcretePrototypeB;

            Console.ReadKey();
        }
    }
}
