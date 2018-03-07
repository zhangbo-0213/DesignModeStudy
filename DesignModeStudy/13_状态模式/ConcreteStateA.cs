using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_状态模式
{
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State=new ConcreteStateB();
        }
    }
}
