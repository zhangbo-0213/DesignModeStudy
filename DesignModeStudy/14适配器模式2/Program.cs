using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14适配器模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player guards = new Guards("麦迪");
            guards.Attack();
            guards.Defense();

            Player center = new Translator("姚明");
            center.Attack();
            center.Defense();

            Console.ReadKey();
        }
    }
}
