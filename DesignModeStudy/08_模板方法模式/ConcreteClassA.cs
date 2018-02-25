using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_模板方法模式
{
    public class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperationA()
        {
            Console.WriteLine("具体类A方法1实现");
        }

        public override void PrimitiveOperationB()
        {
            Console.WriteLine("具体类A方法2实现");
        }
    }
}
