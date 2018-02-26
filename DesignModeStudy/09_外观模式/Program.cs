using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_外观模式
{
    //外观模式为子系统中的一组接口提供一致的界面，该模式定义一个高层接口，使子系统使用更加方便
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();

            Console.ReadKey();
        }
    }
}
