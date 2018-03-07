using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_状态模式2
{
    public class SleepingState : State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine("当前时间：{0} 不行了，睡着了",work.Hour);
        }
    }
}
