using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_模板方法模式
{
    public abstract class AbstractClass
    {
        //抽象行为，放到子类中去实现
        public abstract void PrimitiveOperationA();
        public abstract void PrimitiveOperationB();

        //模板方法，给出逻辑的骨架，逻辑的组成是由相应的抽象操作完成，推迟到子类实现
        public void TempelateMethod() {
            PrimitiveOperationA();
            PrimitiveOperationB();
            Console.WriteLine("");
        }
    }
}
