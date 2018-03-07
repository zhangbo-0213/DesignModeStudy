using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_适配器模式
{
    public  class Target
    {
        public virtual void Request() {
            Console.WriteLine("普通请求！");
        }
    }
}
