using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中介者模式2
{
    public class Iraq:Country
    {
        public Iraq(UnitedNations unitedNations) : base(unitedNations)
        {

        }

        public void Send(string message)
        {
            unitedNations.Declare(message, this);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine("{0} 获得信息: {1}", this.GetType().Name, message);
        }
    }
}
