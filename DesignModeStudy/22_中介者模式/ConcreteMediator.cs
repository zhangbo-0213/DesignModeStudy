using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_中介者模式
{
    public class ConcreteMediator : Mediator
    {
        protected ConcreteColleague1 concreteColleague1;
        protected ConcreteColleague2 concreteColleague2;

        public ConcreteColleague1 ConcreteColleague1 {
            set { this.concreteColleague1 = value; }
        }

        public ConcreteColleague2 ConcreteColleague2 {
            set { this.concreteColleague2 = value; }
        }
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == concreteColleague1)
            {
                concreteColleague2.Notify(message);
            }
            else {
                concreteColleague1.Notify(message);
            }
        }
    }
}
