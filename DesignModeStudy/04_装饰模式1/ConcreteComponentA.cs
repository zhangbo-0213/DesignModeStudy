using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_装饰模式1
{
    public class ConcreteComponentA:Decorator
    {
        private string addState; //ConcreteComponentA该类自身功能，区别其他具体装饰类
        public override void Operation()
        {
            //先执行原Component的Operation(),再执行自身特有功能，相当于对原Component进行装饰
            base.Operation();
            addState = "New State";
            Console.WriteLine("具体装饰对象A操作");
            Console.WriteLine("具体装饰对象A的新状态：{0}",addState);
        }
    }
}
