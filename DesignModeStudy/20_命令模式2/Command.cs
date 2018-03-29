using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_命令模式2
{
    public abstract class Command
    {
        protected Barbecuer receicer;
        public Command(Barbecuer receiver) {
            this.receicer = receiver;
        }

        public abstract void ExecuteCommand();
    }
}
