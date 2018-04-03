using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_职责链模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteHanlder1 concreteHanlder1 = new ConcreteHanlder1();
            ConcreteHandler2 concreteHandler2 = new ConcreteHandler2();
            ConcreteHandler3 concreteHandler3 = new ConcreteHandler3();

            concreteHanlder1.SetHandler(concreteHandler2);
            concreteHandler2.SetHandler(concreteHandler3);

            int[] requests = { 2, 5, 14, 26, 18, 7, 27, 20 };

            foreach (int i in requests) {
                concreteHanlder1.HandlerRequest(i);
            }

            Console.ReadKey();
        }
    }
}
