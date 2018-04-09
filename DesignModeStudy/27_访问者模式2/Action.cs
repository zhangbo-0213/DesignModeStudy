using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_访问者模式2
{
    public abstract class Action
    {
        public abstract void GetManConclusion(Man man);
        public abstract void GetWomanConclusion(Woman woman);
    }
}
