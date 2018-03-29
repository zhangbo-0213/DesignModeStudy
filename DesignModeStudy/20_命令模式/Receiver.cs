using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_命令模式
{
    //对应命令的实施类，知道如何实施与执行一个请求相关的操作，任何类都有可能成为一个接收者
    public class Receiver
    {
        public void Action() {
            Console.WriteLine("执行请求！");
        }
    }
}
