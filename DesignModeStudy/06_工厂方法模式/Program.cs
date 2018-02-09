using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_工厂方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory[] factorys = new IFactory[2];
    
            factorys[0] = new FactoryProductA();
            factorys[1] = new FactoryProductB();

            foreach (IFactory factory in factorys) {
                Product product=factory.CreateProduct();
                product.AboutProduct();
            }

            Console.ReadKey();
        }
    }
}
