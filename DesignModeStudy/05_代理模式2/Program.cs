using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_代理模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            MathProxy mathProxy = new MathProxy();
            Console.WriteLine("4+2={0}", mathProxy.Add(4, 2));
            Console.WriteLine("4-2={0}", mathProxy.Sub(4, 2));
            Console.WriteLine("4*2={0}", mathProxy.Mul(4, 2));
            Console.WriteLine("4/2={0}", mathProxy.Div(4, 2));

            Console.ReadKey();
        }
    }
}
