using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_访问者模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure o = new ObjectStructure();
            o.Add(new Man());
            o.Add(new Woman());

            Success success = new Success();
            Amativeness amativeness = new Amativeness();

            o.Display(success);
            o.Display(amativeness);

            Console.ReadKey();
        }
    }
}
