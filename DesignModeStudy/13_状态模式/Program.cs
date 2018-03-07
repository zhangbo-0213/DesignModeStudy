using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_状态模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ConcreteStateA());

            //不断切换自身状态
            context.Request();
            context.Request();
            context.Request();
            context.Request();

            Console.ReadKey();
        }
    }
}
