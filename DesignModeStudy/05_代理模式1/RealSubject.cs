using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_代理模式1
{
    public class RealSubject : Subject
    {
        public void Request()
        {
            Console.WriteLine("被代理对象的真实请求");
        }
    }
}
