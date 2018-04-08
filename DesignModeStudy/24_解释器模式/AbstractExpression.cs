using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_解释器模式
{
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}
