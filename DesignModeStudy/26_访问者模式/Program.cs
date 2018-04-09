using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_访问者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure o = new ObjectStructure();
            o.Add(new ConcreteElementA());
            o.Add(new ConcreteElementB());

            ConcreteVisitorA concreteVisitorA = new ConcreteVisitorA();
            ConcreteVisitorB concreteVisitorB = new ConcreteVisitorB();

            o.Accept(concreteVisitorA);
            o.Accept(concreteVisitorB);

            Console.ReadKey();
        }
    }
}
