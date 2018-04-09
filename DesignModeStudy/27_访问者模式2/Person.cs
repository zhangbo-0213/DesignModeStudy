using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_访问者模式2
{
    public abstract class Person
    {
        public abstract void Accept(Action action);
    }
}
