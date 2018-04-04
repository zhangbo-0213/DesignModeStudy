using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_享元模式
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicstate = 20;
            FlyweightFactory flyweightFactory = new FlyweightFactory();

            Flyweight fx = flyweightFactory.GetFlyweight("X");
            fx.Operation(extrinsicstate);

            Flyweight fy = flyweightFactory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = flyweightFactory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);
            Flyweight fz2 = flyweightFactory.GetFlyweight("Z");
            fz2.Operation(--extrinsicstate);

            UnsharedFlyweight unsharedFlyweight = new UnsharedFlyweight();
            unsharedFlyweight.Operation(--extrinsicstate);

            Console.ReadKey();

        }
    }
}
