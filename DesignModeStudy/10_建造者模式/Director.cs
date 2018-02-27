using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_建造者模式
{
    public class Director
    {
        public void Construct(Builder builder) {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
