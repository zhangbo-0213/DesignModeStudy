using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_桥接模式
{
    public abstract class Abstraction
    {
        protected Implementor implementor;

        public void SetImplementor(Implementor implementor) {
            this.implementor = implementor;
        }

        public virtual void Operation() {
            implementor.Operation();
        }
    }
}
