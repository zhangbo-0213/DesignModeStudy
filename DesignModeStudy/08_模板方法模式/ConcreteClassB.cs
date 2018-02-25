using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_模板方法模式
{
    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperationA()
        {
            Console.WriteLine("具体类B方法1实现");
        }

        public override void PrimitiveOperationB()
        {
            Console.WriteLine("具体类B方法2实现");
        }
    }
}
