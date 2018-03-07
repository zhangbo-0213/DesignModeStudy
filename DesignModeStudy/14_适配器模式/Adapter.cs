using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_适配器模式
{
    public class Adapter:Target
    {
        private Adapee adapee=new Adapee();
        public override void Request()
        {
            adapee.SpecificRequest();
        }
    }
}
