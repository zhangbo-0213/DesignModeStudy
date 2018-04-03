using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_中介者模式
{
    public class ConcreteColleague1:Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator) { }

        public void Send(string message) {
            mediator.Send(message, this);
        }

        public void Notify(string message) {
            Console.WriteLine("{0} 收到消息：{1}",this.GetType().Name,message);
        }
    }
}
