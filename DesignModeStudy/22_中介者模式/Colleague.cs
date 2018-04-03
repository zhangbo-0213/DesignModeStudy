using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_中介者模式
{
    public abstract class Colleague
    {
        protected Mediator mediator;
        public Colleague(Mediator mediator) {
            this.mediator = mediator;
        }
    }
}
