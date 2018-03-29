using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_命令模式2
{
    public class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer barbecuer) :base(barbecuer){ }
        public override void ExecuteCommand()
        {
            receicer.BakeChickenWing();
        }
    }
}
