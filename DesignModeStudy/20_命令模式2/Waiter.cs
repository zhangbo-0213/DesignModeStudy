using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_命令模式2
{
    public class Waiter
    {
        private IList<Command> commands = new List<Command>();

        public void SetOrder(Command command) {
            if (command.ToString() == "_20_命令模式2.BakeChickenWingCommand")
            {
                Console.WriteLine("服务员：鸡翅膀没有了，换别的吧！");
            }
            else {
                commands.Add(command);
                Console.WriteLine("下单:"+command.ToString()+"时间："+DateTime.Now.ToString());
            }
        }

        public void CancleOrder(Command command) {
            if (commands.IndexOf(command) == -1)
            {
                Console.WriteLine("未下单");
            }
            else {
                commands.Remove(command);
                Console.WriteLine("取消订单:" + command.ToString() + "时间：" + DateTime.Now.ToString());
            }
        }

        public void Notify() {
            foreach (Command command in commands) {
                command.ExecuteCommand();
            }
        }
    }
}
