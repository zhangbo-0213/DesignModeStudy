using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_命令模式2
{
    public class MakeMuttonCommand : Command
    {
        public MakeMuttonCommand(Barbecuer receiver) : base(receiver) { }
        public override void ExecuteCommand()
        {
            receicer.MakeMutton();
        }
    }
}
