using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//代理模式：为其它对象提供代理对象来控制对该对象的访问
//代理类通过实现和被代理类完全相同的接口并管理一个被代理类的实例，使在使用被代理对象的地方完全替代被代理对象。
namespace _05_代理模式1
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Request();

            Console.ReadKey();
        }
    }
}
