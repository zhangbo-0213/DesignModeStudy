using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_模板方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass A = new ConcreteClassA();
            A.TempelateMethod();
            AbstractClass B = new ConcreteClassB();
            B.TempelateMethod();

            Console.ReadKey();
        }
    }
}
