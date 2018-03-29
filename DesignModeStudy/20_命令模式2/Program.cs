using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_命令模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            Waiter waiter = new Waiter();
            Barbecuer barbecuer = new Barbecuer();
            MakeMuttonCommand m1 = new MakeMuttonCommand(barbecuer);
            MakeMuttonCommand m2 = new MakeMuttonCommand(barbecuer);
            BakeChickenWingCommand chicken = new BakeChickenWingCommand(barbecuer);

            waiter.SetOrder(m1);
            waiter.SetOrder(m2);
            waiter.SetOrder(chicken);

            waiter.CancleOrder(m2);

            waiter.Notify();

            Console.ReadKey();

        }
    }
}
