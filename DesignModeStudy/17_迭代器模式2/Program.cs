using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_迭代器模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors= { "red", "green", "blue" };
            IEnumerable1<string> Colors = new IEnumerable1<string>(colors);

            foreach (var color in Colors) {
                Console.WriteLine(color);
            }

            Console.ReadKey();
        }
    }
}
