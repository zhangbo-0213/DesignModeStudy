using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_命令模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            invoker.SetCommand(new ConcreteCommand(receiver));

            invoker.ExecuteCommand();

            Console.ReadKey();
        }
    }
}
