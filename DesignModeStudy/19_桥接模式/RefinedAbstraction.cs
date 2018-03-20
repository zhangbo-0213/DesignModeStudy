using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_桥接模式
{
    public class RefinedAbstraction:Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
