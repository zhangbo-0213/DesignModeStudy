using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_装饰模式1
{

    //Component定义一个对象接口，可以动态给对象添加功能。
    //ConcreteComponent是一个实体对象，也可以为这个对象添加职责。
    //Decorator，装饰的抽象类，继承了Component，Component（或者说ConcreteComponent）通过装饰抽象类来进行功能的扩展，
    //对于Component类来说并不需要知道Decorator的存在。ConcreteDecorator具体的起装饰作用的对象，为Component添加功能

    //装饰模式，动态给对象添加一些额外的职责，就增加功能来说，装饰模式比生成子类更加灵活。   
    //通过继承产生的特定的装饰对象对实体对象进行装饰和扩展
    //多层的装饰是通过重写装饰基类的装饰方法和调用基类的装饰方法实现，基类的装饰方法中管理和引用一个Component的实例
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent cc = new ConcreteComponent();
            ConcreteComponentA cca = new ConcreteComponentA();
            ConcreteComponentB ccb = new ConcreteComponentB();

            //对ConcreteComponent对象进行层层装饰
            cca.SetComponent(cc);
            ccb.SetComponent(cca);

            ccb.Operation();

            Console.ReadKey();
        }
    }
}
