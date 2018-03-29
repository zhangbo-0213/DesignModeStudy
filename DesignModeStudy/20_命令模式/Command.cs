using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_命令模式
{
    public abstract class Command
    {
        protected Receiver receiver;
        public Command(Receiver receiver) {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}
