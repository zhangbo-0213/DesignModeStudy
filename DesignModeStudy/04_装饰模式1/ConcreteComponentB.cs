using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_装饰模式1
{
    public class ConcreteComponentB:Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("具体装饰对象B操作");
            AddBehavior();        
        }

        private void AddBehavior() {
            Console.WriteLine("具体装饰对象B的特有方法");
        }
    }
}
