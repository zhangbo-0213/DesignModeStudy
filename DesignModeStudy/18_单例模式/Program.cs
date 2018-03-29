using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstace();
            Singleton s2 = Singleton.GetInstace();
            if (s1 == s2)
                Console.WriteLine("S1和S2是同一个实例");

            Console.ReadKey();                                                                     
        }
    }
}
