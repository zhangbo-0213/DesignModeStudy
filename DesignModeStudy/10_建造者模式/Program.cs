using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            ConcreteBulider1 concreteBulider1 = new ConcreteBulider1();
            ConcreteBuilder2 concreteBuilder2 = new ConcreteBuilder2();

            director.Construct(concreteBulider1);
            Product product = concreteBulider1.GetProduct();
            product.Show();

            director.Construct(concreteBuilder2);
            Product product2 = concreteBuilder2.GetProduct();
            product2.Show();

            Console.ReadKey();
        }
    }
}
