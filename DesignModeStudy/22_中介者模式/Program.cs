using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_中介者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator concreteMediator = new ConcreteMediator();

            ConcreteColleague1 concreteColleague1 = new ConcreteColleague1(concreteMediator);
            ConcreteColleague2 concreteColleague2 = new ConcreteColleague2(concreteMediator);

            concreteMediator.ConcreteColleague1 = concreteColleague1;
            concreteMediator.ConcreteColleague2 = concreteColleague2;

            concreteColleague1.Send("我想你了");
            concreteColleague2.Send("我没钱了");

            Console.ReadKey();
        }
    }
}
